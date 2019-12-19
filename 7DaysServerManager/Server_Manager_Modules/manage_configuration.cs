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
            /// !!! CRITICAL NOTE
            /// This Label Is Changed After The App Is Loaded, So That While The Server Config Is Being Loaded Into The UI For The First Time So We Don't Fire TextChanged Events For Each Field And Deadlock The Config.
            /// If You Make A Change To The Default Text, Make Sure To Update Below!! 
            /// <summary>
            if (Public_IP_Address_Label.Text != "Getting Public IP...")
            {
                Echo_debug("---Updating & Saving Server Config---");


                //TODO: MOVE THIS SOMEWHERE MORE APPROPRIATE
                // Build ServerDisabledNetworkProtocols String Based On Selected Values
                string ServerDisabledNetworkProtocolsList = string.Empty;
                for (int SDNP_Item_Count = 0; SDNP_Item_Count < ConfigProperty_ServerDisabledNetworkProtocols.Items.Count; SDNP_Item_Count++)
                {
                    if (ConfigProperty_ServerDisabledNetworkProtocols.GetItemChecked(SDNP_Item_Count))
                    {
                        ServerDisabledNetworkProtocolsList += ConfigProperty_ServerDisabledNetworkProtocols.Items[SDNP_Item_Count] + ", ";
                    }
                }
                if (ServerDisabledNetworkProtocolsList.EndsWith(", "))
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


                #region Alpha 18.x Configuration File Template

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
                        "\r\n\t<property name=\"ControlPanelEnabled\"                       value=\"" + ConfigProperty_ControlPanelEnabled.Text.ToLower() + "\"/>" +
                        "\r\n\t<property name=\"ControlPanelPort\"                          value=\"" + ConfigProperty_ControlPanelPort.Text + "\"/>" +
                        "\r\n\t<property name=\"ControlPanelPassword\"                      value=\"" + ConfigProperty_ControlPanelPassword.Text + "\"/>" +
                        "\r\n\t<property name=\"TelnetEnabled\"                             value=\"" + ConfigProperty_TelnetEnabled.Text.ToLower() + "\"/>" +
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
                        "\r\n\t<property name=\"HideCommandExecutionLog\"                   value=\"" + ConfigProperty_HideCommandExecutionLog.SelectedIndex.ToString() + "\"/>" +
                        "\r\n\t<property name=\"MaxUncoveredMapChunksPerPlayer\"            value=\"" + ConfigProperty_MaxUncoveredMapChunksPerPlayer.Text + "\"/>" +
                        "\r\n\t<property name=\"PersistentPlayerProfiles\"                  value=\"" + ConfigProperty_PersistentPlayerProfiles.Text + "\"/>" +
                        "\r\n\r\n\t<!-- GAMEPLAY -->" +
                        "\r\n\r\n\t<!-- World -->" +
                        "\r\n\t<property name=\"GameWorld\"                                 value=\"" + ConfigProperty_GameWorld.Text + "\"/>" +
                        "\r\n\t<property name=\"WorldGenSeed\"                              value=\"" + ConfigProperty_WorldGenSeed.Text + "\"/>" +
                        "\r\n\t<property name=\"WorldGenSize\"                              value=\"" + ConfigProperty_WorldGenSize.Value + "\"/>" +
                        "\r\n\t<property name=\"GameName\"                                  value=\"" + ConfigProperty_GameName.Text + "\"/>" +
                        "\r\n\t<property name=\"GameMode\"                                  value=\"" + ConfigProperty_GameMode.Text + "\"/>" +
                        "\r\n\r\n\t<!-- Difficulty -->" +
                        "\r\n\t<property name=\"GameDifficulty\"                            value=\"" + ConfigProperty_GameDifficulty.Value + "\"/>" +
                        "\r\n\t<property name=\"BlockDamagePlayer\"                         value=\"" + ConfigProperty_BlockDamagePlayer.Value + "\"/>" +
                        "\r\n\t<property name=\"BlockDamageAI\"                             value=\"" + ConfigProperty_BlockDamageAI.Value + "\"/>" +
                        "\r\n\t<property name=\"BlockDamageAIBM\"                           value=\"" + ConfigProperty_BlockDamageAIBM.Value + "\"/>" +
                        "\r\n\t<property name=\"XPMultiplier\"                              value=\"" + ConfigProperty_XPMultiplier.Value + "\"/>" +
                        "\r\n\t<property name=\"PlayerSafeZoneLevel\"                       value=\"" + ConfigProperty_PlayerSafeZoneLevel.Text + "\"/>" +
                        "\r\n\t<property name=\"PlayerSafeZoneHours\"                       value=\"" + ConfigProperty_PlayerSafeZoneHours.Text + "\"/>" +
                        "\r\n\r\n\t<!--  -->" +
                        "\r\n\t<property name=\"BuildCreate\"                               value=\"" + ConfigProperty_BuildCreate.Text.ToLower() + "\"/>" +
                        "\r\n\t<property name=\"DayNightLength\"                            value=\"" + ConfigProperty_DayNightLength.Value + "\"/>" +
                        "\r\n\t<property name=\"DayLightLength\"                            value=\"" + ConfigProperty_DayLightLength.Value + "\"/>" +
                        "\r\n\t<property name=\"DropOnDeath\"                               value=\"" + ConfigProperty_DropOnDeath.SelectedIndex.ToString() + "\"/>" +
                        "\r\n\t<property name=\"DropOnQuit\"                                value=\"" + ConfigProperty_DropOnQuit.SelectedIndex.ToString() + "\"/>" +
                        "\r\n\t<property name=\"BedrollDeadZoneSize\"                       value=\"" + ConfigProperty_BedrollDeadZoneSize.Value + "\"/>" +
                        "\r\n\t<property name=\"BedrollExpiryTime\"                         value=\"" + ConfigProperty_BedrollExpiryTime.Value + "\"/>" +
                        "\r\n\r\n\t<!-- Performance Related -->" +
                        "\r\n\t<property name=\"MaxSpawnedZombies\"                         value=\"" + ConfigProperty_MaxSpawnedZombies.Value + "\"/>" +
                        "\r\n\t<property name=\"MaxSpawnedAnimals\"                         value=\"" + ConfigProperty_MaxSpawnedAnimals.Value + "\"/>" +
                        "\r\n\t<property name=\"ServerMaxAllowedViewDistance\"              value=\"" + ConfigProperty_ServerMaxAllowedViewDistance.Value + "\"/>" +
                        "\r\n\r\n\t<!-- Zombie Settings -->" +
                        "\r\n\t<property name=\"EnemySpawnMode\"                            value=\"" + ConfigProperty_EnemySpawnMode.Text.ToLower() + "\"/>" +
                        "\r\n\t<property name=\"EnemyDifficulty\"                           value=\"" + ConfigProperty_EnemyDifficulty.Text + "\"/>" +
                        "\r\n\t<property name=\"ZombieMove\"                                value=\"" + ConfigProperty_ZombieMove.SelectedIndex.ToString() + "\"/>" +
                        "\r\n\t<property name=\"ZombieMoveNight\"                           value=\"" + ConfigProperty_ZombieMoveNight.SelectedIndex.ToString() + "\"/>" +
                        "\r\n\t<property name=\"ZombieFeralMove\"                           value=\"" + ConfigProperty_ZombieFeralMove.SelectedIndex.ToString() + "\"/>" +
                        "\r\n\t<property name=\"ZombieBMMove\"                              value=\"" + ConfigProperty_ZombieBMMove.SelectedIndex.ToString() + "\"/>" +
                        "\r\n\t<property name=\"BloodMoonFrequency\"                        value=\"" + ConfigProperty_BloodMoonFrequency.Value + "\"/>" +
                        "\r\n\t<property name=\"BloodMoonRange\"                            value=\"" + ConfigProperty_BloodMoonRange.Value + "\"/>" +
                        "\r\n\t<property name=\"BloodMoonWarning\"                          value=\"" + ConfigProperty_BloodMoonWarning.Value + "\"/>" +
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

                #endregion

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
                                    //Default: My Game Host
                                    ConfigProperty_ServerName.Text = Config_File_Property_Value;
                                    break;
                                
                                case "ServerDescription":
                                    // Default: A 7 Days to Die server
                                    ConfigProperty_ServerDescription.Text = Config_File_Property_Value;
                                    break;
                                
                                case "ServerWebsiteURL":
                                    // Default: (blank)
                                    ConfigProperty_ServerWebsiteURL.Text = Config_File_Property_Value;
                                    break;

                                case "ServerPassword":
                                    // Default: (blank)
                                    ConfigProperty_ServerPassword.Text = Config_File_Property_Value;
                                    break;

                                case "ServerLoginConfirmationText":
                                    // Default: (blank)
                                    ConfigProperty_ServerLoginConfirmationText.Text = Config_File_Property_Value;
                                    break;

                                case "ServerPort":
                                    //Default: 26900
                                    ConfigProperty_ServerPort.Text = Config_File_Property_Value;
                                    break;

                                case "ServerVisibility":
                                    // Default : 2 (Public)
                                    // 2 = public, 1 = Only Shown To Friends, 0 = Not Listed.
                                    if (Config_File_Property_Value == "2")
                                        ConfigProperty_ServerVisibility.SelectedIndex = 2;
                                    else if (Config_File_Property_Value == "1")
                                        ConfigProperty_ServerVisibility.SelectedIndex = 1;
                                    else if (Config_File_Property_Value == "0")
                                        ConfigProperty_ServerVisibility.SelectedIndex = 0;
                                    break;

                                case "ServerDisabledNetworkProtocols":
                                    // Default: SteamNetworking                                    
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
                                    ConfigProperty_ServerMaxWorldTransferSpeedKiBs.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;
                                
                                case "ServerMaxPlayerCount":
                                    // Default: 8
                                    ConfigProperty_ServerMaxPlayerCount.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;
                                
                                case "ServerReservedSlots":
                                    // Default: 0
                                    ConfigProperty_ServerReservedSlots.Text = Config_File_Property_Value;
                                    break;
                                
                                case "ServerReservedSlotsPermission":
                                    // Default: 100
                                    ConfigProperty_ServerReservedSlotsPermission.Text = Config_File_Property_Value;
                                    break;
                                
                                case "ServerAdminSlots":
                                    //Default: 0
                                    ConfigProperty_ServerAdminSlots.Text = Config_File_Property_Value;
                                    break;

                                case "ServerAdminSlotsPermission":
                                    //Default: 0
                                    ConfigProperty_ServerAdminSlotsPermission.Text = Config_File_Property_Value;
                                    break;

                                case "ControlPanelEnabled":
                                    // Default: false
                                    if (Config_File_Property_Value == "true")
                                    {
                                        ConfigProperty_ControlPanelEnabled.ToggleState = ToggleButtonState.Active;
                                    }
                                    else
                                    {
                                        ConfigProperty_ControlPanelEnabled.ToggleState = ToggleButtonState.Inactive;
                                    }
                                    break;

                                case "ControlPanelPort":
                                    // Default: 8080
                                    ConfigProperty_ControlPanelPort.Text = Config_File_Property_Value;
                                    break;

                                case "ControlPanelPassword":
                                    // Default: CHANGEME
                                    ConfigProperty_ControlPanelPassword.Text = Config_File_Property_Value;
                                    break;

                                case "TelnetEnabled":
                                    // Default: true
                                    if (Config_File_Property_Value == "true")
                                    {
                                        ConfigProperty_TelnetEnabled.ToggleState = ToggleButtonState.Active;
                                    }
                                    else
                                    {
                                        ConfigProperty_TelnetEnabled.ToggleState = ToggleButtonState.Inactive;
                                    }
                                    break;

                                case "TelnetPort":
                                    // Default: 8081
                                    ConfigProperty_TelnetPort.Text = Config_File_Property_Value;
                                    break;

                                case "TelnetPassword":
                                    // Default: (blank)
                                    ConfigProperty_TelnetPassword.Text = Config_File_Property_Value;
                                    break;

                                case "TelnetFailedLoginLimit":
                                    // Default: 10
                                    ConfigProperty_TelnetFailedLoginLimit.Text = Config_File_Property_Value;
                                    break;

                                case "TelnetFailedLoginsBlocktime":
                                    // Default: 10
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
                                    // Default: serveradmin.xml
                                    ConfigProperty_AdminFileName.Text = Config_File_Property_Value;
                                    break;

                                case "UserDataFolder":
                                    // Default: (Disabled)
                                    ConfigProperty_UserDataFolder.Text = Config_File_Property_Value;
                                    break;

                                case "SaveGameFolder":
                                    // Default: (Disabled)
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
                                    // Default: 0 (Show Everything)
                                    // 0 = Show Everything, 1 = Hide From Telnet / ControlPanel, 2 = Hide From Telnet / ControlPanel / Remote Game Clients, 3 = Hide Everything
                                    if (Config_File_Property_Value == "3")
                                        ConfigProperty_HideCommandExecutionLog.SelectedIndex = 3;
                                    else if (Config_File_Property_Value == "2")
                                        ConfigProperty_HideCommandExecutionLog.SelectedIndex = 2;
                                    else if (Config_File_Property_Value == "1")
                                        ConfigProperty_HideCommandExecutionLog.SelectedIndex = 1;
                                    else if (Config_File_Property_Value == "0")
                                        ConfigProperty_HideCommandExecutionLog.SelectedIndex = 0;
                                    break;

                                case "MaxUncoveredMapChunksPerPlayer":
                                    // Default: 131072
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
                                    // Default: Navezgane
                                    if (Config_File_Property_Value == "Navezgane")
                                        ConfigProperty_GameWorld.SelectedIndex = 1;
                                    else
                                        ConfigProperty_GameWorld.SelectedIndex = 0;
                                    break;

                                case "WorldGenSeed":
                                    // Default: asdf
                                    ConfigProperty_WorldGenSeed.Text = Config_File_Property_Value;
                                    break;

                                case "WorldGenSize":
                                    // Default: 4096
                                    ConfigProperty_WorldGenSize.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "GameName":
                                    // Default: My Game
                                    ConfigProperty_GameName.SelectedText = Config_File_Property_Value;
                                    break;

                                case "GameMode":
                                    // Default: GameModeSurvival
                                    ConfigProperty_GameMode.SelectedText = Config_File_Property_Value;
                                    break;

                                case "GameDifficulty":
                                    // Default: 2
                                    ConfigProperty_GameDifficulty.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;
                                
                                case "BlockDamagePlayer":
                                    // Default: 100
                                    ConfigProperty_BlockDamagePlayer.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "BlockDamageAI":
                                    // Default: 100
                                    ConfigProperty_BlockDamageAI.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "BlockDamageAIBM":
                                    // Default: 100
                                    ConfigProperty_BlockDamageAIBM.Value = Convert.ToInt32(Config_File_Property_Value);

                                    // Update Text To Currently Set Value
                                    if (ConfigProperty_BlockDamageAIBM.Value == 0)
                                        BlockDamageAIBM_GroupBox.Text = "AI Block Damage During Blood Moon [25%]";
                                    else
                                        BlockDamageAIBM_GroupBox.Text = "AI Block Damage During Blood Moon [" + Convert.ToInt32(ConfigProperty_BlockDamageAIBM.Value) + "%]";
                                    break;

                                case "XPMultiplier":
                                    // Default: 100
                                    ConfigProperty_XPMultiplier.Value = Convert.ToInt32(Config_File_Property_Value);

                                    // Update Text To Currently Set Value
                                    if (ConfigProperty_XPMultiplier.Value == 0)
                                        XPMultiplier_GroupBox.Text = "XP Multiplier [25%]";
                                    else
                                        XPMultiplier_GroupBox.Text = "XP Multiplier [" + Convert.ToInt32(ConfigProperty_XPMultiplier.Value) + "%]";
                                    break;

                                case "PlayerSafeZoneLevel":
                                    // Default: 5
                                    ConfigProperty_PlayerSafeZoneLevel.Text = Config_File_Property_Value;
                                    break;
                                
                                case "PlayerSafeZoneHours":
                                    // Default: 5
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
                                    // Default: 60
                                    ConfigProperty_DayNightLength.Value = Convert.ToInt32(Config_File_Property_Value);

                                    // Update Text To Currently Set Value
                                    DayNightLength_GroupBox.Text = "Each In Game Day Equals [" + Convert.ToInt32(ConfigProperty_DayNightLength.Value) + "] Real World Minutes";
                                    break;
                                
                                case "DayLightLength":
                                    // Default: 18
                                    ConfigProperty_DayLightLength.Value = Convert.ToInt32(Config_File_Property_Value);

                                    // Update Text To Currently Set Value
                                    DayLightLength_GroupBox.Text = "Sun Shines For [" + ConfigProperty_DayLightLength.Value + "] Hours Each Game Day ";
                                    break;
                                
                                case "DropOnDeath":
                                    // Default: 1 (Everything)
                                    // 0 = Nothing, 1 = Everything, 2 = Toolbelt Only, 3 = Backpack Only, 4 = Delete All
                                    if (Config_File_Property_Value == "4")
                                        ConfigProperty_DropOnDeath.SelectedIndex = 4;
                                    else if (Config_File_Property_Value == "3")
                                        ConfigProperty_DropOnDeath.SelectedIndex = 3;
                                    else if (Config_File_Property_Value == "2")
                                        ConfigProperty_DropOnDeath.SelectedIndex = 2;
                                    else if (Config_File_Property_Value == "1")
                                        ConfigProperty_DropOnDeath.SelectedIndex = 1;
                                    else if (Config_File_Property_Value == "0")
                                        ConfigProperty_DropOnDeath.SelectedIndex = 0;
                                    break;

                                case "DropOnQuit":
                                    // Default: 0 (Nothing)
                                    // 0 = Nothing, 1 = Everything, 2 = Toolbelt Only, 3 = Backpack Only
                                    if (Config_File_Property_Value == "3")
                                        ConfigProperty_DropOnQuit.SelectedIndex = 3;
                                    else if (Config_File_Property_Value == "2")
                                        ConfigProperty_DropOnQuit.SelectedIndex = 2;
                                    else if (Config_File_Property_Value == "1")
                                        ConfigProperty_DropOnQuit.SelectedIndex = 1;
                                    else if (Config_File_Property_Value == "0")
                                        ConfigProperty_DropOnQuit.SelectedIndex = 0;
                                    break;

                                case "BedrollDeadZoneSize":
                                    // Default: 15
                                    ConfigProperty_BedrollDeadZoneSize.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "BedrollExpiryTime":
                                    // Default: 45
                                    ConfigProperty_BedrollExpiryTime.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "MaxSpawnedZombies":
                                    // Default: 60
                                    ConfigProperty_MaxSpawnedZombies.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "MaxSpawnedAnimals":
                                    // Default: 50
                                    ConfigProperty_MaxSpawnedAnimals.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "ServerMaxAllowedViewDistance":
                                    // Default: 12
                                    ConfigProperty_ServerMaxAllowedViewDistance.Value = Convert.ToInt32(Config_File_Property_Value);

                                    // Update Text To Currently Set Value

                                    break;

                                case "EnemySpawnMode":
                                    // Default: true
                                    if (Config_File_Property_Value == "true")
                                        ConfigProperty_EnemySpawnMode.ToggleState = ToggleButtonState.Active;
                                    else
                                        ConfigProperty_EnemySpawnMode.ToggleState = ToggleButtonState.Inactive;
                                    break;

                                case "EnemyDifficulty":
                                    // Default: 0
                                    // 0 = Normal / Toggle Inactive, 1 = Feral / Toggle Active 
                                    if (Config_File_Property_Value == "1")
                                        ConfigProperty_EnemyDifficulty.ToggleState = ToggleButtonState.Active;
                                    else
                                        ConfigProperty_EnemyDifficulty.ToggleState = ToggleButtonState.Inactive;
                                    break;

                                case "ZombieMove":
                                    // Default: 0
                                    // 0 = Walk, 1 = Jog, 2 = Run, 3 = Sprint, 4 = Nightmare)
                                    if (Config_File_Property_Value == "4")
                                        ConfigProperty_ZombieMove.SelectedIndex = 4;
                                    else if (Config_File_Property_Value == "3")
                                        ConfigProperty_ZombieMove.SelectedIndex = 3;
                                    else if (Config_File_Property_Value == "2")
                                        ConfigProperty_ZombieMove.SelectedIndex = 2;
                                    else if (Config_File_Property_Value == "1")
                                        ConfigProperty_ZombieMove.SelectedIndex = 1;
                                    else if (Config_File_Property_Value == "0")
                                        ConfigProperty_ZombieMove.SelectedIndex = 0;
                                    break;

                                case "ZombieMoveNight":
                                    // Default: 3
                                    // 0 = Walk, 1 = Jog, 2 = Run, 3 = Sprint, 4 = Nightmare)
                                    if (Config_File_Property_Value == "4")
                                        ConfigProperty_ZombieMoveNight.SelectedIndex = 4;
                                    else if (Config_File_Property_Value == "3")
                                        ConfigProperty_ZombieMoveNight.SelectedIndex = 3;
                                    else if (Config_File_Property_Value == "2")
                                        ConfigProperty_ZombieMoveNight.SelectedIndex = 2;
                                    else if (Config_File_Property_Value == "1")
                                        ConfigProperty_ZombieMoveNight.SelectedIndex = 1;
                                    else if (Config_File_Property_Value == "0")
                                        ConfigProperty_ZombieMoveNight.SelectedIndex = 0;
                                    break;

                                case "ZombieFeralMove":
                                    // Default: 3
                                    // 0 = Walk, 1 = Jog, 2 = Run, 3 = Sprint, 4 = Nightmare)
                                    if (Config_File_Property_Value == "4")
                                        ConfigProperty_ZombieFeralMove.SelectedIndex = 4;
                                    else if (Config_File_Property_Value == "3")
                                        ConfigProperty_ZombieFeralMove.SelectedIndex = 3;
                                    else if (Config_File_Property_Value == "2")
                                        ConfigProperty_ZombieFeralMove.SelectedIndex = 2;
                                    else if (Config_File_Property_Value == "1")
                                        ConfigProperty_ZombieFeralMove.SelectedIndex = 1;
                                    else if (Config_File_Property_Value == "0")
                                        ConfigProperty_ZombieFeralMove.SelectedIndex = 0;
                                    break;

                                case "ZombieBMMove":
                                    // Default: 3
                                    // 0 = Walk, 1 = Jog, 2 = Run, 3 = Sprint, 4 = Nightmare)
                                    if (Config_File_Property_Value == "4")
                                        ConfigProperty_ZombieBMMove.SelectedIndex = 4;
                                    else if (Config_File_Property_Value == "3")
                                        ConfigProperty_ZombieBMMove.SelectedIndex = 3;
                                    else if (Config_File_Property_Value == "2")
                                        ConfigProperty_ZombieBMMove.SelectedIndex = 2;
                                    else if (Config_File_Property_Value == "1")
                                        ConfigProperty_ZombieBMMove.SelectedIndex = 1;
                                    else if (Config_File_Property_Value == "0")
                                        ConfigProperty_ZombieBMMove.SelectedIndex = 0;
                                    break;

                                case "BloodMoonFrequency":
                                    // Default: 7
                                    ConfigProperty_BloodMoonFrequency.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "BloodMoonRange":
                                    // Default: 0
                                    ConfigProperty_BloodMoonRange.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "BloodMoonWarning":
                                    // Default: 8
                                    ConfigProperty_BloodMoonWarning.Value = Convert.ToInt32(Config_File_Property_Value);
                                    break;

                                case "BloodMoonEnemyCount":
                                    // Default: 8
                                    ConfigProperty_BloodMoonEnemyCount.Value = Convert.ToInt32(Config_File_Property_Value);
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