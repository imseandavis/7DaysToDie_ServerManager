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
                if (EnemySpawnMode.Checked)
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
                if (cheatmode.Checked)
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
                if (ctrlp.Checked)
                    cpl = "true";

                // Set Player Persistant Profiles
                if (PersistentPlayerProfiles.Checked)
                    PersistentPlayerProfiles_l = "true";

                // Set EAC Mode
                if (Enable_Easy_Anti_Cheat_CheckBox.Checked)
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

                // Set Player drop On Death Mode
                if (Drop_On_Death_Mode_0.Checked)
                    dropondeathmode = "0";
                else if (Drop_On_Death_Mode_1.Checked)
                    dropondeathmode = "1";
                else if (Drop_On_Death_Mode_2.Checked)
                    dropondeathmode = "2";
                else if (Drop_On_Death_Mode_3.Checked)
                    dropondeathmode = "3";

                // Set Player Drop On Quit Mode
                if (Drop_On_Quit_Mode_0.Checked)
                    droponquitmode = "0";
                else if (Drop_On_Quit_Mode_1.Checked)
                    droponquitmode = "1";
                else if (Drop_On_Quit_Mode_2.Checked)
                    droponquitmode = "2";
                else if (Drop_On_Quit_Mode_3.Checked)
                    droponquitmode = "3";

                // Set Terminal Window Mode
                if (HideCommandExecutionLog_0.Checked)
                    hce = "0";
                else if (HideCommandExecutionLog_1.Checked)
                    hce = "1";
                else if (HideCommandExecutionLog_2.Checked)
                    hce = "2";
                else if (HideCommandExecutionLog_3.Checked)
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
                if (bdm.Value == 0)
                    bdm_t = 25;
                else
                    bdm_t = bdm.Value*50;

                // Set ????
                if (feral.Checked)
                    feral_c = "1";

                // Set ????
                string savegamefolderproperty = "";
                if (save.Text != "")
                {
                    savegamefolderproperty = "  <property name=\"SaveGameFolder\"				value=\"" + save.Text + "\"/>\r\n";
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
                    "\"/>\r\n  <property name=\"ServerMaxPlayerCount\"      	value=\"" + MaxPlayers.Value + 
                    "\"/>\r\n  \r\n  <property name=\"GameWorld\" 		        	value=\"" + ConfigProperty_GameWorld.Text + 
                    "\"/>\r\n  <property name=\"GameName\" 				    value=\"" + ConfigProperty_GameName.Text + 
                    "\"/>\r\n  <property name=\"GameDifficulty\" 		    	value=\"" + Game_Difficulty_TrackBar.Value +
                    "\"/>\r\n  <property name=\"GameMode\"				    	value=\"" + gamemode +

                    "\"/>\r\n  <property name=\"ServerReservedSlots\"				    	value=\"" + Server_Player_Reserved_Slots.Text +
                    "\"/>\r\n  <property name=\"ServerReservedSlotsPermission\"				    	value=\"" + Server_Player_Reserved_Slots_Permission.Text +
                    "\"/>\r\n  <property name=\"ServerAdminSlots\"				    	value=\"" + Server_Admin_Reserved_Slots.Text +
                    "\"/>\r\n  <property name=\"ServerAdminSlotsPermission\"				    	value=\"" + Server_Admin_Reserved_Slots_Permission.Text +

                    "\"/>\r\n  <property name=\"BloodMoonEnemyCount\"				    	value=\"" + BloodMoonEnemyCount.Value +
                    "\"/>\r\n  <property name=\"MaxUncoveredMapChunksPerPlayer\"				    	value=\"" + MaxUncoveredMapChunksPerPlayer.Text +
                    "\"/>\r\n  <property name=\"BedrollDeadZoneSize\"				    	value=\"" + BedrollDeadZoneSize.Value +
                    "\"/>\r\n  <property name=\"HideCommandExecutionLog\"				    	value=\"" + hce +
                    "\"/>\r\n  <property name=\"ServerDisabledNetworkProtocols\"				    	value=\"" + sdnp +

                    "\"/>\r\n\r\n  <property name=\"ZombiesRun\"				    value=\"" + zombierun + 
                    "\" />\r\n  <property name=\"BuildCreate\"			    	value=\"" + cheat + 
                    "\" />\r\n  <property name=\"DayNightLength\"		    	value=\"" + Realtime_get() +
                    "\" />\r\n  <property name=\"PlayerKillingMode\"			    	value=\"" + PlayerKillingMode + 
                    "\" />\r\n\r\n  <property name=\"ControlPanelEnabled\"	 	    value=\"" + cpl + 
                    "\"/>\r\n  <property name=\"ControlPanelPort\" 		    value=\"" + port_panel.Text + 
                    "\"/>\r\n  <property name=\"ControlPanelPassword\"      	value=\"" + ctrlppass.Text + 
                    "\"/>\r\n\r\n  <property name=\"TelnetEnabled\"	 	    	value=\"true\"" +
                    "/>\r\n  <property name=\"TelnetPort\" 				    value=\"" + telnet_port_p.Text +
                    "\"/>\r\n  <property name=\"AdminFileName\"			    value=\"" + Server_Admin_File_Name_TextBox.Text +
                    "\"/>\r\n\r\n  <property name=\"DropOnDeath\"			    	value=\"" + dropondeathmode + 
                    "\"/>\r\n  <property name=\"DropOnQuit\"			    	value=\"" + droponquitmode +
                    "\"/>\r\n  <property name=\"BlockDurabilityModifier\"		value=\"" + bdm_t +
                    "\"/>\r\n  <property name=\"DayLightLength\"				value=\"" + nightpercentage.Value +
                    "\"/>\r\n  <property name=\"LootAbundance\"				value=\"" + LootAbundance.Value +
                    "\"/>\r\n  <property name=\"LootRespawnDays\"				value=\"" + LootRespawnDays.Value +
                    "\"/>\r\n  <property name=\"TelnetPassword\"				value=\"" + telnet_psw.Text +
                    "\"/>\r\n  <property name=\"EnemySpawnMode\"				value=\"" + EnemySpawnMode_Selected +
                    "\"/>\r\n  <property name=\"AirDropFrequency\"		value=\"" + Air_Drop_Frequency_TrackBar.Value +
                    "\"/>\r\n  <property name=\"PersistentPlayerProfiles\"		value=\"" + PersistentPlayerProfiles_l + 
                    "\"/>\r\n\r\n\r\n\r\n  <property name=\"LandClaimSize\"				value=\"" + Land_Claim_Size_TextBox.Text +
                    "\"/>\r\n  <property name=\"LandClaimDeadZone\"				value=\"" + Land_Claim_Dead_Zone_TextBox.Text +
                    "\"/>\r\n  <property name=\"LandClaimExpiryTime\"				value=\"" + Land_Claim_Expiry_Time_TextBox.Text +
                    "\"/>\r\n  <property name=\"LandClaimDecayMode\"				value=\"" + lcdm +
                    "\"/>\r\n  <property name=\"EnemyDifficulty\"				value=\"" + feral_c +
                    "\"/>\r\n  <property name=\"EACEnabled\"				value=\"" + vac +
                    "\"/>\r\n  <property name=\"AirDropMarker\"				value=\"" + adm +
                    "\"/>\r\n\r\n\r\n\r\n  <property name=\"ServerWebsiteURL\"				value=\"" + ConfigProperty_ServerWebsiteURL.Text +
                    "\"/>\r\n  <property name=\"ServerDescription\"				value=\"" + ConfigProperty_ServerDescription.Text +
                    "\"/>\r\n  <property name=\"MaxSpawnedZombies\"				value=\"" + MaxSpawnedZombies.Value +
                    "\"/>\r\n  <property name=\"MaxSpawnedAnimals\"				value=\"" + MaxSpawnedAnimals.Value +
                    "\"/>\r\n  <property name=\"PlayerSafeZoneLevel\"				value=\"" + Player_Safe_Zone_Level_TextBox.Text +
                    "\"/>\r\n  <property name=\"PlayerSafeZoneHours\"				value=\"" + Player_Safe_Zone_Hours_TextBox.Text +
                    "\"/>\r\n  <property name=\"LandClaimOnlineDurabilityModifier\"				value=\"" + LandClaimOnlineDurabilityModifier.Text +
                    "\"/>\r\n  <property name=\"LandClaimOfflineDurabilityModifier\"				value=\"" + LandClaimOfflineDurabilityModifier.Text + "\"/>\r\n" +
                    
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
                                MaxPlayers.Value = Convert.ToInt32(value);
                            else if (name == "GameWorld")
                                ConfigProperty_GameWorld.Text = value;
                            else if (name == "GameDifficulty")
                                Game_Difficulty_TrackBar.Value = Convert.ToInt32(value);
                            //else if (name == "GameMode")
                            //{
                                //if (value == "GameModeSurvival")
                                    //gamemode_coop.Checked = true;
                                //else
                                    //gamemode_surv_pvp.Checked = true;
                               
                            //}
                            else if (name == "PersistentPlayerProfiles" && value == "true")
                                PersistentPlayerProfiles.Checked = true;



                            else if (name == "AirDropMarker" && value == "true")
                                AirDropMarker.Checked = true;
                            else if (name == "BuildCreate" && value == "true")
                                cheatmode.Checked = true;
                            else if (name == "DayNightLength")
                                dayLength.Value = Convert.ToInt32(value);
                            else if (name == "AirDropFrequency")
                                Air_Drop_Frequency_TrackBar.Value = Convert.ToInt32(value);
                            else if (name == "ControlPanelEnabled" && value == "true")
                                ctrlp.Checked = true;
                            else if (name == "ControlPanelPort")
                                port_panel.Text = value;
                            else if (name == "ControlPanelPassword")
                                ctrlppass.Text = value;
                            else if (name == "PlayerSafeZoneLevel")
                                Player_Safe_Zone_Level_TextBox.Text = value;
                            else if (name == "PlayerSafeZoneHours")
                                Player_Safe_Zone_Hours_TextBox.Text = value;
                            else if (name == "EACEnabled" && value == "false")
                                Enable_Easy_Anti_Cheat_CheckBox.Checked = false;
                            else if (name == "MaxSpawnedZombies")
                                MaxSpawnedZombies.Value = Convert.ToInt32(value);
                            else if (name == "MaxSpawnedAnimals")
                                MaxSpawnedAnimals.Value = Convert.ToInt32(value);

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
                                    Drop_On_Death_Mode_0.Checked = true;
                                else if (value == "1")
                                    Drop_On_Death_Mode_1.Checked = true;
                                else if (value == "2")
                                    Drop_On_Death_Mode_2.Checked = true;
                                else if (value == "3")
                                    Drop_On_Death_Mode_3.Checked = true;
                            }

                            else if (name == "DropOnQuit")
                            {
                                if (value == "0")
                                    Drop_On_Quit_Mode_0.Checked = true;
                                else if (value == "1")
                                    Drop_On_Quit_Mode_1.Checked = true;
                                else if (value == "2")
                                    Drop_On_Quit_Mode_2.Checked = true;
                                else if (value == "3")
                                    Drop_On_Quit_Mode_3.Checked = true;
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
                                BloodMoonEnemyCount.Value = Convert.ToInt32(value);
                                BloodMoonEnemyCount_g.Text = "Zombies spawned for every player during Blood Moon [" + Convert.ToInt32(BloodMoonEnemyCount.Value) * 5 + " sec.]";
                            }

                            else if (name == "BedrollDeadZoneSize")
                            {
                                BedrollDeadZoneSize.Value = Convert.ToInt32(value);
                                BedrollDeadZoneSize_g.Text = "Minimum enemy spawn distance from bedroll [" + Convert.ToInt32(BloodMoonEnemyCount.Value) * 5 + " sec.]";
                            }

                            else if (name == "EnemySpawnMode")
                            {
                                if (value == "true")
                                    EnemySpawnMode.Checked = true;
                                else
                                    EnemySpawnMode.Checked = false;
                            }

                            else if (name == "BlockDurabilityModifier")
                            {
                                bdm.Value = Convert.ToInt32(value) / 50;

                                if (bdm.Value == 0)
                                    bdm_g.Text = LocalizedLanguage("bdm_g") + " [25%]";
                                else
                                    bdm_g.Text = LocalizedLanguage("bdm_g") + " [" + bdm.Value * 50 + "%]";
                            }

                            else if (name == "DayLightLength")
                            {
                                nightpercentage.Value = Convert.ToInt32(value);
                                nightpercentage_g.Text = LocalizedLanguage("nightpercentage_g") + " [" + nightpercentage.Value + "h]";
                            }

                            else if (name == "TelnetPassword")
                                telnet_psw.Text = value;

                            else if (name == "TelnetPort")
                                telnet_port_p.Text = value;

                            else if (name == "AdminFileName")
                                Server_Admin_File_Name_TextBox.Text = value;

                            else if (name == "LootAbundance")
                                LootAbundance.Value = Convert.ToInt32(value);
                            else if (name == "LootRespawnDays")
                                LootRespawnDays.Value = Convert.ToInt32(value);

                            else if (name == "ServerReservedSlots")
                                Server_Player_Reserved_Slots.Text = value;

                            else if (name == "ServerReservedSlotsPermission")
                                Server_Player_Reserved_Slots_Permission.Text = value;

                            else if (name == "ServerAdminSlots")
                                Server_Admin_Reserved_Slots.Text = value;

                            else if (name == "ServerAdminSlotsPermission")
                                Server_Admin_Reserved_Slots_Permission.Text = value;

                            else if (name == "MaxUncoveredMapChunksPerPlayer")
                                MaxUncoveredMapChunksPerPlayer.Text = value;

                            else if (name == "HideCommandExecutionLog")
                            {
                                if (value == "0")
                                    HideCommandExecutionLog_0.Checked = true;
                                else if (value == "1")
                                    HideCommandExecutionLog_1.Checked = true;
                                else if (value == "2")
                                    HideCommandExecutionLog_2.Checked = true;
                                else if (value == "3")
                                    HideCommandExecutionLog_3.Checked = true;
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
                                Land_Claim_Size_TextBox.Text = value;

                            else if (name == "LandClaimDeadZone")
                                Land_Claim_Dead_Zone_TextBox.Text = value;

                            else if (name == "LandClaimExpiryTime")
                                Land_Claim_Expiry_Time_TextBox.Text = value;

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
                                LandClaimOnlineDurabilityModifier.Text = value;

                            else if (name == "LandClaimOfflineDurabilityModifier")
                                LandClaimOfflineDurabilityModifier.Text = value;

                            else if (name == "SaveGameFolder")
                                save.Text = value;

                            else if (name == "EnemyDifficulty")
                                if (value == "1")
                                    feral.Checked = true;

                            if (name == "ServerDescription")
                                ConfigProperty_ServerDescription.Text = value;

                            if (name == "ServerWebsiteURL")
                                ConfigProperty_ServerWebsiteURL.Text = value;

                            Loot_Abundance_GroupBox.Text = LocalizedLanguage("LootAbundance_g") + " [" + LootAbundance.Value + "%]";

                            if (LootRespawnDays.Value == -1)
                                Loot_Respawn_Days_GroupBox.Text = LocalizedLanguage("LootRespawnDays_g") + " [" + LocalizedLanguage("disabled") + "]";
                            else
                                Loot_Respawn_Days_GroupBox.Text = LocalizedLanguage("LootRespawnDays_g") + " [" + LootRespawnDays.Value + "]";

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
