using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7DaysServerManager
{

    public partial class Server_Panel_Form : Form
    {


        public void Load_Languages()
        {
            About_Button.Text = lang("about");
            always_on_top.Text = lang("always_on_top");
            autobots.Text = lang("autobots");
            Ban_Hammer_Button.Text = lang("ban");
            blad.Text = lang("blad");
            cheatmode.Text = lang("cheatmode");
            Change_Game_File_Path_Button.Text = lang("chpath");
            cpl_pass.Text = lang("cpl_pass");
            cpl_port.Text = lang("cpl_port");
            ctrlp.Text = lang("ctrlp");
            ctrlpanel.Text = lang("ctrlpanel");
            dostep.Text = lang("dostep");
            dzien.Text = lang("dzien") + " [1]";

            gamemode_coop.Text = lang("gamemode_coop");

            godzina.Text = lang("godzina") + " [8:00]";
            Kick_Player_Button.Text = lang("kick");
            Kick_GroupBox.Text = lang("kickgroup");
            Kill_Server_Process.Text = lang("kill_proccess");
            Console_Group.Text = lang("kons_group");
            Server_Controls_Group.Text = lang("kontrola");

            Max_Players_GroupBox.Text = lang("maxplgroup");
            nazwamapa.Text = lang("nazwamapa");
            odery.Text = lang("odery");
            port_g.Text = lang("port_g");
            save_logfiles.Text = lang("save_logfiles");
            Save_Logs_CheckBox.Text = lang("save_logfiles_2");
            ServerIsPublic.Text = lang("ServerIsPublic");

            Spawn_GroupBox.Text = lang("spawn_group");
            Spawn_Item_Button.Text = lang("spawn_now");

            Start_Server_Button.Text = lang("start");
            Auto_Detect_Game_File_Path_Button.Text = lang("steamsearch");
            Shutdown_Server_Button.Text = lang("stop");
            Game_Time_Controls_GroupBox.Text = lang("telnet_group");
            to_tray.Text = lang("to_tray");
            Game_Difficulty_GroupBox.Text = lang("trudnoscgroup");
            Game_Mode_Settings_GroupBox.Text = lang("trybgry");
            Settings_GroupBox.Text = lang("ustawienia_grupa_ustawienia");
            workerynapis.Text = lang("workerynapis");
            Zombie_Settings_GroupBox.Text = lang("zomb_pie");
            zombie_never_run.Text = lang("zombie_never_run");
            zombie_normal.Text = lang("zombie_normal");
            zombie_run.Text = lang("zombie_run");
            PersistentPlayerProfiles.Text = lang("PersistentPlayerProfiles");
            

            Set_Game_Time_Button.Text = lang("telnet_connect");
            Server_Commands_Note_Label.Text = lang("spaminfo");
            Server_Commands_Delay_GroupBox.Text = lang("spam_time");
            show_ip.Text = lang("show_ip");
            Kick_Reason_ComboBox.Text = lang("powod");
            cleanexit.Text = lang("cleanexit");
            anon_data.Text = lang("anon_data");
            anon_data_2.Text = lang("anon_data_2");
            SQL_Enabled_CheckBox.Text = lang("sql_enabled");
            SQL_Host_GroupBox.Text = lang("sql_host_g");
            SQL_Username_GroupBox.Text = lang("sql_username_g");
            SQL_Password_GroupBox.Text = lang("sql_password_g");
            SQL_DB_Name_GroupBox.Text = lang("sql_db_name_g");
            SQL_Encrption_Warning_Label.Text = lang("sql_warn");
            SQL_Update_Time_Label.Text = lang("upd_time");
            SQL_Update_Time_GroupBox.Text = lang("sql_updates_time_g");
            Timers_Group.Text = lang("timers_g");
            Auto_Command_Timer_Label.Text = lang("auto_messages_label");
            SQL_Export_Timer_Label.Text = lang("sql_export_label");

            Backup_Timer_Label.Text = lang("backup_timer_label");
            auto_backup_check.Text = lang("auto_backup_check");
            backup_chat.Text = lang("backup_chat");
            feral.Text = lang("feral");


            Land_Claim_GroupBox.Text = lang("LandClaim");
            Land_Claim_Decay_Mode_GroupBox.Text = lang("LandClaimDecayMode_g");
            Linear.Text = lang("Linear");
            Exponential.Text = lang("Exponential");
            Full_prot.Text = lang("Full_prot");
            Land_Claim_Durability_Modifier_GroupBox.Text = lang("LandClaim_g");
            Land_Claim_Durability_Online_Label.Text = lang("online");
            Land_Claim_Durability_Offline_Label.Text = lang("offline");
            Land_Claim_Dead_Zone_GroupBox.Text = lang("LandClaimDeadZone_g");
            Land_Claim_Size_GroupBox.Text = lang("LandClaimSize_g");
            Land_Claim_Expiry_Time_GroupBox.Text = lang("LandClaimExpiryTime_g");


            Drop_On_Death_Group_Box.Text = lang("dod_g");
            Drop_On_Death_Mode_0.Text = lang("dod_0");
            Drop_On_Death_Mode_1.Text = lang("dod_1");
            Drop_On_Death_Mode_2.Text = lang("dod_2");
            Drop_On_Death_Mode_3.Text = lang("dod_3");
            Drop_On_Quit_Mode_0.Text = lang("doq_0");
            Drop_On_Quit_Mode_1.Text = lang("doq_1");
            Drop_On_Quit_Mode_2.Text = lang("doq_2");
            Drop_On_Quit_Mode_3.Text = lang("doq_3");

            realtime.Text = lang("realtime");

            Connect_Running_Server_Button.Text = lang("reboot_con");

            VACEnabled.Text = lang("VACEnabled");

            Chat_GroupBox.Text = lang("chat_g");
            
            telnet_g.Text = lang("telnet_g");
            filename_g.Text = lang("filename_g");
            telnet_port_l.Text = lang("cpl_port");
            telnet_psw_l.Text = lang("cpl_pass");

            sa_edit.Text = lang("sa_edit");
            Browse_Game_File_Path_Button.Text = lang("browse");

            Ban_GroupBox.Text = lang("bantime_slider") + " [" + Convert.ToString(Ban_Slider_TrackBar.Value) + "]";

            Server_Commands_GroupBox.Text = lang("spam_g");

            Auto_Restart_Timer_Label.Text = lang("reset_timer_label");
            Auto_Restarts_GroupBox.Text = lang("reset_g") + " [" + Convert.ToString(Auto_Restart_Time_TrackBar.Value) + ":00]";
            Warn_Before_Restart_CheckBox.Text = lang("reset_chat");
            Enable_Auto_Restarts_CheckBox.Text = lang("reset_enabled");

            save_g.Text = lang("save_g");
            Server_Commands_Say_Switch_CheckBox.Text = lang("spam_is_spam");

            if (Air_Drop_Frequency_TrackBar.Value != 0)
                Air_Drop_Frequency_GroupBox.Text = lang("AirDropFrequency") + " [" + Convert.ToString(Air_Drop_Frequency_TrackBar.Value) + " h.]";
            else
                Air_Drop_Frequency_GroupBox.Text = lang("AirDropFrequency") + " [" + lang("disabled") + "]";

            MaxSpawnedZombies_g.Text = lang("MaxSpawnedZombies_g") + " [" + Convert.ToString(MaxSpawnedZombies.Value) + "]";
            MaxSpawnedAnimals_g.Text = lang("MaxSpawnedAnimals_g") + " [" + Convert.ToString(MaxSpawnedAnimals.Value) + "]";

            Starting_Backup_Message_Label.Text = lang("backup_msg_1_l");
            Backup_Completed_Message_Label.Text = lang("backup_msg_2_l");
            Reboot_Now_Message_Label.Text = lang("reboot_l");
            Time_Until_Reboot_Message_Label.Text = lang("reboot_time_l");
            Server_Chat_Messages_GroupBox.Text = lang("messages_g");
            Custom_Commands_GroupBox.Text = lang("customcommands_g");
            How_To_Commands_Button.Text = lang("how_to_commands");
            Enable_Custom_Commands_CheckBox.Text = lang("enable_cc");
            Command_Wait_Message_Label.Text = lang("cmd_not_yet_l");
            configfile_g.Text = lang("configfile_g");
            configfile_e.Text = lang("sa_edit");

            ServerWebsiteURL_g.Text = lang("ServerWebsiteURL_g");
            ServerDescription_g.Text = lang("ServerDescription_g");
        }

    }
}
