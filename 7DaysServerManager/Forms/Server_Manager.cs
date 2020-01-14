using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using Microsoft.Win32;
using System.Xml;
using System.Resources;
using MySql.Data.MySqlClient;
using Ionic.Zip;
using System.Text.RegularExpressions;
using System.Net;
using System.Linq;
using Syncfusion.Windows.Forms.Tools;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _7DaysServerManager
{
    public partial class Server_Panel_Form : Form
    {
        //Build Lists and Queues
        //List<string> players_ids = new List<string>();
        Queue<string> telnet_queue = new Queue<string>();

        // Version Variables
        public const string ver = "9.2";
        public const bool dev = false;
        public const string game_ver = "Alpha 18.3";
        public const string whatsnew = "Whats new since last STABLE build:\n-Updated To Work With v18.x\n-Added New Visual CPU/RAM/Toggles\n-Over 381 Other Fixes";

        // Registry Variables
        readonly string base_registry_key = @"HKEY_CURRENT_USER\Software\7DSM\";

        // Debug Settings
        bool debug_mode = false;
        readonly bool enable_autoreboot = true; //!! DEBUG ONLY, This Will Corrupt The Server Pointer, So Keep It Set To True!

        // Text Formatting Variables
        string console_pre = "\n";
        string chat_pre = "\n";

        public bool server_online = false;
        bool break_telnet = false;
        bool premium = false;
        bool webserver_running = false;

        string file_path, telnet_NOW = "null", reply_telnet, reply_lp="";
        readonly string translation_error_c = "";

        string all_exes = "init-0-Server"; //Performance Custom Commands

        string profile_name = "Default";
        bool just_killin = false;

        bool file_log = false;

        bool icons_moved = false;

        bool updater_invoked_manually = false;

        readonly int console_offset = 100000;

        bool selected_player_list_offline = false;

        FileStream main_log_stream;
        StreamWriter main_log;

        FileStream chat_log_stream;
        StreamWriter chat_log;


        List<string> allowed_players = new List<string>();

        TelnetConnection tc = null;


        internal static class AssemblyCreationDate
        {
            public static readonly DateTime Value;

            static AssemblyCreationDate()
            {
                Version version = Assembly.GetExecutingAssembly().GetName().Version;
                Value = new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.MinorRevision * 2);
            }
        }

        public Server_Panel_Form()
        {
            /*Charging Internal Distances?*/
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };

            InitializeComponent();
        }

        public void Echo(string text, int color, bool enter)
        {
            Console_RichTextBox.Invoke((MethodInvoker)delegate
            {

                Console_RichTextBox.SelectionStart = Console_RichTextBox.Text.Length;
                Console_RichTextBox.ScrollToCaret();

                if (color == 4)
                    Console_RichTextBox.SelectionColor = Color.LightGray;
                if (color == 3)
                    Console_RichTextBox.SelectionColor = Color.Red;
                if (color == 2)
                    Console_RichTextBox.SelectionColor = Color.Orange;
                if (color == 1)
                    Console_RichTextBox.SelectionColor = Color.Lime;

                if (enter == true)
                    Console_RichTextBox.SelectedText = text + "\n";
                else
                    Console_RichTextBox.SelectedText = text;

                Console_RichTextBox.SelectionStart = Console_RichTextBox.Text.Length;
                Console_RichTextBox.ScrollToCaret();
            });

        }

        public void Echo_chat(string text, bool color)
        {
            Chat_RichTextBox.Invoke((MethodInvoker)delegate
            {

                Chat_RichTextBox.SelectionStart = Chat_RichTextBox.Text.Length;
                Chat_RichTextBox.ScrollToCaret();

                if (color)
                    Chat_RichTextBox.SelectionColor = Color.Orange;
                else
                    Chat_RichTextBox.SelectionColor = Color.LightGray;

                Chat_RichTextBox.SelectedText = text + "\n";


                Chat_RichTextBox.SelectionStart = Chat_RichTextBox.Text.Length;
                Chat_RichTextBox.ScrollToCaret();
            });

        }

        public void Echo_debug(string text)
        {
            try
            {
                if (file_log)
                    File.AppendAllText("7DSM_DEBUG.LOG", DateTime.Now.ToString() + ": " + text + Environment.NewLine);
                Console.WriteLine(text);
            }
            catch { }
        }

        public void Echo_news(string text, int color)
        {
            News_Feed_RichTextBox.Invoke((MethodInvoker)delegate
            {
                News_Feed_RichTextBox.Text = text;

                if(color!=0)
                {
                    News_Feed_RichTextBox.BackColor = Color.FromArgb(255, 224, 192);
                }
            });
        }

        public bool Player_is_listed(ListViewItem lvi)
        {
            foreach (ListViewItem item in Online_Player_List.Items)
            {
                bool subItemEqualFlag = true;
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    string sub1 = item.SubItems[i].Text;
                    string sub2 = lvi.SubItems[i].Text;
                    if (sub1 != sub2)
                    {
                        subItemEqualFlag = false;
                    }
                }
                if (subItemEqualFlag)
                    return true;
            }

            return false;

        }

        public bool Player_big_list(ListViewItem lvi)
        {
            foreach (ListViewItem item in All_Players_List.Items)
            {
                bool subItemEqualFlag = true;
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    string sub1 = item.SubItems[i].Text;
                    string sub2 = lvi.SubItems[i].Text;
                    if (sub1 != sub2)
                    {
                        subItemEqualFlag = false;
                    }
                }
                if (subItemEqualFlag)
                    return true;
            }

            return false;

        }

        public void Download_maps(string selected_map)
        {
            ConfigProperty_GameName.Items.Clear();

            try
            {
                string sci = "";
                if (ConfigProperty_SaveGameFolder.Text == "")
                {
                    sci = Environment.GetEnvironmentVariable("userprofile") + "\\Documents\\7 Days To Die\\Saves\\" + selected_map + "\\";

                }
                else
                {
                    sci = ConfigProperty_SaveGameFolder.Text;
                }

                string[] wszystkie_mapy = System.IO.Directory.GetDirectories(@sci, "*", System.IO.SearchOption.TopDirectoryOnly);

                foreach (string dany_save in wszystkie_mapy)
                {
                    ConfigProperty_GameName.Items.Add(dany_save.Replace(sci, "").Replace("\\", ""));
                }
            }
            catch { }
        }

        private void Start_Server_Button_Click(object sender, EventArgs e)
        {
            Run_Server();
        }


        private void IsProcessRunning(string sProcessName)
        {

            Process[] proc = Process.GetProcessesByName("7DaysToDie");
            Process[] proc2 = Process.GetProcessesByName("7DaysToDieServer");

            if (proc.Length > 0 || proc2.Length > 0)
            {
                status.Invoke((MethodInvoker)delegate
                {
                    status.Text = "Server: ONLINE";


                    if (tc != null && tc.IsConnected)
                    {
                        if (sProcessName == "7DaysToDieServer")
                            img_status.Image = Properties.Resources.status_ok_dedi;
                        else
                            img_status.Image = Properties.Resources.status_ok;
                    }
                    else
                    {
                        img_status.Image = Properties.Resources.status_not_connected;
                    }
                    if (server_online == false)
                        Connect_Running_Server_Button.Enabled = true;
                    else
                        Connect_Running_Server_Button.Enabled = false;

                });
            }
            else
            {
                if (enable_autoreboot)
                {
                    status.Invoke((MethodInvoker)delegate
                    {
                        Connect_Running_Server_Button.Enabled = false;
                        status.Text = "Server: OFFLINE";
                        Unlock_Panel_Controls();
                        img_status.Image = Properties.Resources.status_stopped;

                        if (server_online == true)
                        {
                            Thread.Sleep(500);
                            //restart crasha
                            Echo("Server crashed... Restarting...", 2, true);

                            Thread.Sleep(5000);

                            Start_Server_Button_Click(null, null);
                        }
                    });
                }
            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            // Retrieve Server Info
            status.Invoke((MethodInvoker)delegate
            {
                status.Text = "Server: OFFLINE";
                OS_Version_Label.Text = "OS: "+Convert.ToString(System.Environment.OSVersion);

                if (Environment.Is64BitOperatingSystem)
                    OS_Architecture_Label.Text = "OS Architecture: 64bit (x64)";
                else
                {
                    OS_Architecture_Label.BackColor = Color.FromArgb(255, 178, 102);
                    OS_Architecture_Label.Text = "OS Architecture: 32bit (x86): Update To 64bit Recommended!";
                }

            });

            // Init Dedicated Server Variable
            bool dedicated_server = false;
            
            // If This Is A 7 Days To Die Server Profile, Check Service Statuses
            if ((string)Registry.GetValue(base_registry_key + profile_name, "server_type", null) == "server")
                // Mark Server As A Dedicated Server
                dedicated_server = true;

            while (true)
            {

                if (tc!=null)
                {
                    status.Invoke((MethodInvoker)delegate
                    {
                        telnetstatus.Text = "Telnet: UP";
                    });
                }
                else
                {
                    status.Invoke((MethodInvoker)delegate
                    {
                        telnetstatus.Text = "Telnet: DOWN";
                    });
                }

                if (dedicated_server)
                    // Look For The Dedicated Server Binary
                    IsProcessRunning("7DaysToDieServer");
                else
                    // Look For The Regular 7 days To Die Binary
                    IsProcessRunning("7DaysToDie");

                Thread.Sleep(2000);
            }

        }

        private void Server_panel_Load(object sender, EventArgs e)
        {
            //tabControl.TabPages.Remove(WebServer); //!!

            //srv_list.Dispose();

            // Import Header Icons
            Header_Icons.Images.Add(Properties.Resources.globe);
            Header_Icons.Images.Add(Properties.Resources.math);
            Header_Icons.Images.Add(Properties.Resources.database);
            Header_Icons.Images.Add(Properties.Resources.edit);
            Header_Icons.Images.Add(Properties.Resources.tools);
            Header_Icons.Images.Add(Properties.Resources.dbi);
            Header_Icons.Images.Add(Properties.Resources.dice);
            Header_Icons.Images.Add(Properties.Resources.sch_tasks);
            Header_Icons.Images.Add(Properties.Resources.backup);
            Header_Icons.Images.Add(Properties.Resources.rate);
            Header_Icons.Images.Add(Properties.Resources.shield);
            Header_Icons.Images.Add(Properties.Resources.firefox);
            Header_Icons.Images.Add(Properties.Resources.net);

            // Retrieve and Assign The Server Profile Name
            profile_name = (string)Registry.GetValue(base_registry_key, "last_profile", null);
            string profile_registry_key = @"HKEY_CURRENT_USER\Software\7DSM\" + profile_name;

            Prepare_app_after_start();
        }

        private void Telnet_Click(object sender, EventArgs e)
        {
            About o_programie = new About();
            o_programie.Show();
        }

        private void Server_Panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _listener.Stop();
            }
            catch { }

            try
            {
                _listener.Close();
            }
            catch { }

            main_log.Close();
            main_log_stream.Close();

            chat_log.Close();
            chat_log_stream.Close();

            if (server_online == true && Settings_Clean_Exit_CheckBox.Checked)
            {
                Echo("Close window request", 2, false);
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to turn the server off?", "Close window request", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Stop_Click(null, null);
                    Echo("\n" + "CONFIRMED", 1, true);
                    System.Threading.Thread.Sleep(3000);
                }
                else
                {
                    e.Cancel = true;
                    Echo("\n" + "CANCELLED", 1, true);
                }
            }
            try
            {
                using (var tw = new StreamWriter("7dsm_players_history.txt"))
                {
                    foreach (ListViewItem item in All_Players_List.Items)
                    {
                        tw.WriteLine(item.Text);
                        tw.WriteLine(item.SubItems[1].Text);
                    }
                }
            }
            catch { }
        }

        private void Cmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Echo("> " + cmd.Text, 2, true);
                string przyciety = "";

                if (cmd.Text.Length >= 5)
                {
                    przyciety = cmd.Text.Remove(5, cmd.Text.Length - 5);
                }


                if (przyciety == "local")
                {
                    if (cmd.Text == "local")
                    {
                        Echo("Usage: local <command>", 0, true);
                    }
                    else
                    {
                        przyciety = cmd.Text.Remove(0, 6);

                        cmd.Text = przyciety;



                        if (cmd.Text == "ver")
                        {
                            Echo("Version: " + ver, 0, true);
                        }

                        else if (cmd.Text == "for")
                        {
                            Echo("Game version: " + game_ver, 0, true);
                        }


                        else if (cmd.Text == "help")
                        {
                            Echo("Each command should be preceded with \"local\" eg. local cls", 0, true);
                            Echo("cls- Clears console", 0, true);
                            Echo("cls path- Remove game files path. It may cause errors!", 0, true);
                            Echo("help- This list", 0, true);
                            Echo("ver- Displays version of manager", 0, true);
                            Echo("for- Displays version of game", 0, true);
                            Echo("kill workers- Sets server_online variable to false without killing server. It may cause errors!", 0, true);
                            Echo("whats new- Shows changelog of this release", 0, true);
                            Echo("glass- Useless magic;)", 0, true);
                            Echo("exe- show executions of custom commands (only these with delay)", 0, true);

                        }

                        else if (cmd.Text == "cls")
                        {
                            Console_RichTextBox.Text = "";
                        }

                        else if (cmd.Text == "glass")
                        {
                            this.Opacity = 0.9;

                        }

                        else if (cmd.Text == "cls path")
                        {
                            Registry.SetValue(base_registry_key + profile_name, "game_path", "");
                            Echo("Ścieżka wyczyszczona!", 1, true);
                        }

                        else if (cmd.Text == "ankieta")
                        {
                            Survey_Form an = new Survey_Form();
                            an.Show();
                        }

                        else if (cmd.Text == "exe")
                        {
                            Echo("command-unix timestamp-username", 1, true);
                            string[] executed_cmds = all_exes.Split(':');

                            foreach (string comd in executed_cmds)
                            {
                                Echo(comd, 1, true);
                            }
                        }

                        else if (cmd.Text == "kill workers")
                        {
                            Echo("Set. Connection destroyed. Server will not respond to any action in manager (except killing proccess).", 3, true);
                            server_online = false;
                        }

                        else if (cmd.Text == "whats new")
                        {
                            Echo(whatsnew, 1, true);
                        }

                        else if (cmd.Text == "transerr")
                        {
                            Echo("If You're sure that translation is ok, check original lang.xml. It may contain new labels to translate. New labels will ALWAYS be on the end of file.\nIf Your translation contains special characters such as Ö, Ó, Ą, Ę, ß try to change file encoding (You can do this in Notepad++ (Encoding->Convert to UTF-8))", 2, true);
                            Echo("------------------------\nDetected errors:\n" + translation_error_c, 3, true);
                        }


                        else
                            Echo("Command not found. Type \"local help\".", 2, true);
                        cmd.Text = "";



                    }
                }
                else
                {
                    telnet_queue.Enqueue(cmd.Text);
                    cmd.Text = "";
                }




                e.Handled = true;

            }


        }


        private void Telnet_connect_Click(object sender, EventArgs e)
        {
            int s = (((Game_Hour_TrackBar.Value * 1000) - 8000) + ((Game_Day_TrackBar.Value * 24000) - 24000) - 8000);
            telnet_queue.Enqueue("settime " + s);
        }

        private void Dzien_bar_Scroll(object sender, EventArgs e)
        {
            dzien.Text = "Day [" + Convert.ToString(Game_Day_TrackBar.Value) + "]";
        }

        private void Godzina_bar_Scroll(object sender, EventArgs e)
        {
            godzina.Text = "Hour [" + Convert.ToString(Game_Hour_TrackBar.Value) + ":00]";
        }

        private void Server_panel_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState & Settings_Send_To_Tray_CheckBox.Checked)
            {
                App_Icon.Visible = true;
                this.Visible = false;
                App_Icon.ShowBalloonTip(15000, "I'm here!", "Click here to restore manager.", ToolTipIcon.Info);
            }

        }

        private void Ikona_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            App_Icon.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void Chpath_Click(object sender, EventArgs e)
        {
            Echo_debug("---changing dir---");
            if (Select_Game_Directory.ShowDialog() == DialogResult.OK)
            {
                string sciezka_plikow = Select_Game_Directory.SelectedPath + "\\" + exe_name.Text;
                string sciezka_plikow_server = Select_Game_Directory.SelectedPath + "\\7DaysToDieServer.exe";

                if (File.Exists(@sciezka_plikow))
                {
                    MessageBox.Show("Dir seems to be all right. Saved", "Saved");
                    Registry.SetValue(base_registry_key + profile_name, "game_path", Select_Game_Directory.SelectedPath);
                    Registry.SetValue(base_registry_key + profile_name, "server_type", "client");

                }
                else if (File.Exists(@sciezka_plikow_server))
                {
                    MessageBox.Show("Dir seems to be all right. Saved", "Saved");
                    Registry.SetValue(base_registry_key + profile_name, "game_path", Select_Game_Directory.SelectedPath);
                    Registry.SetValue(base_registry_key + profile_name, "server_type", "server");

                }
                else
                {
                    MessageBox.Show("Game files not found.", "Error");
                }

            }
        }

        private void Spawn_now_Click(object sender, EventArgs e)
        {
            Echo_debug("---spawning---");

            //telnet_NOW = "spawnentity" + players_ids[spawn_player.SelectedIndex] + "" + Convert.ToString(spawn_item.SelectedIndex + 1);
            try
            {
                telnet_queue.Enqueue("spawnentity \"" + Online_Player_List.SelectedItems[0].SubItems[0].Text + "\" " + Convert.ToString(Spawn_Item_ComboBox.SelectedIndex + 1));
            }
            catch
            {
                MessageBox.Show("Select player from list.");
            }

        }

        private void Kill_proccess_Click(object sender, EventArgs e)
        {

            Echo_debug("---killing 7daystodie.exe---");
            DialogResult dialogResult = MessageBox.Show("Are you sure? This may corrupt your save file!", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    telnet_connection.CancelAsync();
                }
                catch (Exception eksepszyn)
                {
                    Error_Reporter err_rep = new Error_Reporter("Workers closing error. It shouldn't be a problem, but if something in not ok try restarting 7DSM." + "\n" + Convert.ToString(eksepszyn));
                    err_rep.Show();
                }


                Echo("Killing proccess...", 0, false);

                //telnet_cmd("shutdown", false, false);

                foreach (Process myProc in Process.GetProcesses())
                {
                    if (myProc.ProcessName == "7DaysToDie" || myProc.ProcessName == "7DaysToDieServer")
                    {
                        myProc.Kill();
                    }
                }

                Unlock_Panel_Controls();
                this.ControlBox = true;


                server_online = false;
                Echo("OK", 1, true);
                Echo("Proccess killed", 0, true);
            }
        }

        private void Work_after_start_DoWork(object sender, DoWorkEventArgs e)
        {

            bool fresh_start = (bool)e.Argument;

            var prog = Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.Instance;
            prog.SetProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Normal);

            int i = 0;
            startbar.Invoke((MethodInvoker)delegate
            {
                startbar.Visible = true;
            });

            Shutdown_Server_Button.Invoke((MethodInvoker)delegate
            {
                //!!!stop.Enabled = false;
            });

            if (fresh_start)
            {
                while (i <= 3500)
                {
                    System.Threading.Thread.Sleep(10);
                    startbar.Invoke((MethodInvoker)delegate
                    {
                        startbar.Value = i;
                        prog.SetProgressValue(i, 3500);
                    });
                    i++;

                    if (i == 3400)
                        try
                        {
                            telnet_connection.RunWorkerAsync();
                        }
                        catch
                        {
                            Echo_debug("FAILED to start telnet_connection worker!");
                        }

                }
            }
            else
            {
                try
                {
                    telnet_connection.RunWorkerAsync();
                }
                catch
                {
                    Echo_debug("FAILED to start telnet_connection worker!");
                }
            }


            if (SQL_Enabled_CheckBox.Checked)
            {
                try
                {
                    System.Threading.Thread.Sleep(2000);
                    sql_exporter.RunWorkerAsync();
                }
                catch
                {
                    Echo("Error while starting sql_exporter.", 3, true);
                }
            }
            

            try
            {
                auto_messages.RunWorkerAsync();
            }
            catch
            {
                Echo_debug("Error while starting auto_messages. (normal on telnet reboot)");
            }

            try
            {
                string plik_out = (string)Registry.GetValue(base_registry_key + profile_name, "game_path", null) + "\\whitelist.txt";

                allowed_players.Clear();

                using (var sr = new StreamReader(@plik_out))
                {
                    while (sr.Peek() >= 0)
                        allowed_players.Add(sr.ReadLine());
                }
            }
            catch { }

            try
            {
                autoupdate_whitelist.RunWorkerAsync();
            }
            catch
            {
                Echo("Error while starting autoupdate_whitelist.", 3, true);
            }


            if (auto_backup_check.Checked)
            {
                try
                {
                    auto_backup.RunWorkerAsync();
                }
                catch
                {
                    Echo_debug("Error while starting auto_backup. (normal on telnet reboot)");
                }
            }

            bool rr_enabled = false;

            Shutdown_Server_Button.Invoke((MethodInvoker)delegate
            {
                rr_enabled = Enable_Auto_Restarts_CheckBox.Checked;
            });

            if (!auto_reset.IsBusy && rr_enabled)
            {
                try
                {
                    auto_reset.RunWorkerAsync();
                }
                catch
                {
                    Echo("Error while starting auto_reset.", 3, true);
                }
            }

            Thread.Sleep(1000);

            Shutdown_Server_Button.Invoke((MethodInvoker)delegate
            {
                Echo("Server is running now...", 1, true);
            });

            prog.SetProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.NoProgress);

            startbar.Invoke((MethodInvoker)delegate
            {
                startbar.Visible = false;
            });


            Shutdown_Server_Button.Invoke((MethodInvoker)delegate
            {
                Shutdown_Server_Button.Enabled = true;
            });

            e.Cancel = true;
            return;
        }

        private void Kick_Click(object sender, EventArgs e)
        {
            Echo_debug("---kick---");
            try
            {
                telnet_queue.Enqueue("kick " + Convert.ToString(Online_Player_List.SelectedItems[0].Text) + " " + Kick_Reason_ComboBox.Text);
                MessageBox.Show(Convert.ToString(Online_Player_List.SelectedItems[0].Text) + " has been kicked.", "KICK");

                int liczba = 0; string cur_pl = "";
                startbar.Invoke((MethodInvoker)delegate
                {
                    liczba = Online_Player_List.Items.Count;
                });
                for (int x = 0; x < liczba; x++)
                {
                    startbar.Invoke((MethodInvoker)delegate
                    {
                        cur_pl = Online_Player_List.Items[x].SubItems[0].Text.Trim();
                    });

                    string wwl = Regex.Replace(Convert.ToString(Online_Player_List.SelectedItems[0].Text), @"\t|\n|\r", "");
                    string cur_pl2 = Regex.Replace(cur_pl, @"\t|\n|\r", "");

                    Echo_debug("KICK remove from pl_list: " + wwl + ":" + cur_pl2 + ";");
                    if (0 == String.Compare(wwl, cur_pl2))
                    {
                        Echo_debug("GTFO: " + cur_pl2);
                        startbar.Invoke((MethodInvoker)delegate
                        {
                            Online_Player_List.Items[x].Remove();
                        });
                    }
                }

            }
            catch
            {
                MessageBox.Show("Select player from list.");
            }
        }

        private void Ban_Click(object sender, EventArgs e)
        {
            Echo_debug("---ban---");
            try
            {

                string user = "";

                if (selected_player_list_offline)
                    user = Convert.ToString(All_Players_List.SelectedItems[0].Text);
                else
                    user = Convert.ToString(Online_Player_List.SelectedItems[0].Text);


                DialogResult dialogResult = MessageBox.Show("Are you sure you want to ban " + user + "?\n", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string czas;

                    if (Ban_Time_ComboBox.Text != "")
                    {

                        if (Ban_Time_ComboBox.Text == "minutes")
                        {
                            czas = "minutes";
                        }
                        else if (Ban_Time_ComboBox.Text == "hours")
                        {
                            czas = "hours";
                        }
                        else if (Ban_Time_ComboBox.Text == "days")
                        {
                            czas = "days";
                        }
                        else if (Ban_Time_ComboBox.Text == "weeks")
                        {
                            czas = "weeks";
                        }
                        else if (Ban_Time_ComboBox.Text == "months")
                        {
                            czas = "months";
                        }
                        else
                        {
                            czas = "years";
                        }

                        telnet_queue.Enqueue("ban add " + user + " " + Ban_Slider_TrackBar.Value + " " + czas);
                        MessageBox.Show(user + " is banned now.", "BAN");
                    }
                    else
                    {
                        MessageBox.Show("Select ban time", "Warning");
                    }
                }
                else
                {
                    MessageBox.Show("Canceled", "BAN");
                }
            }
            catch
            {
                MessageBox.Show("Select player from list.");
            }
        }

        private void Spawn_delay_Scroll(object sender, EventArgs e)
        {

        }

        private void Taskman_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {

                if (status_updater.IsBusy)
                {
                    startbar.Invoke((MethodInvoker)delegate
                    {
                        taskman.Items.Add("status_updater");
                    });
                }


                if (server_startup_tasks.IsBusy)
                {
                    startbar.Invoke((MethodInvoker)delegate
                    {
                        taskman.Items.Add("server_startup_tasks");
                    });
                }

                if (auto_backup.IsBusy)
                {
                    startbar.Invoke((MethodInvoker)delegate
                    {
                        taskman.Items.Add("auto_backup");
                    });
                }


                if (telnet_connection.IsBusy)
                {
                    startbar.Invoke((MethodInvoker)delegate
                    {
                        taskman.Items.Add("telnet_connection");
                    });
                }

                if (workers_list.IsBusy)
                {
                    startbar.Invoke((MethodInvoker)delegate
                    {
                        taskman.Items.Add("workers_list");
                    });
                }

                if (auto_messages.IsBusy)
                {
                    startbar.Invoke((MethodInvoker)delegate
                    {
                        taskman.Items.Add("auto_messages");
                    });
                }

                if (sql_exporter.IsBusy)
                {
                    startbar.Invoke((MethodInvoker)delegate
                    {
                        taskman.Items.Add("sql_exporter");
                    });
                }



                if (auto_reset.IsBusy)
                {
                    startbar.Invoke((MethodInvoker)delegate
                    {
                        taskman.Items.Add("auto_reset");
                    });
                }

                if (reboot_telnet.IsBusy)
                {
                    startbar.Invoke((MethodInvoker)delegate
                    {
                        taskman.Items.Add("reboot_telnet");
                    });
                }


                if (autoupdate_whitelist.IsBusy)
                {
                    startbar.Invoke((MethodInvoker)delegate
                    {
                        taskman.Items.Add("autoupdate_whitelist");
                    });
                }

                Thread.Sleep(5000);
                startbar.Invoke((MethodInvoker)delegate
                    {
                        taskman.Items.Clear();
                    });
            }
        }

        private void Telnet_connection_DoWork(object sender, DoWorkEventArgs e)
        {
            string telnet_host = "localhost";
            int telnet_port = 8081;

            startbar.Invoke((MethodInvoker)delegate
            {
                telnet_port = Convert.ToInt32(ConfigProperty_TelnetPort.Text);
            });

            /*string telnet_host = "towel.blinkenlights.nl";
            int telnet_port = 23;*/

            Echo_debug("---starting telnet_connection---");

            string reply = "";


            Recon: //I am bad person, I am bad person, I am bad person
            try
            {
                tc = new TelnetConnection(telnet_host, telnet_port);
            }
            catch
            {
                //echo("Server refused connection... Trying again in 30s.\n(If this is the first start, it might take few minutes to render the level, keep calm.)", 2, true);
                Echo("Server is not ready yet... Trying again in 30s.\n(If this is the first start, it might take few minutes to render the level, keep calm.)", 2, true);
                Thread.Sleep(30000);
                goto Recon; //don't kill me
            }

            if (tc == null)
            {
                MessageBox.Show("Something went terribly wrong. Restart server.", "Warning");
                e.Cancel = true;
                return;
            }

            //Login
            Thread.Sleep(2 * 1000);

            startbar.Invoke((MethodInvoker)delegate
            {
                telnet_NOW = ConfigProperty_TelnetPassword.Text;
            });

            tc.WriteLine(telnet_NOW);
            reply = tc.Read();

            try
            {
                if (reply.Contains("incorrect"))
                {
                    Echo("WRONG PASSWORD! TELNET CONNECTION CLOSED!", 3, true);
                    e.Cancel = true;
                    return;
                }
            }
            catch { }


            string fakepsw = "";

            for (int a = 0; a < telnet_NOW.Length; a++)
            {
                fakepsw += "*";
            }
            Echo(reply.Replace("Please enter password:", "Please enter password: " + fakepsw), 4, true);

            telnet_NOW = "null";

            break_telnet = false;

            int cntr = 100; //I will send a telnet request every few cycles to maintain the connection

            while (server_online && !break_telnet || just_killin)
            {

                if (telnet_queue.Count == 0)
                {
                    if (cntr == 180)
                    {
                        tc.WriteLine("ping");
                        Echo_debug("REFRESH: " + tc.IsConnected);
                        cntr = 0;
                    }
                    cntr++;
                }

                if (!just_killin)
                    if (!tc.IsConnected)
                    {
                        Echo("Server broke telnet connection!", 2, true);
                        try
                        {
                            reboot_telnet.RunWorkerAsync();

                        }
                        catch/* (Exception exc)*/
                        {
                            /*error_reporter err_rep = new error_reporter("Can not reestablish connection because of 7DSM internal error.\n" + Convert.ToString(exc));
                            err_rep.Show();*/
                        }
                    }



                if (this.telnet_connection.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }


                if (!server_online && !just_killin)
                {
                    e.Cancel = true;
                    return;
                }


                if (telnet_NOW != "null")
                {
                    tc.WriteLine(telnet_NOW);
                    telnet_NOW = "null";
                }
                else if (telnet_queue.Count != 0)
                {
                    tc.WriteLine(telnet_queue.Dequeue());
                }


                reply = tc.Read();
                reply_telnet = reply;


                try
                {
                    if (reply.Contains("ERROR: unknown command 'ping'"))
                        reply = "";
                }
                catch { }



                if (reply != "")
                {

                    //response processing, do not spoil, let it pass

                    /////////////////////////////////////////////////////////////////////////////////////////////////////
                    // NEW PLAYER LIST
                    /////////////////////////////////////////////////////////////////////////////////////////////////////


                    /////////////////////////////////////////////////////////////////////////////////////////////////////
                    //removing a player from the list

                    try
                    {

                        if (reply_telnet.Contains("Total of"))
                        {
                            reply_lp = reply_telnet;
                        }



                        if (reply_telnet.Contains("Player disconnected"))
                        {
                            reply_telnet.Substring(reply_telnet.IndexOf('\n') + 1);
                            string[] podzielony = reply_telnet.Split('\'');
                            string[] podzielony2 = podzielony[5].Split('\'');
                            podzielony2[0] = podzielony2[0].Trim();
                            podzielony2[0] = Regex.Replace(podzielony2[0], @"\t|\n|\r", "");
                            Echo_debug("-> DISCONNECT: " + podzielony2[0]);

                            string cur_pl = "";
                            int liczba = 0;
                            startbar.Invoke((MethodInvoker)delegate
                            {
                                liczba = Online_Player_List.Items.Count;
                            });


                            for (int x = 0; x < liczba; x++)
                            {
                                startbar.Invoke((MethodInvoker)delegate
                                {
                                    cur_pl = Online_Player_List.Items[x].SubItems[0].Text.Trim();
                                });


                                if (0 == String.Compare(podzielony2[0], cur_pl))
                                {
                                    Echo_debug("GTFO: " + cur_pl);
                                    Echo("Player disconnected: " + cur_pl, 1, true);
                                    startbar.Invoke((MethodInvoker)delegate
                                    {
                                        Online_Player_List.Items[x].Remove();
                                    });
                                }
                            }
                        }


                        if (reply_telnet.Contains("left the game"))
                        {
                            reply_telnet = reply_telnet.Substring(reply_telnet.LastIndexOf("GMSG: ") + 6);
                            reply_telnet = reply_telnet.Substring(0, reply_telnet.LastIndexOf(" left the game"));


                            /*podzielony2[0] = Regex.Replace(podzielony2[0], @"\t|\n|\r", "");*/
                            Echo_debug("-> DISCONNECT: -" + reply_telnet + "-");

                            string cur_pl = "";
                            int liczba = 0;
                            startbar.Invoke((MethodInvoker)delegate
                            {
                                liczba = Online_Player_List.Items.Count;
                            });


                            for (int x = 0; x < liczba; x++)
                            {
                                startbar.Invoke((MethodInvoker)delegate
                                {
                                    cur_pl = Online_Player_List.Items[x].SubItems[0].Text.Trim();
                                });


                                if (0 == String.Compare(reply_telnet, cur_pl))
                                {
                                    Echo_debug("GTFO: " + cur_pl);
                                    Echo("Player disconnected: " + cur_pl, 1, true);
                                    startbar.Invoke((MethodInvoker)delegate
                                    {
                                        Online_Player_List.Items[x].Remove();
                                    });
                                }
                            }

                        }


                        ////////////////////////////////////////////////////////////////////////////
                        // Adding Players
                        if (reply_telnet.Contains("Authenticating"))
                        {

                            try
                            {
                                string[] odp_wlasciwa_list = reply_telnet.Split('\n');
                                string successful_response = "";

                                foreach (string odp in odp_wlasciwa_list)
                                {
                                    if (odp.Contains("Authenticating"))
                                    {
                                        successful_response = odp;
                                    }
                                }

                                Echo_debug("LOGIN detected");
                                // EXPECTING THE LOG LINES BELOW
                                //28.865 LOG: Authenticating player: pionner121 SteamId: 76561198035573640 TicketLen: 1024 Result: OK
                                //2015-02-08T22:15:50 103.437 INF [Steamworks.NET] Authenticating player: pionner121 SteamId: 76561198035573640 TicketLen: 1024 Result: k_EBeginAuthSessionResultOK
                                string[] divided_response = successful_response.Split(':');
                                divided_response[3] = divided_response[3].Replace("SteamId", "").Trim(); //login
                                divided_response[4] = divided_response[4].Replace("TicketLen", "").Trim(); //steamid


                                startbar.Invoke((MethodInvoker)delegate
                                {

                                    if (allowed_players.Contains(divided_response[3]) || !Use_Whitelist_CheckBox.Checked)
                                    {
                                        ListViewItem lvi = new ListViewItem
                                        {
                                            Text = divided_response[3]
                                        };
                                        lvi.SubItems.Add(divided_response[4]);

                                        ListViewItem item = Online_Player_List.FindItemWithText(divided_response[3]);

                                        if (!Player_is_listed(lvi))
                                            Online_Player_List.Items.Add(lvi);

                                        if (!Player_big_list(lvi))
                                            All_Players_List.Items.Add((ListViewItem)lvi.Clone());

                                        Echo("Player joined: " + divided_response[3], 1, true);
                                    }
                                    else
                                    {
                                        Echo("Player joined, but kicked (not on WL): " + divided_response[3], 1, true);
                                        telnet_queue.Enqueue("kick " + divided_response[3] + " You_are_not_on_whitelist.");
                                    }


                                });

                                Echo_debug("ADDED TO PL_LIST: " + divided_response[3] + ", " + divided_response[4] + "\nFULL: " + reply_telnet);


                                int banmode = Convert.ToInt32((string)Registry.GetValue(base_registry_key + profile_name, "glob", null));

                                if (banmode != 0)
                                {

                                    System.Net.WebClient client = new System.Net.WebClient();
                                    client.Headers.Add("User-Agent", "7DSM");
                                    int is_globally_banned = 0;

                                    try
                                    {
                                        is_globally_banned = Convert.ToInt32(client.DownloadString(new Uri("https://7dsm.smartmoose.org/system/ban/check_ban.php?login=" + divided_response[4])));
                                    }
                                    catch { }


                                    if (is_globally_banned >= 3)
                                    {
                                        if (banmode == 1)
                                            telnet_queue.Enqueue("say \"Globally banned player " + divided_response[3] + " just joined.\"");
                                        else if (banmode == 2)
                                            telnet_queue.Enqueue("kick " + divided_response[3] + " \"GLOBAL BAN (more details: https://7dsm.smartmoose.org/ban, your SteamID: " + divided_response[4] + ")\"");
                                    }
                                    else if (is_globally_banned != 0 && banmode == 3)
                                    {
                                        telnet_queue.Enqueue("kick " + divided_response[3] + " \"You are monitored (more details: https://7dsm.smartmoose.org/ban), your SteamID: " + divided_response[4] + ")\"");
                                    }
                                }


                            }
                            catch (Exception ex)
                            {
                                Error_Reporter err_rep = new Error_Reporter("Exception during adding player to players list (part 1).\n" + Convert.ToString(ex));
                                err_rep.Show();
                            }
                        }


                        if (reply_telnet.Contains("already allowed!"))
                        {
                            try
                            {
                                string[] podzielony = reply_telnet.Split('\'');
                                startbar.Invoke((MethodInvoker)delegate
                                {
                                    ListViewItem lvi = new ListViewItem
                                    {
                                        Text = podzielony[1]
                                    };
                                    lvi.SubItems.Add("n/a");



                                    if (!Player_is_listed(lvi))
                                    {
                                        Online_Player_List.Items.Add(lvi);
                                    }


                                    if (!Player_big_list(lvi))
                                    {
                                        All_Players_List.Items.Add((ListViewItem)lvi.Clone());
                                    }


                                });
                            }
                            catch { }

                        }


                        /////////////////////////////////////////////////////////////////////////////////////////////////////
                        // END: NEW PLAYER LIST
                        /////////////////////////////////////////////////////////////////////////////////////////////////////


                        /////////////////////////////////////////////////////////////////////////////////////////////////////
                        // CHAT
                        /////////////////////////////////////////////////////////////////////////////////////////////////////
                        try
                        {
                            if (reply_telnet.Contains("INF Chat") && !reply_telnet.Contains("joined the game") && !reply_telnet.Contains("left the game") && !reply_telnet.Contains("INF Executing command"))
                            {
                                string[] wiadomosc = reply_telnet.Split(':');


                                int index = wiadomosc[2].IndexOf("\n");
                                if (index > 0)
                                    wiadomosc[2] = wiadomosc[2].Substring(0, index);


                                wiadomosc[2] = Regex.Replace(wiadomosc[2], @"\t|\n|\r", "").TrimStart();
                                wiadomosc[1] = wiadomosc[1].TrimEnd();
                                wiadomosc[1] = wiadomosc[1].TrimStart();



                                Echo_debug("->Checking if command: " + wiadomosc[4].Trim());
                                if (wiadomosc[4].Trim().StartsWith("/"))
                                {
                                    Console.Write("Calling executor... ");
                                    //custom command!
                                    string wiad = wiadomosc[2] + ":" + wiadomosc[3] + ":" + wiadomosc[4].Trim();

                                    Echo_debug(wiad);
                                    try
                                    {
                                        custom_cmd_executor.RunWorkerAsync(wiad);
                                    }
                                    catch
                                    {
                                        //only 1 cmd at the time lol
                                    }
                                }
                                else
                                {
                                    try
                                    {
                                        Echo_chat("<" + wiadomosc[3].Trim().Replace("'", "") + "> " + wiadomosc[4].Trim(), false);
                                    }
                                    catch (Exception ee)
                                    {
                                        Error_Reporter err_rep = new Error_Reporter("Array out of bound. They changed something again.\n" + Convert.ToString(ee));
                                        err_rep.Show();
                                    }

                                }
                            }
                        }
                        catch { /*Put The Intercepted Logging Info Here*/ }


                        //End of Treatment

                        Echo(reply, 4, true);
                    }
                    catch { }
                }


            }

            Echo("Telnet connection closed.", 2, true);

            Echo_debug("TELNET TERMINATED!!!");
            e.Cancel = true;
            return;
        }

        private void Save_logfiles_CheckedChanged(object sender, EventArgs e)
        {
            if (Save_Logs_CheckBox.Checked)
            {
                Registry.SetValue(base_registry_key + profile_name, "save_logfiles", "1");
                Save_Logs_CheckBox.Checked = true;
            }

            else
            {
                Registry.SetValue(base_registry_key + profile_name, "save_logfiles", "0");
                Save_Logs_CheckBox.Checked = false;
            }
        }

        private void Console_TextChanged(object sender, EventArgs e)
        {
            if (Save_Logs_CheckBox.Checked)
            {

                try
                {
                    main_log.WriteLine(Console_RichTextBox.Text.Replace(console_pre, ""));

                    if (Console_RichTextBox.Text.Length > console_offset)
                        Console_RichTextBox.Text = Console_RichTextBox.Text.Substring(Console_RichTextBox.Text.Length - console_offset);

                    console_pre = Console_RichTextBox.Text;
                }
                catch { }
            }
        }

        private void TrackBar1_Scroll_1(object sender, EventArgs e)
        {
            Ban_GroupBox.Text = "BAN [" + Convert.ToString(Ban_Slider_TrackBar.Value) + "]";
        }

        private void Save_logfiles_2_CheckedChanged(object sender, EventArgs e)
        {
            if (Save_Logs_CheckBox.Checked)
            {
                Registry.SetValue(base_registry_key + profile_name, "save_logfiles", "1");
                Save_Logs_CheckBox.Checked = true;
            }

            else
            {
                Registry.SetValue(base_registry_key + profile_name, "save_logfiles", "0");
                Save_Logs_CheckBox.Checked = false;
            }
        }

        private void To_tray_CheckedChanged(object sender, EventArgs e)
        {
            if (Settings_Send_To_Tray_CheckBox.Checked)
                Registry.SetValue(base_registry_key + profile_name, "to_tray", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "to_tray", "0");
        }

        private void Always_on_top_CheckedChanged(object sender, EventArgs e)
        {
            if (Settings_Always_On_Top_CheckBox.Checked)
            {
                Registry.SetValue(base_registry_key + profile_name, "always_on_top", "1");
                this.TopMost = true;
            }
            else
            {
                Registry.SetValue(base_registry_key + profile_name, "always_on_top", "0");
                this.TopMost = false;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Ctrlp_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Ctrlppass_TextChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Port_panel_TextChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Zombiespawn_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void ServerIsPublic_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void ServerPassword_TextChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Mapa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_Config();
            Download_maps(ConfigProperty_GameWorld.Text);
        }

        private void Showonmap_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Friendlyfire_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Rebuildmap_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Cheatmode_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Blad_Click(object sender, EventArgs e)
        {
            Error_Reporter err_rep = new Error_Reporter("Report by user");
            err_rep.Show();
        }

        private void Zombie_normal_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Zombie_run_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Zombie_never_run_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Steamsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string steam_registry_path = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null);
                steam_registry_path = steam_registry_path.Replace("/", "\\");

                steam_registry_path += "\\steamapps\\common\\7 Days To Die";


                if (File.Exists(steam_registry_path + "\\" + exe_name.Text))
                {
                    MessageBox.Show("Found steam game files. Should work:)", "Saved");
                    Registry.SetValue(base_registry_key + profile_name, "game_path", steam_registry_path);
                    Game_File_Path_Label.Text = "Game files path: " + (string)Registry.GetValue(base_registry_key + profile_name, "game_path", null);
                }
                else
                {
                    steam_registry_path += " Dedicated Server";
                    if (File.Exists(steam_registry_path + "\\7DaysToDieServer.exe"))
                    {
                        MessageBox.Show("Found steam game files. Should work:)", "Saved");
                        Registry.SetValue(base_registry_key + profile_name, "game_path", steam_registry_path);
                        Game_File_Path_Label.Text = "Game files path: " + (string)Registry.GetValue(base_registry_key + profile_name, "game_path", null);
                    }
                    else
                    {

                        MessageBox.Show("Didn't found game on Steam. You have to download the game via Steam.", "Error");
                        Echo("Didn't found game on Steam. You have to download the game via Steam.", 3, true);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Steam not found. Set path manually", "Error");
            }
        }

        private void Flag_pl_Click(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "lang", "en");
            Process.Start(Application.ExecutablePath);
            this.Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "lang", "pl");
            Process.Start(Application.ExecutablePath);
            this.Close();
        }

        private void Spamer_DoWork(object sender, DoWorkEventArgs e)
        {
            Echo_debug("---starting spamer---");

            Random r = new Random();
            int n;

            while (true)
            {

                if (this.auto_messages.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                /*You can't kill a worker it's asleep, so we wake it up every second and see if it wants to die*/

                int s_time = 0;
                try
                {
                    s_time = (int)Registry.GetValue(base_registry_key + profile_name, "spam_time", null);
                }
                catch { }

                for (int k = Convert.ToInt32(s_time * 30); k >= 0; k--)
                {
                    Thread.Sleep(1000);

                    int min = k / 60;
                    int sec = k % 60;

                    string min_str, sec_str;

                    if (min > 9)
                        min_str = Convert.ToString(min);
                    else
                        min_str = "0" + Convert.ToString(min);
                    if (sec > 9)
                        sec_str = Convert.ToString(sec);
                    else
                        sec_str = "0" + Convert.ToString(sec);


                    startbar.Invoke((MethodInvoker)delegate
                    {
                        Auto_Command_Timer.Text = min_str + ":" + sec_str;
                    });

                    if (!server_online)
                    {
                        startbar.Invoke((MethodInvoker)delegate
                        {
                            Auto_Command_Timer.Text = "00:00";
                        });
                        break;
                    }

                }

                string sl = (string)Registry.GetValue(base_registry_key + profile_name, "spam_list", null);

                if (sl != "")
                {
                    Echo_debug("Sending some SPAM...");

                    string[] spamy = sl.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

                    n = r.Next(0, spamy.Length);

                    bool spamy_spam = false;
                    startbar.Invoke((MethodInvoker)delegate
                    {
                        spamy_spam = Server_Commands_Say_Switch_CheckBox.Checked;
                    });

                    if (spamy_spam)
                    {
                        telnet_queue.Enqueue("say \"" + spamy[n] + "\"");
                    }
                    else
                    {
                        telnet_queue.Enqueue(spamy[n]);
                    }
                    Echo("Sent command: " + spamy[n], 1, true);
                }

            }
        }

        private void Spam_list_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "spam_list", Server_Commands_List_RichTextBox.Text);
        }

        private void Spam_time_Scroll(object sender, EventArgs e)
        {
            Server_Commands_Delay_GroupBox.Text = "Delay Between Commands: [" + Server_Commands_Time_TrackBar.Value * 0.5 + " min.]";
            Registry.SetValue(base_registry_key + profile_name, "spam_time", Server_Commands_Time_TrackBar.Value);
        }

        //Show or Hide IP Addresses On Server Management Tab
        private void Show_IP_CheckedChanged(object sender, EventArgs e)
        {
            if (Settings_Show_IPS_CheckBox.Checked)
            {
                Registry.SetValue(base_registry_key + profile_name, "show_ip", "1");
                Public_IP_Address_Label.Visible = true;
                Private_IP_Address_Label.Visible = true;
            }
            else
            {
                Registry.SetValue(base_registry_key + profile_name, "show_ip", "0");
                Public_IP_Address_Label.Visible = false;
                Private_IP_Address_Label.Visible = false;
            }
        }

        private void Cleanexit_CheckedChanged(object sender, EventArgs e)
        {
            if (Settings_Clean_Exit_CheckBox.Checked)
                Registry.SetValue(base_registry_key + profile_name, "cleanexit", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "cleanexit", "0");
        }

        private void Pionnershome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://7dsm.smartmoose.org");
        }

        private void Flag_cn_Click(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "lang", "cn");
            Process.Start(Application.ExecutablePath);
            this.Close();
        }

        private void Anon_data_CheckedChanged(object sender, EventArgs e)
        {
            if (Settings_Allow_Anon_Data_CheckBox.Checked)
                Registry.SetValue(base_registry_key + profile_name, "anon_data", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "anon_data", "0");
        }

        private void Sql_exporter_DoWork(object sender, DoWorkEventArgs e)
        {
            MySqlConnection conn;
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=7dsm;";

            if (SQL_Update_Time_TextBox.Text == "")
                SQL_Update_Time_TextBox.Text = "60";

            startbar.Invoke((MethodInvoker)delegate
            {
                myConnectionString = "server=" + SQL_Host_TextBox.Text + ";uid=" + SQL_Username_TextBox.Text + ";" + "pwd=" + SQL_Password_TextBox.Text + ";database=" + SQL_Database_Name_TextBox.Text + ";";
            });

            Echo_debug("SQL_EXPORTER: init");

            /*Create The Table*/

            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();

                MySqlCommand sql_cmd = new MySqlCommand
                {
                    Connection = conn,

                    CommandText = "CREATE TABLE IF NOT EXISTS `7days_stats` (`players` int(11) NOT NULL,`max_players` int(11) NOT NULL,`last_update` int(32) NOT NULL);"
                };
                sql_cmd.ExecuteNonQuery();

                sql_cmd.CommandText = "CREATE TABLE IF NOT EXISTS `7days_players` (`id` int(11) NOT NULL AUTO_INCREMENT, `login` varchar(64) COLLATE utf8_bin NOT NULL, `x` varchar(10) COLLATE utf8_bin NOT NULL, `y` varchar(10) COLLATE utf8_bin NOT NULL, `z` varchar(10) COLLATE utf8_bin NOT NULL, `hp` int(4) NOT NULL, PRIMARY KEY (`id`));";

                sql_cmd.ExecuteNonQuery();

                conn.Close();

                startbar.Invoke((MethodInvoker)delegate
                {
                    Echo("SQL data updated.", 2, true);
                });
            }
            catch (MySqlException ex)
            {
                startbar.Invoke((MethodInvoker)delegate
                {
                    Echo(Convert.ToString(ex), 3, true);
                });
            }

            /*Recording To CL*/

            Echo_debug("SQL_EXPORTER: ready");

            while (server_online)
            {
                Echo_debug("SQL_EXPORTER: loop");

                /*--------------------------------------------------*/
                telnet_NOW = "lp";

                System.Threading.Thread.Sleep(1000);

                if (reply_lp == "error")
                {
                    Echo("Cannot download playerlist.", 3, true);
                }
                else
                {
                    string[] wszystkie_odpowiedzi;
                    wszystkie_odpowiedzi = reply_lp.Split((char)13);


                    /*clean sql from old records*/
                    try
                    {
                        conn = new MySqlConnection(myConnectionString);
                        conn.Open();

                        MySqlCommand sql_cmd = new MySqlCommand
                        {
                            Connection = conn,
                            CommandText = "DELETE FROM 7days_stats"
                        };
                        sql_cmd.ExecuteNonQuery();
                        sql_cmd.CommandText = "DELETE FROM 7days_players";
                        sql_cmd.ExecuteNonQuery();

                        conn.Close();
                    }
                    catch { }

                    foreach (string linia in wszystkie_odpowiedzi)
                    {

                        if (linia.Contains("Total of"))
                        {

                            string l=linia.Replace("Total of ", "");
                            l=l.Replace(" in the game", "");
                            l=l.Replace("\n", "");
                            l=l.Replace(" ", "");

                            Int32 unixTimestamp = (Int32)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

                            /*Recording To SQL*/

                            try
                            {


                                conn = new MySqlConnection(myConnectionString);
                                conn.Open();

                                MySqlCommand sql_cmd = new MySqlCommand
                                {
                                    Connection = conn
                                };

                                Echo_debug("SQL ITEM: players: " + l);

                                sql_cmd.CommandText = "INSERT INTO 7days_stats(players, max_players, last_update) VALUES(?players,?max_players,?last_update)";
                                sql_cmd.Parameters.Add("?players", MySqlDbType.VarChar).Value = l;
                                sql_cmd.Parameters.Add("?max_players", MySqlDbType.VarChar).Value = ConfigProperty_ServerMaxPlayerCount.Value;
                                sql_cmd.Parameters.Add("?last_update", MySqlDbType.VarChar).Value = unixTimestamp;


                                sql_cmd.ExecuteNonQuery();

                                conn.Close();

                                startbar.Invoke((MethodInvoker)delegate
                                {
                                    Echo("SQL data updated.", 2, true);
                                });
                            }
                            catch (MySql.Data.MySqlClient.MySqlException ex)
                            {
                                startbar.Invoke((MethodInvoker)delegate
                                {
                                    Echo(Convert.ToString(ex), 3, true);
                                });
                            }


                            /*Record To SQL*/

                        }
                        else
                        {
                            if (linia != "")
                            {
                                string[] gracz_info;
                                gracz_info = new string[10];
                                gracz_info = linia.Split(',');
                                try
                                {
                                    gracz_info[2] = gracz_info[2].Replace("pos=(", "");
                                    gracz_info[4] = gracz_info[4].Replace(")", "");
                                    gracz_info[9] = gracz_info[9].Replace("health=", "");

                                    /*Record To SQL*/

                                    try
                                    {
                                        conn = new MySqlConnection(myConnectionString);
                                        conn.Open();

                                        MySqlCommand sql_cmd = new MySqlCommand
                                        {
                                            Connection = conn
                                        };

                                        Echo_debug("SQL ITEM: login: " + gracz_info[1] + " x: " + gracz_info[2] + " y: " + gracz_info[3] + " z: " + gracz_info[4] + " hp: " + gracz_info[9]);

                                        sql_cmd.CommandText = "INSERT INTO 7days_players(login,x,y,z,hp) VALUES(?login,?x,?y,?z,?hp)";
                                        sql_cmd.Parameters.Add("?login", MySqlDbType.VarChar).Value = gracz_info[1];
                                        sql_cmd.Parameters.Add("?x", MySqlDbType.VarChar).Value = gracz_info[2];
                                        sql_cmd.Parameters.Add("?y", MySqlDbType.VarChar).Value = gracz_info[3];
                                        sql_cmd.Parameters.Add("?z", MySqlDbType.VarChar).Value = gracz_info[4];
                                        sql_cmd.Parameters.Add("?hp", MySqlDbType.VarChar).Value = gracz_info[9];

                                        sql_cmd.ExecuteNonQuery();

                                        conn.Close();

                                        startbar.Invoke((MethodInvoker)delegate
                                        {
                                            Echo("SQL data updated.", 2, true);
                                        });
                                    }
                                    catch (MySqlException ex)
                                    {
                                        startbar.Invoke((MethodInvoker)delegate
                                        {
                                            Echo(Convert.ToString(ex), 3, true);
                                        });
                                    }
                                    
                                    /*Record To SQL*/

                                }
                                catch { }
                            }
                            /*else
                            {
                                startbar.Invoke((MethodInvoker)delegate
                                {
                                    echo("sql error:" + Convert.ToString(linia) + "\nDon't worry, it happens sometimes. No need to fix anything, it's just one time error.", 3, true);
                                });
                            }*/

                        }
                    }
                }
                /*--------------------------------------------------*/
                //System.Threading.Thread.Sleep(1000 * Convert.ToInt32(sql_updates_time.Text));

                for (int n = Convert.ToInt32(SQL_Update_Time_TextBox.Text); n >= 0; n--)
                {
                    System.Threading.Thread.Sleep(1000);

                    int min = n / 60;
                    int sec = n % 60;

                    string min_str, sec_str;

                    if (min > 9)
                        min_str = Convert.ToString(min);
                    else
                        min_str = "0" + Convert.ToString(min);
                    if (sec > 9)
                        sec_str = Convert.ToString(sec);
                    else
                        sec_str = "0" + Convert.ToString(sec);


                    startbar.Invoke((MethodInvoker)delegate
                    {
                        SQL_Export_Timer.Text = min_str + ":" + sec_str;
                    });

                    if (!server_online)
                    {
                        startbar.Invoke((MethodInvoker)delegate
                        {
                            SQL_Export_Timer.Text = "00:00";
                        });
                        break;
                    }

                }
            }

        }


        private void Sql_enabled_CheckedChanged(object sender, EventArgs e)
        {
            if (SQL_Enabled_CheckBox.Checked)
            {
                Registry.SetValue(base_registry_key + profile_name, "sql_enabled", "1");
            }
            else
            {
                Registry.SetValue(base_registry_key + profile_name, "sql_enabled", "0");
            }
        }

        private void Sql_host_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "sql_host", SQL_Host_TextBox.Text);
        }

        private void Sql_username_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "sql_username", SQL_Username_TextBox.Text);
        }

        private void Sql_password_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "sql_password", SQL_Password_TextBox.Text);
        }

        private void Sql_db_name_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "sql_db_name", SQL_Database_Name_TextBox.Text);
        }

        private void How_to_sql_Click(object sender, EventArgs e)
        {
            Process.Start("https://7dsm.smartmoose.org/index.php?id=mysql-tutorial");
        }

        private void Sql_updates_time_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(SQL_Update_Time_TextBox.Text, out double num) && SQL_Update_Time_TextBox.Text != "")
            {
                SQL_Update_Time_TextBox.Text = "60";
            }

            if (SQL_Update_Time_TextBox.Text != "")
            {
                Registry.SetValue(base_registry_key + profile_name, "sql_updates_time", Convert.ToInt32(SQL_Update_Time_TextBox.Text));
            }
        }

        private void ServerName_TextChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Auto_backup_check_CheckedChanged(object sender, EventArgs e)
        {
            if (auto_backup_check.Checked)
            {
                Registry.SetValue(base_registry_key + profile_name, "auto_backup", "1");
                backup_chat.Enabled = true;
                backup_time.Enabled = true;
            }
            else
            {
                Registry.SetValue(base_registry_key + profile_name, "auto_backup", "0");
                backup_chat.Enabled = false;
                backup_time.Enabled = false;
            }
        }

        private void Backup_time_Scroll(object sender, EventArgs e)
        {
            int hrs = (backup_time.Value * 15) / 60;
            int min = (backup_time.Value * 15) % 60;

            string hrs_s, min_s;

            if (hrs < 9)
            {
                hrs_s = "0" + Convert.ToString(hrs);
            }
            else
            {
                hrs_s = Convert.ToString(hrs);
            }

            if (min < 9)
            {
                min_s = "0" + Convert.ToString(min);
            }
            else
            {
                min_s = Convert.ToString(min);
            }

            auto_backup_group.Text = "Next backup in: [" + hrs_s + ":" + min_s + " h.]";
            Registry.SetValue(base_registry_key + profile_name, "backup_time", backup_time.Value);
        }

        public void Create_backup_now()
        {
            bool pokazuj_chat = false, usun_stare = false;
            string lokacja = "", selected_map = "", game_name = "", backup_location = "";
            int delete_old_number = 0;

            startbar.Invoke((MethodInvoker)delegate
            {
                try
                {
                    selected_map = ConfigProperty_GameWorld.Text;
                    game_name = ConfigProperty_GameName.Text;
                    backup_location = this.backup_location.Text;
                    pokazuj_chat = backup_chat.Checked;
                    lokacja = ConfigProperty_SaveGameFolder.Text;
                    usun_stare = rem_old_backups.Checked;
                    delete_old_number = Convert.ToInt32(rem_old_backups_count.Text);
                }
                catch { }
            });



            if (backup_location == "")
            {
                try
                {
                    Directory.CreateDirectory("backups");
                }
                catch { }
                backup_location = "backups";
            }

            /*backup*/
            Echo("[Backup system]Creating backup...", 1, true);
            if (pokazuj_chat)
                telnet_queue.Enqueue("say \"" + (string)Registry.GetValue(base_registry_key + profile_name, "backup_msg_1", null) + "\"");


            using (ZipFile zip = new ZipFile())
            {
                string sci = "";

                try
                {

                    if (lokacja == "")
                    {
                        sci = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\7DaysToDie\\Saves\\" + selected_map;

                    }
                    else
                    {
                        sci = lokacja + "\\" + selected_map;
                    }

                    Echo_debug(sci + "\\" + game_name);

                    zip.UseZip64WhenSaving = Zip64Option.Always;

                    zip.AddDirectory(sci + "\\" + game_name);
                    zip.Save(backup_location + "\\" + game_name + System.DateTime.Now.ToString(" yyy-MM-dd (HH_mm_ss)") + ".zip");


                    if (premium && usun_stare)
                    {
                        try
                        {
                            foreach (var fi in new DirectoryInfo(backup_location).GetFiles().OrderByDescending(x => x.LastWriteTime).Skip(delete_old_number))
                                fi.Delete();
                        }
                        catch (Exception ee)
                        {
                            Error_Reporter err_rep = new Error_Reporter("Error while removing old backups\n" + Convert.ToString(ee));
                            err_rep.Show();
                        }
                    }


                }
                catch
                {
                    Echo("Can't find data to backup: " + sci + "\\" + game_name, 3, true);
                }
            }

            /*/backup*/
            Echo("[Backup system]Backup created.", 1, true);
            if (pokazuj_chat)
                telnet_queue.Enqueue("say \"" + (string)Registry.GetValue(base_registry_key + profile_name, "backup_msg_2", null) + "\"");

            startbar.Invoke((MethodInvoker)delegate
            {
                Refresh_backups_list();
            });

        }

        private void Auto_backup_DoWork(object sender, DoWorkEventArgs e)
        {
            int n = 0;


            startbar.Invoke((MethodInvoker)delegate
            {
                n = backup_time.Value;
            });


            while (server_online)
            {

                for (int k = n * 900; k >= 0; k--)
                {
                    System.Threading.Thread.Sleep(1000);

                    int k_m = k;
                    int hrs = 0;


                    while (k_m >= 3600)
                    {
                        k_m -= 3600;
                        hrs++;
                    }

                    int min = k_m / 60;
                    int sec = k_m % 60;

                    string min_str, sec_str, hrs_str;


                    if (hrs > 9)
                        hrs_str = Convert.ToString(hrs);
                    else
                        hrs_str = "0" + Convert.ToString(hrs);
                    if (min > 9)
                        min_str = Convert.ToString(min);
                    else
                        min_str = "0" + Convert.ToString(min);
                    if (sec > 9)
                        sec_str = Convert.ToString(sec);
                    else
                        sec_str = "0" + Convert.ToString(sec);


                    startbar.Invoke((MethodInvoker)delegate
                    {
                        Backup_Timer.Text = hrs_str + ":" + min_str + ":" + sec_str;
                    });

                    if (!server_online)
                    {
                        startbar.Invoke((MethodInvoker)delegate
                        {
                            Backup_Timer.Text = "00:00:00";
                        });
                        break;
                    }

                }

                Create_backup_now();

            }
        }

        private void Show_stats_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://7dsm.smartmoose.org/index.php?id=stats");
        }

        private void Backup_chat_CheckedChanged(object sender, EventArgs e)
        {
            if (backup_chat.Checked)
                Registry.SetValue(base_registry_key + profile_name, "backup_chat", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "backup_chat", "0");
        }

        private void Donate_Click(object sender, EventArgs e)
        {
            //Updated To Latest Paypal Button Code - 1-2-2020
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=Y6XKJPQ4YB5Y8");

            // Print Thank You for Donating Message In Console :)
            Echo(Figgle.FiggleFonts.Big.Render("Thanks For Donating!"), 0, true);
        }
          

        //private void LootRespawnDays_Scroll(object sender, EventArgs e)
        //{

            //if (ConfigProperty_LootRespawnDays.Value == -1)
            //    LootRespawnDays_GroupBox.Text = LocalizedLanguage("LootRespawnDays_g") + " [" + LocalizedLanguage("disabled") + "]";
            //else
            //    LootRespawnDays_GroupBox.Text = LocalizedLanguage("LootRespawnDays_g") + " [" + ConfigProperty_LootRespawnDays_Old.Value + "]";
            //Update_Config();
        //}

        private void Browse_Click(object sender, EventArgs e)
        {
            Process prc = new Process();
            prc.StartInfo.FileName = (string)Registry.GetValue(base_registry_key + profile_name, "game_path", null);
            prc.Start();
        }

        private void Sa_edit_Click(object sender, EventArgs e)
        {
            try
            {
                Process prc = new Process();
                prc.StartInfo.FileName = (string)Registry.GetValue(base_registry_key + profile_name, "game_path", null) + "\\" + ConfigProperty_AdminFileName.Text;
                prc.Start();
            }
            catch (Exception ex)
            {
                try
                {
                    Process prc = new Process();
                    prc.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\7DaysToDie\\Saves\\" + ConfigProperty_AdminFileName.Text;
                    prc.Start();
                }
                catch (Exception ex2)
                {
                    Echo_debug("\n\n\nEXCEPTION WHILE OPENING ADMINFILE:\n1st try:\n" + ex + "\n\n2nd try:\n" + ex2 + "\n\n\n");
                    MessageBox.Show("Can't open file.", "Error");
                    MessageBox.Show((string)Registry.GetValue(base_registry_key + profile_name, "game_path", null) + "\\" + ConfigProperty_AdminFileName.Text);
                }
            }
        }

        // DEPRECATED ONLY ONE GAME MODE
        //private void Gamemode_surv_pvp_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (gamemode_surv_pvp.Checked == true)
        //    {
        //        Land_Claim_GroupBox.Visible = true;
        //    }
        //    else
        //    {
        //        Land_Claim_GroupBox.Visible = false;
        //    }
        //    Update_Config();
        //}

        private void Linear_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Exponential_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Full_prot_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void LandClaimOnlineDurabilityModifier_TextChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void LandClaimOfflineDurabilityModifier_TextChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void LandClaimDeadZone_TextChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void LandClaimSize_TextChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void LandClaimExpiryTime_TextChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Auto_reset_DoWork(object sender, DoWorkEventArgs e)
        {
            int n = 0;
            bool en = true, chat = false;

            Console_RichTextBox.Invoke((MethodInvoker)delegate
            {
                n = Auto_Restart_Time_TrackBar.Value;
                chat = Warn_Before_Restart_CheckBox.Checked;
            });

            while (en)
            {

                for (int k = n * 3600; k >= 0; k--)
                //for (int k = n * 2; k >= 0; k--)
                {
                    System.Threading.Thread.Sleep(1000);

                    int k_m = k;
                    int hrs = 0;


                    while (k_m >= 3600)
                    {
                        k_m -= 3600;
                        hrs++;
                    }

                    int min = k_m / 60;
                    int sec = k_m % 60;

                    string min_str, sec_str, hrs_str;

                    if (chat)
                    {
                        if (k == 900)
                        {
                            telnet_queue.Enqueue("say \"" + ((string)Registry.GetValue(base_registry_key + profile_name, "reboot_time", null)).Replace("%d", "15") + "\"");
                        }
                        else if (k == 600)
                        {
                            telnet_queue.Enqueue("say \"" + ((string)Registry.GetValue(base_registry_key + profile_name, "reboot_time", null)).Replace("%d", "10") + "\"");
                        }
                        else if (k == 300)
                        {
                            telnet_queue.Enqueue("say \"" + ((string)Registry.GetValue(base_registry_key + profile_name, "reboot_time", null)).Replace("%d", "5") + "\"");
                        }
                        else if (k == 180)
                        {
                            telnet_queue.Enqueue("say \"" + ((string)Registry.GetValue(base_registry_key + profile_name, "reboot_time", null)).Replace("%d", "3") + "\"");
                        }
                        else if (k == 120)
                        {
                            telnet_queue.Enqueue("say \"" + ((string)Registry.GetValue(base_registry_key + profile_name, "reboot_time", null)).Replace("%d", "2") + "\"");
                        }
                        else if (k == 60)
                        {
                            telnet_queue.Enqueue("say \"" + ((string)Registry.GetValue(base_registry_key + profile_name, "reboot_time", null)).Replace("%d", "1") + "\"");
                        }
                    }



                    if (hrs > 9)
                        hrs_str = Convert.ToString(hrs);
                    else
                        hrs_str = "0" + Convert.ToString(hrs);
                    if (min > 9)
                        min_str = Convert.ToString(min);
                    else
                        min_str = "0" + Convert.ToString(min);
                    if (sec > 9)
                        sec_str = Convert.ToString(sec);
                    else
                        sec_str = "0" + Convert.ToString(sec);


                    startbar.Invoke((MethodInvoker)delegate
                    {
                        Auto_Restart_Timer.Text = hrs_str + ":" + min_str + ":" + sec_str;
                    });

                    if (!en)
                    {
                        startbar.Invoke((MethodInvoker)delegate
                        {
                            Auto_Restart_Timer.Text = "00:00:00";
                        });
                        break;
                    }

                }

                //Execution
                startbar.Invoke((MethodInvoker)delegate
                {
                    Echo(((string)Registry.GetValue(base_registry_key + profile_name, "reboot", null)), 2, true);

                    telnet_queue.Enqueue("say \"" + (string)Registry.GetValue(base_registry_key + profile_name, "reboot", null) + "\"");

                    Stop_Click(null, null);
                    Start_Server_Button.Enabled = false;
                });

                Echo("Start in: ", 1, false);

                for (int lol = 10; lol > 0; lol--)
                {
                    System.Threading.Thread.Sleep(1000);
                    Echo(" " + Convert.ToString(lol), 1, false);
                }

                Echo("", 1, true);

                startbar.Invoke((MethodInvoker)delegate
                {
                    Run_Server();
                });

                Console_RichTextBox.Invoke((MethodInvoker)delegate
                {
                    en = Enable_Auto_Restarts_CheckBox.Checked;
                    n = Auto_Restart_Time_TrackBar.Value;
                    chat = Warn_Before_Restart_CheckBox.Checked;
                });
            }
        }

        private void Reset_time_Scroll(object sender, EventArgs e)
        {
            int hrs = Auto_Restart_Time_TrackBar.Value;
            int min = 0;

            string hrs_s, min_s;

            if (hrs < 9)
            {
                hrs_s = "0" + Convert.ToString(hrs);
            }
            else
            {
                hrs_s = Convert.ToString(hrs);
            }

            if (min < 9)
            {
                min_s = "0" + Convert.ToString(min);
            }
            else
            {
                min_s = Convert.ToString(min);
            }

            Auto_Restarts_GroupBox.Text = "Auto restarts [" + hrs_s + ":" + min_s + " h.]";
            Registry.SetValue(base_registry_key + profile_name, "reset_time", Auto_Restart_Time_TrackBar.Value);
        }

        private void Reset_enabled_CheckedChanged(object sender, EventArgs e)
        {
            if (Enable_Auto_Restarts_CheckBox.Checked)
            {
                Registry.SetValue(base_registry_key + profile_name, "auto_reset", "1");
                Warn_Before_Restart_CheckBox.Enabled = true;
                Auto_Restart_Time_TrackBar.Enabled = true;
            }
            else
            {
                Registry.SetValue(base_registry_key + profile_name, "auto_reset", "0");
                Warn_Before_Restart_CheckBox.Enabled = false;
                Auto_Restart_Time_TrackBar.Enabled = false;
            }
        }

        private void Reset_chat_CheckedChanged(object sender, EventArgs e)
        {
            if (Warn_Before_Restart_CheckBox.Checked)
                Registry.SetValue(base_registry_key + profile_name, "reset_chat", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "reset_chat", "0");
        }

        private void Save_TextChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Spam_is_spam_CheckedChanged(object sender, EventArgs e)
        {
            if (Server_Commands_Say_Switch_CheckBox.Checked)
                Registry.SetValue(base_registry_key + profile_name, "spam_is_spam", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "spam_is_spam", "0");
        }

        // Process And Send Anonymous Statistics
        private void Stats_DoWork(object sender, DoWorkEventArgs e)
        {
            // Setup New Webclient
            WebClient client;
            client = new WebClient();

            // Init Variables
            bool anonymous = false;

            // Set The Anonymous Variable
            Console_RichTextBox.Invoke((MethodInvoker)delegate
            {
                anonymous = Settings_Allow_Anon_Data_CheckBox.Checked;
            });

            while (true)
            {
                // If Send Anonymous Stats Is Enabled
                if (anonymous)
                {
                    // Get Windows Version Info
                    string os_ver = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentVersion", null);

                    // If Version Is Windows 10, Get The Build Number
                    try
                    {
                        if (os_ver == "6.3")
                            if (Convert.ToInt32((string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", null)) > 10000)
                                os_ver = "10.0";
                    }
                    catch
                    {
                        Echo_debug("Couldn't Obtain Windows 10 Build");
                    }

                    // Send Install ID, Windows Version, Is Server Public, Server Port, Game Name, Game Version, Android Enable Flag, Profile Name, and Website Enabled Flag
                    client.Headers.Add("User-Agent", (string)Registry.GetValue(base_registry_key, "install_id", null) + ";" + os_ver + ";" + "n\\a" + ";" + ConfigProperty_ServerVisibility.Text + ";" + ConfigProperty_ServerPort.Text + ";" + ConfigProperty_GameName.Text + ";" + ver + ";" + (string)Registry.GetValue(base_registry_key + profile_name, "android_allow", null) + ";" + (string)Registry.GetValue(base_registry_key + profile_name, "enable_website", null));
                }
                else
                {
                    // Only Send Install ID
                    client.Headers.Add("User-Agent", (string)Registry.GetValue(base_registry_key, "install_id", null) + ";ANON;ANON;0;0;0;0;0");
                }

                // Reset IP Variables To Ensure They Are Updated
                string Public_IP = "";
                string Private_IP = "";

                // Retrieve Public IP Address From Website
                try
                {
                    Public_IP = "IP: " + new WebClient().DownloadString("http://icanhazip.com"); //Get IP From Website
                }
                catch
                {
                    Public_IP = "IP: Error Retrieving Public IP";
                }

                //Retrieve Private IP Address From System Info
                try
                {
                    if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                    {
                        Private_IP = "IP: Network Is Not Available!";
                    }
                    else
                    {
                        Private_IP = "IP: " + Dns.GetHostEntry(Dns.GetHostName());
                    }
                }
                catch
                {
                    Private_IP = "IP: Error Retrieving Private IP";
                }

                // Set Public IP
                Public_IP_Address_Label.Invoke((MethodInvoker)delegate
                {
                    Public_IP_Address_Label.Text = Public_IP;
                    Echo_debug("Public IP Has Been Set");
                });

                //Set Private IP
                Private_IP_Address_Label.Invoke((MethodInvoker)delegate
                {
                    Private_IP_Address_Label.Text = Public_IP;
                    Echo_debug("Private IP Has Been Set");
                });

                // Parse The Admin File
                Process_Bans();

                // Sleep For An Hour
                Thread.Sleep(3600 * 1000);
            }
        }

        // Update Text On Air Drop Frequency Control When Slider Value Changes
        //private void AirDropFrequency_Scroll(object sender, EventArgs e)
        //{
            // Determine If Disabled Or Set To Specific Amount of Hours
            //if (ConfigProperty_AirDropFrequency_Old.Value != 0)
            //    AirDropFrequency_GroupBox.Text = LocalizedLanguage("AirDropFrequency") + " [" + Convert.ToString(ConfigProperty_AirDropFrequency_Old.Value) + " h.]";
            //else
            //    AirDropFrequency_GroupBox.Text = LocalizedLanguage("AirDropFrequency") + " [" + LocalizedLanguage("disabled") + "]";

            // Update The Config
            //Update_Config();
        //}

        private void Console_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void Feral_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Reboot_con_Click(object sender, EventArgs e)
        {
            reboot_telnet.RunWorkerAsync();
            Start_Server_Button.Enabled = false;
            Shutdown_Server_Button.Enabled = true;
        }

        private void Reboot_telnet_DoWork(object sender, DoWorkEventArgs e)
        {
            Echo("Reestablishing connection to 7DTD server...", 2, true);
            break_telnet = true;
            server_online = true; //so that they can connect without firing up with 7dsm
            try
            {
                telnet_connection.CancelAsync();
            }
            catch { }
            Thread.Sleep(500);
            try
            {
                server_startup_tasks.RunWorkerAsync(false);
                Lock_Panel_Controls();
            }
            catch { }

            Shutdown_Server_Button.Invoke((MethodInvoker)delegate
            {
                Shutdown_Server_Button.Enabled = true;
            });
        }

        private void Chat_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                telnet_queue.Enqueue("say \"" + Chat_Input_TextBox.Text + "\"");
                Chat_Input_TextBox.Text = "";
                e.Handled = true;
            }
        }

        #region 7DSM Site Links (OnClick)

        private void How_to_commands_Click(object sender, EventArgs e)
        {
            Process.Start("http://7dsm.seanasaservice.com/custom-commands-internal-interpreter.html");
        }

        # endregion

        private void Backup_msg_1_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "backup_msg_1", Starting_Backup_Message_TextBox.Text);
        }

        private void Backup_msg_2_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "backup_msg_2", Backup_Completed_Message_TextBox.Text);
        }

        private void Reboot_time_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "reboot_time", reboot_time.Text);
        }

        private void Reboot_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "reboot", reboot.Text);
        }

        private void Custom_cmd_executor_DoWork(object sender, DoWorkEventArgs e)
        {
            bool cc = true;
            bool externalCall = false;
            string wiad = (string)e.Argument;
            string excallFile=null;



            startbar.Invoke((MethodInvoker)delegate
            {
                cc = Enable_Custom_Commands_CheckBox.Checked;
                externalCall = Use_External_Call_CheckBox.Checked;
                excallFile = External_Call_File_Name_Label.Text;
            });


            Echo_debug("CC: " + wiad);



            try
            {
                Echo_debug("Here I am.");

                string[] wiadomosc = wiad.Split(':');

                bool dtds = false;

                Echo_debug("-> CC detected");

                int cmds_num = 0;
                startbar.Invoke((MethodInvoker)delegate
                {
                    cmds_num = Custom_Commands_RichTextBox.Lines.Length;
                    dtds = dtds_enable.Checked;
                });






                if (wiad.Contains("/reward") && dtds)
                {
                    Echo_debug("REWARD DEMANDED");



                    string resp = "0";
                    string klucz = "";
                    string login = wiadomosc[1].Replace("'", "").Trim();



                    Console_RichTextBox.Invoke((MethodInvoker)delegate
                    {
                        klucz = dtds_auth.Text;
                    });

                    try
                    {
                        WebClient client = new WebClient();
                        resp = client.DownloadString(new Uri("https://7daystodie-servers.com/api/?object=votes&element=claim&key=" + klucz + "&username=" + login));

                        Echo_debug("CHECKING: " + "https://7daystodie-servers.com/api/?object=votes&element=claim&key=" + klucz + "&username=" + login);
                        Echo_debug("RESP: " + resp);


                        switch (resp)
                        {
                            case "0":
                                telnet_queue.Enqueue("say \"You didn't vote!\"");
                                break;
                            case "1":
                                Console_RichTextBox.Invoke((MethodInvoker)delegate
                                {
                                    foreach (var item in dtds_lista.Items)
                                    {
                                        string res = item.ToString().Substring(0, item.ToString().IndexOf('-')).Trim();

                                        telnet_queue.Enqueue("spawnentity \"" + login + "\" " + res);
                                    }

                                });
                                client.DownloadString("https://7daystodie-servers.com/api/?action=post&object=votes&element=claim&key=" + klucz + "&username=" + login);

                                telnet_queue.Enqueue("say \"Thank you for voting!\"");
                                break;
                            case "2":
                                telnet_queue.Enqueue("say \"You have already claimed your reward!\"");
                                break;
                        }

                    }
                    catch { }

                }
                else if(cc && externalCall)
                {
                    try
                    {

                        string login = wiadomosc[1].Replace("'", "").Trim();
                        string command = wiadomosc[2].Replace("/", "");
                        string steamid = "0";



                        startbar.Invoke((MethodInvoker)delegate
                        {
                            foreach(ListViewItem ti in Online_Player_List.Items)
                            {
                                if(ti.SubItems[0].Text==login)
                                {
                                    steamid = ti.SubItems[1].Text;
                                }
                            }
                        });


                        Process p = new Process();

                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.RedirectStandardOutput = true;
                        p.StartInfo.RedirectStandardError = true;
                        p.StartInfo.FileName = excallFile;
                        p.StartInfo.Arguments = "\""+command + "\" \"" + login + "\" \"" + steamid + "\"";
                        p.Start();

                        string output = p.StandardOutput.ReadToEnd();
                        string errors = p.StandardError.ReadToEnd();
                        p.WaitForExit();

                        if (errors != "")
                        {
                            Echo(errors, 2, true);
                        }



                        string[] lines = output.Split('\n');

                        foreach (string line in lines)
                        {
                            if(line!="")
                                telnet_queue.Enqueue(line);
                        }

                        

                    }
                    catch(Exception ee)
                    {
                        Echo("There was an exception while running your CC external call: \n"+ee, 3, true);
                    }

                }
                else if (cc)
                {



                    for (int i = 0; i < cmds_num; i++)
                    {

                        string login = wiadomosc[1].Replace("'", "").Trim();


                        string cala_linia = "none";

                        startbar.Invoke((MethodInvoker)delegate
                        {
                            cala_linia = Custom_Commands_RichTextBox.Lines[i];
                        });


                        string[] komenda = cala_linia.Split(':');



                        Echo_debug("-> checking: " + komenda[0] + " and " + wiadomosc[2].Replace("/", ""));

                        if (komenda[0] == wiadomosc[2].Replace("/", ""))
                        {
                            Echo_debug("--> found: " + komenda[0] + " and " + wiadomosc[2].Replace("/", ""));
                            komenda[1] = komenda[1].Replace("%player%", login);




                            //random

                            if (komenda[1].Contains("{rand("))
                            {

                                string rand_tmp = komenda[1];

                                rand_tmp = rand_tmp.Substring(rand_tmp.IndexOf("{rand") + 6, rand_tmp.IndexOf(")") - rand_tmp.IndexOf("{rand") - 6);

                                string[] poszczegolne = rand_tmp.Split(',');

                                int[] poszcz_int = new int[2];

                                poszcz_int[0] = Convert.ToInt32(poszczegolne[0].Trim());
                                poszcz_int[1] = Convert.ToInt32(poszczegolne[1].Trim());

                                Random rnd = new Random();
                                int real_rand = rnd.Next(poszcz_int[0], poszcz_int[1]);

                                Regex rex = new Regex(@"\{([^\}]+)\}");
                                komenda[1] = rex.Replace(komenda[1], real_rand.ToString());

                            }

                            //end: random



                            string[] poszczegolne_komendy = komenda[1].Split(';');

                            string[] executed_cmds = all_exes.Split(':');




                            bool jest_zle = false;
                            double czas = 0;


                            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

                            foreach (string historia in executed_cmds)
                            {

                                string[] linia = historia.Split('-');

                                Echo_debug(linia[0].Replace("/", "") + " ---> " + wiadomosc[2].Replace("/", "") + "\n" + wiadomosc[1] + " ---> " + linia[2]);

                                if (linia[0].Replace("/", "") == wiadomosc[2].Replace("/", "") && wiadomosc[1] == linia[2]) //masz już właściwą komendę i login
                                {
                                    if (Convert.ToInt32(linia[1]) + Convert.ToInt32(komenda[2]) > unixTimestamp)
                                    {

                                        //no to jest źle
                                        jest_zle = true;
                                        czas = Convert.ToInt32(linia[1]) + Convert.ToInt32(komenda[2]) - unixTimestamp;

                                    }

                                }

                            }

                            if (!jest_zle)
                            {
                                foreach (string dana_komenda in poszczegolne_komendy)
                                {
                                    telnet_queue.Enqueue(dana_komenda);
                                    if (komenda[2] != "0")
                                        all_exes = all_exes + ":" + komenda[0] + "-" + unixTimestamp + "-" + wiadomosc[1];
                                    System.Threading.Thread.Sleep(500);
                                }
                            }
                            else
                            {
                                Int32 dobry_czas = Convert.ToInt32(Math.Round(czas / 60, 0));

                                telnet_queue.Enqueue("say \"" + ((string)Registry.GetValue(base_registry_key + profile_name, "cmd_not_yet", null)).Replace("%d", Convert.ToString(dobry_czas)) + "\"");
                            }




                            break;
                        }

                    }
                }

                Echo_chat("<" + wiadomosc[1].Trim() + "> " + wiadomosc[2].Trim(), true);

            }
            catch
            {
                Echo("There is error in syntax of one of your custom commands!", 3, true);
            }

        }

        private void Cmd_not_yet_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "cmd_not_yet", cmd_not_yet.Text);
        }

        private void Enable_cc_CheckedChanged(object sender, EventArgs e)
        {
            if (Enable_Custom_Commands_CheckBox.Checked)
                Registry.SetValue(base_registry_key + profile_name, "enable_cc", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "enable_cc", "0");


        }

        private void Configfile_e_Click(object sender, EventArgs e)
        {
            try
            {
                Process prc = new Process();
                prc.StartInfo.FileName = (string)Registry.GetValue(base_registry_key + profile_name, "game_path", null) + "\\" + ConfigProperty_UserDataFolder.Text;
                prc.Start();
            }
            catch
            {
                MessageBox.Show("Can't open file.", "Error");
            }
        }

        private void Configfile_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "configfile", ConfigProperty_UserDataFolder.Text);
        }

        private void Customcommands_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "cc", Custom_Commands_RichTextBox.Text);
        }

        private void PersistentPlayerProfiles_CheckedChanged(object sender, EventArgs e)
        {
            Update_Config();
        }

        private void Skip_profiles_CheckedChanged(object sender, EventArgs e)
        {
            if (Settings_Skip_Profiles_CheckBox.Checked)
                Registry.SetValue(base_registry_key, "skip_profiles", "1");
            else
                Registry.SetValue(base_registry_key, "skip_profiles", "0");
        }


        private void Stop_Click(object sender, EventArgs e)
        {
            just_killin = true;
            server_stop_tasks.RunWorkerAsync();
        }

        private void Server_stop_tasks_DoWork(object sender, DoWorkEventArgs e)
        {

            server_online = false;

            Console_RichTextBox.Invoke((MethodInvoker)delegate
            {
                Shutdown_Server_Button.Text = "Wait...";
                Shutdown_Server_Button.Enabled = false;
            });

            Echo("Closing server...", 2, true);

            telnet_queue.Enqueue("shutdown");

            Console_RichTextBox.Invoke((MethodInvoker)delegate
            {
                Online_Player_List.Items.Clear();
            });

            for (int i = 0; i < 15; i++)
                Thread.Sleep(100);

            if (reply_telnet == "error")
            {
                Echo("Error", 3, true);
                Echo("Killing proccess...", 0, false);

                foreach (Process myProc in Process.GetProcesses())
                {
                    if (myProc.ProcessName == "7DaysToDie" || myProc.ProcessName == "7DaysToDieServer")
                    {
                        myProc.Kill();
                    }
                }
            }

            telnet_connection.CancelAsync();

            Thread.Sleep(5000);

            Process[] proc = Process.GetProcessesByName("7DaysToDie");
            if (proc.Length > 0)
            {
                foreach (Process myProc in Process.GetProcesses())
                {
                    if (myProc.ProcessName == "7DaysToDie" || myProc.ProcessName == "7DaysToDieServer")
                    {
                        myProc.Kill();
                    }
                }
            }


            Console_RichTextBox.Invoke((MethodInvoker)delegate
            {
                Unlock_Panel_Controls();
                this.ControlBox = true;
                Start_Server_Button.Enabled = true;
                Shutdown_Server_Button.Text = "Close server";
            });


            //echo("OK", 1, true);
            Echo("Server closed", 1, true);

            just_killin = false;
        }

        private void Kill_Player_Click(object sender, EventArgs e)
        {
            try
            {
                telnet_queue.Enqueue("kill " + Online_Player_List.SelectedItems[0].SubItems[0].Text);
            }
            catch
            {
                MessageBox.Show("Select player from list.");
            }
        }

        private void Starve_Player_Click(object sender, EventArgs e)
        {
            try
            {
                telnet_queue.Enqueue("starve " + Online_Player_List.SelectedItems[0].SubItems[0].Text);
            }
            catch
            {
                MessageBox.Show("Select player from list.");
            }
        }

        private void Thirsty_Player_Click(object sender, EventArgs e)
        {
            try
            {
                telnet_queue.Enqueue("thirsty " + Online_Player_List.SelectedItems[0].SubItems[0].Text);
            }
            catch
            {
                MessageBox.Show("Select player from list.");
            }
        }

        private void Debug_Log_CheckedChanged(object sender, EventArgs e)
        {
            if (debug_log.Checked)
            {
                Registry.SetValue(base_registry_key + profile_name, "debug_log", "1");
                debug_mode = true;
            }
            else
            {
                Registry.SetValue(base_registry_key + profile_name, "debug_log", "0");
                debug_mode = false;
            }

            file_log = debug_log.Checked;
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {
            Process.Start("https://7dsm.smartmoose.org");
        }

        private void Wl_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (Auto_Update_Whitelist_CheckBox.Checked)
                Registry.SetValue(base_registry_key + profile_name, "autoupdate_whitelist", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "autoupdate_whitelist", "0");
        }

        private void Wl_interval_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "wl_interval", Update_Whitelist_Interval_TextBox.Text);
        }

        private void Wl_add_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "wl_add", Auto_Update_External_Whitelist_URL_TextBox.Text);
        }

        private void Autoupdate_whitelist_DoWork(object sender, DoWorkEventArgs e)
        {
            bool cont = false;
            string plik_in = "", plik_out = "";
            int i = 0;

            Auto_Update_Whitelist_CheckBox.Invoke((MethodInvoker)delegate
            {
                cont = Auto_Update_Whitelist_CheckBox.Checked;
                try
                {
                    i = Convert.ToInt32(Update_Whitelist_Interval_TextBox.Text);
                    plik_in = Auto_Update_External_Whitelist_URL_TextBox.Text;
                    plik_out = (string)Registry.GetValue(base_registry_key + profile_name, "game_path", null) + "\\whitelist.txt";
                }
                catch { }
            });


            while (cont)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(plik_in, @plik_out);

                    allowed_players.Clear();

                    using (var sr = new StreamReader(@plik_out))
                    {
                        while (sr.Peek() >= 0)
                            allowed_players.Add(sr.ReadLine());
                    }

                    Echo("Updated whitelist file.", 1, true);
                }
                catch
                {
                    Echo("Couldn't download whitelist file!", 3, true);
                }

                for (int k = i * 60; k >= 0; k--)
                {
                    Thread.Sleep(1000);

                    int k_m = k;
                    //int hrs = 0;

                    int min = k_m / 60;
                    int sec = k_m % 60;

                    string min_str, sec_str;

                    if (min > 9)
                        min_str = Convert.ToString(min);
                    else
                        min_str = "0" + Convert.ToString(min);
                    if (sec > 9)
                        sec_str = Convert.ToString(sec);
                    else
                        sec_str = "0" + Convert.ToString(sec);


                    startbar.Invoke((MethodInvoker)delegate
                    {
                        Whitelist_Update_Timer.Text = min_str + ":" + sec_str;
                    });
                }



            }


        }

        private void Use_wl_CheckedChanged(object sender, EventArgs e)
        {
            if (Use_Whitelist_CheckBox.Checked)
                Registry.SetValue(base_registry_key + profile_name, "use_wl", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "use_wl", "0");
        }

        private void Start_with_7dsm_CheckedChanged(object sender, EventArgs e)
        {
            if (Start_With_7DSM_CheckBox.Checked)
                Registry.SetValue(base_registry_key + profile_name, "start_with_7dsm", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "start_with_7dsm", "0");
        }

        private void Start_with_win_CheckedChanged(object sender, EventArgs e)
        {
            if (Start_7DSM_With_Windows_CheckBox.Checked)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("7DaysServerManager", @System.Reflection.Assembly.GetExecutingAssembly().Location);
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.DeleteValue("7DaysServerManager", false);
            }
        }

        private void Backup_location_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "backup_location", backup_location.Text);
        }

        private void Check_updates_DoWork(object sender, DoWorkEventArgs e)
        {
            string update_available = "0";
            WebClient client;

            bool dl_dev = false;

            if ((string)Registry.GetValue(base_registry_key, "dev", null) == "1")
                dl_dev = true;


            client = new WebClient();

            try
            {
                if (dl_dev)
                    update_available = client.DownloadString("https://7dsm.smartmoose.org/system/updates-dev/" + ver + ".txt");
                else
                    update_available = client.DownloadString("https://7dsm.smartmoose.org/system/updates/" + ver + ".txt");
            }
            catch
            {
                update_available = "err";
                Echo("Error during connecting to update server: the server is down, your connection to the internet is down or you're using unregistered build (server doesn't know your version of 7DSM, so it can't tell you if there are updates for it).", 3, true);

                if (updater_invoked_manually)
                {
                    MessageBox.Show("No updates found on current update channel.");
                }
            }

            if (update_available == "1")
            {
                Echo("Update available!", 2, true);
                DialogResult dialogResult = MessageBox.Show("Update available! Download now?", "Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Console_RichTextBox.Invoke((MethodInvoker)delegate
                    {
                        Updater up = new Updater();
                        up.Show();
                    });
                }

            }
            else if (update_available != "err")
            {
                Echo("You have the latest version of 7DSM.", 1, true);

                if (updater_invoked_manually)
                {
                    MessageBox.Show("No updates found on current update channel.");
                }
            }

            if (!updater_invoked_manually)
            {
                try
                {
                    //Retrieve The News                    
                    string[] news = client.DownloadString("http://7dsm.seanasaservice.com/news.php").Split(';');
                    Echo_news(news[1], Convert.ToInt32(news[0]));
                }
                catch { }
            }

        }

        private void Prepare_app_after_draw_DoWork(object sender, DoWorkEventArgs e)
        {
            Echo("Type \"local help\" for commands.", 0, true);

            IsPremium();

            check_updates.RunWorkerAsync();
        }

        private void Server_panel_Shown(object sender, EventArgs e)
        {
            prepare_app_after_draw.RunWorkerAsync();
        }

        private void Prem_act_Click(object sender, EventArgs e)
        {
            if (Supporter_Activate_Button.Text == "Activate")
            {

                if (Support_Code_TextBox.Text.Length == 8)
                {

                    Registry.SetValue(base_registry_key + "\\", "prem_code", Support_Code_TextBox.Text);

                    IsPremium();

                    if (premium)
                    {
                        Unlock_Premium();
                        MessageBox.Show("Thanks for supporting me :)", "Thanks");
                    }
                    else
                        MessageBox.Show("The code you entered is not valid.", "Sorry :(");

                }
                else
                {
                    MessageBox.Show("The code you entered is too short.", "Sorry :(");
                }
            }
            else
            {
                if (Support_Code_TextBox.ReadOnly == true)
                {
                    Support_Code_TextBox.ReadOnly = false;
                    Supporter_Activate_Button.Text = "Activate";
                }
            }
        }

        private void Prem_show_CheckedChanged(object sender, EventArgs e)
        {
            if (Support_Code_Show_CheckBox.Checked)
                Support_Code_TextBox.PasswordChar = '\0';
            else
                Support_Code_TextBox.PasswordChar = '*';
        }




        public void IsPremium()
        {
            Echo_debug("Checking Premium Status With Server");
            try
            {
                WebClient client = new WebClient(); ;

                int resp = Convert.ToInt32(client.DownloadString("https://7dsm.smartmoose.org/system/premium/check.php?code=" + (string)Registry.GetValue(base_registry_key, "prem_code", null)));

                if (resp == 0)
                {
                    Unlock_Premium();
                    premium = true;
                }
                else
                {
                    Lock_Premium();
                    premium = false;
                }

            }
            catch
            {
                Registry.SetValue(base_registry_key, "tmp_prem", "0");
                Lock_Premium();
                premium = false;
            }
        }

        public void Unlock_Premium()
        {
            Echo_debug("Premium Unlocked");
            Registry.SetValue(base_registry_key, "tmp_prem", "1");

            Hide_Donation_Buttons_CheckBox.Enabled = true;

            Console_RichTextBox.Invoke((MethodInvoker)delegate
            {
                Supporter_Status_Label.Text = "Supporter status: ACTIVE :)";

                if (Hide_Donation_Buttons_CheckBox.Checked)
                {
                    forumklik.Visible = false;
                    don_l.Visible = false;
                    Supporter_Donate_Button.Visible = false;

                    // Reset Icon Locations
                    if (!icons_moved)
                    {
                        GitHub_Repo_Button.Location = new Point(GitHub_Repo_Button.Location.X + 123, GitHub_Repo_Button.Location.Y);
                        www7dsm.Location = new Point(www7dsm.Location.X + 123, www7dsm.Location.Y);
                        contact_b.Location = new Point(contact_b.Location.X + 123, contact_b.Location.Y);
                        help_b.Location = new Point(help_b.Location.X + 123, help_b.Location.Y);
                        discord_b.Location = new Point(discord_b.Location.X + 123, discord_b.Location.Y);
                        icons_moved = true;
                    }
                }

                Supporter_Activate_Button.Text = "Change";
                Support_Code_TextBox.ReadOnly = true;

                Premium_Settings_Help_PictureBox.Visible = false;
                prem_help2.Visible = false;
                prem_help3.Visible = false;

                hide_footer.Enabled = true;

                rem_old_backups.Enabled = true;
                rem_old_backups_count.Enabled = true;
                rem_old_backups_l.Enabled = true;

            });

        }

        public void Lock_Premium()
        {
            Echo_debug("Premium Locked");
            Registry.SetValue(base_registry_key, "tmp_prem", "0");

            Hide_Donation_Buttons_CheckBox.Enabled = false;

            Console_RichTextBox.Invoke((MethodInvoker)delegate
            {
                Supporter_Status_Label.Text = "Supporter status: NOT activated";

                if (Hide_Donation_Buttons_CheckBox.Checked)
                {
                    forumklik.Visible = true;
                    don_l.Visible = true;
                    Supporter_Donate_Button.Visible = true;

                    if (icons_moved)
                    {
                        GitHub_Repo_Button.Location = new Point(GitHub_Repo_Button.Location.X - 123, GitHub_Repo_Button.Location.Y);
                        www7dsm.Location = new Point(www7dsm.Location.X - 123, www7dsm.Location.Y);
                        contact_b.Location = new Point(contact_b.Location.X - 123, contact_b.Location.Y);
                        help_b.Location = new Point(help_b.Location.X - 123, help_b.Location.Y);
                        discord_b.Location = new Point(discord_b.Location.X - 123, discord_b.Location.Y);
                        icons_moved = false;
                    }
                }

                Supporter_Activate_Button.Text = "Activate";
                Support_Code_TextBox.ReadOnly = false;

                Premium_Settings_Help_PictureBox.Visible = true;
                prem_help2.Visible = true;
                prem_help3.Visible = true;

                hide_footer.Enabled = false;

                rem_old_backups.Enabled = false;
                rem_old_backups_count.Enabled = false;
                rem_old_backups_l.Enabled = false;

                rem_old_backups.Checked = false;
            });

        }

        private void Hide_Donate_Button_CheckedChanged(object sender, EventArgs e)
        {
            if (premium)
                if (Hide_Donation_Buttons_CheckBox.Checked)
                {
                    Registry.SetValue(base_registry_key + profile_name, "hide_don_btn", "1");
                    forumklik.Visible = false;
                    don_l.Visible = false;
                    Supporter_Donate_Button.Visible = false;

                    // Reset Icon Locations
                    if (!icons_moved)
                    {
                        GitHub_Repo_Button.Location = new Point(GitHub_Repo_Button.Location.X + 123, GitHub_Repo_Button.Location.Y);
                        www7dsm.Location = new Point(www7dsm.Location.X + 123, www7dsm.Location.Y);
                        contact_b.Location = new Point(contact_b.Location.X + 123, contact_b.Location.Y);
                        help_b.Location = new Point(help_b.Location.X + 123, help_b.Location.Y);
                        discord_b.Location = new Point(discord_b.Location.X + 123, discord_b.Location.Y);
                        icons_moved = true;
                    }
                }
                else
                {
                    Registry.SetValue(base_registry_key + profile_name, "hide_don_btn", "0");
                    forumklik.Visible = true;
                    don_l.Visible = true;
                    Supporter_Donate_Button.Visible = true;

                    // Reset Icon Locations
                    if (icons_moved)
                    {
                        GitHub_Repo_Button.Location = new Point(GitHub_Repo_Button.Location.X - 123, GitHub_Repo_Button.Location.Y);
                        www7dsm.Location = new Point(www7dsm.Location.X - 123, www7dsm.Location.Y);
                        contact_b.Location = new Point(contact_b.Location.X - 123, contact_b.Location.Y);
                        help_b.Location = new Point(help_b.Location.X - 123, help_b.Location.Y);
                        discord_b.Location = new Point(discord_b.Location.X - 123, discord_b.Location.Y);
                        icons_moved = false;
                    }
                }
        }

        private void Rem_old_backups_CheckedChanged(object sender, EventArgs e)
        {
            if (rem_old_backups.Checked)
                Registry.SetValue(base_registry_key + profile_name, "rem_old_backups", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "rem_old_backups", "0");
        }

        private void Rem_old_backups_count_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "rem_old_backups_count", rem_old_backups_count.Text);
        }


        private void Dtds_visit_Click(object sender, EventArgs e)
        {
            Process.Start("http://7daystodie-servers.com/");
        }

        private void Dtds_enable_CheckedChanged(object sender, EventArgs e)
        {
            if (dtds_enable.Checked)
                Registry.SetValue(base_registry_key + profile_name, "dtds_enable", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "dtds_enable", "0");
        }

        private void Dtds_auth_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "dtds_auth", dtds_auth.Text);
        }

        public void Save_dtds()
        {
            try
            {
                string to_save = "";
                foreach (var item in dtds_lista.Items)
                {
                    to_save += item + ";";
                }

                to_save = to_save.Remove(to_save.Length - 1);

                Registry.SetValue(base_registry_key + profile_name, "dtds_items", to_save);
            }
            catch { }
        }

        private void Dtds_add_Click(object sender, EventArgs e)
        {
            dtds_lista.Items.Add(dtds_possible.SelectedItem.ToString().Trim());
            Save_dtds();
        }

        private void Dtds_rem_Click(object sender, EventArgs e)
        {
            try
            {
                dtds_lista.Items.RemoveAt(dtds_lista.SelectedIndex);
            }
            catch { }
            Save_dtds();
        }

        private void Error_reporter_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string rep = (string)e.Argument;
            Error_Reporter rr = new Error_Reporter(rep);
            rr.Show();
        }

        private void Dbg_btn_Click(object sender, EventArgs e)
        {
            //ws.Run();
            RunWebServer();

        }

        private void Contact_b_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.Show();
        }


        public void Refresh_backups_list()
        {
            backups_list.Items.Clear();

            try
            {
                string[] filePaths = Directory.GetFiles(@backup_location.Text, "*.zip");

                foreach (string f in filePaths)
                {
                    //string a=Path.GetFileNameWithoutExtension(f);
                    backups_list.Items.Add(Path.GetFileNameWithoutExtension(f));
                }
            }
            catch
            {
                try
                {
                    Directory.CreateDirectory(backup_location.Text);
                }
                catch { }
                //MessageBox.Show("Couldn't find backups directory", "Error");
            }
        }

        private void Backup_refresh_Click(object sender, EventArgs e)
        {
            Refresh_backups_list();
        }

        private void Backup_del_Click(object sender, EventArgs e)
        {
            if (backups_list.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE this backup?\nTHIS CAN NOT BE UNDONE!", "Delete backup", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    File.Delete(backup_location.Text + "\\" + backups_list.GetItemText(backups_list.SelectedItem) + ".zip");
                    Refresh_backups_list();
                }
            }
            else
            {
                MessageBox.Show("Select backup file first.", "You forgot something");
            }
        }

        private void Restore_now_Click(object sender, EventArgs e)
        {
            if (backups_list.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to RESTORE this backup?\nTHIS CAN NOT BE UNDONE!", "Restore backup", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string direct = "";

                        if (ConfigProperty_SaveGameFolder.Text == "")
                        {
                            direct = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\7DaysToDie\\Saves\\" + ConfigProperty_GameWorld.Text + "\\" + ConfigProperty_GameName.Text;
                        }
                        else
                        {
                            direct = ConfigProperty_SaveGameFolder.Text + "\\" + ConfigProperty_GameWorld.Text + "\\" + ConfigProperty_GameName.Text;
                        }

                        MessageBox.Show("This may take a while.");
                        System.IO.DirectoryInfo di = new DirectoryInfo(direct);

                        foreach (FileInfo file in di.GetFiles())
                        {
                            file.Delete();
                        }
                        foreach (DirectoryInfo dir in di.GetDirectories())
                        {
                            dir.Delete(true);
                        }




                        using (ZipFile zip1 = ZipFile.Read(backup_location.Text + "\\" + backups_list.GetItemText(backups_list.SelectedItem) + ".zip"))
                        {
                            foreach (ZipEntry itm in zip1)
                            {
                                itm.Extract(direct, ExtractExistingFileAction.OverwriteSilently);
                            }
                        }

                        MessageBox.Show("Restore complete.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("FAILED! Please restart machine and try again (some files may be locked).\n" + ex, "ERROR");
                    }

                }

            }
            else
            {
                MessageBox.Show("Select backup file first.", "You forgot something");
            }
        }

        private void Create_bp_now_Click(object sender, EventArgs e)
        {
            Create_backup_now();
        }

        private void Opeb_bp_dir_Click(object sender, EventArgs e)
        {
            if (backup_location.Text == "")
                Process.Start("backups");
            else
                Process.Start(backup_location.Text);
        }

        private void Dtds_show_CheckedChanged(object sender, EventArgs e)
        {
            if (dtds_show.Checked)
                dtds_auth.PasswordChar = '\0';
            else
                dtds_auth.PasswordChar = '*';
        }

        private void Exe_name_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "exe_name", exe_name.Text);
        }

        private void Chat_TextChanged(object sender, EventArgs e)
        {
            if (Save_Logs_CheckBox.Checked)
            {

                try
                {
                    chat_log.WriteLine(Chat_RichTextBox.Text.Replace(chat_pre, ""));


                    if (Chat_RichTextBox.Text.Length > console_offset)
                        Chat_RichTextBox.Text = Chat_RichTextBox.Text.Substring(Chat_RichTextBox.Text.Length - console_offset);

                    chat_pre = Chat_RichTextBox.Text;

                }
                catch { }
            }
        }

        private void Help_b_Click(object sender, EventArgs e)
        {
            Process.Start("https://7dsm.smartmoose.org/index.php?id=help");
        }

        private void Chk_upd_Click(object sender, EventArgs e)
        {
            updater_invoked_manually = true;
            try
            {
                check_updates.RunWorkerAsync();
            }
            catch { }
        }

        private void Force_upd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Console_RichTextBox.Invoke((MethodInvoker)delegate
                {
                    Updater up = new Updater();
                    up.Show();
                });
            }
        }

        private void All_players_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_player_list_offline = true;
            Kick_GroupBox.Enabled = false;
            Spawn_GroupBox.Enabled = false;
            Player_GroupBox.Enabled = false;
        }

        private void Players_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_player_list_offline = false;
            Kick_GroupBox.Enabled = true;
            Spawn_GroupBox.Enabled = true;
            Player_GroupBox.Enabled = true;
        }

        private void Players_list_Click(object sender, EventArgs e)
        {
            Players_list_SelectedIndexChanged(null, null);
        }

        private void All_players_list_Click(object sender, EventArgs e)
        {
            All_players_list_SelectedIndexChanged(null, null);
        }

        private void Apply_update_channel_Click(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key, "dev", Convert.ToString(Update_Channel_ComboBox.SelectedIndex));

            MessageBox.Show("7DSM will now download latest version from selected update channel.", "Update");

            Console_RichTextBox.Invoke((MethodInvoker)delegate
            {
                Updater up = new Updater();
                up.Show();
            });

        }

        private void Process_Bans()
        {
            bool allow_bans_sending = false;

            Console_RichTextBox.Invoke((MethodInvoker)delegate
            {
                allow_bans_sending = sendbans.Checked;
            });


            if (!allow_bans_sending)
                return;


            string nazwa_w = null;

            if (File.Exists((string)Registry.GetValue(base_registry_key + profile_name, "game_path", null) + "\\" + ConfigProperty_AdminFileName.Text))
                nazwa_w = (string)Registry.GetValue(base_registry_key + profile_name, "game_path", null) + "\\" + ConfigProperty_AdminFileName.Text;
            else if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\7DaysToDie\\Saves\\" + ConfigProperty_AdminFileName.Text))
                nazwa_w = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\7DaysToDie\\Saves\\" + ConfigProperty_AdminFileName.Text;


            if (nazwa_w == null)
            {
                Echo("Can not establish serveradmin.xml reader. Banned users list won't be shared with other servers even if you enable it in options. Try moving serveradmin.xml to default location with default name.", 2, true);
                return;
            }


            List<string> wyslani = new List<string>();
            string line;
            if (File.Exists("7dsm_global_banlist.txt"))
            {
                System.IO.StreamReader file =
                    new System.IO.StreamReader("7dsm_global_banlist.txt");
                while ((line = file.ReadLine()) != null)
                {
                    if (!line.Contains("<!--"))
                        wyslani.Add(line);
                }
                file.Close();

            }
            else
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("7dsm_global_banlist.txt");
                file.WriteLine("<!-- This file is NOT full global banlist, it's only a cache. Please don't remove it. -->");
                file.Close();
            }

            try
            {
                XmlReader xmlReader = XmlReader.Create(nazwa_w);
                while (xmlReader.Read())
                {
                    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "blacklisted"))
                    {
                        if (xmlReader.HasAttributes)
                        {
                            string steamID = xmlReader.GetAttribute("steamID");

                            if (!wyslani.Contains(steamID))
                            {
                                Echo_debug("GLOBAL BAN REPORT: " + steamID);

                                System.Net.WebClient client = new System.Net.WebClient();
                                client.Headers.Add("User-Agent", "7DSM");

                                try
                                {
                                    client.DownloadStringAsync(new Uri("https://7dsm.smartmoose.org/system/ban/report.php?sid=" + (string)Registry.GetValue(base_registry_key, "install_id", null) + "&uid=" + steamID));
                                }
                                catch { }


                                using (StreamWriter sw = File.AppendText("7dsm_global_banlist.txt"))
                                {
                                    sw.WriteLine(steamID);
                                }

                            }
                            else
                            {
                                Echo_debug("IGNORING BAN:" + steamID);
                            }
                        }
                    }
                }
            }
            catch { }


        }


        // CONFIG STATE CHANGES

        private void Sendbans_CheckedChanged(object sender, EventArgs e)
        {
            if (sendbans.Checked)
                Registry.SetValue(base_registry_key + profile_name, "sendbans", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "sendbans", "0");
        }

        private void Glob_0_CheckedChanged(object sender, EventArgs e)
        {
            if (glob_0.Checked)
                Registry.SetValue(base_registry_key + profile_name, "glob", "0");
            else if (glob_1.Checked)
                Registry.SetValue(base_registry_key + profile_name, "glob", "1");
            else if (glob_2.Checked)
                Registry.SetValue(base_registry_key + profile_name, "glob", "2");
            else if (glob_3.Checked)
                Registry.SetValue(base_registry_key + profile_name, "glob", "3");
        }

        private void Check_bans_Click(object sender, EventArgs e)
        {
            Process.Start("https://7dsm.smartmoose.org/ban");
        }

        private void Dbg_btn_2_Click(object sender, EventArgs e)
        {
            //ws.Stop();

        }

        private void Android_allow_CheckedChanged(object sender, EventArgs e)
        {
            if (!android_allow.Checked && !enable_website.Checked)
            {
                try
                {
                    StopWebServer();
                }
                catch { }
            }
            else
            {
                try
                {
                    StartWebServer();
                }
                catch { }
            }

            if (android_allow.Checked)
                Registry.SetValue(base_registry_key + profile_name, "android_allow", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "android_allow", "0");

        }

        private void Fix_firewall_and_other_windows_shit_Click(object sender, EventArgs e)
        {
            Fix_WebServer();
        }

        private void Enable_website_CheckedChanged(object sender, EventArgs e)
        {
            if (!android_allow.Checked && !enable_website.Checked)
            {
                try
                {
                    StopWebServer();
                }
                catch { }
            }
            else
            {
                try
                {
                    StartWebServer();
                }
                catch { }
            }

            if (enable_website.Checked)
                Registry.SetValue(base_registry_key + profile_name, "enable_website", "1");
            else
                Registry.SetValue(base_registry_key + profile_name, "enable_website", "0");
        }

        private void Reverse_reservation_Click(object sender, EventArgs e)
        {
            Cancel_WebServer();
        }

        private void Android_APK_Click(object sender, EventArgs e)
        {
            Process.Start("https://7dsm.smartmoose.org/index.php?id=downloads");
        }

        private void Android_Play_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet available on Google Play. Please download .APK file.");
        }

        private void Www_main_content_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "www_main_content", www_main_content.Text);
        }

        private void Rules_content_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "rules_content", rules_content.Text);
        }

        private void Forum_url_TextChanged(object sender, EventArgs e)
        {
            Registry.SetValue(base_registry_key + profile_name, "forum_url", forum_url.Text);
        }

        private void Hide_footer_CheckedChanged(object sender, EventArgs e)
        {
            if (premium)
                if (hide_footer.Checked)
                {
                    Registry.SetValue(base_registry_key + profile_name, "hide_footer", "1");
                }
                else
                {
                    Registry.SetValue(base_registry_key + profile_name, "hide_footer", "0");
                }
            else
                Registry.SetValue(base_registry_key + profile_name, "hide_footer", "0");
        }

        private void Excall_CheckedChanged(object sender, EventArgs e)
        {
            if (Use_External_Call_CheckBox.Checked)
            {
                Custom_Commands_RichTextBox.Enabled = false;
                External_Call_File_Select_Button.Enabled = true;
                Registry.SetValue(base_registry_key + profile_name, "excall", "1");
            }
            else
            {
                Custom_Commands_RichTextBox.Enabled = true;
                External_Call_File_Select_Button.Enabled = false;
                Registry.SetValue(base_registry_key + profile_name, "excall", "0");
            }
        }

        private void Select_dir_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Excall_file_Click(object sender, EventArgs e)
        {
            Echo_debug("---changing dir---");
            if (externalCallFile.ShowDialog() == DialogResult.OK)
            {
                External_Call_File_Name_Label.Text = externalCallFile.FileName;
                Registry.SetValue(base_registry_key + profile_name, "excall_file", externalCallFile.FileName);


            }
        }

        private void How_to_commands2_Click(object sender, EventArgs e)
        {
            Process.Start("http://7dsm.seanasaservice.com/custom-commands.html");
        }

        private void Zoomup_Click(object sender, EventArgs e)
        {
            overviewSplitter.Panel1Collapsed = !overviewSplitter.Panel1Collapsed;
            if(overviewSplitter.Panel1Collapsed)
                zoomup.Text = "▼";
            else
                zoomup.Text = "▲";
        }

        private void Discord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/KneMGU"); // 7DSM User Discord Channel
        }

        private void Newsbox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void News_Feed_RichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usecmd_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Text += commandslist.SelectedItem.ToString();
            }
            catch { }
        }

        private void GitHub_Repo_Button_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/imseandavis/7DaysToDie_ServerManager");
        }

        private JArray GetRESTData(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.Headers.Add("apikey", "SmpkZWI2bmhWY3lQczVOUnZXT3EzTHR5Rmp6SmlHYmVnNkFxVTVoTjdHM1M0SUVHZ0NQSlQxNFdpa1FwWm5KMC0tZlFvTWlCMXo3YitFQndJZDhaTHgvUT09--c263c337518233d4b00051b7114989af6f837328");
            webRequest.ContentType = "application/json";
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<JArray>(s);
        }

        private void Retrieve_Mods_From_Nexus_Button_Click(object sender, EventArgs e)
        {
            Mods_DataGridView.DataSource = GetRESTData("https://api.nexusmods.com/v1/games/7DaysToDie/mods/updated.json?period=1m");
            
            // SWAGGER API REF: https://app.swaggerhub.com/apis-docs/NexusMods/nexus-mods_public_api_params_in_form_data/1.0#/

            // Pull Latest Updated Mods For The Last 30 Days From Nexus
            // User Will Need Thier Own API Key From Nexus
            // Go To https://www.nexusmods.com/users/myaccount?tab=api
            // Then Scroll To Bottom and Click Generate Personal API Key

            // API CALL FOR GET LAST 30 DAYS
            // curl - X GET "https://api.nexusmods.com/v1/games/7DaysToDie/mods/updated.json?period=1m" - H "accept: application/json" - H "apikey: SmpkZWI2bmhWY3lQczVOUnZXT3EzTHR5Rmp6SmlHYmVnNkFxVTVoTjdHM1M0SUVHZ0NQSlQxNFdpa1FwWm5KMC0tZlFvTWlCMXo3YitFQndJZDhaTHgvUT09--c263c337518233d4b00051b7114989af6f837328"

            // API CALL TO GET CHANGE LOG FOR EACH GAME
            // curl -X GET "https://api.nexusmods.com/v1/games/7DaysToDie/mods/22/changelogs.json" -H "accept: application/json" -H "apikey: SmpkZWI2bmhWY3lQczVOUnZXT3EzTHR5Rmp6SmlHYmVnNkFxVTVoTjdHM1M0SUVHZ0NQSlQxNFdpa1FwWm5KMC0tZlFvTWlCMXo3YitFQndJZDhaTHgvUT09--c263c337518233d4b00051b7114989af6f837328"

            // API CALL TO GET INFO FOR EACH GAME
            // curl -X GET "https://api.nexusmods.com/v1/games/7DaysToDie/mods/22.json" -H "accept: application/json" -H "apikey: SmpkZWI2bmhWY3lQczVOUnZXT3EzTHR5Rmp6SmlHYmVnNkFxVTVoTjdHM1M0SUVHZ0NQSlQxNFdpa1FwWm5KMC0tZlFvTWlCMXo3YitFQndJZDhaTHgvUT09--c263c337518233d4b00051b7114989af6f837328"
        }

        private void NitroGEN_Map_Generator_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://7daystodie.com/forums/showthread.php?114207-Tool-NITROGEN-a-random-world-generator-for-7DtD");
        }


        #region Server Configuration File Settings OnChange Events

        private void ConfigProperty_ServerName_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ServerDescription_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ServerWebsiteURL_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ServerPassword_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ServerLoginConfirmationText_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ServerPort_ValueChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ServerVisibility_SelectedValueChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ServerDisabledNetworkProtocols_SelectedValueChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ServerMaxWorldTransferSpeedKiBs_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            ServerMaxWorldTransferSpeedKiBs_GroupBox.Text = "Server Max World Transfer Speed" + " [" + Convert.ToInt32(ConfigProperty_ServerMaxWorldTransferSpeedKiBs.Value) + " KiB/s]";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ServerMaxPlayerCount_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            ServerMaxPlayerCount_GroupBox.Text = "Max Players [" + Convert.ToString(ConfigProperty_ServerMaxPlayerCount.Value) + "]";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ServerReservedSlots_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ServerReservedSlotsPermission_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ServerAdminSlots_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ServerAdminSlotsPermission_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ControlPanelEnabled_ToggleStateChanged(object sender, ToggleStateChangedEventArgs e)
        {
            if (ConfigProperty_ControlPanelEnabled.ToggleState == ToggleButtonState.Active)
            {
                ConfigProperty_ControlPanelEnabled.Text = "true";

                // Unlock The Other Options So They Can Be Changed
                ControlPanel_Port_GroupBox.Enabled = true;
                ControlPanel_Password_GroupBox.Enabled = true;
            }
            else
            {
                ConfigProperty_ControlPanelEnabled.Text = "false";

                //Lock The Other Options So They Can't Be Changed
                ControlPanel_Port_GroupBox.Enabled = false;
                ControlPanel_Password_GroupBox.Enabled = false;
            }

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ControlPanelPort_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ControlPanelPassword_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_TelnetEnabled_ToggleStateChanged(object sender, ToggleStateChangedEventArgs e)
        {
            if (ConfigProperty_TelnetEnabled.ToggleState == ToggleButtonState.Active)
            {
                ConfigProperty_TelnetEnabled.Text = "true";

                // Unlock The Other Options So They Can Be Changed
                Telnet_Port_GroupBox.Enabled = true;
                Telnet_Password_GroupBox.Enabled = true;
                Telnet_FailedLoginLimit_GroupBox.Enabled = true;
                Telnet_FailedLoginsBlocktime_GroupBox.Enabled = true;
            }
            else
            {
                ConfigProperty_TelnetEnabled.Text = "false";

                //Lock The Other Options So They Can't Be Changed
                Telnet_Port_GroupBox.Enabled = false;
                Telnet_Password_GroupBox.Enabled = false;
                Telnet_FailedLoginLimit_GroupBox.Enabled = false;
                Telnet_FailedLoginsBlocktime_GroupBox.Enabled = false;
            }

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_TelnetPort_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_TelnetPassword_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_TelnetFailedLoginLimit_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }
        
        private void ConfigProperty_TelnetFailedLoginsBlocktime_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_TerminalWindowEnabled_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            if (ConfigProperty_TerminalWindowEnabled.ToggleState == ToggleButtonState.Active)
                ConfigProperty_TerminalWindowEnabled.Text = "true";
            else
                ConfigProperty_TerminalWindowEnabled.Text = "false";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_AdminFileName_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_UserDataFolder_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_SaveGameFolder_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_EACEnabled_ToggleStateChanged(object sender, ToggleStateChangedEventArgs e)
        {
            if (ConfigProperty_EACEnabled.ToggleState == ToggleButtonState.Active)
                ConfigProperty_EACEnabled.Text = "true";
            else
                ConfigProperty_EACEnabled.Text = "false";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_HideCommandExecutionLog_SelectedValueChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_MaxUncoveredMapChunksPerPlayer_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            MaxUncoveredMapChunksPerPlayer_GroupBox.Text = "Max Uncovered Map Chunks Per Player [" + ConfigProperty_MaxUncoveredMapChunksPerPlayer.Value + "]";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_PersistentPlayerProfiles_ToggleStateChanged(object sender, ToggleStateChangedEventArgs e)
        {
            if (ConfigProperty_PersistentPlayerProfiles.ToggleState == ToggleButtonState.Active)
                ConfigProperty_PersistentPlayerProfiles.Text = "true";
            else
                ConfigProperty_PersistentPlayerProfiles.Text = "false";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_GameWorld_SelectedValueChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_WorldGenSeed_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_WorldGenSize_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            WorldGenSize_GroupBox.Text = "World Gen Size [" + ConfigProperty_WorldGenSize.Value + "]";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_GameName_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_GameMode_SelectedValueChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_GameDifficulty_ValueChanged(object sender, RatingValueChangedEventArgs args)
        {
            // Update Text To Currently Set Value
            GameDifficulty_GroupBox.Text = "Game Difficulty" + " [" + Convert.ToString(ConfigProperty_GameDifficulty.Value) + "]";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_BlockDamagePlayer_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            if (ConfigProperty_BlockDamagePlayer.Value == 0)
                BlockDamagePlayer_GroupBox.Text = "Player Block Damage [25%]";
            else
                BlockDamagePlayer_GroupBox.Text = "Player Block Damage [" + Convert.ToInt32(ConfigProperty_BlockDamagePlayer.Value) + "%]";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_BlockDamageAI_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            if (ConfigProperty_BlockDamageAI.Value == 0)
                BlockDamageAI_GroupBox.Text = "AI Block Damage [25%]";
            else
                BlockDamageAI_GroupBox.Text = "AI Block Damage [" + Convert.ToInt32(ConfigProperty_BlockDamageAI.Value) + "%]";

            // Update The Config File With The New Value
            Update_Config();
        }
        
        private void ConfigProperty_BlockDamageAIBM_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            if (ConfigProperty_BlockDamageAIBM.Value == 0)
                BlockDamageAIBM_GroupBox.Text = "AI Block Damage During Blood Moon [25%]";
            else
                BlockDamageAIBM_GroupBox.Text = "AI Block Damage During Blood Moon [" + Convert.ToInt32(ConfigProperty_BlockDamageAIBM.Value) + "%]";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_XPMultiplier_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            if (ConfigProperty_XPMultiplier.Value == 0)
                XPMultiplier_GroupBox.Text = "XP Multiplier [25%]";
            else
                XPMultiplier_GroupBox.Text = "XP Multiplier [" + Convert.ToInt32(ConfigProperty_XPMultiplier.Value) + "%]";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_PlayerSafeZoneLevel_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_PlayerSafeZoneHours_TextChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_BuildCreate_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            if (ConfigProperty_BuildCreate.ToggleState == ToggleButtonState.Active)
                ConfigProperty_BuildCreate.Text = "true";
            else
                ConfigProperty_BuildCreate.Text = "false";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_DayNightLength_ValueChanged(object sender, EventArgs e)
        {
            // Update The Group Box Text (Realtime Minutes Per Game Day)
            if (ConfigProperty_DayNightLength.Value == 1440)
            {
                DayNightLength_GroupBox.Text = "Each In Game Day Is [Realtime]";
                DialogResult Realtime_Response = MessageBox.Show("You Have Chosen Realtime Mode! If You Continue, The Server Time Will Be Set To Your Local Time And Game Time Will Pass In Realtime!", "Set Game Time To Relatime?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Realtime_Response == DialogResult.Yes)
                {
                    try
                    {
                        // Calculate Realtime
                        string realtime_time = Convert.ToString(((Convert.ToInt32((DateTime.Now.ToString("HH"))) * 1000) - 8000) + ((60 * Convert.ToInt32((DateTime.Now.ToString("mm"))) / 100)));

                        // Execute Set Time Telnet Command
                        telnet_queue.Enqueue("settime " + realtime_time);

                        // Set Realtime Value To On
                        Registry.SetValue(base_registry_key + profile_name, "realtime", "1");
                    }
                    catch
                    {
                        // Notify User Of Failure
                        //TODO: SEND THIS AS AN ERROR REPORT
                        MessageBox.Show("Unable To Set Realtime Mode!");

                        // Decrement To Prevent Realtime
                        ConfigProperty_DayNightLength.Value = -24;

                        // Update GroupBox Text
                        DayNightLength_GroupBox.Text = "Each In Game Day Equals [" + Convert.ToInt32(ConfigProperty_DayNightLength.Value) + "] Real World Minutes";

                        // Set Realtime Value To Off
                        Registry.SetValue(base_registry_key + profile_name, "realtime", "0");
                    }
                }
                else
                {
                    // Decrement To Prevent Realtime
                    ConfigProperty_DayNightLength.Value = -24;

                    // Update GroupBox Text
                    DayNightLength_GroupBox.Text = "Each In Game Day Equals [" + Convert.ToInt32(ConfigProperty_DayNightLength.Value) + "] Real World Minutes";

                    // Set Realtime Value To Off
                    Registry.SetValue(base_registry_key + profile_name, "realtime", "0");
                }
            }
            else
            {
                // Update Groupbox Text
                DayNightLength_GroupBox.Text = "Each In Game Day Equals [" + Convert.ToInt32(ConfigProperty_DayNightLength.Value) + "] Real World Minutes";

                // Set Realtime Value To On
                Registry.SetValue(base_registry_key + profile_name, "realtime", "0");
            }

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_DayLightLength_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            DayLightLength_GroupBox.Text = "Sun Shines For [" + ConfigProperty_DayLightLength.Value + "] Hours Each Game Day ";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_DropOnDeath_SelectedValueChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_DropOnQuit_SelectedValueChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_BedrollDeadZoneSize_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            BedrollDeadZoneSize_GroupBox.Text = "Enemies Spawn At Least [" + ConfigProperty_BedrollDeadZoneSize.Value + "] Blocks From Bedroll";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_BedrollExpiryTime_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            BedrollExpiryTime_GroupBox.Text = "Bedroll Lasts [" + ConfigProperty_BedrollExpiryTime.Value + "] Game Days Offline";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_MaxSpawnedZombies_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            MaxSpawnedZombies_GroupBox.Text = "[" + Convert.ToString(ConfigProperty_MaxSpawnedZombies.Value) + "] Zombies Spawned Per Player";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_MaxSpawnedAnimals_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            MaxSpawnedAnimals_GroupBox.Text = "[" + Convert.ToString(ConfigProperty_MaxSpawnedAnimals.Value) + "] Animals Spawned Per Player";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ServerMaxAllowedViewDistance_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            ServerMaxAllowedViewDistance_GroupBox.Text = "[" + Convert.ToString(ConfigProperty_ServerMaxAllowedViewDistance.Value) + "] Animals Spawned Per Player";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_EnemySpawnMode_ToggleStateChanged(object sender, ToggleStateChangedEventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_EnemyDifficulty_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            if (ConfigProperty_EnemyDifficulty.ToggleState == ToggleButtonState.Active)
                ConfigProperty_EnemyDifficulty.Text = "1";
            else
                ConfigProperty_EnemyDifficulty.Text = "0";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ZombieMove_SelectedValueChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ZombieMoveNight_SelectedValueChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ZombieFeralMove_SelectedValueChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_ZombieBMMove_SelectedValueChanged(object sender, EventArgs e)
        {
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_BloodMoonFrequency_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            BloodMoonFrequency_GroupBox.Text = "Blood Moon Frequency [" + Convert.ToString(ConfigProperty_BloodMoonFrequency.Value) + "]";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_BloodMoonRange_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            BloodMoonRange_GroupBox.Text = "Blood Moon Deviation [" + Convert.ToString(ConfigProperty_BloodMoonRange.Value) + "]";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_BloodMoonWarning_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            BloodMoonWarning_GroupBox.Text = "Blood Moon Red Day Text Warning [" + Convert.ToString(ConfigProperty_BloodMoonWarning.Value) + "]";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_BloodMoonEnemyCount_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            BloodMoonEnemyCount_GroupBox.Text = "Zombies Spawned Per Player During Blood Moon [" + ConfigProperty_BloodMoonEnemyCount.Value + "]";
            
            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_LootAbundance_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            if (ConfigProperty_LootAbundance.Value == 0)
                LootAbundance_GroupBox.Text = "Loot Abundance [25%]";
            else
                LootAbundance_GroupBox.Text = "Loot Abundance [" + Convert.ToInt32(ConfigProperty_LootAbundance.Value) + "%]";

            // Update The Config File With The New Value
            Update_Config();
        }

        private void SelectInstance_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save The Current Server Instance Settings
            Save_Server_Instance();

            // Load The Settings For The Newly Selected Server Instance
            Load_Server_Instance();
        }

        private void ConfigProperty_LootRespawnDays_ValueChanged(object sender, EventArgs e)
        {
            // Update Text To Currently Set Value
            if (ConfigProperty_LootRespawnDays.Value == -1)
            {
                LootRespawnDays_GroupBox.Text = "Loot Respawn Time [ Disabled ]";
            }
            else if (ConfigProperty_LootRespawnDays.Value == 0)
            {
                // Set The Minimum Ammount
                ConfigProperty_LootRespawnDays.Value = 1;

                // Update Text To Currently Set Value
                LootRespawnDays_GroupBox.Text = "Loot Respawns Every [" + Convert.ToInt32(ConfigProperty_LootRespawnDays.Value) + " days]";
            }
            else
            {
                // Update Text To Currently Set Value
                LootRespawnDays_GroupBox.Text = "Loot Respawns Every [" + Convert.ToInt32(ConfigProperty_LootRespawnDays.Value) + " days]";
            }

            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_AirDropFrequency_ValueChanged(object sender, EventArgs e)
        {
            //TODO - NEEDS GROUP BOX TEXT UPDATE CODE


            // Update The Config File With The New Value
            Update_Config();
        }

        private void ConfigProperty_AirDropMarker_ToggleStateChanged(object sender, ToggleStateChangedEventArgs e)
        {
            if (ConfigProperty_AirDropMarker.ToggleState == ToggleButtonState.Active)
                ConfigProperty_AirDropMarker.Text = "true";
            else
                ConfigProperty_AirDropMarker.Text = "false";

            // Update The Config File With The New Value
            Update_Config();
        }

        #endregion

    }

}