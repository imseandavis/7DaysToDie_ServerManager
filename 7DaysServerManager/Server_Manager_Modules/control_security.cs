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
            ConfigProperty_ServerMaxPlayerCount.Enabled = false;
            ConfigProperty_GameDifficulty.Enabled = false;
            ConfigProperty_ControlPanelEnabled.Enabled = false;
            ConfigProperty_ControlPanelPassword.Enabled = false;
            ConfigProperty_ControlPanelPort.Enabled = false;
            ConfigProperty_ZombieMove.Enabled = false;
            ConfigProperty_ZombieMoveNight.Enabled = false;
            ConfigProperty_ZombieFeralMove.Enabled = false;
            ConfigProperty_ZombieBMMove.Enabled = false;
            ConfigProperty_GameName.Enabled = false;
            ConfigProperty_GameWorld.Enabled = false;
            ConfigProperty_ServerPort.Enabled = false;

            ConfigProperty_BuildCreate.Enabled = false;
            ConfigProperty_ServerPort.Enabled = false;
            ConfigProperty_ServerName.Enabled = false;

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

            ConfigProperty_DropOnDeath.Enabled = false;
            ConfigProperty_DropOnQuit.Enabled = false;
            ConfigProperty_EnemySpawnMode.Enabled = false;
            ConfigProperty_DayLightLength.Enabled = false;
            ConfigProperty_BlockDamagePlayer.Enabled = false;

            ConfigProperty_AdminFileName.Enabled = false;
            ConfigProperty_TelnetPort.Enabled = false;
            ConfigProperty_TelnetPassword.Enabled = false;
            ConfigProperty_LootAbundance.Enabled = false;
            ConfigProperty_LootRespawnDays.Enabled = false;

            Land_Claim_GroupBox.Enabled = false;
            ConfigProperty_LandClaimDecayMode.Enabled = false;
            Land_Claim_GroupBox.Enabled = false;
            Land_Claim_Durability_Online_Label.Enabled = false;
            Land_Claim_Durability_Offline_Label.Enabled = false;
            ConfigProperty_LandClaimDeadZone.Enabled = false;
            ConfigProperty_LandClaimSize.Enabled = false;
            ConfigProperty_LandClaimExpiryTime.Enabled = false;
            ConfigProperty_EnemyDifficulty.Enabled = false;
            ConfigProperty_AirDropFrequency.Enabled = false;
            ConfigProperty_EACEnabled.Enabled = false;
            ConfigProperty_MaxSpawnedZombies.Enabled = false;
            ConfigProperty_SaveGameFolder.Enabled = false;

            ConfigProperty_PersistentPlayerProfiles.Enabled = false;
            ConfigProperty_UserDataFolder.Enabled = false;
            ConfigProperty_MaxSpawnedZombies.Enabled = false;
            ConfigProperty_ServerDescription.Enabled = false;
            ConfigProperty_ServerWebsiteURL.Enabled = false;

            Auto_Restarts_GroupBox.Enabled = false;
            Whitelist_GroupBox.Enabled = false;
            ConfigProperty_PlayerSafeZoneLevel.Enabled = false;
            ConfigProperty_PlayerSafeZoneHours.Enabled = false;
            ConfigProperty_MaxSpawnedAnimals.Enabled = false;

        }

        public void Unlock_Panel_Controls()
        {
            Echo_debug("---Unlocking Panel Controls---");

            // Server Management Tab
            Start_Server_Button.Enabled = true;
            Shutdown_Server_Button.Enabled = false;

            // Game Settings Tab
            Player_Killing_Mode_GroupBox.Enabled = true;
            AirDropMarker.Enabled = true;
            ConfigProperty_ServerMaxPlayerCount.Enabled = true;
            ConfigProperty_GameDifficulty.Enabled = true;
            ConfigProperty_ControlPanelEnabled.Enabled = true;
            ConfigProperty_ControlPanelPassword.Enabled = true;
            ConfigProperty_ControlPanelPort.Enabled = true;
            ConfigProperty_ZombieMove.Enabled = true;
            ConfigProperty_ZombieMoveNight.Enabled = true;
            ConfigProperty_ZombieFeralMove.Enabled = true;
            ConfigProperty_ZombieBMMove.Enabled = true;
            ConfigProperty_GameName.Enabled = true;
            ConfigProperty_GameWorld.Enabled = true;
            ConfigProperty_ServerPort.Enabled = true;
            ConfigProperty_BuildCreate.Enabled = true;
            ConfigProperty_ServerPort.Enabled = true;
            ConfigProperty_ServerName.Enabled = true;

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

            ConfigProperty_DropOnDeath.Enabled = true;
            ConfigProperty_DropOnQuit.Enabled = true;
            ConfigProperty_EnemySpawnMode.Enabled = true;
            ConfigProperty_DayLightLength.Enabled = true;
            ConfigProperty_BlockDamagePlayer.Enabled = true;

            ConfigProperty_AdminFileName.Enabled = true;
            ConfigProperty_TelnetPort.Enabled = true;
            ConfigProperty_TelnetPassword.Enabled = true;
            ConfigProperty_LootAbundance.Enabled = true;
            ConfigProperty_LootRespawnDays.Enabled = true;

            Land_Claim_GroupBox.Enabled = true;
            ConfigProperty_LandClaimDecayMode.Enabled = true;
            Land_Claim_GroupBox.Enabled = true;
            Land_Claim_Durability_Online_Label.Enabled = true;
            Land_Claim_Durability_Offline_Label.Enabled = true;
            ConfigProperty_LandClaimDeadZone.Enabled = true;
            ConfigProperty_LandClaimSize.Enabled = true;
            ConfigProperty_LandClaimExpiryTime.Enabled = true;
            ConfigProperty_EnemyDifficulty.Enabled = true;
            ConfigProperty_AirDropFrequency.Enabled = true;
            ConfigProperty_EACEnabled.Enabled = true;
            ConfigProperty_MaxSpawnedZombies.Enabled = true;
            ConfigProperty_SaveGameFolder.Enabled = true;

            ConfigProperty_PersistentPlayerProfiles.Enabled = true;
            ConfigProperty_UserDataFolder.Enabled = true;
            ConfigProperty_MaxSpawnedZombies.Enabled = true;
            ConfigProperty_ServerDescription.Enabled = true;
            ConfigProperty_ServerWebsiteURL.Enabled = true;

            Auto_Restarts_GroupBox.Enabled = true;
            Whitelist_GroupBox.Enabled = true;
            ConfigProperty_PlayerSafeZoneLevel.Enabled = true;
            ConfigProperty_PlayerSafeZoneHours.Enabled = true;
            ConfigProperty_MaxSpawnedAnimals.Enabled = true;

        }
    }
}
