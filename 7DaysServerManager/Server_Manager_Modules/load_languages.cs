using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7DaysServerManager
{

    public partial class Server_Panel_Form : Form
    {
        // Load Language Localizations
        public void Load_Languages()
        {
            //Server Management Tab
            About_Button.Text = LocalizedLanguage("about");
            Settings_Always_On_Top_CheckBox.Text = LocalizedLanguage("always_on_top");
            Ban_Hammer_Button.Text = LocalizedLanguage("ban");
            blad.Text = LocalizedLanguage("blad");
            //ConfigProperty_BuildCreate.Text = LocalizedLanguage("cheatmode");
            Change_Game_File_Path_Button.Text = LocalizedLanguage("chpath");
            //cpl_pass.Text = LocalizedLanguage("cpl_pass");
            //cpl_port.Text = LocalizedLanguage("cpl_port");
            //ConfigProperty_ControlPanelEnabled.Text = LocalizedLanguage("ctrlp");
            ControlPanel_GroupBox.Text = LocalizedLanguage("ctrlpanel");
            dzien.Text = LocalizedLanguage("dzien") + " [1]";

            godzina.Text = LocalizedLanguage("godzina") + " [8:00]";
            Kick_Player_Button.Text = LocalizedLanguage("kick");
            Kick_GroupBox.Text = LocalizedLanguage("kickgroup");
            Kill_Server_Process.Text = LocalizedLanguage("kill_proccess");
            Console_Group.Text = LocalizedLanguage("kons_group");
            Server_Controls_Group.Text = LocalizedLanguage("kontrola");

            ServerMaxPlayerCount_GroupBox.Text = LocalizedLanguage("maxplgroup");
            GameWorldSettings_GroupBox.Text = LocalizedLanguage("nazwamapa");
            ServerPort_GroupBox.Text = LocalizedLanguage("port_g");
            //Save_Logs_CheckBox.Text = LocalizedLanguage("save_logfiles");

            Spawn_GroupBox.Text = LocalizedLanguage("spawn_group");
            Spawn_Item_Button.Text = LocalizedLanguage("spawn_now");

            Start_Server_Button.Text = LocalizedLanguage("start");
            Auto_Detect_Game_File_Path_Button.Text = LocalizedLanguage("steamsearch");
            Shutdown_Server_Button.Text = LocalizedLanguage("stop");
            Game_Time_Controls_GroupBox.Text = LocalizedLanguage("telnet_group");
            Settings_Send_To_Tray_CheckBox.Text = LocalizedLanguage("to_tray");
            GameDifficulty_GroupBox.Text = LocalizedLanguage("trudnoscgroup");
            //Game_Mode_Settings_GroupBox.Text = LocalizedLanguage("trybgry");
            Settings_GroupBox.Text = LocalizedLanguage("ustawienia_grupa_ustawienia");
            workerynapis.Text = LocalizedLanguage("workerynapis");
            //ConfigProperty_PersistentPlayerProfiles.Text = LocalizedLanguage("PersistentPlayerProfiles");
            

            Set_Game_Time_Button.Text = LocalizedLanguage("telnet_connect");
            Server_Commands_Note_Label.Text = LocalizedLanguage("spaminfo");
            //Server_Commands_Delay_GroupBox.Text = LocalizedLanguage("spam_time");
            Settings_Show_IPS_CheckBox.Text = LocalizedLanguage("show_ip");
            Kick_Reason_ComboBox.Text = LocalizedLanguage("powod");
            Settings_Clean_Exit_CheckBox.Text = LocalizedLanguage("cleanexit");
            SQL_Enabled_CheckBox.Text = LocalizedLanguage("sql_enabled");
            SQL_Host_GroupBox.Text = LocalizedLanguage("sql_host_g");
            SQL_Username_GroupBox.Text = LocalizedLanguage("sql_username_g");
            SQL_Password_GroupBox.Text = LocalizedLanguage("sql_password_g");
            SQL_DB_Name_GroupBox.Text = LocalizedLanguage("sql_db_name_g");
            SQL_Encrption_Warning_Label.Text = LocalizedLanguage("sql_warn");
            SQL_Update_Time_Label.Text = LocalizedLanguage("upd_time");
            SQL_Update_Time_GroupBox.Text = LocalizedLanguage("sql_updates_time_g");
            Timers_Group.Text = LocalizedLanguage("timers_g");
            Auto_Command_Timer_Label.Text = LocalizedLanguage("auto_messages_label");
            SQL_Export_Timer_Label.Text = LocalizedLanguage("sql_export_label");

            Backup_Timer_Label.Text = LocalizedLanguage("backup_timer_label");
            auto_backup_check.Text = LocalizedLanguage("auto_backup_check");
            backup_chat.Text = LocalizedLanguage("backup_chat");
            ConfigProperty_EnemyDifficulty.Text = LocalizedLanguage("feral");


            LandClaimSettings_GroupBox.Text = LocalizedLanguage("LandClaim");
            LandClaimDecayMode_GroupBox.Text = LocalizedLanguage("LandClaimDecayMode_g");
            LandClaimDurabilityModifier_GroupBox.Text = LocalizedLanguage("LandClaim_g");
            Land_Claim_Durability_Online_Label.Text = LocalizedLanguage("online");
            Land_Claim_Durability_Offline_Label.Text = LocalizedLanguage("offline");
            LandClaimDeadZone_GroupBox.Text = LocalizedLanguage("LandClaimDeadZone_g");
            LandClaimSize_GroupBox.Text = LocalizedLanguage("LandClaimSize_g");
            LandClaimExpiryTime_GroupBox.Text = LocalizedLanguage("LandClaimExpiryTime_g");


            DropOnDeath_GroupBox.Text = LocalizedLanguage("dod_g");

            // TODO: DOD and DOQ Localization
            ConfigProperty_DropOnDeath.Text = LocalizedLanguage("dod_0");
            ConfigProperty_DropOnQuit.Text = LocalizedLanguage("dod_1");

            //DayNightLength_Realtime_Mode.Text = LocalizedLanguage("realtime");

            Connect_Running_Server_Button.Text = LocalizedLanguage("reboot_con");

            //ConfigProperty_EACEnabled.Text = LocalizedLanguage("VACEnabled");

            Chat_GroupBox.Text = LocalizedLanguage("chat_g");
            
            //Telnet_Settings_GroupBox.Text = LocalizedLanguage("telnet_g");
            Server_Admin_Config_File_GroupBox.Text = LocalizedLanguage("filename_g");
            //telnet_port_l.Text = LocalizedLanguage("cpl_port");
            //telnet_psw_l.Text = LocalizedLanguage("cpl_pass");

            Server_Admin_Path_Selector_Button.Text = LocalizedLanguage("sa_edit");
            Browse_Game_File_Path_Button.Text = LocalizedLanguage("browse");

            Ban_GroupBox.Text = LocalizedLanguage("bantime_slider") + " [" + Convert.ToString(Ban_Slider_TrackBar.Value) + "]";

            Server_Commands_GroupBox.Text = LocalizedLanguage("spam_g");

            Auto_Restart_Timer_Label.Text = LocalizedLanguage("reset_timer_label");
            //Auto_Restarts_GroupBox.Text = LocalizedLanguage("reset_g") + " [" + Convert.ToString(Auto_Restart_Time_TrackBar.Value) + ":00]";
            Warn_Before_Restart_CheckBox.Text = LocalizedLanguage("reset_chat");
            Enable_Auto_Restarts_CheckBox.Text = LocalizedLanguage("reset_enabled");

            Save_Game_Folder_GroupBox.Text = LocalizedLanguage("save_g");
            Server_Commands_Say_Switch_CheckBox.Text = LocalizedLanguage("spam_is_spam");

            //if (ConfigProperty_AirDropFrequency.Value != 0)
            //    AirDropFrequency_GroupBox.Text = LocalizedLanguage("AirDropFrequency") + " [" + Convert.ToString(ConfigProperty_AirDropFrequency.Value) + " h.]";
            //else
            //    AirDropFrequency_GroupBox.Text = LocalizedLanguage("AirDropFrequency") + " [" + LocalizedLanguage("disabled") + "]";

            MaxSpawnedZombies_GroupBox.Text = "[" + Convert.ToString(ConfigProperty_MaxSpawnedZombies.Value) + "] Zombies Spawned Per Player";
            MaxSpawnedAnimals_GroupBox.Text = "[" + Convert.ToString(ConfigProperty_MaxSpawnedAnimals.Value) + "] Animals Spawned Per Player";

            Starting_Backup_Message_Label.Text = LocalizedLanguage("backup_msg_1_l");
            Backup_Completed_Message_Label.Text = LocalizedLanguage("backup_msg_2_l");
            Reboot_Now_Message_Label.Text = LocalizedLanguage("reboot_l");
            Time_Until_Reboot_Message_Label.Text = LocalizedLanguage("reboot_time_l");
            Server_Chat_Messages_GroupBox.Text = LocalizedLanguage("messages_g");
            Custom_Commands_GroupBox.Text = LocalizedLanguage("customcommands_g");
            How_To_Commands_Button.Text = LocalizedLanguage("how_to_commands");
            Enable_Custom_Commands_CheckBox.Text = LocalizedLanguage("enable_cc");
            Command_Wait_Message_Label.Text = LocalizedLanguage("cmd_not_yet_l");
            User_Data_Folder_GroupBox.Text = LocalizedLanguage("configfile_g");
            configfile_e.Text = LocalizedLanguage("sa_edit");

            ServerWebsiteURL_GroupBox.Text = LocalizedLanguage("ServerWebsiteURL_g");
            ServerDescription_GroupBox.Text = LocalizedLanguage("ServerDescription_g");
        }

    }
}
