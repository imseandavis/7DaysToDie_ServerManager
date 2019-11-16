using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;



namespace _7DaysServerManager
{

    public partial class Server_Panel_Form : Form
    {
        public void run_server()
        {
            echo_debug("---server start---");
            server_online = false;



            if (telnet_connection.IsBusy)
                telnet_connection.CancelAsync();

            if (auto_messages.IsBusy)
                auto_messages.CancelAsync();

            if (autoupdate_whitelist.IsBusy)
                autoupdate_whitelist.CancelAsync();


            string parametry = "-quit -batchmode -nographics";

            string exec_name = exe_name.Text;
            if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "server_type", null) == "server")
                exec_name = "7DaysToDieServer.exe";

            

            sciezka_plikow = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "game_path", null);
            

            parametry = parametry + " -configfile=" + (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "configfile", null);


            parametry = parametry + " -dedicated";


                if (sciezka_plikow == "" | !File.Exists(@sciezka_plikow + "\\" + exec_name))
                {
                    echo(lang("error"), 3, true);
                    echo(lang("game_not_found_cons"), 3, true);
                    MessageBox.Show(lang("game_not_found"), lang("error"));



                    if (Select_Game_Directory.ShowDialog() == DialogResult.OK)
                    {
                        sciezka_plikow = Select_Game_Directory.SelectedPath + "\\" + exe_name.Text;
                        string sciezka_plikow_server = Select_Game_Directory.SelectedPath + "\\7DaysToDieServer.exe";



                        if (File.Exists(@sciezka_plikow + "\\" + exe_name.Text))
                        {
                            MessageBox.Show(lang("dir_ok"), lang("saved"));
                            echo(lang("dir_ok"), 0, true);
                            Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "game_path", sciezka_plikow);
                            Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "server_type", "client");
                        }
                        else if (File.Exists(@sciezka_plikow + "\\7daystodieserver.exe"))
                        {
                            MessageBox.Show(lang("dir_ok"), lang("saved"));
                            echo(lang("dir_ok"), 0, true);
                            Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "game_path", sciezka_plikow);
                            Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "server_type", "server");
                        }
                        else
                        {
                            MessageBox.Show(lang("game_not_found_2"), lang("error"));
                            echo(lang("game_not_found_2"), 3, true);
                        }
                    }
                }
                else
                {
                    echo_debug(@sciezka_plikow + "\\" + exec_name + parametry);
                    System.Diagnostics.Process.Start(@sciezka_plikow + "\\" + exec_name, parametry);
                    Shutdown_Server_Button.Enabled = true;
                    Start_Server_Button.Enabled = false;

                    //this.ControlBox = false;

                    lock_ctrl();

                    server_online = true;

                    //echo("OK", 1, true);
                    echo(lang("run_from") + sciezka_plikow, 0, true);

                    try
                    {
                        server_startup_tasks.RunWorkerAsync(true);
                    }
                    catch { }

                }




            echo_debug("---DONE!---");
        }

    }
}
