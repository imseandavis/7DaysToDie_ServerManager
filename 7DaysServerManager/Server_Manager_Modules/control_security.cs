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
            ServerName_GroupBox.Enabled = false;
            ServerDescription_GroupBox.Enabled = false;
            ServerWebsiteURL_GroupBox.Enabled = false;
            ServerPassword_GroupBox.Enabled = false;
            ServerLoginConfirmationText_GroupBox.Enabled = false;

            ServerPort_GroupBox.Enabled = false;
            ServerVisibility_GroupBox.Enabled = false;
            ServerDisabledNetworkProtocols_GroupBox.Enabled = false;
            ServerMaxWorldTransferSpeedKiBs_GroupBox.Enabled = false;

            ServerMaxPlayerCount_GroupBox.Enabled = false;
            ServerReservedSlots_GroupBox.Enabled = false;

            ControlPanel_GroupBox.Enabled = false;
            Telnet_GroupBox.Enabled = false;
            ConfigProperty_TerminalWindowEnabled.Enabled = false;

            Server_Admin_Config_File_GroupBox.Enabled = false;
            User_Data_Folder_GroupBox.Enabled = false;
            Save_Game_Folder_GroupBox.Enabled = false;

            ConfigProperty_EACEnabled.Enabled = false;
            HideCommandExecutionLog_GroupBox.Enabled = false;
            MaxUncoveredMapChunksPerPlayer_GroupBox.Enabled = false;
            ConfigProperty_PersistentPlayerProfiles.Enabled = false;

            GameWorldSettings_GroupBox.Enabled = false;

            GameDifficulty_GroupBox.Enabled = false;
            BlockDamagePlayer_GroupBox.Enabled = false;
            BlockDamageAI_GroupBox.Enabled = false;
            BlockDamageAIBM_GroupBox.Enabled = false;
            XPMultiplier_GroupBox.Enabled = false;
            PlayerSafeZoneLevel_GroupBox.Enabled = false;
            PlayerSafeZoneHours_GroupBox.Enabled = false;

            ConfigProperty_BuildCreate.Enabled = false;
            DayLightLength_GroupBox.Enabled = false;
            DayNightLength_GroupBox.Enabled = false;
            DropOnDeath_GroupBox.Enabled = false;
            DropOnQuit_GroupBox.Enabled = false;
            BedrollDeadZoneSize_GroupBox.Enabled = false;
            BedrollExpiryTime_GroupBox.Enabled = false;

            MaxSpawnedZombies_GroupBox.Enabled = false;            
            MaxSpawnedAnimals_GroupBox.Enabled = false;
            ServerMaxAllowedViewDistance_GroupBox.Enabled = false;

            ConfigProperty_EnemySpawnMode.Enabled = false;
            ConfigProperty_EnemyDifficulty.Enabled = false;
            ZombieSpeedSettings_GroupBox.Enabled = false;
            BloodMoonFrequency_GroupBox.Enabled = false;
            BloodMoonRange_GroupBox.Enabled = false;
            BloodMoonWarning_GroupBox.Enabled = false;
            BloodMoonEnemyCount_GroupBox.Enabled = false;

            LootAbundance_GroupBox.Enabled = false;
            LootRespawnDays_GroupBox.Enabled = false;
            AirDropFrequency_GroupBox.Enabled = false;
            ConfigProperty_AirDropMarker.Enabled = false;

            PartySharedKillRange_GroupBox.Enabled = false;
            Player_Killing_Mode_GroupBox.Enabled = false;

            LandClaimSettings_GroupBox.Enabled = false;


            // SQL Tab
            SQL_Enabled_CheckBox.Enabled = false;
            SQL_Host_TextBox.Enabled = false;
            SQL_Username_TextBox.Enabled = false;
            SQL_Password_TextBox.Enabled = false;
            SQL_Database_Name_TextBox.Enabled = false;
            SQL_Update_Time_TextBox.Enabled = false;

            //Backup Tab
            if (auto_backup_check.Checked)
                backup_time.Enabled = false;
            auto_backup_check.Enabled = false;

           

            LandClaimSettings_GroupBox.Enabled = false;
            ConfigProperty_LandClaimDecayMode.Enabled = false;
            LandClaimSettings_GroupBox.Enabled = false;
            Land_Claim_Durability_Online_Label.Enabled = false;
            Land_Claim_Durability_Offline_Label.Enabled = false;
            

            Auto_Restarts_GroupBox.Enabled = false;
            Whitelist_GroupBox.Enabled = false;
        }

        public void Unlock_Panel_Controls()
        {
            Echo_debug("---Unlocking Panel Controls---");

            // Server Management Tab
            Start_Server_Button.Enabled = true;
            Shutdown_Server_Button.Enabled = true;

            // Game Settings Tab
            ServerName_GroupBox.Enabled = true;
            ServerDescription_GroupBox.Enabled = true;
            ServerWebsiteURL_GroupBox.Enabled = true;
            ServerPassword_GroupBox.Enabled = true;
            ServerLoginConfirmationText_GroupBox.Enabled = true;

            ServerPort_GroupBox.Enabled = true;
            ServerVisibility_GroupBox.Enabled = true;
            ServerDisabledNetworkProtocols_GroupBox.Enabled = true;
            ServerMaxWorldTransferSpeedKiBs_GroupBox.Enabled = true;

            ServerMaxPlayerCount_GroupBox.Enabled = true;
            ServerReservedSlots_GroupBox.Enabled = true;

            ControlPanel_GroupBox.Enabled = true;
            Telnet_GroupBox.Enabled = true;
            ConfigProperty_TerminalWindowEnabled.Enabled = true;

            Server_Admin_Config_File_GroupBox.Enabled = true;
            User_Data_Folder_GroupBox.Enabled = true;
            Save_Game_Folder_GroupBox.Enabled = true;

            ConfigProperty_EACEnabled.Enabled = true;
            HideCommandExecutionLog_GroupBox.Enabled = true;
            MaxUncoveredMapChunksPerPlayer_GroupBox.Enabled = true;
            ConfigProperty_PersistentPlayerProfiles.Enabled = true;

            GameWorldSettings_GroupBox.Enabled = true;

            GameDifficulty_GroupBox.Enabled = true;
            BlockDamagePlayer_GroupBox.Enabled = true;
            BlockDamageAI_GroupBox.Enabled = true;
            BlockDamageAIBM_GroupBox.Enabled = true;
            XPMultiplier_GroupBox.Enabled = true;
            PlayerSafeZoneLevel_GroupBox.Enabled = true;
            PlayerSafeZoneHours_GroupBox.Enabled = true;

            ConfigProperty_BuildCreate.Enabled = true;
            DayLightLength_GroupBox.Enabled = true;
            DayNightLength_GroupBox.Enabled = true;
            DropOnDeath_GroupBox.Enabled = true;
            DropOnQuit_GroupBox.Enabled = true;
            BedrollDeadZoneSize_GroupBox.Enabled = true;
            BedrollExpiryTime_GroupBox.Enabled = true;

            MaxSpawnedZombies_GroupBox.Enabled = true;
            MaxSpawnedAnimals_GroupBox.Enabled = true;
            ServerMaxAllowedViewDistance_GroupBox.Enabled = true;

            ConfigProperty_EnemySpawnMode.Enabled = true;
            ConfigProperty_EnemyDifficulty.Enabled = true;
            ZombieSpeedSettings_GroupBox.Enabled = true;
            BloodMoonFrequency_GroupBox.Enabled = true;
            BloodMoonRange_GroupBox.Enabled = true;
            BloodMoonWarning_GroupBox.Enabled = true;
            BloodMoonEnemyCount_GroupBox.Enabled = true;

            LootAbundance_GroupBox.Enabled = true;
            LootRespawnDays_GroupBox.Enabled = true;
            AirDropFrequency_GroupBox.Enabled = true;
            ConfigProperty_AirDropMarker.Enabled = true;

            PartySharedKillRange_GroupBox.Enabled = true;
            Player_Killing_Mode_GroupBox.Enabled = true;

            LandClaimSettings_GroupBox.Enabled = true;

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

            Auto_Restarts_GroupBox.Enabled = true;
            Whitelist_GroupBox.Enabled = true;

        }
    }
}
