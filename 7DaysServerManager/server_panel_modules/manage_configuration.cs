using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Xml;


namespace _7DaysServerManager
{

    public partial class Server_Panel_Form : Form
    {
        
        // Update The Server Config File
        public void Update_Config()
        {
            
            // The Label Is Changed After The App Is Loaded, So That It Doesn't Get Accessed When Loading The Configuration From A File.
            if (Public_IP_Address_Label.Text != "Checking IP...")
            {
                Echo_debug("---Updating & Saving Server Config---");

                // Resolve All Calculated Fields
                // TODO: FIX CHECK BOX LIST CALCS
                //if (UNET.Checked)
                //    sdnp += "unet,";
                //if (RakNet.Checked)
                //    sdnp += "raknet,";
                //if (SteamNetworking.Checked)
                //    sdnp += "steamnetworking";
                //if(sdnp.EndsWith(","))
                //    sdnp = sdnp.Substring(0, sdnp.Length - 1);

                // Resolve Player Killing Mode
                // TODO: WRITE CODE TO RESOLVE PLAYER KILLING MODE
                //if (ConfigProperty_PlayerKillingMode.Text == "No Killing")
                //    PlayerKillingMode = "0";
                //else if (ConfigProperty_PlayerKillingMode.Text == "Kill Allies Only")
                //    PlayerKillingMode = "1";
                //else if (ConfigProperty_PlayerKillingMode.Text == "Kill Strangers Only")
                //    PlayerKillingMode = "2";
                //else if (ConfigProperty_PlayerKillingMode.Text == "Kill Everyone")
                //    PlayerKillingMode = "3";

                // Set Player Drop On Death Mode
                // TODO: WRITE CODE TO RESOLVE PLAYER DROP ON DEATH
                //if (ConfigProperty_DropOnDeath.Text == "Nothing")
                //    dropondeathmode = "0";
                //else if (ConfigProperty_DropOnDeath.Text == "Everything")
                //    dropondeathmode = "1";
                //else if (ConfigProperty_DropOnDeath.Text == "Toolbelt Only")
                //    dropondeathmode = "2";
                //else if (ConfigProperty_DropOnDeath.Text == "Backpack Only")
                //    dropondeathmode = "3";
                //else if (ConfigProperty_DropOnDeath.Text == "Delete All")
                //    dropondeathmode = "4";

                // Set Player Drop On Quit Mode
                // TODO: WRITE CODE TO RESOLVE PLAYER DROP ON QUIT
                //if (ConfigProperty_DropOnQuit.Text == "Nothing")
                //    droponquitmode = "0";
                //else if (ConfigProperty_DropOnQuit.Text == "Everything")
                //    droponquitmode = "1";
                //else if (ConfigProperty_DropOnQuit.Text == "Toolbelt Only")
                //    droponquitmode = "2";
                //else if (ConfigProperty_DropOnQuit.Text == "Backpack Only")
                //    droponquitmode = "3";

                // Set Terminal Window Mode
                //TODO: WRITE CODE TO RESOLVE TERMINAL WINDOW MODE
                //if (ConfigProperty_HideCommandExecutionLog.Text == "Show Everything")
                //    hce = "0";
                //else if (ConfigProperty_HideCommandExecutionLog.Text == "Hide Only From Telnet / Control Panel")
                //    hce = "1";
                //else if (ConfigProperty_HideCommandExecutionLog.Text == "Hide From Telnet / Control Panel / Remote Game Clients")
                //    hce = "2";
                //else if (ConfigProperty_HideCommandExecutionLog.Text == "Hide Everything")
                //    hce = "3";

                // Set Config Property: LandClaimDecayMode
                //TODO: WRITE CODE TO RESOLVE LAND CLAIM DECAY MODE
                //if (ConfigProperty_LandClaimDecayMode.Text == "Linear")
                //    lcdm = "0";
                //else if (ConfigProperty_LandClaimDecayMode.Text == "Exponential")
                //    lcdm = "1";
                //else if (ConfigProperty_LandClaimDecayMode.Text == "Full Protection")
                //    lcdm = "2";

                // Resolve Config Property: BlockDamagePlayer
                //TODO: WRITE CODE TO RESOLVE BLOCK DAMAGE PLAYER
                //int bdm_t = 0;
                //if (ConfigProperty_BlockDamagePlayer.Value == 0)
                //    bdm_t = 25;
                //else
                //    bdm_t = ConfigProperty_BlockDamagePlayer.Value*50;

                // Resolve Config Property: EnemyDifficulty
                //TODO: WRITE CODE TO RESOLVE ENEMY DIFFICULTY
                //if (ConfigProperty_EnemyDifficulty.Checked)
                //    feral_c = "1";

                // Resolve Config Property: SaveGamefolder
                // TODO: WRITE CODE TO RESOLVE SAVE GAME FOLDER
                //string savegamefolderproperty = "";
                //if (ConfigProperty_SaveGameFolder.Text != "")
                //{
                //    savegamefolderproperty = "  <property name=\"SaveGameFolder\"				value=\"" + ConfigProperty_SaveGameFolder.Text + "\"/>\r\n";
                //}


                // Resolve Config Property: UserDataFolder
                // TODO: WRITE CODE TO RESOLVE USER DATA FOLDER
                //string userdatafolderproperty = "";
                //if (userdata.Text != "")
                //{
                //    userdatafolderproperty = "  <property name=\"SaveGameFolder\"				value=\"" + userdata.Text + "\"/>\r\n";
                //}


                // Alpha 18.1 Configuration File Sample - Leave Spacing Exactly As Is For Perfect Replication Of Config File
                string config = "<?xml version=\"1.0\"?>" +
                        "\n<ServerSettings>\r\n  " +
                        "\t<!-- GENERAL SERVER SETTINGS -->" +
                        "\r\n\r\n\t<!-- Server representation -->" +
                        "\r\n\t<property name=\"ServerName\"                                value=\"" + ConfigProperty_ServerName.Text + "\"/>" +
                        "\r\n\t<property name=\"ServerDescription\"                         value=\"" + ConfigProperty_ServerDescription.Text + "\"/>" +
                        "\r\n\t<property name=\"ServerWebsiteURL\"                          value=\"" + ConfigProperty_ServerWebsiteURL.Text + "\"/>" +
                        "\r\n\t<property name=\"ServerPassword\"                            value=\"" + ConfigProperty_ServerPassword.Text + "\"/>" +
                        "\r\n\t<property name=\"ServerLoginConfirmationText\"               value=\"" + ConfigProperty_ServerLoginConfirmationText.Text + "\"/>" +
                        "\r\n\r\n\t<!-- Networking -->" +
                        "\r\n\t<property name=\"ServerPort\"                                value=\"" + ConfigProperty_ServerPort.Value + "\"/>" +
                        "\r\n\t<property name=\"ServerVisibility\"                          value=\"" + ConfigProperty_ServerVisibility.Text + "\"/>" +
                        "\r\n\t<property name=\"ServerDisabledNetworkProtocols\"            value=\"" + ConfigProperty_ServerDisabledNetworkProtocols.Text + "\"/>" +
                        "\r\n\t<property name=\"ServerMaxWorldTransferSpeedKiBs\"           value=\"" + ConfigProperty_ServerMaxWorldTransferSpeedKiBs.Value + "\"/>" +
                        "\r\n\r\n\t<!-- Slots -->" +
                        "\r\n\t<property name=\"ServerMaxPlayerCount\"                      value=\"" + ConfigProperty_ServerMaxPlayerCount.Value + "\"/>" +
                        "\r\n\t<property name=\"ServerReservedSlots\"                       value=\"" + ConfigProperty_ServerReservedSlots.Text + "\"/>" +
                        "\r\n\t<property name=\"ServerReservedSlotsPermission\"             value=\"" + ConfigProperty_ServerReservedSlotsPermission.Text + "\"/>" +
                        "\r\n\t<property name=\"ServerAdminSlots\"                          value=\"" + ConfigProperty_ServerAdminSlots.Text + "\"/>" +
                        "\r\n\t<property name=\"ServerAdminSlotsPermission\"                value=\"" + ConfigProperty_ServerAdminSlotsPermission.Text + "\"/>" +
                        "\r\n\r\n\t<!-- Admin Interfaces -->" +
                        "\r\n\t<property name=\"ControlPanelEnabled\"                       value=\"" + ConfigProperty_ControlPanelEnabled.Checked.ToString().ToLower() + "\"/>" +
                        "\r\n\t<property name=\"ControlPanelPort\"                          value=\"" + ConfigProperty_ControlPanelPort.Text + "\"/>" +
                        "\r\n\t<property name=\"ControlPanelPassword\"                      value=\"" + ConfigProperty_ControlPanelPassword.Text + "\"/>" +
                        "\r\n\t<property name=\"TelnetEnabled\"                             value=\"" + ConfigProperty_TelnetEnabled.Checked.ToString().ToLower() + "\"/>" +
                        "\r\n\t<property name=\"TelnetPort\"                                value=\"" + ConfigProperty_TelnetPort.Text + "\"/>" +
                        "\r\n\t<property name=\"TelnetPassword\"                            value=\"" + ConfigProperty_TelnetPassword.Text + "\"/>" +
                        "\r\n\t<property name=\"TelnetFailedLoginLimit\"                    value=\"" + ConfigProperty_TelnetFailedLoginLimit.Text + "\"/>" +
                        "\r\n\t<property name=\"TelnetFailedLoginsBlocktime\"               value=\"" + ConfigProperty_TelnetFailedLoginsBlocktime.Text + "\"/>" +
                        "\r\n\t<property name=\"TerminalWindowEnabled\"                     value=\"" + ConfigProperty_TerminalWindowEnabled.Checked.ToString().ToLower() + "\"/>" +
                        "\r\n\r\n\t<!-- Folder and file locations -->" +
                        "\r\n\t<property name=\"AdminFileName\"                             value=\"" + ConfigProperty_AdminFileName.Text + "\"/>" +
                        "\r\n\t<property name=\"UserDataFolder\"                            value=\"" + ConfigProperty_UserDataFolder.Text + "\"/>" +
                        "\r\n\t<property name=\"SaveGameFolder\"                            value=\"" + ConfigProperty_SaveGameFolder.Text + "\"/>" +
                        "\r\n\r\n\t<!-- Other technical settings -->" +
                        "\r\n\t<property name=\"EACEnabled\"                                value=\"" + ConfigProperty_EACEnabled.Checked.ToString().ToLower() + "\"/>" +
                        "\r\n\t<property name=\"HideCommandExecutionLog\"                   value=\"" + ConfigProperty_HideCommandExecutionLog.Text + "\"/>" +
                        "\r\n\t<property name=\"MaxUncoveredMapChunksPerPlayer\"            value=\"" + ConfigProperty_MaxUncoveredMapChunksPerPlayer.Text + "\"/>" +
                        "\r\n\t<property name=\"PersistentPlayerProfiles\"                  value=\"" + ConfigProperty_PersistentPlayerProfiles.Checked.ToString().ToLower() + "\"/>" +
                        "\r\n\r\n\t<!-- GAMEPLAY -->" +
                        "\r\n\r\n\t<!-- World -->" +
                        "\r\n\t<property name=\"GameWorld\"                                 value=\"" + ConfigProperty_GameWorld.Text + "\"/>" +
                        "\r\n\t<property name=\"WorldGenSeed\"                              value=\"" + ConfigProperty_WorldGenSeed.Text + "\"/>" +
                        "\r\n\t<property name=\"WorldGenSize\"                              value=\"" + ConfigProperty_WorldGenSize.Text + "\"/>" +
                        "\r\n\t<property name=\"GameName\"                                  value=\"" + ConfigProperty_GameName.Text + "\"/>" +
                        "\r\n\t<property name=\"GameMode\"                                  value=\"" + ConfigProperty_GameMode.Text + "\"/>" +
                        "\r\n\r\n\t<!-- Difficulty -->" +
                        "\r\n\t<property name=\"GameDifficulty\"                            value=\"" + ConfigProperty_GameDifficulty.Text + "\"/>" +
                        "\r\n\t<property name=\"BlockDamagePlayer\"                         value=\"" + ConfigProperty_BlockDamagePlayer.Text + "\"/>" +
                        "\r\n\t<property name=\"BlockDamageAI\"                             value=\"" + ConfigProperty_BlockDamageAI.Text + "\"/>" +
                        "\r\n\t<property name=\"BlockDamageAIBM\"                           value=\"" + ConfigProperty_BlockDamageAIBM.Text + "\"/>" +
                        "\r\n\t<property name=\"XPMultiplier\"                              value=\"" + ConfigProperty_XPMultiplier.Text + "\"/>" +
                        "\r\n\t<property name=\"PlayerSafeZoneLevel\"                       value=\"" + ConfigProperty_PlayerSafeZoneLevel.Text + "\"/>" +
                        "\r\n\t<property name=\"PlayerSafeZoneHours\"                       value=\"" + ConfigProperty_PlayerSafeZoneHours.Text + "\"/>" +
                        "\r\n\r\n\t<!--  -->" +
                        "\r\n\t<property name=\"BuildCreate\"                               value=\"" + ConfigProperty_BuildCreate.Checked.ToString().ToLower() + "\"/>" +
                        "\r\n\t<property name=\"DayNightLength\"                            value=\"" + ConfigProperty_DayNightLength.Text + "\"/>" +
                        "\r\n\t<property name=\"DayLightLength\"                            value=\"" + ConfigProperty_DayLightLength.Text + "\"/>" +
                        "\r\n\t<property name=\"DropOnDeath\"                               value=\"" + ConfigProperty_DropOnDeath.Text + "\"/>" +
                        "\r\n\t<property name=\"DropOnQuit\"                                value=\"" + ConfigProperty_DropOnQuit.Text + "\"/>" +
                        "\r\n\t<property name=\"BedrollDeadZoneSize\"                       value=\"" + ConfigProperty_BedrollDeadZoneSize.Text + "\"/>" +
                        "\r\n\t<property name=\"BedrollExpiryTime\"                         value=\"" + ConfigProperty_BedrollExpiryTime.Text + "\"/>" +
                        "\r\n\r\n\t<!-- Performance Related -->" +
                        "\r\n\t<property name=\"MaxSpawnedZombies\"                         value=\"" + ConfigProperty_MaxSpawnedZombies.Value + "\"/>" +
                        "\r\n\t<property name=\"MaxSpawnedAnimals\"                         value=\"" + ConfigProperty_MaxSpawnedAnimals.Value + "\"/>" +
                        "\r\n\t<property name=\"ServerMaxAllowedViewDistance\"              value=\"" + ConfigProperty_ServerMaxAllowedViewDistance.Value + "\"/>" +
                        "\r\n\r\n\t<!-- Zombie Settings -->" +
                        "\r\n\t<property name=\"EnemySpawnMode\"                            value=\"" + ConfigProperty_EnemySpawnMode.Checked.ToString().ToLower() + "\"/>" +
                        "\r\n\t<property name=\"EnemyDifficulty\"                           value=\"" + ConfigProperty_EnemyDifficulty.Text + "\"/>" +
                        "\r\n\t<property name=\"ZombieMove\"                                value=\"" + ConfigProperty_ZombieMove.Text + "\"/>" +
                        "\r\n\t<property name=\"ZombieMoveNight\"                           value=\"" + ConfigProperty_ZombieMoveNight.Text + "\"/>" +
                        "\r\n\t<property name=\"ZombieFeralMove\"                           value=\"" + ConfigProperty_ZombieFeralMove.Text + "\"/>" +
                        "\r\n\t<property name=\"ZombieBMMove\"                              value=\"" + ConfigProperty_ZombieBMMove.Text + "\"/>" +
                        "\r\n\t<property name=\"BloodMoonFrequency\"                        value=\"" + ConfigProperty_BloodMoonFrequency.Text + "\"/>" +
                        "\r\n\t<property name=\"BloodMoonRange\"                            value=\"" + ConfigProperty_BloodMoonRange.Text + "\"/>" +
                        "\r\n\t<property name=\"BloodMoonWarning\"                          value=\"" + ConfigProperty_BloodMoonWarning.Text + "\"/>" +
                        "\r\n\t<property name=\"BloodMoonEnemyCount\"                       value=\"" + ConfigProperty_BloodMoonEnemyCount.Value + "\"/>" +
                        "\r\n\r\n\t<!-- Loot -->" +
                        "\r\n\t<property name=\"LootAbundance\"                             value=\"" + ConfigProperty_LootAbundance.Value + "\"/>" +
                        "\r\n\t<property name=\"LootRespawnDays\"                           value=\"" + ConfigProperty_LootRespawnDays.Value + "\"/>" +
                        "\r\n\t<property name=\"AirDropFrequency\"                          value=\"" + ConfigProperty_AirDropFrequency.Value + "\"/>" +
                        "\r\n\t<property name=\"AirDropMarker\"                             value=\"" + ConfigProperty_AirDropMarker.Checked.ToString().ToLower() + "\"/>" +
                        "\r\n\r\n\t<!-- Multiplayer -->" +
                        "\r\n\t<property name=\"PartySharedKillRange\"                      value=\"" + ConfigProperty_PartySharedKillRange.Text + "\"/>" +
                        "\r\n\t<property name=\"PlayerKillingMode\"                         value=\"" + ConfigProperty_PlayerKillingMode.Text + "\"/>" +
                        "\r\n\r\n\t<!-- Land Claim Options -->" +
                        "\r\n\t<property name=\"LandClaimCount\"                            value=\"" + ConfigProperty_LandClaimCount.Value + "\"/>" +
                        "\r\n\t<property name=\"LandClaimSize\"                             value=\"" + ConfigProperty_LandClaimSize.Text + "\"/>" +
                        "\r\n\t<property name=\"LandClaimDeadZone\"                         value=\"" + ConfigProperty_LandClaimDeadZone.Text + "\"/>" +
                        "\r\n\t<property name=\"LandClaimExpiryTime\"                       value=\"" + ConfigProperty_LandClaimExpiryTime.Text + "\"/>" +
                        "\r\n\t<property name=\"LandClaimDecayMode\"                        value=\"" + ConfigProperty_LandClaimDecayMode.Text + "\"/>" +
                        "\r\n\t<property name=\"LandClaimOnlineDurabilityModifier\"         value=\"" + ConfigProperty_LandClaimOnlineDurabilityModifier.Text + "\"/>" +
                        "\r\n\t<property name=\"LandClaimOfflineDurabilityModifier\"        value=\"" + ConfigProperty_LandClaimOfflineDurabilityModifier.Text + "\"/>\r\n" +
                    "\r\n</ServerSettings>";

                // Write The Server Config To File
                try
                {
                    // Get Config File Path
                    StreamWriter str = new StreamWriter((string)Registry.GetValue(base_registry_key + profile_name, "game_path", null) + "\\serverconfig.xml");

                    // Write To File
                    str.WriteLine(config);

                    // Close Stream
                    str.Close();
                }
                catch
                {
                    Echo_debug("---ERR: File Access Error---");
                    Thread.Sleep(100);
                }
            }
        }

