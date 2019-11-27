namespace _7DaysServerManager
{
    partial class Server_Panel_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server_Panel_Form));
            this.status_updater = new System.ComponentModel.BackgroundWorker();
            this.Select_Game_Directory = new System.Windows.Forms.FolderBrowserDialog();
            this.App_Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Public_IP_Address_Label = new System.Windows.Forms.Label();
            this.Settings_TabPage = new System.Windows.Forms.TabPage();
            this.Updates_GroupBox = new System.Windows.Forms.GroupBox();
            this.Apply_Update_Channel_Button = new System.Windows.Forms.Button();
            this.Force_Update_Button = new System.Windows.Forms.Button();
            this.Check_Updates_Button = new System.Windows.Forms.Button();
            this.updates_info = new System.Windows.Forms.Label();
            this.Update_Channel_Label = new System.Windows.Forms.Label();
            this.Update_Channel_ComboBox = new System.Windows.Forms.ComboBox();
            this.exe_settings_g = new System.Windows.Forms.GroupBox();
            this.exe_name_l = new System.Windows.Forms.Label();
            this.exe_name = new System.Windows.Forms.TextBox();
            this.Supporter_Settings_GroupBox = new System.Windows.Forms.GroupBox();
            this.Premium_Settings_Help_PictureBox = new System.Windows.Forms.PictureBox();
            this.Hide_Donation_Buttons_CheckBox = new System.Windows.Forms.CheckBox();
            this.Supporter_GroupBox = new System.Windows.Forms.GroupBox();
            this.Support_Code_Show_CheckBox = new System.Windows.Forms.CheckBox();
            this.Supporter_Donate_Button = new System.Windows.Forms.Button();
            this.Supporter_Instructions_Label = new System.Windows.Forms.Label();
            this.Supporter_Status_Label = new System.Windows.Forms.Label();
            this.Supporter_Activate_Button = new System.Windows.Forms.Button();
            this.Supporter_Code_Label = new System.Windows.Forms.Label();
            this.Support_Code_TextBox = new System.Windows.Forms.TextBox();
            this.debug_log = new System.Windows.Forms.CheckBox();
            this.SQL_GroupBox = new System.Windows.Forms.GroupBox();
            this.SQL_Enabled_CheckBox = new System.Windows.Forms.CheckBox();
            this.SQL_Update_Time_GroupBox = new System.Windows.Forms.GroupBox();
            this.SQL_Update_Time_Info_PictureBox = new System.Windows.Forms.PictureBox();
            this.SQL_Update_Time_TextBox = new System.Windows.Forms.TextBox();
            this.SQL_Update_Time_Label = new System.Windows.Forms.Label();
            this.SQL_Host_GroupBox = new System.Windows.Forms.GroupBox();
            this.SQL_Host_Info_PictureBox = new System.Windows.Forms.PictureBox();
            this.SQL_Host_TextBox = new System.Windows.Forms.TextBox();
            this.SQL_How_To_Integrate_Button = new System.Windows.Forms.Button();
            this.SQL_Username_GroupBox = new System.Windows.Forms.GroupBox();
            this.SQL_Username_Info_PictureBox = new System.Windows.Forms.PictureBox();
            this.SQL_Username_TextBox = new System.Windows.Forms.TextBox();
            this.SQL_DB_Name_GroupBox = new System.Windows.Forms.GroupBox();
            this.SQL_Database_Name_Info_PictureBox = new System.Windows.Forms.PictureBox();
            this.SQL_Database_Name_TextBox = new System.Windows.Forms.TextBox();
            this.SQL_Password_GroupBox = new System.Windows.Forms.GroupBox();
            this.SQL_Password_Info_PictureBox = new System.Windows.Forms.PictureBox();
            this.SQL_Encrption_Warning_Label = new System.Windows.Forms.Label();
            this.SQL_Password_TextBox = new System.Windows.Forms.TextBox();
            this.blad = new System.Windows.Forms.Button();
            this.workerynapis = new System.Windows.Forms.Label();
            this.taskman = new System.Windows.Forms.ListBox();
            this.Settings_GroupBox = new System.Windows.Forms.GroupBox();
            this.Settings_Skip_Profiles_CheckBox = new System.Windows.Forms.CheckBox();
            this.Browse_Game_File_Path_Button = new System.Windows.Forms.Button();
            this.anon_data_2 = new System.Windows.Forms.LinkLabel();
            this.Settings_Allow_Anon_Data_CheckBox = new System.Windows.Forms.CheckBox();
            this.Settings_Clean_Exit_CheckBox = new System.Windows.Forms.CheckBox();
            this.Settings_Show_IPS_CheckBox = new System.Windows.Forms.CheckBox();
            this.Auto_Detect_Game_File_Path_Button = new System.Windows.Forms.Button();
            this.Settings_Always_On_Top_CheckBox = new System.Windows.Forms.CheckBox();
            this.Change_Game_File_Path_Button = new System.Windows.Forms.Button();
            this.Game_File_Path_Label = new System.Windows.Forms.Label();
            this.Settings_Send_To_Tray_CheckBox = new System.Windows.Forms.CheckBox();
            this.About_Button = new System.Windows.Forms.Button();
            this.auto_backup_group = new System.Windows.Forms.GroupBox();
            this.backup_location_l = new System.Windows.Forms.Label();
            this.backup_location = new System.Windows.Forms.TextBox();
            this.backup_chat = new System.Windows.Forms.CheckBox();
            this.auto_backup_check = new System.Windows.Forms.CheckBox();
            this.backup_time = new System.Windows.Forms.TrackBar();
            this.Spawn_GroupBox = new System.Windows.Forms.GroupBox();
            this.Spawn_Item_Button = new System.Windows.Forms.Button();
            this.Spawn_Item_ComboBox = new System.Windows.Forms.ComboBox();
            this.Game_Time_Controls_GroupBox = new System.Windows.Forms.GroupBox();
            this.godzina = new System.Windows.Forms.Label();
            this.dzien = new System.Windows.Forms.Label();
            this.Set_Game_Time_Button = new System.Windows.Forms.Button();
            this.Game_Day_TrackBar = new System.Windows.Forms.TrackBar();
            this.Game_Hour_TrackBar = new System.Windows.Forms.TrackBar();
            this.cmd = new System.Windows.Forms.TextBox();
            this.Console_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.startbar = new System.Windows.Forms.ProgressBar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ManageServer_TabPage = new System.Windows.Forms.TabPage();
            this.CommandsGroup = new System.Windows.Forms.GroupBox();
            this.usecmd = new System.Windows.Forms.Button();
            this.commandslist = new System.Windows.Forms.ListBox();
            this.zoomup = new System.Windows.Forms.Button();
            this.overviewSplitter = new System.Windows.Forms.SplitContainer();
            this.News_Group = new System.Windows.Forms.GroupBox();
            this.News_Feed_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Server_Status_Group = new System.Windows.Forms.GroupBox();
            this.OS_Architecture_Label = new System.Windows.Forms.Label();
            this.telnetstatus = new System.Windows.Forms.Label();
            this.OS_Version_Label = new System.Windows.Forms.Label();
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
            this.PlayerManagement_TabPage = new System.Windows.Forms.TabPage();
            this.Chat_GroupBox = new System.Windows.Forms.GroupBox();
            this.Chat_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Chat_Input_TextBox = new System.Windows.Forms.TextBox();
            this.All_Players_Label = new System.Windows.Forms.Label();
            this.Online_Players_Label = new System.Windows.Forms.Label();
            this.All_Players_List = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Player_GroupBox = new System.Windows.Forms.GroupBox();
            this.Thirsty_Player_Button = new System.Windows.Forms.Button();
            this.Starve_Player_Button = new System.Windows.Forms.Button();
            this.Kill_Player_Button = new System.Windows.Forms.Button();
            this.Kick_GroupBox = new System.Windows.Forms.GroupBox();
            this.Kick_Player_Button = new System.Windows.Forms.Button();
            this.Kick_Reason_ComboBox = new System.Windows.Forms.ComboBox();
            this.Ban_GroupBox = new System.Windows.Forms.GroupBox();
            this.Ban_Time_ComboBox = new System.Windows.Forms.ComboBox();
            this.Ban_Hammer_Button = new System.Windows.Forms.Button();
            this.Ban_Slider_TrackBar = new System.Windows.Forms.TrackBar();
            this.Online_Player_List = new System.Windows.Forms.ListView();
            this.login_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.steamid_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameSettings_TabPage = new System.Windows.Forms.TabPage();
            this.main_page_opts = new System.Windows.Forms.TabControl();
            this.game_opts = new System.Windows.Forms.TabPage();
            this.Drop_On_Quit_GroupBox = new System.Windows.Forms.GroupBox();
            this.Drop_On_Quit_Mode_0 = new System.Windows.Forms.RadioButton();
            this.Drop_On_Quit_Mode_1 = new System.Windows.Forms.RadioButton();
            this.Drop_On_Quit_Mode_3 = new System.Windows.Forms.RadioButton();
            this.Drop_On_Quit_Mode_2 = new System.Windows.Forms.RadioButton();
            this.Server_Reserved_Slots_GroupBox = new System.Windows.Forms.GroupBox();
            this.Server_Admin_Reserved_Slots_Permission = new System.Windows.Forms.TextBox();
            this.Admin_Slot_Text_Label = new System.Windows.Forms.Label();
            this.Admin_Reserve_Text_Label = new System.Windows.Forms.Label();
            this.Server_Admin_Reserved_Slots = new System.Windows.Forms.TextBox();
            this.Server_Player_Reserved_Slots_Permission = new System.Windows.Forms.TextBox();
            this.Player_Slot_Text_Label = new System.Windows.Forms.Label();
            this.Player_Reserve_Text_Label = new System.Windows.Forms.Label();
            this.Server_Player_Reserved_Slots = new System.Windows.Forms.TextBox();
            this.Player_Killing_Mode_GroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Player_Killing_Mode_0 = new System.Windows.Forms.RadioButton();
            this.Player_Killing_Mode_1 = new System.Windows.Forms.RadioButton();
            this.Player_Killing_Mode_2 = new System.Windows.Forms.RadioButton();
            this.Player_Killing_Mode_3 = new System.Windows.Forms.RadioButton();
            this.Spawn_Settings_GroupBox = new System.Windows.Forms.GroupBox();
            this.Player_Safe_Zone_Hours_Label = new System.Windows.Forms.Label();
            this.Player_Safe_Zone_Level_Label = new System.Windows.Forms.Label();
            this.Player_Safe_Zone_Hours_TextBox = new System.Windows.Forms.TextBox();
            this.Player_Safe_Zone_Level_TextBox = new System.Windows.Forms.TextBox();
            this.Air_Drop_Frequency_GroupBox = new System.Windows.Forms.GroupBox();
            this.Air_Drop_Frequency_TrackBar = new System.Windows.Forms.TrackBar();
            this.Land_Claim_GroupBox = new System.Windows.Forms.GroupBox();
            this.Land_Claim_Decay_Mode_GroupBox = new System.Windows.Forms.GroupBox();
            this.Full_prot = new System.Windows.Forms.RadioButton();
            this.Exponential = new System.Windows.Forms.RadioButton();
            this.Linear = new System.Windows.Forms.RadioButton();
            this.Land_Claim_Durability_Modifier_GroupBox = new System.Windows.Forms.GroupBox();
            this.Land_Claim_Durability_Offline_Label = new System.Windows.Forms.Label();
            this.Land_Claim_Durability_Online_Label = new System.Windows.Forms.Label();
            this.LandClaimOfflineDurabilityModifier = new System.Windows.Forms.TextBox();
            this.LandClaimOnlineDurabilityModifier = new System.Windows.Forms.TextBox();
            this.Land_Claim_Size_GroupBox = new System.Windows.Forms.GroupBox();
            this.Land_Claim_Size_TextBox = new System.Windows.Forms.TextBox();
            this.Land_Claim_Dead_Zone_GroupBox = new System.Windows.Forms.GroupBox();
            this.Land_Claim_Dead_Zone_TextBox = new System.Windows.Forms.TextBox();
            this.Land_Claim_Expiry_Time_GroupBox = new System.Windows.Forms.GroupBox();
            this.Land_Claim_Expiry_Time_TextBox = new System.Windows.Forms.TextBox();
            this.Loot_Respawn_Days_GroupBox = new System.Windows.Forms.GroupBox();
            this.LootRespawnDays = new System.Windows.Forms.TrackBar();
            this.Loot_Abundance_GroupBox = new System.Windows.Forms.GroupBox();
            this.LootAbundance = new System.Windows.Forms.TrackBar();
            this.Max_Players_GroupBox = new System.Windows.Forms.GroupBox();
            this.maxpl = new System.Windows.Forms.TrackBar();
            this.Game_Mode_Settings_GroupBox = new System.Windows.Forms.GroupBox();
            this.PersistentPlayerProfiles = new System.Windows.Forms.CheckBox();
            this.feral = new System.Windows.Forms.CheckBox();
            this.gamemode_surv_pvp = new System.Windows.Forms.RadioButton();
            this.cheatmode = new System.Windows.Forms.CheckBox();
            this.gamemode_coop = new System.Windows.Forms.RadioButton();
            this.Zombie_Settings_GroupBox = new System.Windows.Forms.GroupBox();
            this.zombie_never_run = new System.Windows.Forms.RadioButton();
            this.zombie_normal = new System.Windows.Forms.RadioButton();
            this.zombie_run = new System.Windows.Forms.RadioButton();
            this.nightpercentage_g = new System.Windows.Forms.GroupBox();
            this.nightpercentage = new System.Windows.Forms.TrackBar();
            this.Day_Length_GroupBox = new System.Windows.Forms.GroupBox();
            this.realtime = new System.Windows.Forms.CheckBox();
            this.dayLength = new System.Windows.Forms.TrackBar();
            this.bdm_g = new System.Windows.Forms.GroupBox();
            this.bdm = new System.Windows.Forms.TrackBar();
            this.Drop_On_Death_Group_Box = new System.Windows.Forms.GroupBox();
            this.Drop_On_Death_Mode_0 = new System.Windows.Forms.RadioButton();
            this.Drop_On_Death_Mode_1 = new System.Windows.Forms.RadioButton();
            this.Drop_On_Death_Mode_3 = new System.Windows.Forms.RadioButton();
            this.Drop_On_Death_Mode_2 = new System.Windows.Forms.RadioButton();
            this.Game_Difficulty_GroupBox = new System.Windows.Forms.GroupBox();
            this.Game_Difficulty_TrackBar = new System.Windows.Forms.TrackBar();
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
            this.gamename = new System.Windows.Forms.ComboBox();
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
            this.Header_Icons = new System.Windows.Forms.ImageList(this.components);
            this.Messaging_TabPage = new System.Windows.Forms.TabPage();
            this.Server_Chat_Messages_GroupBox = new System.Windows.Forms.GroupBox();
            this.cmd_not_yet = new System.Windows.Forms.TextBox();
            this.Command_Wait_Message_Label = new System.Windows.Forms.Label();
            this.Starting_Backup_Message_TextBox = new System.Windows.Forms.TextBox();
            this.Backup_Completed_Message_Label = new System.Windows.Forms.Label();
            this.reboot = new System.Windows.Forms.TextBox();
            this.Backup_Completed_Message_TextBox = new System.Windows.Forms.TextBox();
            this.Starting_Backup_Message_Label = new System.Windows.Forms.Label();
            this.Time_Until_Reboot_Message_Label = new System.Windows.Forms.Label();
            this.Reboot_Now_Message_Label = new System.Windows.Forms.Label();
            this.reboot_time = new System.Windows.Forms.TextBox();
            this.Custom_Commands_GroupBox = new System.Windows.Forms.GroupBox();
            this.How_To_Use_External_Calls_Button = new System.Windows.Forms.Button();
            this.External_Call_File_Name_Label = new System.Windows.Forms.Label();
            this.External_Call_File_Select_Button = new System.Windows.Forms.Button();
            this.Use_External_Call_CheckBox = new System.Windows.Forms.CheckBox();
            this.Enable_Custom_Commands_CheckBox = new System.Windows.Forms.CheckBox();
            this.How_To_Commands_Button = new System.Windows.Forms.Button();
            this.Custom_Commands_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.GlobalBanList_TabPage = new System.Windows.Forms.TabPage();
            this.check_bans = new System.Windows.Forms.Button();
            this.global_ban_g = new System.Windows.Forms.GroupBox();
            this.sendbans = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.glob_3 = new System.Windows.Forms.RadioButton();
            this.glob_0 = new System.Windows.Forms.RadioButton();
            this.glob_2 = new System.Windows.Forms.RadioButton();
            this.glob_1 = new System.Windows.Forms.RadioButton();
            this.banlist_logo = new System.Windows.Forms.PictureBox();
            this.WebServer_TabPage = new System.Windows.Forms.TabPage();
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
            this.ServerTasks_TabPage = new System.Windows.Forms.TabPage();
            this.Auto_Restarts_GroupBox = new System.Windows.Forms.GroupBox();
            this.Warn_Before_Restart_CheckBox = new System.Windows.Forms.CheckBox();
            this.Enable_Auto_Restarts_CheckBox = new System.Windows.Forms.CheckBox();
            this.Auto_Restart_Time_TrackBar = new System.Windows.Forms.TrackBar();
            this.Server_Commands_GroupBox = new System.Windows.Forms.GroupBox();
            this.Server_Commands_Say_Switch_CheckBox = new System.Windows.Forms.CheckBox();
            this.Server_Commands_Note_Label = new System.Windows.Forms.Label();
            this.Server_Commands_List_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Server_Commands_Delay_GroupBox = new System.Windows.Forms.GroupBox();
            this.Server_Commands_Time_TrackBar = new System.Windows.Forms.TrackBar();
            this.Whitelist_GroupBox = new System.Windows.Forms.GroupBox();
            this.Use_Whitelist_CheckBox = new System.Windows.Forms.CheckBox();
            this.Auto_Update_Whitelist_Text_Label = new System.Windows.Forms.Label();
            this.Update_Whitelist_Interval_TextBox = new System.Windows.Forms.TextBox();
            this.Auto_Update_Whitelist_CheckBox = new System.Windows.Forms.CheckBox();
            this.Auto_Update_External_Whitelist_Note_Label = new System.Windows.Forms.Label();
            this.Auto_Update_External_Whitelist_URL_TextBox = new System.Windows.Forms.TextBox();
            this.Backups_TabPage = new System.Windows.Forms.TabPage();
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
            this.Rewards_TabPage = new System.Windows.Forms.TabPage();
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
            this.Mods_TabPage = new System.Windows.Forms.TabPage();
            this.Private_IP_Address_Label = new System.Windows.Forms.Label();
            this.Settings_TabPage.SuspendLayout();
            this.Updates_GroupBox.SuspendLayout();
            this.exe_settings_g.SuspendLayout();
            this.Supporter_Settings_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Premium_Settings_Help_PictureBox)).BeginInit();
            this.Supporter_GroupBox.SuspendLayout();
            this.SQL_GroupBox.SuspendLayout();
            this.SQL_Update_Time_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQL_Update_Time_Info_PictureBox)).BeginInit();
            this.SQL_Host_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQL_Host_Info_PictureBox)).BeginInit();
            this.SQL_Username_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQL_Username_Info_PictureBox)).BeginInit();
            this.SQL_DB_Name_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQL_Database_Name_Info_PictureBox)).BeginInit();
            this.SQL_Password_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQL_Password_Info_PictureBox)).BeginInit();
            this.Settings_GroupBox.SuspendLayout();
            this.auto_backup_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backup_time)).BeginInit();
            this.Spawn_GroupBox.SuspendLayout();
            this.Game_Time_Controls_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Day_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Hour_TrackBar)).BeginInit();
            this.tabControl.SuspendLayout();
            this.ManageServer_TabPage.SuspendLayout();
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
            this.PlayerManagement_TabPage.SuspendLayout();
            this.Chat_GroupBox.SuspendLayout();
            this.Player_GroupBox.SuspendLayout();
            this.Kick_GroupBox.SuspendLayout();
            this.Ban_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ban_Slider_TrackBar)).BeginInit();
            this.GameSettings_TabPage.SuspendLayout();
            this.main_page_opts.SuspendLayout();
            this.game_opts.SuspendLayout();
            this.Drop_On_Quit_GroupBox.SuspendLayout();
            this.Server_Reserved_Slots_GroupBox.SuspendLayout();
            this.Player_Killing_Mode_GroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Spawn_Settings_GroupBox.SuspendLayout();
            this.Air_Drop_Frequency_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Air_Drop_Frequency_TrackBar)).BeginInit();
            this.Land_Claim_GroupBox.SuspendLayout();
            this.Land_Claim_Decay_Mode_GroupBox.SuspendLayout();
            this.Land_Claim_Durability_Modifier_GroupBox.SuspendLayout();
            this.Land_Claim_Size_GroupBox.SuspendLayout();
            this.Land_Claim_Dead_Zone_GroupBox.SuspendLayout();
            this.Land_Claim_Expiry_Time_GroupBox.SuspendLayout();
            this.Loot_Respawn_Days_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LootRespawnDays)).BeginInit();
            this.Loot_Abundance_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LootAbundance)).BeginInit();
            this.Max_Players_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxpl)).BeginInit();
            this.Game_Mode_Settings_GroupBox.SuspendLayout();
            this.Zombie_Settings_GroupBox.SuspendLayout();
            this.nightpercentage_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nightpercentage)).BeginInit();
            this.Day_Length_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayLength)).BeginInit();
            this.bdm_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdm)).BeginInit();
            this.Drop_On_Death_Group_Box.SuspendLayout();
            this.Game_Difficulty_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Difficulty_TrackBar)).BeginInit();
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
            this.Messaging_TabPage.SuspendLayout();
            this.Server_Chat_Messages_GroupBox.SuspendLayout();
            this.Custom_Commands_GroupBox.SuspendLayout();
            this.GlobalBanList_TabPage.SuspendLayout();
            this.global_ban_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banlist_logo)).BeginInit();
            this.WebServer_TabPage.SuspendLayout();
            this.autofix_g.SuspendLayout();
            this.website_g.SuspendLayout();
            this.www_rules_content.SuspendLayout();
            this.home_tab.SuspendLayout();
            this.rules_tab.SuspendLayout();
            this.other_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prem_help3)).BeginInit();
            this.android_g.SuspendLayout();
            this.ServerTasks_TabPage.SuspendLayout();
            this.Auto_Restarts_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Auto_Restart_Time_TrackBar)).BeginInit();
            this.Server_Commands_GroupBox.SuspendLayout();
            this.Server_Commands_Delay_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Server_Commands_Time_TrackBar)).BeginInit();
            this.Whitelist_GroupBox.SuspendLayout();
            this.Backups_TabPage.SuspendLayout();
            this.restore_backup_g.SuspendLayout();
            this.ex_backup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prem_help2)).BeginInit();
            this.Rewards_TabPage.SuspendLayout();
            this.deds_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_status)).BeginInit();
            this.SuspendLayout();
            // 
            // status_updater
            // 
            this.status_updater.WorkerSupportsCancellation = true;
            this.status_updater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // Select_Game_Directory
            // 
            this.Select_Game_Directory.Description = "Game dir";
            this.Select_Game_Directory.ShowNewFolderButton = false;
            this.Select_Game_Directory.HelpRequest += new System.EventHandler(this.Select_dir_HelpRequest);
            // 
            // App_Icon
            // 
            this.App_Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("App_Icon.Icon")));
            this.App_Icon.Text = "7 Days Server Manager";
            this.App_Icon.Visible = true;
            this.App_Icon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Ikona_MouseClick);
            // 
            // Public_IP_Address_Label
            // 
            this.Public_IP_Address_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Public_IP_Address_Label.AutoSize = true;
            this.Public_IP_Address_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Public_IP_Address_Label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Public_IP_Address_Label.Location = new System.Drawing.Point(6, 100);
            this.Public_IP_Address_Label.Name = "Public_IP_Address_Label";
            this.Public_IP_Address_Label.Size = new System.Drawing.Size(95, 13);
            this.Public_IP_Address_Label.TabIndex = 23;
            this.Public_IP_Address_Label.Text = "Getting Public IP...";
            this.Public_IP_Address_Label.Visible = false;
            // 
            // Settings_TabPage
            // 
            this.Settings_TabPage.BackColor = System.Drawing.SystemColors.Control;
            this.Settings_TabPage.Controls.Add(this.Updates_GroupBox);
            this.Settings_TabPage.Controls.Add(this.exe_settings_g);
            this.Settings_TabPage.Controls.Add(this.Supporter_Settings_GroupBox);
            this.Settings_TabPage.Controls.Add(this.Supporter_GroupBox);
            this.Settings_TabPage.Controls.Add(this.debug_log);
            this.Settings_TabPage.Controls.Add(this.SQL_GroupBox);
            this.Settings_TabPage.Controls.Add(this.blad);
            this.Settings_TabPage.Controls.Add(this.workerynapis);
            this.Settings_TabPage.Controls.Add(this.taskman);
            this.Settings_TabPage.Controls.Add(this.Settings_GroupBox);
            this.Settings_TabPage.Controls.Add(this.About_Button);
            this.Settings_TabPage.ImageIndex = 4;
            this.Settings_TabPage.Location = new System.Drawing.Point(47, 4);
            this.Settings_TabPage.Name = "Settings_TabPage";
            this.Settings_TabPage.Size = new System.Drawing.Size(908, 684);
            this.Settings_TabPage.TabIndex = 4;
            // 
            // Updates_GroupBox
            // 
            this.Updates_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Updates_GroupBox.Controls.Add(this.Apply_Update_Channel_Button);
            this.Updates_GroupBox.Controls.Add(this.Force_Update_Button);
            this.Updates_GroupBox.Controls.Add(this.Check_Updates_Button);
            this.Updates_GroupBox.Controls.Add(this.updates_info);
            this.Updates_GroupBox.Controls.Add(this.Update_Channel_Label);
            this.Updates_GroupBox.Controls.Add(this.Update_Channel_ComboBox);
            this.Updates_GroupBox.Location = new System.Drawing.Point(551, 58);
            this.Updates_GroupBox.Name = "Updates_GroupBox";
            this.Updates_GroupBox.Size = new System.Drawing.Size(350, 191);
            this.Updates_GroupBox.TabIndex = 41;
            this.Updates_GroupBox.TabStop = false;
            this.Updates_GroupBox.Text = "7DSM Updates";
            // 
            // Apply_Update_Channel_Button
            // 
            this.Apply_Update_Channel_Button.Location = new System.Drawing.Point(270, 22);
            this.Apply_Update_Channel_Button.Name = "Apply_Update_Channel_Button";
            this.Apply_Update_Channel_Button.Size = new System.Drawing.Size(75, 23);
            this.Apply_Update_Channel_Button.TabIndex = 44;
            this.Apply_Update_Channel_Button.Text = "Apply";
            this.Apply_Update_Channel_Button.UseVisualStyleBackColor = true;
            this.Apply_Update_Channel_Button.Click += new System.EventHandler(this.Apply_update_channel_Click);
            // 
            // Force_Update_Button
            // 
            this.Force_Update_Button.Location = new System.Drawing.Point(180, 151);
            this.Force_Update_Button.Name = "Force_Update_Button";
            this.Force_Update_Button.Size = new System.Drawing.Size(156, 23);
            this.Force_Update_Button.TabIndex = 43;
            this.Force_Update_Button.Text = "Force Update Now";
            this.Force_Update_Button.UseVisualStyleBackColor = true;
            this.Force_Update_Button.Click += new System.EventHandler(this.Force_upd_Click);
            // 
            // Check_Updates_Button
            // 
            this.Check_Updates_Button.Location = new System.Drawing.Point(18, 151);
            this.Check_Updates_Button.Name = "Check_Updates_Button";
            this.Check_Updates_Button.Size = new System.Drawing.Size(156, 23);
            this.Check_Updates_Button.TabIndex = 42;
            this.Check_Updates_Button.Text = "Check For Updates Now";
            this.Check_Updates_Button.UseVisualStyleBackColor = true;
            this.Check_Updates_Button.Click += new System.EventHandler(this.Chk_upd_Click);
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
            // Update_Channel_Label
            // 
            this.Update_Channel_Label.AutoSize = true;
            this.Update_Channel_Label.Location = new System.Drawing.Point(15, 26);
            this.Update_Channel_Label.Name = "Update_Channel_Label";
            this.Update_Channel_Label.Size = new System.Drawing.Size(125, 13);
            this.Update_Channel_Label.TabIndex = 40;
            this.Update_Channel_Label.Text = "7DSM Updates Channel:";
            // 
            // Update_Channel_ComboBox
            // 
            this.Update_Channel_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Update_Channel_ComboBox.FormattingEnabled = true;
            this.Update_Channel_ComboBox.Items.AddRange(new object[] {
            "STABLE",
            "DEV"});
            this.Update_Channel_ComboBox.Location = new System.Drawing.Point(145, 23);
            this.Update_Channel_ComboBox.Name = "Update_Channel_ComboBox";
            this.Update_Channel_ComboBox.Size = new System.Drawing.Size(119, 21);
            this.Update_Channel_ComboBox.TabIndex = 39;
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
            this.exe_name.TextChanged += new System.EventHandler(this.Exe_name_TextChanged);
            // 
            // Supporter_Settings_GroupBox
            // 
            this.Supporter_Settings_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Supporter_Settings_GroupBox.Controls.Add(this.Premium_Settings_Help_PictureBox);
            this.Supporter_Settings_GroupBox.Controls.Add(this.Hide_Donation_Buttons_CheckBox);
            this.Supporter_Settings_GroupBox.Location = new System.Drawing.Point(551, 460);
            this.Supporter_Settings_GroupBox.Name = "Supporter_Settings_GroupBox";
            this.Supporter_Settings_GroupBox.Size = new System.Drawing.Size(351, 45);
            this.Supporter_Settings_GroupBox.TabIndex = 39;
            this.Supporter_Settings_GroupBox.TabStop = false;
            this.Supporter_Settings_GroupBox.Text = "Supporter Settings";
            // 
            // Premium_Settings_Help_PictureBox
            // 
            this.Premium_Settings_Help_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Premium_Settings_Help_PictureBox.Image")));
            this.Premium_Settings_Help_PictureBox.Location = new System.Drawing.Point(329, 19);
            this.Premium_Settings_Help_PictureBox.Name = "Premium_Settings_Help_PictureBox";
            this.Premium_Settings_Help_PictureBox.Size = new System.Drawing.Size(16, 16);
            this.Premium_Settings_Help_PictureBox.TabIndex = 40;
            this.Premium_Settings_Help_PictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.Premium_Settings_Help_PictureBox, "You need 7DSM Supporter to change these options.\r\nIt\'s almost free, please check " +
        "it out in \"Settings\" tab.");
            // 
            // Hide_Donation_Buttons_CheckBox
            // 
            this.Hide_Donation_Buttons_CheckBox.AutoSize = true;
            this.Hide_Donation_Buttons_CheckBox.Enabled = false;
            this.Hide_Donation_Buttons_CheckBox.Location = new System.Drawing.Point(18, 20);
            this.Hide_Donation_Buttons_CheckBox.Name = "Hide_Donation_Buttons_CheckBox";
            this.Hide_Donation_Buttons_CheckBox.Size = new System.Drawing.Size(133, 17);
            this.Hide_Donation_Buttons_CheckBox.TabIndex = 41;
            this.Hide_Donation_Buttons_CheckBox.Text = "Hide Donation Buttons";
            this.Hide_Donation_Buttons_CheckBox.UseVisualStyleBackColor = true;
            this.Hide_Donation_Buttons_CheckBox.CheckedChanged += new System.EventHandler(this.Hide_Donate_Button_CheckedChanged);
            // 
            // Supporter_GroupBox
            // 
            this.Supporter_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Supporter_GroupBox.Controls.Add(this.Support_Code_Show_CheckBox);
            this.Supporter_GroupBox.Controls.Add(this.Supporter_Donate_Button);
            this.Supporter_GroupBox.Controls.Add(this.Supporter_Instructions_Label);
            this.Supporter_GroupBox.Controls.Add(this.Supporter_Status_Label);
            this.Supporter_GroupBox.Controls.Add(this.Supporter_Activate_Button);
            this.Supporter_GroupBox.Controls.Add(this.Supporter_Code_Label);
            this.Supporter_GroupBox.Controls.Add(this.Support_Code_TextBox);
            this.Supporter_GroupBox.Location = new System.Drawing.Point(551, 255);
            this.Supporter_GroupBox.Name = "Supporter_GroupBox";
            this.Supporter_GroupBox.Size = new System.Drawing.Size(351, 199);
            this.Supporter_GroupBox.TabIndex = 38;
            this.Supporter_GroupBox.TabStop = false;
            this.Supporter_GroupBox.Text = "7DSM Supporter";
            // 
            // Support_Code_Show_CheckBox
            // 
            this.Support_Code_Show_CheckBox.AutoSize = true;
            this.Support_Code_Show_CheckBox.Location = new System.Drawing.Point(135, 19);
            this.Support_Code_Show_CheckBox.Name = "Support_Code_Show_CheckBox";
            this.Support_Code_Show_CheckBox.Size = new System.Drawing.Size(135, 17);
            this.Support_Code_Show_CheckBox.TabIndex = 27;
            this.Support_Code_Show_CheckBox.Text = "Show Code Characters";
            this.Support_Code_Show_CheckBox.UseVisualStyleBackColor = true;
            this.Support_Code_Show_CheckBox.CheckedChanged += new System.EventHandler(this.Prem_show_CheckedChanged);
            // 
            // Supporter_Donate_Button
            // 
            this.Supporter_Donate_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Supporter_Donate_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Supporter_Donate_Button.BackgroundImage")));
            this.Supporter_Donate_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Supporter_Donate_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Supporter_Donate_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Supporter_Donate_Button.FlatAppearance.BorderSize = 0;
            this.Supporter_Donate_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supporter_Donate_Button.Location = new System.Drawing.Point(135, 68);
            this.Supporter_Donate_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Supporter_Donate_Button.Name = "Supporter_Donate_Button";
            this.Supporter_Donate_Button.Size = new System.Drawing.Size(75, 23);
            this.Supporter_Donate_Button.TabIndex = 26;
            this.Supporter_Donate_Button.UseVisualStyleBackColor = true;
            this.Supporter_Donate_Button.Click += new System.EventHandler(this.Forumklik_Click);
            // 
            // Supporter_Instructions_Label
            // 
            this.Supporter_Instructions_Label.AutoSize = true;
            this.Supporter_Instructions_Label.Location = new System.Drawing.Point(6, 114);
            this.Supporter_Instructions_Label.Name = "Supporter_Instructions_Label";
            this.Supporter_Instructions_Label.Size = new System.Drawing.Size(308, 78);
            this.Supporter_Instructions_Label.TabIndex = 6;
            this.Supporter_Instructions_Label.Text = resources.GetString("Supporter_Instructions_Label.Text");
            // 
            // Supporter_Status_Label
            // 
            this.Supporter_Status_Label.AutoSize = true;
            this.Supporter_Status_Label.Location = new System.Drawing.Point(132, 94);
            this.Supporter_Status_Label.Name = "Supporter_Status_Label";
            this.Supporter_Status_Label.Size = new System.Drawing.Size(163, 13);
            this.Supporter_Status_Label.TabIndex = 5;
            this.Supporter_Status_Label.Text = "Supporter Status: NOT Activated";
            // 
            // Supporter_Activate_Button
            // 
            this.Supporter_Activate_Button.Location = new System.Drawing.Point(216, 68);
            this.Supporter_Activate_Button.Name = "Supporter_Activate_Button";
            this.Supporter_Activate_Button.Size = new System.Drawing.Size(75, 23);
            this.Supporter_Activate_Button.TabIndex = 4;
            this.Supporter_Activate_Button.Text = "Activate";
            this.Supporter_Activate_Button.UseVisualStyleBackColor = true;
            this.Supporter_Activate_Button.Click += new System.EventHandler(this.Prem_act_Click);
            // 
            // Supporter_Code_Label
            // 
            this.Supporter_Code_Label.AutoSize = true;
            this.Supporter_Code_Label.Location = new System.Drawing.Point(52, 45);
            this.Supporter_Code_Label.Name = "Supporter_Code_Label";
            this.Supporter_Code_Label.Size = new System.Drawing.Size(84, 13);
            this.Supporter_Code_Label.TabIndex = 3;
            this.Supporter_Code_Label.Text = "Supporter Code:";
            // 
            // Support_Code_TextBox
            // 
            this.Support_Code_TextBox.Location = new System.Drawing.Point(140, 42);
            this.Support_Code_TextBox.MaxLength = 8;
            this.Support_Code_TextBox.Name = "Support_Code_TextBox";
            this.Support_Code_TextBox.PasswordChar = '*';
            this.Support_Code_TextBox.Size = new System.Drawing.Size(156, 20);
            this.Support_Code_TextBox.TabIndex = 1;
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
            this.debug_log.CheckedChanged += new System.EventHandler(this.Debug_Log_CheckedChanged);
            // 
            // SQL_GroupBox
            // 
            this.SQL_GroupBox.Controls.Add(this.SQL_Enabled_CheckBox);
            this.SQL_GroupBox.Controls.Add(this.SQL_Update_Time_GroupBox);
            this.SQL_GroupBox.Controls.Add(this.SQL_Host_GroupBox);
            this.SQL_GroupBox.Controls.Add(this.SQL_How_To_Integrate_Button);
            this.SQL_GroupBox.Controls.Add(this.SQL_Username_GroupBox);
            this.SQL_GroupBox.Controls.Add(this.SQL_DB_Name_GroupBox);
            this.SQL_GroupBox.Controls.Add(this.SQL_Password_GroupBox);
            this.SQL_GroupBox.Location = new System.Drawing.Point(8, 238);
            this.SQL_GroupBox.Name = "SQL_GroupBox";
            this.SQL_GroupBox.Size = new System.Drawing.Size(534, 376);
            this.SQL_GroupBox.TabIndex = 10;
            this.SQL_GroupBox.TabStop = false;
            this.SQL_GroupBox.Text = "SQL";
            // 
            // SQL_Enabled_CheckBox
            // 
            this.SQL_Enabled_CheckBox.AutoSize = true;
            this.SQL_Enabled_CheckBox.Location = new System.Drawing.Point(6, 19);
            this.SQL_Enabled_CheckBox.Name = "SQL_Enabled_CheckBox";
            this.SQL_Enabled_CheckBox.Size = new System.Drawing.Size(185, 17);
            this.SQL_Enabled_CheckBox.TabIndex = 0;
            this.SQL_Enabled_CheckBox.Text = "Export Data To MySQL Database";
            this.SQL_Enabled_CheckBox.UseVisualStyleBackColor = true;
            this.SQL_Enabled_CheckBox.CheckedChanged += new System.EventHandler(this.Sql_enabled_CheckedChanged);
            // 
            // SQL_Update_Time_GroupBox
            // 
            this.SQL_Update_Time_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQL_Update_Time_GroupBox.Controls.Add(this.SQL_Update_Time_Info_PictureBox);
            this.SQL_Update_Time_GroupBox.Controls.Add(this.SQL_Update_Time_TextBox);
            this.SQL_Update_Time_GroupBox.Controls.Add(this.SQL_Update_Time_Label);
            this.SQL_Update_Time_GroupBox.Location = new System.Drawing.Point(6, 277);
            this.SQL_Update_Time_GroupBox.Name = "SQL_Update_Time_GroupBox";
            this.SQL_Update_Time_GroupBox.Size = new System.Drawing.Size(522, 50);
            this.SQL_Update_Time_GroupBox.TabIndex = 9;
            this.SQL_Update_Time_GroupBox.TabStop = false;
            this.SQL_Update_Time_GroupBox.Text = "SQL Update Time";
            // 
            // SQL_Update_Time_Info_PictureBox
            // 
            this.SQL_Update_Time_Info_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SQL_Update_Time_Info_PictureBox.Image")));
            this.SQL_Update_Time_Info_PictureBox.Location = new System.Drawing.Point(502, 23);
            this.SQL_Update_Time_Info_PictureBox.Name = "SQL_Update_Time_Info_PictureBox";
            this.SQL_Update_Time_Info_PictureBox.Size = new System.Drawing.Size(16, 16);
            this.SQL_Update_Time_Info_PictureBox.TabIndex = 45;
            this.SQL_Update_Time_Info_PictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.SQL_Update_Time_Info_PictureBox, "You need 7DSM Supporter to change these options.\r\nIt\'s almost free, please check " +
        "it out in \"Settings\" tab.");
            // 
            // SQL_Update_Time_TextBox
            // 
            this.SQL_Update_Time_TextBox.Location = new System.Drawing.Point(6, 19);
            this.SQL_Update_Time_TextBox.Name = "SQL_Update_Time_TextBox";
            this.SQL_Update_Time_TextBox.Size = new System.Drawing.Size(41, 20);
            this.SQL_Update_Time_TextBox.TabIndex = 1;
            this.SQL_Update_Time_TextBox.Text = "60";
            this.SQL_Update_Time_TextBox.TextChanged += new System.EventHandler(this.Sql_updates_time_TextChanged);
            // 
            // SQL_Update_Time_Label
            // 
            this.SQL_Update_Time_Label.AutoSize = true;
            this.SQL_Update_Time_Label.Location = new System.Drawing.Point(50, 23);
            this.SQL_Update_Time_Label.Name = "SQL_Update_Time_Label";
            this.SQL_Update_Time_Label.Size = new System.Drawing.Size(43, 13);
            this.SQL_Update_Time_Label.TabIndex = 7;
            this.SQL_Update_Time_Label.Text = "minutes";
            // 
            // SQL_Host_GroupBox
            // 
            this.SQL_Host_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQL_Host_GroupBox.Controls.Add(this.SQL_Host_Info_PictureBox);
            this.SQL_Host_GroupBox.Controls.Add(this.SQL_Host_TextBox);
            this.SQL_Host_GroupBox.Location = new System.Drawing.Point(6, 42);
            this.SQL_Host_GroupBox.Name = "SQL_Host_GroupBox";
            this.SQL_Host_GroupBox.Size = new System.Drawing.Size(522, 50);
            this.SQL_Host_GroupBox.TabIndex = 2;
            this.SQL_Host_GroupBox.TabStop = false;
            this.SQL_Host_GroupBox.Text = "SQL Host";
            // 
            // SQL_Host_Info_PictureBox
            // 
            this.SQL_Host_Info_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SQL_Host_Info_PictureBox.Image")));
            this.SQL_Host_Info_PictureBox.Location = new System.Drawing.Point(502, 21);
            this.SQL_Host_Info_PictureBox.Name = "SQL_Host_Info_PictureBox";
            this.SQL_Host_Info_PictureBox.Size = new System.Drawing.Size(16, 16);
            this.SQL_Host_Info_PictureBox.TabIndex = 41;
            this.SQL_Host_Info_PictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.SQL_Host_Info_PictureBox, "You need 7DSM Supporter to change these options.\r\nIt\'s almost free, please check " +
        "it out in \"Settings\" tab.");
            // 
            // SQL_Host_TextBox
            // 
            this.SQL_Host_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQL_Host_TextBox.Location = new System.Drawing.Point(6, 19);
            this.SQL_Host_TextBox.Name = "SQL_Host_TextBox";
            this.SQL_Host_TextBox.Size = new System.Drawing.Size(490, 20);
            this.SQL_Host_TextBox.TabIndex = 1;
            this.SQL_Host_TextBox.Text = "localhost";
            this.SQL_Host_TextBox.TextChanged += new System.EventHandler(this.Sql_host_TextChanged);
            // 
            // SQL_How_To_Integrate_Button
            // 
            this.SQL_How_To_Integrate_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQL_How_To_Integrate_Button.Location = new System.Drawing.Point(6, 333);
            this.SQL_How_To_Integrate_Button.Name = "SQL_How_To_Integrate_Button";
            this.SQL_How_To_Integrate_Button.Size = new System.Drawing.Size(522, 31);
            this.SQL_How_To_Integrate_Button.TabIndex = 8;
            this.SQL_How_To_Integrate_Button.Text = "How to integrate it with my website? - Examples";
            this.SQL_How_To_Integrate_Button.UseVisualStyleBackColor = true;
            this.SQL_How_To_Integrate_Button.Click += new System.EventHandler(this.How_to_sql_Click);
            // 
            // SQL_Username_GroupBox
            // 
            this.SQL_Username_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQL_Username_GroupBox.Controls.Add(this.SQL_Username_Info_PictureBox);
            this.SQL_Username_GroupBox.Controls.Add(this.SQL_Username_TextBox);
            this.SQL_Username_GroupBox.Location = new System.Drawing.Point(6, 98);
            this.SQL_Username_GroupBox.Name = "SQL_Username_GroupBox";
            this.SQL_Username_GroupBox.Size = new System.Drawing.Size(522, 50);
            this.SQL_Username_GroupBox.TabIndex = 3;
            this.SQL_Username_GroupBox.TabStop = false;
            this.SQL_Username_GroupBox.Text = "SQL Username";
            // 
            // SQL_Username_Info_PictureBox
            // 
            this.SQL_Username_Info_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SQL_Username_Info_PictureBox.Image")));
            this.SQL_Username_Info_PictureBox.Location = new System.Drawing.Point(502, 23);
            this.SQL_Username_Info_PictureBox.Name = "SQL_Username_Info_PictureBox";
            this.SQL_Username_Info_PictureBox.Size = new System.Drawing.Size(16, 16);
            this.SQL_Username_Info_PictureBox.TabIndex = 42;
            this.SQL_Username_Info_PictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.SQL_Username_Info_PictureBox, "You need 7DSM Supporter to change these options.\r\nIt\'s almost free, please check " +
        "it out in \"Settings\" tab.");
            // 
            // SQL_Username_TextBox
            // 
            this.SQL_Username_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQL_Username_TextBox.Location = new System.Drawing.Point(6, 19);
            this.SQL_Username_TextBox.Name = "SQL_Username_TextBox";
            this.SQL_Username_TextBox.Size = new System.Drawing.Size(490, 20);
            this.SQL_Username_TextBox.TabIndex = 1;
            this.SQL_Username_TextBox.Text = "root";
            this.SQL_Username_TextBox.TextChanged += new System.EventHandler(this.Sql_username_TextChanged);
            // 
            // SQL_DB_Name_GroupBox
            // 
            this.SQL_DB_Name_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQL_DB_Name_GroupBox.Controls.Add(this.SQL_Database_Name_Info_PictureBox);
            this.SQL_DB_Name_GroupBox.Controls.Add(this.SQL_Database_Name_TextBox);
            this.SQL_DB_Name_GroupBox.Location = new System.Drawing.Point(6, 221);
            this.SQL_DB_Name_GroupBox.Name = "SQL_DB_Name_GroupBox";
            this.SQL_DB_Name_GroupBox.Size = new System.Drawing.Size(522, 50);
            this.SQL_DB_Name_GroupBox.TabIndex = 5;
            this.SQL_DB_Name_GroupBox.TabStop = false;
            this.SQL_DB_Name_GroupBox.Text = "SQL Database Name";
            // 
            // SQL_Database_Name_Info_PictureBox
            // 
            this.SQL_Database_Name_Info_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SQL_Database_Name_Info_PictureBox.Image")));
            this.SQL_Database_Name_Info_PictureBox.Location = new System.Drawing.Point(502, 20);
            this.SQL_Database_Name_Info_PictureBox.Name = "SQL_Database_Name_Info_PictureBox";
            this.SQL_Database_Name_Info_PictureBox.Size = new System.Drawing.Size(16, 16);
            this.SQL_Database_Name_Info_PictureBox.TabIndex = 44;
            this.SQL_Database_Name_Info_PictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.SQL_Database_Name_Info_PictureBox, "You need 7DSM Supporter to change these options.\r\nIt\'s almost free, please check " +
        "it out in \"Settings\" tab.");
            // 
            // SQL_Database_Name_TextBox
            // 
            this.SQL_Database_Name_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQL_Database_Name_TextBox.Location = new System.Drawing.Point(6, 19);
            this.SQL_Database_Name_TextBox.Name = "SQL_Database_Name_TextBox";
            this.SQL_Database_Name_TextBox.Size = new System.Drawing.Size(490, 20);
            this.SQL_Database_Name_TextBox.TabIndex = 1;
            this.SQL_Database_Name_TextBox.Text = "test";
            this.SQL_Database_Name_TextBox.TextChanged += new System.EventHandler(this.Sql_db_name_TextChanged);
            // 
            // SQL_Password_GroupBox
            // 
            this.SQL_Password_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQL_Password_GroupBox.Controls.Add(this.SQL_Password_Info_PictureBox);
            this.SQL_Password_GroupBox.Controls.Add(this.SQL_Encrption_Warning_Label);
            this.SQL_Password_GroupBox.Controls.Add(this.SQL_Password_TextBox);
            this.SQL_Password_GroupBox.Location = new System.Drawing.Point(6, 154);
            this.SQL_Password_GroupBox.Name = "SQL_Password_GroupBox";
            this.SQL_Password_GroupBox.Size = new System.Drawing.Size(522, 61);
            this.SQL_Password_GroupBox.TabIndex = 4;
            this.SQL_Password_GroupBox.TabStop = false;
            this.SQL_Password_GroupBox.Text = "SQL Password";
            // 
            // SQL_Password_Info_PictureBox
            // 
            this.SQL_Password_Info_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SQL_Password_Info_PictureBox.Image")));
            this.SQL_Password_Info_PictureBox.Location = new System.Drawing.Point(502, 19);
            this.SQL_Password_Info_PictureBox.Name = "SQL_Password_Info_PictureBox";
            this.SQL_Password_Info_PictureBox.Size = new System.Drawing.Size(16, 16);
            this.SQL_Password_Info_PictureBox.TabIndex = 43;
            this.SQL_Password_Info_PictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.SQL_Password_Info_PictureBox, "You need 7DSM Supporter to change these options.\r\nIt\'s almost free, please check " +
        "it out in \"Settings\" tab.");
            // 
            // SQL_Encrption_Warning_Label
            // 
            this.SQL_Encrption_Warning_Label.AutoSize = true;
            this.SQL_Encrption_Warning_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SQL_Encrption_Warning_Label.Location = new System.Drawing.Point(6, 42);
            this.SQL_Encrption_Warning_Label.Name = "SQL_Encrption_Warning_Label";
            this.SQL_Encrption_Warning_Label.Size = new System.Drawing.Size(177, 13);
            this.SQL_Encrption_Warning_Label.TabIndex = 7;
            this.SQL_Encrption_Warning_Label.Text = "Stored Password is NOT Encrypted!";
            // 
            // SQL_Password_TextBox
            // 
            this.SQL_Password_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQL_Password_TextBox.Location = new System.Drawing.Point(6, 19);
            this.SQL_Password_TextBox.Name = "SQL_Password_TextBox";
            this.SQL_Password_TextBox.PasswordChar = '*';
            this.SQL_Password_TextBox.Size = new System.Drawing.Size(490, 20);
            this.SQL_Password_TextBox.TabIndex = 1;
            this.SQL_Password_TextBox.TextChanged += new System.EventHandler(this.Sql_password_TextChanged);
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
            this.blad.Click += new System.EventHandler(this.Blad_Click);
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
            // Settings_GroupBox
            // 
            this.Settings_GroupBox.Controls.Add(this.Settings_Skip_Profiles_CheckBox);
            this.Settings_GroupBox.Controls.Add(this.Browse_Game_File_Path_Button);
            this.Settings_GroupBox.Controls.Add(this.anon_data_2);
            this.Settings_GroupBox.Controls.Add(this.Settings_Allow_Anon_Data_CheckBox);
            this.Settings_GroupBox.Controls.Add(this.Settings_Clean_Exit_CheckBox);
            this.Settings_GroupBox.Controls.Add(this.Settings_Show_IPS_CheckBox);
            this.Settings_GroupBox.Controls.Add(this.Auto_Detect_Game_File_Path_Button);
            this.Settings_GroupBox.Controls.Add(this.Settings_Always_On_Top_CheckBox);
            this.Settings_GroupBox.Controls.Add(this.Change_Game_File_Path_Button);
            this.Settings_GroupBox.Controls.Add(this.Game_File_Path_Label);
            this.Settings_GroupBox.Controls.Add(this.Settings_Send_To_Tray_CheckBox);
            this.Settings_GroupBox.Location = new System.Drawing.Point(8, 3);
            this.Settings_GroupBox.Name = "Settings_GroupBox";
            this.Settings_GroupBox.Size = new System.Drawing.Size(534, 229);
            this.Settings_GroupBox.TabIndex = 22;
            this.Settings_GroupBox.TabStop = false;
            this.Settings_GroupBox.Text = "Settings";
            // 
            // Settings_Skip_Profiles_CheckBox
            // 
            this.Settings_Skip_Profiles_CheckBox.AutoSize = true;
            this.Settings_Skip_Profiles_CheckBox.Location = new System.Drawing.Point(6, 111);
            this.Settings_Skip_Profiles_CheckBox.Name = "Settings_Skip_Profiles_CheckBox";
            this.Settings_Skip_Profiles_CheckBox.Size = new System.Drawing.Size(126, 17);
            this.Settings_Skip_Profiles_CheckBox.TabIndex = 36;
            this.Settings_Skip_Profiles_CheckBox.Text = "Skip Profile Selection";
            this.Settings_Skip_Profiles_CheckBox.UseVisualStyleBackColor = true;
            this.Settings_Skip_Profiles_CheckBox.CheckedChanged += new System.EventHandler(this.Skip_profiles_CheckedChanged);
            // 
            // Browse_Game_File_Path_Button
            // 
            this.Browse_Game_File_Path_Button.Location = new System.Drawing.Point(325, 200);
            this.Browse_Game_File_Path_Button.Name = "Browse_Game_File_Path_Button";
            this.Browse_Game_File_Path_Button.Size = new System.Drawing.Size(70, 23);
            this.Browse_Game_File_Path_Button.TabIndex = 35;
            this.Browse_Game_File_Path_Button.Text = "Browse";
            this.Browse_Game_File_Path_Button.UseVisualStyleBackColor = true;
            this.Browse_Game_File_Path_Button.Click += new System.EventHandler(this.Browse_Click);
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
            this.anon_data_2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Anon_data_2_LinkClicked);
            // 
            // Settings_Allow_Anon_Data_CheckBox
            // 
            this.Settings_Allow_Anon_Data_CheckBox.AutoSize = true;
            this.Settings_Allow_Anon_Data_CheckBox.Checked = true;
            this.Settings_Allow_Anon_Data_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Settings_Allow_Anon_Data_CheckBox.Location = new System.Drawing.Point(6, 134);
            this.Settings_Allow_Anon_Data_CheckBox.Name = "Settings_Allow_Anon_Data_CheckBox";
            this.Settings_Allow_Anon_Data_CheckBox.Size = new System.Drawing.Size(188, 17);
            this.Settings_Allow_Anon_Data_CheckBox.TabIndex = 32;
            this.Settings_Allow_Anon_Data_CheckBox.Text = "Send Anonymous Usage Statistics";
            this.Settings_Allow_Anon_Data_CheckBox.UseVisualStyleBackColor = true;
            this.Settings_Allow_Anon_Data_CheckBox.CheckedChanged += new System.EventHandler(this.Anon_data_CheckedChanged);
            // 
            // Settings_Clean_Exit_CheckBox
            // 
            this.Settings_Clean_Exit_CheckBox.AutoSize = true;
            this.Settings_Clean_Exit_CheckBox.Checked = true;
            this.Settings_Clean_Exit_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Settings_Clean_Exit_CheckBox.Location = new System.Drawing.Point(6, 88);
            this.Settings_Clean_Exit_CheckBox.Name = "Settings_Clean_Exit_CheckBox";
            this.Settings_Clean_Exit_CheckBox.Size = new System.Drawing.Size(73, 17);
            this.Settings_Clean_Exit_CheckBox.TabIndex = 31;
            this.Settings_Clean_Exit_CheckBox.Text = "Clean Exit";
            this.Settings_Clean_Exit_CheckBox.UseVisualStyleBackColor = true;
            this.Settings_Clean_Exit_CheckBox.CheckedChanged += new System.EventHandler(this.Cleanexit_CheckedChanged);
            // 
            // Settings_Show_IPS_CheckBox
            // 
            this.Settings_Show_IPS_CheckBox.AutoSize = true;
            this.Settings_Show_IPS_CheckBox.Location = new System.Drawing.Point(6, 65);
            this.Settings_Show_IPS_CheckBox.Name = "Settings_Show_IPS_CheckBox";
            this.Settings_Show_IPS_CheckBox.Size = new System.Drawing.Size(73, 17);
            this.Settings_Show_IPS_CheckBox.TabIndex = 30;
            this.Settings_Show_IPS_CheckBox.Text = "Show IP\'s";
            this.Settings_Show_IPS_CheckBox.UseVisualStyleBackColor = true;
            this.Settings_Show_IPS_CheckBox.CheckedChanged += new System.EventHandler(this.Show_IP_CheckedChanged);
            // 
            // Auto_Detect_Game_File_Path_Button
            // 
            this.Auto_Detect_Game_File_Path_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Auto_Detect_Game_File_Path_Button.Location = new System.Drawing.Point(6, 200);
            this.Auto_Detect_Game_File_Path_Button.Name = "Auto_Detect_Game_File_Path_Button";
            this.Auto_Detect_Game_File_Path_Button.Size = new System.Drawing.Size(207, 23);
            this.Auto_Detect_Game_File_Path_Button.TabIndex = 29;
            this.Auto_Detect_Game_File_Path_Button.Text = "Auto Detect";
            this.Auto_Detect_Game_File_Path_Button.UseVisualStyleBackColor = true;
            this.Auto_Detect_Game_File_Path_Button.Click += new System.EventHandler(this.Steamsearch_Click);
            // 
            // Settings_Always_On_Top_CheckBox
            // 
            this.Settings_Always_On_Top_CheckBox.AutoSize = true;
            this.Settings_Always_On_Top_CheckBox.Location = new System.Drawing.Point(6, 42);
            this.Settings_Always_On_Top_CheckBox.Name = "Settings_Always_On_Top_CheckBox";
            this.Settings_Always_On_Top_CheckBox.Size = new System.Drawing.Size(98, 17);
            this.Settings_Always_On_Top_CheckBox.TabIndex = 26;
            this.Settings_Always_On_Top_CheckBox.Text = "Always On Top";
            this.Settings_Always_On_Top_CheckBox.UseVisualStyleBackColor = true;
            this.Settings_Always_On_Top_CheckBox.CheckedChanged += new System.EventHandler(this.Always_on_top_CheckedChanged);
            // 
            // Change_Game_File_Path_Button
            // 
            this.Change_Game_File_Path_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Change_Game_File_Path_Button.Location = new System.Drawing.Point(219, 200);
            this.Change_Game_File_Path_Button.Name = "Change_Game_File_Path_Button";
            this.Change_Game_File_Path_Button.Size = new System.Drawing.Size(100, 23);
            this.Change_Game_File_Path_Button.TabIndex = 24;
            this.Change_Game_File_Path_Button.Text = "Change Path";
            this.Change_Game_File_Path_Button.UseVisualStyleBackColor = true;
            this.Change_Game_File_Path_Button.Click += new System.EventHandler(this.Chpath_Click);
            // 
            // Game_File_Path_Label
            // 
            this.Game_File_Path_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Game_File_Path_Label.AutoSize = true;
            this.Game_File_Path_Label.Location = new System.Drawing.Point(5, 184);
            this.Game_File_Path_Label.Name = "Game_File_Path_Label";
            this.Game_File_Path_Label.Size = new System.Drawing.Size(85, 13);
            this.Game_File_Path_Label.TabIndex = 23;
            this.Game_File_Path_Label.Text = "Game File Path: ";
            // 
            // Settings_Send_To_Tray_CheckBox
            // 
            this.Settings_Send_To_Tray_CheckBox.AutoSize = true;
            this.Settings_Send_To_Tray_CheckBox.Location = new System.Drawing.Point(6, 19);
            this.Settings_Send_To_Tray_CheckBox.Name = "Settings_Send_To_Tray_CheckBox";
            this.Settings_Send_To_Tray_CheckBox.Size = new System.Drawing.Size(106, 17);
            this.Settings_Send_To_Tray_CheckBox.TabIndex = 21;
            this.Settings_Send_To_Tray_CheckBox.Text = "Minimize To Tray";
            this.Settings_Send_To_Tray_CheckBox.UseVisualStyleBackColor = true;
            this.Settings_Send_To_Tray_CheckBox.CheckedChanged += new System.EventHandler(this.To_tray_CheckedChanged);
            // 
            // About_Button
            // 
            this.About_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.About_Button.Location = new System.Drawing.Point(658, 649);
            this.About_Button.Name = "About_Button";
            this.About_Button.Size = new System.Drawing.Size(243, 23);
            this.About_Button.TabIndex = 12;
            this.About_Button.Text = "About...";
            this.About_Button.UseVisualStyleBackColor = true;
            this.About_Button.Click += new System.EventHandler(this.Telnet_Click);
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
            this.backup_location.TextChanged += new System.EventHandler(this.Backup_location_TextChanged);
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
            this.backup_chat.CheckedChanged += new System.EventHandler(this.Backup_chat_CheckedChanged);
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
            this.auto_backup_check.CheckedChanged += new System.EventHandler(this.Auto_backup_check_CheckedChanged);
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
            this.backup_time.Scroll += new System.EventHandler(this.Backup_time_Scroll);
            // 
            // Spawn_GroupBox
            // 
            this.Spawn_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Spawn_GroupBox.Controls.Add(this.Spawn_Item_Button);
            this.Spawn_GroupBox.Controls.Add(this.Spawn_Item_ComboBox);
            this.Spawn_GroupBox.Location = new System.Drawing.Point(309, 414);
            this.Spawn_GroupBox.Name = "Spawn_GroupBox";
            this.Spawn_GroupBox.Size = new System.Drawing.Size(592, 48);
            this.Spawn_GroupBox.TabIndex = 21;
            this.Spawn_GroupBox.TabStop = false;
            this.Spawn_GroupBox.Text = "Spawn items";
            // 
            // Spawn_Item_Button
            // 
            this.Spawn_Item_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Spawn_Item_Button.Location = new System.Drawing.Point(465, 19);
            this.Spawn_Item_Button.Name = "Spawn_Item_Button";
            this.Spawn_Item_Button.Size = new System.Drawing.Size(121, 21);
            this.Spawn_Item_Button.TabIndex = 3;
            this.Spawn_Item_Button.Text = "Spawn";
            this.Spawn_Item_Button.UseVisualStyleBackColor = true;
            this.Spawn_Item_Button.Click += new System.EventHandler(this.Spawn_now_Click);
            // 
            // Spawn_Item_ComboBox
            // 
            this.Spawn_Item_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Spawn_Item_ComboBox.FormattingEnabled = true;
            this.Spawn_Item_ComboBox.Items.AddRange(new object[] {
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
            this.Spawn_Item_ComboBox.Location = new System.Drawing.Point(6, 19);
            this.Spawn_Item_ComboBox.Name = "Spawn_Item_ComboBox";
            this.Spawn_Item_ComboBox.Size = new System.Drawing.Size(151, 21);
            this.Spawn_Item_ComboBox.TabIndex = 0;
            // 
            // Game_Time_Controls_GroupBox
            // 
            this.Game_Time_Controls_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Game_Time_Controls_GroupBox.Controls.Add(this.godzina);
            this.Game_Time_Controls_GroupBox.Controls.Add(this.dzien);
            this.Game_Time_Controls_GroupBox.Controls.Add(this.Set_Game_Time_Button);
            this.Game_Time_Controls_GroupBox.Controls.Add(this.Game_Day_TrackBar);
            this.Game_Time_Controls_GroupBox.Controls.Add(this.Game_Hour_TrackBar);
            this.Game_Time_Controls_GroupBox.Location = new System.Drawing.Point(309, 517);
            this.Game_Time_Controls_GroupBox.Name = "Game_Time_Controls_GroupBox";
            this.Game_Time_Controls_GroupBox.Size = new System.Drawing.Size(592, 140);
            this.Game_Time_Controls_GroupBox.TabIndex = 19;
            this.Game_Time_Controls_GroupBox.TabStop = false;
            this.Game_Time_Controls_GroupBox.Text = "Game Time Controls";
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
            // Set_Game_Time_Button
            // 
            this.Set_Game_Time_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Set_Game_Time_Button.Location = new System.Drawing.Point(465, 113);
            this.Set_Game_Time_Button.Name = "Set_Game_Time_Button";
            this.Set_Game_Time_Button.Size = new System.Drawing.Size(121, 21);
            this.Set_Game_Time_Button.TabIndex = 0;
            this.Set_Game_Time_Button.Text = "Set";
            this.Set_Game_Time_Button.UseVisualStyleBackColor = true;
            this.Set_Game_Time_Button.Click += new System.EventHandler(this.Telnet_connect_Click);
            // 
            // Game_Day_TrackBar
            // 
            this.Game_Day_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Game_Day_TrackBar.Location = new System.Drawing.Point(6, 34);
            this.Game_Day_TrackBar.Maximum = 365;
            this.Game_Day_TrackBar.Minimum = 1;
            this.Game_Day_TrackBar.Name = "Game_Day_TrackBar";
            this.Game_Day_TrackBar.Size = new System.Drawing.Size(580, 45);
            this.Game_Day_TrackBar.TabIndex = 1;
            this.Game_Day_TrackBar.Value = 1;
            this.Game_Day_TrackBar.Scroll += new System.EventHandler(this.Dzien_bar_Scroll);
            // 
            // Game_Hour_TrackBar
            // 
            this.Game_Hour_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Game_Hour_TrackBar.Location = new System.Drawing.Point(6, 82);
            this.Game_Hour_TrackBar.Maximum = 23;
            this.Game_Hour_TrackBar.Name = "Game_Hour_TrackBar";
            this.Game_Hour_TrackBar.Size = new System.Drawing.Size(580, 45);
            this.Game_Hour_TrackBar.TabIndex = 3;
            this.Game_Hour_TrackBar.Value = 8;
            this.Game_Hour_TrackBar.Scroll += new System.EventHandler(this.Godzina_bar_Scroll);
            // 
            // cmd
            // 
            this.cmd.AcceptsReturn = true;
            this.cmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd.Location = new System.Drawing.Point(6, 468);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(689, 20);
            this.cmd.TabIndex = 17;
            this.cmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmd_KeyPress);
            // 
            // Console_RichTextBox
            // 
            this.Console_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Console_RichTextBox.BackColor = System.Drawing.Color.Black;
            this.Console_RichTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Console_RichTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Console_RichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Console_RichTextBox.Location = new System.Drawing.Point(6, 19);
            this.Console_RichTextBox.Name = "Console_RichTextBox";
            this.Console_RichTextBox.ReadOnly = true;
            this.Console_RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.Console_RichTextBox.Size = new System.Drawing.Size(686, 448);
            this.Console_RichTextBox.TabIndex = 15;
            this.Console_RichTextBox.Text = "";
            this.Console_RichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.Konsola_LinkClicked);
            this.Console_RichTextBox.TextChanged += new System.EventHandler(this.Console_TextChanged);
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
            this.tabControl.Controls.Add(this.ManageServer_TabPage);
            this.tabControl.Controls.Add(this.PlayerManagement_TabPage);
            this.tabControl.Controls.Add(this.GameSettings_TabPage);
            this.tabControl.Controls.Add(this.Messaging_TabPage);
            this.tabControl.Controls.Add(this.Mods_TabPage);
            this.tabControl.Controls.Add(this.GlobalBanList_TabPage);
            this.tabControl.Controls.Add(this.WebServer_TabPage);
            this.tabControl.Controls.Add(this.ServerTasks_TabPage);
            this.tabControl.Controls.Add(this.Backups_TabPage);
            this.tabControl.Controls.Add(this.Rewards_TabPage);
            this.tabControl.Controls.Add(this.Settings_TabPage);
            this.tabControl.ImageList = this.Header_Icons;
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
            // ManageServer_TabPage
            // 
            this.ManageServer_TabPage.BackColor = System.Drawing.SystemColors.Control;
            this.ManageServer_TabPage.Controls.Add(this.CommandsGroup);
            this.ManageServer_TabPage.Controls.Add(this.zoomup);
            this.ManageServer_TabPage.Controls.Add(this.overviewSplitter);
            this.ManageServer_TabPage.Controls.Add(this.Timers_Group);
            this.ManageServer_TabPage.Controls.Add(this.Server_Controls_Group);
            this.ManageServer_TabPage.Controls.Add(this.startbar);
            this.ManageServer_TabPage.ImageIndex = 0;
            this.ManageServer_TabPage.Location = new System.Drawing.Point(47, 4);
            this.ManageServer_TabPage.Name = "ManageServer_TabPage";
            this.ManageServer_TabPage.Size = new System.Drawing.Size(908, 684);
            this.ManageServer_TabPage.TabIndex = 7;
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
            this.usecmd.Click += new System.EventHandler(this.Usecmd_Click);
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
            this.zoomup.Click += new System.EventHandler(this.Zoomup_Click);
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
            this.News_Feed_RichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.Newsbox_LinkClicked);
            this.News_Feed_RichTextBox.TextChanged += new System.EventHandler(this.News_Feed_RichTextBox_TextChanged);
            // 
            // Server_Status_Group
            // 
            this.Server_Status_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Server_Status_Group.Controls.Add(this.Private_IP_Address_Label);
            this.Server_Status_Group.Controls.Add(this.OS_Architecture_Label);
            this.Server_Status_Group.Controls.Add(this.telnetstatus);
            this.Server_Status_Group.Controls.Add(this.OS_Version_Label);
            this.Server_Status_Group.Controls.Add(this.status);
            this.Server_Status_Group.Controls.Add(this.Public_IP_Address_Label);
            this.Server_Status_Group.Location = new System.Drawing.Point(3, 8);
            this.Server_Status_Group.Name = "Server_Status_Group";
            this.Server_Status_Group.Size = new System.Drawing.Size(340, 160);
            this.Server_Status_Group.TabIndex = 20;
            this.Server_Status_Group.TabStop = false;
            this.Server_Status_Group.Text = "Server status";
            // 
            // OS_Architecture_Label
            // 
            this.OS_Architecture_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OS_Architecture_Label.AutoSize = true;
            this.OS_Architecture_Label.BackColor = System.Drawing.Color.Transparent;
            this.OS_Architecture_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OS_Architecture_Label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OS_Architecture_Label.Location = new System.Drawing.Point(6, 140);
            this.OS_Architecture_Label.Name = "OS_Architecture_Label";
            this.OS_Architecture_Label.Size = new System.Drawing.Size(82, 13);
            this.OS_Architecture_Label.TabIndex = 5;
            this.OS_Architecture_Label.Text = "OS Architecture";
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
            // OS_Version_Label
            // 
            this.OS_Version_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OS_Version_Label.AutoSize = true;
            this.OS_Version_Label.BackColor = System.Drawing.Color.Transparent;
            this.OS_Version_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OS_Version_Label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OS_Version_Label.Location = new System.Drawing.Point(6, 120);
            this.OS_Version_Label.Name = "OS_Version_Label";
            this.OS_Version_Label.Size = new System.Drawing.Size(60, 13);
            this.OS_Version_Label.TabIndex = 3;
            this.OS_Version_Label.Text = "OS Version";
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
            this.Console_Group.Controls.Add(this.Console_RichTextBox);
            this.Console_Group.Controls.Add(this.cmd);
            this.Console_Group.Location = new System.Drawing.Point(3, 8);
            this.Console_Group.Name = "Console_Group";
            this.Console_Group.Size = new System.Drawing.Size(698, 499);
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
            this.Start_7DSM_With_Windows_CheckBox.CheckedChanged += new System.EventHandler(this.Start_with_win_CheckedChanged);
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
            this.Start_With_7DSM_CheckBox.CheckedChanged += new System.EventHandler(this.Start_with_7dsm_CheckedChanged);
            // 
            // Start_Server_Button
            // 
            this.Start_Server_Button.Location = new System.Drawing.Point(6, 17);
            this.Start_Server_Button.Name = "Start_Server_Button";
            this.Start_Server_Button.Size = new System.Drawing.Size(152, 23);
            this.Start_Server_Button.TabIndex = 4;
            this.Start_Server_Button.Text = "Start Server";
            this.Start_Server_Button.UseVisualStyleBackColor = true;
            this.Start_Server_Button.Click += new System.EventHandler(this.Start_Server_Button_Click);
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
            this.Save_Logs_CheckBox.CheckedChanged += new System.EventHandler(this.Save_logfiles_2_CheckedChanged);
            // 
            // Kill_Server_Process
            // 
            this.Kill_Server_Process.Location = new System.Drawing.Point(76, 104);
            this.Kill_Server_Process.Name = "Kill_Server_Process";
            this.Kill_Server_Process.Size = new System.Drawing.Size(82, 24);
            this.Kill_Server_Process.TabIndex = 6;
            this.Kill_Server_Process.Text = "Kill Process";
            this.Kill_Server_Process.UseVisualStyleBackColor = true;
            this.Kill_Server_Process.Click += new System.EventHandler(this.Kill_proccess_Click);
            // 
            // PlayerManagement_TabPage
            // 
            this.PlayerManagement_TabPage.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerManagement_TabPage.Controls.Add(this.Chat_GroupBox);
            this.PlayerManagement_TabPage.Controls.Add(this.All_Players_Label);
            this.PlayerManagement_TabPage.Controls.Add(this.Online_Players_Label);
            this.PlayerManagement_TabPage.Controls.Add(this.All_Players_List);
            this.PlayerManagement_TabPage.Controls.Add(this.Player_GroupBox);
            this.PlayerManagement_TabPage.Controls.Add(this.Game_Time_Controls_GroupBox);
            this.PlayerManagement_TabPage.Controls.Add(this.Kick_GroupBox);
            this.PlayerManagement_TabPage.Controls.Add(this.Spawn_GroupBox);
            this.PlayerManagement_TabPage.Controls.Add(this.Ban_GroupBox);
            this.PlayerManagement_TabPage.Controls.Add(this.Online_Player_List);
            this.PlayerManagement_TabPage.ImageIndex = 2;
            this.PlayerManagement_TabPage.Location = new System.Drawing.Point(47, 4);
            this.PlayerManagement_TabPage.Name = "PlayerManagement_TabPage";
            this.PlayerManagement_TabPage.Size = new System.Drawing.Size(908, 684);
            this.PlayerManagement_TabPage.TabIndex = 5;
            // 
            // Chat_GroupBox
            // 
            this.Chat_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chat_GroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.Chat_GroupBox.Controls.Add(this.Chat_RichTextBox);
            this.Chat_GroupBox.Controls.Add(this.Chat_Input_TextBox);
            this.Chat_GroupBox.Location = new System.Drawing.Point(309, 8);
            this.Chat_GroupBox.Name = "Chat_GroupBox";
            this.Chat_GroupBox.Size = new System.Drawing.Size(592, 253);
            this.Chat_GroupBox.TabIndex = 26;
            this.Chat_GroupBox.TabStop = false;
            this.Chat_GroupBox.Text = "Chat";
            // 
            // Chat_RichTextBox
            // 
            this.Chat_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chat_RichTextBox.BackColor = System.Drawing.Color.Black;
            this.Chat_RichTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Chat_RichTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Chat_RichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Chat_RichTextBox.Location = new System.Drawing.Point(6, 19);
            this.Chat_RichTextBox.Name = "Chat_RichTextBox";
            this.Chat_RichTextBox.ReadOnly = true;
            this.Chat_RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.Chat_RichTextBox.Size = new System.Drawing.Size(581, 202);
            this.Chat_RichTextBox.TabIndex = 15;
            this.Chat_RichTextBox.Text = "";
            this.Chat_RichTextBox.TextChanged += new System.EventHandler(this.Chat_TextChanged);
            // 
            // Chat_Input_TextBox
            // 
            this.Chat_Input_TextBox.AcceptsReturn = true;
            this.Chat_Input_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chat_Input_TextBox.Location = new System.Drawing.Point(6, 227);
            this.Chat_Input_TextBox.Name = "Chat_Input_TextBox";
            this.Chat_Input_TextBox.Size = new System.Drawing.Size(580, 20);
            this.Chat_Input_TextBox.TabIndex = 17;
            this.Chat_Input_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chat_text_KeyPress);
            // 
            // All_Players_Label
            // 
            this.All_Players_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.All_Players_Label.AutoSize = true;
            this.All_Players_Label.Location = new System.Drawing.Point(5, 343);
            this.All_Players_Label.Name = "All_Players_Label";
            this.All_Players_Label.Size = new System.Drawing.Size(57, 13);
            this.All_Players_Label.TabIndex = 25;
            this.All_Players_Label.Text = "All players:";
            // 
            // Online_Players_Label
            // 
            this.Online_Players_Label.AutoSize = true;
            this.Online_Players_Label.Location = new System.Drawing.Point(5, 11);
            this.Online_Players_Label.Name = "Online_Players_Label";
            this.Online_Players_Label.Size = new System.Drawing.Size(76, 13);
            this.Online_Players_Label.TabIndex = 24;
            this.Online_Players_Label.Text = "Online players:";
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
            this.All_Players_List.SelectedIndexChanged += new System.EventHandler(this.All_players_list_SelectedIndexChanged);
            this.All_Players_List.Click += new System.EventHandler(this.All_players_list_Click);
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
            // Player_GroupBox
            // 
            this.Player_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player_GroupBox.Controls.Add(this.Thirsty_Player_Button);
            this.Player_GroupBox.Controls.Add(this.Starve_Player_Button);
            this.Player_GroupBox.Controls.Add(this.Kill_Player_Button);
            this.Player_GroupBox.Location = new System.Drawing.Point(309, 468);
            this.Player_GroupBox.Name = "Player_GroupBox";
            this.Player_GroupBox.Size = new System.Drawing.Size(592, 43);
            this.Player_GroupBox.TabIndex = 22;
            this.Player_GroupBox.TabStop = false;
            this.Player_GroupBox.Text = "Player";
            // 
            // Thirsty_Player_Button
            // 
            this.Thirsty_Player_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Thirsty_Player_Button.Location = new System.Drawing.Point(465, 19);
            this.Thirsty_Player_Button.Name = "Thirsty_Player_Button";
            this.Thirsty_Player_Button.Size = new System.Drawing.Size(121, 21);
            this.Thirsty_Player_Button.TabIndex = 5;
            this.Thirsty_Player_Button.Text = "Thirsty";
            this.Thirsty_Player_Button.UseVisualStyleBackColor = true;
            this.Thirsty_Player_Button.Click += new System.EventHandler(this.Thirsty_Player_Click);
            // 
            // Starve_Player_Button
            // 
            this.Starve_Player_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Starve_Player_Button.Location = new System.Drawing.Point(235, 19);
            this.Starve_Player_Button.Name = "Starve_Player_Button";
            this.Starve_Player_Button.Size = new System.Drawing.Size(121, 21);
            this.Starve_Player_Button.TabIndex = 4;
            this.Starve_Player_Button.Text = "Starve";
            this.Starve_Player_Button.UseVisualStyleBackColor = true;
            this.Starve_Player_Button.Click += new System.EventHandler(this.Starve_Player_Click);
            // 
            // Kill_Player_Button
            // 
            this.Kill_Player_Button.Location = new System.Drawing.Point(6, 19);
            this.Kill_Player_Button.Name = "Kill_Player_Button";
            this.Kill_Player_Button.Size = new System.Drawing.Size(121, 21);
            this.Kill_Player_Button.TabIndex = 3;
            this.Kill_Player_Button.Text = "Kill";
            this.Kill_Player_Button.UseVisualStyleBackColor = true;
            this.Kill_Player_Button.Click += new System.EventHandler(this.Kill_Player_Click);
            // 
            // Kick_GroupBox
            // 
            this.Kick_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Kick_GroupBox.Controls.Add(this.Kick_Player_Button);
            this.Kick_GroupBox.Controls.Add(this.Kick_Reason_ComboBox);
            this.Kick_GroupBox.Location = new System.Drawing.Point(309, 359);
            this.Kick_GroupBox.Name = "Kick_GroupBox";
            this.Kick_GroupBox.Size = new System.Drawing.Size(592, 49);
            this.Kick_GroupBox.TabIndex = 10;
            this.Kick_GroupBox.TabStop = false;
            this.Kick_GroupBox.Text = "KICK";
            // 
            // Kick_Player_Button
            // 
            this.Kick_Player_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Kick_Player_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Kick_Player_Button.Location = new System.Drawing.Point(465, 21);
            this.Kick_Player_Button.Name = "Kick_Player_Button";
            this.Kick_Player_Button.Size = new System.Drawing.Size(121, 21);
            this.Kick_Player_Button.TabIndex = 5;
            this.Kick_Player_Button.Text = "KICK";
            this.Kick_Player_Button.UseVisualStyleBackColor = false;
            this.Kick_Player_Button.Click += new System.EventHandler(this.Kick_Click);
            // 
            // Kick_Reason_ComboBox
            // 
            this.Kick_Reason_ComboBox.FormattingEnabled = true;
            this.Kick_Reason_ComboBox.Items.AddRange(new object[] {
            "SPAMING",
            "Cheating",
            "Griefing",
            "Swearing",
            "Amazingly_stupid"});
            this.Kick_Reason_ComboBox.Location = new System.Drawing.Point(6, 21);
            this.Kick_Reason_ComboBox.Name = "Kick_Reason_ComboBox";
            this.Kick_Reason_ComboBox.Size = new System.Drawing.Size(151, 21);
            this.Kick_Reason_ComboBox.TabIndex = 7;
            // 
            // Ban_GroupBox
            // 
            this.Ban_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ban_GroupBox.Controls.Add(this.Ban_Time_ComboBox);
            this.Ban_GroupBox.Controls.Add(this.Ban_Hammer_Button);
            this.Ban_GroupBox.Controls.Add(this.Ban_Slider_TrackBar);
            this.Ban_GroupBox.Location = new System.Drawing.Point(309, 267);
            this.Ban_GroupBox.Name = "Ban_GroupBox";
            this.Ban_GroupBox.Size = new System.Drawing.Size(592, 86);
            this.Ban_GroupBox.TabIndex = 9;
            this.Ban_GroupBox.TabStop = false;
            this.Ban_GroupBox.Text = "BAN";
            // 
            // Ban_Time_ComboBox
            // 
            this.Ban_Time_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ban_Time_ComboBox.FormattingEnabled = true;
            this.Ban_Time_ComboBox.Items.AddRange(new object[] {
            "minutes",
            "hours",
            "days",
            "weeks",
            "months",
            "years"});
            this.Ban_Time_ComboBox.Location = new System.Drawing.Point(6, 55);
            this.Ban_Time_ComboBox.Name = "Ban_Time_ComboBox";
            this.Ban_Time_ComboBox.Size = new System.Drawing.Size(151, 21);
            this.Ban_Time_ComboBox.TabIndex = 8;
            // 
            // Ban_Hammer_Button
            // 
            this.Ban_Hammer_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ban_Hammer_Button.BackColor = System.Drawing.Color.LightCoral;
            this.Ban_Hammer_Button.Location = new System.Drawing.Point(465, 54);
            this.Ban_Hammer_Button.Name = "Ban_Hammer_Button";
            this.Ban_Hammer_Button.Size = new System.Drawing.Size(121, 21);
            this.Ban_Hammer_Button.TabIndex = 4;
            this.Ban_Hammer_Button.Text = "BAN";
            this.Ban_Hammer_Button.UseVisualStyleBackColor = false;
            this.Ban_Hammer_Button.Click += new System.EventHandler(this.Ban_Click);
            // 
            // Ban_Slider_TrackBar
            // 
            this.Ban_Slider_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ban_Slider_TrackBar.Location = new System.Drawing.Point(6, 19);
            this.Ban_Slider_TrackBar.Maximum = 60;
            this.Ban_Slider_TrackBar.Minimum = 1;
            this.Ban_Slider_TrackBar.Name = "Ban_Slider_TrackBar";
            this.Ban_Slider_TrackBar.Size = new System.Drawing.Size(580, 45);
            this.Ban_Slider_TrackBar.TabIndex = 9;
            this.Ban_Slider_TrackBar.Value = 1;
            this.Ban_Slider_TrackBar.Scroll += new System.EventHandler(this.TrackBar1_Scroll_1);
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
            this.Online_Player_List.SelectedIndexChanged += new System.EventHandler(this.Players_list_SelectedIndexChanged);
            this.Online_Player_List.Click += new System.EventHandler(this.Players_list_Click);
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
            // GameSettings_TabPage
            // 
            this.GameSettings_TabPage.BackColor = System.Drawing.SystemColors.Control;
            this.GameSettings_TabPage.Controls.Add(this.main_page_opts);
            this.GameSettings_TabPage.ImageIndex = 1;
            this.GameSettings_TabPage.Location = new System.Drawing.Point(47, 4);
            this.GameSettings_TabPage.Name = "GameSettings_TabPage";
            this.GameSettings_TabPage.Size = new System.Drawing.Size(908, 684);
            this.GameSettings_TabPage.TabIndex = 11;
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
            this.main_page_opts.ImageList = this.Header_Icons;
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
            this.game_opts.Controls.Add(this.Drop_On_Quit_GroupBox);
            this.game_opts.Controls.Add(this.Server_Reserved_Slots_GroupBox);
            this.game_opts.Controls.Add(this.Player_Killing_Mode_GroupBox);
            this.game_opts.Controls.Add(this.Spawn_Settings_GroupBox);
            this.game_opts.Controls.Add(this.Air_Drop_Frequency_GroupBox);
            this.game_opts.Controls.Add(this.Land_Claim_GroupBox);
            this.game_opts.Controls.Add(this.Loot_Respawn_Days_GroupBox);
            this.game_opts.Controls.Add(this.Loot_Abundance_GroupBox);
            this.game_opts.Controls.Add(this.Max_Players_GroupBox);
            this.game_opts.Controls.Add(this.Game_Mode_Settings_GroupBox);
            this.game_opts.Controls.Add(this.Zombie_Settings_GroupBox);
            this.game_opts.Controls.Add(this.nightpercentage_g);
            this.game_opts.Controls.Add(this.Day_Length_GroupBox);
            this.game_opts.Controls.Add(this.bdm_g);
            this.game_opts.Controls.Add(this.Drop_On_Death_Group_Box);
            this.game_opts.Controls.Add(this.Game_Difficulty_GroupBox);
            this.game_opts.ImageIndex = 5;
            this.game_opts.Location = new System.Drawing.Point(4, 50);
            this.game_opts.Name = "game_opts";
            this.game_opts.Size = new System.Drawing.Size(897, 630);
            this.game_opts.TabIndex = 2;
            this.game_opts.UseVisualStyleBackColor = true;
            // 
            // Drop_On_Quit_GroupBox
            // 
            this.Drop_On_Quit_GroupBox.Controls.Add(this.Drop_On_Quit_Mode_0);
            this.Drop_On_Quit_GroupBox.Controls.Add(this.Drop_On_Quit_Mode_1);
            this.Drop_On_Quit_GroupBox.Controls.Add(this.Drop_On_Quit_Mode_3);
            this.Drop_On_Quit_GroupBox.Controls.Add(this.Drop_On_Quit_Mode_2);
            this.Drop_On_Quit_GroupBox.Location = new System.Drawing.Point(616, 217);
            this.Drop_On_Quit_GroupBox.Name = "Drop_On_Quit_GroupBox";
            this.Drop_On_Quit_GroupBox.Size = new System.Drawing.Size(86, 112);
            this.Drop_On_Quit_GroupBox.TabIndex = 52;
            this.Drop_On_Quit_GroupBox.TabStop = false;
            this.Drop_On_Quit_GroupBox.Text = "Drop On Quit";
            // 
            // Drop_On_Quit_Mode_0
            // 
            this.Drop_On_Quit_Mode_0.AutoSize = true;
            this.Drop_On_Quit_Mode_0.Checked = true;
            this.Drop_On_Quit_Mode_0.Location = new System.Drawing.Point(8, 18);
            this.Drop_On_Quit_Mode_0.Name = "Drop_On_Quit_Mode_0";
            this.Drop_On_Quit_Mode_0.Size = new System.Drawing.Size(62, 17);
            this.Drop_On_Quit_Mode_0.TabIndex = 28;
            this.Drop_On_Quit_Mode_0.TabStop = true;
            this.Drop_On_Quit_Mode_0.Text = "Nothing";
            this.Drop_On_Quit_Mode_0.UseVisualStyleBackColor = true;
            this.Drop_On_Quit_Mode_0.CheckedChanged += new System.EventHandler(this.Doq_0_CheckedChanged);
            // 
            // Drop_On_Quit_Mode_1
            // 
            this.Drop_On_Quit_Mode_1.AutoSize = true;
            this.Drop_On_Quit_Mode_1.Location = new System.Drawing.Point(8, 41);
            this.Drop_On_Quit_Mode_1.Name = "Drop_On_Quit_Mode_1";
            this.Drop_On_Quit_Mode_1.Size = new System.Drawing.Size(75, 17);
            this.Drop_On_Quit_Mode_1.TabIndex = 29;
            this.Drop_On_Quit_Mode_1.Text = "Everything";
            this.Drop_On_Quit_Mode_1.UseVisualStyleBackColor = true;
            this.Drop_On_Quit_Mode_1.CheckedChanged += new System.EventHandler(this.Doq_1_CheckedChanged);
            // 
            // Drop_On_Quit_Mode_3
            // 
            this.Drop_On_Quit_Mode_3.AutoSize = true;
            this.Drop_On_Quit_Mode_3.Location = new System.Drawing.Point(8, 87);
            this.Drop_On_Quit_Mode_3.Name = "Drop_On_Quit_Mode_3";
            this.Drop_On_Quit_Mode_3.Size = new System.Drawing.Size(74, 17);
            this.Drop_On_Quit_Mode_3.TabIndex = 31;
            this.Drop_On_Quit_Mode_3.Text = "Backpack";
            this.Drop_On_Quit_Mode_3.UseVisualStyleBackColor = true;
            this.Drop_On_Quit_Mode_3.CheckedChanged += new System.EventHandler(this.Doq_3_CheckedChanged);
            // 
            // Drop_On_Quit_Mode_2
            // 
            this.Drop_On_Quit_Mode_2.AutoSize = true;
            this.Drop_On_Quit_Mode_2.Location = new System.Drawing.Point(8, 64);
            this.Drop_On_Quit_Mode_2.Name = "Drop_On_Quit_Mode_2";
            this.Drop_On_Quit_Mode_2.Size = new System.Drawing.Size(63, 17);
            this.Drop_On_Quit_Mode_2.TabIndex = 30;
            this.Drop_On_Quit_Mode_2.Text = "Toolbelt";
            this.Drop_On_Quit_Mode_2.UseVisualStyleBackColor = true;
            this.Drop_On_Quit_Mode_2.CheckedChanged += new System.EventHandler(this.Doq_2_CheckedChanged);
            // 
            // Server_Reserved_Slots_GroupBox
            // 
            this.Server_Reserved_Slots_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.Server_Admin_Reserved_Slots_Permission);
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.Admin_Slot_Text_Label);
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.Admin_Reserve_Text_Label);
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.Server_Admin_Reserved_Slots);
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.Server_Player_Reserved_Slots_Permission);
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.Player_Slot_Text_Label);
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.Player_Reserve_Text_Label);
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.Server_Player_Reserved_Slots);
            this.Server_Reserved_Slots_GroupBox.Location = new System.Drawing.Point(524, 4);
            this.Server_Reserved_Slots_GroupBox.Name = "Server_Reserved_Slots_GroupBox";
            this.Server_Reserved_Slots_GroupBox.Size = new System.Drawing.Size(366, 65);
            this.Server_Reserved_Slots_GroupBox.TabIndex = 51;
            this.Server_Reserved_Slots_GroupBox.TabStop = false;
            this.Server_Reserved_Slots_GroupBox.Text = "Server Reserved Slots";
            // 
            // Server_Admin_Reserved_Slots_Permission
            // 
            this.Server_Admin_Reserved_Slots_Permission.Location = new System.Drawing.Point(285, 38);
            this.Server_Admin_Reserved_Slots_Permission.Name = "Server_Admin_Reserved_Slots_Permission";
            this.Server_Admin_Reserved_Slots_Permission.Size = new System.Drawing.Size(31, 20);
            this.Server_Admin_Reserved_Slots_Permission.TabIndex = 7;
            this.Server_Admin_Reserved_Slots_Permission.Text = "0";
            this.Server_Admin_Reserved_Slots_Permission.TextChanged += new System.EventHandler(this.ServerAdminSlotsPermission_TextChanged);
            // 
            // Admin_Slot_Text_Label
            // 
            this.Admin_Slot_Text_Label.AutoSize = true;
            this.Admin_Slot_Text_Label.Location = new System.Drawing.Point(95, 41);
            this.Admin_Slot_Text_Label.Name = "Admin_Slot_Text_Label";
            this.Admin_Slot_Text_Label.Size = new System.Drawing.Size(183, 13);
            this.Admin_Slot_Text_Label.TabIndex = 6;
            this.Admin_Slot_Text_Label.Text = "slots for admins with permissions level";
            // 
            // Admin_Reserve_Text_Label
            // 
            this.Admin_Reserve_Text_Label.AutoSize = true;
            this.Admin_Reserve_Text_Label.Location = new System.Drawing.Point(6, 41);
            this.Admin_Reserve_Text_Label.Name = "Admin_Reserve_Text_Label";
            this.Admin_Reserve_Text_Label.Size = new System.Drawing.Size(47, 13);
            this.Admin_Reserve_Text_Label.TabIndex = 5;
            this.Admin_Reserve_Text_Label.Text = "Reserve";
            // 
            // Server_Admin_Reserved_Slots
            // 
            this.Server_Admin_Reserved_Slots.Location = new System.Drawing.Point(59, 38);
            this.Server_Admin_Reserved_Slots.Name = "Server_Admin_Reserved_Slots";
            this.Server_Admin_Reserved_Slots.Size = new System.Drawing.Size(31, 20);
            this.Server_Admin_Reserved_Slots.TabIndex = 4;
            this.Server_Admin_Reserved_Slots.Text = "0";
            this.Server_Admin_Reserved_Slots.TextChanged += new System.EventHandler(this.ServerAdminSlots_TextChanged);
            // 
            // Server_Player_Reserved_Slots_Permission
            // 
            this.Server_Player_Reserved_Slots_Permission.Location = new System.Drawing.Point(285, 13);
            this.Server_Player_Reserved_Slots_Permission.Name = "Server_Player_Reserved_Slots_Permission";
            this.Server_Player_Reserved_Slots_Permission.Size = new System.Drawing.Size(31, 20);
            this.Server_Player_Reserved_Slots_Permission.TabIndex = 3;
            this.Server_Player_Reserved_Slots_Permission.Text = "100";
            this.Server_Player_Reserved_Slots_Permission.TextChanged += new System.EventHandler(this.ServerReservedSlotsPermission_TextChanged);
            // 
            // Player_Slot_Text_Label
            // 
            this.Player_Slot_Text_Label.AutoSize = true;
            this.Player_Slot_Text_Label.Location = new System.Drawing.Point(96, 16);
            this.Player_Slot_Text_Label.Name = "Player_Slot_Text_Label";
            this.Player_Slot_Text_Label.Size = new System.Drawing.Size(183, 13);
            this.Player_Slot_Text_Label.TabIndex = 2;
            this.Player_Slot_Text_Label.Text = "slots for players with permissions level";
            // 
            // Player_Reserve_Text_Label
            // 
            this.Player_Reserve_Text_Label.AutoSize = true;
            this.Player_Reserve_Text_Label.Location = new System.Drawing.Point(6, 16);
            this.Player_Reserve_Text_Label.Name = "Player_Reserve_Text_Label";
            this.Player_Reserve_Text_Label.Size = new System.Drawing.Size(47, 13);
            this.Player_Reserve_Text_Label.TabIndex = 1;
            this.Player_Reserve_Text_Label.Text = "Reserve";
            // 
            // Server_Player_Reserved_Slots
            // 
            this.Server_Player_Reserved_Slots.Location = new System.Drawing.Point(59, 13);
            this.Server_Player_Reserved_Slots.Name = "Server_Player_Reserved_Slots";
            this.Server_Player_Reserved_Slots.Size = new System.Drawing.Size(31, 20);
            this.Server_Player_Reserved_Slots.TabIndex = 0;
            this.Server_Player_Reserved_Slots.Text = "0";
            this.Server_Player_Reserved_Slots.TextChanged += new System.EventHandler(this.ServerReservedSlots_TextChanged);
            // 
            // Player_Killing_Mode_GroupBox
            // 
            this.Player_Killing_Mode_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player_Killing_Mode_GroupBox.Controls.Add(this.panel1);
            this.Player_Killing_Mode_GroupBox.Location = new System.Drawing.Point(708, 310);
            this.Player_Killing_Mode_GroupBox.Name = "Player_Killing_Mode_GroupBox";
            this.Player_Killing_Mode_GroupBox.Size = new System.Drawing.Size(179, 125);
            this.Player_Killing_Mode_GroupBox.TabIndex = 50;
            this.Player_Killing_Mode_GroupBox.TabStop = false;
            this.Player_Killing_Mode_GroupBox.Text = "Player Killing Mode";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Player_Killing_Mode_0);
            this.panel1.Controls.Add(this.Player_Killing_Mode_1);
            this.panel1.Controls.Add(this.Player_Killing_Mode_2);
            this.panel1.Controls.Add(this.Player_Killing_Mode_3);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 95);
            this.panel1.TabIndex = 30;
            // 
            // Player_Killing_Mode_0
            // 
            this.Player_Killing_Mode_0.AutoSize = true;
            this.Player_Killing_Mode_0.Location = new System.Drawing.Point(3, 3);
            this.Player_Killing_Mode_0.Name = "Player_Killing_Mode_0";
            this.Player_Killing_Mode_0.Size = new System.Drawing.Size(135, 17);
            this.Player_Killing_Mode_0.TabIndex = 24;
            this.Player_Killing_Mode_0.Text = "No Killing Other Players";
            this.Player_Killing_Mode_0.UseVisualStyleBackColor = true;
            // 
            // Player_Killing_Mode_1
            // 
            this.Player_Killing_Mode_1.AutoSize = true;
            this.Player_Killing_Mode_1.Location = new System.Drawing.Point(3, 26);
            this.Player_Killing_Mode_1.Name = "Player_Killing_Mode_1";
            this.Player_Killing_Mode_1.Size = new System.Drawing.Size(89, 17);
            this.Player_Killing_Mode_1.TabIndex = 25;
            this.Player_Killing_Mode_1.Text = "Kill Allies Only";
            this.Player_Killing_Mode_1.UseVisualStyleBackColor = true;
            // 
            // Player_Killing_Mode_2
            // 
            this.Player_Killing_Mode_2.AutoSize = true;
            this.Player_Killing_Mode_2.Location = new System.Drawing.Point(3, 49);
            this.Player_Killing_Mode_2.Name = "Player_Killing_Mode_2";
            this.Player_Killing_Mode_2.Size = new System.Drawing.Size(134, 17);
            this.Player_Killing_Mode_2.TabIndex = 26;
            this.Player_Killing_Mode_2.Text = "Kill Enemy Players Only";
            this.Player_Killing_Mode_2.UseVisualStyleBackColor = true;
            // 
            // Player_Killing_Mode_3
            // 
            this.Player_Killing_Mode_3.AutoSize = true;
            this.Player_Killing_Mode_3.Checked = true;
            this.Player_Killing_Mode_3.Location = new System.Drawing.Point(3, 72);
            this.Player_Killing_Mode_3.Name = "Player_Killing_Mode_3";
            this.Player_Killing_Mode_3.Size = new System.Drawing.Size(86, 17);
            this.Player_Killing_Mode_3.TabIndex = 27;
            this.Player_Killing_Mode_3.TabStop = true;
            this.Player_Killing_Mode_3.Text = "Kill Everyone";
            this.Player_Killing_Mode_3.UseVisualStyleBackColor = true;
            // 
            // Spawn_Settings_GroupBox
            // 
            this.Spawn_Settings_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Spawn_Settings_GroupBox.Controls.Add(this.Player_Safe_Zone_Hours_Label);
            this.Spawn_Settings_GroupBox.Controls.Add(this.Player_Safe_Zone_Level_Label);
            this.Spawn_Settings_GroupBox.Controls.Add(this.Player_Safe_Zone_Hours_TextBox);
            this.Spawn_Settings_GroupBox.Controls.Add(this.Player_Safe_Zone_Level_TextBox);
            this.Spawn_Settings_GroupBox.Location = new System.Drawing.Point(523, 500);
            this.Spawn_Settings_GroupBox.Name = "Spawn_Settings_GroupBox";
            this.Spawn_Settings_GroupBox.Size = new System.Drawing.Size(366, 66);
            this.Spawn_Settings_GroupBox.TabIndex = 49;
            this.Spawn_Settings_GroupBox.TabStop = false;
            this.Spawn_Settings_GroupBox.Text = "Spawning";
            // 
            // Player_Safe_Zone_Hours_Label
            // 
            this.Player_Safe_Zone_Hours_Label.AutoSize = true;
            this.Player_Safe_Zone_Hours_Label.Location = new System.Drawing.Point(17, 42);
            this.Player_Safe_Zone_Hours_Label.Name = "Player_Safe_Zone_Hours_Label";
            this.Player_Safe_Zone_Hours_Label.Size = new System.Drawing.Size(120, 13);
            this.Player_Safe_Zone_Hours_Label.TabIndex = 3;
            this.Player_Safe_Zone_Hours_Label.Text = "Player Safe Zone Hours";
            // 
            // Player_Safe_Zone_Level_Label
            // 
            this.Player_Safe_Zone_Level_Label.AutoSize = true;
            this.Player_Safe_Zone_Level_Label.Location = new System.Drawing.Point(17, 16);
            this.Player_Safe_Zone_Level_Label.Name = "Player_Safe_Zone_Level_Label";
            this.Player_Safe_Zone_Level_Label.Size = new System.Drawing.Size(118, 13);
            this.Player_Safe_Zone_Level_Label.TabIndex = 2;
            this.Player_Safe_Zone_Level_Label.Text = "Player Safe Zone Level";
            // 
            // Player_Safe_Zone_Hours_TextBox
            // 
            this.Player_Safe_Zone_Hours_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player_Safe_Zone_Hours_TextBox.Location = new System.Drawing.Point(302, 39);
            this.Player_Safe_Zone_Hours_TextBox.Name = "Player_Safe_Zone_Hours_TextBox";
            this.Player_Safe_Zone_Hours_TextBox.Size = new System.Drawing.Size(54, 20);
            this.Player_Safe_Zone_Hours_TextBox.TabIndex = 1;
            this.Player_Safe_Zone_Hours_TextBox.Text = "5";
            this.Player_Safe_Zone_Hours_TextBox.TextChanged += new System.EventHandler(this.PlayerSafeZoneHours_TextChanged);
            // 
            // Player_Safe_Zone_Level_TextBox
            // 
            this.Player_Safe_Zone_Level_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player_Safe_Zone_Level_TextBox.Location = new System.Drawing.Point(302, 13);
            this.Player_Safe_Zone_Level_TextBox.Name = "Player_Safe_Zone_Level_TextBox";
            this.Player_Safe_Zone_Level_TextBox.Size = new System.Drawing.Size(54, 20);
            this.Player_Safe_Zone_Level_TextBox.TabIndex = 0;
            this.Player_Safe_Zone_Level_TextBox.Text = "5";
            this.Player_Safe_Zone_Level_TextBox.TextChanged += new System.EventHandler(this.PlayerSafeZoneLevel_TextChanged);
            // 
            // Air_Drop_Frequency_GroupBox
            // 
            this.Air_Drop_Frequency_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Air_Drop_Frequency_GroupBox.Controls.Add(this.Air_Drop_Frequency_TrackBar);
            this.Air_Drop_Frequency_GroupBox.Location = new System.Drawing.Point(524, 75);
            this.Air_Drop_Frequency_GroupBox.Name = "Air_Drop_Frequency_GroupBox";
            this.Air_Drop_Frequency_GroupBox.Size = new System.Drawing.Size(366, 65);
            this.Air_Drop_Frequency_GroupBox.TabIndex = 48;
            this.Air_Drop_Frequency_GroupBox.TabStop = false;
            this.Air_Drop_Frequency_GroupBox.Text = "Air Drop Frequency";
            // 
            // Air_Drop_Frequency_TrackBar
            // 
            this.Air_Drop_Frequency_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Air_Drop_Frequency_TrackBar.Location = new System.Drawing.Point(6, 14);
            this.Air_Drop_Frequency_TrackBar.Maximum = 168;
            this.Air_Drop_Frequency_TrackBar.Name = "Air_Drop_Frequency_TrackBar";
            this.Air_Drop_Frequency_TrackBar.Size = new System.Drawing.Size(354, 45);
            this.Air_Drop_Frequency_TrackBar.TabIndex = 8;
            this.Air_Drop_Frequency_TrackBar.Scroll += new System.EventHandler(this.AirDropFrequency_Scroll);
            // 
            // Land_Claim_GroupBox
            // 
            this.Land_Claim_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Land_Claim_GroupBox.Controls.Add(this.Land_Claim_Decay_Mode_GroupBox);
            this.Land_Claim_GroupBox.Controls.Add(this.Land_Claim_Durability_Modifier_GroupBox);
            this.Land_Claim_GroupBox.Controls.Add(this.Land_Claim_Size_GroupBox);
            this.Land_Claim_GroupBox.Controls.Add(this.Land_Claim_Dead_Zone_GroupBox);
            this.Land_Claim_GroupBox.Controls.Add(this.Land_Claim_Expiry_Time_GroupBox);
            this.Land_Claim_GroupBox.Location = new System.Drawing.Point(10, 381);
            this.Land_Claim_GroupBox.Name = "Land_Claim_GroupBox";
            this.Land_Claim_GroupBox.Size = new System.Drawing.Size(508, 185);
            this.Land_Claim_GroupBox.TabIndex = 39;
            this.Land_Claim_GroupBox.TabStop = false;
            this.Land_Claim_GroupBox.Text = "Land Claims";
            // 
            // Land_Claim_Decay_Mode_GroupBox
            // 
            this.Land_Claim_Decay_Mode_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Land_Claim_Decay_Mode_GroupBox.Controls.Add(this.Full_prot);
            this.Land_Claim_Decay_Mode_GroupBox.Controls.Add(this.Exponential);
            this.Land_Claim_Decay_Mode_GroupBox.Controls.Add(this.Linear);
            this.Land_Claim_Decay_Mode_GroupBox.Location = new System.Drawing.Point(6, 19);
            this.Land_Claim_Decay_Mode_GroupBox.Name = "Land_Claim_Decay_Mode_GroupBox";
            this.Land_Claim_Decay_Mode_GroupBox.Size = new System.Drawing.Size(342, 92);
            this.Land_Claim_Decay_Mode_GroupBox.TabIndex = 3;
            this.Land_Claim_Decay_Mode_GroupBox.TabStop = false;
            this.Land_Claim_Decay_Mode_GroupBox.Text = "Land Claim Decay Mode";
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
            // Land_Claim_Durability_Modifier_GroupBox
            // 
            this.Land_Claim_Durability_Modifier_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Land_Claim_Durability_Modifier_GroupBox.Controls.Add(this.Land_Claim_Durability_Offline_Label);
            this.Land_Claim_Durability_Modifier_GroupBox.Controls.Add(this.Land_Claim_Durability_Online_Label);
            this.Land_Claim_Durability_Modifier_GroupBox.Controls.Add(this.LandClaimOfflineDurabilityModifier);
            this.Land_Claim_Durability_Modifier_GroupBox.Controls.Add(this.LandClaimOnlineDurabilityModifier);
            this.Land_Claim_Durability_Modifier_GroupBox.Location = new System.Drawing.Point(6, 113);
            this.Land_Claim_Durability_Modifier_GroupBox.Name = "Land_Claim_Durability_Modifier_GroupBox";
            this.Land_Claim_Durability_Modifier_GroupBox.Size = new System.Drawing.Size(342, 67);
            this.Land_Claim_Durability_Modifier_GroupBox.TabIndex = 4;
            this.Land_Claim_Durability_Modifier_GroupBox.TabStop = false;
            this.Land_Claim_Durability_Modifier_GroupBox.Text = "Land Claim Durability Modifier";
            // 
            // Land_Claim_Durability_Offline_Label
            // 
            this.Land_Claim_Durability_Offline_Label.AutoSize = true;
            this.Land_Claim_Durability_Offline_Label.Location = new System.Drawing.Point(17, 42);
            this.Land_Claim_Durability_Offline_Label.Name = "Land_Claim_Durability_Offline_Label";
            this.Land_Claim_Durability_Offline_Label.Size = new System.Drawing.Size(37, 13);
            this.Land_Claim_Durability_Offline_Label.TabIndex = 3;
            this.Land_Claim_Durability_Offline_Label.Text = "Offline";
            // 
            // Land_Claim_Durability_Online_Label
            // 
            this.Land_Claim_Durability_Online_Label.AutoSize = true;
            this.Land_Claim_Durability_Online_Label.Location = new System.Drawing.Point(17, 16);
            this.Land_Claim_Durability_Online_Label.Name = "Land_Claim_Durability_Online_Label";
            this.Land_Claim_Durability_Online_Label.Size = new System.Drawing.Size(37, 13);
            this.Land_Claim_Durability_Online_Label.TabIndex = 2;
            this.Land_Claim_Durability_Online_Label.Text = "Online";
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
            // Land_Claim_Size_GroupBox
            // 
            this.Land_Claim_Size_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Land_Claim_Size_GroupBox.Controls.Add(this.Land_Claim_Size_TextBox);
            this.Land_Claim_Size_GroupBox.Location = new System.Drawing.Point(354, 72);
            this.Land_Claim_Size_GroupBox.Name = "Land_Claim_Size_GroupBox";
            this.Land_Claim_Size_GroupBox.Size = new System.Drawing.Size(145, 51);
            this.Land_Claim_Size_GroupBox.TabIndex = 0;
            this.Land_Claim_Size_GroupBox.TabStop = false;
            this.Land_Claim_Size_GroupBox.Text = "Land Claim Size";
            // 
            // Land_Claim_Size_TextBox
            // 
            this.Land_Claim_Size_TextBox.Location = new System.Drawing.Point(6, 19);
            this.Land_Claim_Size_TextBox.Name = "Land_Claim_Size_TextBox";
            this.Land_Claim_Size_TextBox.Size = new System.Drawing.Size(133, 20);
            this.Land_Claim_Size_TextBox.TabIndex = 0;
            this.Land_Claim_Size_TextBox.Text = "7";
            this.Land_Claim_Size_TextBox.TextChanged += new System.EventHandler(this.LandClaimSize_TextChanged);
            // 
            // Land_Claim_Dead_Zone_GroupBox
            // 
            this.Land_Claim_Dead_Zone_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Land_Claim_Dead_Zone_GroupBox.Controls.Add(this.Land_Claim_Dead_Zone_TextBox);
            this.Land_Claim_Dead_Zone_GroupBox.Location = new System.Drawing.Point(354, 19);
            this.Land_Claim_Dead_Zone_GroupBox.Name = "Land_Claim_Dead_Zone_GroupBox";
            this.Land_Claim_Dead_Zone_GroupBox.Size = new System.Drawing.Size(145, 51);
            this.Land_Claim_Dead_Zone_GroupBox.TabIndex = 1;
            this.Land_Claim_Dead_Zone_GroupBox.TabStop = false;
            this.Land_Claim_Dead_Zone_GroupBox.Text = "Land Claim Dead Zone";
            // 
            // Land_Claim_Dead_Zone_TextBox
            // 
            this.Land_Claim_Dead_Zone_TextBox.Location = new System.Drawing.Point(6, 19);
            this.Land_Claim_Dead_Zone_TextBox.Name = "Land_Claim_Dead_Zone_TextBox";
            this.Land_Claim_Dead_Zone_TextBox.Size = new System.Drawing.Size(133, 20);
            this.Land_Claim_Dead_Zone_TextBox.TabIndex = 0;
            this.Land_Claim_Dead_Zone_TextBox.Text = "30";
            this.Land_Claim_Dead_Zone_TextBox.TextChanged += new System.EventHandler(this.LandClaimDeadZone_TextChanged);
            // 
            // Land_Claim_Expiry_Time_GroupBox
            // 
            this.Land_Claim_Expiry_Time_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Land_Claim_Expiry_Time_GroupBox.Controls.Add(this.Land_Claim_Expiry_Time_TextBox);
            this.Land_Claim_Expiry_Time_GroupBox.Location = new System.Drawing.Point(354, 129);
            this.Land_Claim_Expiry_Time_GroupBox.Name = "Land_Claim_Expiry_Time_GroupBox";
            this.Land_Claim_Expiry_Time_GroupBox.Size = new System.Drawing.Size(145, 51);
            this.Land_Claim_Expiry_Time_GroupBox.TabIndex = 2;
            this.Land_Claim_Expiry_Time_GroupBox.TabStop = false;
            this.Land_Claim_Expiry_Time_GroupBox.Text = "Land Claim Expiry Time";
            // 
            // Land_Claim_Expiry_Time_TextBox
            // 
            this.Land_Claim_Expiry_Time_TextBox.Location = new System.Drawing.Point(6, 19);
            this.Land_Claim_Expiry_Time_TextBox.Name = "Land_Claim_Expiry_Time_TextBox";
            this.Land_Claim_Expiry_Time_TextBox.Size = new System.Drawing.Size(133, 20);
            this.Land_Claim_Expiry_Time_TextBox.TabIndex = 0;
            this.Land_Claim_Expiry_Time_TextBox.Text = "3";
            this.Land_Claim_Expiry_Time_TextBox.TextChanged += new System.EventHandler(this.LandClaimExpiryTime_TextChanged);
            // 
            // Loot_Respawn_Days_GroupBox
            // 
            this.Loot_Respawn_Days_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Loot_Respawn_Days_GroupBox.Controls.Add(this.LootRespawnDays);
            this.Loot_Respawn_Days_GroupBox.Location = new System.Drawing.Point(10, 310);
            this.Loot_Respawn_Days_GroupBox.Name = "Loot_Respawn_Days_GroupBox";
            this.Loot_Respawn_Days_GroupBox.Size = new System.Drawing.Size(508, 65);
            this.Loot_Respawn_Days_GroupBox.TabIndex = 47;
            this.Loot_Respawn_Days_GroupBox.TabStop = false;
            this.Loot_Respawn_Days_GroupBox.Text = "Loot Respawn Days";
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
            // Loot_Abundance_GroupBox
            // 
            this.Loot_Abundance_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Loot_Abundance_GroupBox.Controls.Add(this.LootAbundance);
            this.Loot_Abundance_GroupBox.Location = new System.Drawing.Point(10, 239);
            this.Loot_Abundance_GroupBox.Name = "Loot_Abundance_GroupBox";
            this.Loot_Abundance_GroupBox.Size = new System.Drawing.Size(508, 65);
            this.Loot_Abundance_GroupBox.TabIndex = 46;
            this.Loot_Abundance_GroupBox.TabStop = false;
            this.Loot_Abundance_GroupBox.Text = "Loot Abundance %";
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
            // Max_Players_GroupBox
            // 
            this.Max_Players_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Max_Players_GroupBox.Controls.Add(this.maxpl);
            this.Max_Players_GroupBox.Location = new System.Drawing.Point(10, 3);
            this.Max_Players_GroupBox.Name = "Max_Players_GroupBox";
            this.Max_Players_GroupBox.Size = new System.Drawing.Size(508, 65);
            this.Max_Players_GroupBox.TabIndex = 45;
            this.Max_Players_GroupBox.TabStop = false;
            this.Max_Players_GroupBox.Text = "Max Players";
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
            this.maxpl.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // Game_Mode_Settings_GroupBox
            // 
            this.Game_Mode_Settings_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Game_Mode_Settings_GroupBox.Controls.Add(this.PersistentPlayerProfiles);
            this.Game_Mode_Settings_GroupBox.Controls.Add(this.feral);
            this.Game_Mode_Settings_GroupBox.Controls.Add(this.gamemode_surv_pvp);
            this.Game_Mode_Settings_GroupBox.Controls.Add(this.cheatmode);
            this.Game_Mode_Settings_GroupBox.Controls.Add(this.gamemode_coop);
            this.Game_Mode_Settings_GroupBox.Location = new System.Drawing.Point(523, 335);
            this.Game_Mode_Settings_GroupBox.Name = "Game_Mode_Settings_GroupBox";
            this.Game_Mode_Settings_GroupBox.Size = new System.Drawing.Size(179, 162);
            this.Game_Mode_Settings_GroupBox.TabIndex = 44;
            this.Game_Mode_Settings_GroupBox.TabStop = false;
            this.Game_Mode_Settings_GroupBox.Text = "Game Mode Settings";
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
            this.gamemode_surv_pvp.CheckedChanged += new System.EventHandler(this.Gamemode_surv_pvp_CheckedChanged);
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
            this.cheatmode.CheckedChanged += new System.EventHandler(this.Cheatmode_CheckedChanged);
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
            this.gamemode_coop.CheckedChanged += new System.EventHandler(this.Gamemode_coop_CheckedChanged);
            // 
            // Zombie_Settings_GroupBox
            // 
            this.Zombie_Settings_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Zombie_Settings_GroupBox.Controls.Add(this.zombie_never_run);
            this.Zombie_Settings_GroupBox.Controls.Add(this.zombie_normal);
            this.Zombie_Settings_GroupBox.Controls.Add(this.zombie_run);
            this.Zombie_Settings_GroupBox.Location = new System.Drawing.Point(708, 217);
            this.Zombie_Settings_GroupBox.Name = "Zombie_Settings_GroupBox";
            this.Zombie_Settings_GroupBox.Size = new System.Drawing.Size(179, 87);
            this.Zombie_Settings_GroupBox.TabIndex = 43;
            this.Zombie_Settings_GroupBox.TabStop = false;
            this.Zombie_Settings_GroupBox.Text = "Zombies";
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
            this.zombie_never_run.CheckedChanged += new System.EventHandler(this.Zombie_never_run_CheckedChanged);
            // 
            // zombie_normal
            // 
            this.zombie_normal.AutoSize = true;
            this.zombie_normal.Location = new System.Drawing.Point(6, 18);
            this.zombie_normal.Name = "zombie_normal";
            this.zombie_normal.Size = new System.Drawing.Size(124, 17);
            this.zombie_normal.TabIndex = 24;
            this.zombie_normal.TabStop = true;
            this.zombie_normal.Text = "Zombie Run At Night";
            this.zombie_normal.UseVisualStyleBackColor = true;
            this.zombie_normal.CheckedChanged += new System.EventHandler(this.Zombie_normal_CheckedChanged);
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
            this.zombie_run.CheckedChanged += new System.EventHandler(this.Zombie_run_CheckedChanged);
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
            this.nightpercentage.Scroll += new System.EventHandler(this.Nightpercentage_Scroll);
            // 
            // Day_Length_GroupBox
            // 
            this.Day_Length_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Day_Length_GroupBox.Controls.Add(this.realtime);
            this.Day_Length_GroupBox.Controls.Add(this.dayLength);
            this.Day_Length_GroupBox.Location = new System.Drawing.Point(10, 145);
            this.Day_Length_GroupBox.Name = "Day_Length_GroupBox";
            this.Day_Length_GroupBox.Size = new System.Drawing.Size(508, 88);
            this.Day_Length_GroupBox.TabIndex = 39;
            this.Day_Length_GroupBox.TabStop = false;
            this.Day_Length_GroupBox.Text = "Day Length";
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
            this.realtime.CheckedChanged += new System.EventHandler(this.Realtime_CheckedChanged);
            // 
            // dayLength
            // 
            this.dayLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dayLength.Enabled = false;
            this.dayLength.Location = new System.Drawing.Point(6, 19);
            this.dayLength.Maximum = 240;
            this.dayLength.Minimum = 1;
            this.dayLength.Name = "dayLength";
            this.dayLength.Size = new System.Drawing.Size(496, 45);
            this.dayLength.TabIndex = 9;
            this.dayLength.Value = 20;
            this.dayLength.Scroll += new System.EventHandler(this.Day_Length_Scroll);
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
            this.bdm.Scroll += new System.EventHandler(this.Bdm_Scroll);
            // 
            // Drop_On_Death_Group_Box
            // 
            this.Drop_On_Death_Group_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Drop_On_Death_Group_Box.Controls.Add(this.Drop_On_Death_Mode_0);
            this.Drop_On_Death_Group_Box.Controls.Add(this.Drop_On_Death_Mode_1);
            this.Drop_On_Death_Group_Box.Controls.Add(this.Drop_On_Death_Mode_3);
            this.Drop_On_Death_Group_Box.Controls.Add(this.Drop_On_Death_Mode_2);
            this.Drop_On_Death_Group_Box.Location = new System.Drawing.Point(523, 217);
            this.Drop_On_Death_Group_Box.Name = "Drop_On_Death_Group_Box";
            this.Drop_On_Death_Group_Box.Size = new System.Drawing.Size(95, 112);
            this.Drop_On_Death_Group_Box.TabIndex = 32;
            this.Drop_On_Death_Group_Box.TabStop = false;
            this.Drop_On_Death_Group_Box.Text = "Drop On Death";
            // 
            // Drop_On_Death_Mode_0
            // 
            this.Drop_On_Death_Mode_0.AutoSize = true;
            this.Drop_On_Death_Mode_0.Location = new System.Drawing.Point(9, 18);
            this.Drop_On_Death_Mode_0.Name = "Drop_On_Death_Mode_0";
            this.Drop_On_Death_Mode_0.Size = new System.Drawing.Size(62, 17);
            this.Drop_On_Death_Mode_0.TabIndex = 24;
            this.Drop_On_Death_Mode_0.Text = "Nothing";
            this.Drop_On_Death_Mode_0.UseVisualStyleBackColor = true;
            this.Drop_On_Death_Mode_0.CheckedChanged += new System.EventHandler(this.Dtds_show_CheckedChanged);
            // 
            // Drop_On_Death_Mode_1
            // 
            this.Drop_On_Death_Mode_1.AutoSize = true;
            this.Drop_On_Death_Mode_1.Location = new System.Drawing.Point(9, 41);
            this.Drop_On_Death_Mode_1.Name = "Drop_On_Death_Mode_1";
            this.Drop_On_Death_Mode_1.Size = new System.Drawing.Size(75, 17);
            this.Drop_On_Death_Mode_1.TabIndex = 25;
            this.Drop_On_Death_Mode_1.Text = "Everything";
            this.Drop_On_Death_Mode_1.UseVisualStyleBackColor = true;
            this.Drop_On_Death_Mode_1.CheckedChanged += new System.EventHandler(this.Dod_1_CheckedChanged);
            // 
            // Drop_On_Death_Mode_3
            // 
            this.Drop_On_Death_Mode_3.AutoSize = true;
            this.Drop_On_Death_Mode_3.Location = new System.Drawing.Point(9, 87);
            this.Drop_On_Death_Mode_3.Name = "Drop_On_Death_Mode_3";
            this.Drop_On_Death_Mode_3.Size = new System.Drawing.Size(74, 17);
            this.Drop_On_Death_Mode_3.TabIndex = 27;
            this.Drop_On_Death_Mode_3.Text = "Backpack";
            this.Drop_On_Death_Mode_3.UseVisualStyleBackColor = true;
            this.Drop_On_Death_Mode_3.CheckedChanged += new System.EventHandler(this.Dod_3_CheckedChanged);
            // 
            // Drop_On_Death_Mode_2
            // 
            this.Drop_On_Death_Mode_2.AutoSize = true;
            this.Drop_On_Death_Mode_2.Checked = true;
            this.Drop_On_Death_Mode_2.Location = new System.Drawing.Point(9, 64);
            this.Drop_On_Death_Mode_2.Name = "Drop_On_Death_Mode_2";
            this.Drop_On_Death_Mode_2.Size = new System.Drawing.Size(63, 17);
            this.Drop_On_Death_Mode_2.TabIndex = 26;
            this.Drop_On_Death_Mode_2.TabStop = true;
            this.Drop_On_Death_Mode_2.Text = "Toolbelt";
            this.Drop_On_Death_Mode_2.UseVisualStyleBackColor = true;
            this.Drop_On_Death_Mode_2.CheckedChanged += new System.EventHandler(this.Dod_2_CheckedChanged);
            // 
            // Game_Difficulty_GroupBox
            // 
            this.Game_Difficulty_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Game_Difficulty_GroupBox.Controls.Add(this.Game_Difficulty_TrackBar);
            this.Game_Difficulty_GroupBox.Location = new System.Drawing.Point(523, 146);
            this.Game_Difficulty_GroupBox.Name = "Game_Difficulty_GroupBox";
            this.Game_Difficulty_GroupBox.Size = new System.Drawing.Size(179, 65);
            this.Game_Difficulty_GroupBox.TabIndex = 31;
            this.Game_Difficulty_GroupBox.TabStop = false;
            this.Game_Difficulty_GroupBox.Text = "Difficulty";
            // 
            // Game_Difficulty_TrackBar
            // 
            this.Game_Difficulty_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Game_Difficulty_TrackBar.Location = new System.Drawing.Point(6, 13);
            this.Game_Difficulty_TrackBar.Maximum = 5;
            this.Game_Difficulty_TrackBar.Name = "Game_Difficulty_TrackBar";
            this.Game_Difficulty_TrackBar.Size = new System.Drawing.Size(167, 45);
            this.Game_Difficulty_TrackBar.TabIndex = 9;
            this.Game_Difficulty_TrackBar.Value = 1;
            this.Game_Difficulty_TrackBar.Scroll += new System.EventHandler(this.Trudnosc_Scroll);
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
            this.nazwamapa.Controls.Add(this.gamename);
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
            this.gamename.FormattingEnabled = true;
            this.gamename.Location = new System.Drawing.Point(6, 22);
            this.gamename.Name = "nazwa";
            this.gamename.Size = new System.Drawing.Size(190, 21);
            this.gamename.TabIndex = 4;
            this.gamename.SelectedIndexChanged += new System.EventHandler(this.Nazwa_SelectedIndexChanged);
            this.gamename.TextChanged += new System.EventHandler(this.Nazwa_TextChanged);
            // 
            // server_nazwa
            // 
            this.server_nazwa.Location = new System.Drawing.Point(6, 48);
            this.server_nazwa.Name = "server_nazwa";
            this.server_nazwa.Size = new System.Drawing.Size(190, 20);
            this.server_nazwa.TabIndex = 3;
            this.server_nazwa.Text = "7DaysServerManager";
            this.server_nazwa.TextChanged += new System.EventHandler(this.Server_nazwa_TextChanged);
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
            this.mapa.SelectedIndexChanged += new System.EventHandler(this.Mapa_SelectedIndexChanged);
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
            this.save_logfiles.CheckedChanged += new System.EventHandler(this.Save_logfiles_CheckedChanged);
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
            this.port.TextChanged += new System.EventHandler(this.Port_TextChanged);
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
            this.port_panel.TextChanged += new System.EventHandler(this.Port_panel_TextChanged);
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
            this.ctrlp.CheckedChanged += new System.EventHandler(this.Ctrlp_CheckedChanged);
            // 
            // ctrlppass
            // 
            this.ctrlppass.Location = new System.Drawing.Point(96, 42);
            this.ctrlppass.Name = "ctrlppass";
            this.ctrlppass.PasswordChar = '*';
            this.ctrlppass.Size = new System.Drawing.Size(169, 20);
            this.ctrlppass.TabIndex = 8;
            this.ctrlppass.TextChanged += new System.EventHandler(this.Ctrlppass_TextChanged);
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
            // Header_Icons
            // 
            this.Header_Icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.Header_Icons.ImageSize = new System.Drawing.Size(40, 40);
            this.Header_Icons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Messaging_TabPage
            // 
            this.Messaging_TabPage.BackColor = System.Drawing.SystemColors.Control;
            this.Messaging_TabPage.Controls.Add(this.Server_Chat_Messages_GroupBox);
            this.Messaging_TabPage.Controls.Add(this.Custom_Commands_GroupBox);
            this.Messaging_TabPage.ImageIndex = 3;
            this.Messaging_TabPage.Location = new System.Drawing.Point(47, 4);
            this.Messaging_TabPage.Name = "Messaging_TabPage";
            this.Messaging_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Messaging_TabPage.Size = new System.Drawing.Size(908, 684);
            this.Messaging_TabPage.TabIndex = 13;
            // 
            // Server_Chat_Messages_GroupBox
            // 
            this.Server_Chat_Messages_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Server_Chat_Messages_GroupBox.Controls.Add(this.cmd_not_yet);
            this.Server_Chat_Messages_GroupBox.Controls.Add(this.Command_Wait_Message_Label);
            this.Server_Chat_Messages_GroupBox.Controls.Add(this.Starting_Backup_Message_TextBox);
            this.Server_Chat_Messages_GroupBox.Controls.Add(this.Backup_Completed_Message_Label);
            this.Server_Chat_Messages_GroupBox.Controls.Add(this.reboot);
            this.Server_Chat_Messages_GroupBox.Controls.Add(this.Backup_Completed_Message_TextBox);
            this.Server_Chat_Messages_GroupBox.Controls.Add(this.Starting_Backup_Message_Label);
            this.Server_Chat_Messages_GroupBox.Controls.Add(this.Time_Until_Reboot_Message_Label);
            this.Server_Chat_Messages_GroupBox.Controls.Add(this.Reboot_Now_Message_Label);
            this.Server_Chat_Messages_GroupBox.Controls.Add(this.reboot_time);
            this.Server_Chat_Messages_GroupBox.Location = new System.Drawing.Point(9, 508);
            this.Server_Chat_Messages_GroupBox.Name = "Server_Chat_Messages_GroupBox";
            this.Server_Chat_Messages_GroupBox.Size = new System.Drawing.Size(892, 170);
            this.Server_Chat_Messages_GroupBox.TabIndex = 12;
            this.Server_Chat_Messages_GroupBox.TabStop = false;
            this.Server_Chat_Messages_GroupBox.Text = "Server Chat Message Defaults";
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
            // Command_Wait_Message_Label
            // 
            this.Command_Wait_Message_Label.AutoSize = true;
            this.Command_Wait_Message_Label.Location = new System.Drawing.Point(15, 126);
            this.Command_Wait_Message_Label.Name = "Command_Wait_Message_Label";
            this.Command_Wait_Message_Label.Size = new System.Drawing.Size(199, 13);
            this.Command_Wait_Message_Label.TabIndex = 13;
            this.Command_Wait_Message_Label.Text = "Can\'t Use Command Yet! (%d = time left):";
            // 
            // Starting_Backup_Message_TextBox
            // 
            this.Starting_Backup_Message_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Starting_Backup_Message_TextBox.Location = new System.Drawing.Point(226, 19);
            this.Starting_Backup_Message_TextBox.Name = "Starting_Backup_Message_TextBox";
            this.Starting_Backup_Message_TextBox.Size = new System.Drawing.Size(646, 20);
            this.Starting_Backup_Message_TextBox.TabIndex = 4;
            this.Starting_Backup_Message_TextBox.TextChanged += new System.EventHandler(this.Backup_msg_1_TextChanged);
            // 
            // Backup_Completed_Message_Label
            // 
            this.Backup_Completed_Message_Label.AutoSize = true;
            this.Backup_Completed_Message_Label.Location = new System.Drawing.Point(15, 48);
            this.Backup_Completed_Message_Label.Name = "Backup_Completed_Message_Label";
            this.Backup_Completed_Message_Label.Size = new System.Drawing.Size(100, 13);
            this.Backup_Completed_Message_Label.TabIndex = 11;
            this.Backup_Completed_Message_Label.Text = "Backup Completed:";
            this.Backup_Completed_Message_Label.Click += new System.EventHandler(this.Backup_Completed_Message_Label_Click);
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
            // Backup_Completed_Message_TextBox
            // 
            this.Backup_Completed_Message_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Backup_Completed_Message_TextBox.Location = new System.Drawing.Point(226, 45);
            this.Backup_Completed_Message_TextBox.Name = "Backup_Completed_Message_TextBox";
            this.Backup_Completed_Message_TextBox.Size = new System.Drawing.Size(646, 20);
            this.Backup_Completed_Message_TextBox.TabIndex = 10;
            this.Backup_Completed_Message_TextBox.TextChanged += new System.EventHandler(this.Backup_msg_2_TextChanged);
            // 
            // Starting_Backup_Message_Label
            // 
            this.Starting_Backup_Message_Label.AutoSize = true;
            this.Starting_Backup_Message_Label.Location = new System.Drawing.Point(15, 22);
            this.Starting_Backup_Message_Label.Name = "Starting_Backup_Message_Label";
            this.Starting_Backup_Message_Label.Size = new System.Drawing.Size(86, 13);
            this.Starting_Backup_Message_Label.TabIndex = 6;
            this.Starting_Backup_Message_Label.Text = "Starting Backup:";
            // 
            // Time_Until_Reboot_Message_Label
            // 
            this.Time_Until_Reboot_Message_Label.AutoSize = true;
            this.Time_Until_Reboot_Message_Label.Location = new System.Drawing.Point(15, 74);
            this.Time_Until_Reboot_Message_Label.Name = "Time_Until_Reboot_Message_Label";
            this.Time_Until_Reboot_Message_Label.Size = new System.Drawing.Size(179, 13);
            this.Time_Until_Reboot_Message_Label.TabIndex = 9;
            this.Time_Until_Reboot_Message_Label.Text = "Time Left To Reboot (%d = time left):";
            // 
            // Reboot_Now_Message_Label
            // 
            this.Reboot_Now_Message_Label.AutoSize = true;
            this.Reboot_Now_Message_Label.Location = new System.Drawing.Point(15, 100);
            this.Reboot_Now_Message_Label.Name = "Reboot_Now_Message_Label";
            this.Reboot_Now_Message_Label.Size = new System.Drawing.Size(70, 13);
            this.Reboot_Now_Message_Label.TabIndex = 7;
            this.Reboot_Now_Message_Label.Text = "Reboot Now:";
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
            // Custom_Commands_GroupBox
            // 
            this.Custom_Commands_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Custom_Commands_GroupBox.Controls.Add(this.How_To_Use_External_Calls_Button);
            this.Custom_Commands_GroupBox.Controls.Add(this.External_Call_File_Name_Label);
            this.Custom_Commands_GroupBox.Controls.Add(this.External_Call_File_Select_Button);
            this.Custom_Commands_GroupBox.Controls.Add(this.Use_External_Call_CheckBox);
            this.Custom_Commands_GroupBox.Controls.Add(this.Enable_Custom_Commands_CheckBox);
            this.Custom_Commands_GroupBox.Controls.Add(this.How_To_Commands_Button);
            this.Custom_Commands_GroupBox.Controls.Add(this.Custom_Commands_RichTextBox);
            this.Custom_Commands_GroupBox.Location = new System.Drawing.Point(9, 8);
            this.Custom_Commands_GroupBox.Name = "Custom_Commands_GroupBox";
            this.Custom_Commands_GroupBox.Size = new System.Drawing.Size(892, 494);
            this.Custom_Commands_GroupBox.TabIndex = 14;
            this.Custom_Commands_GroupBox.TabStop = false;
            this.Custom_Commands_GroupBox.Text = "Custom Commands";
            // 
            // How_To_Use_External_Calls_Button
            // 
            this.How_To_Use_External_Calls_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.How_To_Use_External_Calls_Button.Location = new System.Drawing.Point(700, 465);
            this.How_To_Use_External_Calls_Button.Name = "How_To_Use_External_Calls_Button";
            this.How_To_Use_External_Calls_Button.Size = new System.Drawing.Size(178, 23);
            this.How_To_Use_External_Calls_Button.TabIndex = 19;
            this.How_To_Use_External_Calls_Button.Text = "How to use external calling?";
            this.How_To_Use_External_Calls_Button.UseVisualStyleBackColor = true;
            this.How_To_Use_External_Calls_Button.Click += new System.EventHandler(this.How_to_commands2_Click);
            // 
            // External_Call_File_Name_Label
            // 
            this.External_Call_File_Name_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.External_Call_File_Name_Label.AutoSize = true;
            this.External_Call_File_Name_Label.Location = new System.Drawing.Point(140, 432);
            this.External_Call_File_Name_Label.Name = "External_Call_File_Name_Label";
            this.External_Call_File_Name_Label.Size = new System.Drawing.Size(37, 13);
            this.External_Call_File_Name_Label.TabIndex = 18;
            this.External_Call_File_Name_Label.Text = "(none)";
            // 
            // External_Call_File_Select_Button
            // 
            this.External_Call_File_Select_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.External_Call_File_Select_Button.Enabled = false;
            this.External_Call_File_Select_Button.Location = new System.Drawing.Point(18, 427);
            this.External_Call_File_Select_Button.Name = "External_Call_File_Select_Button";
            this.External_Call_File_Select_Button.Size = new System.Drawing.Size(116, 23);
            this.External_Call_File_Select_Button.TabIndex = 17;
            this.External_Call_File_Select_Button.Text = "Select File To Call...";
            this.External_Call_File_Select_Button.UseVisualStyleBackColor = true;
            this.External_Call_File_Select_Button.Click += new System.EventHandler(this.Excall_file_Click);
            // 
            // Use_External_Call_CheckBox
            // 
            this.Use_External_Call_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Use_External_Call_CheckBox.AutoSize = true;
            this.Use_External_Call_CheckBox.Location = new System.Drawing.Point(18, 404);
            this.Use_External_Call_CheckBox.Name = "Use_External_Call_CheckBox";
            this.Use_External_Call_CheckBox.Size = new System.Drawing.Size(370, 17);
            this.Use_External_Call_CheckBox.TabIndex = 16;
            this.Use_External_Call_CheckBox.Text = "Instead use external call (harder to use, but gives much more possibilities)";
            this.Use_External_Call_CheckBox.UseVisualStyleBackColor = true;
            this.Use_External_Call_CheckBox.CheckedChanged += new System.EventHandler(this.Excall_CheckedChanged);
            // 
            // Enable_Custom_Commands_CheckBox
            // 
            this.Enable_Custom_Commands_CheckBox.AutoSize = true;
            this.Enable_Custom_Commands_CheckBox.Location = new System.Drawing.Point(18, 19);
            this.Enable_Custom_Commands_CheckBox.Name = "Enable_Custom_Commands_CheckBox";
            this.Enable_Custom_Commands_CheckBox.Size = new System.Drawing.Size(152, 17);
            this.Enable_Custom_Commands_CheckBox.TabIndex = 15;
            this.Enable_Custom_Commands_CheckBox.Text = "Enable Custom Commands";
            this.Enable_Custom_Commands_CheckBox.UseVisualStyleBackColor = true;
            this.Enable_Custom_Commands_CheckBox.CheckedChanged += new System.EventHandler(this.Enable_cc_CheckedChanged);
            // 
            // How_To_Commands_Button
            // 
            this.How_To_Commands_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.How_To_Commands_Button.Location = new System.Drawing.Point(700, 384);
            this.How_To_Commands_Button.Name = "How_To_Commands_Button";
            this.How_To_Commands_Button.Size = new System.Drawing.Size(178, 23);
            this.How_To_Commands_Button.TabIndex = 14;
            this.How_To_Commands_Button.Text = "How to Create Commands?";
            this.How_To_Commands_Button.UseVisualStyleBackColor = true;
            this.How_To_Commands_Button.Click += new System.EventHandler(this.How_to_commands_Click);
            // 
            // Custom_Commands_RichTextBox
            // 
            this.Custom_Commands_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Custom_Commands_RichTextBox.Location = new System.Drawing.Point(18, 42);
            this.Custom_Commands_RichTextBox.Name = "Custom_Commands_RichTextBox";
            this.Custom_Commands_RichTextBox.Size = new System.Drawing.Size(860, 336);
            this.Custom_Commands_RichTextBox.TabIndex = 13;
            this.Custom_Commands_RichTextBox.Text = "";
            this.Custom_Commands_RichTextBox.TextChanged += new System.EventHandler(this.Customcommands_TextChanged);
            // 
            // GlobalBanList_TabPage
            // 
            this.GlobalBanList_TabPage.BackColor = System.Drawing.SystemColors.Control;
            this.GlobalBanList_TabPage.Controls.Add(this.check_bans);
            this.GlobalBanList_TabPage.Controls.Add(this.global_ban_g);
            this.GlobalBanList_TabPage.Controls.Add(this.banlist_logo);
            this.GlobalBanList_TabPage.ImageIndex = 10;
            this.GlobalBanList_TabPage.Location = new System.Drawing.Point(47, 4);
            this.GlobalBanList_TabPage.Name = "GlobalBanList_TabPage";
            this.GlobalBanList_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GlobalBanList_TabPage.Size = new System.Drawing.Size(908, 684);
            this.GlobalBanList_TabPage.TabIndex = 17;
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
            this.check_bans.Click += new System.EventHandler(this.Check_bans_Click);
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
            this.sendbans.CheckedChanged += new System.EventHandler(this.Sendbans_CheckedChanged);
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
            this.glob_3.CheckedChanged += new System.EventHandler(this.Glob_0_CheckedChanged);
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
            this.glob_0.CheckedChanged += new System.EventHandler(this.Glob_0_CheckedChanged);
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
            this.glob_2.CheckedChanged += new System.EventHandler(this.Glob_0_CheckedChanged);
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
            this.glob_1.CheckedChanged += new System.EventHandler(this.Glob_0_CheckedChanged);
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
            // WebServer_TabPage
            // 
            this.WebServer_TabPage.BackColor = System.Drawing.SystemColors.Control;
            this.WebServer_TabPage.Controls.Add(this.autofix_g);
            this.WebServer_TabPage.Controls.Add(this.website_g);
            this.WebServer_TabPage.Controls.Add(this.android_g);
            this.WebServer_TabPage.ImageIndex = 11;
            this.WebServer_TabPage.Location = new System.Drawing.Point(47, 4);
            this.WebServer_TabPage.Name = "WebServer_TabPage";
            this.WebServer_TabPage.Size = new System.Drawing.Size(908, 684);
            this.WebServer_TabPage.TabIndex = 18;
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
            this.reverse_reservation.Click += new System.EventHandler(this.Reverse_reservation_Click);
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
            this.fix_firewall_and_other_windows_shit.Click += new System.EventHandler(this.Fix_firewall_and_other_windows_shit_Click);
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
            this.www_main_content.TextChanged += new System.EventHandler(this.Www_main_content_TextChanged);
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
            this.rules_content.TextChanged += new System.EventHandler(this.Rules_content_TextChanged);
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
            this.hide_footer.CheckedChanged += new System.EventHandler(this.Hide_footer_CheckedChanged);
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
            this.forum_url.TextChanged += new System.EventHandler(this.Forum_url_TextChanged);
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
            this.enable_website.CheckedChanged += new System.EventHandler(this.Enable_website_CheckedChanged);
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
            this.android_apk.Click += new System.EventHandler(this.Android_apk_Click);
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
            this.android_play.Click += new System.EventHandler(this.Android_play_Click);
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
            this.android_allow.CheckedChanged += new System.EventHandler(this.Android_allow_CheckedChanged);
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
            // ServerTasks_TabPage
            // 
            this.ServerTasks_TabPage.BackColor = System.Drawing.SystemColors.Control;
            this.ServerTasks_TabPage.Controls.Add(this.Auto_Restarts_GroupBox);
            this.ServerTasks_TabPage.Controls.Add(this.Server_Commands_GroupBox);
            this.ServerTasks_TabPage.Controls.Add(this.Whitelist_GroupBox);
            this.ServerTasks_TabPage.ImageIndex = 7;
            this.ServerTasks_TabPage.Location = new System.Drawing.Point(47, 4);
            this.ServerTasks_TabPage.Name = "ServerTasks_TabPage";
            this.ServerTasks_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ServerTasks_TabPage.Size = new System.Drawing.Size(908, 684);
            this.ServerTasks_TabPage.TabIndex = 12;
            this.ServerTasks_TabPage.Text = " ";
            // 
            // Auto_Restarts_GroupBox
            // 
            this.Auto_Restarts_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Auto_Restarts_GroupBox.Controls.Add(this.Warn_Before_Restart_CheckBox);
            this.Auto_Restarts_GroupBox.Controls.Add(this.Enable_Auto_Restarts_CheckBox);
            this.Auto_Restarts_GroupBox.Controls.Add(this.Auto_Restart_Time_TrackBar);
            this.Auto_Restarts_GroupBox.Location = new System.Drawing.Point(8, 8);
            this.Auto_Restarts_GroupBox.Name = "Auto_Restarts_GroupBox";
            this.Auto_Restarts_GroupBox.Size = new System.Drawing.Size(893, 65);
            this.Auto_Restarts_GroupBox.TabIndex = 34;
            this.Auto_Restarts_GroupBox.TabStop = false;
            this.Auto_Restarts_GroupBox.Text = "Auto Restarts";
            // 
            // Warn_Before_Restart_CheckBox
            // 
            this.Warn_Before_Restart_CheckBox.AutoSize = true;
            this.Warn_Before_Restart_CheckBox.Checked = true;
            this.Warn_Before_Restart_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Warn_Before_Restart_CheckBox.Enabled = false;
            this.Warn_Before_Restart_CheckBox.Location = new System.Drawing.Point(9, 42);
            this.Warn_Before_Restart_CheckBox.Name = "Warn_Before_Restart_CheckBox";
            this.Warn_Before_Restart_CheckBox.Size = new System.Drawing.Size(166, 17);
            this.Warn_Before_Restart_CheckBox.TabIndex = 10;
            this.Warn_Before_Restart_CheckBox.Text = "Warn Players Before Restart?";
            this.Warn_Before_Restart_CheckBox.UseVisualStyleBackColor = true;
            this.Warn_Before_Restart_CheckBox.CheckedChanged += new System.EventHandler(this.Reset_chat_CheckedChanged);
            // 
            // Enable_Auto_Restarts_CheckBox
            // 
            this.Enable_Auto_Restarts_CheckBox.AutoSize = true;
            this.Enable_Auto_Restarts_CheckBox.Location = new System.Drawing.Point(9, 19);
            this.Enable_Auto_Restarts_CheckBox.Name = "Enable_Auto_Restarts_CheckBox";
            this.Enable_Auto_Restarts_CheckBox.Size = new System.Drawing.Size(126, 17);
            this.Enable_Auto_Restarts_CheckBox.TabIndex = 9;
            this.Enable_Auto_Restarts_CheckBox.Text = "Enable Auto Restarts";
            this.Enable_Auto_Restarts_CheckBox.UseVisualStyleBackColor = true;
            this.Enable_Auto_Restarts_CheckBox.CheckedChanged += new System.EventHandler(this.Reset_enabled_CheckedChanged);
            // 
            // Auto_Restart_Time_TrackBar
            // 
            this.Auto_Restart_Time_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Auto_Restart_Time_TrackBar.Enabled = false;
            this.Auto_Restart_Time_TrackBar.Location = new System.Drawing.Point(220, 14);
            this.Auto_Restart_Time_TrackBar.Maximum = 48;
            this.Auto_Restart_Time_TrackBar.Minimum = 1;
            this.Auto_Restart_Time_TrackBar.Name = "Auto_Restart_Time_TrackBar";
            this.Auto_Restart_Time_TrackBar.Size = new System.Drawing.Size(667, 45);
            this.Auto_Restart_Time_TrackBar.TabIndex = 8;
            this.Auto_Restart_Time_TrackBar.Value = 16;
            this.Auto_Restart_Time_TrackBar.Scroll += new System.EventHandler(this.Reset_time_Scroll);
            // 
            // Server_Commands_GroupBox
            // 
            this.Server_Commands_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Server_Commands_GroupBox.Controls.Add(this.Server_Commands_Say_Switch_CheckBox);
            this.Server_Commands_GroupBox.Controls.Add(this.Server_Commands_Note_Label);
            this.Server_Commands_GroupBox.Controls.Add(this.Server_Commands_List_RichTextBox);
            this.Server_Commands_GroupBox.Controls.Add(this.Server_Commands_Delay_GroupBox);
            this.Server_Commands_GroupBox.Location = new System.Drawing.Point(8, 173);
            this.Server_Commands_GroupBox.Name = "Server_Commands_GroupBox";
            this.Server_Commands_GroupBox.Size = new System.Drawing.Size(893, 505);
            this.Server_Commands_GroupBox.TabIndex = 33;
            this.Server_Commands_GroupBox.TabStop = false;
            this.Server_Commands_GroupBox.Text = "Send Commands To Server";
            // 
            // Server_Commands_Say_Switch_CheckBox
            // 
            this.Server_Commands_Say_Switch_CheckBox.AutoSize = true;
            this.Server_Commands_Say_Switch_CheckBox.Location = new System.Drawing.Point(9, 32);
            this.Server_Commands_Say_Switch_CheckBox.Name = "Server_Commands_Say_Switch_CheckBox";
            this.Server_Commands_Say_Switch_CheckBox.Size = new System.Drawing.Size(170, 17);
            this.Server_Commands_Say_Switch_CheckBox.TabIndex = 4;
            this.Server_Commands_Say_Switch_CheckBox.Text = "Add \"say\" To Every Command";
            this.Server_Commands_Say_Switch_CheckBox.UseVisualStyleBackColor = true;
            this.Server_Commands_Say_Switch_CheckBox.CheckedChanged += new System.EventHandler(this.Spam_is_spam_CheckedChanged);
            // 
            // Server_Commands_Note_Label
            // 
            this.Server_Commands_Note_Label.AutoSize = true;
            this.Server_Commands_Note_Label.Location = new System.Drawing.Point(6, 16);
            this.Server_Commands_Note_Label.Name = "Server_Commands_Note_Label";
            this.Server_Commands_Note_Label.Size = new System.Drawing.Size(499, 13);
            this.Server_Commands_Note_Label.TabIndex = 1;
            this.Server_Commands_Note_Label.Text = "Commands Written Here Will Be Sent to The Server. Each Command Should Be Written " +
    "On A New Line.";
            // 
            // Server_Commands_List_RichTextBox
            // 
            this.Server_Commands_List_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Server_Commands_List_RichTextBox.Location = new System.Drawing.Point(9, 54);
            this.Server_Commands_List_RichTextBox.Name = "Server_Commands_List_RichTextBox";
            this.Server_Commands_List_RichTextBox.Size = new System.Drawing.Size(878, 372);
            this.Server_Commands_List_RichTextBox.TabIndex = 0;
            this.Server_Commands_List_RichTextBox.Text = "";
            this.Server_Commands_List_RichTextBox.TextChanged += new System.EventHandler(this.Spam_list_TextChanged);
            // 
            // Server_Commands_Delay_GroupBox
            // 
            this.Server_Commands_Delay_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Server_Commands_Delay_GroupBox.Controls.Add(this.Server_Commands_Time_TrackBar);
            this.Server_Commands_Delay_GroupBox.Location = new System.Drawing.Point(9, 432);
            this.Server_Commands_Delay_GroupBox.Name = "Server_Commands_Delay_GroupBox";
            this.Server_Commands_Delay_GroupBox.Size = new System.Drawing.Size(878, 67);
            this.Server_Commands_Delay_GroupBox.TabIndex = 3;
            this.Server_Commands_Delay_GroupBox.TabStop = false;
            this.Server_Commands_Delay_GroupBox.Text = "Delay Between Commands";
            // 
            // Server_Commands_Time_TrackBar
            // 
            this.Server_Commands_Time_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Server_Commands_Time_TrackBar.Location = new System.Drawing.Point(6, 19);
            this.Server_Commands_Time_TrackBar.Maximum = 240;
            this.Server_Commands_Time_TrackBar.Minimum = 1;
            this.Server_Commands_Time_TrackBar.Name = "Server_Commands_Time_TrackBar";
            this.Server_Commands_Time_TrackBar.Size = new System.Drawing.Size(866, 45);
            this.Server_Commands_Time_TrackBar.TabIndex = 2;
            this.Server_Commands_Time_TrackBar.Value = 1;
            this.Server_Commands_Time_TrackBar.Scroll += new System.EventHandler(this.Spam_time_Scroll);
            // 
            // Whitelist_GroupBox
            // 
            this.Whitelist_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Whitelist_GroupBox.Controls.Add(this.Use_Whitelist_CheckBox);
            this.Whitelist_GroupBox.Controls.Add(this.Auto_Update_Whitelist_Text_Label);
            this.Whitelist_GroupBox.Controls.Add(this.Update_Whitelist_Interval_TextBox);
            this.Whitelist_GroupBox.Controls.Add(this.Auto_Update_Whitelist_CheckBox);
            this.Whitelist_GroupBox.Controls.Add(this.Auto_Update_External_Whitelist_Note_Label);
            this.Whitelist_GroupBox.Controls.Add(this.Auto_Update_External_Whitelist_URL_TextBox);
            this.Whitelist_GroupBox.Location = new System.Drawing.Point(8, 79);
            this.Whitelist_GroupBox.Name = "Whitelist_GroupBox";
            this.Whitelist_GroupBox.Size = new System.Drawing.Size(893, 88);
            this.Whitelist_GroupBox.TabIndex = 35;
            this.Whitelist_GroupBox.TabStop = false;
            this.Whitelist_GroupBox.Text = "Whitelist";
            // 
            // Use_Whitelist_CheckBox
            // 
            this.Use_Whitelist_CheckBox.AutoSize = true;
            this.Use_Whitelist_CheckBox.Location = new System.Drawing.Point(9, 19);
            this.Use_Whitelist_CheckBox.Name = "Use_Whitelist_CheckBox";
            this.Use_Whitelist_CheckBox.Size = new System.Drawing.Size(532, 17);
            this.Use_Whitelist_CheckBox.TabIndex = 5;
            this.Use_Whitelist_CheckBox.Text = "Use whitelist (File must be put in main game folder, named whitelist.txt. Every n" +
    "ickname must be in new line.)";
            this.Use_Whitelist_CheckBox.UseVisualStyleBackColor = true;
            this.Use_Whitelist_CheckBox.CheckedChanged += new System.EventHandler(this.Use_wl_CheckedChanged);
            // 
            // Auto_Update_Whitelist_Text_Label
            // 
            this.Auto_Update_Whitelist_Text_Label.AutoSize = true;
            this.Auto_Update_Whitelist_Text_Label.Location = new System.Drawing.Point(198, 44);
            this.Auto_Update_Whitelist_Text_Label.Name = "Auto_Update_Whitelist_Text_Label";
            this.Auto_Update_Whitelist_Text_Label.Size = new System.Drawing.Size(148, 13);
            this.Auto_Update_Whitelist_Text_Label.TabIndex = 4;
            this.Auto_Update_Whitelist_Text_Label.Text = "Minutes From External Server:";
            // 
            // Update_Whitelist_Interval_TextBox
            // 
            this.Update_Whitelist_Interval_TextBox.Location = new System.Drawing.Point(165, 41);
            this.Update_Whitelist_Interval_TextBox.Name = "Update_Whitelist_Interval_TextBox";
            this.Update_Whitelist_Interval_TextBox.Size = new System.Drawing.Size(27, 20);
            this.Update_Whitelist_Interval_TextBox.TabIndex = 3;
            this.Update_Whitelist_Interval_TextBox.Text = "60";
            this.Update_Whitelist_Interval_TextBox.TextChanged += new System.EventHandler(this.Wl_interval_TextChanged);
            // 
            // Auto_Update_Whitelist_CheckBox
            // 
            this.Auto_Update_Whitelist_CheckBox.AutoSize = true;
            this.Auto_Update_Whitelist_CheckBox.Location = new System.Drawing.Point(9, 43);
            this.Auto_Update_Whitelist_CheckBox.Name = "Auto_Update_Whitelist_CheckBox";
            this.Auto_Update_Whitelist_CheckBox.Size = new System.Drawing.Size(159, 17);
            this.Auto_Update_Whitelist_CheckBox.TabIndex = 2;
            this.Auto_Update_Whitelist_CheckBox.Text = "Auto Update Whitelist Every";
            this.Auto_Update_Whitelist_CheckBox.UseVisualStyleBackColor = true;
            this.Auto_Update_Whitelist_CheckBox.CheckedChanged += new System.EventHandler(this.Wl_chk_CheckedChanged);
            // 
            // Auto_Update_External_Whitelist_Note_Label
            // 
            this.Auto_Update_External_Whitelist_Note_Label.AutoSize = true;
            this.Auto_Update_External_Whitelist_Note_Label.Location = new System.Drawing.Point(342, 63);
            this.Auto_Update_External_Whitelist_Note_Label.Name = "Auto_Update_External_Whitelist_Note_Label";
            this.Auto_Update_External_Whitelist_Note_Label.Size = new System.Drawing.Size(398, 13);
            this.Auto_Update_External_Whitelist_Note_Label.TabIndex = 1;
            this.Auto_Update_External_Whitelist_Note_Label.Text = "(Put direct address to whitelist.txt file. Don\'t forget to put http(s):// on the " +
    "beginning)";
            // 
            // Auto_Update_External_Whitelist_URL_TextBox
            // 
            this.Auto_Update_External_Whitelist_URL_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Auto_Update_External_Whitelist_URL_TextBox.Location = new System.Drawing.Point(347, 41);
            this.Auto_Update_External_Whitelist_URL_TextBox.Name = "Auto_Update_External_Whitelist_URL_TextBox";
            this.Auto_Update_External_Whitelist_URL_TextBox.Size = new System.Drawing.Size(542, 20);
            this.Auto_Update_External_Whitelist_URL_TextBox.TabIndex = 0;
            this.Auto_Update_External_Whitelist_URL_TextBox.Text = "http://";
            this.Auto_Update_External_Whitelist_URL_TextBox.TextChanged += new System.EventHandler(this.Wl_add_TextChanged);
            // 
            // Backups_TabPage
            // 
            this.Backups_TabPage.BackColor = System.Drawing.SystemColors.Control;
            this.Backups_TabPage.Controls.Add(this.restore_backup_g);
            this.Backups_TabPage.Controls.Add(this.ex_backup);
            this.Backups_TabPage.Controls.Add(this.auto_backup_group);
            this.Backups_TabPage.ImageIndex = 8;
            this.Backups_TabPage.Location = new System.Drawing.Point(47, 4);
            this.Backups_TabPage.Name = "Backups_TabPage";
            this.Backups_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Backups_TabPage.Size = new System.Drawing.Size(908, 684);
            this.Backups_TabPage.TabIndex = 14;
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
            this.opeb_bp_dir.Click += new System.EventHandler(this.Opeb_bp_dir_Click);
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
            this.create_bp_now.Click += new System.EventHandler(this.Create_bp_now_Click);
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
            this.backup_del.Click += new System.EventHandler(this.Backup_del_Click);
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
            this.backup_refresh.Click += new System.EventHandler(this.Backup_refresh_Click);
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
            this.restore_now.Click += new System.EventHandler(this.Restore_now_Click);
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
            this.rem_old_backups_count.TextChanged += new System.EventHandler(this.Rem_old_backups_count_TextChanged);
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
            this.rem_old_backups.CheckedChanged += new System.EventHandler(this.Rem_old_backups_CheckedChanged);
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
            // Rewards_TabPage
            // 
            this.Rewards_TabPage.BackColor = System.Drawing.SystemColors.Control;
            this.Rewards_TabPage.Controls.Add(this.deds_g);
            this.Rewards_TabPage.ImageIndex = 9;
            this.Rewards_TabPage.Location = new System.Drawing.Point(47, 4);
            this.Rewards_TabPage.Name = "Rewards_TabPage";
            this.Rewards_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Rewards_TabPage.Size = new System.Drawing.Size(908, 684);
            this.Rewards_TabPage.TabIndex = 15;
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
            this.dtds_show.CheckedChanged += new System.EventHandler(this.Dtds_show_CheckedChanged);
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
            this.dtds_auth.TextChanged += new System.EventHandler(this.Dtds_auth_TextChanged);
            // 
            // dtds_rem
            // 
            this.dtds_rem.Location = new System.Drawing.Point(195, 310);
            this.dtds_rem.Name = "dtds_rem";
            this.dtds_rem.Size = new System.Drawing.Size(100, 23);
            this.dtds_rem.TabIndex = 7;
            this.dtds_rem.Text = "Remove selected";
            this.dtds_rem.UseVisualStyleBackColor = true;
            this.dtds_rem.Click += new System.EventHandler(this.Dtds_rem_Click);
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
            this.dtds_add.Click += new System.EventHandler(this.Dtds_add_Click);
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
            this.dtds_enable.CheckedChanged += new System.EventHandler(this.Dtds_enable_CheckedChanged);
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
            this.dtds_visit.Click += new System.EventHandler(this.Dtds_visit_Click);
            // 
            // server_startup_tasks
            // 
            this.server_startup_tasks.WorkerSupportsCancellation = true;
            this.server_startup_tasks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Work_after_start_DoWork);
            // 
            // telnet_connection
            // 
            this.telnet_connection.WorkerSupportsCancellation = true;
            this.telnet_connection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Telnet_connection_DoWork);
            // 
            // workers_list
            // 
            this.workers_list.WorkerSupportsCancellation = true;
            this.workers_list.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Taskman_worker_DoWork);
            // 
            // auto_messages
            // 
            this.auto_messages.WorkerSupportsCancellation = true;
            this.auto_messages.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Spamer_DoWork);
            // 
            // sql_exporter
            // 
            this.sql_exporter.WorkerSupportsCancellation = true;
            this.sql_exporter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Sql_exporter_DoWork);
            // 
            // auto_backup
            // 
            this.auto_backup.WorkerSupportsCancellation = true;
            this.auto_backup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Auto_backup_DoWork);
            // 
            // auto_reset
            // 
            this.auto_reset.WorkerSupportsCancellation = true;
            this.auto_reset.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Auto_reset_DoWork);
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
            this.custom_cmd_executor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Custom_cmd_executor_DoWork);
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
            this.autoupdate_whitelist.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Autoupdate_whitelist_DoWork);
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
            this.check_updates.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Check_updates_DoWork);
            // 
            // prepare_app_after_draw
            // 
            this.prepare_app_after_draw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Prepare_app_after_draw_DoWork);
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
            this.dbg_btn.Click += new System.EventHandler(this.Dbg_btn_Click);
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
            this.dbg_btn_2.Click += new System.EventHandler(this.Dbg_btn_2_Click);
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
            this.help_b.Click += new System.EventHandler(this.Help_b_Click);
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
            this.contact_b.Click += new System.EventHandler(this.Contact_b_Click);
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
            this.www7dsm.Click += new System.EventHandler(this.Button1_Click_3);
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
            this.discord_b.Click += new System.EventHandler(this.Discord_b_Click);
            // 
            // Mods_TabPage
            // 
            this.Mods_TabPage.Location = new System.Drawing.Point(47, 4);
            this.Mods_TabPage.Name = "Mods_TabPage";
            this.Mods_TabPage.Size = new System.Drawing.Size(908, 684);
            this.Mods_TabPage.TabIndex = 19;
            this.Mods_TabPage.UseVisualStyleBackColor = true;
            // 
            // Private_IP_Address_Label
            // 
            this.Private_IP_Address_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Private_IP_Address_Label.AutoSize = true;
            this.Private_IP_Address_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Private_IP_Address_Label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Private_IP_Address_Label.Location = new System.Drawing.Point(6, 80);
            this.Private_IP_Address_Label.Name = "Private_IP_Address_Label";
            this.Private_IP_Address_Label.Size = new System.Drawing.Size(99, 13);
            this.Private_IP_Address_Label.TabIndex = 24;
            this.Private_IP_Address_Label.Text = "Getting Private IP...";
            this.Private_IP_Address_Label.Visible = false;
            // 
            // Server_Panel_Form
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
            this.Name = "Server_Panel_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7 Days Server Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_Panel_FormClosing);
            this.Load += new System.EventHandler(this.Server_panel_Load);
            this.Shown += new System.EventHandler(this.Server_panel_Shown);
            this.Resize += new System.EventHandler(this.Server_panel_Resize);
            this.Settings_TabPage.ResumeLayout(false);
            this.Settings_TabPage.PerformLayout();
            this.Updates_GroupBox.ResumeLayout(false);
            this.Updates_GroupBox.PerformLayout();
            this.exe_settings_g.ResumeLayout(false);
            this.exe_settings_g.PerformLayout();
            this.Supporter_Settings_GroupBox.ResumeLayout(false);
            this.Supporter_Settings_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Premium_Settings_Help_PictureBox)).EndInit();
            this.Supporter_GroupBox.ResumeLayout(false);
            this.Supporter_GroupBox.PerformLayout();
            this.SQL_GroupBox.ResumeLayout(false);
            this.SQL_GroupBox.PerformLayout();
            this.SQL_Update_Time_GroupBox.ResumeLayout(false);
            this.SQL_Update_Time_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQL_Update_Time_Info_PictureBox)).EndInit();
            this.SQL_Host_GroupBox.ResumeLayout(false);
            this.SQL_Host_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQL_Host_Info_PictureBox)).EndInit();
            this.SQL_Username_GroupBox.ResumeLayout(false);
            this.SQL_Username_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQL_Username_Info_PictureBox)).EndInit();
            this.SQL_DB_Name_GroupBox.ResumeLayout(false);
            this.SQL_DB_Name_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQL_Database_Name_Info_PictureBox)).EndInit();
            this.SQL_Password_GroupBox.ResumeLayout(false);
            this.SQL_Password_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQL_Password_Info_PictureBox)).EndInit();
            this.Settings_GroupBox.ResumeLayout(false);
            this.Settings_GroupBox.PerformLayout();
            this.auto_backup_group.ResumeLayout(false);
            this.auto_backup_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backup_time)).EndInit();
            this.Spawn_GroupBox.ResumeLayout(false);
            this.Game_Time_Controls_GroupBox.ResumeLayout(false);
            this.Game_Time_Controls_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Day_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Hour_TrackBar)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ManageServer_TabPage.ResumeLayout(false);
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
            this.PlayerManagement_TabPage.ResumeLayout(false);
            this.PlayerManagement_TabPage.PerformLayout();
            this.Chat_GroupBox.ResumeLayout(false);
            this.Chat_GroupBox.PerformLayout();
            this.Player_GroupBox.ResumeLayout(false);
            this.Kick_GroupBox.ResumeLayout(false);
            this.Ban_GroupBox.ResumeLayout(false);
            this.Ban_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ban_Slider_TrackBar)).EndInit();
            this.GameSettings_TabPage.ResumeLayout(false);
            this.main_page_opts.ResumeLayout(false);
            this.game_opts.ResumeLayout(false);
            this.Drop_On_Quit_GroupBox.ResumeLayout(false);
            this.Drop_On_Quit_GroupBox.PerformLayout();
            this.Server_Reserved_Slots_GroupBox.ResumeLayout(false);
            this.Server_Reserved_Slots_GroupBox.PerformLayout();
            this.Player_Killing_Mode_GroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Spawn_Settings_GroupBox.ResumeLayout(false);
            this.Spawn_Settings_GroupBox.PerformLayout();
            this.Air_Drop_Frequency_GroupBox.ResumeLayout(false);
            this.Air_Drop_Frequency_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Air_Drop_Frequency_TrackBar)).EndInit();
            this.Land_Claim_GroupBox.ResumeLayout(false);
            this.Land_Claim_Decay_Mode_GroupBox.ResumeLayout(false);
            this.Land_Claim_Decay_Mode_GroupBox.PerformLayout();
            this.Land_Claim_Durability_Modifier_GroupBox.ResumeLayout(false);
            this.Land_Claim_Durability_Modifier_GroupBox.PerformLayout();
            this.Land_Claim_Size_GroupBox.ResumeLayout(false);
            this.Land_Claim_Size_GroupBox.PerformLayout();
            this.Land_Claim_Dead_Zone_GroupBox.ResumeLayout(false);
            this.Land_Claim_Dead_Zone_GroupBox.PerformLayout();
            this.Land_Claim_Expiry_Time_GroupBox.ResumeLayout(false);
            this.Land_Claim_Expiry_Time_GroupBox.PerformLayout();
            this.Loot_Respawn_Days_GroupBox.ResumeLayout(false);
            this.Loot_Respawn_Days_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LootRespawnDays)).EndInit();
            this.Loot_Abundance_GroupBox.ResumeLayout(false);
            this.Loot_Abundance_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LootAbundance)).EndInit();
            this.Max_Players_GroupBox.ResumeLayout(false);
            this.Max_Players_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxpl)).EndInit();
            this.Game_Mode_Settings_GroupBox.ResumeLayout(false);
            this.Game_Mode_Settings_GroupBox.PerformLayout();
            this.Zombie_Settings_GroupBox.ResumeLayout(false);
            this.Zombie_Settings_GroupBox.PerformLayout();
            this.nightpercentage_g.ResumeLayout(false);
            this.nightpercentage_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nightpercentage)).EndInit();
            this.Day_Length_GroupBox.ResumeLayout(false);
            this.Day_Length_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayLength)).EndInit();
            this.bdm_g.ResumeLayout(false);
            this.bdm_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdm)).EndInit();
            this.Drop_On_Death_Group_Box.ResumeLayout(false);
            this.Drop_On_Death_Group_Box.PerformLayout();
            this.Game_Difficulty_GroupBox.ResumeLayout(false);
            this.Game_Difficulty_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Difficulty_TrackBar)).EndInit();
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
            this.Messaging_TabPage.ResumeLayout(false);
            this.Server_Chat_Messages_GroupBox.ResumeLayout(false);
            this.Server_Chat_Messages_GroupBox.PerformLayout();
            this.Custom_Commands_GroupBox.ResumeLayout(false);
            this.Custom_Commands_GroupBox.PerformLayout();
            this.GlobalBanList_TabPage.ResumeLayout(false);
            this.global_ban_g.ResumeLayout(false);
            this.global_ban_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banlist_logo)).EndInit();
            this.WebServer_TabPage.ResumeLayout(false);
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
            this.ServerTasks_TabPage.ResumeLayout(false);
            this.Auto_Restarts_GroupBox.ResumeLayout(false);
            this.Auto_Restarts_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Auto_Restart_Time_TrackBar)).EndInit();
            this.Server_Commands_GroupBox.ResumeLayout(false);
            this.Server_Commands_GroupBox.PerformLayout();
            this.Server_Commands_Delay_GroupBox.ResumeLayout(false);
            this.Server_Commands_Delay_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Server_Commands_Time_TrackBar)).EndInit();
            this.Whitelist_GroupBox.ResumeLayout(false);
            this.Whitelist_GroupBox.PerformLayout();
            this.Backups_TabPage.ResumeLayout(false);
            this.restore_backup_g.ResumeLayout(false);
            this.ex_backup.ResumeLayout(false);
            this.ex_backup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prem_help2)).EndInit();
            this.Rewards_TabPage.ResumeLayout(false);
            this.deds_g.ResumeLayout(false);
            this.deds_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker status_updater;
        private System.Windows.Forms.FolderBrowserDialog Select_Game_Directory;
        private System.Windows.Forms.NotifyIcon App_Icon;
        private System.Windows.Forms.PictureBox img_status;
        private System.Windows.Forms.Label Public_IP_Address_Label;
        private System.Windows.Forms.TabPage Settings_TabPage;
        private System.Windows.Forms.GroupBox Settings_GroupBox;
        private System.Windows.Forms.Button Change_Game_File_Path_Button;
        private System.Windows.Forms.Label Game_File_Path_Label;
        private System.Windows.Forms.CheckBox Settings_Send_To_Tray_CheckBox;
        private System.Windows.Forms.Button About_Button;
        private System.Windows.Forms.GroupBox Spawn_GroupBox;
        private System.Windows.Forms.Button Spawn_Item_Button;
        private System.Windows.Forms.ComboBox Spawn_Item_ComboBox;
        private System.Windows.Forms.GroupBox Game_Time_Controls_GroupBox;
        private System.Windows.Forms.Label godzina;
        private System.Windows.Forms.TrackBar Game_Hour_TrackBar;
        private System.Windows.Forms.Label dzien;
        private System.Windows.Forms.TrackBar Game_Day_TrackBar;
        private System.Windows.Forms.Button Set_Game_Time_Button;
        private System.Windows.Forms.TextBox cmd;
        private System.Windows.Forms.RichTextBox Console_RichTextBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.ComponentModel.BackgroundWorker server_startup_tasks;
        private System.Windows.Forms.ImageList Header_Icons;
        private System.Windows.Forms.TabPage PlayerManagement_TabPage;
        private System.Windows.Forms.Button Kick_Player_Button;
        private System.Windows.Forms.Button Ban_Hammer_Button;
        private System.Windows.Forms.ProgressBar startbar;
        private System.Windows.Forms.ComboBox Kick_Reason_ComboBox;
        private System.Windows.Forms.TabPage ManageServer_TabPage;
        private System.ComponentModel.BackgroundWorker telnet_connection;
        private System.Windows.Forms.ListBox taskman;
        private System.ComponentModel.BackgroundWorker workers_list;
        private System.Windows.Forms.Label workerynapis;
        private System.Windows.Forms.ComboBox Ban_Time_ComboBox;
        private System.Windows.Forms.GroupBox Kick_GroupBox;
        private System.Windows.Forms.GroupBox Ban_GroupBox;
        private System.Windows.Forms.TrackBar Ban_Slider_TrackBar;
        private System.Windows.Forms.GroupBox Console_Group;
        private System.Windows.Forms.CheckBox Settings_Always_On_Top_CheckBox;
        private System.Windows.Forms.Button blad;
        private System.Windows.Forms.Button Auto_Detect_Game_File_Path_Button;
        private System.ComponentModel.BackgroundWorker auto_messages;
        private System.Windows.Forms.RichTextBox Server_Commands_List_RichTextBox;
        private System.Windows.Forms.Label Server_Commands_Note_Label;
        private System.Windows.Forms.TrackBar Server_Commands_Time_TrackBar;
        private System.Windows.Forms.GroupBox Server_Commands_Delay_GroupBox;
        private System.Windows.Forms.CheckBox Settings_Show_IPS_CheckBox;
        private System.Windows.Forms.CheckBox Settings_Clean_Exit_CheckBox;
        private System.Windows.Forms.GroupBox Server_Controls_Group;
        private System.Windows.Forms.CheckBox Save_Logs_CheckBox;
        private System.Windows.Forms.Button Shutdown_Server_Button;
        private System.Windows.Forms.Button Start_Server_Button;
        private System.Windows.Forms.Button Kill_Server_Process;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.CheckBox Settings_Allow_Anon_Data_CheckBox;
        private System.Windows.Forms.LinkLabel anon_data_2;
        private System.Windows.Forms.GroupBox SQL_DB_Name_GroupBox;
        private System.Windows.Forms.TextBox SQL_Database_Name_TextBox;
        private System.Windows.Forms.GroupBox SQL_Password_GroupBox;
        private System.Windows.Forms.TextBox SQL_Password_TextBox;
        private System.Windows.Forms.GroupBox SQL_Username_GroupBox;
        private System.Windows.Forms.TextBox SQL_Username_TextBox;
        private System.Windows.Forms.GroupBox SQL_Host_GroupBox;
        private System.Windows.Forms.TextBox SQL_Host_TextBox;
        private System.Windows.Forms.CheckBox SQL_Enabled_CheckBox;
        private System.ComponentModel.BackgroundWorker sql_exporter;
        private System.Windows.Forms.Label SQL_Encrption_Warning_Label;
        private System.Windows.Forms.Label SQL_Update_Time_Label;
        private System.Windows.Forms.Button SQL_How_To_Integrate_Button;
        private System.Windows.Forms.GroupBox SQL_Update_Time_GroupBox;
        private System.Windows.Forms.TextBox SQL_Update_Time_TextBox;
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
        private System.Windows.Forms.TabPage GameSettings_TabPage;
        private System.Windows.Forms.TabControl main_page_opts;
        private System.Windows.Forms.TabPage server_opts;
        private System.Windows.Forms.TabPage game_opts;
        private System.Windows.Forms.GroupBox bdm_g;
        private System.Windows.Forms.TrackBar bdm;
        private System.Windows.Forms.GroupBox Drop_On_Death_Group_Box;
        private System.Windows.Forms.RadioButton Drop_On_Death_Mode_0;
        private System.Windows.Forms.RadioButton Drop_On_Death_Mode_1;
        private System.Windows.Forms.RadioButton Drop_On_Death_Mode_2;
        private System.Windows.Forms.RadioButton Drop_On_Death_Mode_3;
        private System.Windows.Forms.RadioButton Drop_On_Quit_Mode_3;
        private System.Windows.Forms.RadioButton Drop_On_Quit_Mode_2;
        private System.Windows.Forms.RadioButton Drop_On_Quit_Mode_1;
        private System.Windows.Forms.RadioButton Drop_On_Quit_Mode_0;
        private System.Windows.Forms.GroupBox Game_Difficulty_GroupBox;
        private System.Windows.Forms.TrackBar Game_Difficulty_TrackBar;
        private System.Windows.Forms.GroupBox nazwamapa;
        private System.Windows.Forms.ComboBox gamename;
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
        private System.Windows.Forms.GroupBox Day_Length_GroupBox;
        private System.Windows.Forms.CheckBox realtime;
        private System.Windows.Forms.TrackBar dayLength;
        private System.Windows.Forms.GroupBox autobots;
        private System.Windows.Forms.GroupBox Game_Mode_Settings_GroupBox;
        private System.Windows.Forms.CheckBox cheatmode;
        private System.Windows.Forms.RadioButton gamemode_coop;
        private System.Windows.Forms.GroupBox Zombie_Settings_GroupBox;
        private System.Windows.Forms.RadioButton zombie_never_run;
        private System.Windows.Forms.RadioButton zombie_normal;
        private System.Windows.Forms.RadioButton zombie_run;
        private System.Windows.Forms.GroupBox Max_Players_GroupBox;
        private System.Windows.Forms.GroupBox telnet_g;
        private System.Windows.Forms.Label telnet_port_l;
        private System.Windows.Forms.TextBox telnet_port_p;
        private System.Windows.Forms.Label telnet_psw_l;
        private System.Windows.Forms.TextBox telnet_psw;
        private System.Windows.Forms.TextBox AdminFileName;
        private System.Windows.Forms.GroupBox filename_g;
        private System.Windows.Forms.GroupBox Loot_Abundance_GroupBox;
        private System.Windows.Forms.TrackBar LootAbundance;
        private System.Windows.Forms.GroupBox Loot_Respawn_Days_GroupBox;
        private System.Windows.Forms.TrackBar LootRespawnDays;
        private System.Windows.Forms.Button sa_edit;
        private System.Windows.Forms.Button Browse_Game_File_Path_Button;
        private System.Windows.Forms.RadioButton gamemode_surv_pvp;
        private System.Windows.Forms.GroupBox Land_Claim_Dead_Zone_GroupBox;
        private System.Windows.Forms.TextBox Land_Claim_Dead_Zone_TextBox;
        private System.Windows.Forms.GroupBox Land_Claim_Size_GroupBox;
        private System.Windows.Forms.TextBox Land_Claim_Size_TextBox;
        private System.Windows.Forms.GroupBox Land_Claim_Durability_Modifier_GroupBox;
        private System.Windows.Forms.Label Land_Claim_Durability_Offline_Label;
        private System.Windows.Forms.Label Land_Claim_Durability_Online_Label;
        private System.Windows.Forms.TextBox LandClaimOfflineDurabilityModifier;
        private System.Windows.Forms.TextBox LandClaimOnlineDurabilityModifier;
        private System.Windows.Forms.GroupBox Land_Claim_Decay_Mode_GroupBox;
        private System.Windows.Forms.RadioButton Full_prot;
        private System.Windows.Forms.RadioButton Exponential;
        private System.Windows.Forms.RadioButton Linear;
        private System.Windows.Forms.GroupBox Land_Claim_Expiry_Time_GroupBox;
        private System.Windows.Forms.TextBox Land_Claim_Expiry_Time_TextBox;
        private System.Windows.Forms.GroupBox Land_Claim_GroupBox;
        private System.Windows.Forms.ColumnHeader login_header;
        private System.Windows.Forms.ColumnHeader steamid_header;
        private System.Windows.Forms.TabPage ServerTasks_TabPage;
        private System.Windows.Forms.GroupBox Server_Commands_GroupBox;
        private System.ComponentModel.BackgroundWorker auto_reset;
        private System.Windows.Forms.GroupBox Auto_Restarts_GroupBox;
        private System.Windows.Forms.CheckBox Warn_Before_Restart_CheckBox;
        private System.Windows.Forms.CheckBox Enable_Auto_Restarts_CheckBox;
        private System.Windows.Forms.TrackBar Auto_Restart_Time_TrackBar;
        private System.Windows.Forms.Label Auto_Restart_Timer;
        private System.Windows.Forms.Label Auto_Restart_Timer_Label;
        private System.Windows.Forms.GroupBox save_g;
        private System.Windows.Forms.TextBox save;
        private System.Windows.Forms.CheckBox Server_Commands_Say_Switch_CheckBox;
        private System.ComponentModel.BackgroundWorker stats;
        private System.Windows.Forms.GroupBox Air_Drop_Frequency_GroupBox;
        private System.Windows.Forms.TrackBar Air_Drop_Frequency_TrackBar;
        private System.Windows.Forms.CheckBox feral;
        private System.Windows.Forms.Button Connect_Running_Server_Button;
        private System.ComponentModel.BackgroundWorker reboot_telnet;
        private System.Windows.Forms.CheckBox VACEnabled;
        private System.Windows.Forms.GroupBox MaxSpawnedZombies_g;
        private System.Windows.Forms.TrackBar MaxSpawnedZombies;
        private System.Windows.Forms.GroupBox Chat_GroupBox;
        private System.Windows.Forms.RichTextBox Chat_RichTextBox;
        private System.Windows.Forms.TextBox Chat_Input_TextBox;
        private System.Windows.Forms.GroupBox SQL_GroupBox;
        private System.Windows.Forms.Label Reboot_Now_Message_Label;
        private System.Windows.Forms.Label Starting_Backup_Message_Label;
        private System.Windows.Forms.TextBox reboot;
        private System.Windows.Forms.TextBox Starting_Backup_Message_TextBox;
        private System.Windows.Forms.Label Time_Until_Reboot_Message_Label;
        private System.Windows.Forms.TextBox reboot_time;
        private System.Windows.Forms.Label Backup_Completed_Message_Label;
        private System.Windows.Forms.TextBox Backup_Completed_Message_TextBox;
        private System.Windows.Forms.GroupBox Server_Chat_Messages_GroupBox;
        private System.Windows.Forms.GroupBox Custom_Commands_GroupBox;
        private System.Windows.Forms.RichTextBox Custom_Commands_RichTextBox;
        private System.Windows.Forms.Button How_To_Commands_Button;
        private System.Windows.Forms.CheckBox Enable_Custom_Commands_CheckBox;
        private System.ComponentModel.BackgroundWorker custom_cmd_executor;
        private System.Windows.Forms.TextBox cmd_not_yet;
        private System.Windows.Forms.Label Command_Wait_Message_Label;
        private System.Windows.Forms.TabPage Messaging_TabPage;
        private System.Windows.Forms.GroupBox configfile_g;
        private System.Windows.Forms.Button configfile_e;
        private System.Windows.Forms.TextBox configfile;
        private System.Windows.Forms.GroupBox ServerWebsiteURL_g;
        private System.Windows.Forms.TextBox ServerWebsiteURL;
        private System.Windows.Forms.GroupBox ServerDescription_g;
        private System.Windows.Forms.TextBox ServerDescription;
        private System.Windows.Forms.CheckBox PersistentPlayerProfiles;
        private System.Windows.Forms.CheckBox Settings_Skip_Profiles_CheckBox;
        private System.ComponentModel.BackgroundWorker server_stop_tasks;
        private System.Windows.Forms.Button like;
        private System.Windows.Forms.GroupBox Spawn_Settings_GroupBox;
        private System.Windows.Forms.Label Player_Safe_Zone_Hours_Label;
        private System.Windows.Forms.Label Player_Safe_Zone_Level_Label;
        private System.Windows.Forms.TextBox Player_Safe_Zone_Hours_TextBox;
        private System.Windows.Forms.TextBox Player_Safe_Zone_Level_TextBox;
        private System.Windows.Forms.GroupBox MaxSpawnedAnimals_g;
        private System.Windows.Forms.TrackBar MaxSpawnedAnimals;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox Player_GroupBox;
        private System.Windows.Forms.Button Thirsty_Player_Button;
        private System.Windows.Forms.Button Starve_Player_Button;
        private System.Windows.Forms.Button Kill_Player_Button;
        private System.Windows.Forms.CheckBox debug_log;
        private System.Windows.Forms.Button www7dsm;
        private System.Windows.Forms.GroupBox Whitelist_GroupBox;
        private System.Windows.Forms.Label Auto_Update_Whitelist_Text_Label;
        private System.Windows.Forms.TextBox Update_Whitelist_Interval_TextBox;
        private System.Windows.Forms.CheckBox Auto_Update_Whitelist_CheckBox;
        private System.Windows.Forms.Label Auto_Update_External_Whitelist_Note_Label;
        private System.Windows.Forms.TextBox Auto_Update_External_Whitelist_URL_TextBox;
        private System.ComponentModel.BackgroundWorker autoupdate_whitelist;
        private System.Windows.Forms.CheckBox Use_Whitelist_CheckBox;
        private System.Windows.Forms.Label Whitelist_Update_Timer;
        private System.Windows.Forms.Label Whitelist_Update_Label;
        private System.Windows.Forms.CheckBox Start_7DSM_With_Windows_CheckBox;
        private System.Windows.Forms.CheckBox Start_With_7DSM_CheckBox;
        private System.Windows.Forms.Label don_l;
        private System.Windows.Forms.Label backup_location_l;
        private System.Windows.Forms.TextBox backup_location;
        private System.ComponentModel.BackgroundWorker check_updates;
        private System.ComponentModel.BackgroundWorker prepare_app_after_draw;
        private System.Windows.Forms.GroupBox Supporter_GroupBox;
        private System.Windows.Forms.Button Supporter_Activate_Button;
        private System.Windows.Forms.Label Supporter_Code_Label;
        private System.Windows.Forms.TextBox Support_Code_TextBox;
        private System.Windows.Forms.Label Supporter_Status_Label;
        private System.Windows.Forms.Button Supporter_Donate_Button;
        private System.Windows.Forms.Label Supporter_Instructions_Label;
        private System.Windows.Forms.CheckBox Support_Code_Show_CheckBox;
        private System.Windows.Forms.GroupBox Supporter_Settings_GroupBox;
        private System.Windows.Forms.PictureBox Premium_Settings_Help_PictureBox;
        private System.Windows.Forms.CheckBox Hide_Donation_Buttons_CheckBox;
        private System.Windows.Forms.TabPage Backups_TabPage;
        private System.Windows.Forms.GroupBox ex_backup;
        private System.Windows.Forms.PictureBox prem_help2;
        private System.Windows.Forms.Label rem_old_backups_l;
        private System.Windows.Forms.TextBox rem_old_backups_count;
        private System.Windows.Forms.CheckBox rem_old_backups;
        private System.Windows.Forms.TabPage Rewards_TabPage;
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
        private System.Windows.Forms.RadioButton Player_Killing_Mode_0;
        private System.Windows.Forms.RadioButton Player_Killing_Mode_1;
        private System.Windows.Forms.RadioButton Player_Killing_Mode_2;
        private System.Windows.Forms.RadioButton Player_Killing_Mode_3;
        private System.Windows.Forms.GroupBox Player_Killing_Mode_GroupBox;
        private System.Windows.Forms.CheckBox AirDropMarker;
        private System.Windows.Forms.Button help_b;
        private System.Windows.Forms.ListView All_Players_List;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label All_Players_Label;
        private System.Windows.Forms.Label Online_Players_Label;
        private System.Windows.Forms.Label Update_Channel_Label;
        private System.Windows.Forms.ComboBox Update_Channel_ComboBox;
        private System.Windows.Forms.GroupBox Updates_GroupBox;
        private System.Windows.Forms.Label updates_info;
        private System.Windows.Forms.GroupBox exe_settings_g;
        private System.Windows.Forms.Button Force_Update_Button;
        private System.Windows.Forms.Button Check_Updates_Button;
        private System.Windows.Forms.Button Apply_Update_Channel_Button;
        private System.Windows.Forms.TabPage GlobalBanList_TabPage;
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
        private System.Windows.Forms.TabPage WebServer_TabPage;
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
        private System.Windows.Forms.GroupBox Server_Reserved_Slots_GroupBox;
        private System.Windows.Forms.TextBox Server_Admin_Reserved_Slots_Permission;
        private System.Windows.Forms.Label Admin_Slot_Text_Label;
        private System.Windows.Forms.Label Admin_Reserve_Text_Label;
        private System.Windows.Forms.TextBox Server_Admin_Reserved_Slots;
        private System.Windows.Forms.TextBox Server_Player_Reserved_Slots_Permission;
        private System.Windows.Forms.Label Player_Slot_Text_Label;
        private System.Windows.Forms.Label Player_Reserve_Text_Label;
        private System.Windows.Forms.TextBox Server_Player_Reserved_Slots;
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
        private System.Windows.Forms.CheckBox Use_External_Call_CheckBox;
        private System.Windows.Forms.Label External_Call_File_Name_Label;
        private System.Windows.Forms.Button External_Call_File_Select_Button;
        private System.Windows.Forms.OpenFileDialog externalCallFile;
        private System.Windows.Forms.Button How_To_Use_External_Calls_Button;
        private System.Windows.Forms.Label Auto_Command_Timer;
        private System.Windows.Forms.GroupBox News_Group;
        private System.Windows.Forms.GroupBox Server_Status_Group;
        private System.Windows.Forms.RichTextBox News_Feed_RichTextBox;
        private System.Windows.Forms.SplitContainer overviewSplitter;
        private System.Windows.Forms.Button zoomup;
        private System.Windows.Forms.Label OS_Version_Label;
        private System.Windows.Forms.Label telnetstatus;
        private System.Windows.Forms.Label OS_Architecture_Label;
        private System.Windows.Forms.Button discord_b;
        private System.Windows.Forms.ListBox commandslist;
        private System.Windows.Forms.GroupBox CommandsGroup;
        private System.Windows.Forms.Button usecmd;
        private System.Windows.Forms.GroupBox Drop_On_Quit_GroupBox;
        private System.Windows.Forms.PictureBox SQL_Update_Time_Info_PictureBox;
        private System.Windows.Forms.PictureBox SQL_Host_Info_PictureBox;
        private System.Windows.Forms.PictureBox SQL_Username_Info_PictureBox;
        private System.Windows.Forms.PictureBox SQL_Database_Name_Info_PictureBox;
        private System.Windows.Forms.PictureBox SQL_Password_Info_PictureBox;
        private System.Windows.Forms.TabPage Mods_TabPage;
        private System.Windows.Forms.Label Private_IP_Address_Label;
    }
}