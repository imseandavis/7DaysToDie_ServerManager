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
    public partial class new_profile : Form
    {
        string profile_name="";

        public new_profile()
        {
            InitializeComponent();
        }

        public string lang(string text)
        {
            ResourceManager rm = new ResourceManager("_7DaysServerManager.lang.lang_en", this.GetType().Assembly);


            return rm.GetString(text);
        }

        public void load_lang()
        {
            fr_hi.Text = lang("fr_hi");
            next.Text = lang("next");
            fr_detect.Text = lang("fr_detect");
            auto.Text = lang("auto");
            manual.Text = lang("manual");
            fr_fin.Text = lang("fr_fin");
            fr_end.Text = lang("fr_end");
        }

        private void flag_pl_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "lang", "pl");
            load_lang();
            licz.Text = Convert.ToString(Convert.ToInt32(licz.Text) + 1);
            tabControl1.SelectedIndex = 1;
        }

        private void flag_us_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "lang", "en");
            load_lang();
            licz.Text = Convert.ToString(Convert.ToInt32(licz.Text) + 1);
            tabControl1.SelectedIndex = 1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pb.Value = Convert.ToInt32(licz.Text) - 1;
            tabControl1.SelectedIndex = Convert.ToInt32(licz.Text) - 1;
        }

        private void next_Click(object sender, EventArgs e)
        {
            bool zajety = false;

            try
            {
                String[] values = Registry.CurrentUser.OpenSubKey(@"Software\pionner\7DSM").GetSubKeyNames();

                foreach (String value in values)
                    if (value == profname.Text)
                        zajety = true;
            }
            catch { }
            


            if (profname.Text != "" && !zajety)
            {
                profile_name = profname.Text;
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "always_on_top", "0");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "save_logfiles", "1");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "show_ip", "1");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "spam_list", "");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "spam_time", 20);
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "spawn_box", "0");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "spawn_zombie", "0");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "survey_done", "0");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "to_tray", "0");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "reg_key", "0");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "reg_user", "0");

                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "last_profile", profile_name);

                licz.Text = Convert.ToString(Convert.ToInt32(licz.Text) + 1);
                tabControl1.SelectedIndex = 1;
            }
            else if (zajety)
            {
                MessageBox.Show("Profile with this name already exist.");
            }else
            {
                MessageBox.Show(lang("no_prof_name"), lang("error"));
            }
        }

        private void auto_Click(object sender, EventArgs e)
        {
            try
            {
                string sciezka = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null);
                sciezka = sciezka.Replace("/", "\\");

                sciezka = sciezka + "\\steamapps\\common\\7 Days To Die";


                if (File.Exists(@sciezka + "\\" + exe_name.Text))
                {
                    MessageBox.Show(lang("steam_ok"), lang("saved"));
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "game_path", sciezka);
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "server_type", "client");
                    licz.Text = Convert.ToString(Convert.ToInt32(licz.Text) + 1);
                    tabControl1.SelectedIndex = 2;
                }
                else
                {
                    sciezka = sciezka + " Dedicated Server";
                    if (File.Exists(@sciezka + "\\7DaysToDieServer.exe"))
                    {
                        MessageBox.Show(lang("steam_ok"), lang("saved"));
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "game_path", sciezka);
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "server_type", "server");
                        licz.Text = Convert.ToString(Convert.ToInt32(licz.Text) + 1);
                        tabControl1.SelectedIndex = 2;
                    }
                    else
                    {

                        MessageBox.Show(lang("steam_no_game"), lang("error"));
                    }
                }


            }
            catch
            {
                MessageBox.Show(lang("steam_no_steam"), lang("error"));
            }
        }

        private void manual_Click(object sender, EventArgs e)
        {
            if (select_dir.ShowDialog() == DialogResult.OK)
            {
                string sciezka_plikow = select_dir.SelectedPath + "\\" + exe_name.Text;
                string sciezka_plikow_server = select_dir.SelectedPath + "\\7DaysToDieServer.exe";

                if (File.Exists(@sciezka_plikow))
                {
                    MessageBox.Show(lang("dir_ok"), lang("saved"));
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "game_path", select_dir.SelectedPath);
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "server_type", "client");

                    licz.Text = Convert.ToString(Convert.ToInt32(licz.Text) + 1);
                    tabControl1.SelectedIndex = 2;

                }else if (File.Exists(@sciezka_plikow_server))
                {
                    MessageBox.Show(lang("dir_ok"), lang("saved"));
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "game_path", select_dir.SelectedPath);
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "server_type", "server");

                    licz.Text = Convert.ToString(Convert.ToInt32(licz.Text) + 1);
                    tabControl1.SelectedIndex = 2;

                }
                else
                {
                    MessageBox.Show(lang("game_not_found_2"), lang("error"));
                }



            }
        }


        private void fr_fin_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "exe_name", exe_name.Text);
            
            /*System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();*/
            
            //!!reload list
            DataContainer.reload_now = true;
            this.Close();
        }


        private void first_run_Load(object sender, EventArgs e)
        {
            load_lang();
        }

        private void select_dir_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