        // Import The Server Config Settings Into 7DSM
        public void Import_Config()
        {
            Echo_debug("---Importing Game Config---");

            try
            {
                XmlReader xmlReader = XmlReader.Create((string)Registry.GetValue(base_registry_key + profile_name, "game_path", null) + "\\serverconfig.xml");
                while (xmlReader.Read())
                {
                    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "property"))
                    {
                        if (xmlReader.HasAttributes)
                        {
                            string name = xmlReader.GetAttribute("name");
                            string value = xmlReader.GetAttribute("value");
                            //echo_debug(name + ": " + value);  - This Helps Me See The Entries To Know If The Values Are Being Read Right - REMOVE LATER

                            // Sync App Properties To Config Values
                            if (name == "ServerName")
                                ConfigProperty_ServerName.Text = value;
                            else if (name == "ServerDescription")
                                ConfigProperty_ServerDescription.Text = value;
                            else if (name == "ServerWebsiteURL")
                                ConfigProperty_ServerWebsiteURL.Text = value;
                            else if (name == "ServerPassword")
                                ConfigProperty_ServerPassword.Text = value;
                            else if (name == "ServerLoginConfirmationText")
                                ConfigProperty_ServerLoginConfirmationText.Text = value;
                            else if (name == "ServerPort")
                                ConfigProperty_ServerPort.Text = value;
                            else if (name == "ServerVisibility")
                                ConfigProperty_ServerVisibility.Text = value;
                            else if (name == "ServerDisabledNetworkProtocols")
                                ConfigProperty_ServerDisabledNetworkProtocols.Text = value;
                            else if (name == "ServerMaxWorldTransferSpeedKiBs")
                                ConfigProperty_ServerMaxWorldTransferSpeedKiBs.Text = value;
                            else if (name == "ServerMaxPlayerCount")
                                ConfigProperty_ServerMaxPlayerCount.Value = Convert.ToInt32(value);
                            else if (name == "ServerReservedSlots")
                                ConfigProperty_ServerReservedSlots.Text = value;
                            else if (name == "ServerReservedSlotsPermission")
                                ConfigProperty_ServerReservedSlotsPermission.Text = value;
                            else if (name == "ServerAdminSlots")
                                ConfigProperty_ServerAdminSlots.Text = value;
                            else if (name == "ServerAdminSlotsPermission")
                                ConfigProperty_ServerAdminSlotsPermission.Text = value;
                            else if (name == "ControlPanelEnabled" && value == "true")
                                ConfigProperty_ControlPanelEnabled.Checked = true;
                            else if (name == "ControlPanelPort")
                                ConfigProperty_ControlPanelPort.Text = value;
                            else if (name == "ControlPanelPassword")
                                ConfigProperty_ControlPanelPassword.Text = value;
                            else if (name == "TelnetEnabled")
                                ConfigProperty_TelnetEnabled.Text = value;
                            else if (name == "TelnetPort")
                                ConfigProperty_TelnetPort.Text = value;
                            else if (name == "TelnetPassword")
                                ConfigProperty_TelnetPassword.Text = value;
                            else if (name == "TelnetFailedLoginLimit")
                                ConfigProperty_TelnetFailedLoginLimit.Text = value;
                            else if (name == "TelnetFailedLoginsBlocktime")
                                ConfigProperty_TelnetFailedLoginsBlocktime.Text = value;
                            else if (name == "TerminalWindowEnabled")
                                ConfigProperty_TerminalWindowEnabled.Text = value;
                            else if (name == "AdminFileName")
                                ConfigProperty_AdminFileName.Text = value;
                            else if (name == "UserDataFolder")
                                ConfigProperty_UserDataFolder.Text = value;
                            else if (name == "SaveGameFolder")
                                ConfigProperty_SaveGameFolder.Text = value;
                            else if (name == "EACEnabled" && value == "false")
                                ConfigProperty_EACEnabled.Checked = false; // Only Changes If Not Default
                            else if (name == "HideCommandExecutionLog")
                                ConfigProperty_HideCommandExecutionLog.Text = value;
                            else if (name == "MaxUncoveredMapChunksPerPlayer")
                                ConfigProperty_MaxUncoveredMapChunksPerPlayer.Text = value;
                            else if (name == "PersistentPlayerProfiles" && value == "true")
                                ConfigProperty_PersistentPlayerProfiles.Checked = true; // Only Changes If Not Default
                            else if (name == "GameWorld")
                                ConfigProperty_GameWorld.Text = value;
                            else if (name == "WorldGenSeed")
                                ConfigProperty_WorldGenSeed.Text = value;
                            else if (name == "WorldGenSize")
                                ConfigProperty_WorldGenSize.Text = value;
                            else if (name == "GameName")
                                ConfigProperty_GameName.Text = value;
                            else if (name == "GameMode")
                                ConfigProperty_GameMode.Text = value;
                            else if (name == "GameDifficulty")
                                ConfigProperty_GameDifficulty.Value = Convert.ToInt32(value);
                            else if (name == "BlockDamagePlayer")
                            {
                                ConfigProperty_BlockDamagePlayer.Value = Convert.ToInt32(value);

                                // TODO: EXPLAIN WHAT'S HAPPENING HERE
                                if (ConfigProperty_BlockDamagePlayer.Value == 0)
                                    BlockDamagePlayer_GroupBox.Text = LocalizedLanguage("bdm_g") + " [25%]";
                                else
                                    BlockDamagePlayer_GroupBox.Text = LocalizedLanguage("bdm_g") + " [" + ConfigProperty_BlockDamagePlayer.Value * 50 + "%]";
                            }
                            else if (name == "BlockDamageAI")
                                ConfigProperty_BlockDamageAI.Text = value;
                            else if (name == "BlockDamageAIBM")
                                ConfigProperty_BlockDamageAIBM.Text = value;
                            else if (name == "XPMultiplier")
                                ConfigProperty_XPMultiplier.Text = value;
                            else if (name == "PlayerSafeZoneLevel")
                                ConfigProperty_PlayerSafeZoneLevel.Text = value;
                            else if (name == "PlayerSafeZoneHours")
                                ConfigProperty_PlayerSafeZoneHours.Text = value;
                            else if (name == "BuildCreate" && value == "true")
                                ConfigProperty_BuildCreate.Checked = true;
                            else if (name == "DayNightLength")
                                ConfigProperty_DayNightLength.Value = Convert.ToInt32(value);
                            else if (name == "DayLightLength")
                            {
                                ConfigProperty_DayLightLength.Value = Convert.ToInt32(value);
                                DayLightLength_GroupBox.Text = LocalizedLanguage("nightpercentage_g") + " [" + ConfigProperty_DayLightLength.Value + "h]";  // Updates The GroupBox Text When The Value Is Written
                            }
                            else if (name == "DropOnDeath")
                                ConfigProperty_DropOnDeath.Text = value;
                            else if (name == "DropOnQuit")
                                ConfigProperty_DropOnQuit.Text = value;
                            else if (name == "BedrollDeadZoneSize")
                            {
                                ConfigProperty_BedrollDeadZoneSize.Value = Convert.ToInt32(value);
                                BedrollDeadZoneSize_GroupBox.Text = "Minimum enemy spawn distance from bedroll [" + Convert.ToInt32(ConfigProperty_BloodMoonEnemyCount.Value) * 5 + " sec.]"; // Updates The GroupBox Text When The Value Is Written
                            }
                            else if (name == "BedrollExpiryTime")
                                ConfigProperty_BedrollExpiryTime.Text = value;
                            else if (name == "MaxSpawnedZombies")
                                ConfigProperty_MaxSpawnedZombies.Value = Convert.ToInt32(value);
                            else if (name == "MaxSpawnedAnimals")
                                ConfigProperty_MaxSpawnedAnimals.Value = Convert.ToInt32(value);
                            else if (name == "ServerMaxAllowedViewDistance")
                                ConfigProperty_ServerMaxAllowedViewDistance.Text = value;
                            else if (name == "EnemySpawnMode" && value == "false")
                                ConfigProperty_EnemySpawnMode.Checked = false;
                            else if (name == "EnemyDifficulty")
                                ConfigProperty_EnemyDifficulty.Text = value;
                            else if (name == "ZombieMove")
                                ConfigProperty_ZombieMove.Text = value;
                            else if (name == "ZombieMoveNight")
                                ConfigProperty_ZombieMoveNight.Text = value;
                            else if (name == "ZombieFeralMove")
                                ConfigProperty_ZombieFeralMove.Text = value;
                            else if (name == "ZombieBMMove")
                                ConfigProperty_ZombieBMMove.Text = value;
                            else if (name == "BloodMoonFrequency")
                                ConfigProperty_BloodMoonFrequency.Value = Convert.ToInt32(value);
                            else if (name == "BloodMoonRange")
                                ConfigProperty_BloodMoonRange.Value = Convert.ToInt32(value);
                            else if (name == "BloodMoonWarning")
                                ConfigProperty_BloodMoonWarning.Value = Convert.ToInt32(value);
                            else if (name == "BloodMoonEnemyCount")
                            {
                                ConfigProperty_BloodMoonEnemyCount.Value = Convert.ToInt32(value);
                                BloodMoonEnemyCount_GroupBox.Text = "Zombies spawned for every player during Blood Moon [" + Convert.ToInt32(ConfigProperty_BloodMoonEnemyCount.Value) * 5 + " sec.]";
                            }
                            else if (name == "LootAbundance")
                            {
                                ConfigProperty_LootAbundance.Value = Convert.ToInt32(value);
                                LootAbundance_GroupBox.Text = LocalizedLanguage("LootAbundance_g") + " [" + ConfigProperty_LootAbundance.Value + "%]";
                            }
                            else if (name == "LootRespawnDays")
                            {
                                ConfigProperty_LootRespawnDays.Value = Convert.ToInt32(value);

                                // Determine If The Value Is Disabled Or Defined
                                if (ConfigProperty_LootRespawnDays.Value == -1)
                                    LootRespawnDays_GroupBox.Text = LocalizedLanguage("LootRespawnDays_g") + " [" + LocalizedLanguage("disabled") + "]";
                                else
                                    LootRespawnDays_GroupBox.Text = LocalizedLanguage("LootRespawnDays_g") + " [" + ConfigProperty_LootRespawnDays.Value + "]";
                            }
                            else if (name == "AirDropFrequency")
                                ConfigProperty_AirDropFrequency.Value = Convert.ToInt32(value);
                            else if (name == "AirDropMarker" && value == "true")
                                ConfigProperty_AirDropMarker.Checked = true;
                            else if (name == "PartySharedKillRange")
                                ConfigProperty_PartySharedKillRange.Value = Convert.ToInt32(value);
                            else if (name == "PlayerKillingMode")
                                ConfigProperty_PlayerKillingMode.SelectedValue = value;
                            else if (name == "LandClaimCount")
                                ConfigProperty_LandClaimCount.Value = Convert.ToInt32(value);
                            else if (name == "LandClaimSize")
                                ConfigProperty_LandClaimSize.Text = value;
                            else if (name == "LandClaimDeadZone")
                                ConfigProperty_LandClaimDeadZone.Text = value;
                            else if (name == "LandClaimExpiryTime")
                                ConfigProperty_LandClaimExpiryTime.Text = value;
                            else if (name == "LandClaimDecayMode")
                                ConfigProperty_LandClaimDecayMode.Text = value;
                            else if (name == "LandClaimOnlineDurabilityModifier")
                                ConfigProperty_LandClaimOnlineDurabilityModifier.Text = value;

                            else if (name == "LandClaimOfflineDurabilityModifier")
                                ConfigProperty_LandClaimOfflineDurabilityModifier.Text = value;

                        }

                    }
                }

                // Close The Reader
                xmlReader.Close();
            }
            catch (Exception e)
            {
                Echo_debug("ERR READING CFG FILE: " + e);
            }

            Echo_debug("---Finished Importing Config---");
        }
    }
}