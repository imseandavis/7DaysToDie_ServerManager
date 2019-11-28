using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;


namespace _7DaysServerManager
{

    public partial class Server_Panel_Form : Form
    {

        public string[] GetPrefixes(Boolean all_of_them)
        {
            List<string> pref = new List<string>
            {

                //Android List
                "http://+:17011/widget/",
                "http://+:17011/widget/{aak}/",

                "http://+:80/",
                "http://+:80/rules/",
                "http://+:80/shop/"
            };

            string[] prefixes = pref.ToArray<string>();

            return prefixes;
        }

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void Prepare_app_after_start()
        {


            main_log_stream = new FileStream("server.log", FileMode.Append, FileAccess.Write);
            main_log = new StreamWriter(main_log_stream, Encoding.UTF8);

            chat_log_stream = new FileStream("chat.log", FileMode.Append, FileAccess.Write);
            chat_log = new StreamWriter(chat_log_stream, Encoding.UTF8);







            /*
            if (dev)
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "dev", "1");
                updates_channel.SelectedIndex = 1;
            }
            else
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "dev", "0");
                updates_channel.SelectedIndex = 0;
            }
            */






            Echo_debug("7DaysServerManager ver: " + ver + " game ver: " + game_ver + "\nDEBUG MODE");

            if ((string)Registry.GetValue(base_registry_key + profile_name, "anon_data", null) == "0")
            {
                Settings_Allow_Anon_Data_CheckBox.Checked = false;
            }



            //echo(" ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄   ▄▄▄▄▄▄▄▄▄▄▄  ▄▄       ▄▄ \n▐░░░░░░░░░░░▌▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌▐░░▌     ▐░░▌\n ▀▀▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌   ▐░▐░▌\n         ▐░▌ ▐░▌       ▐░▌▐░▌          ▐░▌▐░▌ ▐░▌▐░▌\n        ▐░▌  ▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▐░▌ ▐░▌\n       ▐░▌   ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌\n      ▐░▌    ▐░▌       ▐░▌ ▀▀▀▀▀▀▀▀▀█░▌▐░▌   ▀   ▐░▌\n     ▐░▌     ▐░▌       ▐░▌          ▐░▌▐░▌       ▐░▌\n    ▐░▌      ▐░█▄▄▄▄▄▄▄█░▌ ▄▄▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌\n   ▐░▌       ▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌▐░▌       ▐░▌\n    ▀         ▀▀▀▀▀▀▀▀▀▀   ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀", 0, true);



            Echo("7DaysServerManager " + ver + " (Compiled " + Convert.ToString(AssemblyCreationDate.Value) + ")", 0, true);
            //echo("Compilation date: " + Convert.ToString(AssemblyCreationDate.Value), 0, true);












            /*pobierz wszystkie mapy*/
            //mapa.Items.Clear();
            try
            {
                string[] wszystkie_mapy = System.IO.Directory.GetDirectories((string)Registry.GetValue(base_registry_key + profile_name, "game_path", null) + "\\Data\\Worlds\\", "*", System.IO.SearchOption.TopDirectoryOnly);


                foreach (string dany_save in wszystkie_mapy)
                {
                    ConfigProperty_GameWorld.Items.Add(dany_save.Replace((string)Registry.GetValue(base_registry_key + profile_name, "game_path", null) + "\\Data\\Worlds\\", ""));
                }
            }
            catch { }
            try
            {
                ConfigProperty_GameWorld.Text = "Navezgane";
            }
            catch { }
            /*kuniec*/










            Import_Config();

            Load_Languages();

            workers_list.RunWorkerAsync();

            Spawn_Item_ComboBox.SelectedIndex = 0;







            Echo_debug("---checking update---");

            if (File.Exists("server_updater.exe"))
            {
                try
                {
                    File.Delete("server_updater.exe");
                    MessageBox.Show(LocalizedLanguage("update_ok"), LocalizedLanguage("update"));
                    Echo(LocalizedLanguage("update_ok"), 0, true);
                    MessageBox.Show(whatsnew, "What's new in ServerManager " + ver);
                }
                catch
                {
                    MessageBox.Show(LocalizedLanguage("err_su_rem"), LocalizedLanguage("error"));
                }

                try
                {
                    File.Delete("7DaysServerManager-dev.exe");
                }
                catch { }
            }





            /*string update_avaible = "0";
            System.Net.WebClient client;

            client = new System.Net.WebClient();
            
            try
            {
                update_avaible = client.DownloadString("https://7dsm.smartmoose.org/system/updates/" + ver + ".txt");
            }
            catch
            {
                update_avaible = "err";
                echo(lang("upd_err"), 3, true);
            }

            if (update_avaible == "1")
            {
                echo(lang("upd_ava"), 2, true);
                DialogResult dialogResult = MessageBox.Show(lang("upd_ava_2"), lang("update"), MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    update up = new update();
                    up.Show();
                }

            }
            else if(update_avaible!="err")
            {
                echo("You have latest version of 7DSM :)", 1, true);
            }*/





            if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "install_id", null) == null)
            {
                long min = 10000000000001;
                long max = 99999999999999;
                Random random = new Random();
                long randomNumber = min + random.Next() % (max - min);
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "install_id", randomNumber);
            }



            Echo_debug("---getting srv IP---");






            try
            {
                stats.RunWorkerAsync();
            }
            catch { }


            /*
             * if (!dev)
                this.Text = this.Text + " " + ver + " (" + lang("title_ver") + " " + game_ver + ", profile: " + profile_name + ")";
            else
                this.Text = this.Text + " " + ver + "DEV (" + lang("title_ver") + " " + game_ver + ", profile: " + profile_name + ") [DEV BUILD- MAY CONTAIN BUGS]";
            */

            status_updater.RunWorkerAsync();






            /*if ((string)Registry.GetValue(base_registry_key + profile_name, "game_path", null) == null)
            {
                first_run fr = new first_run();
                fr.Show();
                this.Opacity = 0;
                this.ShowInTaskbar = false;
            }*/


            if ((string)Registry.GetValue(base_registry_key + profile_name, "save_logfiles", null) == "1")
            {
                Save_Logs_To_Files_CheckBox.Checked = true;
                Save_Logs_CheckBox.Checked = true;
            }

            if ((string)Registry.GetValue(base_registry_key + profile_name, "realtime", null) == "1")
            {
                DayNightLength_Realtime_Mode.Checked = true;
            }


            if ((string)Registry.GetValue(base_registry_key + profile_name, "auto_backup", null) == "1")
            {
                auto_backup_check.Checked = true;
                backup_chat.Enabled = true;
                backup_time.Enabled = true;

            }

            if ((string)Registry.GetValue(base_registry_key + profile_name, "backup_chat", null) == "1")
            {
                backup_chat.Checked = true;
            }

            if ((string)Registry.GetValue(base_registry_key + profile_name, "android_allow", null) == "1")
            {
                android_allow.Checked = true;
            }

            if ((string)Registry.GetValue(base_registry_key + profile_name, "enable_website", null) == "1")
            {
                enable_website.Checked = true;
            }


            if ((string)Registry.GetValue(base_registry_key + profile_name, "autoupdate_whitelist", null) == "1")
            {
                Auto_Update_Whitelist_CheckBox.Checked = true;
            }


            try
            {
                int auto_backup_time_v = (int)Registry.GetValue(base_registry_key + profile_name, "backup_time", null);
                backup_time.Value = auto_backup_time_v;


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

                auto_backup_group.Text = LocalizedLanguage("backup_time") + " [" + hrs_s + ":" + min_s + " h.]";
            }
            catch { auto_backup_group.Text = LocalizedLanguage("backup_time"); }




            if ((string)Registry.GetValue(base_registry_key + profile_name, "spam_is_spam", null) == "1")
            {
                Server_Commands_Say_Switch_CheckBox.Checked = true;
            }







            if ((string)Registry.GetValue(base_registry_key + profile_name, "auto_reset", null) == "1")
            {
                Enable_Auto_Restarts_CheckBox.Checked = true;
                Warn_Before_Restart_CheckBox.Enabled = true;
                Auto_Restart_Time_TrackBar.Enabled = true;

            }

            if ((string)Registry.GetValue(base_registry_key + profile_name, "reset_chat", null) == "0")
            {
                Warn_Before_Restart_CheckBox.Checked = false;
            }

            try
            {
                int auto_reset_time_v = (int)Registry.GetValue(base_registry_key + profile_name, "reset_time", null);
                Auto_Restart_Time_TrackBar.Value = auto_reset_time_v;


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

                Auto_Restarts_GroupBox.Text = LocalizedLanguage("reset_g") + " [" + hrs_s + ":" + min_s + " h.]";
            }
            catch { Auto_Restarts_GroupBox.Text = LocalizedLanguage("reset_g"); }








            if ((string)Registry.GetValue(base_registry_key + profile_name, "start_with_7dsm", null) == "1")
            {
                Start_With_7DSM_CheckBox.Checked = true;
            }


            if (Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "7DaysServerManager", null) != null)
            {
                Start_7DSM_With_Windows_CheckBox.Checked = true;
            }





            if ((string)Registry.GetValue(base_registry_key + profile_name, "use_wl", null) == "1")
            {
                Use_Whitelist_CheckBox.Checked = true;
            }



            if ((string)Registry.GetValue(base_registry_key + profile_name, "sql_enabled", null) == "1")
            {
                SQL_Enabled_CheckBox.Checked = true;
            }



            if ((string)Registry.GetValue(base_registry_key + profile_name, "cleanexit", null) == "0")
            {
                Settings_Clean_Exit_CheckBox.Checked = false;
            }

            if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "skip_profiles", null) == "1")
            {
                Settings_Skip_Profiles_CheckBox.Checked = true;
            }

            if ((string)Registry.GetValue(base_registry_key + profile_name, "show_ip", null) == "1")
            {
                Public_IP_Address_Label.Visible = true;
                Settings_Show_IPS_CheckBox.Checked = true;
            }





            if ((string)Registry.GetValue(base_registry_key + profile_name, "always_on_top", null) == "1")
            {
                Settings_Always_On_Top_CheckBox.Checked = true;
                this.TopMost = true;
            }

            if ((string)Registry.GetValue(base_registry_key + profile_name, "to_tray", null) == "1")
            {
                Settings_Send_To_Tray_CheckBox.Checked = true;
            }

            if ((string)Registry.GetValue(base_registry_key + profile_name, "hide_don_btn", null) == "1")
            {
                Hide_Donation_Buttons_CheckBox.Checked = true;
            }


            if ((string)Registry.GetValue(base_registry_key + profile_name, "rem_old_backups", null) == "1")
            {
                rem_old_backups.Checked = true;
            }

            if ((string)Registry.GetValue(base_registry_key + profile_name, "dtds_enable", null) == "1")
            {
                dtds_enable.Checked = true;
            }


            if ((string)Registry.GetValue(base_registry_key + profile_name, "sendbans", null) == "0")
            {
                sendbans.Checked = false;
            }


            if ((string)Registry.GetValue(base_registry_key + profile_name, "glob", null) == "0")
            {
                glob_0.Checked = true;
            }
            else if ((string)Registry.GetValue(base_registry_key + profile_name, "glob", null) == "1")
            {
                glob_1.Checked = true;
            }
            else if ((string)Registry.GetValue(base_registry_key + profile_name, "glob", null) == "2")
            {
                glob_2.Checked = true;
            }
            else if ((string)Registry.GetValue(base_registry_key + profile_name, "glob", null) == "3")
            {
                glob_3.Checked = true;
            }



            if ((string)Registry.GetValue(base_registry_key + profile_name, "excall", null) == "1")
            {
                Use_External_Call_CheckBox.Checked = true;
            }

            if ((string)Registry.GetValue(base_registry_key + profile_name, "excall_file", null) != null)
            {
                External_Call_File_Name_Label.Text = (string)Registry.GetValue(base_registry_key + profile_name, "excall_file", null);
            }



            string aak = "";
            try
            {
                aak = (string)Registry.GetValue(base_registry_key + profile_name, "android_access_key", null);
                //echo_debug(aak);

                if (aak == null)
                {
                    Echo_debug("AAK");
                    aak = CreatePassword(5);
                    Registry.SetValue(base_registry_key + profile_name, "android_access_key", aak);
                }

                android_access_key.Text = "Android access key: " + aak;
            }
            catch (Exception e)
            {
                Echo_debug(e + "");
            }



            try
            {
                string psw = (string)Registry.GetValue(base_registry_key + profile_name, "rem_old_backups_count", null);
                rem_old_backups_count.Text = psw;
            }
            catch { }

            try
            {
                string psw = (string)Registry.GetValue(base_registry_key + profile_name, "dtds_auth", null);
                dtds_auth.Text = psw;
            }
            catch { }


            try
            {
                string psw = (string)Registry.GetValue(base_registry_key, "prem_code", null);
                Support_Code_TextBox.Text = psw;
            }
            catch { }



            try
            {
                int s_time = (int)Registry.GetValue(base_registry_key + profile_name, "spam_time", null);
                Server_Commands_Time_TrackBar.Value = s_time;
            }
            catch { }






            if ((string)Registry.GetValue(base_registry_key + profile_name, "debug_log", null) == "1")
            {
                debug_log.Checked = true;
                debug_mode = true;
            }



            







            try
            {
                string full = (string)Registry.GetValue(base_registry_key + profile_name, "dtds_items", null);

                string[] poj = full.Split(';');

                foreach (string p in poj)
                {
                    dtds_lista.Items.Add(p);
                }
            }
            catch { }






            //kopiowanie itemów
            object[] dtds_temp_items = new object[Spawn_Item_ComboBox.Items.Count];
            Spawn_Item_ComboBox.Items.CopyTo(dtds_temp_items, 0);
            dtds_possible.Items.AddRange(dtds_temp_items);
            dtds_possible.SelectedIndex = 0;




            Server_Commands_Delay_GroupBox.Text = LocalizedLanguage("spam_time") + " [" + Server_Commands_Time_TrackBar.Value * 0.5 + " min.]";

            Server_Commands_List_RichTextBox.Text = (string)Registry.GetValue(base_registry_key + profile_name, "spam_list", null);

            SQL_Host_TextBox.Text = (string)Registry.GetValue(base_registry_key + profile_name, "sql_host", null);
            SQL_Username_TextBox.Text = (string)Registry.GetValue(base_registry_key + profile_name, "sql_username", null);
            SQL_Password_TextBox.Text = (string)Registry.GetValue(base_registry_key + profile_name, "sql_password", null);
            SQL_Database_Name_TextBox.Text = (string)Registry.GetValue(base_registry_key + profile_name, "sql_db_name", null);







            Auto_Update_External_Whitelist_URL_TextBox.Text = (string)Registry.GetValue(base_registry_key + profile_name, "wl_add", null);
            Update_Whitelist_Interval_TextBox.Text = (string)Registry.GetValue(base_registry_key + profile_name, "wl_interval", null);





            Game_File_Path_Label.Text = LocalizedLanguage("path") + (string)Registry.GetValue(base_registry_key + profile_name, "game_path", null);

            if (Game_File_Path_Label.Text == LocalizedLanguage("path"))
                Game_File_Path_Label.Text = LocalizedLanguage("path") + "ERROR- NONE";


            Max_Players_GroupBox.Text = LocalizedLanguage("maxplgroup") + " [" + Convert.ToString(ConfigProperty_ServerMaxPlayerCount.Value) + "]";
            GameDifficulty_GroupBox.Text = LocalizedLanguage("trudnoscgroup") + " [" + Convert.ToString(ConfigProperty_GameDifficulty.Value) + "]";
            DayNightLength_GroupBox.Text = LocalizedLanguage("dlugoscdnia") + " [" + Convert.ToString(ConfigProperty_DayNightLength.Value) + " min.]";






            Realtime_prepare();







            /*try
            {
                string[] news = client.DownloadString("https://7dsm.smartmoose.org/system/news.php").Split(';');
                echo(news[1], Convert.ToInt32(news[0]), true);
            }
            catch { }*/









            if ((string)Registry.GetValue(base_registry_key, "tmp_prem", null) == "1")
            {
                Echo_debug("local premium valid, unlocking");
                Unlock_Premium();
            }









            Download_maps(ConfigProperty_GameWorld.Text);






            if ((string)Registry.GetValue(base_registry_key + profile_name, "exe_name", null) == null || (string)Registry.GetValue(base_registry_key + profile_name, "exe_name", null) == "")
                exe_name.Text = "7DaysToDie.exe";
            else
                exe_name.Text = (string)Registry.GetValue(base_registry_key + profile_name, "exe_name", null);







            /*if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "show_hello_msg", null) != "0")
            {
                hello show_msg = new hello();
                show_msg.Show();
            }*/

            if ((string)Registry.GetValue(base_registry_key + profile_name, "backup_msg_1", null) == null || (string)Registry.GetValue(base_registry_key + profile_name, "backup_msg_1", null) == "")
                Starting_Backup_Message_TextBox.Text = LocalizedLanguage("chat_backup_1");
            else
                Starting_Backup_Message_TextBox.Text = (string)Registry.GetValue(base_registry_key + profile_name, "backup_msg_1", null);


            if ((string)Registry.GetValue(base_registry_key + profile_name, "backup_msg_2", null) == null || (string)Registry.GetValue(base_registry_key + profile_name, "backup_msg_2", null) == "")
                Backup_Completed_Message_TextBox.Text = LocalizedLanguage("chat_backup_2");
            else
                Backup_Completed_Message_TextBox.Text = (string)Registry.GetValue(base_registry_key + profile_name, "backup_msg_2", null);


            if ((string)Registry.GetValue(base_registry_key + profile_name, "reboot_time", null) == null || (string)Registry.GetValue(base_registry_key + profile_name, "reboot_time", null) == "")
                reboot_time.Text = LocalizedLanguage("reset_time_left");
            else
                reboot_time.Text = (string)Registry.GetValue(base_registry_key + profile_name, "reboot_time", null);

            if ((string)Registry.GetValue(base_registry_key + profile_name, "reboot", null) == null || (string)Registry.GetValue(base_registry_key + profile_name, "reboot", null) == "")
                reboot.Text = LocalizedLanguage("rebooting");
            else
                reboot.Text = (string)Registry.GetValue(base_registry_key + profile_name, "reboot", null);


            if ((string)Registry.GetValue(base_registry_key + profile_name, "cmd_not_yet", null) == null || (string)Registry.GetValue(base_registry_key + profile_name, "cmd_not_yet", null) == "")
                cmd_not_yet.Text = LocalizedLanguage("cmd_not_yet");
            else
                cmd_not_yet.Text = (string)Registry.GetValue(base_registry_key + profile_name, "cmd_not_yet", null);




            if ((string)Registry.GetValue(base_registry_key + profile_name, "configfile", null) == null || (string)Registry.GetValue(base_registry_key + profile_name, "configfile", null) == "")
                ConfigProperty_UserDataFolder.Text = "serverconfig.xml";
            else
                ConfigProperty_UserDataFolder.Text = (string)Registry.GetValue(base_registry_key + profile_name, "configfile", null);



            if ((string)Registry.GetValue(base_registry_key + profile_name, "cc", null) == null)
                Custom_Commands_RichTextBox.Text = "whoami:say \"You are %player%\":0\nrules:say \"No cheating!\":0\nkit:spawnentity %player% 32;say \"Here you are\":3600\nhelp:say \"Available commands are whoami, kit and rules\":0";
            else
                Custom_Commands_RichTextBox.Text = (string)Registry.GetValue(base_registry_key + profile_name, "cc", null);





            if ((string)Registry.GetValue(base_registry_key + profile_name, "www_main_content", null) != null)
            {
                www_main_content.Text = (string)Registry.GetValue(base_registry_key + profile_name, "www_main_content", null);
            }


            if ((string)Registry.GetValue(base_registry_key + profile_name, "rules_content", null) != null)
            {
                rules_content.Text = (string)Registry.GetValue(base_registry_key + profile_name, "rules_content", null);
            }

            if ((string)Registry.GetValue(base_registry_key + profile_name, "forum_url", null) != null)
            {
                forum_url.Text = (string)Registry.GetValue(base_registry_key + profile_name, "forum_url", null);
            }


            if ((string)Registry.GetValue(base_registry_key + profile_name, "backup_location", null) == null)
                backup_location.Text = AppDomain.CurrentDomain.BaseDirectory + "backups";
            else
                backup_location.Text = (string)Registry.GetValue(base_registry_key + profile_name, "backup_location", null);


            if ((string)Registry.GetValue(base_registry_key + profile_name, "enable_cc", null) == "1")
            {
                Enable_Custom_Commands_CheckBox.Checked = true;
            }

            this.KeyPreview = true;

            Refresh_backups_list();


            if (translation_error)
            {
                Echo("There are problems with language file.", 3, true);
                Echo("If You're author of translation type \"local transerr\" otherwise look for updated lang.xml file.", 2, true);
            }

            if (Start_With_7DSM_CheckBox.Checked)
                Run_Server();


            file_log = debug_log.Checked;



            try
            {
                using (StreamReader sr = new StreamReader("7dsm_players_history.txt"))
                {
                    while (-1 < sr.Peek())
                    {
                        try
                        {
                            string name = sr.ReadLine();
                            string steamid = sr.ReadLine();
                            var lvi = new ListViewItem(name);
                            lvi.SubItems.Add(steamid);
                            All_Players_List.Items.Add(lvi);
                        }
                        catch (Exception) { }
                    }
                    sr.Close();
                }
            }
            catch { }



            if(enable_website.Checked || android_allow.Checked)
                StartWebServer();



            Echo_debug("->prepare_app_after_start finished task!");

        }






        // Fire Up the 7 Days to Die Server Manager Webserver
        public void StartWebServer()
        {

            if (webserver_running)
                return;
            else
                webserver_running = true;



            Echo_debug("*STARTWEBSERVER*");

            string[] prefixes = GetPrefixes(false);

            //string[] prefixes = new string[] { "http://+:80/" };

            string aak = "";
            try
            {
                aak = (string)Registry.GetValue(base_registry_key + profile_name, "android_access_key", null);

                if (aak == null)
                {
                    aak = CreatePassword(5);
                    Registry.SetValue(base_registry_key + profile_name, "android_access_key", aak);
                }
            }
            catch (Exception e)
            {
                Echo_debug(e + "");
            }

            foreach (string s in prefixes)
            {
                _listener.Prefixes.Add(s.Replace("{aak}", aak));

                Echo_debug(s.Replace("{aak}", aak));
            }


            try
            {
                _listener.Stop();
                _listener.Start();
                RunWebServer();
            }
            catch (Exception e)
            {
                //Not Authorized!

                Echo_debug(""+e);

                Fix_WebServer();

            }
        }



        void Fix_WebServer()
        {
            string[] prefixes = GetPrefixes(true);
            android_allow.Checked = false;
            enable_website.Checked = false;

            string aak = "";
            try
            {
                aak = (string)Registry.GetValue(base_registry_key + profile_name, "android_access_key", null);

                if (aak == null)
                {
                    aak = CreatePassword(5);
                    Registry.SetValue(base_registry_key + profile_name, "android_access_key", aak);
                }
            }
            catch (Exception e)
            {
                Echo_debug(e + "");
            }

            String all_comds = "";


            string comd = "netsh http delete urlacl url={prefix}";

            foreach (string s in prefixes)
            {
                all_comds += comd.Replace("{prefix}", s).Replace("{aak}", aak) + "\n";
                Echo_debug(comd.Replace("{prefix}", s).Replace("{aak}", aak) + "\n");
            }

            comd = "netsh http add urlacl url={prefix} user=" + Environment.UserDomainName + "\\" + Environment.UserName;

            foreach (string s in prefixes)
            {
                all_comds += comd.Replace("{prefix}", s).Replace("{aak}", aak) + "\n";
                Echo_debug(comd.Replace("{prefix}", s).Replace("{aak}", aak) + "\n");
            }


            DialogResult dialogResult = MessageBox.Show("7DSM does not have proper permissions to run WebServer that is needed for integrated website engine or Android widget.\n" +
            "You will be asked to grant 7DSM administrative rights.\n" +
            "Please click \"Yes\" in the Windows UAC window.\n" +
            "This is one-time operation.\n\n" +
            "Do you want to see details before executing?"
            , "IMPORTANT!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            string obrobiony = all_comds.Replace("\n", " & ");
            obrobiony = obrobiony.Remove(obrobiony.Length - 2);
            //obrobiony += " & netsh advfirewall firewall add rule name=\"7DSM\" dir=in action=allow program=\"" + System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + "\" enable=yes";
            // TODO YOU NEED TO MAKE SURE THERES NOT SOMETHING ALREADY ON 80
            obrobiony += " & netsh advfirewall firewall add rule name=\"Open Port 80 (7DSM WebServer)\" dir=in action=allow protocol=TCP localport=80";
            obrobiony += " & netsh advfirewall firewall add rule name=\"Open Port 17011 (7DSM Widget Server)\" dir=in action=allow protocol=TCP localport=17011";


            if (dialogResult == DialogResult.Yes)
                MessageBox.Show("Following commands will be executed on administrative rights:\n\n" + obrobiony);



            Echo_debug(obrobiony);

            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", "/c " + obrobiony)
            {
                Verb = "runas",
                WindowStyle = ProcessWindowStyle.Hidden
            };

            try
            {
                System.Diagnostics.Process.Start(startInfo);
            }
            catch
            {
                MessageBox.Show("Either you clicked \"No\" or other problem occured.", "Error");
            }

            MessageBox.Show("Please RESTART 7DSM to make it work:)");

        }


        void Cancel_WebServer()
        {
            string[] prefixes = GetPrefixes(true);
            android_allow.Checked = false;
            enable_website.Checked = false;

            string aak = "";
            try
            {
                aak = (string)Registry.GetValue(base_registry_key + profile_name, "android_access_key", null);

                if (aak == null)
                {
                    aak = CreatePassword(5);
                    Registry.SetValue(base_registry_key + profile_name, "android_access_key", aak);
                }
            }
            catch (Exception e)
            {
                Echo_debug(e + "");
            }


            String all_comds = "";


            string comd = "netsh http delete urlacl url={prefix}";

            foreach (string s in prefixes)
            {
                all_comds += comd.Replace("{prefix}", s).Replace("{aak}", aak) + "\n";
                Echo_debug(comd.Replace("{prefix}", s).Replace("{aak}", aak) + "\n");
            }


            DialogResult dialogResult = MessageBox.Show(
            "Do you want to see details before executing?"
            , "Cancel reservations", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            // Initi Processed Commands
            string processed = all_comds.Replace("\n", " & ");
            processed = processed.Remove(processed.Length - 2);



            if (dialogResult == DialogResult.Yes)
                MessageBox.Show("Following commands will be executed on administrative rights:\n\n" + processed);



            Echo_debug(processed);

            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", "/c " + processed)
            {
                Verb = "runas",
                WindowStyle = ProcessWindowStyle.Hidden
            };
            try
            {
                System.Diagnostics.Process.Start(startInfo);
            }
            catch
            {
                MessageBox.Show("Either you clicked \"No\" or other problem occured.", "Error");
            }

        }





    }
}
