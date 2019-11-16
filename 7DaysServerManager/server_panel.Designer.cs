namespace _7DaysServerManager
{
    partial class server_panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(server_panel));
            this.status_updater = new System.ComponentModel.BackgroundWorker();
            this.select_dir = new System.Windows.Forms.FolderBrowserDialog();
            this.ikona = new System.Windows.Forms.NotifyIcon(this.components);
            this.twoje_ip = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.TabPage();
            this.dsm_updates_g = new System.Windows.Forms.GroupBox();
            this.apply_update_channel = new System.Windows.Forms.Button();
            this.force_upd = new System.Windows.Forms.Button();
            this.chk_upd = new System.Windows.Forms.Button();
            this.updates_info = new System.Windows.Forms.Label();
            this.updates_channel_l = new System.Windows.Forms.Label();
            this.updates_channel = new System.Windows.Forms.ComboBox();
            this.exe_settings_g = new System.Windows.Forms.GroupBox();
            this.exe_name_l = new System.Windows.Forms.Label();
            this.exe_name = new System.Windows.Forms.TextBox();
            this.prem_set = new System.Windows.Forms.GroupBox();
            this.prem_help1 = new System.Windows.Forms.PictureBox();
            this.hide_don_btn = new System.Windows.Forms.CheckBox();
            this.prem_g = new System.Windows.Forms.GroupBox();
            this.prem_show = new System.Windows.Forms.CheckBox();
            this.dondon2 = new System.Windows.Forms.Button();
            this.prem_info_2 = new System.Windows.Forms.Label();
            this.prem_info = new System.Windows.Forms.Label();
            this.prem_act = new System.Windows.Forms.Button();
            this.prem_psw_l = new System.Windows.Forms.Label();
            this.prem_psw = new System.Windows.Forms.TextBox();
            this.debug_log = new System.Windows.Forms.CheckBox();
            this.sql = new System.Windows.Forms.GroupBox();
            this.sql_enabled = new System.Windows.Forms.CheckBox();
            this.sql_updates_time_g = new System.Windows.Forms.GroupBox();
            this.sql_updates_time = new System.Windows.Forms.TextBox();
            this.upd_time = new System.Windows.Forms.Label();
            this.sql_host_g = new System.Windows.Forms.GroupBox();
            this.sql_host = new System.Windows.Forms.TextBox();
            this.how_to_sql = new System.Windows.Forms.Button();
            this.sql_username_g = new System.Windows.Forms.GroupBox();
            this.sql_username = new System.Windows.Forms.TextBox();
            this.sql_db_name_g = new System.Windows.Forms.GroupBox();
            this.sql_db_name = new System.Windows.Forms.TextBox();
            this.sql_password_g = new System.Windows.Forms.GroupBox();
            this.sql_warn = new System.Windows.Forms.Label();
            this.sql_password = new System.Windows.Forms.TextBox();
            this.blad = new System.Windows.Forms.Button();
            this.workerynapis = new System.Windows.Forms.Label();
            this.taskman = new System.Windows.Forms.ListBox();
            this.ustawienia_grupa_ustawienia = new System.Windows.Forms.GroupBox();
            this.skip_profiles = new System.Windows.Forms.CheckBox();
            this.browse = new System.Windows.Forms.Button();
            this.anon_data_2 = new System.Windows.Forms.LinkLabel();
            this.anon_data = new System.Windows.Forms.CheckBox();
            this.cleanexit = new System.Windows.Forms.CheckBox();
            this.show_ip = new System.Windows.Forms.CheckBox();
            this.steamsearch = new System.Windows.Forms.Button();
            this.always_on_top = new System.Windows.Forms.CheckBox();
            this.chpath = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.to_tray = new System.Windows.Forms.CheckBox();
            this.about = new System.Windows.Forms.Button();
            this.auto_backup_group = new System.Windows.Forms.GroupBox();
            this.backup_location_l = new System.Windows.Forms.Label();
            this.backup_location = new System.Windows.Forms.TextBox();
            this.backup_chat = new System.Windows.Forms.CheckBox();
            this.auto_backup_check = new System.Windows.Forms.CheckBox();
            this.backup_time = new System.Windows.Forms.TrackBar();
            this.spawn_group = new System.Windows.Forms.GroupBox();
            this.spawn_now = new System.Windows.Forms.Button();
            this.spawn_item = new System.Windows.Forms.ComboBox();
            this.telnet_group = new System.Windows.Forms.GroupBox();
            this.godzina = new System.Windows.Forms.Label();
            this.dzien = new System.Windows.Forms.Label();
            this.telnet_connect = new System.Windows.Forms.Button();
            this.dzien_bar = new System.Windows.Forms.TrackBar();
            this.godzina_bar = new System.Windows.Forms.TrackBar();
            this.cmd = new System.Windows.Forms.TextBox();
            this.konsola = new System.Windows.Forms.RichTextBox();
            this.startbar = new System.Windows.Forms.ProgressBar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.server_manage = new System.Windows.Forms.TabPage();
            this.CommandsGroup = new System.Windows.Forms.GroupBox();
            this.usecmd = new System.Windows.Forms.Button();
            this.commandslist = new System.Windows.Forms.ListBox();
            this.zoomup = new System.Windows.Forms.Button();
            this.overviewSplitter = new System.Windows.Forms.SplitContainer();
            this.News_Group = new System.Windows.Forms.GroupBox();
            this.News_Feed_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Server_Status_Group = new System.Windows.Forms.GroupBox();
            this.osarch = new System.Windows.Forms.Label();
            this.telnetstatus = new System.Windows.Forms.Label();
            this.osver = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.Console_Group = new System.Windows.Forms.GroupBox();
            this.Timers_Group = new System.Windows.Forms.GroupBox();
            this.Auto_Command_Timer = new System.Windows.Forms.Label();
            this.Whitelist_Update_Timer = new System.Windows.Forms.Label();
            this.Whitelist_Update_Label = new System.Windows.Forms.Label();
            this.Auto_Restart_Timer = new System.Windows.Forms.Label();
            this.Auto_Restart_Timer_Label = new System.Windows.Forms.Label();
            this.Backup_Timer = new System.Windows.Forms.Label();
            this.Backup_Timer_Label = new System.Windows.Forms.Label();
            this.SQL_Export_Timer_Label = new System.Windows.Forms.Label();
            this.SQL_Export_Timer = new System.Windows.Forms.Label();
            this.Auto_Command_Timer_Label = new System.Windows.Forms.Label();
            this.Server_Controls_Group = new System.Windows.Forms.GroupBox();
            this.Start_7DSM_With_Windows_CheckBox = new System.Windows.Forms.CheckBox();
            this.Start_With_7DSM_CheckBox = new System.Windows.Forms.CheckBox();
            this.Start_Server_Button = new System.Windows.Forms.Button();
            this.Shutdown_Server_Button = new System.Windows.Forms.Button();
            this.Connect_Running_Server_Button = new System.Windows.Forms.Button();
            this.Save_Logs_CheckBox = new System.Windows.Forms.CheckBox();
            this.Kill_Server_Process = new System.Windows.Forms.Button();
            this.ban_kick = new System.Windows.Forms.TabPage();
            this.Chat_Group = new System.Windows.Forms.GroupBox();
            this.chat = new System.Windows.Forms.RichTextBox();
            this.chat_text = new System.Windows.Forms.TextBox();
            this.all_players_l = new System.Windows.Forms.Label();
            this.online_l = new System.Windows.Forms.Label();
            this.All_Players_List = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.player_g = new System.Windows.Forms.GroupBox();
            this.thirsty_player = new System.Windows.Forms.Button();
            this.starve_player = new System.Windows.Forms.Button();
            this.kill_player = new System.Windows.Forms.Button();
            this.kickgroup = new System.Windows.Forms.GroupBox();
            this.kick = new System.Windows.Forms.Button();
            this.powod = new System.Windows.Forms.ComboBox();
            this.bantime_slider = new System.Windows.Forms.GroupBox();
            this.bantime = new System.Windows.Forms.ComboBox();
            this.ban = new System.Windows.Forms.Button();
            this.ban_slide = new System.Windows.Forms.TrackBar();
            this.Online_Player_List = new System.Windows.Forms.ListView();
            this.login_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.steamid_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.main_page = new System.Windows.Forms.TabPage();
            this.main_page_opts = new System.Windows.Forms.TabControl();
            this.game_opts = new System.Windows.Forms.TabPage();
            this.reserved_g = new System.Windows.Forms.GroupBox();
            this.ServerAdminSlotsPermission = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerAdminSlots = new System.Windows.Forms.TextBox();
            this.ServerReservedSlotsPermission = new System.Windows.Forms.TextBox();
            this.res_l2 = new System.Windows.Forms.Label();
            this.res_l1 = new System.Windows.Forms.Label();
            this.ServerReservedSlots = new System.Windows.Forms.TextBox();
            this.PlayerKillingMode_g = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlayerKillingMode_0 = new System.Windows.Forms.RadioButton();
            this.PlayerKillingMode_1 = new System.Windows.Forms.RadioButton();
            this.PlayerKillingMode_2 = new System.Windows.Forms.RadioButton();
            this.PlayerKillingMode_3 = new System.Windows.Forms.RadioButton();
            this.spawn_p_l = new System.Windows.Forms.GroupBox();
            this.PlayerSafeZoneHours_l = new System.Windows.Forms.Label();
            this.PlayerSafeZoneLevel_l = new System.Windows.Forms.Label();
            this.PlayerSafeZoneHours = new System.Windows.Forms.TextBox();
            this.PlayerSafeZoneLevel = new System.Windows.Forms.TextBox();
            this.AirDropFrequency_g = new System.Windows.Forms.GroupBox();
            this.AirDropFrequency = new System.Windows.Forms.TrackBar();
            this.LandClaim = new System.Windows.Forms.GroupBox();
            this.LandClaimDecayMode_g = new System.Windows.Forms.GroupBox();
            this.Full_prot = new System.Windows.Forms.RadioButton();
            this.Exponential = new System.Windows.Forms.RadioButton();
            this.Linear = new System.Windows.Forms.RadioButton();
            this.LandClaim_g = new System.Windows.Forms.GroupBox();
            this.offline = new System.Windows.Forms.Label();
            this.online = new System.Windows.Forms.Label();
            this.LandClaimOfflineDurabilityModifier = new System.Windows.Forms.TextBox();
            this.LandClaimOnlineDurabilityModifier = new System.Windows.Forms.TextBox();
            this.LandClaimSize_g = new System.Windows.Forms.GroupBox();
            this.LandClaimSize = new System.Windows.Forms.TextBox();
            this.LandClaimDeadZone_g = new System.Windows.Forms.GroupBox();
            this.LandClaimDeadZone = new System.Windows.Forms.TextBox();
            this.LandClaimExpiryTime_g = new System.Windows.Forms.GroupBox();
            this.LandClaimExpiryTime = new System.Windows.Forms.TextBox();
            this.LootRespawnDays_g = new System.Windows.Forms.GroupBox();
            this.LootRespawnDays = new System.Windows.Forms.TrackBar();
            this.LootAbundance_g = new System.Windows.Forms.GroupBox();
            this.LootAbundance = new System.Windows.Forms.TrackBar();
            this.maxplgroup = new System.Windows.Forms.GroupBox();
            this.maxpl = new System.Windows.Forms.TrackBar();
            this.trybgry = new System.Windows.Forms.GroupBox();
            this.PersistentPlayerProfiles = new System.Windows.Forms.CheckBox();
            this.feral = new System.Windows.Forms.CheckBox();
            this.gamemode_surv_pvp = new System.Windows.Forms.RadioButton();
            this.cheatmode = new System.Windows.Forms.CheckBox();
            this.gamemode_coop = new System.Windows.Forms.RadioButton();
            this.zomb_pie = new System.Windows.Forms.GroupBox();
            this.zombie_never_run = new System.Windows.Forms.RadioButton();
            this.zombie_normal = new System.Windows.Forms.RadioButton();
            this.zombie_run = new System.Windows.Forms.RadioButton();
            this.nightpercentage_g = new System.Windows.Forms.GroupBox();
            this.nightpercentage = new System.Windows.Forms.TrackBar();
            this.dlugoscdnia_g = new System.Windows.Forms.GroupBox();
            this.realtime = new System.Windows.Forms.CheckBox();
            this.dlugoscdnia = new System.Windows.Forms.TrackBar();
            this.bdm_g = new System.Windows.Forms.GroupBox();
            this.bdm = new System.Windows.Forms.TrackBar();
            this.dod_g = new System.Windows.Forms.GroupBox();
            this.dod_p = new System.Windows.Forms.Panel();
            this.dod_0 = new System.Windows.Forms.RadioButton();
            this.dod_1 = new System.Windows.Forms.RadioButton();
            this.dod_2 = new System.Windows.Forms.RadioButton();
            this.dod_3 = new System.Windows.Forms.RadioButton();
            this.doq_3 = new System.Windows.Forms.RadioButton();
            this.doq_2 = new System.Windows.Forms.RadioButton();
            this.doq_1 = new System.Windows.Forms.RadioButton();
            this.doq_0 = new System.Windows.Forms.RadioButton();
            this.trudnoscgroup = new System.Windows.Forms.GroupBox();
            this.trudnosc = new System.Windows.Forms.TrackBar();
            this.server_opts = new System.Windows.Forms.TabPage();
            this.ServerWebsiteURL_g = new System.Windows.Forms.GroupBox();
            this.ServerWebsiteURL = new System.Windows.Forms.TextBox();
            this.ServerDescription_g = new System.Windows.Forms.GroupBox();
            this.ServerDescription = new System.Windows.Forms.TextBox();
            this.configfile_g = new System.Windows.Forms.GroupBox();
            this.configfile_e = new System.Windows.Forms.Button();
            this.configfile = new System.Windows.Forms.TextBox();
            this.save_g = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.TextBox();
            this.filename_g = new System.Windows.Forms.GroupBox();
            this.sa_edit = new System.Windows.Forms.Button();
            this.AdminFileName = new System.Windows.Forms.TextBox();
            this.nazwamapa = new System.Windows.Forms.GroupBox();
            this.nazwa = new System.Windows.Forms.ComboBox();
            this.server_nazwa = new System.Windows.Forms.TextBox();
            this.mapa = new System.Windows.Forms.ComboBox();
            this.dostep = new System.Windows.Forms.GroupBox();
            this.ServerPassword = new System.Windows.Forms.TextBox();
            this.ServerIsPublic = new System.Windows.Forms.CheckBox();
            this.odery = new System.Windows.Forms.GroupBox();
            this.VACEnabled = new System.Windows.Forms.CheckBox();
            this.save_logfiles = new System.Windows.Forms.CheckBox();
            this.autobots = new System.Windows.Forms.GroupBox();
            this.EnemySpawnMode = new System.Windows.Forms.CheckBox();
            this.BedrollDeadZoneSize_g = new System.Windows.Forms.GroupBox();
            this.BedrollDeadZoneSize = new System.Windows.Forms.TrackBar();
            this.BloodMoonEnemyCount_g = new System.Windows.Forms.GroupBox();
            this.BloodMoonEnemyCount = new System.Windows.Forms.TrackBar();
            this.AirDropMarker = new System.Windows.Forms.CheckBox();
            this.MaxSpawnedAnimals_g = new System.Windows.Forms.GroupBox();
            this.MaxSpawnedAnimals = new System.Windows.Forms.TrackBar();
            this.MaxSpawnedZombies_g = new System.Windows.Forms.GroupBox();
            this.MaxSpawnedZombies = new System.Windows.Forms.TrackBar();
            this.net_opts = new System.Windows.Forms.TabPage();
            this.MaxUncoveredMapChunksPerPlayer_g = new System.Windows.Forms.GroupBox();
            this.MaxUncoveredMapChunksPerPlayer = new System.Windows.Forms.TextBox();
            this.HideCommandExecutionLog_g = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HideCommandExecutionLog_0 = new System.Windows.Forms.RadioButton();
            this.HideCommandExecutionLog_1 = new System.Windows.Forms.RadioButton();
            this.HideCommandExecutionLog_2 = new System.Windows.Forms.RadioButton();
            this.HideCommandExecutionLog_3 = new System.Windows.Forms.RadioButton();
            this.ServerDisabledNetworkProtocols_g = new System.Windows.Forms.GroupBox();
            this.RakNet = new System.Windows.Forms.CheckBox();
            this.SteamNetworking = new System.Windows.Forms.CheckBox();
            this.UNET = new System.Windows.Forms.CheckBox();
            this.port_g = new System.Windows.Forms.GroupBox();
            this.port = new System.Windows.Forms.TextBox();
            this.ctrlpanel = new System.Windows.Forms.GroupBox();
            this.cpl_port = new System.Windows.Forms.Label();
            this.port_panel = new System.Windows.Forms.TextBox();
            this.cpl_pass = new System.Windows.Forms.Label();
            this.ctrlp = new System.Windows.Forms.CheckBox();
            this.ctrlppass = new System.Windows.Forms.TextBox();
            this.telnet_g = new System.Windows.Forms.GroupBox();
            this.telnet_port_l = new System.Windows.Forms.Label();
            this.telnet_port_p = new System.Windows.Forms.TextBox();
            this.telnet_psw_l = new System.Windows.Forms.Label();
            this.telnet_psw = new System.Windows.Forms.TextBox();
            this.ikony_naglowka = new System.Windows.Forms.ImageList(this.components);
            this.strings_page = new System.Windows.Forms.TabPage();
            this.messages_g = new System.Windows.Forms.GroupBox();
            this.cmd_not_yet = new System.Windows.Forms.TextBox();
            this.cmd_not_yet_l = new System.Windows.Forms.Label();
            this.backup_msg_1 = new System.Windows.Forms.TextBox();
            this.backup_msg_2_l = new System.Windows.Forms.Label();
            this.reboot = new System.Windows.Forms.TextBox();
            this.backup_msg_2 = new System.Windows.Forms.TextBox();
            this.backup_msg_1_l = new System.Windows.Forms.Label();
            this.reboot_time_l = new System.Windows.Forms.Label();
            this.reboot_l = new System.Windows.Forms.Label();
            this.reboot_time = new System.Windows.Forms.TextBox();
            this.customcommands_g = new System.Windows.Forms.GroupBox();
            this.how_to_commands2 = new System.Windows.Forms.Button();
            this.excall_file_l = new System.Windows.Forms.Label();
            this.excall_file = new System.Windows.Forms.Button();
            this.excall = new System.Windows.Forms.CheckBox();
            this.enable_cc = new System.Windows.Forms.CheckBox();
            this.how_to_commands = new System.Windows.Forms.Button();
            this.customcommands = new System.Windows.Forms.RichTextBox();
            this.globalBanList = new System.Windows.Forms.TabPage();
            this.check_bans = new System.Windows.Forms.Button();
            this.global_ban_g = new System.Windows.Forms.GroupBox();
            this.sendbans = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.glob_3 = new System.Windows.Forms.RadioButton();
            this.glob_0 = new System.Windows.Forms.RadioButton();
            this.glob_2 = new System.Windows.Forms.RadioButton();
            this.glob_1 = new System.Windows.Forms.RadioButton();
            this.banlist_logo = new System.Windows.Forms.PictureBox();
            this.WebServer = new System.Windows.Forms.TabPage();
            this.autofix_g = new System.Windows.Forms.GroupBox();
            this.reverse_reservation = new System.Windows.Forms.Button();
            this.conflict_l = new System.Windows.Forms.Label();
            this.fix_firewall_and_other_windows_shit = new System.Windows.Forms.Button();
            this.fix_l = new System.Windows.Forms.Label();
            this.website_g = new System.Windows.Forms.GroupBox();
            this.www_rules_content = new System.Windows.Forms.TabControl();
            this.home_tab = new System.Windows.Forms.TabPage();
            this.www_main_content = new System.Windows.Forms.RichTextBox();
            this.rules_tab = new System.Windows.Forms.TabPage();
            this.rules_content = new System.Windows.Forms.RichTextBox();
            this.other_tab = new System.Windows.Forms.TabPage();
            this.prem_help3 = new System.Windows.Forms.PictureBox();
            this.hide_footer = new System.Windows.Forms.CheckBox();
            this.allowed_replacements_l = new System.Windows.Forms.Label();
            this.allowed_replacements = new System.Windows.Forms.ListBox();
            this.forum_url = new System.Windows.Forms.TextBox();
            this.forum_url_l = new System.Windows.Forms.Label();
            this.website_l = new System.Windows.Forms.Label();
            this.enable_website = new System.Windows.Forms.CheckBox();
            this.android_g = new System.Windows.Forms.GroupBox();
            this.or_l = new System.Windows.Forms.Label();
            this.android_apk = new System.Windows.Forms.Button();
            this.android_play = new System.Windows.Forms.Button();
            this.android_allow = new System.Windows.Forms.CheckBox();
            this.android_access_key = new System.Windows.Forms.Label();
            this.tasks = new System.Windows.Forms.TabPage();
            this.reset_g = new System.Windows.Forms.GroupBox();
            this.reset_chat = new System.Windows.Forms.CheckBox();
            this.reset_enabled = new System.Windows.Forms.CheckBox();
            this.reset_time = new System.Windows.Forms.TrackBar();
            this.spam_g = new System.Windows.Forms.GroupBox();
            this.spam_is_spam = new System.Windows.Forms.CheckBox();
            this.spaminfo = new System.Windows.Forms.Label();
            this.spam_list = new System.Windows.Forms.RichTextBox();
            this.spam_time_g = new System.Windows.Forms.GroupBox();
            this.spam_time = new System.Windows.Forms.TrackBar();
            this.whitelist_dl_g = new System.Windows.Forms.GroupBox();
            this.use_wl = new System.Windows.Forms.CheckBox();
            this.min_l = new System.Windows.Forms.Label();
            this.wl_interval = new System.Windows.Forms.TextBox();
            this.wl_chk = new System.Windows.Forms.CheckBox();
            this.wl_add_l = new System.Windows.Forms.Label();
            this.wl_add = new System.Windows.Forms.TextBox();
            this.backup_tab = new System.Windows.Forms.TabPage();
            this.restore_backup_g = new System.Windows.Forms.GroupBox();
            this.opeb_bp_dir = new System.Windows.Forms.Button();
            this.create_bp_now = new System.Windows.Forms.Button();
            this.backup_del = new System.Windows.Forms.Button();
            this.backup_refresh = new System.Windows.Forms.Button();
            this.restore_now = new System.Windows.Forms.Button();
            this.backups_list = new System.Windows.Forms.ListBox();
            this.ex_backup = new System.Windows.Forms.GroupBox();
            this.rem_old_backups_l = new System.Windows.Forms.Label();
            this.rem_old_backups_count = new System.Windows.Forms.TextBox();
            this.rem_old_backups = new System.Windows.Forms.CheckBox();
            this.prem_help2 = new System.Windows.Forms.PictureBox();
            this.srv_list = new System.Windows.Forms.TabPage();
            this.deds_g = new System.Windows.Forms.GroupBox();
            this.dtds_show = new System.Windows.Forms.CheckBox();
            this.dtds_info2 = new System.Windows.Forms.Label();
            this.dtds_auth = new System.Windows.Forms.TextBox();
            this.dtds_rem = new System.Windows.Forms.Button();
            this.dtds_info = new System.Windows.Forms.Label();
            this.dtds_lista = new System.Windows.Forms.ListBox();
            this.dtds_add = new System.Windows.Forms.Button();
            this.dtds_possible = new System.Windows.Forms.ComboBox();
            this.dtds_explain = new System.Windows.Forms.Label();
            this.dtds_enable = new System.Windows.Forms.CheckBox();
            this.dtds_visit = new System.Windows.Forms.Button();
            this.server_startup_tasks = new System.ComponentModel.BackgroundWorker();
            this.telnet_connection = new System.ComponentModel.BackgroundWorker();
            this.workers_list = new System.ComponentModel.BackgroundWorker();
            this.auto_messages = new System.ComponentModel.BackgroundWorker();
            this.sql_exporter = new System.ComponentModel.BackgroundWorker();
            this.auto_backup = new System.ComponentModel.BackgroundWorker();
            this.auto_reset = new System.ComponentModel.BackgroundWorker();
            this.stats = new System.ComponentModel.BackgroundWorker();
            this.reboot_telnet = new System.ComponentModel.BackgroundWorker();
            this.custom_cmd_executor = new System.ComponentModel.BackgroundWorker();
            this.server_stop_tasks = new System.ComponentModel.BackgroundWorker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.img_status = new System.Windows.Forms.PictureBox();
            this.autoupdate_whitelist = new System.ComponentModel.BackgroundWorker();
            this.don_l = new System.Windows.Forms.Label();
            this.check_updates = new System.ComponentModel.BackgroundWorker();
            this.prepare_app_after_draw = new System.ComponentModel.BackgroundWorker();
            this.dbg_btn = new System.Windows.Forms.Button();
            this.dbg_btn_2 = new System.Windows.Forms.Button();
            this.help_b = new System.Windows.Forms.Button();
            this.contact_b = new System.Windows.Forms.Button();
            this.forumklik = new System.Windows.Forms.Button();
            this.www7dsm = new System.Windows.Forms.Button();
            this.like = new System.Windows.Forms.Button();
            this.externalCallFile = new System.Windows.Forms.OpenFileDialog();
            this.discord_b = new System.Windows.Forms.Button();
            this.settings.SuspendLayout();
            this.dsm_updates_g.SuspendLayout();
            this.exe_settings_g.SuspendLayout();
            this.prem_set.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prem_help1)).BeginInit();
            this.prem_g.SuspendLayout();
            this.sql.SuspendLayout();
            this.sql_updates_time_g.SuspendLayout();
            this.sql_host_g.SuspendLayout();
            this.sql_username_g.SuspendLayout();
            this.sql_db_name_g.SuspendLayout();
            this.sql_password_g.SuspendLayout();
            this.ustawienia_grupa_ustawienia.SuspendLayout();
            this.auto_backup_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backup_time)).BeginInit();
            this.spawn_group.SuspendLayout();
            this.telnet_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dzien_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.godzina_bar)).BeginInit();
            this.tabControl.SuspendLayout();
            this.server_manage.SuspendLayout();
            this.CommandsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewSplitter)).BeginInit();
            this.overviewSplitter.Panel1.SuspendLayout();
            this.overviewSplitter.Panel2.SuspendLayout();
            this.overviewSplitter.SuspendLayout();
            this.News_Group.SuspendLayout();
            this.Server_Status_Group.SuspendLayout();
            this.Console_Group.SuspendLayout();
            this.Timers_Group.SuspendLayout();
            this.Server_Controls_Group.SuspendLayout();
            this.ban_kick.SuspendLayout();
            this.Chat_Group.SuspendLayout();
            this.player_g.SuspendLayout();
            this.kickgroup.SuspendLayout();
            this.bantime_slider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ban_slide)).BeginInit();
            this.main_page.SuspendLayout();
            this.main_page_opts.SuspendLayout();
            this.game_opts.SuspendLayout();
            this.reserved_g.SuspendLayout();
            this.PlayerKillingMode_g.SuspendLayout();
            this.panel1.SuspendLayout();
            this.spawn_p_l.SuspendLayout();
            this.AirDropFrequency_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AirDropFrequency)).BeginInit();
            this.LandClaim.SuspendLayout();
            this.LandClaimDecayMode_g.SuspendLayout();
            this.LandClaim_g.SuspendLayout();
            this.LandClaimSize_g.SuspendLayout();
            this.LandClaimDeadZone_g.SuspendLayout();
            this.LandClaimExpiryTime_g.SuspendLayout();
            this.LootRespawnDays_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LootRespawnDays)).BeginInit();
            this.LootAbundance_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LootAbundance)).BeginInit();
            this.maxplgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxpl)).BeginInit();
            this.trybgry.SuspendLayout();
            this.zomb_pie.SuspendLayout();
            this.nightpercentage_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nightpercentage)).BeginInit();
            this.dlugoscdnia_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlugoscdnia)).BeginInit();
            this.bdm_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdm)).BeginInit();
            this.dod_g.SuspendLayout();
            this.dod_p.SuspendLayout();
            this.trudnoscgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trudnosc)).BeginInit();
            this.server_opts.SuspendLayout();
            this.ServerWebsiteURL_g.SuspendLayout();
            this.ServerDescription_g.SuspendLayout();
            this.configfile_g.SuspendLayout();
            this.save_g.SuspendLayout();
            this.filename_g.SuspendLayout();
            this.nazwamapa.SuspendLayout();
            this.dostep.SuspendLayout();
            this.odery.SuspendLayout();
            this.autobots.SuspendLayout();
            this.BedrollDeadZoneSize_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BedrollDeadZoneSize)).BeginInit();
            this.BloodMoonEnemyCount_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BloodMoonEnemyCount)).BeginInit();
            this.MaxSpawnedAnimals_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpawnedAnimals)).BeginInit();
            this.MaxSpawnedZombies_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpawnedZombies)).BeginInit();
            this.net_opts.SuspendLayout();
            this.MaxUncoveredMapChunksPerPlayer_g.SuspendLayout();
            this.HideCommandExecutionLog_g.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ServerDisabledNetworkProtocols_g.SuspendLayout();
            this.port_g.SuspendLayout();
            this.ctrlpanel.SuspendLayout();
            this.telnet_g.SuspendLayout();
            this.strings_page.SuspendLayout();
            this.messages_g.SuspendLayout();
            this.customcommands_g.SuspendLayout();
            this.globalBanList.SuspendLayout();
            this.global_ban_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banlist_logo)).BeginInit();
            this.WebServer.SuspendLayout();
            this.autofix_g.SuspendLayout();
            this.website_g.SuspendLayout();
            this.www_rules_content.SuspendLayout();
            this.home_tab.SuspendLayout();
            this.rules_tab.SuspendLayout();
            this.other_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prem_help3)).BeginInit();
            this.android_g.SuspendLayout();
            this.tasks.SuspendLayout();
            this.reset_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reset_time)).BeginInit();
            this.spam_g.SuspendLayout();
            this.spam_time_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spam_time)).BeginInit();
            this.whitelist_dl_g.SuspendLayout();
            this.backup_tab.SuspendLayout();
            this.restore_backup_g.SuspendLayout();
            this.ex_backup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prem_help2)).BeginInit();
            this.srv_list.SuspendLayout();
            this.deds_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_status)).BeginInit();
            this.SuspendLayout();
            // 
            // status_updater
            // 
            this.status_updater.WorkerSupportsCancellation = true;
            this.status_updater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // select_dir
            // 
            this.select_dir.Description = "Game dir";
            this.select_dir.ShowNewFolderButton = false;
            this.select_dir.HelpRequest += new System.EventHandler(this.select_dir_HelpRequest);
            // 
            // ikona
            // 
            this.ikona.Icon = ((System.Drawing.Icon)(resources.GetObject("ikona.Icon")));
            this.ikona.Text = "7 Days Server Manager";
            this.ikona.Visible = true;
            this.ikona.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ikona_MouseClick);
            // 
            // twoje_ip
            // 
            this.twoje_ip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.twoje_ip.AutoSize = true;
            this.twoje_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.twoje_ip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.twoje_ip.Location = new System.Drawing.Point(6, 100);
            this.twoje_ip.Name = "twoje_ip";
            this.twoje_ip.Size = new System.Drawing.Size(74, 13);
            this.twoje_ip.TabIndex = 23;
            this.twoje_ip.Text = "Checking IP...";
            this.twoje_ip.Visible = false;
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.Control;
            this.settings.Controls.Add(this.dsm_updates_g);
            this.settings.Controls.Add(this.exe_settings_g);
            this.settings.Controls.Add(this.prem_set);
            this.settings.Controls.Add(this.prem_g);
            this.settings.Controls.Add(this.debug_log);
            this.settings.Controls.Add(this.sql);
            this.settings.Controls.Add(this.blad);
            this.settings.Controls.Add(this.workerynapis);
            this.settings.Controls.Add(this.taskman);
            this.settings.Controls.Add(this.ustawienia_grupa_ustawienia);
            this.settings.Controls.Add(this.about);
            this.settings.ImageIndex = 4;
            this.settings.Location = new System.Drawing.Point(47, 4);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(908, 684);
            this.settings.TabIndex = 4;
            // 
            // dsm_updates_g
            // 
            this.dsm_updates_g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dsm_updates_g.Controls.Add(this.apply_update_channel);
            this.dsm_updates_g.Controls.Add(this.force_upd);
            this.dsm_updates_g.Controls.Add(this.chk_upd);
            this.dsm_updates_g.Controls.Add(this.updates_info);
            this.dsm_updates_g.Controls.Add(this.updates_channel_l);
            this.dsm_updates_g.Controls.Add(this.updates_channel);
            this.dsm_updates_g.Location = new System.Drawing.Point(551, 58);
            this.dsm_updates_g.Name = "dsm_updates_g";
            this.dsm_updates_g.Size = new System.Drawing.Size(350, 191);
            this.dsm_updates_g.TabIndex = 41;
            this.dsm_updates_g.TabStop = false;
            this.dsm_updates_g.Text = "7DSM Updates";
            // 
            // apply_update_channel
            // 
            this.apply_update_channel.Location = new System.Drawing.Point(270, 22);
            this.apply_update_channel.Name = "apply_update_channel";
            this.apply_update_channel.Size = new System.Drawing.Size(75, 23);
            this.apply_update_channel.TabIndex = 44;
            this.apply_update_channel.Text = "Apply";
            this.apply_update_channel.UseVisualStyleBackColor = true;
            this.apply_update_channel.Click += new System.EventHandler(this.apply_update_channel_Click);
            // 
            // force_upd
            // 
            this.force_upd.Location = new System.Drawing.Point(180, 151);
            this.force_upd.Name = "force_upd";
            this.force_upd.Size = new System.Drawing.Size(156, 23);
            this.force_upd.TabIndex = 43;
            this.force_upd.Text = "Force update now";
            this.force_upd.UseVisualStyleBackColor = true;
            this.force_upd.Click += new System.EventHandler(this.force_upd_Click);
            // 
            // chk_upd
            // 
            this.chk_upd.Location = new System.Drawing.Point(18, 151);
            this.chk_upd.Name = "chk_upd";
            this.chk_upd.Size = new System.Drawing.Size(156, 23);
            this.chk_upd.TabIndex = 42;
            this.chk_upd.Text = "Check for updates now";
            this.chk_upd.UseVisualStyleBackColor = true;
            this.chk_upd.Click += new System.EventHandler(this.chk_upd_Click);
            // 
            // updates_info
            // 
            this.updates_info.AutoSize = true;
            this.updates_info.Location = new System.Drawing.Point(15, 57);
            this.updates_info.Name = "updates_info";
            this.updates_info.Size = new System.Drawing.Size(308, 65);
            this.updates_info.TabIndex = 41;
            this.updates_info.Text = "STABLE is main updates channel.\r\nDEV has newer, but untested builds- they may not" +
    " work properly\r\nor even not work at all!\r\n\r\nIf you don\'t know which to use, sele" +
    "ct STABLE.";
            // 
            // updates_channel_l
            // 
            this.updates_channel_l.AutoSize = true;
            this.updates_channel_l.Location = new System.Drawing.Point(15, 26);
            this.updates_channel_l.Name = "updates_channel_l";
            this.updates_channel_l.Size = new System.Drawing.Size(124, 13);
            this.updates_channel_l.TabIndex = 40;
            this.updates_channel_l.Text = "7DSM Updates channel:";
            // 
            // updates_channel
            // 
            this.updates_channel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updates_channel.FormattingEnabled = true;
            this.updates_channel.Items.AddRange(new object[] {
            "STABLE",
            "DEV"});
            this.updates_channel.Location = new System.Drawing.Point(145, 23);
            this.updates_channel.Name = "updates_channel";
            this.updates_channel.Size = new System.Drawing.Size(119, 21);
            this.updates_channel.TabIndex = 39;
            // 
            // exe_settings_g
            // 
            this.exe_settings_g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exe_settings_g.Controls.Add(this.exe_name_l);
            this.exe_settings_g.Controls.Add(this.exe_name);
            this.exe_settings_g.Location = new System.Drawing.Point(551, 8);
            this.exe_settings_g.Name = "exe_settings_g";
            this.exe_settings_g.Size = new System.Drawing.Size(350, 44);
            this.exe_settings_g.TabIndex = 40;
            this.exe_settings_g.TabStop = false;
            this.exe_settings_g.Text = ".exe settings";
            // 
            // exe_name_l
            // 
            this.exe_name_l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exe_name_l.AutoSize = true;
            this.exe_name_l.Location = new System.Drawing.Point(15, 18);
            this.exe_name_l.Name = "exe_name_l";
            this.exe_name_l.Size = new System.Drawing.Size(72, 13);
            this.exe_name_l.TabIndex = 38;
            this.exe_name_l.Text = ".exe filename:";
            // 
            // exe_name
            // 
            this.exe_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exe_name.Location = new System.Drawing.Point(93, 15);
            this.exe_name.Name = "exe_name";
            this.exe_name.Size = new System.Drawing.Size(161, 20);
            this.exe_name.TabIndex = 37;
            this.exe_name.Text = "7DaysToDie.exe";
            this.exe_name.TextChanged += new System.EventHandler(this.exe_name_TextChanged);
            // 
            // prem_set
            // 
            this.prem_set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prem_set.Controls.Add(this.prem_help1);
            this.prem_set.Controls.Add(this.hide_don_btn);
            this.prem_set.Location = new System.Drawing.Point(551, 460);
            this.prem_set.Name = "prem_set";
            this.prem_set.Size = new System.Drawing.Size(351, 45);
            this.prem_set.TabIndex = 39;
            this.prem_set.TabStop = false;
            this.prem_set.Text = "Supporter settings";
            // 
            // prem_help1
            // 
            this.prem_help1.Image = ((System.Drawing.Image)(resources.GetObject("prem_help1.Image")));
            this.prem_help1.Location = new System.Drawing.Point(329, 19);
            this.prem_help1.Name = "prem_help1";
            this.prem_help1.Size = new System.Drawing.Size(16, 16);
            this.prem_help1.TabIndex = 40;
            this.prem_help1.TabStop = false;
            this.toolTip.SetToolTip(this.prem_help1, "You need 7DSM Supporter to change these options.\r\nIt\'s almost free, please check " +
        "it out in \"Settings\" tab.");
            // 
            // hide_don_btn
            // 
            this.hide_don_btn.AutoSize = true;
            this.hide_don_btn.Enabled = false;
            this.hide_don_btn.Location = new System.Drawing.Point(18, 20);
            this.hide_don_btn.Name = "hide_don_btn";
            this.hide_don_btn.Size = new System.Drawing.Size(130, 17);
            this.hide_don_btn.TabIndex = 41;
            this.hide_don_btn.Text = "Hide donation buttons";
            this.hide_don_btn.UseVisualStyleBackColor = true;
            this.hide_don_btn.CheckedChanged += new System.EventHandler(this.hide_don_btn_CheckedChanged);
            // 
            // prem_g
            // 
            this.prem_g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prem_g.Controls.Add(this.prem_show);
            this.prem_g.Controls.Add(this.dondon2);
            this.prem_g.Controls.Add(this.prem_info_2);
            this.prem_g.Controls.Add(this.prem_info);
            this.prem_g.Controls.Add(this.prem_act);
            this.prem_g.Controls.Add(this.prem_psw_l);
            this.prem_g.Controls.Add(this.prem_psw);
            this.prem_g.Location = new System.Drawing.Point(551, 255);
            this.prem_g.Name = "prem_g";
            this.prem_g.Size = new System.Drawing.Size(351, 199);
            this.prem_g.TabIndex = 38;
            this.prem_g.TabStop = false;
            this.prem_g.Text = "7DSM Supporter";
            // 
            // prem_show
            // 
            this.prem_show.AutoSize = true;
            this.prem_show.Location = new System.Drawing.Point(135, 19);
            this.prem_show.Name = "prem_show";
            this.prem_show.Size = new System.Drawing.Size(106, 17);
            this.prem_show.TabIndex = 27;
            this.prem_show.Text = "Show characters";
            this.prem_show.UseVisualStyleBackColor = true;
            this.prem_show.CheckedChanged += new System.EventHandler(this.prem_show_CheckedChanged);
            // 
            // dondon2
            // 
            this.dondon2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dondon2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dondon2.BackgroundImage")));
            this.dondon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dondon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dondon2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dondon2.FlatAppearance.BorderSize = 0;
            this.dondon2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dondon2.Location = new System.Drawing.Point(135, 68);
            this.dondon2.Margin = new System.Windows.Forms.Padding(0);
            this.dondon2.Name = "dondon2";
            this.dondon2.Size = new System.Drawing.Size(75, 23);
            this.dondon2.TabIndex = 26;
            this.dondon2.UseVisualStyleBackColor = true;
            this.dondon2.Click += new System.EventHandler(this.Forumklik_Click);
            // 
            // prem_info_2
            // 
            this.prem_info_2.AutoSize = true;
            this.prem_info_2.Location = new System.Drawing.Point(6, 114);
            this.prem_info_2.Name = "prem_info_2";
            this.prem_info_2.Size = new System.Drawing.Size(308, 78);
            this.prem_info_2.TabIndex = 6;
            this.prem_info_2.Text = resources.GetString("prem_info_2.Text");
            // 
            // prem_info
            // 
            this.prem_info.AutoSize = true;
            this.prem_info.Location = new System.Drawing.Point(132, 94);
            this.prem_info.Name = "prem_info";
            this.prem_info.Size = new System.Drawing.Size(160, 13);
            this.prem_info.TabIndex = 5;
            this.prem_info.Text = "Supporter status: NOT activated";
            // 
            // prem_act
            // 
            this.prem_act.Location = new System.Drawing.Point(216, 68);
            this.prem_act.Name = "prem_act";
            this.prem_act.Size = new System.Drawing.Size(75, 23);
            this.prem_act.TabIndex = 4;
            this.prem_act.Text = "Activate";
            this.prem_act.UseVisualStyleBackColor = true;
            this.prem_act.Click += new System.EventHandler(this.prem_act_Click);
            // 
            // prem_psw_l
            // 
            this.prem_psw_l.AutoSize = true;
            this.prem_psw_l.Location = new System.Drawing.Point(52, 45);
            this.prem_psw_l.Name = "prem_psw_l";
            this.prem_psw_l.Size = new System.Drawing.Size(83, 13);
            this.prem_psw_l.TabIndex = 3;
            this.prem_psw_l.Text = "Supporter code:";
            // 
            // prem_psw
            // 
            this.prem_psw.Location = new System.Drawing.Point(135, 42);
            this.prem_psw.MaxLength = 8;
            this.prem_psw.Name = "prem_psw";
            this.prem_psw.PasswordChar = '*';
            this.prem_psw.Size = new System.Drawing.Size(156, 20);
            this.prem_psw.TabIndex = 1;
            // 
            // debug_log
            // 
            this.debug_log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.debug_log.AutoSize = true;
            this.debug_log.Location = new System.Drawing.Point(549, 624);
            this.debug_log.Name = "debug_log";
            this.debug_log.Size = new System.Drawing.Size(272, 17);
            this.debug_log.TabIndex = 37;
            this.debug_log.Text = "Create DEBUG log files (check only if asked by dev)";
            this.debug_log.UseVisualStyleBackColor = true;
            this.debug_log.CheckedChanged += new System.EventHandler(this.debug_log_CheckedChanged);
            // 
            // sql
            // 
            this.sql.Controls.Add(this.sql_enabled);
            this.sql.Controls.Add(this.sql_updates_time_g);
            this.sql.Controls.Add(this.sql_host_g);
            this.sql.Controls.Add(this.how_to_sql);
            this.sql.Controls.Add(this.sql_username_g);
            this.sql.Controls.Add(this.sql_db_name_g);
            this.sql.Controls.Add(this.sql_password_g);
            this.sql.Location = new System.Drawing.Point(8, 238);
            this.sql.Name = "sql";
            this.sql.Size = new System.Drawing.Size(534, 376);
            this.sql.TabIndex = 10;
            this.sql.TabStop = false;
            this.sql.Text = "SQL";
            // 
            // sql_enabled
            // 
            this.sql_enabled.AutoSize = true;
            this.sql_enabled.Location = new System.Drawing.Point(6, 19);
            this.sql_enabled.Name = "sql_enabled";
            this.sql_enabled.Size = new System.Drawing.Size(83, 17);
            this.sql_enabled.TabIndex = 0;
            this.sql_enabled.Text = "sql_enabled";
            this.sql_enabled.UseVisualStyleBackColor = true;
            this.sql_enabled.CheckedChanged += new System.EventHandler(this.sql_enabled_CheckedChanged);
            // 
            // sql_updates_time_g
            // 
            this.sql_updates_time_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sql_updates_time_g.Controls.Add(this.sql_updates_time);
            this.sql_updates_time_g.Controls.Add(this.upd_time);
            this.sql_updates_time_g.Location = new System.Drawing.Point(6, 277);
            this.sql_updates_time_g.Name = "sql_updates_time_g";
            this.sql_updates_time_g.Size = new System.Drawing.Size(522, 50);
            this.sql_updates_time_g.TabIndex = 9;
            this.sql_updates_time_g.TabStop = false;
            this.sql_updates_time_g.Text = "sql_updates_time_g";
            // 
            // sql_updates_time
            // 
            this.sql_updates_time.Location = new System.Drawing.Point(6, 19);
            this.sql_updates_time.Name = "sql_updates_time";
            this.sql_updates_time.Size = new System.Drawing.Size(41, 20);
            this.sql_updates_time.TabIndex = 1;
            this.sql_updates_time.Text = "60";
            this.sql_updates_time.TextChanged += new System.EventHandler(this.sql_updates_time_TextChanged);
            // 
            // upd_time
            // 
            this.upd_time.AutoSize = true;
            this.upd_time.Location = new System.Drawing.Point(50, 22);
            this.upd_time.Name = "upd_time";
            this.upd_time.Size = new System.Drawing.Size(50, 13);
            this.upd_time.TabIndex = 7;
            this.upd_time.Text = "upd_time";
            // 
            // sql_host_g
            // 
            this.sql_host_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sql_host_g.Controls.Add(this.sql_host);
            this.sql_host_g.Location = new System.Drawing.Point(6, 42);
            this.sql_host_g.Name = "sql_host_g";
            this.sql_host_g.Size = new System.Drawing.Size(522, 50);
            this.sql_host_g.TabIndex = 2;
            this.sql_host_g.TabStop = false;
            this.sql_host_g.Text = "sql_host_g";
            // 
            // sql_host
            // 
            this.sql_host.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sql_host.Location = new System.Drawing.Point(6, 19);
            this.sql_host.Name = "sql_host";
            this.sql_host.Size = new System.Drawing.Size(510, 20);
            this.sql_host.TabIndex = 1;
            this.sql_host.Text = "localhost";
            this.sql_host.TextChanged += new System.EventHandler(this.sql_host_TextChanged);
            // 
            // how_to_sql
            // 
            this.how_to_sql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.how_to_sql.Location = new System.Drawing.Point(6, 333);
            this.how_to_sql.Name = "how_to_sql";
            this.how_to_sql.Size = new System.Drawing.Size(522, 31);
            this.how_to_sql.TabIndex = 8;
            this.how_to_sql.Text = "How to integrate it with my website? - Examples";
            this.how_to_sql.UseVisualStyleBackColor = true;
            this.how_to_sql.Click += new System.EventHandler(this.how_to_sql_Click);
            // 
            // sql_username_g
            // 
            this.sql_username_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sql_username_g.Controls.Add(this.sql_username);
            this.sql_username_g.Location = new System.Drawing.Point(6, 98);
            this.sql_username_g.Name = "sql_username_g";
            this.sql_username_g.Size = new System.Drawing.Size(522, 50);
            this.sql_username_g.TabIndex = 3;
            this.sql_username_g.TabStop = false;
            this.sql_username_g.Text = "sql_username_g";
            // 
            // sql_username
            // 
            this.sql_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sql_username.Location = new System.Drawing.Point(6, 19);
            this.sql_username.Name = "sql_username";
            this.sql_username.Size = new System.Drawing.Size(510, 20);
            this.sql_username.TabIndex = 1;
            this.sql_username.Text = "root";
            this.sql_username.TextChanged += new System.EventHandler(this.sql_username_TextChanged);
            // 
            // sql_db_name_g
            // 
            this.sql_db_name_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sql_db_name_g.Controls.Add(this.sql_db_name);
            this.sql_db_name_g.Location = new System.Drawing.Point(6, 221);
            this.sql_db_name_g.Name = "sql_db_name_g";
            this.sql_db_name_g.Size = new System.Drawing.Size(522, 50);
            this.sql_db_name_g.TabIndex = 5;
            this.sql_db_name_g.TabStop = false;
            this.sql_db_name_g.Text = "sql_db_name_g";
            // 
            // sql_db_name
            // 
            this.sql_db_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sql_db_name.Location = new System.Drawing.Point(6, 19);
            this.sql_db_name.Name = "sql_db_name";
            this.sql_db_name.Size = new System.Drawing.Size(510, 20);
            this.sql_db_name.TabIndex = 1;
            this.sql_db_name.Text = "test";
            this.sql_db_name.TextChanged += new System.EventHandler(this.sql_db_name_TextChanged);
            // 
            // sql_password_g
            // 
            this.sql_password_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sql_password_g.Controls.Add(this.sql_warn);
            this.sql_password_g.Controls.Add(this.sql_password);
            this.sql_password_g.Location = new System.Drawing.Point(6, 154);
            this.sql_password_g.Name = "sql_password_g";
            this.sql_password_g.Size = new System.Drawing.Size(522, 61);
            this.sql_password_g.TabIndex = 4;
            this.sql_password_g.TabStop = false;
            this.sql_password_g.Text = "sql_password_g";
            // 
            // sql_warn
            // 
            this.sql_warn.AutoSize = true;
            this.sql_warn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sql_warn.Location = new System.Drawing.Point(6, 42);
            this.sql_warn.Name = "sql_warn";
            this.sql_warn.Size = new System.Drawing.Size(49, 13);
            this.sql_warn.TabIndex = 7;
            this.sql_warn.Text = "sql_warn";
            // 
            // sql_password
            // 
            this.sql_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sql_password.Location = new System.Drawing.Point(6, 19);
            this.sql_password.Name = "sql_password";
            this.sql_password.PasswordChar = '*';
            this.sql_password.Size = new System.Drawing.Size(510, 20);
            this.sql_password.TabIndex = 1;
            this.sql_password.TextChanged += new System.EventHandler(this.sql_password_TextChanged);
            // 
            // blad
            // 
            this.blad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.blad.Location = new System.Drawing.Point(549, 649);
            this.blad.Name = "blad";
            this.blad.Size = new System.Drawing.Size(99, 23);
            this.blad.TabIndex = 28;
            this.blad.Text = "blad";
            this.blad.UseVisualStyleBackColor = true;
            this.blad.Click += new System.EventHandler(this.blad_Click);
            // 
            // workerynapis
            // 
            this.workerynapis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.workerynapis.AutoSize = true;
            this.workerynapis.Location = new System.Drawing.Point(548, 508);
            this.workerynapis.Name = "workerynapis";
            this.workerynapis.Size = new System.Drawing.Size(69, 13);
            this.workerynapis.TabIndex = 27;
            this.workerynapis.Text = "workerynapis";
            // 
            // taskman
            // 
            this.taskman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.taskman.BackColor = System.Drawing.Color.Black;
            this.taskman.ForeColor = System.Drawing.Color.Lime;
            this.taskman.FormattingEnabled = true;
            this.taskman.Location = new System.Drawing.Point(551, 524);
            this.taskman.Name = "taskman";
            this.taskman.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.taskman.Size = new System.Drawing.Size(352, 95);
            this.taskman.TabIndex = 26;
            // 
            // ustawienia_grupa_ustawienia
            // 
            this.ustawienia_grupa_ustawienia.Controls.Add(this.skip_profiles);
            this.ustawienia_grupa_ustawienia.Controls.Add(this.browse);
            this.ustawienia_grupa_ustawienia.Controls.Add(this.anon_data_2);
            this.ustawienia_grupa_ustawienia.Controls.Add(this.anon_data);
            this.ustawienia_grupa_ustawienia.Controls.Add(this.cleanexit);
            this.ustawienia_grupa_ustawienia.Controls.Add(this.show_ip);
            this.ustawienia_grupa_ustawienia.Controls.Add(this.steamsearch);
            this.ustawienia_grupa_ustawienia.Controls.Add(this.always_on_top);
            this.ustawienia_grupa_ustawienia.Controls.Add(this.chpath);
            this.ustawienia_grupa_ustawienia.Controls.Add(this.path);
            this.ustawienia_grupa_ustawienia.Controls.Add(this.to_tray);
            this.ustawienia_grupa_ustawienia.Location = new System.Drawing.Point(8, 3);
            this.ustawienia_grupa_ustawienia.Name = "ustawienia_grupa_ustawienia";
            this.ustawienia_grupa_ustawienia.Size = new System.Drawing.Size(534, 229);
            this.ustawienia_grupa_ustawienia.TabIndex = 22;
            this.ustawienia_grupa_ustawienia.TabStop = false;
            this.ustawienia_grupa_ustawienia.Text = "ustawienia_grupa_ustawienia";
            // 
            // skip_profiles
            // 
            this.skip_profiles.AutoSize = true;
            this.skip_profiles.Location = new System.Drawing.Point(6, 111);
            this.skip_profiles.Name = "skip_profiles";
            this.skip_profiles.Size = new System.Drawing.Size(123, 17);
            this.skip_profiles.TabIndex = 36;
            this.skip_profiles.Text = "Skip profile selection";
            this.skip_profiles.UseVisualStyleBackColor = true;
            this.skip_profiles.CheckedChanged += new System.EventHandler(this.Skip_profiles_CheckedChanged);
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(325, 200);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(70, 23);
            this.browse.TabIndex = 35;
            this.browse.Text = "browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // anon_data_2
            // 
            this.anon_data_2.AutoSize = true;
            this.anon_data_2.Location = new System.Drawing.Point(6, 154);
            this.anon_data_2.Name = "anon_data_2";
            this.anon_data_2.Size = new System.Drawing.Size(70, 13);
            this.anon_data_2.TabIndex = 33;
            this.anon_data_2.TabStop = true;
            this.anon_data_2.Text = "anon_data_2";
            this.anon_data_2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.anon_data_2_LinkClicked);
            // 
            // anon_data
            // 
            this.anon_data.AutoSize = true;
            this.anon_data.Checked = true;
            this.anon_data.CheckState = System.Windows.Forms.CheckState.Checked;
            this.anon_data.Location = new System.Drawing.Point(6, 134);
            this.anon_data.Name = "anon_data";
            this.anon_data.Size = new System.Drawing.Size(77, 17);
            this.anon_data.TabIndex = 32;
            this.anon_data.Text = "anon_data";
            this.anon_data.UseVisualStyleBackColor = true;
            this.anon_data.CheckedChanged += new System.EventHandler(this.anon_data_CheckedChanged);
            // 
            // cleanexit
            // 
            this.cleanexit.AutoSize = true;
            this.cleanexit.Checked = true;
            this.cleanexit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cleanexit.Location = new System.Drawing.Point(6, 88);
            this.cleanexit.Name = "cleanexit";
            this.cleanexit.Size = new System.Drawing.Size(68, 17);
            this.cleanexit.TabIndex = 31;
            this.cleanexit.Text = "cleanexit";
            this.cleanexit.UseVisualStyleBackColor = true;
            this.cleanexit.CheckedChanged += new System.EventHandler(this.cleanexit_CheckedChanged);
            // 
            // show_ip
            // 
            this.show_ip.AutoSize = true;
            this.show_ip.Location = new System.Drawing.Point(6, 65);
            this.show_ip.Name = "show_ip";
            this.show_ip.Size = new System.Drawing.Size(65, 17);
            this.show_ip.TabIndex = 30;
            this.show_ip.Text = "show_ip";
            this.show_ip.UseVisualStyleBackColor = true;
            this.show_ip.CheckedChanged += new System.EventHandler(this.show_ip_CheckedChanged);
            // 
            // steamsearch
            // 
            this.steamsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.steamsearch.Location = new System.Drawing.Point(6, 200);
            this.steamsearch.Name = "steamsearch";
            this.steamsearch.Size = new System.Drawing.Size(207, 23);
            this.steamsearch.TabIndex = 29;
            this.steamsearch.Text = "steamsearch";
            this.steamsearch.UseVisualStyleBackColor = true;
            this.steamsearch.Click += new System.EventHandler(this.steamsearch_Click);
            // 
            // always_on_top
            // 
            this.always_on_top.AutoSize = true;
            this.always_on_top.Location = new System.Drawing.Point(6, 42);
            this.always_on_top.Name = "always_on_top";
            this.always_on_top.Size = new System.Drawing.Size(97, 17);
            this.always_on_top.TabIndex = 26;
            this.always_on_top.Text = "always_on_top";
            this.always_on_top.UseVisualStyleBackColor = true;
            this.always_on_top.CheckedChanged += new System.EventHandler(this.always_on_top_CheckedChanged);
            // 
            // chpath
            // 
            this.chpath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chpath.Location = new System.Drawing.Point(219, 200);
            this.chpath.Name = "chpath";
            this.chpath.Size = new System.Drawing.Size(100, 23);
            this.chpath.TabIndex = 24;
            this.chpath.Text = "Zmień";
            this.chpath.UseVisualStyleBackColor = true;
            this.chpath.Click += new System.EventHandler(this.chpath_Click);
            // 
            // path
            // 
            this.path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(5, 184);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(34, 13);
            this.path.TabIndex = 23;
            this.path.Text = "(brak)";
            // 
            // to_tray
            // 
            this.to_tray.AutoSize = true;
            this.to_tray.Location = new System.Drawing.Point(6, 19);
            this.to_tray.Name = "to_tray";
            this.to_tray.Size = new System.Drawing.Size(58, 17);
            this.to_tray.TabIndex = 21;
            this.to_tray.Text = "to_tray";
            this.to_tray.UseVisualStyleBackColor = true;
            this.to_tray.CheckedChanged += new System.EventHandler(this.to_tray_CheckedChanged);
            // 
            // about
            // 
            this.about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.about.Location = new System.Drawing.Point(658, 649);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(243, 23);
            this.about.TabIndex = 12;
            this.about.Text = "about";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.telnet_Click);
            // 
            // auto_backup_group
            // 
            this.auto_backup_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auto_backup_group.Controls.Add(this.backup_location_l);
            this.auto_backup_group.Controls.Add(this.backup_location);
            this.auto_backup_group.Controls.Add(this.backup_chat);
            this.auto_backup_group.Controls.Add(this.auto_backup_check);
            this.auto_backup_group.Controls.Add(this.backup_time);
            this.auto_backup_group.Location = new System.Drawing.Point(6, 8);
            this.auto_backup_group.Name = "auto_backup_group";
            this.auto_backup_group.Size = new System.Drawing.Size(896, 96);
            this.auto_backup_group.TabIndex = 32;
            this.auto_backup_group.TabStop = false;
            this.auto_backup_group.Text = "auto_backup_group";
            // 
            // backup_location_l
            // 
            this.backup_location_l.AutoSize = true;
            this.backup_location_l.Location = new System.Drawing.Point(6, 68);
            this.backup_location_l.Name = "backup_location_l";
            this.backup_location_l.Size = new System.Drawing.Size(197, 13);
            this.backup_location_l.TabIndex = 12;
            this.backup_location_l.Text = "Backups location (no backslash at end):";
            // 
            // backup_location
            // 
            this.backup_location.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backup_location.Location = new System.Drawing.Point(209, 65);
            this.backup_location.Name = "backup_location";
            this.backup_location.Size = new System.Drawing.Size(681, 20);
            this.backup_location.TabIndex = 11;
            this.backup_location.TextChanged += new System.EventHandler(this.backup_location_TextChanged);
            // 
            // backup_chat
            // 
            this.backup_chat.AutoSize = true;
            this.backup_chat.Enabled = false;
            this.backup_chat.Location = new System.Drawing.Point(9, 42);
            this.backup_chat.Name = "backup_chat";
            this.backup_chat.Size = new System.Drawing.Size(89, 17);
            this.backup_chat.TabIndex = 10;
            this.backup_chat.Text = "backup_chat";
            this.backup_chat.UseVisualStyleBackColor = true;
            this.backup_chat.CheckedChanged += new System.EventHandler(this.backup_chat_CheckedChanged);
            // 
            // auto_backup_check
            // 
            this.auto_backup_check.AutoSize = true;
            this.auto_backup_check.Location = new System.Drawing.Point(9, 19);
            this.auto_backup_check.Name = "auto_backup_check";
            this.auto_backup_check.Size = new System.Drawing.Size(125, 17);
            this.auto_backup_check.TabIndex = 9;
            this.auto_backup_check.Text = "auto_backup_check";
            this.auto_backup_check.UseVisualStyleBackColor = true;
            this.auto_backup_check.CheckedChanged += new System.EventHandler(this.auto_backup_check_CheckedChanged);
            // 
            // backup_time
            // 
            this.backup_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backup_time.Enabled = false;
            this.backup_time.Location = new System.Drawing.Point(220, 14);
            this.backup_time.Maximum = 96;
            this.backup_time.Minimum = 1;
            this.backup_time.Name = "backup_time";
            this.backup_time.Size = new System.Drawing.Size(670, 45);
            this.backup_time.TabIndex = 8;
            this.backup_time.Value = 16;
            this.backup_time.Scroll += new System.EventHandler(this.backup_time_Scroll);
            // 
            // spawn_group
            // 
            this.spawn_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spawn_group.Controls.Add(this.spawn_now);
            this.spawn_group.Controls.Add(this.spawn_item);
            this.spawn_group.Location = new System.Drawing.Point(309, 414);
            this.spawn_group.Name = "spawn_group";
            this.spawn_group.Size = new System.Drawing.Size(592, 48);
            this.spawn_group.TabIndex = 21;
            this.spawn_group.TabStop = false;
            this.spawn_group.Text = "Spawn items";
            // 
            // spawn_now
            // 
            this.spawn_now.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spawn_now.Location = new System.Drawing.Point(465, 19);
            this.spawn_now.Name = "spawn_now";
            this.spawn_now.Size = new System.Drawing.Size(121, 21);
            this.spawn_now.TabIndex = 3;
            this.spawn_now.Text = "Spawn";
            this.spawn_now.UseVisualStyleBackColor = true;
            this.spawn_now.Click += new System.EventHandler(this.spawn_now_Click);
            // 
            // spawn_item
            // 
            this.spawn_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spawn_item.FormattingEnabled = true;
            this.spawn_item.Items.AddRange(new object[] {
            "  1 - zombieTemplateMale",
            "  2 - zombieWightFeral",
            "  3 - zombieWightFeralRadiated",
            "  4 - zombieBoe",
            "  5 - zombieBoeFeral",
            "  6 - zombieFootballPlayer",
            "  7 - zombieFemaleFat",
            "  8 - zombieFemaleFatFeral",
            "  9 - zombieJoe",
            "  10 - zombieJoeFeral",
            "  11 - zombieMoe",
            "  12 - zombieMoeFeral",
            "  13 - zombieArlene",
            "  14 - zombieArleneFeral",
            "  15 - zombieScreamer",
            "  16 - zombieScreamerFeral",
            "  17 - zombieDarlene",
            "  18 - zombieDarleneFeral",
            "  19 - zombieMarlene",
            "  20 - zombieMarleneFeral",
            "  21 - zombieYo",
            "  22 - zombieYoFeral",
            "  23 - zombieSteve",
            "  24 - zombieSteveFeral",
            "  25 - zombieSteveCrawler",
            "  26 - zombieSteveCrawlerFeral",
            "  27 - zombieBusinessMan",
            "  28 - zombieBusinessManFeral",
            "  29 - zombieSnow",
            "  30 - zombieSnowFeral",
            "  31 - zombieSpider",
            "  32 - zombieSpiderFeral",
            "  33 - zombieSpiderFeralRadiated",
            "  34 - zombieBurnt",
            "  35 - zombieNurse",
            "  36 - zombieNurseFeral",
            "  37 - zombieFatHawaiian",
            "  38 - zombieFatHawaiianFeral",
            "  39 - zombieFatCop",
            "  40 - zombieFatCopFeral",
            "  41 - zombieFatCopFeralRadiated",
            "  42 - zombieMaleHazmat",
            "  43 - zombieUtilityWorker",
            "  44 - zombieUtilityWorkerFeral",
            "  45 - zombieSoldier",
            "  46 - zombieSoldierFeral",
            "  47 - zombieSkateboarder",
            "  48 - zombieSkateboarderFeral",
            "  49 - zombieCheerleader",
            "  50 - zombieCheerleaderFeral",
            "  51 - zombieOldTimer",
            "  52 - zombieOldTimerFeral",
            "  53 - zombieBiker",
            "  54 - zombieFarmer",
            "  55 - zombieFarmerFeral",
            "  56 - zombieStripper",
            "  57 - zombieStripperFeral",
            "  58 - animalTemplateTimid",
            "  59 - animalStag",
            "  60 - animalRabbit",
            "  61 - animalChicken",
            "  62 - animalTemplateHostile",
            "  63 - animalZombieDog",
            "  64 - animalBear",
            "  65 - animalZombieBear",
            "  66 - animalWolf",
            "  67 - animalDireWolf",
            "  68 - animalZombieVulture",
            "  69 - animalSnake",
            "  70 - animalBoar",
            "  71 - supplyPlane",
            "  72 - minibike",
            "  73 - sc_General",
            "  74 - Backpack",
            "  75 - DroppedLootContainer",
            "  76 - EvisceratedRemains",
            "  77 - invisibleAnimal",
            "  78 - invisibleAnimalEnemy",
            "  79 - npcSurvivorTemplate",
            "  80 - npcSurvivorRanged",
            "  81 - npcBanditMelee",
            "  82 - npcBanditRanged",
            "  83 - npcBanditLeader",
            "  84 - npcTraderTemplate",
            "  85 - npcTraderJoel",
            "  86 - npcTraderRekt",
            "  87 - npcTraderBob",
            "  88 - npcTraderJimmy",
            "  89 - npcTraderHugh"});
            this.spawn_item.Location = new System.Drawing.Point(6, 19);
            this.spawn_item.Name = "spawn_item";
            this.spawn_item.Size = new System.Drawing.Size(151, 21);
            this.spawn_item.TabIndex = 0;
            // 
            // telnet_group
            // 
            this.telnet_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telnet_group.Controls.Add(this.godzina);
            this.telnet_group.Controls.Add(this.dzien);
            this.telnet_group.Controls.Add(this.telnet_connect);
            this.telnet_group.Controls.Add(this.dzien_bar);
            this.telnet_group.Controls.Add(this.godzina_bar);
            this.telnet_group.Location = new System.Drawing.Point(309, 517);
            this.telnet_group.Name = "telnet_group";
            this.telnet_group.Size = new System.Drawing.Size(592, 140);
            this.telnet_group.TabIndex = 19;
            this.telnet_group.TabStop = false;
            this.telnet_group.Text = "Change time";
            // 
            // godzina
            // 
            this.godzina.AutoSize = true;
            this.godzina.Location = new System.Drawing.Point(15, 66);
            this.godzina.Name = "godzina";
            this.godzina.Size = new System.Drawing.Size(60, 13);
            this.godzina.TabIndex = 4;
            this.godzina.Text = "Hour [8:00]";
            // 
            // dzien
            // 
            this.dzien.AutoSize = true;
            this.dzien.Location = new System.Drawing.Point(17, 19);
            this.dzien.Name = "dzien";
            this.dzien.Size = new System.Drawing.Size(41, 13);
            this.dzien.TabIndex = 2;
            this.dzien.Text = "Day [1]";
            // 
            // telnet_connect
            // 
            this.telnet_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.telnet_connect.Location = new System.Drawing.Point(465, 113);
            this.telnet_connect.Name = "telnet_connect";
            this.telnet_connect.Size = new System.Drawing.Size(121, 21);
            this.telnet_connect.TabIndex = 0;
            this.telnet_connect.Text = "Set";
            this.telnet_connect.UseVisualStyleBackColor = true;
            this.telnet_connect.Click += new System.EventHandler(this.telnet_connect_Click);
            // 
            // dzien_bar
            // 
            this.dzien_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dzien_bar.Location = new System.Drawing.Point(6, 34);
            this.dzien_bar.Maximum = 365;
            this.dzien_bar.Minimum = 1;
            this.dzien_bar.Name = "dzien_bar";
            this.dzien_bar.Size = new System.Drawing.Size(580, 45);
            this.dzien_bar.TabIndex = 1;
            this.dzien_bar.Value = 1;
            this.dzien_bar.Scroll += new System.EventHandler(this.dzien_bar_Scroll);
            // 
            // godzina_bar
            // 
            this.godzina_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.godzina_bar.Location = new System.Drawing.Point(6, 82);
            this.godzina_bar.Maximum = 23;
            this.godzina_bar.Name = "godzina_bar";
            this.godzina_bar.Size = new System.Drawing.Size(580, 45);
            this.godzina_bar.TabIndex = 3;
            this.godzina_bar.Value = 8;
            this.godzina_bar.Scroll += new System.EventHandler(this.godzina_bar_Scroll);
            // 
            // cmd
            // 
            this.cmd.AcceptsReturn = true;
            this.cmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd.Location = new System.Drawing.Point(6, 447);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(689, 20);
            this.cmd.TabIndex = 17;
            this.cmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmd_KeyPress);
            // 
            // konsola
            // 
            this.konsola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.konsola.BackColor = System.Drawing.Color.Black;
            this.konsola.Cursor = System.Windows.Forms.Cursors.Default;
            this.konsola.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.konsola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.konsola.Location = new System.Drawing.Point(6, 19);
            this.konsola.Name = "konsola";
            this.konsola.ReadOnly = true;
            this.konsola.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.konsola.Size = new System.Drawing.Size(686, 427);
            this.konsola.TabIndex = 15;
            this.konsola.Text = "";
            this.konsola.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.Konsola_LinkClicked);
            this.konsola.TextChanged += new System.EventHandler(this.konsola_TextChanged);
            // 
            // startbar
            // 
            this.startbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startbar.Location = new System.Drawing.Point(3, 663);
            this.startbar.MarqueeAnimationSpeed = 1;
            this.startbar.Maximum = 3500;
            this.startbar.Name = "startbar";
            this.startbar.Size = new System.Drawing.Size(902, 18);
            this.startbar.TabIndex = 7;
            this.startbar.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.server_manage);
            this.tabControl.Controls.Add(this.ban_kick);
            this.tabControl.Controls.Add(this.main_page);
            this.tabControl.Controls.Add(this.strings_page);
            this.tabControl.Controls.Add(this.globalBanList);
            this.tabControl.Controls.Add(this.WebServer);
            this.tabControl.Controls.Add(this.tasks);
            this.tabControl.Controls.Add(this.backup_tab);
            this.tabControl.Controls.Add(this.srv_list);
            this.tabControl.Controls.Add(this.settings);
            this.tabControl.ImageList = this.ikony_naglowka;
            this.tabControl.ItemSize = new System.Drawing.Size(43, 43);
            this.tabControl.Location = new System.Drawing.Point(1, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(3, 3);
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(959, 692);
            this.tabControl.TabIndex = 22;
            // 
            // server_manage
            // 
            this.server_manage.BackColor = System.Drawing.SystemColors.Control;
            this.server_manage.Controls.Add(this.CommandsGroup);
            this.server_manage.Controls.Add(this.zoomup);
            this.server_manage.Controls.Add(this.overviewSplitter);
            this.server_manage.Controls.Add(this.Timers_Group);
            this.server_manage.Controls.Add(this.Server_Controls_Group);
            this.server_manage.Controls.Add(this.startbar);
            this.server_manage.ImageIndex = 0;
            this.server_manage.Location = new System.Drawing.Point(47, 4);
            this.server_manage.Name = "server_manage";
            this.server_manage.Size = new System.Drawing.Size(908, 684);
            this.server_manage.TabIndex = 7;
            // 
            // CommandsGroup
            // 
            this.CommandsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CommandsGroup.Controls.Add(this.usecmd);
            this.CommandsGroup.Controls.Add(this.commandslist);
            this.CommandsGroup.Location = new System.Drawing.Point(5, 467);
            this.CommandsGroup.Name = "CommandsGroup";
            this.CommandsGroup.Size = new System.Drawing.Size(166, 188);
            this.CommandsGroup.TabIndex = 23;
            this.CommandsGroup.TabStop = false;
            this.CommandsGroup.Text = "Commands";
            // 
            // usecmd
            // 
            this.usecmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.usecmd.Location = new System.Drawing.Point(85, 157);
            this.usecmd.Name = "usecmd";
            this.usecmd.Size = new System.Drawing.Size(75, 23);
            this.usecmd.TabIndex = 23;
            this.usecmd.Text = "Use ►";
            this.usecmd.UseVisualStyleBackColor = true;
            this.usecmd.Click += new System.EventHandler(this.usecmd_Click);
            // 
            // commandslist
            // 
            this.commandslist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandslist.FormattingEnabled = true;
            this.commandslist.Items.AddRange(new object[] {
            "local",
            "admin",
            "aiddebug",
            "audio",
            "ban",
            "buff",
            "buffplayer",
            "chunkcache",
            "commandpermission",
            "creativemenu",
            "DeathScreen",
            "debuff",
            "debuffplayer",
            "debugmenu",
            "debugweather",
            "dof",
            "enablescope",
            "exhausted",
            "exportitemicons",
            "gamestage",
            "getgamepref",
            "getgamestat",
            "gettime",
            "givequest",
            "giveself",
            "giveselfskillxp",
            "giveselfxp",
            "help",
            "kick",
            "kickall",
            "kill",
            "killall",
            "listgameobjects",
            "lights",
            "listents",
            "listplayerids",
            "listplayers",
            "listthreads",
            "loggamestate",
            "loglevel",
            "mem",
            "memcl",
            "pplist",
            "prefab",
            "profilenetwork",
            "profiling",
            "removequest",
            "repairchunkdensity",
            "saveworld",
            "say",
            "setgamepref",
            "setgamestat",
            "settargetfps",
            "settempunit",
            "settime",
            "showalbedo",
            "showchunkdata",
            "showClouds",
            "showhits",
            "shownexthordetime",
            "shownormals",
            "showspecular",
            "shutdown",
            "sounddebug",
            "spawnairdrop",
            "spawnentity",
            "spawnentityat",
            "spawnscouts",
            "SpawnScreen",
            "spawnsupplycrate",
            "spawnwanderinghorde",
            "spectrum",
            "stab",
            "starve",
            "staticmap",
            "switchview",
            "SystemInfo",
            "teleport",
            "teleportplayer",
            "thirsty",
            "traderarea",
            "updatelighton",
            "version",
            "visitmap",
            "water",
            "weather",
            "weathersurvival",
            "whitelist",
            "zip"});
            this.commandslist.Location = new System.Drawing.Point(6, 19);
            this.commandslist.Name = "commandslist";
            this.commandslist.Size = new System.Drawing.Size(154, 121);
            this.commandslist.TabIndex = 22;
            // 
            // zoomup
            // 
            this.zoomup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomup.Location = new System.Drawing.Point(884, 13);
            this.zoomup.Name = "zoomup";
            this.zoomup.Size = new System.Drawing.Size(22, 22);
            this.zoomup.TabIndex = 21;
            this.zoomup.Text = "▲";
            this.zoomup.UseVisualStyleBackColor = true;
            this.zoomup.Click += new System.EventHandler(this.zoomup_Click);
            // 
            // overviewSplitter
            // 
            this.overviewSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.overviewSplitter.Location = new System.Drawing.Point(177, 0);
            this.overviewSplitter.Name = "overviewSplitter";
            this.overviewSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // overviewSplitter.Panel1
            // 
            this.overviewSplitter.Panel1.Controls.Add(this.News_Group);
            this.overviewSplitter.Panel1.Controls.Add(this.Server_Status_Group);
            this.overviewSplitter.Panel1MinSize = 0;
            // 
            // overviewSplitter.Panel2
            // 
            this.overviewSplitter.Panel2.Controls.Add(this.Console_Group);
            this.overviewSplitter.Panel2MinSize = 0;
            this.overviewSplitter.Size = new System.Drawing.Size(707, 657);
            this.overviewSplitter.SplitterDistance = 171;
            this.overviewSplitter.SplitterWidth = 1;
            this.overviewSplitter.TabIndex = 21;
            // 
            // News_Group
            // 
            this.News_Group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.News_Group.Controls.Add(this.News_Feed_RichTextBox);
            this.News_Group.Location = new System.Drawing.Point(349, 8);
            this.News_Group.Name = "News_Group";
            this.News_Group.Size = new System.Drawing.Size(352, 160);
            this.News_Group.TabIndex = 19;
            this.News_Group.TabStop = false;
            this.News_Group.Text = "News";
            // 
            // News_Feed_RichTextBox
            // 
            this.News_Feed_RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.News_Feed_RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.News_Feed_RichTextBox.Location = new System.Drawing.Point(3, 16);
            this.News_Feed_RichTextBox.Name = "News_Feed_RichTextBox";
            this.News_Feed_RichTextBox.ReadOnly = true;
            this.News_Feed_RichTextBox.Size = new System.Drawing.Size(346, 141);
            this.News_Feed_RichTextBox.TabIndex = 0;
            this.News_Feed_RichTextBox.Text = "Downloading news...";
            this.News_Feed_RichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.newsbox_LinkClicked);
            // 
            // Server_Status_Group
            // 
            this.Server_Status_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Server_Status_Group.Controls.Add(this.osarch);
            this.Server_Status_Group.Controls.Add(this.telnetstatus);
            this.Server_Status_Group.Controls.Add(this.osver);
            this.Server_Status_Group.Controls.Add(this.status);
            this.Server_Status_Group.Controls.Add(this.twoje_ip);
            this.Server_Status_Group.Location = new System.Drawing.Point(3, 8);
            this.Server_Status_Group.Name = "Server_Status_Group";
            this.Server_Status_Group.Size = new System.Drawing.Size(340, 160);
            this.Server_Status_Group.TabIndex = 20;
            this.Server_Status_Group.TabStop = false;
            this.Server_Status_Group.Text = "Server status";
            // 
            // osarch
            // 
            this.osarch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.osarch.AutoSize = true;
            this.osarch.BackColor = System.Drawing.Color.Transparent;
            this.osarch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osarch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.osarch.Location = new System.Drawing.Point(6, 140);
            this.osarch.Name = "osarch";
            this.osarch.Size = new System.Drawing.Size(39, 13);
            this.osarch.TabIndex = 5;
            this.osarch.Text = "osarch";
            // 
            // telnetstatus
            // 
            this.telnetstatus.AutoSize = true;
            this.telnetstatus.BackColor = System.Drawing.Color.Transparent;
            this.telnetstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telnetstatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.telnetstatus.Location = new System.Drawing.Point(6, 38);
            this.telnetstatus.Name = "telnetstatus";
            this.telnetstatus.Size = new System.Drawing.Size(61, 13);
            this.telnetstatus.TabIndex = 4;
            this.telnetstatus.Text = "telnetstatus";
            // 
            // osver
            // 
            this.osver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.osver.AutoSize = true;
            this.osver.BackColor = System.Drawing.Color.Transparent;
            this.osver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osver.ForeColor = System.Drawing.SystemColors.WindowText;
            this.osver.Location = new System.Drawing.Point(6, 120);
            this.osver.Name = "osver";
            this.osver.Size = new System.Drawing.Size(33, 13);
            this.osver.TabIndex = 3;
            this.osver.Text = "osver";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.status.ForeColor = System.Drawing.SystemColors.WindowText;
            this.status.Location = new System.Drawing.Point(6, 18);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(35, 13);
            this.status.TabIndex = 2;
            this.status.Text = "status";
            // 
            // Console_Group
            // 
            this.Console_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Console_Group.BackColor = System.Drawing.SystemColors.Control;
            this.Console_Group.Controls.Add(this.konsola);
            this.Console_Group.Controls.Add(this.cmd);
            this.Console_Group.Location = new System.Drawing.Point(3, 8);
            this.Console_Group.Name = "Console_Group";
            this.Console_Group.Size = new System.Drawing.Size(698, 478);
            this.Console_Group.TabIndex = 18;
            this.Console_Group.TabStop = false;
            this.Console_Group.Text = "Console";
            // 
            // Timers_Group
            // 
            this.Timers_Group.Controls.Add(this.Auto_Command_Timer);
            this.Timers_Group.Controls.Add(this.Whitelist_Update_Timer);
            this.Timers_Group.Controls.Add(this.Whitelist_Update_Label);
            this.Timers_Group.Controls.Add(this.Auto_Restart_Timer);
            this.Timers_Group.Controls.Add(this.Auto_Restart_Timer_Label);
            this.Timers_Group.Controls.Add(this.Backup_Timer);
            this.Timers_Group.Controls.Add(this.Backup_Timer_Label);
            this.Timers_Group.Controls.Add(this.SQL_Export_Timer_Label);
            this.Timers_Group.Controls.Add(this.SQL_Export_Timer);
            this.Timers_Group.Controls.Add(this.Auto_Command_Timer_Label);
            this.Timers_Group.Location = new System.Drawing.Point(5, 266);
            this.Timers_Group.Name = "Timers_Group";
            this.Timers_Group.Size = new System.Drawing.Size(166, 195);
            this.Timers_Group.TabIndex = 11;
            this.Timers_Group.TabStop = false;
            this.Timers_Group.Text = "timers_g";
            // 
            // Auto_Command_Timer
            // 
            this.Auto_Command_Timer.AutoSize = true;
            this.Auto_Command_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Auto_Command_Timer.Location = new System.Drawing.Point(5, 29);
            this.Auto_Command_Timer.Name = "Auto_Command_Timer";
            this.Auto_Command_Timer.Size = new System.Drawing.Size(49, 20);
            this.Auto_Command_Timer.TabIndex = 14;
            this.Auto_Command_Timer.Text = "00:00";
            // 
            // Whitelist_Update_Timer
            // 
            this.Whitelist_Update_Timer.AutoSize = true;
            this.Whitelist_Update_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Whitelist_Update_Timer.Location = new System.Drawing.Point(5, 163);
            this.Whitelist_Update_Timer.Name = "Whitelist_Update_Timer";
            this.Whitelist_Update_Timer.Size = new System.Drawing.Size(49, 20);
            this.Whitelist_Update_Timer.TabIndex = 13;
            this.Whitelist_Update_Timer.Text = "00:00";
            // 
            // Whitelist_Update_Label
            // 
            this.Whitelist_Update_Label.AutoSize = true;
            this.Whitelist_Update_Label.Location = new System.Drawing.Point(6, 150);
            this.Whitelist_Update_Label.Name = "Whitelist_Update_Label";
            this.Whitelist_Update_Label.Size = new System.Drawing.Size(125, 13);
            this.Whitelist_Update_Label.TabIndex = 12;
            this.Whitelist_Update_Label.Text = "Next Whitelist Update In:";
            // 
            // Auto_Restart_Timer
            // 
            this.Auto_Restart_Timer.AutoSize = true;
            this.Auto_Restart_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Auto_Restart_Timer.Location = new System.Drawing.Point(5, 130);
            this.Auto_Restart_Timer.Name = "Auto_Restart_Timer";
            this.Auto_Restart_Timer.Size = new System.Drawing.Size(71, 20);
            this.Auto_Restart_Timer.TabIndex = 11;
            this.Auto_Restart_Timer.Text = "00:00:00";
            // 
            // Auto_Restart_Timer_Label
            // 
            this.Auto_Restart_Timer_Label.AutoSize = true;
            this.Auto_Restart_Timer_Label.Location = new System.Drawing.Point(6, 117);
            this.Auto_Restart_Timer_Label.Name = "Auto_Restart_Timer_Label";
            this.Auto_Restart_Timer_Label.Size = new System.Drawing.Size(106, 13);
            this.Auto_Restart_Timer_Label.TabIndex = 10;
            this.Auto_Restart_Timer_Label.Text = "Next Auto Restart In:";
            // 
            // Backup_Timer
            // 
            this.Backup_Timer.AutoSize = true;
            this.Backup_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Backup_Timer.Location = new System.Drawing.Point(5, 97);
            this.Backup_Timer.Name = "Backup_Timer";
            this.Backup_Timer.Size = new System.Drawing.Size(71, 20);
            this.Backup_Timer.TabIndex = 9;
            this.Backup_Timer.Text = "00:00:00";
            // 
            // Backup_Timer_Label
            // 
            this.Backup_Timer_Label.AutoSize = true;
            this.Backup_Timer_Label.Location = new System.Drawing.Point(6, 84);
            this.Backup_Timer_Label.Name = "Backup_Timer_Label";
            this.Backup_Timer_Label.Size = new System.Drawing.Size(84, 13);
            this.Backup_Timer_Label.TabIndex = 8;
            this.Backup_Timer_Label.Text = "Next Backup In:";
            // 
            // SQL_Export_Timer_Label
            // 
            this.SQL_Export_Timer_Label.AutoSize = true;
            this.SQL_Export_Timer_Label.Location = new System.Drawing.Point(6, 49);
            this.SQL_Export_Timer_Label.Name = "SQL_Export_Timer_Label";
            this.SQL_Export_Timer_Label.Size = new System.Drawing.Size(101, 13);
            this.SQL_Export_Timer_Label.TabIndex = 1;
            this.SQL_Export_Timer_Label.Text = "Next SQL Export In:";
            // 
            // SQL_Export_Timer
            // 
            this.SQL_Export_Timer.AutoSize = true;
            this.SQL_Export_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SQL_Export_Timer.Location = new System.Drawing.Point(5, 64);
            this.SQL_Export_Timer.Name = "SQL_Export_Timer";
            this.SQL_Export_Timer.Size = new System.Drawing.Size(49, 20);
            this.SQL_Export_Timer.TabIndex = 4;
            this.SQL_Export_Timer.Text = "00:00";
            // 
            // Auto_Command_Timer_Label
            // 
            this.Auto_Command_Timer_Label.AutoSize = true;
            this.Auto_Command_Timer_Label.Location = new System.Drawing.Point(6, 16);
            this.Auto_Command_Timer_Label.Name = "Auto_Command_Timer_Label";
            this.Auto_Command_Timer_Label.Size = new System.Drawing.Size(94, 13);
            this.Auto_Command_Timer_Label.TabIndex = 0;
            this.Auto_Command_Timer_Label.Text = "Auto Command In:";
            // 
            // Server_Controls_Group
            // 
            this.Server_Controls_Group.Controls.Add(this.Start_7DSM_With_Windows_CheckBox);
            this.Server_Controls_Group.Controls.Add(this.Start_With_7DSM_CheckBox);
            this.Server_Controls_Group.Controls.Add(this.Start_Server_Button);
            this.Server_Controls_Group.Controls.Add(this.Shutdown_Server_Button);
            this.Server_Controls_Group.Controls.Add(this.Connect_Running_Server_Button);
            this.Server_Controls_Group.Controls.Add(this.Save_Logs_CheckBox);
            this.Server_Controls_Group.Controls.Add(this.Kill_Server_Process);
            this.Server_Controls_Group.Location = new System.Drawing.Point(5, 8);
            this.Server_Controls_Group.Name = "Server_Controls_Group";
            this.Server_Controls_Group.Size = new System.Drawing.Size(166, 252);
            this.Server_Controls_Group.TabIndex = 12;
            this.Server_Controls_Group.TabStop = false;
            this.Server_Controls_Group.Text = "Server";
            // 
            // Start_7DSM_With_Windows_CheckBox
            // 
            this.Start_7DSM_With_Windows_CheckBox.AutoSize = true;
            this.Start_7DSM_With_Windows_CheckBox.Location = new System.Drawing.Point(6, 157);
            this.Start_7DSM_With_Windows_CheckBox.Name = "Start_7DSM_With_Windows_CheckBox";
            this.Start_7DSM_With_Windows_CheckBox.Size = new System.Drawing.Size(153, 17);
            this.Start_7DSM_With_Windows_CheckBox.TabIndex = 20;
            this.Start_7DSM_With_Windows_CheckBox.Text = "Start 7DSM With Windows";
            this.Start_7DSM_With_Windows_CheckBox.UseVisualStyleBackColor = true;
            this.Start_7DSM_With_Windows_CheckBox.CheckedChanged += new System.EventHandler(this.start_with_win_CheckedChanged);
            // 
            // Start_With_7DSM_CheckBox
            // 
            this.Start_With_7DSM_CheckBox.AutoSize = true;
            this.Start_With_7DSM_CheckBox.Location = new System.Drawing.Point(6, 134);
            this.Start_With_7DSM_CheckBox.Name = "Start_With_7DSM_CheckBox";
            this.Start_With_7DSM_CheckBox.Size = new System.Drawing.Size(140, 17);
            this.Start_With_7DSM_CheckBox.TabIndex = 19;
            this.Start_With_7DSM_CheckBox.Text = "Start Server With 7DSM";
            this.Start_With_7DSM_CheckBox.UseVisualStyleBackColor = true;
            this.Start_With_7DSM_CheckBox.CheckedChanged += new System.EventHandler(this.start_with_7dsm_CheckedChanged);
            // 
            // Start_Server_Button
            // 
            this.Start_Server_Button.Location = new System.Drawing.Point(6, 17);
            this.Start_Server_Button.Name = "Start_Server_Button";
            this.Start_Server_Button.Size = new System.Drawing.Size(152, 23);
            this.Start_Server_Button.TabIndex = 4;
            this.Start_Server_Button.Text = "Start Server";
            this.Start_Server_Button.UseVisualStyleBackColor = true;
            this.Start_Server_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Shutdown_Server_Button
            // 
            this.Shutdown_Server_Button.Enabled = false;
            this.Shutdown_Server_Button.Location = new System.Drawing.Point(6, 46);
            this.Shutdown_Server_Button.Name = "Shutdown_Server_Button";
            this.Shutdown_Server_Button.Size = new System.Drawing.Size(152, 23);
            this.Shutdown_Server_Button.TabIndex = 5;
            this.Shutdown_Server_Button.Text = "Shutdown Server";
            this.Shutdown_Server_Button.UseVisualStyleBackColor = true;
            this.Shutdown_Server_Button.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Connect_Running_Server_Button
            // 
            this.Connect_Running_Server_Button.Location = new System.Drawing.Point(6, 75);
            this.Connect_Running_Server_Button.Name = "Connect_Running_Server_Button";
            this.Connect_Running_Server_Button.Size = new System.Drawing.Size(152, 23);
            this.Connect_Running_Server_Button.TabIndex = 18;
            this.Connect_Running_Server_Button.Text = "Connect To Running Server";
            this.Connect_Running_Server_Button.UseVisualStyleBackColor = true;
            this.Connect_Running_Server_Button.Click += new System.EventHandler(this.Reboot_con_Click);
            // 
            // Save_Logs_CheckBox
            // 
            this.Save_Logs_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save_Logs_CheckBox.AutoSize = true;
            this.Save_Logs_CheckBox.Location = new System.Drawing.Point(6, 229);
            this.Save_Logs_CheckBox.Name = "Save_Logs_CheckBox";
            this.Save_Logs_CheckBox.Size = new System.Drawing.Size(112, 17);
            this.Save_Logs_CheckBox.TabIndex = 8;
            this.Save_Logs_CheckBox.Text = "Save Logs To File";
            this.Save_Logs_CheckBox.UseVisualStyleBackColor = true;
            this.Save_Logs_CheckBox.CheckedChanged += new System.EventHandler(this.save_logfiles_2_CheckedChanged);
            // 
            // Kill_Server_Process
            // 
            this.Kill_Server_Process.Location = new System.Drawing.Point(76, 104);
            this.Kill_Server_Process.Name = "Kill_Server_Process";
            this.Kill_Server_Process.Size = new System.Drawing.Size(82, 24);
            this.Kill_Server_Process.TabIndex = 6;
            this.Kill_Server_Process.Text = "Kill Process";
            this.Kill_Server_Process.UseVisualStyleBackColor = true;
            this.Kill_Server_Process.Click += new System.EventHandler(this.kill_proccess_Click);
            // 
            // ban_kick
            // 
            this.ban_kick.BackColor = System.Drawing.SystemColors.Control;
            this.ban_kick.Controls.Add(this.Chat_Group);
            this.ban_kick.Controls.Add(this.all_players_l);
            this.ban_kick.Controls.Add(this.online_l);
            this.ban_kick.Controls.Add(this.All_Players_List);
            this.ban_kick.Controls.Add(this.player_g);
            this.ban_kick.Controls.Add(this.telnet_group);
            this.ban_kick.Controls.Add(this.kickgroup);
            this.ban_kick.Controls.Add(this.spawn_group);
            this.ban_kick.Controls.Add(this.bantime_slider);
            this.ban_kick.Controls.Add(this.Online_Player_List);
            this.ban_kick.ImageIndex = 2;
            this.ban_kick.Location = new System.Drawing.Point(47, 4);
            this.ban_kick.Name = "ban_kick";
            this.ban_kick.Size = new System.Drawing.Size(908, 684);
            this.ban_kick.TabIndex = 5;
            // 
            // Chat_Group
            // 
            this.Chat_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chat_Group.BackColor = System.Drawing.SystemColors.Control;
            this.Chat_Group.Controls.Add(this.chat);
            this.Chat_Group.Controls.Add(this.chat_text);
            this.Chat_Group.Location = new System.Drawing.Point(309, 8);
            this.Chat_Group.Name = "Chat_Group";
            this.Chat_Group.Size = new System.Drawing.Size(592, 253);
            this.Chat_Group.TabIndex = 26;
            this.Chat_Group.TabStop = false;
            this.Chat_Group.Text = "chat_g";
            // 
            // chat
            // 
            this.chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chat.BackColor = System.Drawing.Color.Black;
            this.chat.Cursor = System.Windows.Forms.Cursors.Default;
            this.chat.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.chat.Location = new System.Drawing.Point(6, 19);
            this.chat.Name = "chat";
            this.chat.ReadOnly = true;
            this.chat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.chat.Size = new System.Drawing.Size(581, 202);
            this.chat.TabIndex = 15;
            this.chat.Text = "";
            this.chat.TextChanged += new System.EventHandler(this.chat_TextChanged);
            // 
            // chat_text
            // 
            this.chat_text.AcceptsReturn = true;
            this.chat_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chat_text.Location = new System.Drawing.Point(6, 227);
            this.chat_text.Name = "chat_text";
            this.chat_text.Size = new System.Drawing.Size(580, 20);
            this.chat_text.TabIndex = 17;
            this.chat_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chat_text_KeyPress);
            // 
            // all_players_l
            // 
            this.all_players_l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.all_players_l.AutoSize = true;
            this.all_players_l.Location = new System.Drawing.Point(5, 343);
            this.all_players_l.Name = "all_players_l";
            this.all_players_l.Size = new System.Drawing.Size(57, 13);
            this.all_players_l.TabIndex = 25;
            this.all_players_l.Text = "All players:";
            // 
            // online_l
            // 
            this.online_l.AutoSize = true;
            this.online_l.Location = new System.Drawing.Point(5, 11);
            this.online_l.Name = "online_l";
            this.online_l.Size = new System.Drawing.Size(76, 13);
            this.online_l.TabIndex = 24;
            this.online_l.Text = "Online players:";
            // 
            // All_Players_List
            // 
            this.All_Players_List.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.All_Players_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.All_Players_List.FullRowSelect = true;
            this.All_Players_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.All_Players_List.HideSelection = false;
            this.All_Players_List.Location = new System.Drawing.Point(8, 359);
            this.All_Players_List.MultiSelect = false;
            this.All_Players_List.Name = "All_Players_List";
            this.All_Players_List.Size = new System.Drawing.Size(295, 298);
            this.All_Players_List.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.All_Players_List.TabIndex = 23;
            this.All_Players_List.UseCompatibleStateImageBehavior = false;
            this.All_Players_List.View = System.Windows.Forms.View.Details;
            this.All_Players_List.SelectedIndexChanged += new System.EventHandler(this.all_players_list_SelectedIndexChanged);
            this.All_Players_List.Click += new System.EventHandler(this.all_players_list_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Login";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SteamID";
            this.columnHeader2.Width = 179;
            // 
            // player_g
            // 
            this.player_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player_g.Controls.Add(this.thirsty_player);
            this.player_g.Controls.Add(this.starve_player);
            this.player_g.Controls.Add(this.kill_player);
            this.player_g.Location = new System.Drawing.Point(309, 468);
            this.player_g.Name = "player_g";
            this.player_g.Size = new System.Drawing.Size(592, 43);
            this.player_g.TabIndex = 22;
            this.player_g.TabStop = false;
            this.player_g.Text = "Player";
            // 
            // thirsty_player
            // 
            this.thirsty_player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thirsty_player.Location = new System.Drawing.Point(465, 19);
            this.thirsty_player.Name = "thirsty_player";
            this.thirsty_player.Size = new System.Drawing.Size(121, 21);
            this.thirsty_player.TabIndex = 5;
            this.thirsty_player.Text = "Thirsty";
            this.thirsty_player.UseVisualStyleBackColor = true;
            this.thirsty_player.Click += new System.EventHandler(this.thirsty_player_Click);
            // 
            // starve_player
            // 
            this.starve_player.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.starve_player.Location = new System.Drawing.Point(235, 19);
            this.starve_player.Name = "starve_player";
            this.starve_player.Size = new System.Drawing.Size(121, 21);
            this.starve_player.TabIndex = 4;
            this.starve_player.Text = "Starve";
            this.starve_player.UseVisualStyleBackColor = true;
            this.starve_player.Click += new System.EventHandler(this.starve_player_Click);
            // 
            // kill_player
            // 
            this.kill_player.Location = new System.Drawing.Point(6, 19);
            this.kill_player.Name = "kill_player";
            this.kill_player.Size = new System.Drawing.Size(121, 21);
            this.kill_player.TabIndex = 3;
            this.kill_player.Text = "Kill";
            this.kill_player.UseVisualStyleBackColor = true;
            this.kill_player.Click += new System.EventHandler(this.kill_player_Click);
            // 
            // kickgroup
            // 
            this.kickgroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kickgroup.Controls.Add(this.kick);
            this.kickgroup.Controls.Add(this.powod);
            this.kickgroup.Location = new System.Drawing.Point(309, 359);
            this.kickgroup.Name = "kickgroup";
            this.kickgroup.Size = new System.Drawing.Size(592, 49);
            this.kickgroup.TabIndex = 10;
            this.kickgroup.TabStop = false;
            this.kickgroup.Text = "KICK";
            // 
            // kick
            // 
            this.kick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kick.Location = new System.Drawing.Point(465, 21);
            this.kick.Name = "kick";
            this.kick.Size = new System.Drawing.Size(121, 21);
            this.kick.TabIndex = 5;
            this.kick.Text = "KICK";
            this.kick.UseVisualStyleBackColor = false;
            this.kick.Click += new System.EventHandler(this.kick_Click);
            // 
            // powod
            // 
            this.powod.FormattingEnabled = true;
            this.powod.Items.AddRange(new object[] {
            "SPAMING",
            "Cheating",
            "Griefing",
            "Swearing",
            "Amazingly_stupid"});
            this.powod.Location = new System.Drawing.Point(6, 21);
            this.powod.Name = "powod";
            this.powod.Size = new System.Drawing.Size(151, 21);
            this.powod.TabIndex = 7;
            // 
            // bantime_slider
            // 
            this.bantime_slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bantime_slider.Controls.Add(this.bantime);
            this.bantime_slider.Controls.Add(this.ban);
            this.bantime_slider.Controls.Add(this.ban_slide);
            this.bantime_slider.Location = new System.Drawing.Point(309, 267);
            this.bantime_slider.Name = "bantime_slider";
            this.bantime_slider.Size = new System.Drawing.Size(592, 86);
            this.bantime_slider.TabIndex = 9;
            this.bantime_slider.TabStop = false;
            this.bantime_slider.Text = "BAN";
            // 
            // bantime
            // 
            this.bantime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bantime.FormattingEnabled = true;
            this.bantime.Items.AddRange(new object[] {
            "minutes",
            "hours",
            "days",
            "weeks",
            "months",
            "years"});
            this.bantime.Location = new System.Drawing.Point(6, 55);
            this.bantime.Name = "bantime";
            this.bantime.Size = new System.Drawing.Size(151, 21);
            this.bantime.TabIndex = 8;
            // 
            // ban
            // 
            this.ban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ban.BackColor = System.Drawing.Color.LightCoral;
            this.ban.Location = new System.Drawing.Point(465, 54);
            this.ban.Name = "ban";
            this.ban.Size = new System.Drawing.Size(121, 21);
            this.ban.TabIndex = 4;
            this.ban.Text = "BAN";
            this.ban.UseVisualStyleBackColor = false;
            this.ban.Click += new System.EventHandler(this.ban_Click);
            // 
            // ban_slide
            // 
            this.ban_slide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ban_slide.Location = new System.Drawing.Point(6, 19);
            this.ban_slide.Maximum = 60;
            this.ban_slide.Minimum = 1;
            this.ban_slide.Name = "ban_slide";
            this.ban_slide.Size = new System.Drawing.Size(580, 45);
            this.ban_slide.TabIndex = 9;
            this.ban_slide.Value = 1;
            this.ban_slide.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // Online_Player_List
            // 
            this.Online_Player_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Online_Player_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.login_header,
            this.steamid_header});
            this.Online_Player_List.FullRowSelect = true;
            this.Online_Player_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Online_Player_List.HideSelection = false;
            this.Online_Player_List.Location = new System.Drawing.Point(8, 27);
            this.Online_Player_List.MultiSelect = false;
            this.Online_Player_List.Name = "Online_Player_List";
            this.Online_Player_List.Size = new System.Drawing.Size(295, 296);
            this.Online_Player_List.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Online_Player_List.TabIndex = 0;
            this.Online_Player_List.UseCompatibleStateImageBehavior = false;
            this.Online_Player_List.View = System.Windows.Forms.View.Details;
            this.Online_Player_List.SelectedIndexChanged += new System.EventHandler(this.players_list_SelectedIndexChanged);
            this.Online_Player_List.Click += new System.EventHandler(this.players_list_Click);
            // 
            // login_header
            // 
            this.login_header.Text = "Login";
            this.login_header.Width = 110;
            // 
            // steamid_header
            // 
            this.steamid_header.Text = "SteamID";
            this.steamid_header.Width = 179;
            // 
            // main_page
            // 
            this.main_page.BackColor = System.Drawing.SystemColors.Control;
            this.main_page.Controls.Add(this.main_page_opts);
            this.main_page.ImageIndex = 1;
            this.main_page.Location = new System.Drawing.Point(47, 4);
            this.main_page.Name = "main_page";
            this.main_page.Size = new System.Drawing.Size(908, 684);
            this.main_page.TabIndex = 11;
            // 
            // main_page_opts
            // 
            this.main_page_opts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_page_opts.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.main_page_opts.Controls.Add(this.game_opts);
            this.main_page_opts.Controls.Add(this.server_opts);
            this.main_page_opts.Controls.Add(this.net_opts);
            this.main_page_opts.ImageList = this.ikony_naglowka;
            this.main_page_opts.ItemSize = new System.Drawing.Size(46, 46);
            this.main_page_opts.Location = new System.Drawing.Point(3, 0);
            this.main_page_opts.Name = "main_page_opts";
            this.main_page_opts.Padding = new System.Drawing.Point(3, 3);
            this.main_page_opts.SelectedIndex = 0;
            this.main_page_opts.Size = new System.Drawing.Size(905, 684);
            this.main_page_opts.TabIndex = 0;
            // 
            // game_opts
            // 
            this.game_opts.Controls.Add(this.reserved_g);
            this.game_opts.Controls.Add(this.PlayerKillingMode_g);
            this.game_opts.Controls.Add(this.spawn_p_l);
            this.game_opts.Controls.Add(this.AirDropFrequency_g);
            this.game_opts.Controls.Add(this.LandClaim);
            this.game_opts.Controls.Add(this.LootRespawnDays_g);
            this.game_opts.Controls.Add(this.LootAbundance_g);
            this.game_opts.Controls.Add(this.maxplgroup);
            this.game_opts.Controls.Add(this.trybgry);
            this.game_opts.Controls.Add(this.zomb_pie);
            this.game_opts.Controls.Add(this.nightpercentage_g);
            this.game_opts.Controls.Add(this.dlugoscdnia_g);
            this.game_opts.Controls.Add(this.bdm_g);
            this.game_opts.Controls.Add(this.dod_g);
            this.game_opts.Controls.Add(this.trudnoscgroup);
            this.game_opts.ImageIndex = 5;
            this.game_opts.Location = new System.Drawing.Point(4, 50);
            this.game_opts.Name = "game_opts";
            this.game_opts.Size = new System.Drawing.Size(897, 630);
            this.game_opts.TabIndex = 2;
            this.game_opts.UseVisualStyleBackColor = true;
            // 
            // reserved_g
            // 
            this.reserved_g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reserved_g.Controls.Add(this.ServerAdminSlotsPermission);
            this.reserved_g.Controls.Add(this.label2);
            this.reserved_g.Controls.Add(this.label3);
            this.reserved_g.Controls.Add(this.ServerAdminSlots);
            this.reserved_g.Controls.Add(this.ServerReservedSlotsPermission);
            this.reserved_g.Controls.Add(this.res_l2);
            this.reserved_g.Controls.Add(this.res_l1);
            this.reserved_g.Controls.Add(this.ServerReservedSlots);
            this.reserved_g.Location = new System.Drawing.Point(524, 4);
            this.reserved_g.Name = "reserved_g";
            this.reserved_g.Size = new System.Drawing.Size(366, 65);
            this.reserved_g.TabIndex = 51;
            this.reserved_g.TabStop = false;
            this.reserved_g.Text = "Server reserved slots";
            // 
            // ServerAdminSlotsPermission
            // 
            this.ServerAdminSlotsPermission.Location = new System.Drawing.Point(285, 38);
            this.ServerAdminSlotsPermission.Name = "ServerAdminSlotsPermission";
            this.ServerAdminSlotsPermission.Size = new System.Drawing.Size(31, 20);
            this.ServerAdminSlotsPermission.TabIndex = 7;
            this.ServerAdminSlotsPermission.Text = "0";
            this.ServerAdminSlotsPermission.TextChanged += new System.EventHandler(this.ServerAdminSlotsPermission_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "slots for admins with permissions level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reserve";
            // 
            // ServerAdminSlots
            // 
            this.ServerAdminSlots.Location = new System.Drawing.Point(59, 38);
            this.ServerAdminSlots.Name = "ServerAdminSlots";
            this.ServerAdminSlots.Size = new System.Drawing.Size(31, 20);
            this.ServerAdminSlots.TabIndex = 4;
            this.ServerAdminSlots.Text = "0";
            this.ServerAdminSlots.TextChanged += new System.EventHandler(this.ServerAdminSlots_TextChanged);
            // 
            // ServerReservedSlotsPermission
            // 
            this.ServerReservedSlotsPermission.Location = new System.Drawing.Point(285, 13);
            this.ServerReservedSlotsPermission.Name = "ServerReservedSlotsPermission";
            this.ServerReservedSlotsPermission.Size = new System.Drawing.Size(31, 20);
            this.ServerReservedSlotsPermission.TabIndex = 3;
            this.ServerReservedSlotsPermission.Text = "100";
            this.ServerReservedSlotsPermission.TextChanged += new System.EventHandler(this.ServerReservedSlotsPermission_TextChanged);
            // 
            // res_l2
            // 
            this.res_l2.AutoSize = true;
            this.res_l2.Location = new System.Drawing.Point(96, 16);
            this.res_l2.Name = "res_l2";
            this.res_l2.Size = new System.Drawing.Size(183, 13);
            this.res_l2.TabIndex = 2;
            this.res_l2.Text = "slots for players with permissions level";
            // 
            // res_l1
            // 
            this.res_l1.AutoSize = true;
            this.res_l1.Location = new System.Drawing.Point(6, 16);
            this.res_l1.Name = "res_l1";
            this.res_l1.Size = new System.Drawing.Size(47, 13);
            this.res_l1.TabIndex = 1;
            this.res_l1.Text = "Reserve";
            // 
            // ServerReservedSlots
            // 
            this.ServerReservedSlots.Location = new System.Drawing.Point(59, 13);
            this.ServerReservedSlots.Name = "ServerReservedSlots";
            this.ServerReservedSlots.Size = new System.Drawing.Size(31, 20);
            this.ServerReservedSlots.TabIndex = 0;
            this.ServerReservedSlots.Text = "0";
            this.ServerReservedSlots.TextChanged += new System.EventHandler(this.ServerReservedSlots_TextChanged);
            // 
            // PlayerKillingMode_g
            // 
            this.PlayerKillingMode_g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerKillingMode_g.Controls.Add(this.panel1);
            this.PlayerKillingMode_g.Location = new System.Drawing.Point(708, 310);
            this.PlayerKillingMode_g.Name = "PlayerKillingMode_g";
            this.PlayerKillingMode_g.Size = new System.Drawing.Size(179, 125);
            this.PlayerKillingMode_g.TabIndex = 50;
            this.PlayerKillingMode_g.TabStop = false;
            this.PlayerKillingMode_g.Text = "Players killing";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PlayerKillingMode_0);
            this.panel1.Controls.Add(this.PlayerKillingMode_1);
            this.panel1.Controls.Add(this.PlayerKillingMode_2);
            this.panel1.Controls.Add(this.PlayerKillingMode_3);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 95);
            this.panel1.TabIndex = 30;
            // 
            // PlayerKillingMode_0
            // 
            this.PlayerKillingMode_0.AutoSize = true;
            this.PlayerKillingMode_0.Location = new System.Drawing.Point(3, 3);
            this.PlayerKillingMode_0.Name = "PlayerKillingMode_0";
            this.PlayerKillingMode_0.Size = new System.Drawing.Size(68, 17);
            this.PlayerKillingMode_0.TabIndex = 24;
            this.PlayerKillingMode_0.Text = "No killing";
            this.PlayerKillingMode_0.UseVisualStyleBackColor = true;
            // 
            // PlayerKillingMode_1
            // 
            this.PlayerKillingMode_1.AutoSize = true;
            this.PlayerKillingMode_1.Location = new System.Drawing.Point(3, 26);
            this.PlayerKillingMode_1.Name = "PlayerKillingMode_1";
            this.PlayerKillingMode_1.Size = new System.Drawing.Size(71, 17);
            this.PlayerKillingMode_1.TabIndex = 25;
            this.PlayerKillingMode_1.Text = "Allies only";
            this.PlayerKillingMode_1.UseVisualStyleBackColor = true;
            // 
            // PlayerKillingMode_2
            // 
            this.PlayerKillingMode_2.AutoSize = true;
            this.PlayerKillingMode_2.Location = new System.Drawing.Point(3, 49);
            this.PlayerKillingMode_2.Name = "PlayerKillingMode_2";
            this.PlayerKillingMode_2.Size = new System.Drawing.Size(87, 17);
            this.PlayerKillingMode_2.TabIndex = 26;
            this.PlayerKillingMode_2.Text = "Enemies only";
            this.PlayerKillingMode_2.UseVisualStyleBackColor = true;
            // 
            // PlayerKillingMode_3
            // 
            this.PlayerKillingMode_3.AutoSize = true;
            this.PlayerKillingMode_3.Checked = true;
            this.PlayerKillingMode_3.Location = new System.Drawing.Point(3, 72);
            this.PlayerKillingMode_3.Name = "PlayerKillingMode_3";
            this.PlayerKillingMode_3.Size = new System.Drawing.Size(85, 17);
            this.PlayerKillingMode_3.TabIndex = 27;
            this.PlayerKillingMode_3.TabStop = true;
            this.PlayerKillingMode_3.Text = "Kill everyone";
            this.PlayerKillingMode_3.UseVisualStyleBackColor = true;
            // 
            // spawn_p_l
            // 
            this.spawn_p_l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spawn_p_l.Controls.Add(this.PlayerSafeZoneHours_l);
            this.spawn_p_l.Controls.Add(this.PlayerSafeZoneLevel_l);
            this.spawn_p_l.Controls.Add(this.PlayerSafeZoneHours);
            this.spawn_p_l.Controls.Add(this.PlayerSafeZoneLevel);
            this.spawn_p_l.Location = new System.Drawing.Point(523, 500);
            this.spawn_p_l.Name = "spawn_p_l";
            this.spawn_p_l.Size = new System.Drawing.Size(366, 66);
            this.spawn_p_l.TabIndex = 49;
            this.spawn_p_l.TabStop = false;
            this.spawn_p_l.Text = "Spawning";
            // 
            // PlayerSafeZoneHours_l
            // 
            this.PlayerSafeZoneHours_l.AutoSize = true;
            this.PlayerSafeZoneHours_l.Location = new System.Drawing.Point(17, 42);
            this.PlayerSafeZoneHours_l.Name = "PlayerSafeZoneHours_l";
            this.PlayerSafeZoneHours_l.Size = new System.Drawing.Size(114, 13);
            this.PlayerSafeZoneHours_l.TabIndex = 3;
            this.PlayerSafeZoneHours_l.Text = "Player safe zone hours";
            // 
            // PlayerSafeZoneLevel_l
            // 
            this.PlayerSafeZoneLevel_l.AutoSize = true;
            this.PlayerSafeZoneLevel_l.Location = new System.Drawing.Point(17, 16);
            this.PlayerSafeZoneLevel_l.Name = "PlayerSafeZoneLevel_l";
            this.PlayerSafeZoneLevel_l.Size = new System.Drawing.Size(110, 13);
            this.PlayerSafeZoneLevel_l.TabIndex = 2;
            this.PlayerSafeZoneLevel_l.Text = "Player safe zone level";
            // 
            // PlayerSafeZoneHours
            // 
            this.PlayerSafeZoneHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerSafeZoneHours.Location = new System.Drawing.Point(302, 39);
            this.PlayerSafeZoneHours.Name = "PlayerSafeZoneHours";
            this.PlayerSafeZoneHours.Size = new System.Drawing.Size(54, 20);
            this.PlayerSafeZoneHours.TabIndex = 1;
            this.PlayerSafeZoneHours.Text = "5";
            this.PlayerSafeZoneHours.TextChanged += new System.EventHandler(this.PlayerSafeZoneHours_TextChanged);
            // 
            // PlayerSafeZoneLevel
            // 
            this.PlayerSafeZoneLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerSafeZoneLevel.Location = new System.Drawing.Point(302, 13);
            this.PlayerSafeZoneLevel.Name = "PlayerSafeZoneLevel";
            this.PlayerSafeZoneLevel.Size = new System.Drawing.Size(54, 20);
            this.PlayerSafeZoneLevel.TabIndex = 0;
            this.PlayerSafeZoneLevel.Text = "5";
            this.PlayerSafeZoneLevel.TextChanged += new System.EventHandler(this.PlayerSafeZoneLevel_TextChanged);
            // 
            // AirDropFrequency_g
            // 
            this.AirDropFrequency_g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AirDropFrequency_g.Controls.Add(this.AirDropFrequency);
            this.AirDropFrequency_g.Location = new System.Drawing.Point(524, 75);
            this.AirDropFrequency_g.Name = "AirDropFrequency_g";
            this.AirDropFrequency_g.Size = new System.Drawing.Size(366, 65);
            this.AirDropFrequency_g.TabIndex = 48;
            this.AirDropFrequency_g.TabStop = false;
            this.AirDropFrequency_g.Text = "AirDropFrequency_g";
            // 
            // AirDropFrequency
            // 
            this.AirDropFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AirDropFrequency.Location = new System.Drawing.Point(6, 14);
            this.AirDropFrequency.Maximum = 168;
            this.AirDropFrequency.Name = "AirDropFrequency";
            this.AirDropFrequency.Size = new System.Drawing.Size(354, 45);
            this.AirDropFrequency.TabIndex = 8;
            this.AirDropFrequency.Scroll += new System.EventHandler(this.AirDropFrequency_Scroll);
            // 
            // LandClaim
            // 
            this.LandClaim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LandClaim.Controls.Add(this.LandClaimDecayMode_g);
            this.LandClaim.Controls.Add(this.LandClaim_g);
            this.LandClaim.Controls.Add(this.LandClaimSize_g);
            this.LandClaim.Controls.Add(this.LandClaimDeadZone_g);
            this.LandClaim.Controls.Add(this.LandClaimExpiryTime_g);
            this.LandClaim.Location = new System.Drawing.Point(10, 381);
            this.LandClaim.Name = "LandClaim";
            this.LandClaim.Size = new System.Drawing.Size(508, 185);
            this.LandClaim.TabIndex = 39;
            this.LandClaim.TabStop = false;
            this.LandClaim.Text = "LandClaim";
            // 
            // LandClaimDecayMode_g
            // 
            this.LandClaimDecayMode_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LandClaimDecayMode_g.Controls.Add(this.Full_prot);
            this.LandClaimDecayMode_g.Controls.Add(this.Exponential);
            this.LandClaimDecayMode_g.Controls.Add(this.Linear);
            this.LandClaimDecayMode_g.Location = new System.Drawing.Point(6, 19);
            this.LandClaimDecayMode_g.Name = "LandClaimDecayMode_g";
            this.LandClaimDecayMode_g.Size = new System.Drawing.Size(342, 92);
            this.LandClaimDecayMode_g.TabIndex = 3;
            this.LandClaimDecayMode_g.TabStop = false;
            this.LandClaimDecayMode_g.Text = "LandClaimDecayMode_g";
            // 
            // Full_prot
            // 
            this.Full_prot.AutoSize = true;
            this.Full_prot.Location = new System.Drawing.Point(6, 64);
            this.Full_prot.Name = "Full_prot";
            this.Full_prot.Size = new System.Drawing.Size(65, 17);
            this.Full_prot.TabIndex = 2;
            this.Full_prot.Text = "Full_prot";
            this.Full_prot.UseVisualStyleBackColor = true;
            this.Full_prot.CheckedChanged += new System.EventHandler(this.Full_prot_CheckedChanged);
            // 
            // Exponential
            // 
            this.Exponential.AutoSize = true;
            this.Exponential.Location = new System.Drawing.Point(6, 41);
            this.Exponential.Name = "Exponential";
            this.Exponential.Size = new System.Drawing.Size(80, 17);
            this.Exponential.TabIndex = 1;
            this.Exponential.Text = "Exponential";
            this.Exponential.UseVisualStyleBackColor = true;
            this.Exponential.CheckedChanged += new System.EventHandler(this.Exponential_CheckedChanged);
            // 
            // Linear
            // 
            this.Linear.AutoSize = true;
            this.Linear.Checked = true;
            this.Linear.Location = new System.Drawing.Point(6, 18);
            this.Linear.Name = "Linear";
            this.Linear.Size = new System.Drawing.Size(54, 17);
            this.Linear.TabIndex = 0;
            this.Linear.TabStop = true;
            this.Linear.Text = "Linear";
            this.Linear.UseVisualStyleBackColor = true;
            this.Linear.CheckedChanged += new System.EventHandler(this.Linear_CheckedChanged);
            // 
            // LandClaim_g
            // 
            this.LandClaim_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LandClaim_g.Controls.Add(this.offline);
            this.LandClaim_g.Controls.Add(this.online);
            this.LandClaim_g.Controls.Add(this.LandClaimOfflineDurabilityModifier);
            this.LandClaim_g.Controls.Add(this.LandClaimOnlineDurabilityModifier);
            this.LandClaim_g.Location = new System.Drawing.Point(6, 113);
            this.LandClaim_g.Name = "LandClaim_g";
            this.LandClaim_g.Size = new System.Drawing.Size(342, 67);
            this.LandClaim_g.TabIndex = 4;
            this.LandClaim_g.TabStop = false;
            this.LandClaim_g.Text = "LandClaim_g";
            // 
            // offline
            // 
            this.offline.AutoSize = true;
            this.offline.Location = new System.Drawing.Point(17, 42);
            this.offline.Name = "offline";
            this.offline.Size = new System.Drawing.Size(35, 13);
            this.offline.TabIndex = 3;
            this.offline.Text = "offline";
            // 
            // online
            // 
            this.online.AutoSize = true;
            this.online.Location = new System.Drawing.Point(17, 16);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(35, 13);
            this.online.TabIndex = 2;
            this.online.Text = "online";
            // 
            // LandClaimOfflineDurabilityModifier
            // 
            this.LandClaimOfflineDurabilityModifier.Location = new System.Drawing.Point(152, 39);
            this.LandClaimOfflineDurabilityModifier.Name = "LandClaimOfflineDurabilityModifier";
            this.LandClaimOfflineDurabilityModifier.Size = new System.Drawing.Size(54, 20);
            this.LandClaimOfflineDurabilityModifier.TabIndex = 1;
            this.LandClaimOfflineDurabilityModifier.Text = "32";
            this.LandClaimOfflineDurabilityModifier.TextChanged += new System.EventHandler(this.LandClaimOfflineDurabilityModifier_TextChanged);
            // 
            // LandClaimOnlineDurabilityModifier
            // 
            this.LandClaimOnlineDurabilityModifier.Location = new System.Drawing.Point(152, 13);
            this.LandClaimOnlineDurabilityModifier.Name = "LandClaimOnlineDurabilityModifier";
            this.LandClaimOnlineDurabilityModifier.Size = new System.Drawing.Size(54, 20);
            this.LandClaimOnlineDurabilityModifier.TabIndex = 0;
            this.LandClaimOnlineDurabilityModifier.Text = "32";
            this.LandClaimOnlineDurabilityModifier.TextChanged += new System.EventHandler(this.LandClaimOnlineDurabilityModifier_TextChanged);
            // 
            // LandClaimSize_g
            // 
            this.LandClaimSize_g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LandClaimSize_g.Controls.Add(this.LandClaimSize);
            this.LandClaimSize_g.Location = new System.Drawing.Point(354, 72);
            this.LandClaimSize_g.Name = "LandClaimSize_g";
            this.LandClaimSize_g.Size = new System.Drawing.Size(145, 51);
            this.LandClaimSize_g.TabIndex = 0;
            this.LandClaimSize_g.TabStop = false;
            this.LandClaimSize_g.Text = "LandClaimSize_g";
            // 
            // LandClaimSize
            // 
            this.LandClaimSize.Location = new System.Drawing.Point(6, 19);
            this.LandClaimSize.Name = "LandClaimSize";
            this.LandClaimSize.Size = new System.Drawing.Size(133, 20);
            this.LandClaimSize.TabIndex = 0;
            this.LandClaimSize.Text = "7";
            this.LandClaimSize.TextChanged += new System.EventHandler(this.LandClaimSize_TextChanged);
            // 
            // LandClaimDeadZone_g
            // 
            this.LandClaimDeadZone_g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LandClaimDeadZone_g.Controls.Add(this.LandClaimDeadZone);
            this.LandClaimDeadZone_g.Location = new System.Drawing.Point(354, 19);
            this.LandClaimDeadZone_g.Name = "LandClaimDeadZone_g";
            this.LandClaimDeadZone_g.Size = new System.Drawing.Size(145, 51);
            this.LandClaimDeadZone_g.TabIndex = 1;
            this.LandClaimDeadZone_g.TabStop = false;
            this.LandClaimDeadZone_g.Text = "LandClaimDeadZone_g";
            // 
            // LandClaimDeadZone
            // 
            this.LandClaimDeadZone.Location = new System.Drawing.Point(6, 19);
            this.LandClaimDeadZone.Name = "LandClaimDeadZone";
            this.LandClaimDeadZone.Size = new System.Drawing.Size(133, 20);
            this.LandClaimDeadZone.TabIndex = 0;
            this.LandClaimDeadZone.Text = "30";
            this.LandClaimDeadZone.TextChanged += new System.EventHandler(this.LandClaimDeadZone_TextChanged);
            // 
            // LandClaimExpiryTime_g
            // 
            this.LandClaimExpiryTime_g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LandClaimExpiryTime_g.Controls.Add(this.LandClaimExpiryTime);
            this.LandClaimExpiryTime_g.Location = new System.Drawing.Point(354, 129);
            this.LandClaimExpiryTime_g.Name = "LandClaimExpiryTime_g";
            this.LandClaimExpiryTime_g.Size = new System.Drawing.Size(145, 51);
            this.LandClaimExpiryTime_g.TabIndex = 2;
            this.LandClaimExpiryTime_g.TabStop = false;
            this.LandClaimExpiryTime_g.Text = "LandClaimExpiryTime_g";
            // 
            // LandClaimExpiryTime
            // 
            this.LandClaimExpiryTime.Location = new System.Drawing.Point(6, 19);
            this.LandClaimExpiryTime.Name = "LandClaimExpiryTime";
            this.LandClaimExpiryTime.Size = new System.Drawing.Size(133, 20);
            this.LandClaimExpiryTime.TabIndex = 0;
            this.LandClaimExpiryTime.Text = "3";
            this.LandClaimExpiryTime.TextChanged += new System.EventHandler(this.LandClaimExpiryTime_TextChanged);
            // 
            // LootRespawnDays_g
            // 
            this.LootRespawnDays_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LootRespawnDays_g.Controls.Add(this.LootRespawnDays);
            this.LootRespawnDays_g.Location = new System.Drawing.Point(10, 310);
            this.LootRespawnDays_g.Name = "LootRespawnDays_g";
            this.LootRespawnDays_g.Size = new System.Drawing.Size(508, 65);
            this.LootRespawnDays_g.TabIndex = 47;
            this.LootRespawnDays_g.TabStop = false;
            this.LootRespawnDays_g.Text = "LootRespawnDays_g";
            // 
            // LootRespawnDays
            // 
            this.LootRespawnDays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LootRespawnDays.Location = new System.Drawing.Point(3, 14);
            this.LootRespawnDays.Maximum = 90;
            this.LootRespawnDays.Minimum = -1;
            this.LootRespawnDays.Name = "LootRespawnDays";
            this.LootRespawnDays.Size = new System.Drawing.Size(496, 45);
            this.LootRespawnDays.TabIndex = 9;
            this.LootRespawnDays.Value = 50;
            this.LootRespawnDays.Scroll += new System.EventHandler(this.LootRespawnDays_Scroll);
            // 
            // LootAbundance_g
            // 
            this.LootAbundance_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LootAbundance_g.Controls.Add(this.LootAbundance);
            this.LootAbundance_g.Location = new System.Drawing.Point(10, 239);
            this.LootAbundance_g.Name = "LootAbundance_g";
            this.LootAbundance_g.Size = new System.Drawing.Size(508, 65);
            this.LootAbundance_g.TabIndex = 46;
            this.LootAbundance_g.TabStop = false;
            this.LootAbundance_g.Text = "LootAbundance_g";
            // 
            // LootAbundance
            // 
            this.LootAbundance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LootAbundance.Location = new System.Drawing.Point(6, 13);
            this.LootAbundance.Maximum = 200;
            this.LootAbundance.Name = "LootAbundance";
            this.LootAbundance.Size = new System.Drawing.Size(496, 45);
            this.LootAbundance.TabIndex = 9;
            this.LootAbundance.Value = 50;
            this.LootAbundance.Scroll += new System.EventHandler(this.LootAbundance_Scroll);
            // 
            // maxplgroup
            // 
            this.maxplgroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxplgroup.Controls.Add(this.maxpl);
            this.maxplgroup.Location = new System.Drawing.Point(10, 3);
            this.maxplgroup.Name = "maxplgroup";
            this.maxplgroup.Size = new System.Drawing.Size(508, 65);
            this.maxplgroup.TabIndex = 45;
            this.maxplgroup.TabStop = false;
            this.maxplgroup.Text = "maxplgroup";
            // 
            // maxpl
            // 
            this.maxpl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxpl.Location = new System.Drawing.Point(6, 14);
            this.maxpl.Maximum = 64;
            this.maxpl.Minimum = 1;
            this.maxpl.Name = "maxpl";
            this.maxpl.Size = new System.Drawing.Size(496, 45);
            this.maxpl.TabIndex = 8;
            this.maxpl.Value = 16;
            this.maxpl.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trybgry
            // 
            this.trybgry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trybgry.Controls.Add(this.PersistentPlayerProfiles);
            this.trybgry.Controls.Add(this.feral);
            this.trybgry.Controls.Add(this.gamemode_surv_pvp);
            this.trybgry.Controls.Add(this.cheatmode);
            this.trybgry.Controls.Add(this.gamemode_coop);
            this.trybgry.Location = new System.Drawing.Point(523, 335);
            this.trybgry.Name = "trybgry";
            this.trybgry.Size = new System.Drawing.Size(179, 162);
            this.trybgry.TabIndex = 44;
            this.trybgry.TabStop = false;
            this.trybgry.Text = "Tryb gry";
            // 
            // PersistentPlayerProfiles
            // 
            this.PersistentPlayerProfiles.AutoSize = true;
            this.PersistentPlayerProfiles.Location = new System.Drawing.Point(6, 93);
            this.PersistentPlayerProfiles.Name = "PersistentPlayerProfiles";
            this.PersistentPlayerProfiles.Size = new System.Drawing.Size(135, 17);
            this.PersistentPlayerProfiles.TabIndex = 19;
            this.PersistentPlayerProfiles.Text = "PersistentPlayerProfiles";
            this.PersistentPlayerProfiles.UseVisualStyleBackColor = true;
            this.PersistentPlayerProfiles.CheckedChanged += new System.EventHandler(this.PersistentPlayerProfiles_CheckedChanged);
            // 
            // feral
            // 
            this.feral.AutoSize = true;
            this.feral.Location = new System.Drawing.Point(6, 116);
            this.feral.Name = "feral";
            this.feral.Size = new System.Drawing.Size(46, 17);
            this.feral.TabIndex = 18;
            this.feral.Text = "feral";
            this.feral.UseVisualStyleBackColor = true;
            this.feral.CheckedChanged += new System.EventHandler(this.Feral_CheckedChanged);
            // 
            // gamemode_surv_pvp
            // 
            this.gamemode_surv_pvp.AutoSize = true;
            this.gamemode_surv_pvp.Checked = true;
            this.gamemode_surv_pvp.Location = new System.Drawing.Point(6, 18);
            this.gamemode_surv_pvp.Name = "gamemode_surv_pvp";
            this.gamemode_surv_pvp.Size = new System.Drawing.Size(82, 17);
            this.gamemode_surv_pvp.TabIndex = 17;
            this.gamemode_surv_pvp.TabStop = true;
            this.gamemode_surv_pvp.Text = "Survival MP";
            this.gamemode_surv_pvp.UseVisualStyleBackColor = true;
            this.gamemode_surv_pvp.CheckedChanged += new System.EventHandler(this.gamemode_surv_pvp_CheckedChanged);
            // 
            // cheatmode
            // 
            this.cheatmode.AutoSize = true;
            this.cheatmode.Location = new System.Drawing.Point(6, 139);
            this.cheatmode.Name = "cheatmode";
            this.cheatmode.Size = new System.Drawing.Size(84, 17);
            this.cheatmode.TabIndex = 14;
            this.cheatmode.Text = "Cheat Mode";
            this.cheatmode.UseVisualStyleBackColor = true;
            this.cheatmode.CheckedChanged += new System.EventHandler(this.cheatmode_CheckedChanged);
            // 
            // gamemode_coop
            // 
            this.gamemode_coop.AutoSize = true;
            this.gamemode_coop.Location = new System.Drawing.Point(6, 41);
            this.gamemode_coop.Name = "gamemode_coop";
            this.gamemode_coop.Size = new System.Drawing.Size(80, 17);
            this.gamemode_coop.TabIndex = 10;
            this.gamemode_coop.Text = "Survival SP";
            this.gamemode_coop.UseVisualStyleBackColor = true;
            this.gamemode_coop.CheckedChanged += new System.EventHandler(this.gamemode_coop_CheckedChanged);
            // 
            // zomb_pie
            // 
            this.zomb_pie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zomb_pie.Controls.Add(this.zombie_never_run);
            this.zomb_pie.Controls.Add(this.zombie_normal);
            this.zomb_pie.Controls.Add(this.zombie_run);
            this.zomb_pie.Location = new System.Drawing.Point(708, 217);
            this.zomb_pie.Name = "zomb_pie";
            this.zomb_pie.Size = new System.Drawing.Size(179, 87);
            this.zomb_pie.TabIndex = 43;
            this.zomb_pie.TabStop = false;
            this.zomb_pie.Text = "Zachowanie zombie";
            // 
            // zombie_never_run
            // 
            this.zombie_never_run.AutoSize = true;
            this.zombie_never_run.Location = new System.Drawing.Point(6, 64);
            this.zombie_never_run.Name = "zombie_never_run";
            this.zombie_never_run.Size = new System.Drawing.Size(142, 17);
            this.zombie_never_run.TabIndex = 25;
            this.zombie_never_run.TabStop = true;
            this.zombie_never_run.Text = "Zombie nigdy nie biegają";
            this.zombie_never_run.UseVisualStyleBackColor = true;
            this.zombie_never_run.CheckedChanged += new System.EventHandler(this.zombie_never_run_CheckedChanged);
            // 
            // zombie_normal
            // 
            this.zombie_normal.AutoSize = true;
            this.zombie_normal.Location = new System.Drawing.Point(6, 18);
            this.zombie_normal.Name = "zombie_normal";
            this.zombie_normal.Size = new System.Drawing.Size(134, 17);
            this.zombie_normal.TabIndex = 24;
            this.zombie_normal.TabStop = true;
            this.zombie_normal.Text = "Zombie biegają w nocy";
            this.zombie_normal.UseVisualStyleBackColor = true;
            this.zombie_normal.CheckedChanged += new System.EventHandler(this.zombie_normal_CheckedChanged);
            // 
            // zombie_run
            // 
            this.zombie_run.AutoSize = true;
            this.zombie_run.Location = new System.Drawing.Point(6, 41);
            this.zombie_run.Name = "zombie_run";
            this.zombie_run.Size = new System.Drawing.Size(135, 17);
            this.zombie_run.TabIndex = 23;
            this.zombie_run.TabStop = true;
            this.zombie_run.Text = "Zombie zawsze biegają";
            this.zombie_run.UseVisualStyleBackColor = true;
            this.zombie_run.CheckedChanged += new System.EventHandler(this.zombie_run_CheckedChanged);
            // 
            // nightpercentage_g
            // 
            this.nightpercentage_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nightpercentage_g.Controls.Add(this.nightpercentage);
            this.nightpercentage_g.Location = new System.Drawing.Point(10, 74);
            this.nightpercentage_g.Name = "nightpercentage_g";
            this.nightpercentage_g.Size = new System.Drawing.Size(508, 65);
            this.nightpercentage_g.TabIndex = 42;
            this.nightpercentage_g.TabStop = false;
            this.nightpercentage_g.Text = "nightpercentage_g";
            // 
            // nightpercentage
            // 
            this.nightpercentage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nightpercentage.Location = new System.Drawing.Point(6, 14);
            this.nightpercentage.Maximum = 24;
            this.nightpercentage.Name = "nightpercentage";
            this.nightpercentage.Size = new System.Drawing.Size(496, 45);
            this.nightpercentage.TabIndex = 9;
            this.nightpercentage.Value = 18;
            this.nightpercentage.Scroll += new System.EventHandler(this.nightpercentage_Scroll);
            // 
            // dlugoscdnia_g
            // 
            this.dlugoscdnia_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dlugoscdnia_g.Controls.Add(this.realtime);
            this.dlugoscdnia_g.Controls.Add(this.dlugoscdnia);
            this.dlugoscdnia_g.Location = new System.Drawing.Point(10, 145);
            this.dlugoscdnia_g.Name = "dlugoscdnia_g";
            this.dlugoscdnia_g.Size = new System.Drawing.Size(508, 88);
            this.dlugoscdnia_g.TabIndex = 39;
            this.dlugoscdnia_g.TabStop = false;
            this.dlugoscdnia_g.Text = "dlugoscdnia";
            // 
            // realtime
            // 
            this.realtime.AutoSize = true;
            this.realtime.Location = new System.Drawing.Point(9, 65);
            this.realtime.Name = "realtime";
            this.realtime.Size = new System.Drawing.Size(62, 17);
            this.realtime.TabIndex = 10;
            this.realtime.Text = "realtime";
            this.realtime.UseVisualStyleBackColor = true;
            this.realtime.CheckedChanged += new System.EventHandler(this.realtime_CheckedChanged);
            // 
            // dlugoscdnia
            // 
            this.dlugoscdnia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dlugoscdnia.Enabled = false;
            this.dlugoscdnia.Location = new System.Drawing.Point(6, 19);
            this.dlugoscdnia.Maximum = 240;
            this.dlugoscdnia.Minimum = 1;
            this.dlugoscdnia.Name = "dlugoscdnia";
            this.dlugoscdnia.Size = new System.Drawing.Size(496, 45);
            this.dlugoscdnia.TabIndex = 9;
            this.dlugoscdnia.Value = 20;
            this.dlugoscdnia.Scroll += new System.EventHandler(this.dlugoscdnia_Scroll);
            // 
            // bdm_g
            // 
            this.bdm_g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bdm_g.Controls.Add(this.bdm);
            this.bdm_g.Location = new System.Drawing.Point(708, 146);
            this.bdm_g.Name = "bdm_g";
            this.bdm_g.Size = new System.Drawing.Size(179, 65);
            this.bdm_g.TabIndex = 37;
            this.bdm_g.TabStop = false;
            this.bdm_g.Text = "bdm_g";
            // 
            // bdm
            // 
            this.bdm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdm.Location = new System.Drawing.Point(6, 14);
            this.bdm.Maximum = 9;
            this.bdm.Name = "bdm";
            this.bdm.Size = new System.Drawing.Size(167, 45);
            this.bdm.TabIndex = 9;
            this.bdm.Value = 2;
            this.bdm.Scroll += new System.EventHandler(this.bdm_Scroll);
            // 
            // dod_g
            // 
            this.dod_g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dod_g.Controls.Add(this.dod_p);
            this.dod_g.Controls.Add(this.doq_3);
            this.dod_g.Controls.Add(this.doq_2);
            this.dod_g.Controls.Add(this.doq_1);
            this.dod_g.Controls.Add(this.doq_0);
            this.dod_g.Location = new System.Drawing.Point(523, 217);
            this.dod_g.Name = "dod_g";
            this.dod_g.Size = new System.Drawing.Size(179, 112);
            this.dod_g.TabIndex = 32;
            this.dod_g.TabStop = false;
            this.dod_g.Text = "dod_g";
            // 
            // dod_p
            // 
            this.dod_p.Controls.Add(this.dod_0);
            this.dod_p.Controls.Add(this.dod_1);
            this.dod_p.Controls.Add(this.dod_2);
            this.dod_p.Controls.Add(this.dod_3);
            this.dod_p.Location = new System.Drawing.Point(6, 15);
            this.dod_p.Name = "dod_p";
            this.dod_p.Size = new System.Drawing.Size(79, 95);
            this.dod_p.TabIndex = 29;
            // 
            // dod_0
            // 
            this.dod_0.AutoSize = true;
            this.dod_0.Location = new System.Drawing.Point(3, 3);
            this.dod_0.Name = "dod_0";
            this.dod_0.Size = new System.Drawing.Size(55, 17);
            this.dod_0.TabIndex = 24;
            this.dod_0.Text = "dod_0";
            this.dod_0.UseVisualStyleBackColor = true;
            this.dod_0.CheckedChanged += new System.EventHandler(this.dod_0_CheckedChanged);
            // 
            // dod_1
            // 
            this.dod_1.AutoSize = true;
            this.dod_1.Location = new System.Drawing.Point(3, 26);
            this.dod_1.Name = "dod_1";
            this.dod_1.Size = new System.Drawing.Size(55, 17);
            this.dod_1.TabIndex = 25;
            this.dod_1.Text = "dod_1";
            this.dod_1.UseVisualStyleBackColor = true;
            this.dod_1.CheckedChanged += new System.EventHandler(this.dod_1_CheckedChanged);
            // 
            // dod_2
            // 
            this.dod_2.AutoSize = true;
            this.dod_2.Checked = true;
            this.dod_2.Location = new System.Drawing.Point(3, 49);
            this.dod_2.Name = "dod_2";
            this.dod_2.Size = new System.Drawing.Size(55, 17);
            this.dod_2.TabIndex = 26;
            this.dod_2.TabStop = true;
            this.dod_2.Text = "dod_2";
            this.dod_2.UseVisualStyleBackColor = true;
            this.dod_2.CheckedChanged += new System.EventHandler(this.dod_2_CheckedChanged);
            // 
            // dod_3
            // 
            this.dod_3.AutoSize = true;
            this.dod_3.Location = new System.Drawing.Point(3, 72);
            this.dod_3.Name = "dod_3";
            this.dod_3.Size = new System.Drawing.Size(55, 17);
            this.dod_3.TabIndex = 27;
            this.dod_3.Text = "dod_3";
            this.dod_3.UseVisualStyleBackColor = true;
            this.dod_3.CheckedChanged += new System.EventHandler(this.dod_3_CheckedChanged);
            // 
            // doq_3
            // 
            this.doq_3.AutoSize = true;
            this.doq_3.Location = new System.Drawing.Point(91, 87);
            this.doq_3.Name = "doq_3";
            this.doq_3.Size = new System.Drawing.Size(55, 17);
            this.doq_3.TabIndex = 31;
            this.doq_3.Text = "doq_3";
            this.doq_3.UseVisualStyleBackColor = true;
            this.doq_3.CheckedChanged += new System.EventHandler(this.doq_3_CheckedChanged);
            // 
            // doq_2
            // 
            this.doq_2.AutoSize = true;
            this.doq_2.Location = new System.Drawing.Point(91, 64);
            this.doq_2.Name = "doq_2";
            this.doq_2.Size = new System.Drawing.Size(55, 17);
            this.doq_2.TabIndex = 30;
            this.doq_2.Text = "doq_2";
            this.doq_2.UseVisualStyleBackColor = true;
            this.doq_2.CheckedChanged += new System.EventHandler(this.doq_2_CheckedChanged);
            // 
            // doq_1
            // 
            this.doq_1.AutoSize = true;
            this.doq_1.Location = new System.Drawing.Point(91, 41);
            this.doq_1.Name = "doq_1";
            this.doq_1.Size = new System.Drawing.Size(55, 17);
            this.doq_1.TabIndex = 29;
            this.doq_1.Text = "doq_1";
            this.doq_1.UseVisualStyleBackColor = true;
            this.doq_1.CheckedChanged += new System.EventHandler(this.doq_1_CheckedChanged);
            // 
            // doq_0
            // 
            this.doq_0.AutoSize = true;
            this.doq_0.Checked = true;
            this.doq_0.Location = new System.Drawing.Point(91, 18);
            this.doq_0.Name = "doq_0";
            this.doq_0.Size = new System.Drawing.Size(55, 17);
            this.doq_0.TabIndex = 28;
            this.doq_0.TabStop = true;
            this.doq_0.Text = "doq_0";
            this.doq_0.UseVisualStyleBackColor = true;
            this.doq_0.CheckedChanged += new System.EventHandler(this.doq_0_CheckedChanged);
            // 
            // trudnoscgroup
            // 
            this.trudnoscgroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trudnoscgroup.Controls.Add(this.trudnosc);
            this.trudnoscgroup.Location = new System.Drawing.Point(523, 146);
            this.trudnoscgroup.Name = "trudnoscgroup";
            this.trudnoscgroup.Size = new System.Drawing.Size(179, 65);
            this.trudnoscgroup.TabIndex = 31;
            this.trudnoscgroup.TabStop = false;
            this.trudnoscgroup.Text = "trudnoscgroup";
            // 
            // trudnosc
            // 
            this.trudnosc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trudnosc.Location = new System.Drawing.Point(6, 13);
            this.trudnosc.Maximum = 5;
            this.trudnosc.Name = "trudnosc";
            this.trudnosc.Size = new System.Drawing.Size(167, 45);
            this.trudnosc.TabIndex = 9;
            this.trudnosc.Value = 1;
            this.trudnosc.Scroll += new System.EventHandler(this.trudnosc_Scroll);
            // 
            // server_opts
            // 
            this.server_opts.Controls.Add(this.ServerWebsiteURL_g);
            this.server_opts.Controls.Add(this.ServerDescription_g);
            this.server_opts.Controls.Add(this.configfile_g);
            this.server_opts.Controls.Add(this.save_g);
            this.server_opts.Controls.Add(this.filename_g);
            this.server_opts.Controls.Add(this.nazwamapa);
            this.server_opts.Controls.Add(this.dostep);
            this.server_opts.Controls.Add(this.odery);
            this.server_opts.Controls.Add(this.autobots);
            this.server_opts.ImageIndex = 6;
            this.server_opts.Location = new System.Drawing.Point(4, 50);
            this.server_opts.Name = "server_opts";
            this.server_opts.Padding = new System.Windows.Forms.Padding(3);
            this.server_opts.Size = new System.Drawing.Size(897, 630);
            this.server_opts.TabIndex = 1;
            this.server_opts.UseVisualStyleBackColor = true;
            // 
            // ServerWebsiteURL_g
            // 
            this.ServerWebsiteURL_g.Controls.Add(this.ServerWebsiteURL);
            this.ServerWebsiteURL_g.Location = new System.Drawing.Point(8, 371);
            this.ServerWebsiteURL_g.Name = "ServerWebsiteURL_g";
            this.ServerWebsiteURL_g.Size = new System.Drawing.Size(369, 48);
            this.ServerWebsiteURL_g.TabIndex = 42;
            this.ServerWebsiteURL_g.TabStop = false;
            this.ServerWebsiteURL_g.Text = "ServerWebsiteURL_g";
            // 
            // ServerWebsiteURL
            // 
            this.ServerWebsiteURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerWebsiteURL.Location = new System.Drawing.Point(9, 19);
            this.ServerWebsiteURL.Name = "ServerWebsiteURL";
            this.ServerWebsiteURL.Size = new System.Drawing.Size(354, 20);
            this.ServerWebsiteURL.TabIndex = 30;
            this.ServerWebsiteURL.Text = "https://7dsm.smartmoose.org";
            // 
            // ServerDescription_g
            // 
            this.ServerDescription_g.Controls.Add(this.ServerDescription);
            this.ServerDescription_g.Location = new System.Drawing.Point(8, 317);
            this.ServerDescription_g.Name = "ServerDescription_g";
            this.ServerDescription_g.Size = new System.Drawing.Size(369, 48);
            this.ServerDescription_g.TabIndex = 41;
            this.ServerDescription_g.TabStop = false;
            this.ServerDescription_g.Text = "ServerDescription_g";
            // 
            // ServerDescription
            // 
            this.ServerDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerDescription.Location = new System.Drawing.Point(9, 19);
            this.ServerDescription.Name = "ServerDescription";
            this.ServerDescription.Size = new System.Drawing.Size(354, 20);
            this.ServerDescription.TabIndex = 30;
            this.ServerDescription.Text = "Powered by 7DSM";
            // 
            // configfile_g
            // 
            this.configfile_g.Controls.Add(this.configfile_e);
            this.configfile_g.Controls.Add(this.configfile);
            this.configfile_g.Location = new System.Drawing.Point(194, 214);
            this.configfile_g.Name = "configfile_g";
            this.configfile_g.Size = new System.Drawing.Size(183, 48);
            this.configfile_g.TabIndex = 40;
            this.configfile_g.TabStop = false;
            this.configfile_g.Text = "configfile_g";
            // 
            // configfile_e
            // 
            this.configfile_e.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.configfile_e.Location = new System.Drawing.Point(120, 17);
            this.configfile_e.Name = "configfile_e";
            this.configfile_e.Size = new System.Drawing.Size(57, 23);
            this.configfile_e.TabIndex = 31;
            this.configfile_e.Text = "configfile_e";
            this.configfile_e.UseVisualStyleBackColor = true;
            this.configfile_e.Click += new System.EventHandler(this.Configfile_e_Click);
            // 
            // configfile
            // 
            this.configfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configfile.Location = new System.Drawing.Point(13, 19);
            this.configfile.Name = "configfile";
            this.configfile.Size = new System.Drawing.Size(101, 20);
            this.configfile.TabIndex = 30;
            this.configfile.TextChanged += new System.EventHandler(this.Configfile_TextChanged);
            // 
            // save_g
            // 
            this.save_g.Controls.Add(this.save);
            this.save_g.Location = new System.Drawing.Point(8, 263);
            this.save_g.Name = "save_g";
            this.save_g.Size = new System.Drawing.Size(369, 48);
            this.save_g.TabIndex = 39;
            this.save_g.TabStop = false;
            this.save_g.Text = "save_g";
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Location = new System.Drawing.Point(9, 19);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(354, 20);
            this.save.TabIndex = 30;
            this.save.TextChanged += new System.EventHandler(this.Save_TextChanged);
            // 
            // filename_g
            // 
            this.filename_g.Controls.Add(this.sa_edit);
            this.filename_g.Controls.Add(this.AdminFileName);
            this.filename_g.Location = new System.Drawing.Point(8, 214);
            this.filename_g.Name = "filename_g";
            this.filename_g.Size = new System.Drawing.Size(180, 48);
            this.filename_g.TabIndex = 31;
            this.filename_g.TabStop = false;
            this.filename_g.Text = "filename_g";
            // 
            // sa_edit
            // 
            this.sa_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sa_edit.Location = new System.Drawing.Point(117, 17);
            this.sa_edit.Name = "sa_edit";
            this.sa_edit.Size = new System.Drawing.Size(57, 23);
            this.sa_edit.TabIndex = 31;
            this.sa_edit.Text = "sa_edit";
            this.sa_edit.UseVisualStyleBackColor = true;
            this.sa_edit.Click += new System.EventHandler(this.Sa_edit_Click);
            // 
            // AdminFileName
            // 
            this.AdminFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminFileName.Location = new System.Drawing.Point(13, 19);
            this.AdminFileName.Name = "AdminFileName";
            this.AdminFileName.Size = new System.Drawing.Size(98, 20);
            this.AdminFileName.TabIndex = 30;
            this.AdminFileName.Text = "serveradmin.xml";
            this.AdminFileName.TextChanged += new System.EventHandler(this.AdminFileName_TextChanged);
            // 
            // nazwamapa
            // 
            this.nazwamapa.Controls.Add(this.nazwa);
            this.nazwamapa.Controls.Add(this.server_nazwa);
            this.nazwamapa.Controls.Add(this.mapa);
            this.nazwamapa.Location = new System.Drawing.Point(8, 6);
            this.nazwamapa.Name = "nazwamapa";
            this.nazwamapa.Size = new System.Drawing.Size(369, 81);
            this.nazwamapa.TabIndex = 28;
            this.nazwamapa.TabStop = false;
            this.nazwamapa.Text = "Nazwa gry i wybór mapy";
            // 
            // nazwa
            // 
            this.nazwa.FormattingEnabled = true;
            this.nazwa.Location = new System.Drawing.Point(6, 22);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(190, 21);
            this.nazwa.TabIndex = 4;
            this.nazwa.SelectedIndexChanged += new System.EventHandler(this.nazwa_SelectedIndexChanged);
            this.nazwa.TextChanged += new System.EventHandler(this.nazwa_TextChanged);
            // 
            // server_nazwa
            // 
            this.server_nazwa.Location = new System.Drawing.Point(6, 48);
            this.server_nazwa.Name = "server_nazwa";
            this.server_nazwa.Size = new System.Drawing.Size(190, 20);
            this.server_nazwa.TabIndex = 3;
            this.server_nazwa.Text = "7DaysServerManager";
            this.server_nazwa.TextChanged += new System.EventHandler(this.server_nazwa_TextChanged);
            // 
            // mapa
            // 
            this.mapa.DisplayMember = "a";
            this.mapa.FormattingEnabled = true;
            this.mapa.Location = new System.Drawing.Point(203, 22);
            this.mapa.Name = "mapa";
            this.mapa.Size = new System.Drawing.Size(160, 21);
            this.mapa.TabIndex = 2;
            this.mapa.Text = "Navezgane";
            this.mapa.SelectedIndexChanged += new System.EventHandler(this.mapa_SelectedIndexChanged);
            // 
            // dostep
            // 
            this.dostep.Controls.Add(this.ServerPassword);
            this.dostep.Controls.Add(this.ServerIsPublic);
            this.dostep.Location = new System.Drawing.Point(8, 165);
            this.dostep.Name = "dostep";
            this.dostep.Size = new System.Drawing.Size(369, 43);
            this.dostep.TabIndex = 25;
            this.dostep.TabStop = false;
            this.dostep.Text = "Lista serwerów i hasło dostępu";
            // 
            // ServerPassword
            // 
            this.ServerPassword.Location = new System.Drawing.Point(205, 16);
            this.ServerPassword.Name = "ServerPassword";
            this.ServerPassword.PasswordChar = '*';
            this.ServerPassword.Size = new System.Drawing.Size(158, 20);
            this.ServerPassword.TabIndex = 4;
            this.ServerPassword.TextChanged += new System.EventHandler(this.ServerPassword_TextChanged);
            // 
            // ServerIsPublic
            // 
            this.ServerIsPublic.AutoSize = true;
            this.ServerIsPublic.Location = new System.Drawing.Point(12, 18);
            this.ServerIsPublic.Name = "ServerIsPublic";
            this.ServerIsPublic.Size = new System.Drawing.Size(179, 17);
            this.ServerIsPublic.TabIndex = 2;
            this.ServerIsPublic.Text = "Pokaż serwer na liście serwerów";
            this.ServerIsPublic.UseVisualStyleBackColor = true;
            this.ServerIsPublic.CheckedChanged += new System.EventHandler(this.ServerIsPublic_CheckedChanged);
            // 
            // odery
            // 
            this.odery.Controls.Add(this.VACEnabled);
            this.odery.Controls.Add(this.save_logfiles);
            this.odery.Location = new System.Drawing.Point(11, 93);
            this.odery.Name = "odery";
            this.odery.Size = new System.Drawing.Size(366, 66);
            this.odery.TabIndex = 24;
            this.odery.TabStop = false;
            this.odery.Text = "Pozostałe";
            // 
            // VACEnabled
            // 
            this.VACEnabled.AutoSize = true;
            this.VACEnabled.Checked = true;
            this.VACEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VACEnabled.Location = new System.Drawing.Point(9, 41);
            this.VACEnabled.Name = "VACEnabled";
            this.VACEnabled.Size = new System.Drawing.Size(86, 17);
            this.VACEnabled.TabIndex = 3;
            this.VACEnabled.Text = "VACEnabled";
            this.VACEnabled.UseVisualStyleBackColor = true;
            this.VACEnabled.CheckedChanged += new System.EventHandler(this.VACEnabled_CheckedChanged);
            // 
            // save_logfiles
            // 
            this.save_logfiles.AutoSize = true;
            this.save_logfiles.Location = new System.Drawing.Point(9, 18);
            this.save_logfiles.Name = "save_logfiles";
            this.save_logfiles.Size = new System.Drawing.Size(159, 17);
            this.save_logfiles.TabIndex = 1;
            this.save_logfiles.Text = "Zapisuj logi serwera do pliku";
            this.save_logfiles.UseVisualStyleBackColor = true;
            this.save_logfiles.CheckedChanged += new System.EventHandler(this.save_logfiles_CheckedChanged);
            // 
            // autobots
            // 
            this.autobots.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autobots.Controls.Add(this.EnemySpawnMode);
            this.autobots.Controls.Add(this.BedrollDeadZoneSize_g);
            this.autobots.Controls.Add(this.BloodMoonEnemyCount_g);
            this.autobots.Controls.Add(this.AirDropMarker);
            this.autobots.Controls.Add(this.MaxSpawnedAnimals_g);
            this.autobots.Controls.Add(this.MaxSpawnedZombies_g);
            this.autobots.Location = new System.Drawing.Point(383, 6);
            this.autobots.Name = "autobots";
            this.autobots.Size = new System.Drawing.Size(508, 360);
            this.autobots.TabIndex = 38;
            this.autobots.TabStop = false;
            this.autobots.Text = "Spawn";
            // 
            // EnemySpawnMode
            // 
            this.EnemySpawnMode.AutoSize = true;
            this.EnemySpawnMode.Checked = true;
            this.EnemySpawnMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnemySpawnMode.Enabled = false;
            this.EnemySpawnMode.Location = new System.Drawing.Point(6, 45);
            this.EnemySpawnMode.Name = "EnemySpawnMode";
            this.EnemySpawnMode.Size = new System.Drawing.Size(141, 17);
            this.EnemySpawnMode.TabIndex = 16;
            this.EnemySpawnMode.Text = "Enable enemy spawning";
            this.EnemySpawnMode.UseVisualStyleBackColor = true;
            this.EnemySpawnMode.CheckedChanged += new System.EventHandler(this.EnemySpawnMode_CheckedChanged);
            // 
            // BedrollDeadZoneSize_g
            // 
            this.BedrollDeadZoneSize_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BedrollDeadZoneSize_g.Controls.Add(this.BedrollDeadZoneSize);
            this.BedrollDeadZoneSize_g.Location = new System.Drawing.Point(6, 290);
            this.BedrollDeadZoneSize_g.Name = "BedrollDeadZoneSize_g";
            this.BedrollDeadZoneSize_g.Size = new System.Drawing.Size(496, 63);
            this.BedrollDeadZoneSize_g.TabIndex = 15;
            this.BedrollDeadZoneSize_g.TabStop = false;
            this.BedrollDeadZoneSize_g.Text = "Minimum enemy spawn distance from bedroll";
            // 
            // BedrollDeadZoneSize
            // 
            this.BedrollDeadZoneSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BedrollDeadZoneSize.Location = new System.Drawing.Point(6, 13);
            this.BedrollDeadZoneSize.Maximum = 150;
            this.BedrollDeadZoneSize.Name = "BedrollDeadZoneSize";
            this.BedrollDeadZoneSize.Size = new System.Drawing.Size(484, 45);
            this.BedrollDeadZoneSize.TabIndex = 8;
            this.BedrollDeadZoneSize.Value = 15;
            this.BedrollDeadZoneSize.Scroll += new System.EventHandler(this.BedrollDeadZoneSize_Scroll);
            // 
            // BloodMoonEnemyCount_g
            // 
            this.BloodMoonEnemyCount_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BloodMoonEnemyCount_g.Controls.Add(this.BloodMoonEnemyCount);
            this.BloodMoonEnemyCount_g.Location = new System.Drawing.Point(6, 226);
            this.BloodMoonEnemyCount_g.Name = "BloodMoonEnemyCount_g";
            this.BloodMoonEnemyCount_g.Size = new System.Drawing.Size(496, 64);
            this.BloodMoonEnemyCount_g.TabIndex = 14;
            this.BloodMoonEnemyCount_g.TabStop = false;
            this.BloodMoonEnemyCount_g.Text = "Zombies spawned for every player during Blood Moon";
            // 
            // BloodMoonEnemyCount
            // 
            this.BloodMoonEnemyCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BloodMoonEnemyCount.Location = new System.Drawing.Point(6, 13);
            this.BloodMoonEnemyCount.Maximum = 50;
            this.BloodMoonEnemyCount.Name = "BloodMoonEnemyCount";
            this.BloodMoonEnemyCount.Size = new System.Drawing.Size(484, 45);
            this.BloodMoonEnemyCount.TabIndex = 8;
            this.BloodMoonEnemyCount.Value = 8;
            this.BloodMoonEnemyCount.Scroll += new System.EventHandler(this.BloodMoonEnemyCount_Scroll);
            // 
            // AirDropMarker
            // 
            this.AirDropMarker.AutoSize = true;
            this.AirDropMarker.Checked = true;
            this.AirDropMarker.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AirDropMarker.Enabled = false;
            this.AirDropMarker.Location = new System.Drawing.Point(6, 22);
            this.AirDropMarker.Name = "AirDropMarker";
            this.AirDropMarker.Size = new System.Drawing.Size(209, 17);
            this.AirDropMarker.TabIndex = 13;
            this.AirDropMarker.Text = "Add marker to players maps on air drop";
            this.AirDropMarker.UseVisualStyleBackColor = true;
            // 
            // MaxSpawnedAnimals_g
            // 
            this.MaxSpawnedAnimals_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxSpawnedAnimals_g.Controls.Add(this.MaxSpawnedAnimals);
            this.MaxSpawnedAnimals_g.Location = new System.Drawing.Point(6, 161);
            this.MaxSpawnedAnimals_g.Name = "MaxSpawnedAnimals_g";
            this.MaxSpawnedAnimals_g.Size = new System.Drawing.Size(496, 64);
            this.MaxSpawnedAnimals_g.TabIndex = 12;
            this.MaxSpawnedAnimals_g.TabStop = false;
            this.MaxSpawnedAnimals_g.Text = "MaxSpawnedAnimals_g";
            // 
            // MaxSpawnedAnimals
            // 
            this.MaxSpawnedAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxSpawnedAnimals.Location = new System.Drawing.Point(6, 13);
            this.MaxSpawnedAnimals.Maximum = 240;
            this.MaxSpawnedAnimals.Minimum = 1;
            this.MaxSpawnedAnimals.Name = "MaxSpawnedAnimals";
            this.MaxSpawnedAnimals.Size = new System.Drawing.Size(484, 45);
            this.MaxSpawnedAnimals.TabIndex = 8;
            this.MaxSpawnedAnimals.Value = 50;
            this.MaxSpawnedAnimals.Scroll += new System.EventHandler(this.MaxSpawnedAnimals_Scroll);
            // 
            // MaxSpawnedZombies_g
            // 
            this.MaxSpawnedZombies_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxSpawnedZombies_g.Controls.Add(this.MaxSpawnedZombies);
            this.MaxSpawnedZombies_g.Location = new System.Drawing.Point(6, 97);
            this.MaxSpawnedZombies_g.Name = "MaxSpawnedZombies_g";
            this.MaxSpawnedZombies_g.Size = new System.Drawing.Size(496, 64);
            this.MaxSpawnedZombies_g.TabIndex = 11;
            this.MaxSpawnedZombies_g.TabStop = false;
            this.MaxSpawnedZombies_g.Text = "MaxSpawnedZombies_g";
            // 
            // MaxSpawnedZombies
            // 
            this.MaxSpawnedZombies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxSpawnedZombies.Location = new System.Drawing.Point(6, 13);
            this.MaxSpawnedZombies.Maximum = 240;
            this.MaxSpawnedZombies.Minimum = 1;
            this.MaxSpawnedZombies.Name = "MaxSpawnedZombies";
            this.MaxSpawnedZombies.Size = new System.Drawing.Size(484, 45);
            this.MaxSpawnedZombies.TabIndex = 8;
            this.MaxSpawnedZombies.Value = 60;
            this.MaxSpawnedZombies.Scroll += new System.EventHandler(this.MaxSpawnedZombies_Scroll);
            // 
            // net_opts
            // 
            this.net_opts.Controls.Add(this.MaxUncoveredMapChunksPerPlayer_g);
            this.net_opts.Controls.Add(this.HideCommandExecutionLog_g);
            this.net_opts.Controls.Add(this.ServerDisabledNetworkProtocols_g);
            this.net_opts.Controls.Add(this.port_g);
            this.net_opts.Controls.Add(this.ctrlpanel);
            this.net_opts.Controls.Add(this.telnet_g);
            this.net_opts.ImageIndex = 12;
            this.net_opts.Location = new System.Drawing.Point(4, 50);
            this.net_opts.Name = "net_opts";
            this.net_opts.Size = new System.Drawing.Size(897, 630);
            this.net_opts.TabIndex = 3;
            this.net_opts.UseVisualStyleBackColor = true;
            // 
            // MaxUncoveredMapChunksPerPlayer_g
            // 
            this.MaxUncoveredMapChunksPerPlayer_g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxUncoveredMapChunksPerPlayer_g.Controls.Add(this.MaxUncoveredMapChunksPerPlayer);
            this.MaxUncoveredMapChunksPerPlayer_g.Location = new System.Drawing.Point(505, 126);
            this.MaxUncoveredMapChunksPerPlayer_g.Name = "MaxUncoveredMapChunksPerPlayer_g";
            this.MaxUncoveredMapChunksPerPlayer_g.Size = new System.Drawing.Size(382, 48);
            this.MaxUncoveredMapChunksPerPlayer_g.TabIndex = 52;
            this.MaxUncoveredMapChunksPerPlayer_g.TabStop = false;
            this.MaxUncoveredMapChunksPerPlayer_g.Text = "Max uncovered map chunks per player";
            // 
            // MaxUncoveredMapChunksPerPlayer
            // 
            this.MaxUncoveredMapChunksPerPlayer.Location = new System.Drawing.Point(6, 19);
            this.MaxUncoveredMapChunksPerPlayer.Name = "MaxUncoveredMapChunksPerPlayer";
            this.MaxUncoveredMapChunksPerPlayer.Size = new System.Drawing.Size(70, 20);
            this.MaxUncoveredMapChunksPerPlayer.TabIndex = 0;
            this.MaxUncoveredMapChunksPerPlayer.Text = "131072";
            this.MaxUncoveredMapChunksPerPlayer.TextChanged += new System.EventHandler(this.MaxUncoveredMapChunksPerPlayer_TextChanged);
            // 
            // HideCommandExecutionLog_g
            // 
            this.HideCommandExecutionLog_g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideCommandExecutionLog_g.Controls.Add(this.panel2);
            this.HideCommandExecutionLog_g.Location = new System.Drawing.Point(505, 3);
            this.HideCommandExecutionLog_g.Name = "HideCommandExecutionLog_g";
            this.HideCommandExecutionLog_g.Size = new System.Drawing.Size(382, 117);
            this.HideCommandExecutionLog_g.TabIndex = 51;
            this.HideCommandExecutionLog_g.TabStop = false;
            this.HideCommandExecutionLog_g.Text = "Hide command execution log";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HideCommandExecutionLog_0);
            this.panel2.Controls.Add(this.HideCommandExecutionLog_1);
            this.panel2.Controls.Add(this.HideCommandExecutionLog_2);
            this.panel2.Controls.Add(this.HideCommandExecutionLog_3);
            this.panel2.Location = new System.Drawing.Point(6, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 95);
            this.panel2.TabIndex = 30;
            // 
            // HideCommandExecutionLog_0
            // 
            this.HideCommandExecutionLog_0.AutoSize = true;
            this.HideCommandExecutionLog_0.Checked = true;
            this.HideCommandExecutionLog_0.Location = new System.Drawing.Point(3, 3);
            this.HideCommandExecutionLog_0.Name = "HideCommandExecutionLog_0";
            this.HideCommandExecutionLog_0.Size = new System.Drawing.Size(102, 17);
            this.HideCommandExecutionLog_0.TabIndex = 24;
            this.HideCommandExecutionLog_0.TabStop = true;
            this.HideCommandExecutionLog_0.Text = "show everything";
            this.HideCommandExecutionLog_0.UseVisualStyleBackColor = true;
            this.HideCommandExecutionLog_0.CheckedChanged += new System.EventHandler(this.HideCommandExecutionLog_0_CheckedChanged);
            // 
            // HideCommandExecutionLog_1
            // 
            this.HideCommandExecutionLog_1.AutoSize = true;
            this.HideCommandExecutionLog_1.Location = new System.Drawing.Point(3, 26);
            this.HideCommandExecutionLog_1.Name = "HideCommandExecutionLog_1";
            this.HideCommandExecutionLog_1.Size = new System.Drawing.Size(132, 17);
            this.HideCommandExecutionLog_1.TabIndex = 25;
            this.HideCommandExecutionLog_1.Text = "hide from 7DSM/telnet";
            this.HideCommandExecutionLog_1.UseVisualStyleBackColor = true;
            this.HideCommandExecutionLog_1.CheckedChanged += new System.EventHandler(this.HideCommandExecutionLog_1_CheckedChanged);
            // 
            // HideCommandExecutionLog_2
            // 
            this.HideCommandExecutionLog_2.AutoSize = true;
            this.HideCommandExecutionLog_2.Location = new System.Drawing.Point(3, 49);
            this.HideCommandExecutionLog_2.Name = "HideCommandExecutionLog_2";
            this.HideCommandExecutionLog_2.Size = new System.Drawing.Size(215, 17);
            this.HideCommandExecutionLog_2.TabIndex = 26;
            this.HideCommandExecutionLog_2.Text = "hite from &DSM/telnet and remote players";
            this.HideCommandExecutionLog_2.UseVisualStyleBackColor = true;
            this.HideCommandExecutionLog_2.CheckedChanged += new System.EventHandler(this.HideCommandExecutionLog_2_CheckedChanged);
            // 
            // HideCommandExecutionLog_3
            // 
            this.HideCommandExecutionLog_3.AutoSize = true;
            this.HideCommandExecutionLog_3.Location = new System.Drawing.Point(3, 72);
            this.HideCommandExecutionLog_3.Name = "HideCommandExecutionLog_3";
            this.HideCommandExecutionLog_3.Size = new System.Drawing.Size(97, 17);
            this.HideCommandExecutionLog_3.TabIndex = 27;
            this.HideCommandExecutionLog_3.Text = "hide everything";
            this.HideCommandExecutionLog_3.UseVisualStyleBackColor = true;
            this.HideCommandExecutionLog_3.CheckedChanged += new System.EventHandler(this.HideCommandExecutionLog_3_CheckedChanged);
            // 
            // ServerDisabledNetworkProtocols_g
            // 
            this.ServerDisabledNetworkProtocols_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerDisabledNetworkProtocols_g.Controls.Add(this.RakNet);
            this.ServerDisabledNetworkProtocols_g.Controls.Add(this.SteamNetworking);
            this.ServerDisabledNetworkProtocols_g.Controls.Add(this.UNET);
            this.ServerDisabledNetworkProtocols_g.Location = new System.Drawing.Point(8, 197);
            this.ServerDisabledNetworkProtocols_g.Name = "ServerDisabledNetworkProtocols_g";
            this.ServerDisabledNetworkProtocols_g.Size = new System.Drawing.Size(485, 100);
            this.ServerDisabledNetworkProtocols_g.TabIndex = 31;
            this.ServerDisabledNetworkProtocols_g.TabStop = false;
            this.ServerDisabledNetworkProtocols_g.Text = "Disabled network protocols";
            // 
            // RakNet
            // 
            this.RakNet.AutoSize = true;
            this.RakNet.Location = new System.Drawing.Point(9, 42);
            this.RakNet.Name = "RakNet";
            this.RakNet.Size = new System.Drawing.Size(63, 17);
            this.RakNet.TabIndex = 32;
            this.RakNet.Text = "RakNet";
            this.RakNet.UseVisualStyleBackColor = true;
            this.RakNet.CheckedChanged += new System.EventHandler(this.RakNet_CheckedChanged);
            // 
            // SteamNetworking
            // 
            this.SteamNetworking.AutoSize = true;
            this.SteamNetworking.Location = new System.Drawing.Point(9, 65);
            this.SteamNetworking.Name = "SteamNetworking";
            this.SteamNetworking.Size = new System.Drawing.Size(110, 17);
            this.SteamNetworking.TabIndex = 31;
            this.SteamNetworking.Text = "SteamNetworking";
            this.SteamNetworking.UseVisualStyleBackColor = true;
            this.SteamNetworking.CheckedChanged += new System.EventHandler(this.SteamNetworking_CheckedChanged);
            // 
            // UNET
            // 
            this.UNET.AutoSize = true;
            this.UNET.Location = new System.Drawing.Point(9, 19);
            this.UNET.Name = "UNET";
            this.UNET.Size = new System.Drawing.Size(56, 17);
            this.UNET.TabIndex = 30;
            this.UNET.Text = "UNET";
            this.UNET.UseVisualStyleBackColor = true;
            this.UNET.CheckedChanged += new System.EventHandler(this.UNET_CheckedChanged);
            // 
            // port_g
            // 
            this.port_g.Controls.Add(this.port);
            this.port_g.Location = new System.Drawing.Point(8, 303);
            this.port_g.Name = "port_g";
            this.port_g.Size = new System.Drawing.Size(485, 48);
            this.port_g.TabIndex = 23;
            this.port_g.TabStop = false;
            this.port_g.Text = "Server port";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(6, 19);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(70, 20);
            this.port.TabIndex = 0;
            this.port.Text = "26900";
            this.port.TextChanged += new System.EventHandler(this.port_TextChanged);
            // 
            // ctrlpanel
            // 
            this.ctrlpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlpanel.Controls.Add(this.cpl_port);
            this.ctrlpanel.Controls.Add(this.port_panel);
            this.ctrlpanel.Controls.Add(this.cpl_pass);
            this.ctrlpanel.Controls.Add(this.ctrlp);
            this.ctrlpanel.Controls.Add(this.ctrlppass);
            this.ctrlpanel.Location = new System.Drawing.Point(8, 3);
            this.ctrlpanel.Name = "ctrlpanel";
            this.ctrlpanel.Size = new System.Drawing.Size(485, 98);
            this.ctrlpanel.TabIndex = 26;
            this.ctrlpanel.TabStop = false;
            this.ctrlpanel.Text = "Control panel";
            // 
            // cpl_port
            // 
            this.cpl_port.AutoSize = true;
            this.cpl_port.Location = new System.Drawing.Point(9, 71);
            this.cpl_port.Name = "cpl_port";
            this.cpl_port.Size = new System.Drawing.Size(32, 13);
            this.cpl_port.TabIndex = 12;
            this.cpl_port.Text = "Port :";
            // 
            // port_panel
            // 
            this.port_panel.Location = new System.Drawing.Point(96, 68);
            this.port_panel.Name = "port_panel";
            this.port_panel.Size = new System.Drawing.Size(49, 20);
            this.port_panel.TabIndex = 11;
            this.port_panel.Text = "8080";
            this.port_panel.TextChanged += new System.EventHandler(this.port_panel_TextChanged);
            // 
            // cpl_pass
            // 
            this.cpl_pass.AutoSize = true;
            this.cpl_pass.Location = new System.Drawing.Point(10, 45);
            this.cpl_pass.Name = "cpl_pass";
            this.cpl_pass.Size = new System.Drawing.Size(56, 13);
            this.cpl_pass.TabIndex = 10;
            this.cpl_pass.Text = "Password:";
            // 
            // ctrlp
            // 
            this.ctrlp.AutoSize = true;
            this.ctrlp.Location = new System.Drawing.Point(9, 19);
            this.ctrlp.Name = "ctrlp";
            this.ctrlp.Size = new System.Drawing.Size(68, 17);
            this.ctrlp.TabIndex = 9;
            this.ctrlp.Text = "Allow cpl";
            this.ctrlp.UseVisualStyleBackColor = true;
            this.ctrlp.CheckedChanged += new System.EventHandler(this.ctrlp_CheckedChanged);
            // 
            // ctrlppass
            // 
            this.ctrlppass.Location = new System.Drawing.Point(96, 42);
            this.ctrlppass.Name = "ctrlppass";
            this.ctrlppass.PasswordChar = '*';
            this.ctrlppass.Size = new System.Drawing.Size(169, 20);
            this.ctrlppass.TabIndex = 8;
            this.ctrlppass.TextChanged += new System.EventHandler(this.ctrlppass_TextChanged);
            // 
            // telnet_g
            // 
            this.telnet_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telnet_g.Controls.Add(this.telnet_port_l);
            this.telnet_g.Controls.Add(this.telnet_port_p);
            this.telnet_g.Controls.Add(this.telnet_psw_l);
            this.telnet_g.Controls.Add(this.telnet_psw);
            this.telnet_g.Location = new System.Drawing.Point(8, 107);
            this.telnet_g.Name = "telnet_g";
            this.telnet_g.Size = new System.Drawing.Size(485, 84);
            this.telnet_g.TabIndex = 29;
            this.telnet_g.TabStop = false;
            this.telnet_g.Text = "telnet_g";
            // 
            // telnet_port_l
            // 
            this.telnet_port_l.AutoSize = true;
            this.telnet_port_l.Location = new System.Drawing.Point(9, 54);
            this.telnet_port_l.Name = "telnet_port_l";
            this.telnet_port_l.Size = new System.Drawing.Size(29, 13);
            this.telnet_port_l.TabIndex = 16;
            this.telnet_port_l.Text = "Port:";
            // 
            // telnet_port_p
            // 
            this.telnet_port_p.Location = new System.Drawing.Point(96, 51);
            this.telnet_port_p.Name = "telnet_port_p";
            this.telnet_port_p.Size = new System.Drawing.Size(49, 20);
            this.telnet_port_p.TabIndex = 15;
            this.telnet_port_p.Text = "8081";
            this.telnet_port_p.TextChanged += new System.EventHandler(this.Telnet_port_TextChanged);
            // 
            // telnet_psw_l
            // 
            this.telnet_psw_l.AutoSize = true;
            this.telnet_psw_l.Location = new System.Drawing.Point(10, 28);
            this.telnet_psw_l.Name = "telnet_psw_l";
            this.telnet_psw_l.Size = new System.Drawing.Size(56, 13);
            this.telnet_psw_l.TabIndex = 14;
            this.telnet_psw_l.Text = "Password:";
            // 
            // telnet_psw
            // 
            this.telnet_psw.Location = new System.Drawing.Point(96, 25);
            this.telnet_psw.Name = "telnet_psw";
            this.telnet_psw.PasswordChar = '*';
            this.telnet_psw.Size = new System.Drawing.Size(169, 20);
            this.telnet_psw.TabIndex = 13;
            this.telnet_psw.TextChanged += new System.EventHandler(this.Telnet_psw_TextChanged);
            // 
            // ikony_naglowka
            // 
            this.ikony_naglowka.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ikony_naglowka.ImageSize = new System.Drawing.Size(40, 40);
            this.ikony_naglowka.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // strings_page
            // 
            this.strings_page.BackColor = System.Drawing.SystemColors.Control;
            this.strings_page.Controls.Add(this.messages_g);
            this.strings_page.Controls.Add(this.customcommands_g);
            this.strings_page.ImageIndex = 3;
            this.strings_page.Location = new System.Drawing.Point(47, 4);
            this.strings_page.Name = "strings_page";
            this.strings_page.Padding = new System.Windows.Forms.Padding(3);
            this.strings_page.Size = new System.Drawing.Size(908, 684);
            this.strings_page.TabIndex = 13;
            // 
            // messages_g
            // 
            this.messages_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messages_g.Controls.Add(this.cmd_not_yet);
            this.messages_g.Controls.Add(this.cmd_not_yet_l);
            this.messages_g.Controls.Add(this.backup_msg_1);
            this.messages_g.Controls.Add(this.backup_msg_2_l);
            this.messages_g.Controls.Add(this.reboot);
            this.messages_g.Controls.Add(this.backup_msg_2);
            this.messages_g.Controls.Add(this.backup_msg_1_l);
            this.messages_g.Controls.Add(this.reboot_time_l);
            this.messages_g.Controls.Add(this.reboot_l);
            this.messages_g.Controls.Add(this.reboot_time);
            this.messages_g.Location = new System.Drawing.Point(9, 508);
            this.messages_g.Name = "messages_g";
            this.messages_g.Size = new System.Drawing.Size(892, 170);
            this.messages_g.TabIndex = 12;
            this.messages_g.TabStop = false;
            this.messages_g.Text = "messages_g";
            // 
            // cmd_not_yet
            // 
            this.cmd_not_yet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_not_yet.Location = new System.Drawing.Point(226, 123);
            this.cmd_not_yet.Name = "cmd_not_yet";
            this.cmd_not_yet.Size = new System.Drawing.Size(646, 20);
            this.cmd_not_yet.TabIndex = 12;
            this.cmd_not_yet.TextChanged += new System.EventHandler(this.Cmd_not_yet_TextChanged);
            // 
            // cmd_not_yet_l
            // 
            this.cmd_not_yet_l.AutoSize = true;
            this.cmd_not_yet_l.Location = new System.Drawing.Point(15, 126);
            this.cmd_not_yet_l.Name = "cmd_not_yet_l";
            this.cmd_not_yet_l.Size = new System.Drawing.Size(76, 13);
            this.cmd_not_yet_l.TabIndex = 13;
            this.cmd_not_yet_l.Text = "cmd_not_yet_l";
            // 
            // backup_msg_1
            // 
            this.backup_msg_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backup_msg_1.Location = new System.Drawing.Point(226, 19);
            this.backup_msg_1.Name = "backup_msg_1";
            this.backup_msg_1.Size = new System.Drawing.Size(646, 20);
            this.backup_msg_1.TabIndex = 4;
            this.backup_msg_1.TextChanged += new System.EventHandler(this.Backup_msg_1_TextChanged);
            // 
            // backup_msg_2_l
            // 
            this.backup_msg_2_l.AutoSize = true;
            this.backup_msg_2_l.Location = new System.Drawing.Point(15, 48);
            this.backup_msg_2_l.Name = "backup_msg_2_l";
            this.backup_msg_2_l.Size = new System.Drawing.Size(88, 13);
            this.backup_msg_2_l.TabIndex = 11;
            this.backup_msg_2_l.Text = "backup_msg_2_l";
            // 
            // reboot
            // 
            this.reboot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reboot.Location = new System.Drawing.Point(226, 97);
            this.reboot.Name = "reboot";
            this.reboot.Size = new System.Drawing.Size(646, 20);
            this.reboot.TabIndex = 5;
            this.reboot.TextChanged += new System.EventHandler(this.Reboot_TextChanged);
            // 
            // backup_msg_2
            // 
            this.backup_msg_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backup_msg_2.Location = new System.Drawing.Point(226, 45);
            this.backup_msg_2.Name = "backup_msg_2";
            this.backup_msg_2.Size = new System.Drawing.Size(646, 20);
            this.backup_msg_2.TabIndex = 10;
            this.backup_msg_2.TextChanged += new System.EventHandler(this.Backup_msg_2_TextChanged);
            // 
            // backup_msg_1_l
            // 
            this.backup_msg_1_l.AutoSize = true;
            this.backup_msg_1_l.Location = new System.Drawing.Point(15, 22);
            this.backup_msg_1_l.Name = "backup_msg_1_l";
            this.backup_msg_1_l.Size = new System.Drawing.Size(88, 13);
            this.backup_msg_1_l.TabIndex = 6;
            this.backup_msg_1_l.Text = "backup_msg_1_l";
            // 
            // reboot_time_l
            // 
            this.reboot_time_l.AutoSize = true;
            this.reboot_time_l.Location = new System.Drawing.Point(15, 74);
            this.reboot_time_l.Name = "reboot_time_l";
            this.reboot_time_l.Size = new System.Drawing.Size(70, 13);
            this.reboot_time_l.TabIndex = 9;
            this.reboot_time_l.Text = "reboot_time_l";
            // 
            // reboot_l
            // 
            this.reboot_l.AutoSize = true;
            this.reboot_l.Location = new System.Drawing.Point(15, 100);
            this.reboot_l.Name = "reboot_l";
            this.reboot_l.Size = new System.Drawing.Size(45, 13);
            this.reboot_l.TabIndex = 7;
            this.reboot_l.Text = "reboot_l";
            // 
            // reboot_time
            // 
            this.reboot_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reboot_time.Location = new System.Drawing.Point(226, 71);
            this.reboot_time.Name = "reboot_time";
            this.reboot_time.Size = new System.Drawing.Size(646, 20);
            this.reboot_time.TabIndex = 8;
            this.reboot_time.TextChanged += new System.EventHandler(this.Reboot_time_TextChanged);
            // 
            // customcommands_g
            // 
            this.customcommands_g.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customcommands_g.Controls.Add(this.how_to_commands2);
            this.customcommands_g.Controls.Add(this.excall_file_l);
            this.customcommands_g.Controls.Add(this.excall_file);
            this.customcommands_g.Controls.Add(this.excall);
            this.customcommands_g.Controls.Add(this.enable_cc);
            this.customcommands_g.Controls.Add(this.how_to_commands);
            this.customcommands_g.Controls.Add(this.customcommands);
            this.customcommands_g.Location = new System.Drawing.Point(9, 8);
            this.customcommands_g.Name = "customcommands_g";
            this.customcommands_g.Size = new System.Drawing.Size(892, 494);
            this.customcommands_g.TabIndex = 14;
            this.customcommands_g.TabStop = false;
            this.customcommands_g.Text = "customcommands_g";
            // 
            // how_to_commands2
            // 
            this.how_to_commands2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.how_to_commands2.Location = new System.Drawing.Point(700, 465);
            this.how_to_commands2.Name = "how_to_commands2";
            this.how_to_commands2.Size = new System.Drawing.Size(178, 23);
            this.how_to_commands2.TabIndex = 19;
            this.how_to_commands2.Text = "How to use external calling?";
            this.how_to_commands2.UseVisualStyleBackColor = true;
            this.how_to_commands2.Click += new System.EventHandler(this.how_to_commands2_Click);
            // 
            // excall_file_l
            // 
            this.excall_file_l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.excall_file_l.AutoSize = true;
            this.excall_file_l.Location = new System.Drawing.Point(140, 432);
            this.excall_file_l.Name = "excall_file_l";
            this.excall_file_l.Size = new System.Drawing.Size(37, 13);
            this.excall_file_l.TabIndex = 18;
            this.excall_file_l.Text = "(none)";
            // 
            // excall_file
            // 
            this.excall_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.excall_file.Enabled = false;
            this.excall_file.Location = new System.Drawing.Point(18, 427);
            this.excall_file.Name = "excall_file";
            this.excall_file.Size = new System.Drawing.Size(116, 23);
            this.excall_file.TabIndex = 17;
            this.excall_file.Text = "Select file to call";
            this.excall_file.UseVisualStyleBackColor = true;
            this.excall_file.Click += new System.EventHandler(this.excall_file_Click);
            // 
            // excall
            // 
            this.excall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.excall.AutoSize = true;
            this.excall.Location = new System.Drawing.Point(18, 404);
            this.excall.Name = "excall";
            this.excall.Size = new System.Drawing.Size(370, 17);
            this.excall.TabIndex = 16;
            this.excall.Text = "Instead use external call (harder to use, but gives much more possibilities)";
            this.excall.UseVisualStyleBackColor = true;
            this.excall.CheckedChanged += new System.EventHandler(this.excall_CheckedChanged);
            // 
            // enable_cc
            // 
            this.enable_cc.AutoSize = true;
            this.enable_cc.Location = new System.Drawing.Point(18, 19);
            this.enable_cc.Name = "enable_cc";
            this.enable_cc.Size = new System.Drawing.Size(76, 17);
            this.enable_cc.TabIndex = 15;
            this.enable_cc.Text = "enable_cc";
            this.enable_cc.UseVisualStyleBackColor = true;
            this.enable_cc.CheckedChanged += new System.EventHandler(this.Enable_cc_CheckedChanged);
            // 
            // how_to_commands
            // 
            this.how_to_commands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.how_to_commands.Location = new System.Drawing.Point(700, 384);
            this.how_to_commands.Name = "how_to_commands";
            this.how_to_commands.Size = new System.Drawing.Size(178, 23);
            this.how_to_commands.TabIndex = 14;
            this.how_to_commands.Text = "how_to_commands";
            this.how_to_commands.UseVisualStyleBackColor = true;
            this.how_to_commands.Click += new System.EventHandler(this.How_to_commands_Click);
            // 
            // customcommands
            // 
            this.customcommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customcommands.Location = new System.Drawing.Point(18, 42);
            this.customcommands.Name = "customcommands";
            this.customcommands.Size = new System.Drawing.Size(860, 336);
            this.customcommands.TabIndex = 13;
            this.customcommands.Text = "";
            this.customcommands.TextChanged += new System.EventHandler(this.Customcommands_TextChanged);
            // 
            // globalBanList
            // 
            this.globalBanList.BackColor = System.Drawing.SystemColors.Control;
            this.globalBanList.Controls.Add(this.check_bans);
            this.globalBanList.Controls.Add(this.global_ban_g);
            this.globalBanList.Controls.Add(this.banlist_logo);
            this.globalBanList.ImageIndex = 10;
            this.globalBanList.Location = new System.Drawing.Point(47, 4);
            this.globalBanList.Name = "globalBanList";
            this.globalBanList.Padding = new System.Windows.Forms.Padding(3);
            this.globalBanList.Size = new System.Drawing.Size(908, 684);
            this.globalBanList.TabIndex = 17;
            // 
            // check_bans
            // 
            this.check_bans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.check_bans.Location = new System.Drawing.Point(741, 346);
            this.check_bans.Name = "check_bans";
            this.check_bans.Size = new System.Drawing.Size(161, 30);
            this.check_bans.TabIndex = 29;
            this.check_bans.Text = "Check if player is banned";
            this.check_bans.UseVisualStyleBackColor = true;
            this.check_bans.Click += new System.EventHandler(this.check_bans_Click);
            // 
            // global_ban_g
            // 
            this.global_ban_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.global_ban_g.Controls.Add(this.sendbans);
            this.global_ban_g.Controls.Add(this.label1);
            this.global_ban_g.Controls.Add(this.glob_3);
            this.global_ban_g.Controls.Add(this.glob_0);
            this.global_ban_g.Controls.Add(this.glob_2);
            this.global_ban_g.Controls.Add(this.glob_1);
            this.global_ban_g.Location = new System.Drawing.Point(6, 159);
            this.global_ban_g.Name = "global_ban_g";
            this.global_ban_g.Size = new System.Drawing.Size(895, 181);
            this.global_ban_g.TabIndex = 27;
            this.global_ban_g.TabStop = false;
            this.global_ban_g.Text = "7DSM global banlist";
            // 
            // sendbans
            // 
            this.sendbans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendbans.AutoSize = true;
            this.sendbans.Checked = true;
            this.sendbans.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sendbans.Location = new System.Drawing.Point(611, 19);
            this.sendbans.Name = "sendbans";
            this.sendbans.Size = new System.Drawing.Size(271, 30);
            this.sendbans.TabIndex = 6;
            this.sendbans.Text = "Share my list of banned players to help other servers\r\n(please do not turn it off" +
    " if not necessary)\r\n";
            this.sendbans.UseVisualStyleBackColor = true;
            this.sendbans.CheckedChanged += new System.EventHandler(this.sendbans_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player banned on 1 or 2 servers is monitored.\r\nFor every next ban player gets glo" +
    "balban for 1 month (not cumulative).";
            // 
            // glob_3
            // 
            this.glob_3.AutoSize = true;
            this.glob_3.Location = new System.Drawing.Point(6, 88);
            this.glob_3.Name = "glob_3";
            this.glob_3.Size = new System.Drawing.Size(313, 17);
            this.glob_3.TabIndex = 4;
            this.glob_3.TabStop = true;
            this.glob_3.Text = "Don\'t allow monitored players (banned on less than 3 servers)";
            this.glob_3.UseVisualStyleBackColor = true;
            this.glob_3.CheckedChanged += new System.EventHandler(this.glob_0_CheckedChanged);
            // 
            // glob_0
            // 
            this.glob_0.AutoSize = true;
            this.glob_0.Location = new System.Drawing.Point(6, 19);
            this.glob_0.Name = "glob_0";
            this.glob_0.Size = new System.Drawing.Size(133, 17);
            this.glob_0.TabIndex = 3;
            this.glob_0.TabStop = true;
            this.glob_0.Text = "Allow everybody to join";
            this.glob_0.UseVisualStyleBackColor = true;
            this.glob_0.CheckedChanged += new System.EventHandler(this.glob_0_CheckedChanged);
            // 
            // glob_2
            // 
            this.glob_2.AutoSize = true;
            this.glob_2.Location = new System.Drawing.Point(6, 65);
            this.glob_2.Name = "glob_2";
            this.glob_2.Size = new System.Drawing.Size(221, 17);
            this.glob_2.TabIndex = 2;
            this.glob_2.TabStop = true;
            this.glob_2.Text = "Don\'t allow globally banned players to join";
            this.glob_2.UseVisualStyleBackColor = true;
            this.glob_2.CheckedChanged += new System.EventHandler(this.glob_0_CheckedChanged);
            // 
            // glob_1
            // 
            this.glob_1.AutoSize = true;
            this.glob_1.Checked = true;
            this.glob_1.Location = new System.Drawing.Point(6, 42);
            this.glob_1.Name = "glob_1";
            this.glob_1.Size = new System.Drawing.Size(305, 17);
            this.glob_1.TabIndex = 0;
            this.glob_1.TabStop = true;
            this.glob_1.Text = "Warn me when globally banned player joins, but let him play\r\n";
            this.glob_1.UseVisualStyleBackColor = true;
            this.glob_1.CheckedChanged += new System.EventHandler(this.glob_0_CheckedChanged);
            // 
            // banlist_logo
            // 
            this.banlist_logo.Image = ((System.Drawing.Image)(resources.GetObject("banlist_logo.Image")));
            this.banlist_logo.Location = new System.Drawing.Point(15, 8);
            this.banlist_logo.Name = "banlist_logo";
            this.banlist_logo.Size = new System.Drawing.Size(632, 96);
            this.banlist_logo.TabIndex = 28;
            this.banlist_logo.TabStop = false;
            // 
            // WebServer
            // 
            this.WebServer.BackColor = System.Drawing.SystemColors.Control;
            this.WebServer.Controls.Add(this.autofix_g);
            this.WebServer.Controls.Add(this.website_g);
            this.WebServer.Controls.Add(this.android_g);
            this.WebServer.ImageIndex = 11;
            this.WebServer.Location = new System.Drawing.Point(47, 4);
            this.WebServer.Name = "WebServer";
            this.WebServer.Size = new System.Drawing.Size(908, 684);
            this.WebServer.TabIndex = 18;
            // 
            // autofix_g
            // 
            this.autofix_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autofix_g.Controls.Add(this.reverse_reservation);
            this.autofix_g.Controls.Add(this.conflict_l);
            this.autofix_g.Controls.Add(this.fix_firewall_and_other_windows_shit);
            this.autofix_g.Controls.Add(this.fix_l);
            this.autofix_g.Location = new System.Drawing.Point(15, 596);
            this.autofix_g.Name = "autofix_g";
            this.autofix_g.Size = new System.Drawing.Size(886, 82);
            this.autofix_g.TabIndex = 2;
            this.autofix_g.TabStop = false;
            this.autofix_g.Text = "Autofix";
            // 
            // reverse_reservation
            // 
            this.reverse_reservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reverse_reservation.Location = new System.Drawing.Point(748, 48);
            this.reverse_reservation.Name = "reverse_reservation";
            this.reverse_reservation.Size = new System.Drawing.Size(128, 23);
            this.reverse_reservation.TabIndex = 2;
            this.reverse_reservation.Text = "Cancel reservations";
            this.reverse_reservation.UseVisualStyleBackColor = true;
            this.reverse_reservation.Click += new System.EventHandler(this.reverse_reservation_Click);
            // 
            // conflict_l
            // 
            this.conflict_l.AutoSize = true;
            this.conflict_l.Location = new System.Drawing.Point(6, 45);
            this.conflict_l.Name = "conflict_l";
            this.conflict_l.Size = new System.Drawing.Size(504, 26);
            this.conflict_l.TabIndex = 3;
            this.conflict_l.Text = "If 7DSM have conflicts with other software that you use (eg. Apache) you can canc" +
    "el 7DSM reservations.\r\nWebsite and widget will stop working. You can always rest" +
    "ore reservations with Autofix.";
            // 
            // fix_firewall_and_other_windows_shit
            // 
            this.fix_firewall_and_other_windows_shit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fix_firewall_and_other_windows_shit.Location = new System.Drawing.Point(748, 15);
            this.fix_firewall_and_other_windows_shit.Name = "fix_firewall_and_other_windows_shit";
            this.fix_firewall_and_other_windows_shit.Size = new System.Drawing.Size(128, 23);
            this.fix_firewall_and_other_windows_shit.TabIndex = 28;
            this.fix_firewall_and_other_windows_shit.Text = "Run Autofix";
            this.fix_firewall_and_other_windows_shit.UseVisualStyleBackColor = true;
            this.fix_firewall_and_other_windows_shit.Click += new System.EventHandler(this.fix_firewall_and_other_windows_shit_Click);
            // 
            // fix_l
            // 
            this.fix_l.AutoSize = true;
            this.fix_l.Location = new System.Drawing.Point(7, 20);
            this.fix_l.Name = "fix_l";
            this.fix_l.Size = new System.Drawing.Size(538, 13);
            this.fix_l.TabIndex = 29;
            this.fix_l.Text = "If you can\'t open website or use widget, try this automatic fix. It sets up Windo" +
    "ws to pass the connection through.";
            // 
            // website_g
            // 
            this.website_g.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.website_g.Controls.Add(this.www_rules_content);
            this.website_g.Controls.Add(this.website_l);
            this.website_g.Controls.Add(this.enable_website);
            this.website_g.Location = new System.Drawing.Point(15, 8);
            this.website_g.Name = "website_g";
            this.website_g.Size = new System.Drawing.Size(886, 488);
            this.website_g.TabIndex = 1;
            this.website_g.TabStop = false;
            this.website_g.Text = "7DSM Website";
            // 
            // www_rules_content
            // 
            this.www_rules_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.www_rules_content.Controls.Add(this.home_tab);
            this.www_rules_content.Controls.Add(this.rules_tab);
            this.www_rules_content.Controls.Add(this.other_tab);
            this.www_rules_content.Location = new System.Drawing.Point(10, 42);
            this.www_rules_content.Name = "www_rules_content";
            this.www_rules_content.SelectedIndex = 0;
            this.www_rules_content.Size = new System.Drawing.Size(866, 418);
            this.www_rules_content.TabIndex = 5;
            // 
            // home_tab
            // 
            this.home_tab.BackColor = System.Drawing.SystemColors.Control;
            this.home_tab.Controls.Add(this.www_main_content);
            this.home_tab.Location = new System.Drawing.Point(4, 22);
            this.home_tab.Name = "home_tab";
            this.home_tab.Padding = new System.Windows.Forms.Padding(3);
            this.home_tab.Size = new System.Drawing.Size(858, 392);
            this.home_tab.TabIndex = 0;
            this.home_tab.Text = "Home";
            // 
            // www_main_content
            // 
            this.www_main_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.www_main_content.Location = new System.Drawing.Point(3, 3);
            this.www_main_content.Name = "www_main_content";
            this.www_main_content.Size = new System.Drawing.Size(852, 386);
            this.www_main_content.TabIndex = 4;
            this.www_main_content.Text = resources.GetString("www_main_content.Text");
            this.www_main_content.TextChanged += new System.EventHandler(this.www_main_content_TextChanged);
            // 
            // rules_tab
            // 
            this.rules_tab.BackColor = System.Drawing.SystemColors.Control;
            this.rules_tab.Controls.Add(this.rules_content);
            this.rules_tab.Location = new System.Drawing.Point(4, 22);
            this.rules_tab.Name = "rules_tab";
            this.rules_tab.Padding = new System.Windows.Forms.Padding(3);
            this.rules_tab.Size = new System.Drawing.Size(858, 392);
            this.rules_tab.TabIndex = 1;
            this.rules_tab.Text = "Rules";
            // 
            // rules_content
            // 
            this.rules_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rules_content.Location = new System.Drawing.Point(3, 3);
            this.rules_content.Name = "rules_content";
            this.rules_content.Size = new System.Drawing.Size(852, 386);
            this.rules_content.TabIndex = 5;
            this.rules_content.Text = resources.GetString("rules_content.Text");
            this.rules_content.TextChanged += new System.EventHandler(this.rules_content_TextChanged);
            // 
            // other_tab
            // 
            this.other_tab.BackColor = System.Drawing.SystemColors.Control;
            this.other_tab.Controls.Add(this.prem_help3);
            this.other_tab.Controls.Add(this.hide_footer);
            this.other_tab.Controls.Add(this.allowed_replacements_l);
            this.other_tab.Controls.Add(this.allowed_replacements);
            this.other_tab.Controls.Add(this.forum_url);
            this.other_tab.Controls.Add(this.forum_url_l);
            this.other_tab.Location = new System.Drawing.Point(4, 22);
            this.other_tab.Name = "other_tab";
            this.other_tab.Size = new System.Drawing.Size(858, 392);
            this.other_tab.TabIndex = 2;
            this.other_tab.Text = "Other";
            // 
            // prem_help3
            // 
            this.prem_help3.Image = ((System.Drawing.Image)(resources.GetObject("prem_help3.Image")));
            this.prem_help3.Location = new System.Drawing.Point(95, 51);
            this.prem_help3.Name = "prem_help3";
            this.prem_help3.Size = new System.Drawing.Size(16, 16);
            this.prem_help3.TabIndex = 41;
            this.prem_help3.TabStop = false;
            this.toolTip.SetToolTip(this.prem_help3, "You need 7DSM Supporter to change these options.\r\nIt\'s almost free, please check " +
        "it out in \"Settings\" tab.");
            // 
            // hide_footer
            // 
            this.hide_footer.AutoSize = true;
            this.hide_footer.Location = new System.Drawing.Point(11, 51);
            this.hide_footer.Name = "hide_footer";
            this.hide_footer.Size = new System.Drawing.Size(78, 17);
            this.hide_footer.TabIndex = 6;
            this.hide_footer.Text = "Hide footer";
            this.hide_footer.UseVisualStyleBackColor = true;
            this.hide_footer.CheckedChanged += new System.EventHandler(this.hide_footer_CheckedChanged);
            // 
            // allowed_replacements_l
            // 
            this.allowed_replacements_l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.allowed_replacements_l.AutoSize = true;
            this.allowed_replacements_l.Location = new System.Drawing.Point(540, 278);
            this.allowed_replacements_l.Name = "allowed_replacements_l";
            this.allowed_replacements_l.Size = new System.Drawing.Size(258, 13);
            this.allowed_replacements_l.TabIndex = 5;
            this.allowed_replacements_l.Text = "Type these in Home/Rules to get server informations:";
            // 
            // allowed_replacements
            // 
            this.allowed_replacements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.allowed_replacements.FormattingEnabled = true;
            this.allowed_replacements.Items.AddRange(new object[] {
            "{server_name} -Shows server name",
            "{server_ip} -Shows server IP",
            "{server_port} -Shows server port",
            "{server_players} -Shows current number of players",
            "{server_players_max} -Shows maximum number of players",
            "{server_is_online} -Shows ONLINE/OFFLINE text",
            "{forum_url}  -Shows Forum URL"});
            this.allowed_replacements.Location = new System.Drawing.Point(543, 294);
            this.allowed_replacements.MultiColumn = true;
            this.allowed_replacements.Name = "allowed_replacements";
            this.allowed_replacements.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.allowed_replacements.Size = new System.Drawing.Size(312, 95);
            this.allowed_replacements.TabIndex = 4;
            // 
            // forum_url
            // 
            this.forum_url.Location = new System.Drawing.Point(78, 12);
            this.forum_url.Name = "forum_url";
            this.forum_url.Size = new System.Drawing.Size(307, 20);
            this.forum_url.TabIndex = 2;
            this.forum_url.Text = "https://7daystodie.com/forums/";
            this.forum_url.TextChanged += new System.EventHandler(this.forum_url_TextChanged);
            // 
            // forum_url_l
            // 
            this.forum_url_l.AutoSize = true;
            this.forum_url_l.Location = new System.Drawing.Point(8, 15);
            this.forum_url_l.Name = "forum_url_l";
            this.forum_url_l.Size = new System.Drawing.Size(64, 13);
            this.forum_url_l.TabIndex = 3;
            this.forum_url_l.Text = "Forum URL:";
            // 
            // website_l
            // 
            this.website_l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.website_l.AutoSize = true;
            this.website_l.Location = new System.Drawing.Point(3, 472);
            this.website_l.Name = "website_l";
            this.website_l.Size = new System.Drawing.Size(258, 13);
            this.website_l.TabIndex = 1;
            this.website_l.Text = "Website can be accessed via your public IP address.";
            // 
            // enable_website
            // 
            this.enable_website.AutoSize = true;
            this.enable_website.Location = new System.Drawing.Point(9, 19);
            this.enable_website.Name = "enable_website";
            this.enable_website.Size = new System.Drawing.Size(98, 17);
            this.enable_website.TabIndex = 0;
            this.enable_website.Text = "Enable website";
            this.enable_website.UseVisualStyleBackColor = true;
            this.enable_website.CheckedChanged += new System.EventHandler(this.enable_website_CheckedChanged);
            // 
            // android_g
            // 
            this.android_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.android_g.Controls.Add(this.or_l);
            this.android_g.Controls.Add(this.android_apk);
            this.android_g.Controls.Add(this.android_play);
            this.android_g.Controls.Add(this.android_allow);
            this.android_g.Controls.Add(this.android_access_key);
            this.android_g.Location = new System.Drawing.Point(15, 502);
            this.android_g.Name = "android_g";
            this.android_g.Size = new System.Drawing.Size(886, 88);
            this.android_g.TabIndex = 0;
            this.android_g.TabStop = false;
            this.android_g.Text = "Android Widget";
            // 
            // or_l
            // 
            this.or_l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.or_l.AutoSize = true;
            this.or_l.Location = new System.Drawing.Point(729, 48);
            this.or_l.Name = "or_l";
            this.or_l.Size = new System.Drawing.Size(16, 13);
            this.or_l.TabIndex = 2;
            this.or_l.Text = "or";
            this.or_l.Visible = false;
            // 
            // android_apk
            // 
            this.android_apk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.android_apk.Location = new System.Drawing.Point(748, 33);
            this.android_apk.Name = "android_apk";
            this.android_apk.Size = new System.Drawing.Size(128, 42);
            this.android_apk.TabIndex = 27;
            this.android_apk.Text = "Download .APK file";
            this.android_apk.UseVisualStyleBackColor = true;
            this.android_apk.Click += new System.EventHandler(this.android_apk_Click);
            // 
            // android_play
            // 
            this.android_play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.android_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.android_play.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.android_play.FlatAppearance.BorderSize = 0;
            this.android_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.android_play.Image = ((System.Drawing.Image)(resources.GetObject("android_play.Image")));
            this.android_play.Location = new System.Drawing.Point(571, 31);
            this.android_play.Margin = new System.Windows.Forms.Padding(0);
            this.android_play.Name = "android_play";
            this.android_play.Size = new System.Drawing.Size(153, 46);
            this.android_play.TabIndex = 26;
            this.android_play.UseVisualStyleBackColor = true;
            this.android_play.Visible = false;
            this.android_play.Click += new System.EventHandler(this.android_play_Click);
            // 
            // android_allow
            // 
            this.android_allow.AutoSize = true;
            this.android_allow.Location = new System.Drawing.Point(9, 19);
            this.android_allow.Name = "android_allow";
            this.android_allow.Size = new System.Drawing.Size(85, 17);
            this.android_allow.TabIndex = 1;
            this.android_allow.Text = "Allow widget";
            this.android_allow.UseVisualStyleBackColor = true;
            this.android_allow.CheckedChanged += new System.EventHandler(this.android_allow_CheckedChanged);
            // 
            // android_access_key
            // 
            this.android_access_key.AutoSize = true;
            this.android_access_key.Location = new System.Drawing.Point(7, 39);
            this.android_access_key.Name = "android_access_key";
            this.android_access_key.Size = new System.Drawing.Size(100, 13);
            this.android_access_key.TabIndex = 0;
            this.android_access_key.Text = "Android access key";
            // 
            // tasks
            // 
            this.tasks.BackColor = System.Drawing.SystemColors.Control;
            this.tasks.Controls.Add(this.reset_g);
            this.tasks.Controls.Add(this.spam_g);
            this.tasks.Controls.Add(this.whitelist_dl_g);
            this.tasks.ImageIndex = 7;
            this.tasks.Location = new System.Drawing.Point(47, 4);
            this.tasks.Name = "tasks";
            this.tasks.Padding = new System.Windows.Forms.Padding(3);
            this.tasks.Size = new System.Drawing.Size(908, 684);
            this.tasks.TabIndex = 12;
            this.tasks.Text = " ";
            // 
            // reset_g
            // 
            this.reset_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reset_g.Controls.Add(this.reset_chat);
            this.reset_g.Controls.Add(this.reset_enabled);
            this.reset_g.Controls.Add(this.reset_time);
            this.reset_g.Location = new System.Drawing.Point(8, 8);
            this.reset_g.Name = "reset_g";
            this.reset_g.Size = new System.Drawing.Size(893, 65);
            this.reset_g.TabIndex = 34;
            this.reset_g.TabStop = false;
            this.reset_g.Text = "reset_g";
            // 
            // reset_chat
            // 
            this.reset_chat.AutoSize = true;
            this.reset_chat.Checked = true;
            this.reset_chat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reset_chat.Enabled = false;
            this.reset_chat.Location = new System.Drawing.Point(9, 42);
            this.reset_chat.Name = "reset_chat";
            this.reset_chat.Size = new System.Drawing.Size(76, 17);
            this.reset_chat.TabIndex = 10;
            this.reset_chat.Text = "reset_chat";
            this.reset_chat.UseVisualStyleBackColor = true;
            this.reset_chat.CheckedChanged += new System.EventHandler(this.Reset_chat_CheckedChanged);
            // 
            // reset_enabled
            // 
            this.reset_enabled.AutoSize = true;
            this.reset_enabled.Location = new System.Drawing.Point(9, 19);
            this.reset_enabled.Name = "reset_enabled";
            this.reset_enabled.Size = new System.Drawing.Size(93, 17);
            this.reset_enabled.TabIndex = 9;
            this.reset_enabled.Text = "reset_enabled";
            this.reset_enabled.UseVisualStyleBackColor = true;
            this.reset_enabled.CheckedChanged += new System.EventHandler(this.Reset_enabled_CheckedChanged);
            // 
            // reset_time
            // 
            this.reset_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reset_time.Enabled = false;
            this.reset_time.Location = new System.Drawing.Point(220, 14);
            this.reset_time.Maximum = 48;
            this.reset_time.Minimum = 1;
            this.reset_time.Name = "reset_time";
            this.reset_time.Size = new System.Drawing.Size(667, 45);
            this.reset_time.TabIndex = 8;
            this.reset_time.Value = 16;
            this.reset_time.Scroll += new System.EventHandler(this.reset_time_Scroll);
            // 
            // spam_g
            // 
            this.spam_g.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spam_g.Controls.Add(this.spam_is_spam);
            this.spam_g.Controls.Add(this.spaminfo);
            this.spam_g.Controls.Add(this.spam_list);
            this.spam_g.Controls.Add(this.spam_time_g);
            this.spam_g.Location = new System.Drawing.Point(8, 173);
            this.spam_g.Name = "spam_g";
            this.spam_g.Size = new System.Drawing.Size(893, 505);
            this.spam_g.TabIndex = 33;
            this.spam_g.TabStop = false;
            this.spam_g.Text = "spam_g";
            // 
            // spam_is_spam
            // 
            this.spam_is_spam.AutoSize = true;
            this.spam_is_spam.Location = new System.Drawing.Point(9, 32);
            this.spam_is_spam.Name = "spam_is_spam";
            this.spam_is_spam.Size = new System.Drawing.Size(95, 17);
            this.spam_is_spam.TabIndex = 4;
            this.spam_is_spam.Text = "spam_is_spam";
            this.spam_is_spam.UseVisualStyleBackColor = true;
            this.spam_is_spam.CheckedChanged += new System.EventHandler(this.Spam_is_spam_CheckedChanged);
            // 
            // spaminfo
            // 
            this.spaminfo.AutoSize = true;
            this.spaminfo.Location = new System.Drawing.Point(6, 16);
            this.spaminfo.Name = "spaminfo";
            this.spaminfo.Size = new System.Drawing.Size(49, 13);
            this.spaminfo.TabIndex = 1;
            this.spaminfo.Text = "spaminfo";
            // 
            // spam_list
            // 
            this.spam_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spam_list.Location = new System.Drawing.Point(9, 54);
            this.spam_list.Name = "spam_list";
            this.spam_list.Size = new System.Drawing.Size(878, 372);
            this.spam_list.TabIndex = 0;
            this.spam_list.Text = "";
            this.spam_list.TextChanged += new System.EventHandler(this.spam_list_TextChanged);
            // 
            // spam_time_g
            // 
            this.spam_time_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spam_time_g.Controls.Add(this.spam_time);
            this.spam_time_g.Location = new System.Drawing.Point(9, 432);
            this.spam_time_g.Name = "spam_time_g";
            this.spam_time_g.Size = new System.Drawing.Size(878, 67);
            this.spam_time_g.TabIndex = 3;
            this.spam_time_g.TabStop = false;
            this.spam_time_g.Text = "spam_time_g";
            // 
            // spam_time
            // 
            this.spam_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spam_time.Location = new System.Drawing.Point(6, 19);
            this.spam_time.Maximum = 240;
            this.spam_time.Minimum = 1;
            this.spam_time.Name = "spam_time";
            this.spam_time.Size = new System.Drawing.Size(866, 45);
            this.spam_time.TabIndex = 2;
            this.spam_time.Value = 1;
            this.spam_time.Scroll += new System.EventHandler(this.spam_time_Scroll);
            // 
            // whitelist_dl_g
            // 
            this.whitelist_dl_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.whitelist_dl_g.Controls.Add(this.use_wl);
            this.whitelist_dl_g.Controls.Add(this.min_l);
            this.whitelist_dl_g.Controls.Add(this.wl_interval);
            this.whitelist_dl_g.Controls.Add(this.wl_chk);
            this.whitelist_dl_g.Controls.Add(this.wl_add_l);
            this.whitelist_dl_g.Controls.Add(this.wl_add);
            this.whitelist_dl_g.Location = new System.Drawing.Point(8, 79);
            this.whitelist_dl_g.Name = "whitelist_dl_g";
            this.whitelist_dl_g.Size = new System.Drawing.Size(893, 88);
            this.whitelist_dl_g.TabIndex = 35;
            this.whitelist_dl_g.TabStop = false;
            this.whitelist_dl_g.Text = "Whitelist";
            // 
            // use_wl
            // 
            this.use_wl.AutoSize = true;
            this.use_wl.Location = new System.Drawing.Point(9, 19);
            this.use_wl.Name = "use_wl";
            this.use_wl.Size = new System.Drawing.Size(532, 17);
            this.use_wl.TabIndex = 5;
            this.use_wl.Text = "Use whitelist (File must be put in main game folder, named whitelist.txt. Every n" +
    "ickname must be in new line.)";
            this.use_wl.UseVisualStyleBackColor = true;
            this.use_wl.CheckedChanged += new System.EventHandler(this.use_wl_CheckedChanged);
            // 
            // min_l
            // 
            this.min_l.AutoSize = true;
            this.min_l.Location = new System.Drawing.Point(198, 44);
            this.min_l.Name = "min_l";
            this.min_l.Size = new System.Drawing.Size(141, 13);
            this.min_l.TabIndex = 4;
            this.min_l.Text = "minutes from external server:";
            // 
            // wl_interval
            // 
            this.wl_interval.Location = new System.Drawing.Point(165, 41);
            this.wl_interval.Name = "wl_interval";
            this.wl_interval.Size = new System.Drawing.Size(27, 20);
            this.wl_interval.TabIndex = 3;
            this.wl_interval.Text = "60";
            this.wl_interval.TextChanged += new System.EventHandler(this.wl_interval_TextChanged);
            // 
            // wl_chk
            // 
            this.wl_chk.AutoSize = true;
            this.wl_chk.Location = new System.Drawing.Point(9, 43);
            this.wl_chk.Name = "wl_chk";
            this.wl_chk.Size = new System.Drawing.Size(150, 17);
            this.wl_chk.TabIndex = 2;
            this.wl_chk.Text = "Autoupdate whitelist every";
            this.wl_chk.UseVisualStyleBackColor = true;
            this.wl_chk.CheckedChanged += new System.EventHandler(this.wl_chk_CheckedChanged);
            // 
            // wl_add_l
            // 
            this.wl_add_l.AutoSize = true;
            this.wl_add_l.Location = new System.Drawing.Point(342, 63);
            this.wl_add_l.Name = "wl_add_l";
            this.wl_add_l.Size = new System.Drawing.Size(398, 13);
            this.wl_add_l.TabIndex = 1;
            this.wl_add_l.Text = "(Put direct address to whitelist.txt file. Don\'t forget to put http(s):// on the " +
    "beggining)";
            // 
            // wl_add
            // 
            this.wl_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wl_add.Location = new System.Drawing.Point(345, 41);
            this.wl_add.Name = "wl_add";
            this.wl_add.Size = new System.Drawing.Size(542, 20);
            this.wl_add.TabIndex = 0;
            this.wl_add.Text = "http://";
            this.wl_add.TextChanged += new System.EventHandler(this.wl_add_TextChanged);
            // 
            // backup_tab
            // 
            this.backup_tab.BackColor = System.Drawing.SystemColors.Control;
            this.backup_tab.Controls.Add(this.restore_backup_g);
            this.backup_tab.Controls.Add(this.ex_backup);
            this.backup_tab.Controls.Add(this.auto_backup_group);
            this.backup_tab.ImageIndex = 8;
            this.backup_tab.Location = new System.Drawing.Point(47, 4);
            this.backup_tab.Name = "backup_tab";
            this.backup_tab.Padding = new System.Windows.Forms.Padding(3);
            this.backup_tab.Size = new System.Drawing.Size(908, 684);
            this.backup_tab.TabIndex = 14;
            // 
            // restore_backup_g
            // 
            this.restore_backup_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.restore_backup_g.Controls.Add(this.opeb_bp_dir);
            this.restore_backup_g.Controls.Add(this.create_bp_now);
            this.restore_backup_g.Controls.Add(this.backup_del);
            this.restore_backup_g.Controls.Add(this.backup_refresh);
            this.restore_backup_g.Controls.Add(this.restore_now);
            this.restore_backup_g.Controls.Add(this.backups_list);
            this.restore_backup_g.Location = new System.Drawing.Point(6, 171);
            this.restore_backup_g.Name = "restore_backup_g";
            this.restore_backup_g.Size = new System.Drawing.Size(400, 507);
            this.restore_backup_g.TabIndex = 34;
            this.restore_backup_g.TabStop = false;
            this.restore_backup_g.Text = "Backup managment";
            // 
            // opeb_bp_dir
            // 
            this.opeb_bp_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.opeb_bp_dir.Location = new System.Drawing.Point(253, 466);
            this.opeb_bp_dir.Name = "opeb_bp_dir";
            this.opeb_bp_dir.Size = new System.Drawing.Size(135, 23);
            this.opeb_bp_dir.TabIndex = 5;
            this.opeb_bp_dir.Text = "Open backups directory";
            this.opeb_bp_dir.UseVisualStyleBackColor = true;
            this.opeb_bp_dir.Click += new System.EventHandler(this.opeb_bp_dir_Click);
            // 
            // create_bp_now
            // 
            this.create_bp_now.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.create_bp_now.Location = new System.Drawing.Point(253, 81);
            this.create_bp_now.Name = "create_bp_now";
            this.create_bp_now.Size = new System.Drawing.Size(135, 23);
            this.create_bp_now.TabIndex = 4;
            this.create_bp_now.Text = "Create backup now";
            this.create_bp_now.UseVisualStyleBackColor = true;
            this.create_bp_now.Click += new System.EventHandler(this.create_bp_now_Click);
            // 
            // backup_del
            // 
            this.backup_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backup_del.Location = new System.Drawing.Point(253, 110);
            this.backup_del.Name = "backup_del";
            this.backup_del.Size = new System.Drawing.Size(135, 23);
            this.backup_del.TabIndex = 3;
            this.backup_del.Text = "Delete selected backup";
            this.backup_del.UseVisualStyleBackColor = true;
            this.backup_del.Click += new System.EventHandler(this.backup_del_Click);
            // 
            // backup_refresh
            // 
            this.backup_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backup_refresh.Location = new System.Drawing.Point(253, 437);
            this.backup_refresh.Name = "backup_refresh";
            this.backup_refresh.Size = new System.Drawing.Size(135, 23);
            this.backup_refresh.TabIndex = 2;
            this.backup_refresh.Text = "Refresh list";
            this.backup_refresh.UseVisualStyleBackColor = true;
            this.backup_refresh.Click += new System.EventHandler(this.backup_refresh_Click);
            // 
            // restore_now
            // 
            this.restore_now.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restore_now.Location = new System.Drawing.Point(253, 25);
            this.restore_now.Name = "restore_now";
            this.restore_now.Size = new System.Drawing.Size(135, 23);
            this.restore_now.TabIndex = 1;
            this.restore_now.Text = "Restore selected backup";
            this.restore_now.UseVisualStyleBackColor = true;
            this.restore_now.Click += new System.EventHandler(this.restore_now_Click);
            // 
            // backups_list
            // 
            this.backups_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.backups_list.FormattingEnabled = true;
            this.backups_list.Location = new System.Drawing.Point(17, 25);
            this.backups_list.Name = "backups_list";
            this.backups_list.Size = new System.Drawing.Size(230, 459);
            this.backups_list.TabIndex = 0;
            // 
            // ex_backup
            // 
            this.ex_backup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ex_backup.Controls.Add(this.rem_old_backups_l);
            this.ex_backup.Controls.Add(this.rem_old_backups_count);
            this.ex_backup.Controls.Add(this.rem_old_backups);
            this.ex_backup.Controls.Add(this.prem_help2);
            this.ex_backup.Location = new System.Drawing.Point(6, 110);
            this.ex_backup.Name = "ex_backup";
            this.ex_backup.Size = new System.Drawing.Size(896, 55);
            this.ex_backup.TabIndex = 33;
            this.ex_backup.TabStop = false;
            this.ex_backup.Text = "Extended backup options";
            // 
            // rem_old_backups_l
            // 
            this.rem_old_backups_l.AutoSize = true;
            this.rem_old_backups_l.Enabled = false;
            this.rem_old_backups_l.Location = new System.Drawing.Point(213, 20);
            this.rem_old_backups_l.Name = "rem_old_backups_l";
            this.rem_old_backups_l.Size = new System.Drawing.Size(35, 13);
            this.rem_old_backups_l.TabIndex = 44;
            this.rem_old_backups_l.Text = "latest.";
            // 
            // rem_old_backups_count
            // 
            this.rem_old_backups_count.Enabled = false;
            this.rem_old_backups_count.Location = new System.Drawing.Point(186, 17);
            this.rem_old_backups_count.MaxLength = 2;
            this.rem_old_backups_count.Name = "rem_old_backups_count";
            this.rem_old_backups_count.Size = new System.Drawing.Size(23, 20);
            this.rem_old_backups_count.TabIndex = 43;
            this.rem_old_backups_count.Text = "3";
            this.rem_old_backups_count.TextChanged += new System.EventHandler(this.rem_old_backups_count_TextChanged);
            // 
            // rem_old_backups
            // 
            this.rem_old_backups.AutoSize = true;
            this.rem_old_backups.Enabled = false;
            this.rem_old_backups.Location = new System.Drawing.Point(9, 19);
            this.rem_old_backups.Name = "rem_old_backups";
            this.rem_old_backups.Size = new System.Drawing.Size(179, 17);
            this.rem_old_backups.TabIndex = 42;
            this.rem_old_backups.Text = "Remove old backups, keep only";
            this.rem_old_backups.UseVisualStyleBackColor = true;
            this.rem_old_backups.CheckedChanged += new System.EventHandler(this.rem_old_backups_CheckedChanged);
            // 
            // prem_help2
            // 
            this.prem_help2.Image = ((System.Drawing.Image)(resources.GetObject("prem_help2.Image")));
            this.prem_help2.Location = new System.Drawing.Point(867, 20);
            this.prem_help2.Name = "prem_help2";
            this.prem_help2.Size = new System.Drawing.Size(16, 16);
            this.prem_help2.TabIndex = 41;
            this.prem_help2.TabStop = false;
            this.toolTip.SetToolTip(this.prem_help2, "You need 7DSM Supporter to change these options.\r\nIt\'s almost free, please check " +
        "it out in \"Settings\" tab.");
            // 
            // srv_list
            // 
            this.srv_list.BackColor = System.Drawing.SystemColors.Control;
            this.srv_list.Controls.Add(this.deds_g);
            this.srv_list.ImageIndex = 9;
            this.srv_list.Location = new System.Drawing.Point(47, 4);
            this.srv_list.Name = "srv_list";
            this.srv_list.Padding = new System.Windows.Forms.Padding(3);
            this.srv_list.Size = new System.Drawing.Size(908, 684);
            this.srv_list.TabIndex = 15;
            // 
            // deds_g
            // 
            this.deds_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deds_g.Controls.Add(this.dtds_show);
            this.deds_g.Controls.Add(this.dtds_info2);
            this.deds_g.Controls.Add(this.dtds_auth);
            this.deds_g.Controls.Add(this.dtds_rem);
            this.deds_g.Controls.Add(this.dtds_info);
            this.deds_g.Controls.Add(this.dtds_lista);
            this.deds_g.Controls.Add(this.dtds_add);
            this.deds_g.Controls.Add(this.dtds_possible);
            this.deds_g.Controls.Add(this.dtds_explain);
            this.deds_g.Controls.Add(this.dtds_enable);
            this.deds_g.Controls.Add(this.dtds_visit);
            this.deds_g.Location = new System.Drawing.Point(12, 8);
            this.deds_g.Name = "deds_g";
            this.deds_g.Size = new System.Drawing.Size(889, 343);
            this.deds_g.TabIndex = 0;
            this.deds_g.TabStop = false;
            this.deds_g.Text = "7daystodie-servers.com";
            // 
            // dtds_show
            // 
            this.dtds_show.AutoSize = true;
            this.dtds_show.Location = new System.Drawing.Point(189, 113);
            this.dtds_show.Name = "dtds_show";
            this.dtds_show.Size = new System.Drawing.Size(106, 17);
            this.dtds_show.TabIndex = 28;
            this.dtds_show.Text = "Show characters";
            this.dtds_show.UseVisualStyleBackColor = true;
            this.dtds_show.CheckedChanged += new System.EventHandler(this.dtds_show_CheckedChanged);
            // 
            // dtds_info2
            // 
            this.dtds_info2.AutoSize = true;
            this.dtds_info2.Location = new System.Drawing.Point(6, 114);
            this.dtds_info2.Name = "dtds_info2";
            this.dtds_info2.Size = new System.Drawing.Size(161, 13);
            this.dtds_info2.TabIndex = 9;
            this.dtds_info2.Text = "7daystodie-servers.com API key:";
            // 
            // dtds_auth
            // 
            this.dtds_auth.Location = new System.Drawing.Point(9, 130);
            this.dtds_auth.Name = "dtds_auth";
            this.dtds_auth.PasswordChar = '*';
            this.dtds_auth.Size = new System.Drawing.Size(286, 20);
            this.dtds_auth.TabIndex = 8;
            this.dtds_auth.TextChanged += new System.EventHandler(this.dtds_auth_TextChanged);
            // 
            // dtds_rem
            // 
            this.dtds_rem.Location = new System.Drawing.Point(195, 310);
            this.dtds_rem.Name = "dtds_rem";
            this.dtds_rem.Size = new System.Drawing.Size(100, 23);
            this.dtds_rem.TabIndex = 7;
            this.dtds_rem.Text = "Remove selected";
            this.dtds_rem.UseVisualStyleBackColor = true;
            this.dtds_rem.Click += new System.EventHandler(this.dtds_rem_Click);
            // 
            // dtds_info
            // 
            this.dtds_info.AutoSize = true;
            this.dtds_info.Location = new System.Drawing.Point(6, 180);
            this.dtds_info.Name = "dtds_info";
            this.dtds_info.Size = new System.Drawing.Size(289, 13);
            this.dtds_info.TabIndex = 6;
            this.dtds_info.Text = "Items player will get after voting and writting /reward in chat:";
            // 
            // dtds_lista
            // 
            this.dtds_lista.FormattingEnabled = true;
            this.dtds_lista.Location = new System.Drawing.Point(6, 196);
            this.dtds_lista.Name = "dtds_lista";
            this.dtds_lista.Size = new System.Drawing.Size(289, 108);
            this.dtds_lista.TabIndex = 5;
            // 
            // dtds_add
            // 
            this.dtds_add.Location = new System.Drawing.Point(195, 156);
            this.dtds_add.Name = "dtds_add";
            this.dtds_add.Size = new System.Drawing.Size(100, 21);
            this.dtds_add.TabIndex = 4;
            this.dtds_add.Text = "Add";
            this.dtds_add.UseVisualStyleBackColor = true;
            this.dtds_add.Click += new System.EventHandler(this.dtds_add_Click);
            // 
            // dtds_possible
            // 
            this.dtds_possible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dtds_possible.FormattingEnabled = true;
            this.dtds_possible.Location = new System.Drawing.Point(9, 156);
            this.dtds_possible.Name = "dtds_possible";
            this.dtds_possible.Size = new System.Drawing.Size(180, 21);
            this.dtds_possible.TabIndex = 3;
            // 
            // dtds_explain
            // 
            this.dtds_explain.AutoSize = true;
            this.dtds_explain.Location = new System.Drawing.Point(6, 16);
            this.dtds_explain.Name = "dtds_explain";
            this.dtds_explain.Size = new System.Drawing.Size(493, 26);
            this.dtds_explain.TabIndex = 2;
            this.dtds_explain.Text = "If your server is on 7daystodie-servers.com toplist, you may enable rewards for p" +
    "layers who vote for you.\r\n7DSM is integrated with their voting system, so system" +
    " checks if player really voted.\r\n";
            // 
            // dtds_enable
            // 
            this.dtds_enable.AutoSize = true;
            this.dtds_enable.Location = new System.Drawing.Point(9, 45);
            this.dtds_enable.Name = "dtds_enable";
            this.dtds_enable.Size = new System.Drawing.Size(279, 17);
            this.dtds_enable.TabIndex = 1;
            this.dtds_enable.Text = "Enable 7daystodie-servers.com rewards on my server.";
            this.dtds_enable.UseVisualStyleBackColor = true;
            this.dtds_enable.CheckedChanged += new System.EventHandler(this.dtds_enable_CheckedChanged);
            // 
            // dtds_visit
            // 
            this.dtds_visit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtds_visit.Location = new System.Drawing.Point(766, 310);
            this.dtds_visit.Name = "dtds_visit";
            this.dtds_visit.Size = new System.Drawing.Size(116, 23);
            this.dtds_visit.TabIndex = 0;
            this.dtds_visit.Text = "Visit website";
            this.dtds_visit.UseVisualStyleBackColor = true;
            this.dtds_visit.Click += new System.EventHandler(this.dtds_visit_Click);
            // 
            // server_startup_tasks
            // 
            this.server_startup_tasks.WorkerSupportsCancellation = true;
            this.server_startup_tasks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.work_after_start_DoWork);
            // 
            // telnet_connection
            // 
            this.telnet_connection.WorkerSupportsCancellation = true;
            this.telnet_connection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.telnet_connection_DoWork);
            // 
            // workers_list
            // 
            this.workers_list.WorkerSupportsCancellation = true;
            this.workers_list.DoWork += new System.ComponentModel.DoWorkEventHandler(this.taskman_worker_DoWork);
            // 
            // auto_messages
            // 
            this.auto_messages.WorkerSupportsCancellation = true;
            this.auto_messages.DoWork += new System.ComponentModel.DoWorkEventHandler(this.spamer_DoWork);
            // 
            // sql_exporter
            // 
            this.sql_exporter.WorkerSupportsCancellation = true;
            this.sql_exporter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.sql_exporter_DoWork);
            // 
            // auto_backup
            // 
            this.auto_backup.WorkerSupportsCancellation = true;
            this.auto_backup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.auto_backup_DoWork);
            // 
            // auto_reset
            // 
            this.auto_reset.WorkerSupportsCancellation = true;
            this.auto_reset.DoWork += new System.ComponentModel.DoWorkEventHandler(this.auto_reset_DoWork);
            // 
            // stats
            // 
            this.stats.WorkerSupportsCancellation = true;
            this.stats.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Stats_DoWork);
            // 
            // reboot_telnet
            // 
            this.reboot_telnet.WorkerSupportsCancellation = true;
            this.reboot_telnet.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Reboot_telnet_DoWork);
            // 
            // custom_cmd_executor
            // 
            this.custom_cmd_executor.WorkerSupportsCancellation = true;
            this.custom_cmd_executor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.custom_cmd_executor_DoWork);
            // 
            // server_stop_tasks
            // 
            this.server_stop_tasks.WorkerSupportsCancellation = true;
            this.server_stop_tasks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Server_stop_tasks_DoWork);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 150;
            this.toolTip.AutoPopDelay = 30000;
            this.toolTip.InitialDelay = 150;
            this.toolTip.ReshowDelay = 30;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Information";
            // 
            // img_status
            // 
            this.img_status.AccessibleDescription = "";
            this.img_status.AccessibleName = "";
            this.img_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.img_status.BackColor = System.Drawing.Color.Transparent;
            this.img_status.Image = ((System.Drawing.Image)(resources.GetObject("img_status.Image")));
            this.img_status.Location = new System.Drawing.Point(9, 698);
            this.img_status.Margin = new System.Windows.Forms.Padding(0);
            this.img_status.Name = "img_status";
            this.img_status.Size = new System.Drawing.Size(40, 40);
            this.img_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_status.TabIndex = 11;
            this.img_status.TabStop = false;
            this.img_status.Tag = "";
            this.toolTip.SetToolTip(this.img_status, "Black- server is not running\r\nYellow- server OR CLIENT is running, but telnet is " +
        "offline\r\nGreen- server is running on Client files\r\nBlue- server is running on de" +
        "dicated files");
            // 
            // autoupdate_whitelist
            // 
            this.autoupdate_whitelist.WorkerReportsProgress = true;
            this.autoupdate_whitelist.WorkerSupportsCancellation = true;
            this.autoupdate_whitelist.DoWork += new System.ComponentModel.DoWorkEventHandler(this.autoupdate_whitelist_DoWork);
            // 
            // don_l
            // 
            this.don_l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.don_l.AutoSize = true;
            this.don_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.don_l.Location = new System.Drawing.Point(845, 697);
            this.don_l.Name = "don_l";
            this.don_l.Size = new System.Drawing.Size(92, 13);
            this.don_l.TabIndex = 37;
            this.don_l.Text = "If you like my work";
            // 
            // check_updates
            // 
            this.check_updates.DoWork += new System.ComponentModel.DoWorkEventHandler(this.check_updates_DoWork);
            // 
            // prepare_app_after_draw
            // 
            this.prepare_app_after_draw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.prepare_app_after_draw_DoWork);
            // 
            // dbg_btn
            // 
            this.dbg_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dbg_btn.Location = new System.Drawing.Point(384, 695);
            this.dbg_btn.Name = "dbg_btn";
            this.dbg_btn.Size = new System.Drawing.Size(84, 43);
            this.dbg_btn.TabIndex = 38;
            this.dbg_btn.Text = "webserver 1";
            this.dbg_btn.UseVisualStyleBackColor = true;
            this.dbg_btn.Visible = false;
            this.dbg_btn.Click += new System.EventHandler(this.dbg_btn_Click);
            // 
            // dbg_btn_2
            // 
            this.dbg_btn_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dbg_btn_2.Location = new System.Drawing.Point(474, 695);
            this.dbg_btn_2.Name = "dbg_btn_2";
            this.dbg_btn_2.Size = new System.Drawing.Size(84, 43);
            this.dbg_btn_2.TabIndex = 41;
            this.dbg_btn_2.Text = "webserver 0";
            this.dbg_btn_2.UseVisualStyleBackColor = true;
            this.dbg_btn_2.Visible = false;
            this.dbg_btn_2.Click += new System.EventHandler(this.dbg_btn_2_Click);
            // 
            // help_b
            // 
            this.help_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.help_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.help_b.FlatAppearance.BorderSize = 0;
            this.help_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_b.Image = ((System.Drawing.Image)(resources.GetObject("help_b.Image")));
            this.help_b.Location = new System.Drawing.Point(649, 698);
            this.help_b.Margin = new System.Windows.Forms.Padding(0);
            this.help_b.Name = "help_b";
            this.help_b.Size = new System.Drawing.Size(43, 43);
            this.help_b.TabIndex = 40;
            this.help_b.UseVisualStyleBackColor = true;
            this.help_b.Click += new System.EventHandler(this.help_b_Click);
            // 
            // contact_b
            // 
            this.contact_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.contact_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contact_b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contact_b.FlatAppearance.BorderSize = 0;
            this.contact_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contact_b.Image = ((System.Drawing.Image)(resources.GetObject("contact_b.Image")));
            this.contact_b.Location = new System.Drawing.Point(694, 698);
            this.contact_b.Margin = new System.Windows.Forms.Padding(0);
            this.contact_b.Name = "contact_b";
            this.contact_b.Size = new System.Drawing.Size(43, 43);
            this.contact_b.TabIndex = 39;
            this.contact_b.UseVisualStyleBackColor = true;
            this.contact_b.Click += new System.EventHandler(this.contact_b_Click);
            // 
            // forumklik
            // 
            this.forumklik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.forumklik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forumklik.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.forumklik.FlatAppearance.BorderSize = 0;
            this.forumklik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forumklik.Image = ((System.Drawing.Image)(resources.GetObject("forumklik.Image")));
            this.forumklik.Location = new System.Drawing.Point(840, 710);
            this.forumklik.Margin = new System.Windows.Forms.Padding(0);
            this.forumklik.Name = "forumklik";
            this.forumklik.Size = new System.Drawing.Size(102, 33);
            this.forumklik.TabIndex = 25;
            this.forumklik.UseVisualStyleBackColor = true;
            this.forumklik.Click += new System.EventHandler(this.Forumklik_Click);
            // 
            // www7dsm
            // 
            this.www7dsm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.www7dsm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.www7dsm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.www7dsm.FlatAppearance.BorderSize = 0;
            this.www7dsm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.www7dsm.Image = ((System.Drawing.Image)(resources.GetObject("www7dsm.Image")));
            this.www7dsm.Location = new System.Drawing.Point(780, 698);
            this.www7dsm.Margin = new System.Windows.Forms.Padding(0);
            this.www7dsm.Name = "www7dsm";
            this.www7dsm.Size = new System.Drawing.Size(43, 43);
            this.www7dsm.TabIndex = 36;
            this.www7dsm.UseVisualStyleBackColor = true;
            this.www7dsm.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // like
            // 
            this.like.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.like.Cursor = System.Windows.Forms.Cursors.Hand;
            this.like.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.like.FlatAppearance.BorderSize = 0;
            this.like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.like.Image = ((System.Drawing.Image)(resources.GetObject("like.Image")));
            this.like.Location = new System.Drawing.Point(737, 698);
            this.like.Margin = new System.Windows.Forms.Padding(0);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(43, 43);
            this.like.TabIndex = 35;
            this.like.UseVisualStyleBackColor = true;
            this.like.Click += new System.EventHandler(this.Like_Click);
            // 
            // externalCallFile
            // 
            this.externalCallFile.Title = "External call";
            // 
            // discord_b
            // 
            this.discord_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.discord_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discord_b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.discord_b.FlatAppearance.BorderSize = 0;
            this.discord_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discord_b.Image = ((System.Drawing.Image)(resources.GetObject("discord_b.Image")));
            this.discord_b.Location = new System.Drawing.Point(604, 698);
            this.discord_b.Margin = new System.Windows.Forms.Padding(0);
            this.discord_b.Name = "discord_b";
            this.discord_b.Size = new System.Drawing.Size(43, 43);
            this.discord_b.TabIndex = 42;
            this.discord_b.UseVisualStyleBackColor = true;
            this.discord_b.Click += new System.EventHandler(this.discord_b_Click);
            // 
            // server_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(961, 747);
            this.Controls.Add(this.discord_b);
            this.Controls.Add(this.dbg_btn_2);
            this.Controls.Add(this.help_b);
            this.Controls.Add(this.contact_b);
            this.Controls.Add(this.dbg_btn);
            this.Controls.Add(this.forumklik);
            this.Controls.Add(this.don_l);
            this.Controls.Add(this.www7dsm);
            this.Controls.Add(this.like);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.img_status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(969, 778);
            this.Name = "server_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7 Days Server Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.server_panel_FormClosing);
            this.Load += new System.EventHandler(this.server_panel_Load);
            this.Shown += new System.EventHandler(this.server_panel_Shown);
            this.Resize += new System.EventHandler(this.server_panel_Resize);
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.dsm_updates_g.ResumeLayout(false);
            this.dsm_updates_g.PerformLayout();
            this.exe_settings_g.ResumeLayout(false);
            this.exe_settings_g.PerformLayout();
            this.prem_set.ResumeLayout(false);
            this.prem_set.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prem_help1)).EndInit();
            this.prem_g.ResumeLayout(false);
            this.prem_g.PerformLayout();
            this.sql.ResumeLayout(false);
            this.sql.PerformLayout();
            this.sql_updates_time_g.ResumeLayout(false);
            this.sql_updates_time_g.PerformLayout();
            this.sql_host_g.ResumeLayout(false);
            this.sql_host_g.PerformLayout();
            this.sql_username_g.ResumeLayout(false);
            this.sql_username_g.PerformLayout();
            this.sql_db_name_g.ResumeLayout(false);
            this.sql_db_name_g.PerformLayout();
            this.sql_password_g.ResumeLayout(false);
            this.sql_password_g.PerformLayout();
            this.ustawienia_grupa_ustawienia.ResumeLayout(false);
            this.ustawienia_grupa_ustawienia.PerformLayout();
            this.auto_backup_group.ResumeLayout(false);
            this.auto_backup_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backup_time)).EndInit();
            this.spawn_group.ResumeLayout(false);
            this.telnet_group.ResumeLayout(false);
            this.telnet_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dzien_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.godzina_bar)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.server_manage.ResumeLayout(false);
            this.CommandsGroup.ResumeLayout(false);
            this.overviewSplitter.Panel1.ResumeLayout(false);
            this.overviewSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overviewSplitter)).EndInit();
            this.overviewSplitter.ResumeLayout(false);
            this.News_Group.ResumeLayout(false);
            this.Server_Status_Group.ResumeLayout(false);
            this.Server_Status_Group.PerformLayout();
            this.Console_Group.ResumeLayout(false);
            this.Console_Group.PerformLayout();
            this.Timers_Group.ResumeLayout(false);
            this.Timers_Group.PerformLayout();
            this.Server_Controls_Group.ResumeLayout(false);
            this.Server_Controls_Group.PerformLayout();
            this.ban_kick.ResumeLayout(false);
            this.ban_kick.PerformLayout();
            this.Chat_Group.ResumeLayout(false);
            this.Chat_Group.PerformLayout();
            this.player_g.ResumeLayout(false);
            this.kickgroup.ResumeLayout(false);
            this.bantime_slider.ResumeLayout(false);
            this.bantime_slider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ban_slide)).EndInit();
            this.main_page.ResumeLayout(false);
            this.main_page_opts.ResumeLayout(false);
            this.game_opts.ResumeLayout(false);
            this.reserved_g.ResumeLayout(false);
            this.reserved_g.PerformLayout();
            this.PlayerKillingMode_g.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.spawn_p_l.ResumeLayout(false);
            this.spawn_p_l.PerformLayout();
            this.AirDropFrequency_g.ResumeLayout(false);
            this.AirDropFrequency_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AirDropFrequency)).EndInit();
            this.LandClaim.ResumeLayout(false);
            this.LandClaimDecayMode_g.ResumeLayout(false);
            this.LandClaimDecayMode_g.PerformLayout();
            this.LandClaim_g.ResumeLayout(false);
            this.LandClaim_g.PerformLayout();
            this.LandClaimSize_g.ResumeLayout(false);
            this.LandClaimSize_g.PerformLayout();
            this.LandClaimDeadZone_g.ResumeLayout(false);
            this.LandClaimDeadZone_g.PerformLayout();
            this.LandClaimExpiryTime_g.ResumeLayout(false);
            this.LandClaimExpiryTime_g.PerformLayout();
            this.LootRespawnDays_g.ResumeLayout(false);
            this.LootRespawnDays_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LootRespawnDays)).EndInit();
            this.LootAbundance_g.ResumeLayout(false);
            this.LootAbundance_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LootAbundance)).EndInit();
            this.maxplgroup.ResumeLayout(false);
            this.maxplgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxpl)).EndInit();
            this.trybgry.ResumeLayout(false);
            this.trybgry.PerformLayout();
            this.zomb_pie.ResumeLayout(false);
            this.zomb_pie.PerformLayout();
            this.nightpercentage_g.ResumeLayout(false);
            this.nightpercentage_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nightpercentage)).EndInit();
            this.dlugoscdnia_g.ResumeLayout(false);
            this.dlugoscdnia_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlugoscdnia)).EndInit();
            this.bdm_g.ResumeLayout(false);
            this.bdm_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdm)).EndInit();
            this.dod_g.ResumeLayout(false);
            this.dod_g.PerformLayout();
            this.dod_p.ResumeLayout(false);
            this.dod_p.PerformLayout();
            this.trudnoscgroup.ResumeLayout(false);
            this.trudnoscgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trudnosc)).EndInit();
            this.server_opts.ResumeLayout(false);
            this.ServerWebsiteURL_g.ResumeLayout(false);
            this.ServerWebsiteURL_g.PerformLayout();
            this.ServerDescription_g.ResumeLayout(false);
            this.ServerDescription_g.PerformLayout();
            this.configfile_g.ResumeLayout(false);
            this.configfile_g.PerformLayout();
            this.save_g.ResumeLayout(false);
            this.save_g.PerformLayout();
            this.filename_g.ResumeLayout(false);
            this.filename_g.PerformLayout();
            this.nazwamapa.ResumeLayout(false);
            this.nazwamapa.PerformLayout();
            this.dostep.ResumeLayout(false);
            this.dostep.PerformLayout();
            this.odery.ResumeLayout(false);
            this.odery.PerformLayout();
            this.autobots.ResumeLayout(false);
            this.autobots.PerformLayout();
            this.BedrollDeadZoneSize_g.ResumeLayout(false);
            this.BedrollDeadZoneSize_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BedrollDeadZoneSize)).EndInit();
            this.BloodMoonEnemyCount_g.ResumeLayout(false);
            this.BloodMoonEnemyCount_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BloodMoonEnemyCount)).EndInit();
            this.MaxSpawnedAnimals_g.ResumeLayout(false);
            this.MaxSpawnedAnimals_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpawnedAnimals)).EndInit();
            this.MaxSpawnedZombies_g.ResumeLayout(false);
            this.MaxSpawnedZombies_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpawnedZombies)).EndInit();
            this.net_opts.ResumeLayout(false);
            this.MaxUncoveredMapChunksPerPlayer_g.ResumeLayout(false);
            this.MaxUncoveredMapChunksPerPlayer_g.PerformLayout();
            this.HideCommandExecutionLog_g.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ServerDisabledNetworkProtocols_g.ResumeLayout(false);
            this.ServerDisabledNetworkProtocols_g.PerformLayout();
            this.port_g.ResumeLayout(false);
            this.port_g.PerformLayout();
            this.ctrlpanel.ResumeLayout(false);
            this.ctrlpanel.PerformLayout();
            this.telnet_g.ResumeLayout(false);
            this.telnet_g.PerformLayout();
            this.strings_page.ResumeLayout(false);
            this.messages_g.ResumeLayout(false);
            this.messages_g.PerformLayout();
            this.customcommands_g.ResumeLayout(false);
            this.customcommands_g.PerformLayout();
            this.globalBanList.ResumeLayout(false);
            this.global_ban_g.ResumeLayout(false);
            this.global_ban_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banlist_logo)).EndInit();
            this.WebServer.ResumeLayout(false);
            this.autofix_g.ResumeLayout(false);
            this.autofix_g.PerformLayout();
            this.website_g.ResumeLayout(false);
            this.website_g.PerformLayout();
            this.www_rules_content.ResumeLayout(false);
            this.home_tab.ResumeLayout(false);
            this.rules_tab.ResumeLayout(false);
            this.other_tab.ResumeLayout(false);
            this.other_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prem_help3)).EndInit();
            this.android_g.ResumeLayout(false);
            this.android_g.PerformLayout();
            this.tasks.ResumeLayout(false);
            this.reset_g.ResumeLayout(false);
            this.reset_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reset_time)).EndInit();
            this.spam_g.ResumeLayout(false);
            this.spam_g.PerformLayout();
            this.spam_time_g.ResumeLayout(false);
            this.spam_time_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spam_time)).EndInit();
            this.whitelist_dl_g.ResumeLayout(false);
            this.whitelist_dl_g.PerformLayout();
            this.backup_tab.ResumeLayout(false);
            this.restore_backup_g.ResumeLayout(false);
            this.ex_backup.ResumeLayout(false);
            this.ex_backup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prem_help2)).EndInit();
            this.srv_list.ResumeLayout(false);
            this.deds_g.ResumeLayout(false);
            this.deds_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker status_updater;
        private System.Windows.Forms.FolderBrowserDialog select_dir;
        private System.Windows.Forms.NotifyIcon ikona;
        private System.Windows.Forms.PictureBox img_status;
        private System.Windows.Forms.Label twoje_ip;
        private System.Windows.Forms.TabPage settings;
        private System.Windows.Forms.GroupBox ustawienia_grupa_ustawienia;
        private System.Windows.Forms.Button chpath;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.CheckBox to_tray;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.GroupBox spawn_group;
        private System.Windows.Forms.Button spawn_now;
        private System.Windows.Forms.ComboBox spawn_item;
        private System.Windows.Forms.GroupBox telnet_group;
        private System.Windows.Forms.Label godzina;
        private System.Windows.Forms.TrackBar godzina_bar;
        private System.Windows.Forms.Label dzien;
        private System.Windows.Forms.TrackBar dzien_bar;
        private System.Windows.Forms.Button telnet_connect;
        private System.Windows.Forms.TextBox cmd;
        private System.Windows.Forms.RichTextBox konsola;
        private System.Windows.Forms.TabControl tabControl;
        private System.ComponentModel.BackgroundWorker server_startup_tasks;
        private System.Windows.Forms.ImageList ikony_naglowka;
        private System.Windows.Forms.TabPage ban_kick;
        private System.Windows.Forms.Button kick;
        private System.Windows.Forms.Button ban;
        private System.Windows.Forms.ProgressBar startbar;
        private System.Windows.Forms.ComboBox powod;
        private System.Windows.Forms.TabPage server_manage;
        private System.ComponentModel.BackgroundWorker telnet_connection;
        private System.Windows.Forms.ListBox taskman;
        private System.ComponentModel.BackgroundWorker workers_list;
        private System.Windows.Forms.Label workerynapis;
        private System.Windows.Forms.ComboBox bantime;
        private System.Windows.Forms.GroupBox kickgroup;
        private System.Windows.Forms.GroupBox bantime_slider;
        private System.Windows.Forms.TrackBar ban_slide;
        private System.Windows.Forms.GroupBox Console_Group;
        private System.Windows.Forms.CheckBox always_on_top;
        private System.Windows.Forms.Button blad;
        private System.Windows.Forms.Button steamsearch;
        private System.ComponentModel.BackgroundWorker auto_messages;
        private System.Windows.Forms.RichTextBox spam_list;
        private System.Windows.Forms.Label spaminfo;
        private System.Windows.Forms.TrackBar spam_time;
        private System.Windows.Forms.GroupBox spam_time_g;
        private System.Windows.Forms.CheckBox show_ip;
        private System.Windows.Forms.CheckBox cleanexit;
        private System.Windows.Forms.GroupBox Server_Controls_Group;
        private System.Windows.Forms.CheckBox Save_Logs_CheckBox;
        private System.Windows.Forms.Button Shutdown_Server_Button;
        private System.Windows.Forms.Button Start_Server_Button;
        private System.Windows.Forms.Button Kill_Server_Process;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.CheckBox anon_data;
        private System.Windows.Forms.LinkLabel anon_data_2;
        private System.Windows.Forms.GroupBox sql_db_name_g;
        private System.Windows.Forms.TextBox sql_db_name;
        private System.Windows.Forms.GroupBox sql_password_g;
        private System.Windows.Forms.TextBox sql_password;
        private System.Windows.Forms.GroupBox sql_username_g;
        private System.Windows.Forms.TextBox sql_username;
        private System.Windows.Forms.GroupBox sql_host_g;
        private System.Windows.Forms.TextBox sql_host;
        private System.Windows.Forms.CheckBox sql_enabled;
        private System.ComponentModel.BackgroundWorker sql_exporter;
        private System.Windows.Forms.Label sql_warn;
        private System.Windows.Forms.Label upd_time;
        private System.Windows.Forms.Button how_to_sql;
        private System.Windows.Forms.GroupBox sql_updates_time_g;
        private System.Windows.Forms.TextBox sql_updates_time;
        private System.Windows.Forms.GroupBox Timers_Group;
        private System.Windows.Forms.Label SQL_Export_Timer_Label;
        private System.Windows.Forms.Label SQL_Export_Timer;
        private System.Windows.Forms.Label Auto_Command_Timer_Label;
        private System.Windows.Forms.Label Backup_Timer;
        private System.Windows.Forms.Label Backup_Timer_Label;
        private System.ComponentModel.BackgroundWorker auto_backup;
        private System.Windows.Forms.GroupBox auto_backup_group;
        private System.Windows.Forms.CheckBox auto_backup_check;
        private System.Windows.Forms.TrackBar backup_time;
        private System.Windows.Forms.CheckBox backup_chat;
        private System.Windows.Forms.Button forumklik;
        private System.Windows.Forms.TabPage main_page;
        private System.Windows.Forms.TabControl main_page_opts;
        private System.Windows.Forms.TabPage server_opts;
        private System.Windows.Forms.TabPage game_opts;
        private System.Windows.Forms.GroupBox bdm_g;
        private System.Windows.Forms.TrackBar bdm;
        private System.Windows.Forms.GroupBox dod_g;
        private System.Windows.Forms.Panel dod_p;
        private System.Windows.Forms.RadioButton dod_0;
        private System.Windows.Forms.RadioButton dod_1;
        private System.Windows.Forms.RadioButton dod_2;
        private System.Windows.Forms.RadioButton dod_3;
        private System.Windows.Forms.RadioButton doq_3;
        private System.Windows.Forms.RadioButton doq_2;
        private System.Windows.Forms.RadioButton doq_1;
        private System.Windows.Forms.RadioButton doq_0;
        private System.Windows.Forms.GroupBox trudnoscgroup;
        private System.Windows.Forms.TrackBar trudnosc;
        private System.Windows.Forms.GroupBox nazwamapa;
        private System.Windows.Forms.ComboBox nazwa;
        private System.Windows.Forms.TextBox server_nazwa;
        private System.Windows.Forms.ComboBox mapa;
        private System.Windows.Forms.GroupBox ctrlpanel;
        private System.Windows.Forms.Label cpl_port;
        private System.Windows.Forms.TextBox port_panel;
        private System.Windows.Forms.Label cpl_pass;
        private System.Windows.Forms.CheckBox ctrlp;
        private System.Windows.Forms.TextBox ctrlppass;
        private System.Windows.Forms.GroupBox port_g;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.GroupBox dostep;
        private System.Windows.Forms.TextBox ServerPassword;
        private System.Windows.Forms.CheckBox ServerIsPublic;
        private System.Windows.Forms.GroupBox odery;
        private System.Windows.Forms.CheckBox save_logfiles;
        private System.Windows.Forms.GroupBox nightpercentage_g;
        private System.Windows.Forms.TrackBar nightpercentage;
        private System.Windows.Forms.GroupBox dlugoscdnia_g;
        private System.Windows.Forms.CheckBox realtime;
        private System.Windows.Forms.TrackBar dlugoscdnia;
        private System.Windows.Forms.GroupBox autobots;
        private System.Windows.Forms.GroupBox trybgry;
        private System.Windows.Forms.CheckBox cheatmode;
        private System.Windows.Forms.RadioButton gamemode_coop;
        private System.Windows.Forms.GroupBox zomb_pie;
        private System.Windows.Forms.RadioButton zombie_never_run;
        private System.Windows.Forms.RadioButton zombie_normal;
        private System.Windows.Forms.RadioButton zombie_run;
        private System.Windows.Forms.GroupBox maxplgroup;
        private System.Windows.Forms.GroupBox telnet_g;
        private System.Windows.Forms.Label telnet_port_l;
        private System.Windows.Forms.TextBox telnet_port_p;
        private System.Windows.Forms.Label telnet_psw_l;
        private System.Windows.Forms.TextBox telnet_psw;
        private System.Windows.Forms.TextBox AdminFileName;
        private System.Windows.Forms.GroupBox filename_g;
        private System.Windows.Forms.GroupBox LootAbundance_g;
        private System.Windows.Forms.TrackBar LootAbundance;
        private System.Windows.Forms.GroupBox LootRespawnDays_g;
        private System.Windows.Forms.TrackBar LootRespawnDays;
        private System.Windows.Forms.Button sa_edit;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.RadioButton gamemode_surv_pvp;
        private System.Windows.Forms.GroupBox LandClaimDeadZone_g;
        private System.Windows.Forms.TextBox LandClaimDeadZone;
        private System.Windows.Forms.GroupBox LandClaimSize_g;
        private System.Windows.Forms.TextBox LandClaimSize;
        private System.Windows.Forms.GroupBox LandClaim_g;
        private System.Windows.Forms.Label offline;
        private System.Windows.Forms.Label online;
        private System.Windows.Forms.TextBox LandClaimOfflineDurabilityModifier;
        private System.Windows.Forms.TextBox LandClaimOnlineDurabilityModifier;
        private System.Windows.Forms.GroupBox LandClaimDecayMode_g;
        private System.Windows.Forms.RadioButton Full_prot;
        private System.Windows.Forms.RadioButton Exponential;
        private System.Windows.Forms.RadioButton Linear;
        private System.Windows.Forms.GroupBox LandClaimExpiryTime_g;
        private System.Windows.Forms.TextBox LandClaimExpiryTime;
        private System.Windows.Forms.GroupBox LandClaim;
        private System.Windows.Forms.ColumnHeader login_header;
        private System.Windows.Forms.ColumnHeader steamid_header;
        private System.Windows.Forms.TabPage tasks;
        private System.Windows.Forms.GroupBox spam_g;
        private System.ComponentModel.BackgroundWorker auto_reset;
        private System.Windows.Forms.GroupBox reset_g;
        private System.Windows.Forms.CheckBox reset_chat;
        private System.Windows.Forms.CheckBox reset_enabled;
        private System.Windows.Forms.TrackBar reset_time;
        private System.Windows.Forms.Label Auto_Restart_Timer;
        private System.Windows.Forms.Label Auto_Restart_Timer_Label;
        private System.Windows.Forms.GroupBox save_g;
        private System.Windows.Forms.TextBox save;
        private System.Windows.Forms.CheckBox spam_is_spam;
        private System.ComponentModel.BackgroundWorker stats;
        private System.Windows.Forms.GroupBox AirDropFrequency_g;
        private System.Windows.Forms.TrackBar AirDropFrequency;
        private System.Windows.Forms.CheckBox feral;
        private System.Windows.Forms.Button Connect_Running_Server_Button;
        private System.ComponentModel.BackgroundWorker reboot_telnet;
        private System.Windows.Forms.CheckBox VACEnabled;
        private System.Windows.Forms.GroupBox MaxSpawnedZombies_g;
        private System.Windows.Forms.TrackBar MaxSpawnedZombies;
        private System.Windows.Forms.GroupBox Chat_Group;
        private System.Windows.Forms.RichTextBox chat;
        private System.Windows.Forms.TextBox chat_text;
        private System.Windows.Forms.GroupBox sql;
        private System.Windows.Forms.Label reboot_l;
        private System.Windows.Forms.Label backup_msg_1_l;
        private System.Windows.Forms.TextBox reboot;
        private System.Windows.Forms.TextBox backup_msg_1;
        private System.Windows.Forms.Label reboot_time_l;
        private System.Windows.Forms.TextBox reboot_time;
        private System.Windows.Forms.Label backup_msg_2_l;
        private System.Windows.Forms.TextBox backup_msg_2;
        private System.Windows.Forms.GroupBox messages_g;
        private System.Windows.Forms.GroupBox customcommands_g;
        private System.Windows.Forms.RichTextBox customcommands;
        private System.Windows.Forms.Button how_to_commands;
        private System.Windows.Forms.CheckBox enable_cc;
        private System.ComponentModel.BackgroundWorker custom_cmd_executor;
        private System.Windows.Forms.TextBox cmd_not_yet;
        private System.Windows.Forms.Label cmd_not_yet_l;
        private System.Windows.Forms.TabPage strings_page;
        private System.Windows.Forms.GroupBox configfile_g;
        private System.Windows.Forms.Button configfile_e;
        private System.Windows.Forms.TextBox configfile;
        private System.Windows.Forms.GroupBox ServerWebsiteURL_g;
        private System.Windows.Forms.TextBox ServerWebsiteURL;
        private System.Windows.Forms.GroupBox ServerDescription_g;
        private System.Windows.Forms.TextBox ServerDescription;
        private System.Windows.Forms.CheckBox PersistentPlayerProfiles;
        private System.Windows.Forms.CheckBox skip_profiles;
        private System.ComponentModel.BackgroundWorker server_stop_tasks;
        private System.Windows.Forms.Button like;
        private System.Windows.Forms.GroupBox spawn_p_l;
        private System.Windows.Forms.Label PlayerSafeZoneHours_l;
        private System.Windows.Forms.Label PlayerSafeZoneLevel_l;
        private System.Windows.Forms.TextBox PlayerSafeZoneHours;
        private System.Windows.Forms.TextBox PlayerSafeZoneLevel;
        private System.Windows.Forms.GroupBox MaxSpawnedAnimals_g;
        private System.Windows.Forms.TrackBar MaxSpawnedAnimals;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox player_g;
        private System.Windows.Forms.Button thirsty_player;
        private System.Windows.Forms.Button starve_player;
        private System.Windows.Forms.Button kill_player;
        private System.Windows.Forms.CheckBox debug_log;
        private System.Windows.Forms.Button www7dsm;
        private System.Windows.Forms.GroupBox whitelist_dl_g;
        private System.Windows.Forms.Label min_l;
        private System.Windows.Forms.TextBox wl_interval;
        private System.Windows.Forms.CheckBox wl_chk;
        private System.Windows.Forms.Label wl_add_l;
        private System.Windows.Forms.TextBox wl_add;
        private System.ComponentModel.BackgroundWorker autoupdate_whitelist;
        private System.Windows.Forms.CheckBox use_wl;
        private System.Windows.Forms.Label Whitelist_Update_Timer;
        private System.Windows.Forms.Label Whitelist_Update_Label;
        private System.Windows.Forms.CheckBox Start_7DSM_With_Windows_CheckBox;
        private System.Windows.Forms.CheckBox Start_With_7DSM_CheckBox;
        private System.Windows.Forms.Label don_l;
        private System.Windows.Forms.Label backup_location_l;
        private System.Windows.Forms.TextBox backup_location;
        private System.ComponentModel.BackgroundWorker check_updates;
        private System.ComponentModel.BackgroundWorker prepare_app_after_draw;
        private System.Windows.Forms.GroupBox prem_g;
        private System.Windows.Forms.Button prem_act;
        private System.Windows.Forms.Label prem_psw_l;
        private System.Windows.Forms.TextBox prem_psw;
        private System.Windows.Forms.Label prem_info;
        private System.Windows.Forms.Button dondon2;
        private System.Windows.Forms.Label prem_info_2;
        private System.Windows.Forms.CheckBox prem_show;
        private System.Windows.Forms.GroupBox prem_set;
        private System.Windows.Forms.PictureBox prem_help1;
        private System.Windows.Forms.CheckBox hide_don_btn;
        private System.Windows.Forms.TabPage backup_tab;
        private System.Windows.Forms.GroupBox ex_backup;
        private System.Windows.Forms.PictureBox prem_help2;
        private System.Windows.Forms.Label rem_old_backups_l;
        private System.Windows.Forms.TextBox rem_old_backups_count;
        private System.Windows.Forms.CheckBox rem_old_backups;
        private System.Windows.Forms.TabPage srv_list;
        private System.Windows.Forms.GroupBox deds_g;
        private System.Windows.Forms.Button dtds_visit;
        private System.Windows.Forms.Label dtds_info;
        private System.Windows.Forms.ListBox dtds_lista;
        private System.Windows.Forms.Button dtds_add;
        private System.Windows.Forms.ComboBox dtds_possible;
        private System.Windows.Forms.Label dtds_explain;
        private System.Windows.Forms.CheckBox dtds_enable;
        private System.Windows.Forms.Button dtds_rem;
        private System.Windows.Forms.Label dtds_info2;
        private System.Windows.Forms.TextBox dtds_auth;
        private System.Windows.Forms.Button dbg_btn;
        private System.Windows.Forms.Button contact_b;
        private System.Windows.Forms.GroupBox restore_backup_g;
        private System.Windows.Forms.Button backup_refresh;
        private System.Windows.Forms.Button restore_now;
        private System.Windows.Forms.ListBox backups_list;
        private System.Windows.Forms.Button backup_del;
        private System.Windows.Forms.Button create_bp_now;
        private System.Windows.Forms.Button opeb_bp_dir;
        private System.Windows.Forms.CheckBox dtds_show;
        private System.Windows.Forms.TextBox exe_name;
        private System.Windows.Forms.Label exe_name_l;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton PlayerKillingMode_0;
        private System.Windows.Forms.RadioButton PlayerKillingMode_1;
        private System.Windows.Forms.RadioButton PlayerKillingMode_2;
        private System.Windows.Forms.RadioButton PlayerKillingMode_3;
        private System.Windows.Forms.GroupBox PlayerKillingMode_g;
        private System.Windows.Forms.CheckBox AirDropMarker;
        private System.Windows.Forms.Button help_b;
        private System.Windows.Forms.ListView All_Players_List;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label all_players_l;
        private System.Windows.Forms.Label online_l;
        private System.Windows.Forms.Label updates_channel_l;
        private System.Windows.Forms.ComboBox updates_channel;
        private System.Windows.Forms.GroupBox dsm_updates_g;
        private System.Windows.Forms.Label updates_info;
        private System.Windows.Forms.GroupBox exe_settings_g;
        private System.Windows.Forms.Button force_upd;
        private System.Windows.Forms.Button chk_upd;
        private System.Windows.Forms.Button apply_update_channel;
        private System.Windows.Forms.TabPage globalBanList;
        private System.Windows.Forms.GroupBox global_ban_g;
        private System.Windows.Forms.CheckBox sendbans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton glob_3;
        private System.Windows.Forms.RadioButton glob_0;
        private System.Windows.Forms.RadioButton glob_2;
        private System.Windows.Forms.RadioButton glob_1;
        private System.Windows.Forms.PictureBox banlist_logo;
        private System.Windows.Forms.Button check_bans;
        private System.Windows.Forms.Button dbg_btn_2;
        public System.Windows.Forms.ListView Online_Player_List;
        public System.Windows.Forms.TrackBar maxpl;
        private System.Windows.Forms.TabPage WebServer;
        private System.Windows.Forms.GroupBox android_g;
        private System.Windows.Forms.CheckBox android_allow;
        private System.Windows.Forms.Label android_access_key;
        private System.Windows.Forms.GroupBox website_g;
        private System.Windows.Forms.Label website_l;
        private System.Windows.Forms.CheckBox enable_website;
        private System.Windows.Forms.Button android_play;
        private System.Windows.Forms.Label or_l;
        private System.Windows.Forms.Button android_apk;
        private System.Windows.Forms.GroupBox autofix_g;
        private System.Windows.Forms.Button fix_firewall_and_other_windows_shit;
        private System.Windows.Forms.Label fix_l;
        private System.Windows.Forms.Button reverse_reservation;
        private System.Windows.Forms.Label conflict_l;
        private System.Windows.Forms.TextBox forum_url;
        private System.Windows.Forms.RichTextBox www_main_content;
        private System.Windows.Forms.Label forum_url_l;
        private System.Windows.Forms.TabControl www_rules_content;
        private System.Windows.Forms.TabPage home_tab;
        private System.Windows.Forms.TabPage rules_tab;
        private System.Windows.Forms.TabPage other_tab;
        private System.Windows.Forms.RichTextBox rules_content;
        private System.Windows.Forms.ListBox allowed_replacements;
        private System.Windows.Forms.Label allowed_replacements_l;
        private System.Windows.Forms.CheckBox hide_footer;
        private System.Windows.Forms.PictureBox prem_help3;
        private System.Windows.Forms.TabPage net_opts;
        private System.Windows.Forms.GroupBox reserved_g;
        private System.Windows.Forms.TextBox ServerAdminSlotsPermission;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ServerAdminSlots;
        private System.Windows.Forms.TextBox ServerReservedSlotsPermission;
        private System.Windows.Forms.Label res_l2;
        private System.Windows.Forms.Label res_l1;
        private System.Windows.Forms.TextBox ServerReservedSlots;
        private System.Windows.Forms.GroupBox ServerDisabledNetworkProtocols_g;
        private System.Windows.Forms.CheckBox UNET;
        private System.Windows.Forms.CheckBox RakNet;
        private System.Windows.Forms.CheckBox SteamNetworking;
        private System.Windows.Forms.GroupBox BloodMoonEnemyCount_g;
        private System.Windows.Forms.TrackBar BloodMoonEnemyCount;
        private System.Windows.Forms.GroupBox HideCommandExecutionLog_g;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton HideCommandExecutionLog_0;
        private System.Windows.Forms.RadioButton HideCommandExecutionLog_1;
        private System.Windows.Forms.RadioButton HideCommandExecutionLog_2;
        private System.Windows.Forms.RadioButton HideCommandExecutionLog_3;
        private System.Windows.Forms.GroupBox BedrollDeadZoneSize_g;
        private System.Windows.Forms.TrackBar BedrollDeadZoneSize;
        private System.Windows.Forms.GroupBox MaxUncoveredMapChunksPerPlayer_g;
        private System.Windows.Forms.TextBox MaxUncoveredMapChunksPerPlayer;
        private System.Windows.Forms.CheckBox EnemySpawnMode;
        private System.Windows.Forms.CheckBox excall;
        private System.Windows.Forms.Label excall_file_l;
        private System.Windows.Forms.Button excall_file;
        private System.Windows.Forms.OpenFileDialog externalCallFile;
        private System.Windows.Forms.Button how_to_commands2;
        private System.Windows.Forms.Label Auto_Command_Timer;
        private System.Windows.Forms.GroupBox News_Group;
        private System.Windows.Forms.GroupBox Server_Status_Group;
        private System.Windows.Forms.RichTextBox News_Feed_RichTextBox;
        private System.Windows.Forms.SplitContainer overviewSplitter;
        private System.Windows.Forms.Button zoomup;
        private System.Windows.Forms.Label osver;
        private System.Windows.Forms.Label telnetstatus;
        private System.Windows.Forms.Label osarch;
        private System.Windows.Forms.Button discord_b;
        private System.Windows.Forms.ListBox commandslist;
        private System.Windows.Forms.GroupBox CommandsGroup;
        private System.Windows.Forms.Button usecmd;
    }
}