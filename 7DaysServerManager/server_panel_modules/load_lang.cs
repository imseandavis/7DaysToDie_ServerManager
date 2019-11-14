using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7DaysServerManager
{

    public partial class server_panel : Form
    {


        public void load_lang()
        {
            about.Text = lang("about");
            always_on_top.Text = lang("always_on_top");
            autobots.Text = lang("autobots");
            ban.Text = lang("ban");
            blad.Text = lang("blad");
            cheatmode.Text = lang("cheatmode");
            chpath.Text = lang("chpath");
            cpl_pass.Text = lang("cpl_pass");
            cpl_port.Text = lang("cpl_port");
            ctrlp.Text = lang("ctrlp");
            ctrlpanel.Text = lang("ctrlpanel");
            dostep.Text = lang("dostep");
            dzien.Text = lang("dzien") + " [1]";

            gamemode_coop.Text = lang("gamemode_coop");

            godzina.Text = lang("godzina") + " [8:00]";
            kick.Text = lang("kick");
            kickgroup.Text = lang("kickgroup");
            kill_proccess.Text = lang("kill_proccess");
            kons_group.Text = lang("kons_group");
            kontrola.Text = lang("kontrola");

            maxplgroup.Text = lang("maxplgroup");
            nazwamapa.Text = lang("nazwamapa");
            odery.Text = lang("odery");
            port_g.Text = lang("port_g");
            save_logfiles.Text = lang("save_logfiles");
            save_logfiles_2.Text = lang("save_logfiles_2");
            ServerIsPublic.Text = lang("ServerIsPublic");

            spawn_group.Text = lang("spawn_group");
            spawn_now.Text = lang("spawn_now");

            start.Text = lang("start");
            steamsearch.Text = lang("steamsearch");
            stop.Text = lang("stop");
            telnet_group.Text = lang("telnet_group");
            to_tray.Text = lang("to_tray");
            trudnoscgroup.Text = lang("trudnoscgroup");
            trybgry.Text = lang("trybgry");
            ustawienia_grupa_ustawienia.Text = lang("ustawienia_grupa_ustawienia");
            workerynapis.Text = lang("workerynapis");
            zomb_pie.Text = lang("zomb_pie");
            zombie_never_run.Text = lang("zombie_never_run");
            zombie_normal.Text = lang("zombie_normal");
            zombie_run.Text = lang("zombie_run");
            PersistentPlayerProfiles.Text = lang("PersistentPlayerProfiles");
            

            telnet_connect.Text = lang("telnet_connect");
            spaminfo.Text = lang("spaminfo");
            spam_time_g.Text = lang("spam_time");
            show_ip.Text = lang("show_ip");
            powod.Text = lang("powod");
            cleanexit.Text = lang("cleanexit");
            anon_data.Text = lang("anon_data");
            anon_data_2.Text = lang("anon_data_2");
            sql_enabled.Text = lang("sql_enabled");
            sql_host_g.Text = lang("sql_host_g");
            sql_username_g.Text = lang("sql_username_g");
            sql_password_g.Text = lang("sql_password_g");
            sql_db_name_g.Text = lang("sql_db_name_g");
            sql_warn.Text = lang("sql_warn");
            upd_time.Text = lang("upd_time");
            sql_updates_time_g.Text = lang("sql_updates_time_g");
            timers_g.Text = lang("timers_g");
            auto_messages_label.Text = lang("auto_messages_label");
            sql_exporter_label.Text = lang("sql_export_label");

            backup_timer_label.Text = lang("backup_timer_label");
            auto_backup_check.Text = lang("auto_backup_check");
            backup_chat.Text = lang("backup_chat");
            feral.Text = lang("feral");


            LandClaim.Text = lang("LandClaim");
            LandClaimDecayMode_g.Text = lang("LandClaimDecayMode_g");
            Linear.Text = lang("Linear");
            Exponential.Text = lang("Exponential");
            Full_prot.Text = lang("Full_prot");
            LandClaim_g.Text = lang("LandClaim_g");
            online.Text = lang("online");
            offline.Text = lang("offline");
            LandClaimDeadZone_g.Text = lang("LandClaimDeadZone_g");
            LandClaimSize_g.Text = lang("LandClaimSize_g");
            LandClaimExpiryTime_g.Text = lang("LandClaimExpiryTime_g");


            dod_g.Text = lang("dod_g");
            dod_0.Text = lang("dod_0");
            dod_1.Text = lang("dod_1");
            dod_2.Text = lang("dod_2");
            dod_3.Text = lang("dod_3");
            doq_0.Text = lang("doq_0");
            doq_1.Text = lang("doq_1");
            doq_2.Text = lang("doq_2");
            doq_3.Text = lang("doq_3");










            realtime.Text = lang("realtime");


            reboot_con.Text = lang("reboot_con");


            VACEnabled.Text = lang("VACEnabled");

            chat_g.Text = lang("chat_g");
            
            telnet_g.Text = lang("telnet_g");
            filename_g.Text = lang("filename_g");
            telnet_port_l.Text = lang("cpl_port");
            telnet_psw_l.Text = lang("cpl_pass");

            sa_edit.Text = lang("sa_edit");
            browse.Text = lang("browse");

            bantime_slider.Text = lang("bantime_slider") + " [" + Convert.ToString(ban_slide.Value) + "]";

            spam_g.Text = lang("spam_g");

            reset_timer_label.Text = lang("reset_timer_label");
            reset_g.Text = lang("reset_g") + " [" + Convert.ToString(reset_time.Value) + ":00]";
            reset_chat.Text = lang("reset_chat");
            reset_enabled.Text = lang("reset_enabled");

            save_g.Text = lang("save_g");
            spam_is_spam.Text = lang("spam_is_spam");

            if (AirDropFrequency.Value != 0)
                AirDropFrequency_g.Text = lang("AirDropFrequency") + " [" + Convert.ToString(AirDropFrequency.Value) + " h.]";
            else
                AirDropFrequency_g.Text = lang("AirDropFrequency") + " [" + lang("disabled") + "]";


            MaxSpawnedZombies_g.Text = lang("MaxSpawnedZombies_g") + " [" + Convert.ToString(MaxSpawnedZombies.Value) + "]";
            MaxSpawnedAnimals_g.Text = lang("MaxSpawnedAnimals_g") + " [" + Convert.ToString(MaxSpawnedAnimals.Value) + "]";





            backup_msg_1_l.Text = lang("backup_msg_1_l");
            backup_msg_2_l.Text = lang("backup_msg_2_l");
            reboot_l.Text = lang("reboot_l");
            reboot_time_l.Text = lang("reboot_time_l");
            messages_g.Text = lang("messages_g");
            customcommands_g.Text = lang("customcommands_g");
            how_to_commands.Text = lang("how_to_commands");
            enable_cc.Text = lang("enable_cc");
            cmd_not_yet_l.Text = lang("cmd_not_yet_l");
            configfile_g.Text = lang("configfile_g");
            configfile_e.Text = lang("sa_edit");

            ServerWebsiteURL_g.Text = lang("ServerWebsiteURL_g");
            ServerDescription_g.Text = lang("ServerDescription_g");
        }


    }
}
