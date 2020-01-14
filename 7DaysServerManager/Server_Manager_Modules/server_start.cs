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
        // Start The 7 Days To Die Server
        public void Run_Server()
        {
            Echo_debug("---Start Server---");

            // Set Server Offline Until Server Is Up
            server_online = false;

            // Init Telnet Connections
            if (telnet_connection.IsBusy)
                telnet_connection.CancelAsync();

            // Init Auto Message
            if (auto_messages.IsBusy)
                auto_messages.CancelAsync();

            // Init Auto Update
            if (autoupdate_whitelist.IsBusy)
                autoupdate_whitelist.CancelAsync();

            // Add Start Server Command Options
            string parametry = "-quit -batchmode -nographics";

            // Retrieve The 7 Days To Die Dedicated Server Path
            string exec_name = exe_name.Text;
            if ((string)Registry.GetValue(base_registry_key + profile_name, "server_type", null) == "server")
                exec_name = "7DaysToDieServer.exe";

            file_path = (string)Registry.GetValue(base_registry_key + profile_name, "game_path", null);

            parametry = parametry + " -configfile=" + (string)Registry.GetValue(base_registry_key + profile_name, "configfile", null);

            parametry += " -dedicated";

                if (file_path == "" | !File.Exists(file_path + "\\" + exec_name))
                {
                    Echo("Error", 3, true);
                    Echo("7DaysToDie.exe not found!", 3, true);
                    MessageBox.Show("Game files not found.", "Error");

                    if (Select_Game_Directory.ShowDialog() == DialogResult.OK)
                    {
                        file_path = Select_Game_Directory.SelectedPath + "\\" + exe_name.Text;
                        string server_file_path = Select_Game_Directory.SelectedPath + "\\7DaysToDieServer.exe";

                        if (File.Exists(file_path + "\\" + exe_name.Text))
                        {
                            MessageBox.Show("Dir seems to be all right. Saved", "Saved");
                            Echo("Dir seems to be all right. Saved", 0, true);
                            Registry.SetValue(base_registry_key + profile_name, "game_path", file_path);
                            Registry.SetValue(base_registry_key + profile_name, "server_type", "client");
                        }
                        else if (File.Exists(file_path + "\\7daystodieserver.exe"))
                        {
                            MessageBox.Show("Dir seems to be all right. Saved", "Saved");
                            Echo("Dir seems to be all right. Saved", 0, true);
                            Registry.SetValue(base_registry_key + profile_name, "game_path", file_path);
                            Registry.SetValue(base_registry_key + profile_name, "server_type", "server");
                        }
                        else
                        {
                            MessageBox.Show("Game files not found.", "Error");
                            Echo("Game files not found.", 3, true);
                        }
                    }
                }
                else
                {
                    Echo_debug(file_path + "\\" + exec_name + parametry);
                    System.Diagnostics.Process.Start(file_path + "\\" + exec_name, parametry);
                    Shutdown_Server_Button.Enabled = true;
                    Start_Server_Button.Enabled = false;

                    //this.ControlBox = false;

                    Lock_Panel_Controls();

                    server_online = true;

                    //echo("OK", 1, true);
                    Echo("Server running from path: " + file_path, 0, true);

                    try
                    {
                        server_startup_tasks.RunWorkerAsync(true);
                    }
                    catch { }

                }

            Echo_debug("---DONE!---");
        }

    }
}
