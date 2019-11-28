using System;
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

        //public void Generate_Config(object sender, EventArgs e)
        //{
        //    Update_Config();
        //}

        public void Update_Config()
        {
            if (Public_IP_Address_Label.Text != "Checking IP...")  // The Label Is Changed After The Configuration Is Loaded, So That It Doesn't Get Accessed When Loading The Configuration From A File.
            {
                Echo_debug("---Updating & Saving Config---");

                // Init Config Default Values
                string gamemode = "GameModeSurvivalMP";
                string serverispublic = "false";
                string cheat = "false";
                string cpl = "false";
                string zombierun = "0";
                string dropondeathmode = "0";
                string droponquitmode = "0";
                string feral_c = "0";
                string vac = "false";
                string PersistentPlayerProfiles_l = "false";
                string PlayerKillingMode = "0";
                string adm = "false";
                string hce = "0";
                string sdnp = "";
                string EnemySpawnMode_Selected="false";

                // Set Enemy Spawn Mode
                if (ConfigProperty_EnemySpawnMode.Checked)
                    EnemySpawnMode_Selected = "true";
                else
                    EnemySpawnMode_Selected = "false";

                // Set Zombie Speeds
                if (zombie_never_run.Checked)
                    zombierun = "1";
                else if (zombie_run.Checked)
                    zombierun = "2";

                // Set Server Public Status
                if (ServerIsPublic.Checked)
                    serverispublic = "true";

                // Set Server Cheat Mode
                if (ConfigProperty_BuildCreate.Checked)
                    cheat = "true";

                // Set Server Networking Modes
                if (UNET.Checked)
                    sdnp += "unet,";
                if (RakNet.Checked)
                    sdnp += "raknet,";
                if (SteamNetworking.Checked)
                    sdnp += "steamnetworking";

                // Set ?????
                if(sdnp.EndsWith(","))
                    sdnp = sdnp.Substring(0, sdnp.Length - 1);

                // Set ???
                if (ConfigProperty_ControlPanelEnabled.Checked)
                    cpl = "true";

                // Set Player Persistant Profiles
                if (ConfigProperty_PersistentPlayerProfiles.Checked)
                    PersistentPlayerProfiles_l = "true";

                // Set EAC Mode
                if (ConfigProperty_EACEnabled.Checked)
                    vac = "true";

                // Set Air Drop Marker
                if (AirDropMarker.Checked)
                    adm = "true";

                // Set Player Killing Mode
                if (Player_Killing_Mode_0.Checked)
                    PlayerKillingMode = "0";
                else if (Player_Killing_Mode_1.Checked)
                    PlayerKillingMode = "1";
                else if (Player_Killing_Mode_2.Checked)
                    PlayerKillingMode = "2";
                else if (Player_Killing_Mode_3.Checked)
                    PlayerKillingMode = "3";

                // Set Player Drop On Death Mode
                if (ConfigProperty_DropOnDeath.Text == "Nothing")
                    dropondeathmode = "0";
                else if (ConfigProperty_DropOnDeath.Text == "Everything")
                    dropondeathmode = "1";
                else if (ConfigProperty_DropOnDeath.Text == "Toolbelt Only")
                    dropondeathmode = "2";
                else if (ConfigProperty_DropOnDeath.Text == "Backpack Only")
                    dropondeathmode = "3";
                else if (ConfigProperty_DropOnDeath.Text == "Delete All")
                    dropondeathmode = "4";

                // Set Player Drop On Quit Mode
                if (ConfigProperty_DropOnQuit.Text == "Nothing")
                    droponquitmode = "0";
                else if (ConfigProperty_DropOnQuit.Text == "Everything")
                    droponquitmode = "1";
                else if (ConfigProperty_DropOnQuit.Text == "Toolbelt Only")
                    droponquitmode = "2";
                else if (ConfigProperty_DropOnQuit.Text == "Backpack Only")
                    droponquitmode = "3";

                // Set Terminal Window Mode
                //TODO: UPDATE TO CASE STATEMENT???
                if (ConfigProperty_HideCommandExecutionLog.Text == "Show Everything")
                    hce = "0";
                else if (ConfigProperty_HideCommandExecutionLog.Text == "Hide Only From Telnet / Control Panel")
                    hce = "1";
                else if (ConfigProperty_HideCommandExecutionLog.Text == "Hide From Telnet / Control Panel / Remote Game Clients")
                    hce = "2";
                else if (ConfigProperty_HideCommandExecutionLog.Text == "Hide Everything")
                    hce = "3";

                // Set ????
                string lcdm="0";
                if (Linear.Checked)
                    lcdm = "0";
                else if (Exponential.Checked)
                    lcdm = "1";
                else if (Full_prot.Checked)
                    lcdm = "2";

                // Set ????
                int bdm_t = 0;
                if (ConfigProperty_BlockDamagePlayer.Value == 0)
                    bdm_t = 25;
                else
                    bdm_t = ConfigProperty_BlockDamagePlayer.Value*50;

                // Set ????
                if (ConfigProperty_EnemyDifficulty.Checked)
                    feral_c = "1";

                // Set ????
                string savegamefolderproperty = "";
                if (ConfigProperty_SaveGameFolder.Text != "")
                {
                    savegamefolderproperty = "  <property name=\"SaveGameFolder\"				value=\"" + ConfigProperty_SaveGameFolder.Text + "\"/>\r\n";
                }

                /*
                // Set ????
                string userdatafolderproperty = "";
                if (userdata.Text != "")
                {
                    userdatafolderproperty = "  <property name=\"SaveGameFolder\"				value=\"" + userdata.Text + "\"/>\r\n";
                }
                */

                /*
                 *
                    Alpha 18.1 Configuration File Sample
                  

                    string config = "<?xml version=\"1.0\"?>\r\n<ServerSettings>\r\n  " +
                        "\n\n<!-- GENERAL SERVER SETTINGS -->" +
                        "\n\n<!-- Server representation -->" +
                        "\"/>\r\n  <property name=\"ServerName\" 				    value=\"" + server_nazwa.Text + 
                        "\"/>\r\n  <property name=\"ServerDescription\"				value=\"" + ServerDescription.Text +
                        "\"/>\r\n  <property name=\"ServerWebsiteURL\"				value=\"" + ServerWebsiteURL.Text +
                        "\"/>\r\n  <property name=\"ServerPassword\" 		    	value=\"" + ServerPassword.Text + 
                        <property name="ServerLoginConfirmationText"	value="" />					<!-- If set the user will see the message during joining the server and has to confirm it before continuing. For more complex changes to this window you can change the "serverjoinrulesdialog" window in XUi -->
                        "\n\n<!-- Networking -->" +
                        "<property name=\"ServerPort\" 			        value=\"" + port.Text +
                        "\"/>\r\n  <property name=\"ServerVisibility\" 		    	value=\"" + serverispublic + 
                        "\"/>\r\n  <property name=\"ServerDisabledNetworkProtocols\"				    	value=\"" + sdnp +
	                    <property name="ServerMaxWorldTransferSpeedKiBs" value="512"/>				<!-- Maximum (!) speed in kiB/s the world is transferred at to a client on first connect if it does not have the world yet. Maximum is about 1300 kiB/s, even if you set a higher value. -->
                        "\n\n<!-- Slots -->" +
                        "\"/>\r\n  <property name=\"ServerMaxPlayerCount\"      	value=\"" + maxpl.Value +
                        "\"/>\r\n  <property name=\"ServerReservedSlots\"				    	value=\"" + Server_Player_Reserved_Slots.Text +
                        "\"/>\r\n  <property name=\"ServerReservedSlotsPermission\"				    	value=\"" + Server_Player_Reserved_Slots_Permission.Text +
                        "\"/>\r\n  <property name=\"ServerAdminSlots\"				    	value=\"" + Server_Admin_Reserved_Slots.Text +
                        "\"/>\r\n  <property name=\"ServerAdminSlotsPermission\"				    	value=\"" + Server_Admin_Reserved_Slots_Permission.Text +
                        "\n\n<!-- Admin Interfaces -->" +
                        "\" />\r\n\r\n  <property name=\"ControlPanelEnabled\"	 	    value=\"" + cpl + 
                        "\"/>\r\n  <property name=\"ControlPanelPort\" 		    value=\"" + port_panel.Text + 
                        "\"/>\r\n  <property name=\"ControlPanelPassword\"      	value=\"" + ctrlppass.Text + 
                        "\"/>\r\n\r\n  <property name=\"TelnetEnabled\"	 	    	value=\"true\"" +
                        "/>\r\n  <property name=\"TelnetPort\" 				    value=\"" + telnet_port_p.Text +
                        "\"/>\r\n  <property name=\"TelnetPassword\"				value=\"" + telnet_psw.Text +
	                    <property name="TelnetFailedLoginLimit"			value="10"/>				<!-- After this many wrong passwords from a single remote client the client will be blocked from connecting to the Telnet interface -->
	                    <property name="TelnetFailedLoginsBlocktime"	value="10"/>				<!-- How long will the block persist (in seconds) -->
                        <property name="TerminalWindowEnabled"			value="true"/>				<!-- Show a terminal window for log output / command input (Windows only) -->
                        "\n\n<!-- Folder and file locations -->\n\n" +
                        "\"/>\r\n  <property name=\"AdminFileName\"			    value=\"" + AdminFileName.Text +
	                    userdatafolderproperty +
                        <!-- <property name="UserDataFolder"				value="absolute path" /> -->	<!-- Use this to override where the server stores all generated data, including RWG generated worlds. Do not forget to uncomment the entry! -->
	                    savegamefolderproperty +        
                        <!-- <property name="SaveGameFolder"				value="absolute path" /> -->	<!-- Use this to only override the save game path. Do not forget to uncomment the entry! -->
                        "\n\n<!-- Other technical settings -->" +
                        "\"/>\r\n  <property name=\"EACEnabled\"				value=\"" + vac +
                        "\"/>\r\n  <property name=\"HideCommandExecutionLog\"				    	value=\"" + hce +
                        "\"/>\r\n  <property name=\"MaxUncoveredMapChunksPerPlayer\"				    	value=\"" + MaxUncoveredMapChunksPerPlayer.Text +
                        "\"/>\r\n  <property name=\"PersistentPlayerProfiles\"		value=\"" + PersistentPlayerProfiles_l +
                        "\n\n<!-- GAMEPLAY -->\n" +
                        "\n\n<!-- World -->\n" +
                        "\"/>\r\n  \r\n  <property name=\"GameWorld\" 		        	value=\"" + mapa.Text + 
                        <property name="WorldGenSeed"					value="asdf"/>				<!-- If RWG this is the seed for the generation of the new world. If a world with the resulting name already exists it will simply load it -->
	                    <property name="WorldGenSize"					value="4096"/>				<!-- If RWG this controls the width and height of the created world. It is also used in combination with WorldGenSeed to create the internal RWG seed thus also creating a unique map name even if using the same WorldGenSeed. Has to be between 2048 and 16384, though large map sizes will take long to generate / download / load -->
                        "\"/>\r\n  <property name=\"GameName\" 				    value=\"" + nazwa.Text + 
                        "\"/>\r\n  <property name=\"GameMode\"				    	value=\"" + gamemode +
                        "\n\n<!-- Difficulty -->\n" +
                        "\"/>\r\n  <property name=\"GameDifficulty\" 		    	value=\"" + Game_Difficulty_TrackBar.Value +
                        <property name="BlockDamagePlayer"				value="100" />				<!-- How much damage do players to blocks (percentage in whole numbers) -->
	                    <property name="BlockDamageAI"					value="100" />				<!-- How much damage do AIs to blocks (percentage in whole numbers) -->
	                    <property name="BlockDamageAIBM"				value="100" />				<!-- How much damage do AIs during blood moons to blocks (percentage in whole numbers) -->
	                    <property name="XPMultiplier"					value="100" />				<!-- XP gain multiplier (percentage in whole numbers) -->
	                    "\"/>\r\n  <property name=\"PlayerSafeZoneLevel\"				value=\"" + Player_Safe_Zone_Level_TextBox.Text +
                        "\"/>\r\n  <property name=\"PlayerSafeZoneHours\"				value=\"" + Player_Safe_Zone_Hours_TextBox.Text +
                        "\n\n<!--  -->\n" +
                        "\" />\r\n  <property name=\"BuildCreate\"			    	value=\"" + cheat + 
                        "\" />\r\n  <property name=\"DayNightLength\"		    	value=\"" + Realtime_get() +
                        "\"/>\r\n  <property name=\"DayLightLength\"				value=\"" + nightpercentage.Value +
                        "\"/>\r\n\r\n  <property name=\"DropOnDeath\"			    	value=\"" + dropondeathmode + 
                        "\"/>\r\n  <property name=\"DropOnQuit\"			    	value=\"" + droponquitmode +
                        "\"/>\r\n  <property name=\"BedrollDeadZoneSize\"				    	value=\"" + BedrollDeadZoneSize.Value +
                        <property name="BedrollExpiryTime"				value="45" />				<!-- Number of days a bedroll stays active after owner was last online -->
                        "\n\n<!-- Performance Related -->\n" +
                        "\"/>\r\n  <property name=\"MaxSpawnedZombies\"				value=\"" + MaxSpawnedZombies.Value +
                        "\"/>\r\n  <property name=\"MaxSpawnedAnimals\"				value=\"" + MaxSpawnedAnimals.Value +
                        <property name="ServerMaxAllowedViewDistance"	value="12" />				<!-- Max viewdistance a client may request (6 - 12). High impact on memory usage and performance. -->
                        "\n\n<!-- Zombie Settings -->\n" +
                        "\"/>\r\n  <property name=\"EnemySpawnMode\"				value=\"" + EnemySpawnMode_Selected +
                        "\"/>\r\n  <property name=\"EnemyDifficulty\"				value=\"" + feral_c +
	                    <property name="ZombieMove"						value="0" />				<!-- 0-4 (walk, jog, run, sprint, nightmare) -->
	                    <property name="ZombieMoveNight"				value="3" />				<!-- 0-4 (walk, jog, run, sprint, nightmare) -->
	                    <property name="ZombieFeralMove"				value="3" />				<!-- 0-4 (walk, jog, run, sprint, nightmare) -->
	                    <property name="ZombieBMMove"					value="3" />				<!-- 0-4 (walk, jog, run, sprint, nightmare) -->
	                    <property name="BloodMoonFrequency"				value="7" />				<!-- What frequency (in days) should a blood moon take place. Set to "0" for no blood moons -->
	                    <property name="BloodMoonRange"					value="0" />				<!-- How many days can the actual blood moon day randomly deviate from the above setting. Setting this to 0 makes blood moons happen exactly each Nth day as specified in BloodMoonFrequency -->
	                    <property name="BloodMoonWarning"				value="8" />				<!-- The Hour number that the red day number begins on a blood moon day. Setting this to -1 makes the red never show.  -->
                        "\"/>\r\n  <property name=\"BloodMoonEnemyCount\"				    	value=\"" + BloodMoonEnemyCount.Value +	                   
                        "\n\n<!-- Loot -->\n" +
                        "\"/>\r\n  <property name=\"LootAbundance\"				value=\"" + LootAbundance.Value +
                        "\"/>\r\n  <property name=\"LootRespawnDays\"				value=\"" + LootRespawnDays.Value +
                        "\"/>\r\n  <property name=\"AirDropFrequency\"		value=\"" + Air_Drop_Frequency_TrackBar.Value +
                        "\"/>\r\n  <property name=\"AirDropMarker\"				value=\"" + adm +
                        "\n\n<!-- Multiplayer -->\n" +
	                    <property name="PartySharedKillRange"			value="100"/>				<!-- The distance you must be within to receive party shared kill xp and quest party kill objective credit. -->
                        "\" />\r\n  <property name=\"PlayerKillingMode\"			    	value=\"" + PlayerKillingMode + 	                    
                        "\n\n<!-- Land Claim Options -->\n" +
	                    <property name="LandClaimCount"					value="1"/>					<!-- Maximum allowed land claims per player. -->
	                    "\"/>\r\n  <property name=\"LandClaimSize\"				value=\"" + Land_Claim_Size_TextBox.Text +
                        "\"/>\r\n  <property name=\"LandClaimDeadZone\"				value=\"" + Land_Claim_Dead_Zone_TextBox.Text +
                        "\"/>\r\n  <property name=\"LandClaimExpiryTime\"				value=\"" + Land_Claim_Expiry_Time_TextBox.Text +
                        "\"/>\r\n  <property name=\"LandClaimDecayMode\"				value=\"" + lcdm +
                        "\"/>\r\n  <property name=\"LandClaimOnlineDurabilityModifier\"				value=\"" + LandClaimOnlineDurabilityModifier.Text +
                        "\"/>\r\n  <property name=\"LandClaimOfflineDurabilityModifier\"				value=\"" + LandClaimOfflineDurabilityModifier.Text + "\"/>\r\n" +

                    savegamefolderproperty +
                    "</ServerSettings>";

                 * 
                 */


                string config = "<?xml version=\"1.0\"?>\r\n<ServerSettings>\r\n  " +
                    "<property name=\"ServerPort\" 			        value=\"" + ConfigProperty_ServerPort.Text +
                    "\"/>\r\n  <property name=\"ServerIsPublic\" 		    	value=\"" + serverispublic + 
                    "\"/>\r\n  <property name=\"ServerName\" 				    value=\"" + ConfigProperty_ServerName.Text + 
                    "\"/>\r\n  <property name=\"ServerPassword\" 		    	value=\"" + ServerPassword.Text + 
                    "\"/>\r\n  <property name=\"ServerMaxPlayerCount\"      	value=\"" + ConfigProperty_ServerMaxPlayerCount.Value + 
                    "\"/>\r\n  \r\n  <property name=\"GameWorld\" 		        	value=\"" + ConfigProperty_GameWorld.Text + 
                    "\"/>\r\n  <property name=\"GameName\" 				    value=\"" + ConfigProperty_GameName.Text + 
                    "\"/>\r\n  <property name=\"GameDifficulty\" 		    	value=\"" + ConfigProperty_GameDifficulty.Value +
                    "\"/>\r\n  <property name=\"GameMode\"				    	value=\"" + gamemode +

                    "\"/>\r\n  <property name=\"ServerReservedSlots\"				    	value=\"" + ConfigProperty_ServerReservedSlots.Text +
                    "\"/>\r\n  <property name=\"ServerReservedSlotsPermission\"				    	value=\"" + ConfigProperty_ServerReservedSlotsPermission.Text +
                    "\"/>\r\n  <property name=\"ServerAdminSlots\"				    	value=\"" + ConfigProperty_ServerAdminSlots.Text +
                    "\"/>\r\n  <property name=\"ServerAdminSlotsPermission\"				    	value=\"" + ConfigProperty_ServerAdminSlotsPermission.Text +

                    "\"/>\r\n  <property name=\"BloodMoonEnemyCount\"				    	value=\"" + ConfigProperty_BloodMoonEnemyCount.Value +
                    "\"/>\r\n  <property name=\"MaxUncoveredMapChunksPerPlayer\"				    	value=\"" + ConfigProperty_MaxUncoveredMapChunksPerPlayer.Text +
                    "\"/>\r\n  <property name=\"BedrollDeadZoneSize\"				    	value=\"" + ConfigProperty_BedrollDeadZoneSize.Value +
                    "\"/>\r\n  <property name=\"HideCommandExecutionLog\"				    	value=\"" + hce +
                    "\"/>\r\n  <property name=\"ServerDisabledNetworkProtocols\"				    	value=\"" + sdnp +

                    "\"/>\r\n\r\n  <property name=\"ZombiesRun\"				    value=\"" + zombierun + 
                    "\" />\r\n  <property name=\"BuildCreate\"			    	value=\"" + cheat + 
                    "\" />\r\n  <property name=\"DayNightLength\"		    	value=\"" + Realtime_get() +
                    "\" />\r\n  <property name=\"PlayerKillingMode\"			    	value=\"" + PlayerKillingMode + 
                    "\" />\r\n\r\n  <property name=\"ControlPanelEnabled\"	 	    value=\"" + cpl + 
                    "\"/>\r\n  <property name=\"ControlPanelPort\" 		    value=\"" + ConfigProperty_ControlPanelPort.Text + 
                    "\"/>\r\n  <property name=\"ControlPanelPassword\"      	value=\"" + ConfigProperty_ControlPanelPassword.Text + 
                    "\"/>\r\n\r\n  <property name=\"TelnetEnabled\"	 	    	value=\"true\"" +
                    "/>\r\n  <property name=\"TelnetPort\" 				    value=\"" + ConfigProperty_TelnetPort.Text +
                    "\"/>\r\n  <property name=\"AdminFileName\"			    value=\"" + ConfigProperty_AdminFileName.Text +
                    "\"/>\r\n\r\n  <property name=\"DropOnDeath\"			    	value=\"" + dropondeathmode + 
                    "\"/>\r\n  <property name=\"DropOnQuit\"			    	value=\"" + droponquitmode +
                    "\"/>\r\n  <property name=\"BlockDurabilityModifier\"		value=\"" + bdm_t +
                    "\"/>\r\n  <property name=\"DayLightLength\"				value=\"" + ConfigProperty_DayLightLength.Value +
                    "\"/>\r\n  <property name=\"LootAbundance\"				value=\"" + ConfigProperty_LootAbundance.Value +
                    "\"/>\r\n  <property name=\"LootRespawnDays\"				value=\"" + ConfigProperty_LootRespawnDays.Value +
                    "\"/>\r\n  <property name=\"TelnetPassword\"				value=\"" + ConfigProperty_TelnetPassword.Text +
                    "\"/>\r\n  <property name=\"EnemySpawnMode\"				value=\"" + EnemySpawnMode_Selected +
                    "\"/>\r\n  <property name=\"AirDropFrequency\"		value=\"" + ConfigProperty_AirDropFrequency.Value +
                    "\"/>\r\n  <property name=\"PersistentPlayerProfiles\"		value=\"" + PersistentPlayerProfiles_l + 
                    "\"/>\r\n\r\n\r\n\r\n  <property name=\"LandClaimSize\"				value=\"" + ConfigProperty_LandClaimSize.Text +
                    "\"/>\r\n  <property name=\"LandClaimDeadZone\"				value=\"" + ConfigProperty_LandClaimDeadZone.Text +
                    "\"/>\r\n  <property name=\"LandClaimExpiryTime\"				value=\"" + ConfigProperty_LandClaimExpiryTime.Text +
                    "\"/>\r\n  <property name=\"LandClaimDecayMode\"				value=\"" + lcdm +
                    "\"/>\r\n  <property name=\"EnemyDifficulty\"				value=\"" + feral_c +
                    "\"/>\r\n  <property name=\"EACEnabled\"				value=\"" + vac +
                    "\"/>\r\n  <property name=\"AirDropMarker\"				value=\"" + adm +
                    "\"/>\r\n\r\n\r\n\r\n  <property name=\"ServerWebsiteURL\"				value=\"" + ConfigProperty_ServerWebsiteURL.Text +
                    "\"/>\r\n  <property name=\"ServerDescription\"				value=\"" + ConfigProperty_ServerDescription.Text +
                    "\"/>\r\n  <property name=\"MaxSpawnedZombies\"				value=\"" + ConfigProperty_MaxSpawnedZombies.Value +
                    "\"/>\r\n  <property name=\"MaxSpawnedAnimals\"				value=\"" + ConfigProperty_MaxSpawnedAnimals.Value +
                    "\"/>\r\n  <property name=\"PlayerSafeZoneLevel\"				value=\"" + ConfigProperty_PlayerSafeZoneLevel.Text +
                    "\"/>\r\n  <property name=\"PlayerSafeZoneHours\"				value=\"" + ConfigProperty_PlayerSafeZoneHours.Text +
                    "\"/>\r\n  <property name=\"LandClaimOnlineDurabilityModifier\"				value=\"" + ConfigProperty_LandClaimOnlineDurabilityModifier.Text +
                    "\"/>\r\n  <property name=\"LandClaimOfflineDurabilityModifier\"				value=\"" + ConfigProperty_LandClaimOfflineDurabilityModifier.Text + "\"/>\r\n" +
                    
                    "</ServerSettings>";
                try
                {
                    StreamWriter str = new StreamWriter((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "game_path", null) + "\\serverconfig.xml");

                    str.WriteLine(config);
                    str.Close();
                }
                catch
                {
                    Echo_debug("---ERR: File access error---");
                    System.Threading.Thread.Sleep(100);
                }
            }
        }



        public void Read_config()
        {
            Echo_debug("---Reading Game Config---");

            try
            {
                XmlReader xmlReader = XmlReader.Create((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "game_path", null) + "\\serverconfig.xml");
                while (xmlReader.Read())
                {
                    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "property"))
                    {
                        if (xmlReader.HasAttributes)
                        {
                            string name = xmlReader.GetAttribute("name");
                            string value = xmlReader.GetAttribute("value");
                            //echo_debug(name + ": " + value);

                            if (name == "ServerPort")
                                ConfigProperty_ServerPort.Text = value;
                            else if (name == "ServerIsPublic" && value == "true")
                                ServerIsPublic.Checked = true;
                            else if (name == "GameName")
                                this.ConfigProperty_GameName.Text = value;
                            else if (name == "ServerName")
                                ConfigProperty_ServerName.Text = value;
                            else if (name == "ServerPassword")
                                ServerPassword.Text = value;
                            else if (name == "ServerMaxPlayerCount")
                                ConfigProperty_ServerMaxPlayerCount.Value = Convert.ToInt32(value);
                            else if (name == "GameWorld")
                                ConfigProperty_GameWorld.Text = value;
                            else if (name == "GameDifficulty")
                                ConfigProperty_GameDifficulty.Value = Convert.ToInt32(value);
                            //else if (name == "GameMode")
                            //{
                                //if (value == "GameModeSurvival")
                                    //gamemode_coop.Checked = true;
                                //else
                                    //gamemode_surv_pvp.Checked = true;
                               
                            //}
                            else if (name == "PersistentPlayerProfiles" && value == "true")
                                ConfigProperty_PersistentPlayerProfiles.Checked = true;



                            else if (name == "AirDropMarker" && value == "true")
                                AirDropMarker.Checked = true;
                            else if (name == "BuildCreate" && value == "true")
                                ConfigProperty_BuildCreate.Checked = true;
                            else if (name == "DayNightLength")
                                ConfigProperty_DayNightLength.Value = Convert.ToInt32(value);
                            else if (name == "AirDropFrequency")
                                ConfigProperty_AirDropFrequency.Value = Convert.ToInt32(value);
                            else if (name == "ControlPanelEnabled" && value == "true")
                                ConfigProperty_ControlPanelEnabled.Checked = true;
                            else if (name == "ControlPanelPort")
                                ConfigProperty_ControlPanelPort.Text = value;
                            else if (name == "ControlPanelPassword")
                                ConfigProperty_ControlPanelPassword.Text = value;
                            else if (name == "PlayerSafeZoneLevel")
                                ConfigProperty_PlayerSafeZoneLevel.Text = value;
                            else if (name == "PlayerSafeZoneHours")
                                ConfigProperty_PlayerSafeZoneHours.Text = value;
                            else if (name == "EACEnabled" && value == "false")
                                ConfigProperty_EACEnabled.Checked = false;
                            else if (name == "MaxSpawnedZombies")
                                ConfigProperty_MaxSpawnedZombies.Value = Convert.ToInt32(value);
                            else if (name == "MaxSpawnedAnimals")
                                ConfigProperty_MaxSpawnedAnimals.Value = Convert.ToInt32(value);

                            else if (name == "ZombiesRun")
                            {
                                if (value == "1")
                                    zombie_never_run.Checked = true;
                                else if (value == "2")
                                    zombie_run.Checked = true;
                                else
                                    zombie_normal.Checked = true;
                            }

                            else if (name == "PlayerKillingMode")
                            {
                                if (value == "0")
                                    Player_Killing_Mode_0.Checked = true;
                                else if (value == "1")
                                    Player_Killing_Mode_1.Checked = true;
                                else if (value == "2")
                                    Player_Killing_Mode_2.Checked = true;
                                else if (value == "3")
                                    Player_Killing_Mode_3.Checked = true;
                            }

                            else if (name == "DropOnDeath")
                            {
                                if (value == "0")
                                    ConfigProperty_DropOnDeath.Text = "Nothing";
                                else if (value == "1")
                                    ConfigProperty_DropOnDeath.Text = "Everything";
                                else if (value == "2")
                                    ConfigProperty_DropOnDeath.Text = "Toolbelt Only";
                                else if (value == "3")
                                    ConfigProperty_DropOnDeath.Text = "Backpack Only";
                                else if (value == "4")
                                    ConfigProperty_DropOnDeath.Text = "Delete All";
                            }

                            else if (name == "DropOnQuit")
                            {
                                if (value == "0")
                                    ConfigProperty_DropOnQuit.Text = "Nothing";
                                else if (value == "1")
                                    ConfigProperty_DropOnQuit.Text = "Everything";
                                else if (value == "2")
                                    ConfigProperty_DropOnQuit.Text = "Toolbelt Only";
                                else if (value == "3")
                                    ConfigProperty_DropOnQuit.Text = "Backpack Only";
                            }

                            /*else if (name == "CraftTimer")
                            {
                                if (value == "0")
                                    ctime_0.Checked = true;
                                else if (value == "1")
                                    ctime_1.Checked = true;
                                else if (value == "2")
                                    ctime_2.Checked = true;
                            }
                            
                            else if (name == "LootTimer")
                            {
                                if (value == "0")
                                    ltime_0.Checked = true;
                                else if (value == "1")
                                    ltime_1.Checked = true;
                                else if (value == "2")
                                    ltime_2.Checked = true;
                            }*/

                            else if (name == "BloodMoonEnemyCount")
                            {
                                ConfigProperty_BloodMoonEnemyCount.Value = Convert.ToInt32(value);
                                BloodMoonEnemyCount_GroupBox.Text = "Zombies spawned for every player during Blood Moon [" + Convert.ToInt32(ConfigProperty_BloodMoonEnemyCount.Value) * 5 + " sec.]";
                            }

                            else if (name == "BedrollDeadZoneSize")
                            {
                                ConfigProperty_BedrollDeadZoneSize.Value = Convert.ToInt32(value);
                                BedrollDeadZoneSize_GroupBox.Text = "Minimum enemy spawn distance from bedroll [" + Convert.ToInt32(ConfigProperty_BloodMoonEnemyCount.Value) * 5 + " sec.]";
                            }

                            else if (name == "EnemySpawnMode")
                            {
                                if (value == "true")
                                    ConfigProperty_EnemySpawnMode.Checked = true;
                                else
                                    ConfigProperty_EnemySpawnMode.Checked = false;
                            }

                            else if (name == "BlockDurabilityModifier")
                            {
                                ConfigProperty_BlockDamagePlayer.Value = Convert.ToInt32(value) / 50;

                                if (ConfigProperty_BlockDamagePlayer.Value == 0)
                                    BlockDamagePlayer_GroupBox.Text = LocalizedLanguage("bdm_g") + " [25%]";
                                else
                                    BlockDamagePlayer_GroupBox.Text = LocalizedLanguage("bdm_g") + " [" + ConfigProperty_BlockDamagePlayer.Value * 50 + "%]";
                            }

                            else if (name == "DayLightLength")
                            {
                                ConfigProperty_DayLightLength.Value = Convert.ToInt32(value);
                                DayLightLength_GroupBox.Text = LocalizedLanguage("nightpercentage_g") + " [" + ConfigProperty_DayLightLength.Value + "h]";
                            }

                            else if (name == "TelnetPassword")
                                ConfigProperty_TelnetPassword.Text = value;

                            else if (name == "TelnetPort")
                                ConfigProperty_TelnetPort.Text = value;

                            else if (name == "AdminFileName")
                                ConfigProperty_AdminFileName.Text = value;

                            else if (name == "LootAbundance")
                                ConfigProperty_LootAbundance.Value = Convert.ToInt32(value);
                            else if (name == "LootRespawnDays")
                                ConfigProperty_LootRespawnDays.Value = Convert.ToInt32(value);

                            else if (name == "ServerReservedSlots")
                                ConfigProperty_ServerReservedSlots.Text = value;

                            else if (name == "ServerReservedSlotsPermission")
                                ConfigProperty_ServerReservedSlotsPermission.Text = value;

                            else if (name == "ServerAdminSlots")
                                ConfigProperty_ServerAdminSlots.Text = value;

                            else if (name == "ServerAdminSlotsPermission")
                                ConfigProperty_ServerAdminSlotsPermission.Text = value;

                            else if (name == "MaxUncoveredMapChunksPerPlayer")
                                ConfigProperty_MaxUncoveredMapChunksPerPlayer.Text = value;

                            // Set Hide Command Execution Log Dropdown To Appropriate Value
                            else if (name == "HideCommandExecutionLog")
                            {
                                if (value == "0")
                                    ConfigProperty_HideCommandExecutionLog.Text = "Show Everything";
                                else if (value == "1")
                                    ConfigProperty_HideCommandExecutionLog.Text = "Hide Only From Telnet / Control Panel";
                                else if (value == "2")
                                    ConfigProperty_HideCommandExecutionLog.Text = "Hide From Telnet / Control Panel / Remote Game Clients";
                                else if (value == "3")
                                    ConfigProperty_HideCommandExecutionLog.Text = "Hide Everything";
                            }

                            else if(name=="ServerDisabledNetworkProtocols")
                            {
                                if (value.ToLower().Contains("unet"))
                                    UNET.Checked = true;
                                if (value.ToLower().Contains("raknet"))
                                    RakNet.Checked = true;
                                if (value.ToLower().Contains("steamnetworking"))
                                    SteamNetworking.Checked = true;
                            }

                            else if (name == "LandClaimSize")
                                ConfigProperty_LandClaimSize.Text = value;

                            else if (name == "LandClaimDeadZone")
                                ConfigProperty_LandClaimDeadZone.Text = value;

                            else if (name == "LandClaimExpiryTime")
                                ConfigProperty_LandClaimExpiryTime.Text = value;

                            else if (name == "LandClaimDecayMode")
                            {
                                if (value == "0")
                                    Linear.Checked = true;
                                else if (value == "1")
                                    Exponential.Checked = true;
                                else if (value == "2")
                                    Full_prot.Checked = true;
                            }

                            else if (name == "LandClaimOnlineDurabilityModifier")
                                ConfigProperty_LandClaimOnlineDurabilityModifier.Text = value;

                            else if (name == "LandClaimOfflineDurabilityModifier")
                                ConfigProperty_LandClaimOfflineDurabilityModifier.Text = value;

                            else if (name == "SaveGameFolder")
                                ConfigProperty_SaveGameFolder.Text = value;

                            else if (name == "EnemyDifficulty")
                                if (value == "1")
                                    ConfigProperty_EnemyDifficulty.Checked = true;

                            if (name == "ServerDescription")
                                ConfigProperty_ServerDescription.Text = value;

                            if (name == "ServerWebsiteURL")
                                ConfigProperty_ServerWebsiteURL.Text = value;

                            LootAbundance_GroupBox.Text = LocalizedLanguage("LootAbundance_g") + " [" + ConfigProperty_LootAbundance.Value + "%]";

                            if (ConfigProperty_LootRespawnDays.Value == -1)
                                LootRespawnDays_GroupBox.Text = LocalizedLanguage("LootRespawnDays_g") + " [" + LocalizedLanguage("disabled") + "]";
                            else
                                LootRespawnDays_GroupBox.Text = LocalizedLanguage("LootRespawnDays_g") + " [" + ConfigProperty_LootRespawnDays.Value + "]";

                        }

                    }
                }


                xmlReader.Close();
                Echo_debug("---EOF---");
            }
            catch (Exception e)
            {
                Echo_debug("ERR READING CFG FILE: " + e);
            }
        }
    }
}
