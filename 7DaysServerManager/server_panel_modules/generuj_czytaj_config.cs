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

    public partial class server_panel : Form
    {

        public void generuj_config(object sender, EventArgs e)
        {
            generuj_config();
        }


        public void generuj_config()
        {
            if (twoje_ip.Text != "Checking IP...") //żeby się nie wpierniczał podczas ładowania konfiguracji z pliku. Label jest zmieniany po załadowaniu konfiguracji.
            {
                echo_debug("---saving config---");
                string gejmod = "GameModeSurvivalMP", serverpublic = "false", cheat = "false", cpl = "false", zombirun = "0", dod = "0", doq = "0", feral_c = "0", vac = "false", PersistentPlayerProfiles_l = "false", PlayerKillingMode = "0", adm = "false", hce = "0", sdnp = "", EnemySpawnMode_Selected="false";

                if (gamemode_coop.Checked)
                    gejmod = "GameModeSurvivalSP";
                else if (gamemode_surv_pvp.Checked)
                    gejmod = "GameModeSurvivalMP";

                if (EnemySpawnMode.Checked)
                    EnemySpawnMode_Selected = "true";
                else
                    EnemySpawnMode_Selected = "false";

                if (zombie_never_run.Checked)
                    zombirun = "1";
                else if (zombie_run.Checked)
                    zombirun = "2";

                if (ServerIsPublic.Checked)
                    serverpublic = "true";



                if (cheatmode.Checked)
                    cheat = "true";



                if (UNET.Checked)
                    sdnp += "unet,";
                if (RakNet.Checked)
                    sdnp += "raknet,";
                if (SteamNetworking.Checked)
                    sdnp += "steamnetworking";

                if(sdnp.EndsWith(","))
                    sdnp = sdnp.Substring(0, sdnp.Length - 1);



                if (ctrlp.Checked)
                    cpl = "true";

                if (PersistentPlayerProfiles.Checked)
                    PersistentPlayerProfiles_l = "true";



                if (VACEnabled.Checked)
                    vac = "true";

                if (AirDropMarker.Checked)
                    adm = "true";


                if (PlayerKillingMode_0.Checked)
                    PlayerKillingMode = "0";
                else if (PlayerKillingMode_1.Checked)
                    PlayerKillingMode = "1";
                else if (PlayerKillingMode_2.Checked)
                    PlayerKillingMode = "2";
                else if (PlayerKillingMode_3.Checked)
                    PlayerKillingMode = "3";


                if (dod_0.Checked)
                    dod = "0";
                else if (dod_1.Checked)
                    dod = "1";
                else if (dod_2.Checked)
                    dod = "2";
                else if (dod_3.Checked)
                    dod = "3";

                if (doq_0.Checked)
                    doq = "0";
                else if (doq_1.Checked)
                    doq = "1";
                else if (doq_2.Checked)
                    doq = "2";
                else if (doq_3.Checked)
                    doq = "3";


                if (HideCommandExecutionLog_0.Checked)
                    hce = "0";
                else if (HideCommandExecutionLog_1.Checked)
                    hce = "1";
                else if (HideCommandExecutionLog_2.Checked)
                    hce = "2";
                else if (HideCommandExecutionLog_3.Checked)
                    hce = "3";


                string lcdm="0";
                if (Linear.Checked)
                    lcdm = "0";
                else if (Exponential.Checked)
                    lcdm = "1";
                else if (Full_prot.Checked)
                    lcdm = "2";

                int bdm_t = 0;
                if (bdm.Value == 0)
                    bdm_t = 25;
                else
                    bdm_t = bdm.Value*50;


                if (feral.Checked)
                    feral_c = "1";


                string sejw = "";
                if (save.Text != "")
                {
                    sejw = "  <property name=\"SaveGameFolder\"				value=\"" + save.Text + "\"/>\r\n";
                }

                string konfig = "<?xml version=\"1.0\"?>\r\n<ServerSettings>\r\n  " +
                    "<property name=\"ServerPort\" 			        value=\"" + port.Text +
                    "\"/>\r\n  <property name=\"ServerIsPublic\" 		    	value=\"" + serverpublic + 
                    "\"/>\r\n  <property name=\"ServerName\" 				    value=\"" + server_nazwa.Text + 
                    "\"/>\r\n  <property name=\"ServerPassword\" 		    	value=\"" + ServerPassword.Text + 
                    "\"/>\r\n  <property name=\"ServerMaxPlayerCount\"      	value=\"" + maxpl.Value + 
                    "\"/>\r\n  \r\n  <property name=\"GameWorld\" 		        	value=\"" + mapa.Text + 
                    "\"/>\r\n  <property name=\"GameName\" 				    value=\"" + nazwa.Text + 
                    "\"/>\r\n  <property name=\"GameDifficulty\" 		    	value=\"" + trudnosc.Value +
                    "\"/>\r\n  <property name=\"GameMode\"				    	value=\"" + gejmod +

                    "\"/>\r\n  <property name=\"ServerReservedSlots\"				    	value=\"" + ServerReservedSlots.Text +
                    "\"/>\r\n  <property name=\"ServerReservedSlotsPermission\"				    	value=\"" + ServerReservedSlotsPermission.Text +
                    "\"/>\r\n  <property name=\"ServerAdminSlots\"				    	value=\"" + ServerAdminSlots.Text +
                    "\"/>\r\n  <property name=\"ServerAdminSlotsPermission\"				    	value=\"" + ServerAdminSlotsPermission.Text +



                    "\"/>\r\n  <property name=\"BloodMoonEnemyCount\"				    	value=\"" + BloodMoonEnemyCount.Value +
                    "\"/>\r\n  <property name=\"MaxUncoveredMapChunksPerPlayer\"				    	value=\"" + MaxUncoveredMapChunksPerPlayer.Text +
                    "\"/>\r\n  <property name=\"BedrollDeadZoneSize\"				    	value=\"" + BedrollDeadZoneSize.Value +
                    "\"/>\r\n  <property name=\"HideCommandExecutionLog\"				    	value=\"" + hce +
                    "\"/>\r\n  <property name=\"ServerDisabledNetworkProtocols\"				    	value=\"" + sdnp +



                    "\"/>\r\n\r\n  <property name=\"ZombiesRun\"				    value=\"" + zombirun + 
                    "\" />\r\n  <property name=\"BuildCreate\"			    	value=\"" + cheat + 
                    "\" />\r\n  <property name=\"DayNightLength\"		    	value=\"" + realtime_get() +
                    "\" />\r\n  <property name=\"PlayerKillingMode\"			    	value=\"" + PlayerKillingMode + 
                    "\" />\r\n\r\n  <property name=\"ControlPanelEnabled\"	 	    value=\"" + cpl + 
                    "\"/>\r\n  <property name=\"ControlPanelPort\" 		    value=\"" + port_panel.Text + 
                    "\"/>\r\n  <property name=\"ControlPanelPassword\"      	value=\"" + ctrlppass.Text + 
                    "\"/>\r\n\r\n  <property name=\"TelnetEnabled\"	 	    	value=\"true\"" +
                    "/>\r\n  <property name=\"TelnetPort\" 				    value=\"" + telnet_port_p.Text +
                    "\"/>\r\n  <property name=\"AdminFileName\"			    value=\"" + AdminFileName.Text +
                    "\"/>\r\n\r\n  <property name=\"DropOnDeath\"			    	value=\"" + dod + 
                    "\"/>\r\n  <property name=\"DropOnQuit\"			    	value=\"" + doq +
                    "\"/>\r\n  <property name=\"BlockDurabilityModifier\"		value=\"" + bdm_t +
                    "\"/>\r\n  <property name=\"DayLightLength\"				value=\"" + nightpercentage.Value +
                    "\"/>\r\n  <property name=\"LootAbundance\"				value=\"" + LootAbundance.Value +
                    "\"/>\r\n  <property name=\"LootRespawnDays\"				value=\"" + LootRespawnDays.Value +
                    "\"/>\r\n  <property name=\"TelnetPassword\"				value=\"" + telnet_psw.Text +
                    "\"/>\r\n  <property name=\"EnemySpawnMode\"				value=\"" + EnemySpawnMode_Selected +
                    "\"/>\r\n  <property name=\"AirDropFrequency\"		value=\"" + AirDropFrequency.Value +
                    "\"/>\r\n  <property name=\"PersistentPlayerProfiles\"		value=\"" + PersistentPlayerProfiles_l + 
                    "\"/>\r\n\r\n\r\n\r\n  <property name=\"LandClaimSize\"				value=\"" + LandClaimSize.Text +
                    "\"/>\r\n  <property name=\"LandClaimDeadZone\"				value=\"" + LandClaimDeadZone.Text +
                    "\"/>\r\n  <property name=\"LandClaimExpiryTime\"				value=\"" + LandClaimExpiryTime.Text +
                    "\"/>\r\n  <property name=\"LandClaimDecayMode\"				value=\"" + lcdm +
                    "\"/>\r\n  <property name=\"EnemyDifficulty\"				value=\"" + feral_c +
                    "\"/>\r\n  <property name=\"EACEnabled\"				value=\"" + vac +
                    "\"/>\r\n  <property name=\"AirDropMarker\"				value=\"" + adm +
                    "\"/>\r\n\r\n\r\n\r\n  <property name=\"ServerWebsiteURL\"				value=\"" + ServerWebsiteURL.Text +
                    "\"/>\r\n  <property name=\"ServerDescription\"				value=\"" + ServerDescription.Text +
                    "\"/>\r\n  <property name=\"MaxSpawnedZombies\"				value=\"" + MaxSpawnedZombies.Value +
                    "\"/>\r\n  <property name=\"MaxSpawnedAnimals\"				value=\"" + MaxSpawnedAnimals.Value +
                    "\"/>\r\n  <property name=\"PlayerSafeZoneLevel\"				value=\"" + PlayerSafeZoneLevel.Text +
                    "\"/>\r\n  <property name=\"PlayerSafeZoneHours\"				value=\"" + PlayerSafeZoneHours.Text +
                    "\"/>\r\n  <property name=\"LandClaimOnlineDurabilityModifier\"				value=\"" + LandClaimOnlineDurabilityModifier.Text +
                    "\"/>\r\n  <property name=\"LandClaimOfflineDurabilityModifier\"				value=\"" + LandClaimOfflineDurabilityModifier.Text + "\"/>\r\n" +
                    sejw +
                    "</ServerSettings>";
                try
                {
                    StreamWriter str = new StreamWriter((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "game_path", null) + "\\serverconfig.xml");

                    str.WriteLine(konfig);
                    str.Close();
                }
                catch
                {
                    echo_debug("---ERR: File access error---");
                    System.Threading.Thread.Sleep(100);
                }
            }
        }




















        public void czytaj_config()
        {
            echo_debug("---Reading game config---");



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
                                port.Text = value;
                            else if (name == "ServerIsPublic" && value == "true")
                                ServerIsPublic.Checked = true;
                            else if (name == "GameName")
                                nazwa.Text = value;
                            else if (name == "ServerName")
                                server_nazwa.Text = value;
                            else if (name == "ServerPassword")
                                ServerPassword.Text = value;
                            else if (name == "ServerMaxPlayerCount")
                                maxpl.Value = Convert.ToInt32(value);
                            else if (name == "GameWorld")
                                mapa.Text = value;
                            else if (name == "GameDifficulty")
                                trudnosc.Value = Convert.ToInt32(value);
                            else if (name == "GameMode")
                            {
                                if (value == "GameModeSurvival")
                                    gamemode_coop.Checked = true;
                                else
                                    gamemode_surv_pvp.Checked = true;
                               
                            }
                            else if (name == "PersistentPlayerProfiles" && value == "true")
                                PersistentPlayerProfiles.Checked = true;



                            else if (name == "AirDropMarker" && value == "true")
                                AirDropMarker.Checked = true;
                            else if (name == "BuildCreate" && value == "true")
                                cheatmode.Checked = true;
                            else if (name == "DayNightLength")
                                dlugoscdnia.Value = Convert.ToInt32(value);
                            else if (name == "AirDropFrequency")
                                AirDropFrequency.Value = Convert.ToInt32(value);
                            else if (name == "ControlPanelEnabled" && value == "true")
                                ctrlp.Checked = true;
                            else if (name == "ControlPanelPort")
                                port_panel.Text = value;
                            else if (name == "ControlPanelPassword")
                                ctrlppass.Text = value;
                            else if (name == "PlayerSafeZoneLevel")
                                PlayerSafeZoneLevel.Text = value;
                            else if (name == "PlayerSafeZoneHours")
                                PlayerSafeZoneHours.Text = value;
                            else if (name == "EACEnabled" && value == "false")
                                VACEnabled.Checked = false;
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
                                    PlayerKillingMode_0.Checked = true;
                                else if (value == "1")
                                    PlayerKillingMode_1.Checked = true;
                                else if (value == "2")
                                    PlayerKillingMode_2.Checked = true;
                                else if (value == "3")
                                    PlayerKillingMode_3.Checked = true;
                            }

                            else if (name == "DropOnDeath")
                            {
                                if (value == "0")
                                    dod_0.Checked = true;
                                else if (value == "1")
                                    dod_1.Checked = true;
                                else if (value == "2")
                                    dod_2.Checked = true;
                                else if (value == "3")
                                    dod_3.Checked = true;
                            }
                            else if (name == "DropOnQuit")
                            {
                                if (value == "0")
                                    doq_0.Checked = true;
                                else if (value == "1")
                                    doq_1.Checked = true;
                                else if (value == "2")
                                    doq_2.Checked = true;
                                else if (value == "3")
                                    doq_3.Checked = true;
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
                                    bdm_g.Text = lang("bdm_g") + " [25%]";
                                else
                                    bdm_g.Text = lang("bdm_g") + " [" + bdm.Value * 50 + "%]";
                            }
                            else if (name == "DayLightLength")
                            {
                                nightpercentage.Value = Convert.ToInt32(value);
                                nightpercentage_g.Text = lang("nightpercentage_g") + " [" + nightpercentage.Value + "h]";
                            }
                            else if (name == "TelnetPassword")
                                telnet_psw.Text = value;
                            else if (name == "TelnetPort")
                                telnet_port_p.Text = value;
                            else if (name == "AdminFileName")
                                AdminFileName.Text = value;

                            else if (name == "LootAbundance")
                                LootAbundance.Value = Convert.ToInt32(value);
                            else if (name == "LootRespawnDays")
                                LootRespawnDays.Value = Convert.ToInt32(value);



                            else if (name == "ServerReservedSlots")
                                ServerReservedSlots.Text = value;
                            else if (name == "ServerReservedSlotsPermission")
                                ServerReservedSlotsPermission.Text = value;
                            else if (name == "ServerAdminSlots")
                                ServerAdminSlots.Text = value;
                            else if (name == "ServerAdminSlotsPermission")
                                ServerAdminSlotsPermission.Text = value;
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
                                LandClaimSize.Text = value;
                            else if (name == "LandClaimDeadZone")
                                LandClaimDeadZone.Text = value;
                            else if (name == "LandClaimExpiryTime")
                                LandClaimExpiryTime.Text = value;
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
                                ServerDescription.Text = value;
                            if (name == "ServerWebsiteURL")
                                ServerWebsiteURL.Text = value;




                            LootAbundance_g.Text = lang("LootAbundance_g") + " [" + LootAbundance.Value + "%]";




                            if (LootRespawnDays.Value == -1)
                                LootRespawnDays_g.Text = lang("LootRespawnDays_g") + " [" + lang("disabled") + "]";
                            else
                                LootRespawnDays_g.Text = lang("LootRespawnDays_g") + " [" + LootRespawnDays.Value + "]";




                        }

                    }
                }


                xmlReader.Close();
                echo_debug("---EOF---");
            }
            catch (Exception e)
            {
                echo_debug("ERR READING CFG FILE: " + e);
            }
        }
    }
}
