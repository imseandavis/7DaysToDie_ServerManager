using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7DaysServerManager
{

    public partial class Server_Panel_Form : Form
    {


        public void Lock_Panel_Controls()
        {
            Echo_debug("---Locking Panel Controls---");

            // Server Tab
            Start_Server_Button.Enabled = false;
            Shutdown_Server_Button.Enabled = true;

            // Game Settings Tab
            Player_Killing_Mode_GroupBox.Enabled = false;
            AirDropMarker.Enabled = false;
            MaxPlayers.Enabled = false;
            Game_Difficulty_TrackBar.Enabled = false;

            if (!realtime.Checked)
                dayLength.Enabled = false;

            ctrlp.Enabled = false;
            ctrlppass.Enabled = false;
            port_panel.Enabled = false;
            zombie_normal.Enabled = false;
            zombie_run.Enabled = false;
            zombie_never_run.Enabled = false;
            ServerIsPublic.Enabled = false;
            ServerPassword.Enabled = false;
            GameName_ComboBox.Enabled = false;
            Game_World_Type_ComboBox.Enabled = false;
            port.Enabled = false;
            gamemode_coop.Enabled = false;

            cheatmode.Enabled = false;
            port.Enabled = false;
            Server_Name_TextBox.Enabled = false;

            // SQL Tab
            SQL_Enabled_CheckBox.Enabled = false;
            SQL_Host_TextBox.Enabled = false;
            SQL_Username_TextBox.Enabled = false;
            SQL_Password_TextBox.Enabled = false;
            SQL_Database_Name_TextBox.Enabled = false;
            SQL_Update_Time_TextBox.Enabled = false;


            if (auto_backup_check.Checked)
                backup_time.Enabled = false;
            auto_backup_check.Enabled = false;

            Drop_On_Death_Mode_0.Enabled = false;
            Drop_On_Death_Mode_1.Enabled = false;
            Drop_On_Death_Mode_2.Enabled = false;
            Drop_On_Death_Mode_3.Enabled = false;
            Drop_On_Quit_Mode_0.Enabled = false;
            Drop_On_Quit_Mode_1.Enabled = false;
            Drop_On_Quit_Mode_2.Enabled = false;
            Drop_On_Quit_Mode_3.Enabled = false;


            EnemySpawnMode.Enabled = false;
            realtime.Enabled = false;

            nightpercentage.Enabled = false;
            bdm.Enabled = false;

            Server_Admin_File_Name_TextBox.Enabled = false;
            telnet_port_p.Enabled = false;
            telnet_psw.Enabled = false;
            LootAbundance.Enabled = false;
            LootRespawnDays.Enabled = false;

            Land_Claim_GroupBox.Enabled = false;
            Linear.Enabled = false;
            Exponential.Enabled = false;
            Full_prot.Enabled = false;
            Land_Claim_GroupBox.Enabled = false;
            Land_Claim_Durability_Online_Label.Enabled = false;
            Land_Claim_Durability_Offline_Label.Enabled = false;
            Land_Claim_Dead_Zone_TextBox.Enabled = false;
            Land_Claim_Size_TextBox.Enabled = false;
            Land_Claim_Expiry_Time_TextBox.Enabled = false;
            gamemode_surv_pvp.Enabled = false;
            feral.Enabled = false;
            Air_Drop_Frequency_TrackBar.Enabled = false;
            Enable_Easy_Anti_Cheat_CheckBox.Enabled = false;
            MaxSpawnedZombies.Enabled = false;
            save.Enabled = false;

            PersistentPlayerProfiles.Enabled = false;
            configfile.Enabled = false;
            MaxSpawnedZombies.Enabled = false;
            ServerDescription.Enabled = false;
            ServerWebsiteURL.Enabled = false;

            Auto_Restarts_GroupBox.Enabled = false;
            Whitelist_GroupBox.Enabled = false;
            Player_Safe_Zone_Level_TextBox.Enabled = false;
            Player_Safe_Zone_Hours_TextBox.Enabled = false;
            MaxSpawnedAnimals.Enabled = false;

        }

        public void Unlock_Panel_Controls()
        {
            Echo_debug("---Unlocking Panel Controls---");

            // Server Tab
            Start_Server_Button.Enabled = true;
            Shutdown_Server_Button.Enabled = false;

            // Game Settings Tab
            Player_Killing_Mode_GroupBox.Enabled = true;
            AirDropMarker.Enabled = true;
            MaxPlayers.Enabled = true;
            Game_Difficulty_TrackBar.Enabled = true;
            if (!realtime.Checked)
                dayLength.Enabled = true;
            ctrlp.Enabled = true;
            ctrlppass.Enabled = true;
            port_panel.Enabled = true;
            zombie_normal.Enabled = true;
            zombie_run.Enabled = true;
            zombie_never_run.Enabled = true;
            ServerIsPublic.Enabled = true;
            ServerPassword.Enabled = true;
            GameName_ComboBox.Enabled = true;
            Game_World_Type_ComboBox.Enabled = true;
            port.Enabled = true;
            gamemode_coop.Enabled = true;
            cheatmode.Enabled = true;
            port.Enabled = true;
            Server_Name_TextBox.Enabled = true;

            // SQL Tab
            SQL_Enabled_CheckBox.Enabled = true;
            SQL_Host_TextBox.Enabled = true;
            SQL_Username_TextBox.Enabled = true;
            SQL_Password_TextBox.Enabled = true;
            SQL_Database_Name_TextBox.Enabled = true;
            SQL_Update_Time_TextBox.Enabled = true;

            // Backup Tab
            if (auto_backup_check.Checked)
                backup_time.Enabled = true;
            auto_backup_check.Enabled = true;


            Drop_On_Death_Mode_0.Enabled = true;
            Drop_On_Death_Mode_1.Enabled = true;
            Drop_On_Death_Mode_2.Enabled = true;
            Drop_On_Death_Mode_3.Enabled = true;
            Drop_On_Quit_Mode_0.Enabled = true;
            Drop_On_Quit_Mode_1.Enabled = true;
            Drop_On_Quit_Mode_2.Enabled = true;
            Drop_On_Quit_Mode_3.Enabled = true;


            EnemySpawnMode.Enabled = true;
            realtime.Enabled = true;

            nightpercentage.Enabled = true;
            bdm.Enabled = true;

            Server_Admin_File_Name_TextBox.Enabled = true;
            telnet_port_p.Enabled = true;
            telnet_psw.Enabled = true;
            LootAbundance.Enabled = true;
            LootRespawnDays.Enabled = true;

            Land_Claim_GroupBox.Enabled = true;
            Linear.Enabled = true;
            Exponential.Enabled = true;
            Full_prot.Enabled = true;
            Land_Claim_GroupBox.Enabled = true;
            Land_Claim_Durability_Online_Label.Enabled = true;
            Land_Claim_Durability_Offline_Label.Enabled = true;
            Land_Claim_Dead_Zone_TextBox.Enabled = true;
            Land_Claim_Size_TextBox.Enabled = true;
            Land_Claim_Expiry_Time_TextBox.Enabled = true;
            gamemode_surv_pvp.Enabled = true;
            feral.Enabled = true;
            Air_Drop_Frequency_TrackBar.Enabled = true;
            Enable_Easy_Anti_Cheat_CheckBox.Enabled = true;
            MaxSpawnedZombies.Enabled = true;
            save.Enabled = true;

            PersistentPlayerProfiles.Enabled = true;
            configfile.Enabled = true;
            MaxSpawnedZombies.Enabled = true;
            ServerDescription.Enabled = true;
            ServerWebsiteURL.Enabled = true;

            Auto_Restarts_GroupBox.Enabled = true;
            Whitelist_GroupBox.Enabled = true;
            Player_Safe_Zone_Level_TextBox.Enabled = true;
            Player_Safe_Zone_Hours_TextBox.Enabled = true;
            MaxSpawnedAnimals.Enabled = true;

        }
    }
}
