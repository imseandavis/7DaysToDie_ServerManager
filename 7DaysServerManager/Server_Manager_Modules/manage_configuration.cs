using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Xml;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace _7DaysServerManager
{

    public partial class Server_Panel_Form : Form
    {
        
        // Update The Server Config File
        public void Update_Config()
        {

            /// <summary>
            /// !!! CRITICAL
            /// This Label Is Changed After The App Is Loaded, So That While The Server Config Is Being Loaded Into The UI For The First Time So We Don't Fire TextChanged Events For Each Field And Deadlock The Config.
            /// If You Make A Change To The Default Text, Make Sure To Update Below!! 
            /// <summary>
            if (Public_IP_Address_Label.Text != "Getting Public IP...")
            {
                Echo_debug("---Updating & Saving Server Config---");

                // Build ServerDisabledNetworkProtocols String Based On Selected Values
                string ServerDisabledNetworkProtocolsList = string.Empty;
                for (int SDNP_Item_Count = 0; SDNP_Item_Count < ConfigProperty_ServerDisabledNetworkProtocols.Items.Count; SDNP_Item_Count++)
                {
                    if (ConfigProperty_ServerDisabledNetworkProtocols.GetItemChecked(SDNP_Item_Count))
                    {
                        ServerDisabledNetworkProtocolsList += ConfigProperty_ServerDisabledNetworkProtocols.Items[SDNP_Item_Count] + ", ";
                    }
                }
                if(ServerDisabledNetworkProtocolsList.EndsWith(", "))
                ServerDisabledNetworkProtocolsList = ServerDisabledNetworkProtocolsList.Substring(0, ServerDisabledNetworkProtocolsList.Length - 2);



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


                    // Alpha 18.x Configuration File - Leave Spacing Exactly As Is For Perfect Replication Of Config File
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
                        "\r\n\t<property name=\"ServerVisibility\"                          value=\"" + ConfigProperty_ServerVisibility.SelectedIndex + "\"/>" +
                        "\r\n\t<property name=\"ServerDisabledNetworkProtocols\"            value=\"" + ServerDisabledNetworkProtocolsList + "\"/>" +
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
                        "\r\n\t<property name=\"TerminalWindowEnabled\"                     value=\"" + ConfigProperty_TerminalWindowEnabled.Text.ToLower() + "\"/>" +
                        "\r\n\r\n\t<!-- Folder and file locations -->" +
                        "\r\n\t<property name=\"AdminFileName\"                             value=\"" + ConfigProperty_AdminFileName.Text + "\"/>" +
                        "\r\n\t<property name=\"UserDataFolder\"                            value=\"" + ConfigProperty_UserDataFolder.Text + "\"/>" +
                        "\r\n\t<property name=\"SaveGameFolder\"                            value=\"" + ConfigProperty_SaveGameFolder.Text + "\"/>" +
                        "\r\n\r\n\t<!-- Other technical settings -->" +
                        "\r\n\t<property name=\"EACEnabled\"                                value=\"" + ConfigProperty_EACEnabled.Text.ToLower() + "\"/>" +
                        "\r\n\t<property name=\"HideCommandExecutionLog\"                   value=\"" + ConfigProperty_HideCommandExecutionLog.Text + "\"/>" +
                        "\r\n\t<property name=\"MaxUncoveredMapChunksPerPlayer\"            value=\"" + ConfigProperty_MaxUncoveredMapChunksPerPlayer.Text + "\"/>" +
                        "\r\n\t<property name=\"PersistentPlayerProfiles\"                  value=\"" + ConfigProperty_PersistentPlayerProfiles.Text + "\"/>" +
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
                        "\r\n\t<property name=\"BuildCreate\"                               value=\"" + ConfigProperty_BuildCreate.Text.ToLower() + "\"/>" +
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
                        "\r\n\t<property name=\"AirDropMarker\"                             value=\"" + ConfigProperty_AirDropMarker.Text + "\"/>" +
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
                    // Write Out Error And Sleep
                    Echo_debug("---ERR: Error Writing Server Config File - File Access Error---");
                    Thread.Sleep(100);
                }
            }
        }

        // Import The Server Config Settings Into 7DSM
        public void Import_Config()
        {
            Echo_debug("--- Importing Game Configs Into Server Manager UI ---");

            try
            {
                //Retrieve The Path For The Config File From The Registry Profile Setting
                XmlReader xmlReader = XmlReader.Create((string)Registry.GetValue(base_registry_key + profile_name, "game_path", null) + "\\serverconfig.xml");
                
                //Read Each Node And If There Is A Settings Property
                while (xmlReader.Read())
                {
                    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "property"))
                    {
                        if (xmlReader.HasAttributes)
                        {
                            // Init Property Variables
                            string Config_File_Property_Name = xmlReader.GetAttribute("name");
                            string Config_File_Property_Value = xmlReader.GetAttribute("value");

                            // Write UI Value Being Updated To Debug Log 
                            Echo_debug("Setting: " + Config_File_Property_Name + ": " + Config_File_Property_Value);

                            // Update The Server Manager UI With The Config File Value
                            switch (Config_File_Property_Name)
                            {
                                case "ServerName":
                                    ConfigProperty_ServerName.Text = Config_File_Property_Value;
                                    break;
                                
                                case "ServerDescription":
                                    ConfigProperty_ServerDescription.Text = Config_File_Property_Value;
                                    break;
                                
                                case "ServerWebsiteURL":
                                    ConfigProperty_ServerWebsiteURL.Text = Config_File_Property_Value;
                                    break;

                                case "ServerPassword":
                                    ConfigProperty_ServerPassword.Text = Config_File_Property_Value;
                                    break;

                                case "ServerLoginConfirmationText":
                                    ConfigProperty_ServerLoginConfirmationText.Text = Config_File_Property_Value;
                                    break;

                                case "ServerPort":
                                    ConfigProperty_ServerPort.Text = Config_File_Property_Value;
                                    break;

                                case "ServerVisibility":
                                    // Default : 2
                                    // 2= public, 1 = Only Shown To Friends, 0 = Not Listed.
                                    if (Config_File_Property_Value == "2")
                                        ConfigProperty_ServerVisibility.SelectedIndex = 2;
                                    else if (Config_File_Property_Value == "1")
                                        ConfigProperty_ServerVisibility.SelectedIndex = 1;
                                    else if (Config_File_Property_Value == "0")
                                        ConfigProperty_ServerVisibility.SelectedIndex = 0;
                                    break;

                                case "ServerDisabledNetworkProtocols":
                                    switch (Config_File_Property_Value)
                                    {
                                        case "LiteNetLib":
                                            ConfigProperty_ServerDisabledNetworkProtocols.SetItemChecked(0, true);
                                            break;

                                        case "SteamNetworking":
                                            ConfigProperty_ServerDisabledNetworkProtocols.SetItemChecked(1, true);
                                            break;

                                        case "LiteNetLib, SteamNetworking":
                                            ConfigProperty_ServerDisabledNetworkProtocols.SetItemChecked(0, true);
                                            ConfigProperty_ServerDisabledNetworkProtocols.SetItemChecked(1, true);
                                            break;

                                        case "SteamNetworking, LiteNetLib":
                                            ConfigProperty_ServerDisabledNetworkProtocols.SetItemChecked(0, true);
                                            ConfigProperty_ServerDisabledNetworkProtocols.SetItemChecked(1, true);
                                            break;
                                    } 
                                    break;
                                
                                case "ServerMaxWorldTransferSpeedKiBs":
                                    // Default: 512
                                    ConfigProperty_ServerMaxWorldTransferSpeedKiBs.Text = Config_File_Property_Value;
                                    break;
                                
                                case "ServerMaxPlayerCount":
                                    ConfigProperty_ServerMaxPlayerCount.Text = Config_File_Property_Value;
                                    break;
                                
                                case "ServerReservedSlots":
                                    ConfigProperty_ServerReservedSlots.Text = Config_File_Property_Value;
                                    break;
                                
                                case "ServerReservedSlotsPermission":
                                    ConfigProperty_ServerReservedSlotsPermission.Text = Config_File_Property_Value;
                                    break;
                                
                                case "ServerAdminSlots":
                                    ConfigProperty_ServerAdminSlots.Text = Config_File_Property_Value;
                                    break;

                                case "ServerAdminSlotsPermission":
                                    ConfigProperty_ServerAdminSlotsPermission.Text = Config_File_Property_Value;
                                    break;

                                case "ControlPanelEnabled":
                                    if (Config_File_Property_Value == "true")
                                        ConfigProperty_ControlPanelEnabled.Checked = true;
                                    else
                                        ConfigProperty_ControlPanelEnabled.Checked = false;
                                    break;

                                case "ControlPanelPort":
                                    ConfigProperty_ControlPanelPort.Text = Config_File_Property_Value;
                                    break;

                                case "ControlPanelPassword":
                                    ConfigProperty_ControlPanelPassword.Text = Config_File_Property_Value;
                                    break;

                                case "TelnetEnabled":
                                    if (Config_File_Property_Value == "true")
                                        ConfigProperty_TelnetEnabled.Checked = true;
                                    else
                                        ConfigProperty_TelnetEnabled.Checked = false;
                                    break;

                                case "TelnetPort":
                                    ConfigProperty_TelnetPort.Text = Config_File_Property_Value;
                                    break;

                                case "TelnetPassword":
                                    ConfigProperty_TelnetPassword.Text = Config_File_Property_Value;
                                    break;

                                case "TelnetFailedLoginLimit":
                                    ConfigProperty_TelnetFailedLoginLimit.Text = Config_File_Property_Value;
                                    break;

                                case "TelnetFailedLoginsBlocktime":
                                    ConfigProperty_TelnetFailedLoginsBlocktime.Text = Config_File_Property_Value;
                                    break;

                                case "TerminalWindowEnabled":
                                    // Default: true
                                    if (Config_File_Property_Value == "true")
                                        ConfigProperty_TerminalWindowEnabled.ToggleState = ToggleButtonState.Active;
                                    else
                                        ConfigProperty_TerminalWindowEnabled.ToggleState = ToggleButtonState.Inactive;
                                    break;

                               case "AdminFileName":
                                    ConfigProperty_AdminFileName.Text = Config_File_Property_Value;
                                    break;

                                case "UserDataFolder":
                                    ConfigProperty_UserDataFolder.Text = Config_File_Property_Value;
                                    break;

                                case "SaveGameFolder":
                                    ConfigProperty_SaveGameFolder.Text = Config_File_Property_Value;
                                    break;

                                case "EACEnabled":
                                    // Default: true
                                    if (Config_File_Property_Value == "true")
                                        ConfigProperty_EACEnabled.ToggleState = ToggleButtonState.Active;
                                    else
                                        ConfigProperty_EACEnabled.ToggleState = ToggleButtonState.Inactive;
                                    break;

                                case "HideCommandExecutionLog":
                                    ConfigProperty_HideCommandExecutionLog.Text = Config_File_Property_Value;
                                    break;

                                case "MaxUncoveredMapChunksPerPlayer":
                                    ConfigProperty_MaxUncoveredMapChunksPerPlayer.Text = Config_File_Property_Value;
                                    break;

                                case "PersistentPlayerProfiles":
                                    // Default: false
                                    if (Config_File_Property_Value == "true")
                                        ConfigProperty_PersistentPlayerProfiles.ToggleState = ToggleButtonState.Active;
                                    else
                                        ConfigProperty_PersistentPlayerProfiles.ToggleState = ToggleButtonState.Inactive;
                                    break;

                                case "GameWorld":
                                    ConfigProperty_GameWorld.SelectedText = Config_File_Property_Value;
                                    break;

                                case "WorldGenSeed":
                                    ConfigProperty_WorldGenSeed.Text = Config_File_Property_Value;
                                    break;

                                case "WorldGenSize":
                                    ConfigProperty_WorldGenSize.Text = Config_File_Property_Value;
                                    break;

                                case "GameName":
                                    ConfigProperty_GameName.SelectedText = Config_File_Property_Value;
                                    break;

                                case "GameMode":
                                    ConfigProperty_GameMode.SelectedText = Config_File_Property_Value;
                                    break;

                                case "GameDifficulty":
                                    ConfigProperty_GameDifficulty.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;
                                
                                case "BlockDamagePlayer":
                                    ConfigProperty_BlockDamagePlayer.Value = Convert.ToInt32(Config_File_Property_Value);

                                    // Update Text To Currently Set Value
                                    if (ConfigProperty_BlockDamagePlayer.Value == 0)
                                        BlockDamagePlayer_GroupBox.Text = "Block Durability Modifier " + " [25%]";
                                    else
                                        BlockDamagePlayer_GroupBox.Text = "Block Durability Modifier " + " [" + Convert.ToInt32(ConfigProperty_BlockDamagePlayer.Value) * 50 + "%]";
                                    break;

                                case "BlockDamageAI":
                                    ConfigProperty_BlockDamageAI.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "BlockDamageAIBM":
                                    ConfigProperty_BlockDamageAIBM.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "XPMultiplier":
                                    ConfigProperty_XPMultiplier.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "PlayerSafeZoneLevel":
                                    ConfigProperty_PlayerSafeZoneLevel.Text = Config_File_Property_Value;
                                    break;
                                
                                case "PlayerSafeZoneHours":
                                    ConfigProperty_PlayerSafeZoneHours.Text = Config_File_Property_Value;
                                    break;

                                case "BuildCreate":
                                    // Default: false
                                    if (Config_File_Property_Value == "true")
                                        ConfigProperty_BuildCreate.ToggleState = ToggleButtonState.Active;
                                    else
                                        ConfigProperty_BuildCreate.ToggleState = ToggleButtonState.Inactive;
                                    break;

                                case "DayNightLength":
                                    ConfigProperty_DayNightLength.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;
                                
                                case "DayLightLength":
                                    ConfigProperty_DayLightLength.Value = Convert.ToInt32(Config_File_Property_Value);

                                    // Update Text To Currently Set Value
                                    DayLightLength_GroupBox.Text = "Day Light Length " + " [" + Convert.ToInt32(ConfigProperty_DayLightLength.Value) + "h]";
                                    break;
                                
                                case "DropOnDeath":
                                    ConfigProperty_DropOnDeath.Text = Config_File_Property_Value;
                                    break;

                                case "DropOnQuit":
                                    ConfigProperty_DropOnQuit.Text = Config_File_Property_Value;
                                    break;

                                case "BedrollDeadZoneSize":
                                    ConfigProperty_BedrollDeadZoneSize.Value = Convert.ToInt32(Config_File_Property_Value);

                                    // Update Text To Currently Set Value
                                    BedrollDeadZoneSize_GroupBox.Text = "Minimum Enemy Spawn Distance From Bedroll [" + Convert.ToInt32(ConfigProperty_BedrollDeadZoneSize.Value) * 5 + " sec.]";
                                    break;

                                case "BedrollExpiryTime":
                                    ConfigProperty_BedrollExpiryTime.Text = Config_File_Property_Value;
                                    break;

                                case "MaxSpawnedZombies":
                                    ConfigProperty_MaxSpawnedZombies.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "MaxSpawnedAnimals":
                                    ConfigProperty_MaxSpawnedAnimals.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "ServerMaxAllowedViewDistance":
                                    ConfigProperty_ServerMaxAllowedViewDistance.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "EnemySpawnMode":
                                    if (Config_File_Property_Value == "true")
                                        ConfigProperty_EnemySpawnMode.Checked = true;
                                    else
                                        ConfigProperty_EnemySpawnMode.Checked = false;
                                    break;

                                case "EnemyDifficulty":
                                    // Default: 0
                                    // 0 = Normal / Toggle Inactive
                                    // 1 = Feral / Toggle Active 
                                    if (Config_File_Property_Value == "1")
                                        ConfigProperty_EnemyDifficulty.ToggleState = ToggleButtonState.Active;
                                    else
                                        ConfigProperty_EnemyDifficulty.ToggleState = ToggleButtonState.Inactive;
                                    break;

                                case "ZombieMove":
                                    ConfigProperty_ZombieMove.Text = Config_File_Property_Value;
                                    break;

                                case "ZombieMoveNight":
                                    ConfigProperty_ZombieMoveNight.Text = Config_File_Property_Value;
                                    break;

                                case "ZombieFeralMove":
                                    ConfigProperty_ZombieFeralMove.Text = Config_File_Property_Value;
                                    break;

                                case "ZombieBMMove":
                                    ConfigProperty_ZombieBMMove.SelectedText = Config_File_Property_Value;
                                    break;

                                case "BloodMoonFrequency":
                                    ConfigProperty_BloodMoonFrequency.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "BloodMoonRange":
                                    ConfigProperty_BloodMoonRange.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "BloodMoonWarning":
                                    ConfigProperty_BloodMoonWarning.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "BloodMoonEnemyCount":
                                    ConfigProperty_BloodMoonEnemyCount.Value = Convert.ToInt32(Config_File_Property_Value);

                                    // Update Text To Currently Set Value
                                    BloodMoonEnemyCount_GroupBox.Text = "Zombies Spawned For Every Player During The Blood Moon [" + Convert.ToInt32(ConfigProperty_BloodMoonEnemyCount.Value) * 5 + " sec.]";
                                    break;

                                case "LootAbundance":
                                    ConfigProperty_LootAbundance.Value = Convert.ToInt32(Config_File_Property_Value);
                                    LootAbundance_GroupBox.Text = "Loot Abundance " + " [" + Convert.ToInt32(ConfigProperty_LootAbundance.Value) + "%]";
                                    break;

                                case "LootRespawnDays":
                                    ConfigProperty_LootRespawnDays.Value = Convert.ToInt32(Config_File_Property_Value);

                                    // Update Text To Currently Set Value
                                    if (ConfigProperty_LootRespawnDays.Value == -1)
                                        LootRespawnDays_GroupBox.Text = "Loot Respawn Time" + " [ Disabled ]";
                                    else
                                        LootRespawnDays_GroupBox.Text = "Loot Respawn Time" + " [" + Convert.ToInt32(ConfigProperty_LootRespawnDays.Value) + "]";
                                    break;

                                case "AirDropFrequency":
                                    ConfigProperty_AirDropFrequency.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "AirDropMarker":
                                    // Default: false
                                    if (Config_File_Property_Value == "true")
                                        ConfigProperty_AirDropMarker.ToggleState = ToggleButtonState.Active;
                                    else
                                        ConfigProperty_AirDropMarker.ToggleState = ToggleButtonState.Inactive;
                                    break;

                                case "PartySharedKillRange":
                                    ConfigProperty_PartySharedKillRange.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "PlayerKillingMode":
                                    ConfigProperty_PlayerKillingMode.SelectedText = Config_File_Property_Value;
                                    break;

                                case "LandClaimCount":
                                    ConfigProperty_LandClaimCount.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "LandClaimSize":
                                    ConfigProperty_LandClaimSize.Text = Config_File_Property_Value;
                                    break;

                                case "LandClaimDeadZone":
                                    ConfigProperty_LandClaimDeadZone.Text = Config_File_Property_Value;
                                    break;

                                case "LandClaimExpiryTime":
                                    ConfigProperty_LandClaimExpiryTime.Text = Config_File_Property_Value;
                                    break;

                                case "LandClaimDecayMode":
                                    ConfigProperty_LandClaimDecayMode.Text = Config_File_Property_Value;
                                    break;

                                case "LandClaimOnlineDurabilityModifier":
                                    ConfigProperty_LandClaimOnlineDurabilityModifier.Text = Config_File_Property_Value;
                                    break;

                                case "LandClaimOfflineDurabilityModifier":
                                    ConfigProperty_LandClaimOfflineDurabilityModifier.Text = Config_File_Property_Value;
                                    break;

                                default:
                                    Echo_debug("MISSING PROPERTY CASE: Didn't find Value For: " + Config_File_Property_Name);
                                    break;
                            }

                        }

                    }
                }

                // Close The Reader
                xmlReader.Close();
            }
            catch (Exception e)
            {
                Echo_debug("ERR: Error Reading Config File: " + e);
            }

            Echo_debug("---Finished Importing Config---");
        }
    }
}