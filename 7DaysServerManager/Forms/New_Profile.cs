using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using System.Xml;
using System.Resources;

namespace _7DaysServerManager
{
    public partial class New_Profile : Form
    {
        string profile_name="";

        public New_Profile()
        {
            InitializeComponent();
        }

        public string Lang(string text)
        {
            ResourceManager rm = new ResourceManager("_7DaysServerManager.lang.lang_en", this.GetType().Assembly);


            return rm.GetString(text);
        }

        public void Load_lang()
        {
            fr_hi.Text = Lang("fr_hi");
            next.Text = Lang("next");
            fr_detect.Text = Lang("fr_detect");
            auto.Text = Lang("auto");
            manual.Text = Lang("manual");
            fr_fin.Text = Lang("fr_fin");
            fr_end.Text = Lang("fr_end");
        }

        private void Flag_pl_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "lang", "pl");
            Load_lang();
            licz.Text = Convert.ToString(Convert.ToInt32(licz.Text) + 1);
            tabControl1.SelectedIndex = 1;
        }

        private void Flag_us_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "lang", "en");
            Load_lang();
            licz.Text = Convert.ToString(Convert.ToInt32(licz.Text) + 1);
            tabControl1.SelectedIndex = 1;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pb.Value = Convert.ToInt32(licz.Text) - 1;
            tabControl1.SelectedIndex = Convert.ToInt32(licz.Text) - 1;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            bool busy = false;

            try
            {
                // Open the Base Registry Key And Retrieve The Current Values 
                String[] values = Registry.CurrentUser.OpenSubKey(@"Software\7DSM").GetSubKeyNames();

                foreach (String value in values)
                    if (value == profname.Text)
                        busy = true;
            }
            catch { }
            


            if (profname.Text != "" && !busy)
            {
                profile_name = profname.Text;
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "always_on_top", "0");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "save_logfiles", "1");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "show_ip", "1");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "spam_list", "");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "spam_time", 20);
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "spawn_box", "0");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "spawn_zombie", "0");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "survey_done", "0");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "to_tray", "0");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "reg_key", "0");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "reg_user", "0");

                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "last_profile", profile_name);

                licz.Text = Convert.ToString(Convert.ToInt32(licz.Text) + 1);
                tabControl1.SelectedIndex = 1;
            }
            else if (busy)
            {
                MessageBox.Show("Profile with this name already exist.");
            }else
            {
                MessageBox.Show(Lang("no_prof_name"), Lang("error"));
            }
        }

        private void Auto_Click(object sender, EventArgs e)
        {
            try
            {
                string sciezka = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null);
                sciezka = sciezka.Replace("/", "\\");

                sciezka += "\\steamapps\\common\\7 Days To Die";


                if (File.Exists(@sciezka + "\\" + exe_name.Text))
                {
                    MessageBox.Show(Lang("steam_ok"), Lang("saved"));
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "game_path", sciezka);
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "server_type", "client");
                    licz.Text = Convert.ToString(Convert.ToInt32(licz.Text) + 1);
                    tabControl1.SelectedIndex = 2;
                }
                else
                {
                    sciezka += " Dedicated Server";
                    if (File.Exists(@sciezka + "\\7DaysToDieServer.exe"))
                    {
                        MessageBox.Show(Lang("steam_ok"), Lang("saved"));
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "game_path", sciezka);
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "server_type", "server");
                        licz.Text = Convert.ToString(Convert.ToInt32(licz.Text) + 1);
                        tabControl1.SelectedIndex = 2;
                    }
                    else
                    {

                        MessageBox.Show(Lang("steam_no_game"), Lang("error"));
                    }
                }


            }
            catch
            {
                MessageBox.Show(Lang("steam_no_steam"), Lang("error"));
            }
        }

        private void Manual_Click(object sender, EventArgs e)
        {
            if (select_dir.ShowDialog() == DialogResult.OK)
            {
                string sciezka_plikow = select_dir.SelectedPath + "\\" + exe_name.Text;
                string sciezka_plikow_server = select_dir.SelectedPath + "\\7DaysToDieServer.exe";

                if (File.Exists(@sciezka_plikow))
                {
                    MessageBox.Show(Lang("dir_ok"), Lang("saved"));
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "game_path", select_dir.SelectedPath);
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "server_type", "client");

                    licz.Text = Convert.ToString(Convert.ToInt32(licz.Text) + 1);
                    tabControl1.SelectedIndex = 2;

                }else if (File.Exists(@sciezka_plikow_server))
                {
                    MessageBox.Show(Lang("dir_ok"), Lang("saved"));
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "game_path", select_dir.SelectedPath);
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "server_type", "server");

                    licz.Text = Convert.ToString(Convert.ToInt32(licz.Text) + 1);
                    tabControl1.SelectedIndex = 2;

                }
                else
                {
                    MessageBox.Show(Lang("game_not_found_2"), Lang("error"));
                }



            }
        }

        private void Fr_fin_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profile_name, "exe_name", exe_name.Text);
            
            /*System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();*/
            
            //!!reload list
            DataContainer.reload_now = true;
            this.Close();
        }


        private void First_run_Load(object sender, EventArgs e)
        {
            Load_lang();
        }

        private void Select_dir_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
