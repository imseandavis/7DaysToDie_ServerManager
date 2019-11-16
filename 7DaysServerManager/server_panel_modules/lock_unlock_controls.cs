using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7DaysServerManager
{

    public partial class server_panel : Form
    {


        public void lock_ctrl()
        {
            echo_debug("---locking ctrl---");

            Start_Server_Button.Enabled = false;
            Shutdown_Server_Button.Enabled = true;


            PlayerKillingMode_g.Enabled = false;
            AirDropMarker.Enabled = false;
            maxpl.Enabled = false;
            trudnosc.Enabled = false;
            if (!realtime.Checked)
                dlugoscdnia.Enabled = false;

            ctrlp.Enabled = false;
            ctrlppass.Enabled = false;
            port_panel.Enabled = false;
            zombie_normal.Enabled = false;
            zombie_run.Enabled = false;
            zombie_never_run.Enabled = false;
            ServerIsPublic.Enabled = false;
            ServerPassword.Enabled = false;
            nazwa.Enabled = false;
            mapa.Enabled = false;
            port.Enabled = false;
            gamemode_coop.Enabled = false;

            cheatmode.Enabled = false;
            port.Enabled = false;
            server_nazwa.Enabled = false;

            sql_enabled.Enabled = false;
            sql_host.Enabled = false;
            sql_username.Enabled = false;
            sql_password.Enabled = false;
            sql_db_name.Enabled = false;
            sql_updates_time.Enabled = false;


            if (auto_backup_check.Checked)
                backup_time.Enabled = false;
            auto_backup_check.Enabled = false;

            dod_0.Enabled = false;
            dod_1.Enabled = false;
            dod_2.Enabled = false;
            dod_3.Enabled = false;
            doq_0.Enabled = false;
            doq_1.Enabled = false;
            doq_2.Enabled = false;
            doq_3.Enabled = false;


            EnemySpawnMode.Enabled = false;
            realtime.Enabled = false;

            nightpercentage.Enabled = false;
            bdm.Enabled = false;

            AdminFileName.Enabled = false;
            telnet_port_p.Enabled = false;
            telnet_psw.Enabled = false;
            LootAbundance.Enabled = false;
            LootRespawnDays.Enabled = false;

            LandClaim.Enabled = false;
            Linear.Enabled = false;
            Exponential.Enabled = false;
            Full_prot.Enabled = false;
            LandClaim.Enabled = false;
            online.Enabled = false;
            offline.Enabled = false;
            LandClaimDeadZone.Enabled = false;
            LandClaimSize.Enabled = false;
            LandClaimExpiryTime.Enabled = false;
            gamemode_surv_pvp.Enabled = false;
            feral.Enabled = false;
            AirDropFrequency.Enabled = false;
            VACEnabled.Enabled = false;
            MaxSpawnedZombies.Enabled = false;
            save.Enabled = false;

            PersistentPlayerProfiles.Enabled = false;
            configfile.Enabled = false;
            MaxSpawnedZombies.Enabled = false;
            ServerDescription.Enabled = false;
            ServerWebsiteURL.Enabled = false;

            reset_g.Enabled = false;
            whitelist_dl_g.Enabled = false;
            PlayerSafeZoneLevel.Enabled = false;
            PlayerSafeZoneHours.Enabled = false;
            MaxSpawnedAnimals.Enabled = false;

        }

        public void unlock_ctrl()
        {

            Start_Server_Button.Enabled = true;
            Shutdown_Server_Button.Enabled = false;


            PlayerKillingMode_g.Enabled = true;
            AirDropMarker.Enabled = true;
            maxpl.Enabled = true;
            trudnosc.Enabled = true;
            if (!realtime.Checked)
                dlugoscdnia.Enabled = true;
            ctrlp.Enabled = true;
            ctrlppass.Enabled = true;
            port_panel.Enabled = true;
            zombie_normal.Enabled = true;
            zombie_run.Enabled = true;
            zombie_never_run.Enabled = true;
            ServerIsPublic.Enabled = true;
            ServerPassword.Enabled = true;
            nazwa.Enabled = true;
            mapa.Enabled = true;
            port.Enabled = true;
            gamemode_coop.Enabled = true;
            cheatmode.Enabled = true;
            port.Enabled = true;
            server_nazwa.Enabled = true;

            sql_enabled.Enabled = true;
            sql_host.Enabled = true;
            sql_username.Enabled = true;
            sql_password.Enabled = true;
            sql_db_name.Enabled = true;
            sql_updates_time.Enabled = true;




            if (auto_backup_check.Checked)
                backup_time.Enabled = true;
            auto_backup_check.Enabled = true;

            dod_0.Enabled = true;
            dod_1.Enabled = true;
            dod_2.Enabled = true;
            dod_3.Enabled = true;
            doq_0.Enabled = true;
            doq_1.Enabled = true;
            doq_2.Enabled = true;
            doq_3.Enabled = true;


            EnemySpawnMode.Enabled = true;
            realtime.Enabled = true;

            nightpercentage.Enabled = true;
            bdm.Enabled = true;

            AdminFileName.Enabled = true;
            telnet_port_p.Enabled = true;
            telnet_psw.Enabled = true;
            LootAbundance.Enabled = true;
            LootRespawnDays.Enabled = true;

            LandClaim.Enabled = true;
            Linear.Enabled = true;
            Exponential.Enabled = true;
            Full_prot.Enabled = true;
            LandClaim.Enabled = true;
            online.Enabled = true;
            offline.Enabled = true;
            LandClaimDeadZone.Enabled = true;
            LandClaimSize.Enabled = true;
            LandClaimExpiryTime.Enabled = true;
            gamemode_surv_pvp.Enabled = true;
            feral.Enabled = true;
            AirDropFrequency.Enabled = true;
            VACEnabled.Enabled = true;
            MaxSpawnedZombies.Enabled = true;
            save.Enabled = true;

            PersistentPlayerProfiles.Enabled = true;
            configfile.Enabled = true;
            MaxSpawnedZombies.Enabled = true;
            ServerDescription.Enabled = true;
            ServerWebsiteURL.Enabled = true;

            reset_g.Enabled = true;
            whitelist_dl_g.Enabled = true;
            PlayerSafeZoneLevel.Enabled = true;
            PlayerSafeZoneHours.Enabled = true;
            MaxSpawnedAnimals.Enabled = true;

        }


    }
}
