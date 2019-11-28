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
            this.Private_IP_Address_Label = new System.Windows.Forms.Label();
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
            this.ManagePlayers_TabPage = new System.Windows.Forms.TabPage();
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
            this.Game_Options_TabPage = new System.Windows.Forms.TabPage();
            this.XPMultiplier_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_XPMultiplier = new System.Windows.Forms.TrackBar();
            this.BlockDamageAI_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_BlockDamageAI = new System.Windows.Forms.TrackBar();
            this.Server_Reserved_Slots_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ServerAdminSlotsPermission = new System.Windows.Forms.TextBox();
            this.Admin_Slot_Text_Label = new System.Windows.Forms.Label();
            this.Admin_Reserve_Text_Label = new System.Windows.Forms.Label();
            this.ConfigProperty_ServerAdminSlots = new System.Windows.Forms.TextBox();
            this.ConfigProperty_ServerReservedSlotsPermission = new System.Windows.Forms.TextBox();
            this.Player_Slot_Text_Label = new System.Windows.Forms.Label();
            this.Player_Reserve_Text_Label = new System.Windows.Forms.Label();
            this.ConfigProperty_ServerReservedSlots = new System.Windows.Forms.TextBox();
            this.Player_Killing_Mode_GroupBox = new System.Windows.Forms.GroupBox();
            this.AirDropFrequency_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_AirDropFrequency = new System.Windows.Forms.TrackBar();
            this.Land_Claim_GroupBox = new System.Windows.Forms.GroupBox();
            this.BlockDamageAIBM_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_BlockDamageAIBM = new System.Windows.Forms.TrackBar();
            this.LandClaimDecayMode_GroupBox = new System.Windows.Forms.GroupBox();
            this.LandClaimDurabilityModifier_GroupBox = new System.Windows.Forms.GroupBox();
            this.Land_Claim_Durability_Offline_Label = new System.Windows.Forms.Label();
            this.Land_Claim_Durability_Online_Label = new System.Windows.Forms.Label();
            this.ConfigProperty_LandClaimOfflineDurabilityModifier = new System.Windows.Forms.TextBox();
            this.ConfigProperty_LandClaimOnlineDurabilityModifier = new System.Windows.Forms.TextBox();
            this.LandClaimSize_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_LandClaimSize = new System.Windows.Forms.TextBox();
            this.LandClaimDeadZone_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_LandClaimDeadZone = new System.Windows.Forms.TextBox();
            this.LandClaimExpiryTime_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_LandClaimExpiryTime = new System.Windows.Forms.TextBox();
            this.LootRespawnDays_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_LootRespawnDays = new System.Windows.Forms.TrackBar();
            this.LootAbundance_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_LootAbundance = new System.Windows.Forms.TrackBar();
            this.Max_Players_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ServerMaxPlayerCount = new System.Windows.Forms.TrackBar();
            this.Game_Mode_Settings_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_PersistentPlayerProfiles = new System.Windows.Forms.CheckBox();
            this.ConfigProperty_EnemyDifficulty = new System.Windows.Forms.CheckBox();
            this.ConfigProperty_BuildCreate = new System.Windows.Forms.CheckBox();
            this.DayLightLength_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_DayLightLength = new System.Windows.Forms.TrackBar();
            this.DayNightLength_GroupBox = new System.Windows.Forms.GroupBox();
            this.DayNightLength_Realtime_Mode = new System.Windows.Forms.CheckBox();
            this.ConfigProperty_DayNightLength = new System.Windows.Forms.TrackBar();
            this.BlockDamagePlayer_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_BlockDamagePlayer = new System.Windows.Forms.TrackBar();
            this.DropOnDeath_GroupBox = new System.Windows.Forms.GroupBox();
            this.GameDifficulty_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_GameDifficulty = new System.Windows.Forms.TrackBar();
            this.Server_Options_TabPage = new System.Windows.Forms.TabPage();
            this.Server_Login_Confirmation_Text_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ServerLoginConfirmationText = new System.Windows.Forms.RichTextBox();
            this.Server_Password_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ServerPassword = new System.Windows.Forms.TextBox();
            this.Server_Name_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ServerName = new System.Windows.Forms.TextBox();
            this.ServerWebsiteURL_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ServerWebsiteURL = new System.Windows.Forms.TextBox();
            this.ServerDescription_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ServerDescription = new System.Windows.Forms.TextBox();
            this.User_Data_Folder_GroupBox = new System.Windows.Forms.GroupBox();
            this.configfile_e = new System.Windows.Forms.Button();
            this.ConfigProperty_UserDataFolder = new System.Windows.Forms.TextBox();
            this.Save_Game_Folder_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_SaveGameFolder = new System.Windows.Forms.TextBox();
            this.Server_Admin_Config_File_GroupBox = new System.Windows.Forms.GroupBox();
            this.Server_Admin_Path_Selector_Button = new System.Windows.Forms.Button();
            this.ConfigProperty_AdminFileName = new System.Windows.Forms.TextBox();
            this.Game_World_Settings_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_GameMode = new System.Windows.Forms.ComboBox();
            this.ConfigProperty_WorldGenSize = new System.Windows.Forms.TrackBar();
            this.ConfigProperty_WorldGenSeed = new System.Windows.Forms.TextBox();
            this.ConfigProperty_GameName = new System.Windows.Forms.ComboBox();
            this.ConfigProperty_GameWorld = new System.Windows.Forms.ComboBox();
            this.ServerListAndPassword_GroupBox = new System.Windows.Forms.GroupBox();
            this.ServerPassword = new System.Windows.Forms.TextBox();
            this.ServerIsPublic = new System.Windows.Forms.CheckBox();
            this.Other_Game_Settings_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_EACEnabled = new System.Windows.Forms.CheckBox();
            this.Save_Logs_To_Files_CheckBox = new System.Windows.Forms.CheckBox();
            this.autobots = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_EnemySpawnMode = new System.Windows.Forms.CheckBox();
            this.BedrollDeadZoneSize_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_BedrollDeadZoneSize = new System.Windows.Forms.TrackBar();
            this.BloodMoonEnemyCount_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_BloodMoonEnemyCount = new System.Windows.Forms.TrackBar();
            this.AirDropMarker = new System.Windows.Forms.CheckBox();
            this.MaxSpawnedAnimals_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_MaxSpawnedAnimals = new System.Windows.Forms.TrackBar();
            this.MaxSpawnedZombies_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_MaxSpawnedZombies = new System.Windows.Forms.TrackBar();
            this.Web_Options_TabPage = new System.Windows.Forms.TabPage();
            this.Terminal_Window_Group_Box = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_TerminalWindowEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ServerMaxWorldTransferSpeedKiBs = new System.Windows.Forms.TrackBar();
            this.Server_Visibility_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ServerVisibility = new System.Windows.Forms.ComboBox();
            this.MaxUncoveredMapChunksPerPlayer_g = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_MaxUncoveredMapChunksPerPlayer = new System.Windows.Forms.TextBox();
            this.HideCommandExecutionLog_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_HideCommandExecutionLog = new System.Windows.Forms.ComboBox();
            this.ServerDisabledNetworkProtocols_g = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ServerDisabledNetworkProtocols = new System.Windows.Forms.CheckedListBox();
            this.RakNet = new System.Windows.Forms.CheckBox();
            this.SteamNetworking = new System.Windows.Forms.CheckBox();
            this.UNET = new System.Windows.Forms.CheckBox();
            this.Telnet_Settings_GroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ConfigProperty_TelnetFailedLoginsBlocktime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ConfigProperty_TelnetFailedLoginLimit = new System.Windows.Forms.TextBox();
            this.ConfigProperty_TelnetEnabled = new System.Windows.Forms.CheckBox();
            this.telnet_port_l = new System.Windows.Forms.Label();
            this.ConfigProperty_TelnetPort = new System.Windows.Forms.TextBox();
            this.telnet_psw_l = new System.Windows.Forms.Label();
            this.ConfigProperty_TelnetPassword = new System.Windows.Forms.TextBox();
            this.port_g = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ServerPort = new System.Windows.Forms.NumericUpDown();
            this.Admin_Control_Panel_GroupBox = new System.Windows.Forms.GroupBox();
            this.cpl_port = new System.Windows.Forms.Label();
            this.ConfigProperty_ControlPanelPort = new System.Windows.Forms.TextBox();
            this.cpl_pass = new System.Windows.Forms.Label();
            this.ConfigProperty_ControlPanelEnabled = new System.Windows.Forms.CheckBox();
            this.ConfigProperty_ControlPanelPassword = new System.Windows.Forms.TextBox();
            this.Mod_Options_TabPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Retrieve_Mods_From_Nexus_Button = new System.Windows.Forms.Button();
            this.Mods_List_GroupBox = new System.Windows.Forms.GroupBox();
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
            this.externalCallFile = new System.Windows.Forms.OpenFileDialog();
            this.discord_b = new System.Windows.Forms.Button();
            this.GitHub_Repo_Button = new System.Windows.Forms.Button();
            this.ConfigProperty_DropOnDeath = new System.Windows.Forms.ComboBox();
            this.DropOnQuit_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_DropOnQuit = new System.Windows.Forms.ComboBox();
            this.BedrollExpiryTime_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_BedrollExpiryTime = new System.Windows.Forms.TrackBar();
            this.ServerMaxAllowedViewDistance_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ServerMaxAllowedViewDistance = new System.Windows.Forms.TrackBar();
            this.ZombieDaySpeed_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ZombieMove = new System.Windows.Forms.ComboBox();
            this.ZombieNightSpeed_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ZombieMoveNight = new System.Windows.Forms.ComboBox();
            this.ZombieBloodMoonSpeed_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ZombieBMMove = new System.Windows.Forms.ComboBox();
            this.ZombieFeralSpeed_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_ZombieFeralMove = new System.Windows.Forms.ComboBox();
            this.BloodMoon_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_BloodMoonFrequency = new System.Windows.Forms.NumericUpDown();
            this.BloodMoonFrequency_Label = new System.Windows.Forms.Label();
            this.BloodMoonRange_Label = new System.Windows.Forms.Label();
            this.ConfigProperty_BloodMoonRange = new System.Windows.Forms.NumericUpDown();
            this.BloodMoonWarning_Label = new System.Windows.Forms.Label();
            this.ConfigProperty_BloodMoonWarning = new System.Windows.Forms.NumericUpDown();
            this.ConfigProperty_AirDropMarker = new System.Windows.Forms.CheckBox();
            this.ConfigProperty_PlayerKillingMode = new System.Windows.Forms.ComboBox();
            this.PartySharedKillRange_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_PartySharedKillRange = new System.Windows.Forms.TrackBar();
            this.ConfigProperty_LandClaimDecayMode = new System.Windows.Forms.ComboBox();
            this.LandClaimCount_GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigProperty_LandClaimCount = new System.Windows.Forms.NumericUpDown();
            this.Player_Safe_Zone_Hours_Label = new System.Windows.Forms.Label();
            this.Player_Safe_Zone_Level_Label = new System.Windows.Forms.Label();
            this.ConfigProperty_PlayerSafeZoneHours = new System.Windows.Forms.TextBox();
            this.ConfigProperty_PlayerSafeZoneLevel = new System.Windows.Forms.TextBox();
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
            this.ManagePlayers_TabPage.SuspendLayout();
            this.Chat_GroupBox.SuspendLayout();
            this.Player_GroupBox.SuspendLayout();
            this.Kick_GroupBox.SuspendLayout();
            this.Ban_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ban_Slider_TrackBar)).BeginInit();
            this.GameSettings_TabPage.SuspendLayout();
            this.main_page_opts.SuspendLayout();
            this.Game_Options_TabPage.SuspendLayout();
            this.XPMultiplier_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_XPMultiplier)).BeginInit();
            this.BlockDamageAI_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BlockDamageAI)).BeginInit();
            this.Server_Reserved_Slots_GroupBox.SuspendLayout();
            this.Player_Killing_Mode_GroupBox.SuspendLayout();
            this.AirDropFrequency_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_AirDropFrequency)).BeginInit();
            this.Land_Claim_GroupBox.SuspendLayout();
            this.BlockDamageAIBM_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BlockDamageAIBM)).BeginInit();
            this.LandClaimDecayMode_GroupBox.SuspendLayout();
            this.LandClaimDurabilityModifier_GroupBox.SuspendLayout();
            this.LandClaimSize_GroupBox.SuspendLayout();
            this.LandClaimDeadZone_GroupBox.SuspendLayout();
            this.LandClaimExpiryTime_GroupBox.SuspendLayout();
            this.LootRespawnDays_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_LootRespawnDays)).BeginInit();
            this.LootAbundance_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_LootAbundance)).BeginInit();
            this.Max_Players_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_ServerMaxPlayerCount)).BeginInit();
            this.Game_Mode_Settings_GroupBox.SuspendLayout();
            this.DayLightLength_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_DayLightLength)).BeginInit();
            this.DayNightLength_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_DayNightLength)).BeginInit();
            this.BlockDamagePlayer_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BlockDamagePlayer)).BeginInit();
            this.DropOnDeath_GroupBox.SuspendLayout();
            this.GameDifficulty_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_GameDifficulty)).BeginInit();
            this.Server_Options_TabPage.SuspendLayout();
            this.Server_Login_Confirmation_Text_GroupBox.SuspendLayout();
            this.Server_Password_GroupBox.SuspendLayout();
            this.Server_Name_GroupBox.SuspendLayout();
            this.ServerWebsiteURL_GroupBox.SuspendLayout();
            this.ServerDescription_GroupBox.SuspendLayout();
            this.User_Data_Folder_GroupBox.SuspendLayout();
            this.Save_Game_Folder_GroupBox.SuspendLayout();
            this.Server_Admin_Config_File_GroupBox.SuspendLayout();
            this.Game_World_Settings_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_WorldGenSize)).BeginInit();
            this.ServerListAndPassword_GroupBox.SuspendLayout();
            this.Other_Game_Settings_GroupBox.SuspendLayout();
            this.autobots.SuspendLayout();
            this.BedrollDeadZoneSize_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BedrollDeadZoneSize)).BeginInit();
            this.BloodMoonEnemyCount_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BloodMoonEnemyCount)).BeginInit();
            this.MaxSpawnedAnimals_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_MaxSpawnedAnimals)).BeginInit();
            this.MaxSpawnedZombies_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_MaxSpawnedZombies)).BeginInit();
            this.Web_Options_TabPage.SuspendLayout();
            this.Terminal_Window_Group_Box.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_ServerMaxWorldTransferSpeedKiBs)).BeginInit();
            this.Server_Visibility_GroupBox.SuspendLayout();
            this.MaxUncoveredMapChunksPerPlayer_g.SuspendLayout();
            this.HideCommandExecutionLog_GroupBox.SuspendLayout();
            this.ServerDisabledNetworkProtocols_g.SuspendLayout();
            this.Telnet_Settings_GroupBox.SuspendLayout();
            this.port_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_ServerPort)).BeginInit();
            this.Admin_Control_Panel_GroupBox.SuspendLayout();
            this.Mod_Options_TabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.DropOnQuit_GroupBox.SuspendLayout();
            this.BedrollExpiryTime_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BedrollExpiryTime)).BeginInit();
            this.ServerMaxAllowedViewDistance_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_ServerMaxAllowedViewDistance)).BeginInit();
            this.ZombieDaySpeed_GroupBox.SuspendLayout();
            this.ZombieNightSpeed_GroupBox.SuspendLayout();
            this.ZombieBloodMoonSpeed_GroupBox.SuspendLayout();
            this.ZombieFeralSpeed_GroupBox.SuspendLayout();
            this.BloodMoon_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BloodMoonFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BloodMoonRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BloodMoonWarning)).BeginInit();
            this.PartySharedKillRange_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_PartySharedKillRange)).BeginInit();
            this.LandClaimCount_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_LandClaimCount)).BeginInit();
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
            this.cmd.Location = new System.Drawing.Point(6, 489);
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
            this.Console_RichTextBox.Size = new System.Drawing.Size(686, 469);
            this.Console_RichTextBox.TabIndex = 15;
            this.Console_RichTextBox.Text = "";
            this.Console_RichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.Console_LinkClicked);
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
            this.tabControl.Controls.Add(this.ManagePlayers_TabPage);
            this.tabControl.Controls.Add(this.GameSettings_TabPage);
            this.tabControl.Controls.Add(this.Messaging_TabPage);
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
            this.Console_Group.Size = new System.Drawing.Size(698, 520);
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
            // ManagePlayers_TabPage
            // 
            this.ManagePlayers_TabPage.BackColor = System.Drawing.SystemColors.Control;
            this.ManagePlayers_TabPage.Controls.Add(this.Chat_GroupBox);
            this.ManagePlayers_TabPage.Controls.Add(this.All_Players_Label);
            this.ManagePlayers_TabPage.Controls.Add(this.Online_Players_Label);
            this.ManagePlayers_TabPage.Controls.Add(this.All_Players_List);
            this.ManagePlayers_TabPage.Controls.Add(this.Player_GroupBox);
            this.ManagePlayers_TabPage.Controls.Add(this.Game_Time_Controls_GroupBox);
            this.ManagePlayers_TabPage.Controls.Add(this.Kick_GroupBox);
            this.ManagePlayers_TabPage.Controls.Add(this.Spawn_GroupBox);
            this.ManagePlayers_TabPage.Controls.Add(this.Ban_GroupBox);
            this.ManagePlayers_TabPage.Controls.Add(this.Online_Player_List);
            this.ManagePlayers_TabPage.ImageIndex = 2;
            this.ManagePlayers_TabPage.Location = new System.Drawing.Point(47, 4);
            this.ManagePlayers_TabPage.Name = "ManagePlayers_TabPage";
            this.ManagePlayers_TabPage.Size = new System.Drawing.Size(908, 684);
            this.ManagePlayers_TabPage.TabIndex = 5;
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
            this.main_page_opts.Controls.Add(this.Game_Options_TabPage);
            this.main_page_opts.Controls.Add(this.Server_Options_TabPage);
            this.main_page_opts.Controls.Add(this.Web_Options_TabPage);
            this.main_page_opts.Controls.Add(this.Mod_Options_TabPage);
            this.main_page_opts.ImageList = this.Header_Icons;
            this.main_page_opts.ItemSize = new System.Drawing.Size(46, 46);
            this.main_page_opts.Location = new System.Drawing.Point(3, 0);
            this.main_page_opts.Name = "main_page_opts";
            this.main_page_opts.Padding = new System.Drawing.Point(3, 3);
            this.main_page_opts.SelectedIndex = 0;
            this.main_page_opts.Size = new System.Drawing.Size(905, 684);
            this.main_page_opts.TabIndex = 0;
            // 
            // Game_Options_TabPage
            // 
            this.Game_Options_TabPage.Controls.Add(this.BlockDamageAIBM_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.PartySharedKillRange_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.ZombieBloodMoonSpeed_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.ZombieNightSpeed_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.ZombieFeralSpeed_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.ServerMaxAllowedViewDistance_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.DropOnQuit_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.XPMultiplier_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.BlockDamageAI_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.Server_Reserved_Slots_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.Player_Killing_Mode_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.DropOnDeath_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.AirDropFrequency_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.Land_Claim_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.LootRespawnDays_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.LootAbundance_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.Max_Players_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.Game_Mode_Settings_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.ZombieDaySpeed_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.DayLightLength_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.DayNightLength_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.BlockDamagePlayer_GroupBox);
            this.Game_Options_TabPage.Controls.Add(this.GameDifficulty_GroupBox);
            this.Game_Options_TabPage.ImageIndex = 5;
            this.Game_Options_TabPage.Location = new System.Drawing.Point(4, 50);
            this.Game_Options_TabPage.Name = "Game_Options_TabPage";
            this.Game_Options_TabPage.Size = new System.Drawing.Size(897, 630);
            this.Game_Options_TabPage.TabIndex = 2;
            this.Game_Options_TabPage.UseVisualStyleBackColor = true;
            // 
            // XPMultiplier_GroupBox
            // 
            this.XPMultiplier_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XPMultiplier_GroupBox.Controls.Add(this.ConfigProperty_XPMultiplier);
            this.XPMultiplier_GroupBox.Location = new System.Drawing.Point(523, 408);
            this.XPMultiplier_GroupBox.Name = "XPMultiplier_GroupBox";
            this.XPMultiplier_GroupBox.Size = new System.Drawing.Size(179, 65);
            this.XPMultiplier_GroupBox.TabIndex = 39;
            this.XPMultiplier_GroupBox.TabStop = false;
            this.XPMultiplier_GroupBox.Text = "XP Multiplier";
            // 
            // ConfigProperty_XPMultiplier
            // 
            this.ConfigProperty_XPMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_XPMultiplier.Location = new System.Drawing.Point(6, 14);
            this.ConfigProperty_XPMultiplier.Maximum = 1000;
            this.ConfigProperty_XPMultiplier.Minimum = 1;
            this.ConfigProperty_XPMultiplier.Name = "ConfigProperty_XPMultiplier";
            this.ConfigProperty_XPMultiplier.Size = new System.Drawing.Size(167, 45);
            this.ConfigProperty_XPMultiplier.SmallChange = 10;
            this.ConfigProperty_XPMultiplier.TabIndex = 9;
            this.ConfigProperty_XPMultiplier.TickFrequency = 10;
            this.toolTip.SetToolTip(this.ConfigProperty_XPMultiplier, "XP gain multiplier (percentage in whole numbers).");
            this.ConfigProperty_XPMultiplier.Value = 100;
            // 
            // BlockDamageAI_GroupBox
            // 
            this.BlockDamageAI_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BlockDamageAI_GroupBox.Controls.Add(this.ConfigProperty_BlockDamageAI);
            this.BlockDamageAI_GroupBox.Location = new System.Drawing.Point(524, 479);
            this.BlockDamageAI_GroupBox.Name = "BlockDamageAI_GroupBox";
            this.BlockDamageAI_GroupBox.Size = new System.Drawing.Size(179, 65);
            this.BlockDamageAI_GroupBox.TabIndex = 38;
            this.BlockDamageAI_GroupBox.TabStop = false;
            this.BlockDamageAI_GroupBox.Text = "AI Block Damage";
            // 
            // ConfigProperty_BlockDamageAI
            // 
            this.ConfigProperty_BlockDamageAI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_BlockDamageAI.Location = new System.Drawing.Point(6, 14);
            this.ConfigProperty_BlockDamageAI.Maximum = 1000;
            this.ConfigProperty_BlockDamageAI.Minimum = 1;
            this.ConfigProperty_BlockDamageAI.Name = "ConfigProperty_BlockDamageAI";
            this.ConfigProperty_BlockDamageAI.Size = new System.Drawing.Size(167, 45);
            this.ConfigProperty_BlockDamageAI.SmallChange = 10;
            this.ConfigProperty_BlockDamageAI.TabIndex = 9;
            this.ConfigProperty_BlockDamageAI.TickFrequency = 10;
            this.toolTip.SetToolTip(this.ConfigProperty_BlockDamageAI, "How much damage do AIs to blocks (percentage in whole numbers).");
            this.ConfigProperty_BlockDamageAI.Value = 100;
            // 
            // Server_Reserved_Slots_GroupBox
            // 
            this.Server_Reserved_Slots_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.ConfigProperty_ServerAdminSlotsPermission);
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.Admin_Slot_Text_Label);
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.Admin_Reserve_Text_Label);
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.ConfigProperty_ServerAdminSlots);
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.ConfigProperty_ServerReservedSlotsPermission);
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.Player_Slot_Text_Label);
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.Player_Reserve_Text_Label);
            this.Server_Reserved_Slots_GroupBox.Controls.Add(this.ConfigProperty_ServerReservedSlots);
            this.Server_Reserved_Slots_GroupBox.Location = new System.Drawing.Point(524, 4);
            this.Server_Reserved_Slots_GroupBox.Name = "Server_Reserved_Slots_GroupBox";
            this.Server_Reserved_Slots_GroupBox.Size = new System.Drawing.Size(366, 65);
            this.Server_Reserved_Slots_GroupBox.TabIndex = 51;
            this.Server_Reserved_Slots_GroupBox.TabStop = false;
            this.Server_Reserved_Slots_GroupBox.Text = "Server Reserved Slots";
            // 
            // ConfigProperty_ServerAdminSlotsPermission
            // 
            this.ConfigProperty_ServerAdminSlotsPermission.Location = new System.Drawing.Point(285, 38);
            this.ConfigProperty_ServerAdminSlotsPermission.Name = "ConfigProperty_ServerAdminSlotsPermission";
            this.ConfigProperty_ServerAdminSlotsPermission.Size = new System.Drawing.Size(31, 20);
            this.ConfigProperty_ServerAdminSlotsPermission.TabIndex = 7;
            this.ConfigProperty_ServerAdminSlotsPermission.Text = "0";
            this.toolTip.SetToolTip(this.ConfigProperty_ServerAdminSlotsPermission, "Required permission level to use the admin slots.");
            this.ConfigProperty_ServerAdminSlotsPermission.TextChanged += new System.EventHandler(this.ServerAdminSlotsPermission_TextChanged);
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
            // ConfigProperty_ServerAdminSlots
            // 
            this.ConfigProperty_ServerAdminSlots.Location = new System.Drawing.Point(59, 38);
            this.ConfigProperty_ServerAdminSlots.Name = "ConfigProperty_ServerAdminSlots";
            this.ConfigProperty_ServerAdminSlots.Size = new System.Drawing.Size(31, 20);
            this.ConfigProperty_ServerAdminSlots.TabIndex = 4;
            this.ConfigProperty_ServerAdminSlots.Text = "0";
            this.toolTip.SetToolTip(this.ConfigProperty_ServerAdminSlots, "This many admins can still join even if the server has reached MaxPlayerCount.");
            this.ConfigProperty_ServerAdminSlots.TextChanged += new System.EventHandler(this.ServerAdminSlots_TextChanged);
            // 
            // ConfigProperty_ServerReservedSlotsPermission
            // 
            this.ConfigProperty_ServerReservedSlotsPermission.Location = new System.Drawing.Point(285, 13);
            this.ConfigProperty_ServerReservedSlotsPermission.Name = "ConfigProperty_ServerReservedSlotsPermission";
            this.ConfigProperty_ServerReservedSlotsPermission.Size = new System.Drawing.Size(31, 20);
            this.ConfigProperty_ServerReservedSlotsPermission.TabIndex = 3;
            this.ConfigProperty_ServerReservedSlotsPermission.Text = "100";
            this.toolTip.SetToolTip(this.ConfigProperty_ServerReservedSlotsPermission, "Required permission level to use reserved slots.");
            this.ConfigProperty_ServerReservedSlotsPermission.TextChanged += new System.EventHandler(this.ServerReservedSlotsPermission_TextChanged);
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
            // ConfigProperty_ServerReservedSlots
            // 
            this.ConfigProperty_ServerReservedSlots.Location = new System.Drawing.Point(59, 13);
            this.ConfigProperty_ServerReservedSlots.Name = "ConfigProperty_ServerReservedSlots";
            this.ConfigProperty_ServerReservedSlots.Size = new System.Drawing.Size(31, 20);
            this.ConfigProperty_ServerReservedSlots.TabIndex = 0;
            this.ConfigProperty_ServerReservedSlots.Text = "0";
            this.toolTip.SetToolTip(this.ConfigProperty_ServerReservedSlots, "Out of the MaxPlayerCount this many slots can only be used by players with a spec" +
        "ific permission level.");
            this.ConfigProperty_ServerReservedSlots.TextChanged += new System.EventHandler(this.ServerReservedSlots_TextChanged);
            // 
            // Player_Killing_Mode_GroupBox
            // 
            this.Player_Killing_Mode_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player_Killing_Mode_GroupBox.Controls.Add(this.ConfigProperty_PlayerKillingMode);
            this.Player_Killing_Mode_GroupBox.Location = new System.Drawing.Point(708, 434);
            this.Player_Killing_Mode_GroupBox.Name = "Player_Killing_Mode_GroupBox";
            this.Player_Killing_Mode_GroupBox.Size = new System.Drawing.Size(179, 47);
            this.Player_Killing_Mode_GroupBox.TabIndex = 50;
            this.Player_Killing_Mode_GroupBox.TabStop = false;
            this.Player_Killing_Mode_GroupBox.Text = "Player Killing Mode";
            // 
            // AirDropFrequency_GroupBox
            // 
            this.AirDropFrequency_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AirDropFrequency_GroupBox.Controls.Add(this.ConfigProperty_AirDropFrequency);
            this.AirDropFrequency_GroupBox.Location = new System.Drawing.Point(524, 75);
            this.AirDropFrequency_GroupBox.Name = "AirDropFrequency_GroupBox";
            this.AirDropFrequency_GroupBox.Size = new System.Drawing.Size(366, 65);
            this.AirDropFrequency_GroupBox.TabIndex = 48;
            this.AirDropFrequency_GroupBox.TabStop = false;
            this.AirDropFrequency_GroupBox.Text = "Air Drop Frequency";
            // 
            // ConfigProperty_AirDropFrequency
            // 
            this.ConfigProperty_AirDropFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_AirDropFrequency.Location = new System.Drawing.Point(6, 14);
            this.ConfigProperty_AirDropFrequency.Maximum = 168;
            this.ConfigProperty_AirDropFrequency.Name = "ConfigProperty_AirDropFrequency";
            this.ConfigProperty_AirDropFrequency.Size = new System.Drawing.Size(354, 45);
            this.ConfigProperty_AirDropFrequency.TabIndex = 8;
            this.toolTip.SetToolTip(this.ConfigProperty_AirDropFrequency, "How often airdrop occur in game-hours, 0 == never");
            this.ConfigProperty_AirDropFrequency.Value = 72;
            this.ConfigProperty_AirDropFrequency.Scroll += new System.EventHandler(this.AirDropFrequency_Scroll);
            // 
            // Land_Claim_GroupBox
            // 
            this.Land_Claim_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Land_Claim_GroupBox.Controls.Add(this.LandClaimCount_GroupBox);
            this.Land_Claim_GroupBox.Controls.Add(this.LandClaimDecayMode_GroupBox);
            this.Land_Claim_GroupBox.Controls.Add(this.LandClaimDurabilityModifier_GroupBox);
            this.Land_Claim_GroupBox.Controls.Add(this.LandClaimSize_GroupBox);
            this.Land_Claim_GroupBox.Controls.Add(this.LandClaimDeadZone_GroupBox);
            this.Land_Claim_GroupBox.Controls.Add(this.LandClaimExpiryTime_GroupBox);
            this.Land_Claim_GroupBox.Location = new System.Drawing.Point(10, 381);
            this.Land_Claim_GroupBox.Name = "Land_Claim_GroupBox";
            this.Land_Claim_GroupBox.Size = new System.Drawing.Size(345, 209);
            this.Land_Claim_GroupBox.TabIndex = 39;
            this.Land_Claim_GroupBox.TabStop = false;
            this.Land_Claim_GroupBox.Text = "Land Claims";
            // 
            // BlockDamageAIBM_GroupBox
            // 
            this.BlockDamageAIBM_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BlockDamageAIBM_GroupBox.Controls.Add(this.ConfigProperty_BlockDamageAIBM);
            this.BlockDamageAIBM_GroupBox.Location = new System.Drawing.Point(708, 561);
            this.BlockDamageAIBM_GroupBox.Name = "BlockDamageAIBM_GroupBox";
            this.BlockDamageAIBM_GroupBox.Size = new System.Drawing.Size(179, 65);
            this.BlockDamageAIBM_GroupBox.TabIndex = 53;
            this.BlockDamageAIBM_GroupBox.TabStop = false;
            this.BlockDamageAIBM_GroupBox.Text = "AI Block Damage (Blood Moon)";
            // 
            // ConfigProperty_BlockDamageAIBM
            // 
            this.ConfigProperty_BlockDamageAIBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_BlockDamageAIBM.Location = new System.Drawing.Point(6, 17);
            this.ConfigProperty_BlockDamageAIBM.Maximum = 1000;
            this.ConfigProperty_BlockDamageAIBM.Minimum = 1;
            this.ConfigProperty_BlockDamageAIBM.Name = "ConfigProperty_BlockDamageAIBM";
            this.ConfigProperty_BlockDamageAIBM.Size = new System.Drawing.Size(167, 45);
            this.ConfigProperty_BlockDamageAIBM.SmallChange = 10;
            this.ConfigProperty_BlockDamageAIBM.TabIndex = 9;
            this.ConfigProperty_BlockDamageAIBM.TickFrequency = 10;
            this.toolTip.SetToolTip(this.ConfigProperty_BlockDamageAIBM, "How much damage do AIs during blood moons to blocks (percentage in whole numbers)" +
        ".");
            this.ConfigProperty_BlockDamageAIBM.Value = 100;
            // 
            // LandClaimDecayMode_GroupBox
            // 
            this.LandClaimDecayMode_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LandClaimDecayMode_GroupBox.Controls.Add(this.ConfigProperty_LandClaimDecayMode);
            this.LandClaimDecayMode_GroupBox.Location = new System.Drawing.Point(9, 19);
            this.LandClaimDecayMode_GroupBox.Name = "LandClaimDecayMode_GroupBox";
            this.LandClaimDecayMode_GroupBox.Size = new System.Drawing.Size(176, 51);
            this.LandClaimDecayMode_GroupBox.TabIndex = 3;
            this.LandClaimDecayMode_GroupBox.TabStop = false;
            this.LandClaimDecayMode_GroupBox.Text = "Land Claim Decay Mode";
            // 
            // LandClaimDurabilityModifier_GroupBox
            // 
            this.LandClaimDurabilityModifier_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LandClaimDurabilityModifier_GroupBox.Controls.Add(this.Land_Claim_Durability_Offline_Label);
            this.LandClaimDurabilityModifier_GroupBox.Controls.Add(this.Land_Claim_Durability_Online_Label);
            this.LandClaimDurabilityModifier_GroupBox.Controls.Add(this.ConfigProperty_LandClaimOfflineDurabilityModifier);
            this.LandClaimDurabilityModifier_GroupBox.Controls.Add(this.ConfigProperty_LandClaimOnlineDurabilityModifier);
            this.LandClaimDurabilityModifier_GroupBox.Location = new System.Drawing.Point(16, 128);
            this.LandClaimDurabilityModifier_GroupBox.Name = "LandClaimDurabilityModifier_GroupBox";
            this.LandClaimDurabilityModifier_GroupBox.Size = new System.Drawing.Size(169, 74);
            this.LandClaimDurabilityModifier_GroupBox.TabIndex = 4;
            this.LandClaimDurabilityModifier_GroupBox.TabStop = false;
            this.LandClaimDurabilityModifier_GroupBox.Text = "Land Claim Durability Modifier";
            // 
            // Land_Claim_Durability_Offline_Label
            // 
            this.Land_Claim_Durability_Offline_Label.AutoSize = true;
            this.Land_Claim_Durability_Offline_Label.Location = new System.Drawing.Point(17, 49);
            this.Land_Claim_Durability_Offline_Label.Name = "Land_Claim_Durability_Offline_Label";
            this.Land_Claim_Durability_Offline_Label.Size = new System.Drawing.Size(37, 13);
            this.Land_Claim_Durability_Offline_Label.TabIndex = 3;
            this.Land_Claim_Durability_Offline_Label.Text = "Offline";
            // 
            // Land_Claim_Durability_Online_Label
            // 
            this.Land_Claim_Durability_Online_Label.AutoSize = true;
            this.Land_Claim_Durability_Online_Label.Location = new System.Drawing.Point(17, 23);
            this.Land_Claim_Durability_Online_Label.Name = "Land_Claim_Durability_Online_Label";
            this.Land_Claim_Durability_Online_Label.Size = new System.Drawing.Size(37, 13);
            this.Land_Claim_Durability_Online_Label.TabIndex = 2;
            this.Land_Claim_Durability_Online_Label.Text = "Online";
            // 
            // ConfigProperty_LandClaimOfflineDurabilityModifier
            // 
            this.ConfigProperty_LandClaimOfflineDurabilityModifier.Location = new System.Drawing.Point(62, 48);
            this.ConfigProperty_LandClaimOfflineDurabilityModifier.Name = "ConfigProperty_LandClaimOfflineDurabilityModifier";
            this.ConfigProperty_LandClaimOfflineDurabilityModifier.Size = new System.Drawing.Size(54, 20);
            this.ConfigProperty_LandClaimOfflineDurabilityModifier.TabIndex = 1;
            this.ConfigProperty_LandClaimOfflineDurabilityModifier.Text = "4";
            this.toolTip.SetToolTip(this.ConfigProperty_LandClaimOfflineDurabilityModifier, "How much protected claim area block hardness is increased when a player is offlin" +
        "e.\r\n\r\n0 means infinite (no damage will ever be taken).");
            this.ConfigProperty_LandClaimOfflineDurabilityModifier.TextChanged += new System.EventHandler(this.LandClaimOfflineDurabilityModifier_TextChanged);
            // 
            // ConfigProperty_LandClaimOnlineDurabilityModifier
            // 
            this.ConfigProperty_LandClaimOnlineDurabilityModifier.Location = new System.Drawing.Point(62, 22);
            this.ConfigProperty_LandClaimOnlineDurabilityModifier.Name = "ConfigProperty_LandClaimOnlineDurabilityModifier";
            this.ConfigProperty_LandClaimOnlineDurabilityModifier.Size = new System.Drawing.Size(54, 20);
            this.ConfigProperty_LandClaimOnlineDurabilityModifier.TabIndex = 0;
            this.ConfigProperty_LandClaimOnlineDurabilityModifier.Text = "4";
            this.toolTip.SetToolTip(this.ConfigProperty_LandClaimOnlineDurabilityModifier, "How much protected claim area block hardness is increased when a player is online" +
        ". \r\n\r\n0 means infinite (no damage will ever be taken).\r\n");
            this.ConfigProperty_LandClaimOnlineDurabilityModifier.TextChanged += new System.EventHandler(this.LandClaimOnlineDurabilityModifier_TextChanged);
            // 
            // LandClaimSize_GroupBox
            // 
            this.LandClaimSize_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LandClaimSize_GroupBox.Controls.Add(this.ConfigProperty_LandClaimSize);
            this.LandClaimSize_GroupBox.Location = new System.Drawing.Point(191, 72);
            this.LandClaimSize_GroupBox.Name = "LandClaimSize_GroupBox";
            this.LandClaimSize_GroupBox.Size = new System.Drawing.Size(145, 51);
            this.LandClaimSize_GroupBox.TabIndex = 0;
            this.LandClaimSize_GroupBox.TabStop = false;
            this.LandClaimSize_GroupBox.Text = "Land Claim Size";
            // 
            // ConfigProperty_LandClaimSize
            // 
            this.ConfigProperty_LandClaimSize.Location = new System.Drawing.Point(6, 19);
            this.ConfigProperty_LandClaimSize.Name = "ConfigProperty_LandClaimSize";
            this.ConfigProperty_LandClaimSize.Size = new System.Drawing.Size(133, 20);
            this.ConfigProperty_LandClaimSize.TabIndex = 0;
            this.ConfigProperty_LandClaimSize.Text = "41";
            this.toolTip.SetToolTip(this.ConfigProperty_LandClaimSize, "Size in blocks that is protected by a keystone.");
            this.ConfigProperty_LandClaimSize.TextChanged += new System.EventHandler(this.LandClaimSize_TextChanged);
            // 
            // LandClaimDeadZone_GroupBox
            // 
            this.LandClaimDeadZone_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LandClaimDeadZone_GroupBox.Controls.Add(this.ConfigProperty_LandClaimDeadZone);
            this.LandClaimDeadZone_GroupBox.Location = new System.Drawing.Point(191, 19);
            this.LandClaimDeadZone_GroupBox.Name = "LandClaimDeadZone_GroupBox";
            this.LandClaimDeadZone_GroupBox.Size = new System.Drawing.Size(145, 51);
            this.LandClaimDeadZone_GroupBox.TabIndex = 1;
            this.LandClaimDeadZone_GroupBox.TabStop = false;
            this.LandClaimDeadZone_GroupBox.Text = "Land Claim Dead Zone";
            // 
            // ConfigProperty_LandClaimDeadZone
            // 
            this.ConfigProperty_LandClaimDeadZone.Location = new System.Drawing.Point(6, 19);
            this.ConfigProperty_LandClaimDeadZone.Name = "ConfigProperty_LandClaimDeadZone";
            this.ConfigProperty_LandClaimDeadZone.Size = new System.Drawing.Size(133, 20);
            this.ConfigProperty_LandClaimDeadZone.TabIndex = 0;
            this.ConfigProperty_LandClaimDeadZone.Text = "30";
            this.toolTip.SetToolTip(this.ConfigProperty_LandClaimDeadZone, "Keystones must be this many blocks apart (unless you are friends with the other p" +
        "layer).");
            this.ConfigProperty_LandClaimDeadZone.TextChanged += new System.EventHandler(this.LandClaimDeadZone_TextChanged);
            // 
            // LandClaimExpiryTime_GroupBox
            // 
            this.LandClaimExpiryTime_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LandClaimExpiryTime_GroupBox.Controls.Add(this.ConfigProperty_LandClaimExpiryTime);
            this.LandClaimExpiryTime_GroupBox.Location = new System.Drawing.Point(197, 129);
            this.LandClaimExpiryTime_GroupBox.Name = "LandClaimExpiryTime_GroupBox";
            this.LandClaimExpiryTime_GroupBox.Size = new System.Drawing.Size(139, 51);
            this.LandClaimExpiryTime_GroupBox.TabIndex = 2;
            this.LandClaimExpiryTime_GroupBox.TabStop = false;
            this.LandClaimExpiryTime_GroupBox.Text = "Land Claim Expiry Time";
            // 
            // ConfigProperty_LandClaimExpiryTime
            // 
            this.ConfigProperty_LandClaimExpiryTime.Location = new System.Drawing.Point(6, 19);
            this.ConfigProperty_LandClaimExpiryTime.Name = "ConfigProperty_LandClaimExpiryTime";
            this.ConfigProperty_LandClaimExpiryTime.Size = new System.Drawing.Size(122, 20);
            this.ConfigProperty_LandClaimExpiryTime.TabIndex = 0;
            this.ConfigProperty_LandClaimExpiryTime.Text = "7";
            this.toolTip.SetToolTip(this.ConfigProperty_LandClaimExpiryTime, "The number of days a player can be offline before their claims expire and are no " +
        "longer protected.");
            this.ConfigProperty_LandClaimExpiryTime.TextChanged += new System.EventHandler(this.LandClaimExpiryTime_TextChanged);
            // 
            // LootRespawnDays_GroupBox
            // 
            this.LootRespawnDays_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LootRespawnDays_GroupBox.Controls.Add(this.ConfigProperty_LootRespawnDays);
            this.LootRespawnDays_GroupBox.Location = new System.Drawing.Point(10, 310);
            this.LootRespawnDays_GroupBox.Name = "LootRespawnDays_GroupBox";
            this.LootRespawnDays_GroupBox.Size = new System.Drawing.Size(508, 65);
            this.LootRespawnDays_GroupBox.TabIndex = 47;
            this.LootRespawnDays_GroupBox.TabStop = false;
            this.LootRespawnDays_GroupBox.Text = "Loot Respawn Days";
            // 
            // ConfigProperty_LootRespawnDays
            // 
            this.ConfigProperty_LootRespawnDays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_LootRespawnDays.Location = new System.Drawing.Point(3, 14);
            this.ConfigProperty_LootRespawnDays.Maximum = 90;
            this.ConfigProperty_LootRespawnDays.Minimum = -1;
            this.ConfigProperty_LootRespawnDays.Name = "ConfigProperty_LootRespawnDays";
            this.ConfigProperty_LootRespawnDays.Size = new System.Drawing.Size(496, 45);
            this.ConfigProperty_LootRespawnDays.TabIndex = 9;
            this.ConfigProperty_LootRespawnDays.Value = 30;
            this.ConfigProperty_LootRespawnDays.Scroll += new System.EventHandler(this.LootRespawnDays_Scroll);
            // 
            // LootAbundance_GroupBox
            // 
            this.LootAbundance_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LootAbundance_GroupBox.Controls.Add(this.ConfigProperty_LootAbundance);
            this.LootAbundance_GroupBox.Location = new System.Drawing.Point(10, 239);
            this.LootAbundance_GroupBox.Name = "LootAbundance_GroupBox";
            this.LootAbundance_GroupBox.Size = new System.Drawing.Size(508, 65);
            this.LootAbundance_GroupBox.TabIndex = 46;
            this.LootAbundance_GroupBox.TabStop = false;
            this.LootAbundance_GroupBox.Text = "Loot Abundance %";
            // 
            // ConfigProperty_LootAbundance
            // 
            this.ConfigProperty_LootAbundance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_LootAbundance.Location = new System.Drawing.Point(6, 13);
            this.ConfigProperty_LootAbundance.Maximum = 200;
            this.ConfigProperty_LootAbundance.Name = "ConfigProperty_LootAbundance";
            this.ConfigProperty_LootAbundance.Size = new System.Drawing.Size(496, 45);
            this.ConfigProperty_LootAbundance.TabIndex = 9;
            this.ConfigProperty_LootAbundance.Value = 100;
            this.ConfigProperty_LootAbundance.Scroll += new System.EventHandler(this.LootAbundance_Scroll);
            // 
            // Max_Players_GroupBox
            // 
            this.Max_Players_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Max_Players_GroupBox.Controls.Add(this.ConfigProperty_ServerMaxPlayerCount);
            this.Max_Players_GroupBox.Location = new System.Drawing.Point(10, 3);
            this.Max_Players_GroupBox.Name = "Max_Players_GroupBox";
            this.Max_Players_GroupBox.Size = new System.Drawing.Size(508, 65);
            this.Max_Players_GroupBox.TabIndex = 45;
            this.Max_Players_GroupBox.TabStop = false;
            this.Max_Players_GroupBox.Text = "Max Players";
            // 
            // ConfigProperty_ServerMaxPlayerCount
            // 
            this.ConfigProperty_ServerMaxPlayerCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_ServerMaxPlayerCount.Location = new System.Drawing.Point(6, 14);
            this.ConfigProperty_ServerMaxPlayerCount.Maximum = 64;
            this.ConfigProperty_ServerMaxPlayerCount.Minimum = 1;
            this.ConfigProperty_ServerMaxPlayerCount.Name = "ConfigProperty_ServerMaxPlayerCount";
            this.ConfigProperty_ServerMaxPlayerCount.Size = new System.Drawing.Size(496, 45);
            this.ConfigProperty_ServerMaxPlayerCount.TabIndex = 8;
            this.toolTip.SetToolTip(this.ConfigProperty_ServerMaxPlayerCount, "Maximum Concurrent Players");
            this.ConfigProperty_ServerMaxPlayerCount.Value = 8;
            this.ConfigProperty_ServerMaxPlayerCount.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // Game_Mode_Settings_GroupBox
            // 
            this.Game_Mode_Settings_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Game_Mode_Settings_GroupBox.Controls.Add(this.ConfigProperty_AirDropMarker);
            this.Game_Mode_Settings_GroupBox.Controls.Add(this.ConfigProperty_PersistentPlayerProfiles);
            this.Game_Mode_Settings_GroupBox.Controls.Add(this.ConfigProperty_EnemyDifficulty);
            this.Game_Mode_Settings_GroupBox.Controls.Add(this.ConfigProperty_BuildCreate);
            this.Game_Mode_Settings_GroupBox.Location = new System.Drawing.Point(524, 288);
            this.Game_Mode_Settings_GroupBox.Name = "Game_Mode_Settings_GroupBox";
            this.Game_Mode_Settings_GroupBox.Size = new System.Drawing.Size(179, 114);
            this.Game_Mode_Settings_GroupBox.TabIndex = 44;
            this.Game_Mode_Settings_GroupBox.TabStop = false;
            this.Game_Mode_Settings_GroupBox.Text = "Game Mode Settings";
            // 
            // ConfigProperty_PersistentPlayerProfiles
            // 
            this.ConfigProperty_PersistentPlayerProfiles.AutoSize = true;
            this.ConfigProperty_PersistentPlayerProfiles.Location = new System.Drawing.Point(6, 17);
            this.ConfigProperty_PersistentPlayerProfiles.Name = "ConfigProperty_PersistentPlayerProfiles";
            this.ConfigProperty_PersistentPlayerProfiles.Size = new System.Drawing.Size(135, 17);
            this.ConfigProperty_PersistentPlayerProfiles.TabIndex = 19;
            this.ConfigProperty_PersistentPlayerProfiles.Text = "PersistentPlayerProfiles";
            this.toolTip.SetToolTip(this.ConfigProperty_PersistentPlayerProfiles, "If disabled a player can join with any selected profile. \r\n\r\nIf true they will jo" +
        "in with the last profile they joined with.");
            this.ConfigProperty_PersistentPlayerProfiles.UseVisualStyleBackColor = true;
            this.ConfigProperty_PersistentPlayerProfiles.CheckedChanged += new System.EventHandler(this.PersistentPlayerProfiles_CheckedChanged);
            // 
            // ConfigProperty_EnemyDifficulty
            // 
            this.ConfigProperty_EnemyDifficulty.AutoSize = true;
            this.ConfigProperty_EnemyDifficulty.Location = new System.Drawing.Point(6, 40);
            this.ConfigProperty_EnemyDifficulty.Name = "ConfigProperty_EnemyDifficulty";
            this.ConfigProperty_EnemyDifficulty.Size = new System.Drawing.Size(92, 17);
            this.ConfigProperty_EnemyDifficulty.TabIndex = 18;
            this.ConfigProperty_EnemyDifficulty.Text = "Feral Difficulty";
            this.toolTip.SetToolTip(this.ConfigProperty_EnemyDifficulty, "Are Zombies Feral? \r\n\r\nThis beefs up the difficulty of certain zombies.");
            this.ConfigProperty_EnemyDifficulty.UseVisualStyleBackColor = true;
            this.ConfigProperty_EnemyDifficulty.CheckedChanged += new System.EventHandler(this.Feral_CheckedChanged);
            // 
            // ConfigProperty_BuildCreate
            // 
            this.ConfigProperty_BuildCreate.AutoSize = true;
            this.ConfigProperty_BuildCreate.Location = new System.Drawing.Point(6, 63);
            this.ConfigProperty_BuildCreate.Name = "ConfigProperty_BuildCreate";
            this.ConfigProperty_BuildCreate.Size = new System.Drawing.Size(84, 17);
            this.ConfigProperty_BuildCreate.TabIndex = 14;
            this.ConfigProperty_BuildCreate.Text = "Cheat Mode";
            this.toolTip.SetToolTip(this.ConfigProperty_BuildCreate, "Creative mode for everyone - on / off.\r\n");
            this.ConfigProperty_BuildCreate.UseVisualStyleBackColor = true;
            this.ConfigProperty_BuildCreate.CheckedChanged += new System.EventHandler(this.Cheatmode_CheckedChanged);
            // 
            // DayLightLength_GroupBox
            // 
            this.DayLightLength_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DayLightLength_GroupBox.Controls.Add(this.ConfigProperty_DayLightLength);
            this.DayLightLength_GroupBox.Location = new System.Drawing.Point(10, 74);
            this.DayLightLength_GroupBox.Name = "DayLightLength_GroupBox";
            this.DayLightLength_GroupBox.Size = new System.Drawing.Size(508, 65);
            this.DayLightLength_GroupBox.TabIndex = 42;
            this.DayLightLength_GroupBox.TabStop = false;
            this.DayLightLength_GroupBox.Text = "Sunshine Hours";
            // 
            // ConfigProperty_DayLightLength
            // 
            this.ConfigProperty_DayLightLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_DayLightLength.Location = new System.Drawing.Point(6, 14);
            this.ConfigProperty_DayLightLength.Maximum = 24;
            this.ConfigProperty_DayLightLength.Minimum = 1;
            this.ConfigProperty_DayLightLength.Name = "ConfigProperty_DayLightLength";
            this.ConfigProperty_DayLightLength.Size = new System.Drawing.Size(496, 45);
            this.ConfigProperty_DayLightLength.TabIndex = 9;
            this.toolTip.SetToolTip(this.ConfigProperty_DayLightLength, "In-game hours the sun shines per day.");
            this.ConfigProperty_DayLightLength.Value = 18;
            this.ConfigProperty_DayLightLength.Scroll += new System.EventHandler(this.Nightpercentage_Scroll);
            // 
            // DayNightLength_GroupBox
            // 
            this.DayNightLength_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DayNightLength_GroupBox.Controls.Add(this.DayNightLength_Realtime_Mode);
            this.DayNightLength_GroupBox.Controls.Add(this.ConfigProperty_DayNightLength);
            this.DayNightLength_GroupBox.Location = new System.Drawing.Point(10, 145);
            this.DayNightLength_GroupBox.Name = "DayNightLength_GroupBox";
            this.DayNightLength_GroupBox.Size = new System.Drawing.Size(508, 88);
            this.DayNightLength_GroupBox.TabIndex = 39;
            this.DayNightLength_GroupBox.TabStop = false;
            this.DayNightLength_GroupBox.Text = "Day Length";
            // 
            // DayNightLength_Realtime_Mode
            // 
            this.DayNightLength_Realtime_Mode.AutoSize = true;
            this.DayNightLength_Realtime_Mode.Location = new System.Drawing.Point(9, 65);
            this.DayNightLength_Realtime_Mode.Name = "DayNightLength_Realtime_Mode";
            this.DayNightLength_Realtime_Mode.Size = new System.Drawing.Size(97, 17);
            this.DayNightLength_Realtime_Mode.TabIndex = 10;
            this.DayNightLength_Realtime_Mode.Text = "Realtime Mode";
            this.toolTip.SetToolTip(this.DayNightLength_Realtime_Mode, "In-game day will happen in realtime.\r\n");
            this.DayNightLength_Realtime_Mode.UseVisualStyleBackColor = true;
            this.DayNightLength_Realtime_Mode.CheckedChanged += new System.EventHandler(this.Realtime_CheckedChanged);
            // 
            // ConfigProperty_DayNightLength
            // 
            this.ConfigProperty_DayNightLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_DayNightLength.Enabled = false;
            this.ConfigProperty_DayNightLength.Location = new System.Drawing.Point(6, 19);
            this.ConfigProperty_DayNightLength.Maximum = 1440;
            this.ConfigProperty_DayNightLength.Minimum = 1;
            this.ConfigProperty_DayNightLength.Name = "ConfigProperty_DayNightLength";
            this.ConfigProperty_DayNightLength.Size = new System.Drawing.Size(496, 45);
            this.ConfigProperty_DayNightLength.TabIndex = 9;
            this.ConfigProperty_DayNightLength.TickFrequency = 10;
            this.toolTip.SetToolTip(this.ConfigProperty_DayNightLength, "Real world minutes per in-game day: 60 minutes.");
            this.ConfigProperty_DayNightLength.Value = 60;
            this.ConfigProperty_DayNightLength.Scroll += new System.EventHandler(this.Day_Length_Scroll);
            // 
            // BlockDamagePlayer_GroupBox
            // 
            this.BlockDamagePlayer_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BlockDamagePlayer_GroupBox.Controls.Add(this.ConfigProperty_BlockDamagePlayer);
            this.BlockDamagePlayer_GroupBox.Location = new System.Drawing.Point(708, 146);
            this.BlockDamagePlayer_GroupBox.Name = "BlockDamagePlayer_GroupBox";
            this.BlockDamagePlayer_GroupBox.Size = new System.Drawing.Size(179, 65);
            this.BlockDamagePlayer_GroupBox.TabIndex = 37;
            this.BlockDamagePlayer_GroupBox.TabStop = false;
            this.BlockDamagePlayer_GroupBox.Text = "Player Block Damage";
            // 
            // ConfigProperty_BlockDamagePlayer
            // 
            this.ConfigProperty_BlockDamagePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_BlockDamagePlayer.Location = new System.Drawing.Point(6, 14);
            this.ConfigProperty_BlockDamagePlayer.Maximum = 1000;
            this.ConfigProperty_BlockDamagePlayer.Minimum = 1;
            this.ConfigProperty_BlockDamagePlayer.Name = "ConfigProperty_BlockDamagePlayer";
            this.ConfigProperty_BlockDamagePlayer.Size = new System.Drawing.Size(167, 45);
            this.ConfigProperty_BlockDamagePlayer.SmallChange = 10;
            this.ConfigProperty_BlockDamagePlayer.TabIndex = 9;
            this.ConfigProperty_BlockDamagePlayer.TickFrequency = 10;
            this.toolTip.SetToolTip(this.ConfigProperty_BlockDamagePlayer, "How much damage do players to blocks (percentage in whole numbers).");
            this.ConfigProperty_BlockDamagePlayer.Value = 100;
            this.ConfigProperty_BlockDamagePlayer.Scroll += new System.EventHandler(this.Bdm_Scroll);
            // 
            // DropOnDeath_GroupBox
            // 
            this.DropOnDeath_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DropOnDeath_GroupBox.Controls.Add(this.ConfigProperty_DropOnDeath);
            this.DropOnDeath_GroupBox.Location = new System.Drawing.Point(362, 436);
            this.DropOnDeath_GroupBox.Name = "DropOnDeath_GroupBox";
            this.DropOnDeath_GroupBox.Size = new System.Drawing.Size(156, 48);
            this.DropOnDeath_GroupBox.TabIndex = 32;
            this.DropOnDeath_GroupBox.TabStop = false;
            this.DropOnDeath_GroupBox.Text = "Drop On Death";
            // 
            // GameDifficulty_GroupBox
            // 
            this.GameDifficulty_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GameDifficulty_GroupBox.Controls.Add(this.ConfigProperty_GameDifficulty);
            this.GameDifficulty_GroupBox.Location = new System.Drawing.Point(523, 146);
            this.GameDifficulty_GroupBox.Name = "GameDifficulty_GroupBox";
            this.GameDifficulty_GroupBox.Size = new System.Drawing.Size(179, 65);
            this.GameDifficulty_GroupBox.TabIndex = 31;
            this.GameDifficulty_GroupBox.TabStop = false;
            this.GameDifficulty_GroupBox.Text = "Difficulty";
            // 
            // ConfigProperty_GameDifficulty
            // 
            this.ConfigProperty_GameDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_GameDifficulty.Location = new System.Drawing.Point(6, 13);
            this.ConfigProperty_GameDifficulty.Maximum = 5;
            this.ConfigProperty_GameDifficulty.Name = "ConfigProperty_GameDifficulty";
            this.ConfigProperty_GameDifficulty.Size = new System.Drawing.Size(167, 45);
            this.ConfigProperty_GameDifficulty.TabIndex = 9;
            this.toolTip.SetToolTip(this.ConfigProperty_GameDifficulty, "0 - 5, 0=easiest, 5=hardest");
            this.ConfigProperty_GameDifficulty.Value = 1;
            this.ConfigProperty_GameDifficulty.Scroll += new System.EventHandler(this.Trudnosc_Scroll);
            // 
            // Server_Options_TabPage
            // 
            this.Server_Options_TabPage.Controls.Add(this.BloodMoon_GroupBox);
            this.Server_Options_TabPage.Controls.Add(this.Server_Login_Confirmation_Text_GroupBox);
            this.Server_Options_TabPage.Controls.Add(this.Server_Password_GroupBox);
            this.Server_Options_TabPage.Controls.Add(this.Server_Name_GroupBox);
            this.Server_Options_TabPage.Controls.Add(this.ServerWebsiteURL_GroupBox);
            this.Server_Options_TabPage.Controls.Add(this.ServerDescription_GroupBox);
            this.Server_Options_TabPage.Controls.Add(this.User_Data_Folder_GroupBox);
            this.Server_Options_TabPage.Controls.Add(this.Save_Game_Folder_GroupBox);
            this.Server_Options_TabPage.Controls.Add(this.Server_Admin_Config_File_GroupBox);
            this.Server_Options_TabPage.Controls.Add(this.Game_World_Settings_GroupBox);
            this.Server_Options_TabPage.Controls.Add(this.ServerListAndPassword_GroupBox);
            this.Server_Options_TabPage.Controls.Add(this.Other_Game_Settings_GroupBox);
            this.Server_Options_TabPage.Controls.Add(this.autobots);
            this.Server_Options_TabPage.ImageIndex = 6;
            this.Server_Options_TabPage.Location = new System.Drawing.Point(4, 50);
            this.Server_Options_TabPage.Name = "Server_Options_TabPage";
            this.Server_Options_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Server_Options_TabPage.Size = new System.Drawing.Size(897, 630);
            this.Server_Options_TabPage.TabIndex = 1;
            this.Server_Options_TabPage.UseVisualStyleBackColor = true;
            // 
            // Server_Login_Confirmation_Text_GroupBox
            // 
            this.Server_Login_Confirmation_Text_GroupBox.Controls.Add(this.ConfigProperty_ServerLoginConfirmationText);
            this.Server_Login_Confirmation_Text_GroupBox.Location = new System.Drawing.Point(8, 222);
            this.Server_Login_Confirmation_Text_GroupBox.Name = "Server_Login_Confirmation_Text_GroupBox";
            this.Server_Login_Confirmation_Text_GroupBox.Size = new System.Drawing.Size(369, 144);
            this.Server_Login_Confirmation_Text_GroupBox.TabIndex = 40;
            this.Server_Login_Confirmation_Text_GroupBox.TabStop = false;
            this.Server_Login_Confirmation_Text_GroupBox.Text = "Server Login Confirmation Text";
            // 
            // ConfigProperty_ServerLoginConfirmationText
            // 
            this.ConfigProperty_ServerLoginConfirmationText.Location = new System.Drawing.Point(9, 20);
            this.ConfigProperty_ServerLoginConfirmationText.Multiline = false;
            this.ConfigProperty_ServerLoginConfirmationText.Name = "ConfigProperty_ServerLoginConfirmationText";
            this.ConfigProperty_ServerLoginConfirmationText.Size = new System.Drawing.Size(354, 117);
            this.ConfigProperty_ServerLoginConfirmationText.TabIndex = 0;
            this.ConfigProperty_ServerLoginConfirmationText.Text = "";
            this.toolTip.SetToolTip(this.ConfigProperty_ServerLoginConfirmationText, resources.GetString("ConfigProperty_ServerLoginConfirmationText.ToolTip"));
            // 
            // Server_Password_GroupBox
            // 
            this.Server_Password_GroupBox.Controls.Add(this.ConfigProperty_ServerPassword);
            this.Server_Password_GroupBox.Location = new System.Drawing.Point(8, 168);
            this.Server_Password_GroupBox.Name = "Server_Password_GroupBox";
            this.Server_Password_GroupBox.Size = new System.Drawing.Size(369, 48);
            this.Server_Password_GroupBox.TabIndex = 43;
            this.Server_Password_GroupBox.TabStop = false;
            this.Server_Password_GroupBox.Text = "Server Password";
            // 
            // ConfigProperty_ServerPassword
            // 
            this.ConfigProperty_ServerPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_ServerPassword.Location = new System.Drawing.Point(9, 19);
            this.ConfigProperty_ServerPassword.Name = "ConfigProperty_ServerPassword";
            this.ConfigProperty_ServerPassword.Size = new System.Drawing.Size(354, 20);
            this.ConfigProperty_ServerPassword.TabIndex = 30;
            this.toolTip.SetToolTip(this.ConfigProperty_ServerPassword, "Password to gain entry to the server.");
            // 
            // Server_Name_GroupBox
            // 
            this.Server_Name_GroupBox.Controls.Add(this.ConfigProperty_ServerName);
            this.Server_Name_GroupBox.Location = new System.Drawing.Point(8, 6);
            this.Server_Name_GroupBox.Name = "Server_Name_GroupBox";
            this.Server_Name_GroupBox.Size = new System.Drawing.Size(369, 48);
            this.Server_Name_GroupBox.TabIndex = 40;
            this.Server_Name_GroupBox.TabStop = false;
            this.Server_Name_GroupBox.Text = "Server Name";
            // 
            // ConfigProperty_ServerName
            // 
            this.ConfigProperty_ServerName.Location = new System.Drawing.Point(6, 19);
            this.ConfigProperty_ServerName.Name = "ConfigProperty_ServerName";
            this.ConfigProperty_ServerName.Size = new System.Drawing.Size(357, 20);
            this.ConfigProperty_ServerName.TabIndex = 3;
            this.ConfigProperty_ServerName.Text = "7DaysServerManager";
            this.toolTip.SetToolTip(this.ConfigProperty_ServerName, "Whatever you want the name of the server to be.");
            this.ConfigProperty_ServerName.TextChanged += new System.EventHandler(this.Server_nazwa_TextChanged);
            // 
            // ServerWebsiteURL_GroupBox
            // 
            this.ServerWebsiteURL_GroupBox.Controls.Add(this.ConfigProperty_ServerWebsiteURL);
            this.ServerWebsiteURL_GroupBox.Location = new System.Drawing.Point(8, 114);
            this.ServerWebsiteURL_GroupBox.Name = "ServerWebsiteURL_GroupBox";
            this.ServerWebsiteURL_GroupBox.Size = new System.Drawing.Size(369, 48);
            this.ServerWebsiteURL_GroupBox.TabIndex = 42;
            this.ServerWebsiteURL_GroupBox.TabStop = false;
            this.ServerWebsiteURL_GroupBox.Text = "Server Website URL";
            // 
            // ConfigProperty_ServerWebsiteURL
            // 
            this.ConfigProperty_ServerWebsiteURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_ServerWebsiteURL.Location = new System.Drawing.Point(9, 19);
            this.ConfigProperty_ServerWebsiteURL.Name = "ConfigProperty_ServerWebsiteURL";
            this.ConfigProperty_ServerWebsiteURL.Size = new System.Drawing.Size(354, 20);
            this.ConfigProperty_ServerWebsiteURL.TabIndex = 30;
            this.toolTip.SetToolTip(this.ConfigProperty_ServerWebsiteURL, "Website URL for the server, will be shown in the server browser as a clickable li" +
        "nk.");
            // 
            // ServerDescription_GroupBox
            // 
            this.ServerDescription_GroupBox.Controls.Add(this.ConfigProperty_ServerDescription);
            this.ServerDescription_GroupBox.Location = new System.Drawing.Point(8, 60);
            this.ServerDescription_GroupBox.Name = "ServerDescription_GroupBox";
            this.ServerDescription_GroupBox.Size = new System.Drawing.Size(369, 48);
            this.ServerDescription_GroupBox.TabIndex = 41;
            this.ServerDescription_GroupBox.TabStop = false;
            this.ServerDescription_GroupBox.Text = "Server Description";
            // 
            // ConfigProperty_ServerDescription
            // 
            this.ConfigProperty_ServerDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_ServerDescription.Location = new System.Drawing.Point(9, 19);
            this.ConfigProperty_ServerDescription.Name = "ConfigProperty_ServerDescription";
            this.ConfigProperty_ServerDescription.Size = new System.Drawing.Size(354, 20);
            this.ConfigProperty_ServerDescription.TabIndex = 30;
            this.ConfigProperty_ServerDescription.Text = "Powered by 7DSM";
            this.toolTip.SetToolTip(this.ConfigProperty_ServerDescription, "Whatever you want the server description to be, will be shown in the server brows" +
        "er.");
            // 
            // User_Data_Folder_GroupBox
            // 
            this.User_Data_Folder_GroupBox.Controls.Add(this.configfile_e);
            this.User_Data_Folder_GroupBox.Controls.Add(this.ConfigProperty_UserDataFolder);
            this.User_Data_Folder_GroupBox.Location = new System.Drawing.Point(194, 516);
            this.User_Data_Folder_GroupBox.Name = "User_Data_Folder_GroupBox";
            this.User_Data_Folder_GroupBox.Size = new System.Drawing.Size(183, 48);
            this.User_Data_Folder_GroupBox.TabIndex = 40;
            this.User_Data_Folder_GroupBox.TabStop = false;
            this.User_Data_Folder_GroupBox.Text = "User Data Folder";
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
            // ConfigProperty_UserDataFolder
            // 
            this.ConfigProperty_UserDataFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_UserDataFolder.Location = new System.Drawing.Point(13, 19);
            this.ConfigProperty_UserDataFolder.Name = "ConfigProperty_UserDataFolder";
            this.ConfigProperty_UserDataFolder.Size = new System.Drawing.Size(101, 20);
            this.ConfigProperty_UserDataFolder.TabIndex = 30;
            this.toolTip.SetToolTip(this.ConfigProperty_UserDataFolder, "Use this to override where the server stores all generated data, including RWG ge" +
        "nerated worlds.");
            this.ConfigProperty_UserDataFolder.TextChanged += new System.EventHandler(this.Configfile_TextChanged);
            // 
            // Save_Game_Folder_GroupBox
            // 
            this.Save_Game_Folder_GroupBox.Controls.Add(this.ConfigProperty_SaveGameFolder);
            this.Save_Game_Folder_GroupBox.Location = new System.Drawing.Point(8, 565);
            this.Save_Game_Folder_GroupBox.Name = "Save_Game_Folder_GroupBox";
            this.Save_Game_Folder_GroupBox.Size = new System.Drawing.Size(369, 48);
            this.Save_Game_Folder_GroupBox.TabIndex = 39;
            this.Save_Game_Folder_GroupBox.TabStop = false;
            this.Save_Game_Folder_GroupBox.Text = "Save Game Folder";
            // 
            // ConfigProperty_SaveGameFolder
            // 
            this.ConfigProperty_SaveGameFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_SaveGameFolder.Location = new System.Drawing.Point(9, 19);
            this.ConfigProperty_SaveGameFolder.Name = "ConfigProperty_SaveGameFolder";
            this.ConfigProperty_SaveGameFolder.Size = new System.Drawing.Size(354, 20);
            this.ConfigProperty_SaveGameFolder.TabIndex = 30;
            this.toolTip.SetToolTip(this.ConfigProperty_SaveGameFolder, "Use this to only override the save game path.");
            this.ConfigProperty_SaveGameFolder.TextChanged += new System.EventHandler(this.Save_TextChanged);
            // 
            // Server_Admin_Config_File_GroupBox
            // 
            this.Server_Admin_Config_File_GroupBox.Controls.Add(this.Server_Admin_Path_Selector_Button);
            this.Server_Admin_Config_File_GroupBox.Controls.Add(this.ConfigProperty_AdminFileName);
            this.Server_Admin_Config_File_GroupBox.Location = new System.Drawing.Point(8, 516);
            this.Server_Admin_Config_File_GroupBox.Name = "Server_Admin_Config_File_GroupBox";
            this.Server_Admin_Config_File_GroupBox.Size = new System.Drawing.Size(180, 48);
            this.Server_Admin_Config_File_GroupBox.TabIndex = 31;
            this.Server_Admin_Config_File_GroupBox.TabStop = false;
            this.Server_Admin_Config_File_GroupBox.Text = "Server Admin Config File";
            // 
            // Server_Admin_Path_Selector_Button
            // 
            this.Server_Admin_Path_Selector_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Server_Admin_Path_Selector_Button.Location = new System.Drawing.Point(117, 17);
            this.Server_Admin_Path_Selector_Button.Name = "Server_Admin_Path_Selector_Button";
            this.Server_Admin_Path_Selector_Button.Size = new System.Drawing.Size(57, 23);
            this.Server_Admin_Path_Selector_Button.TabIndex = 31;
            this.Server_Admin_Path_Selector_Button.Text = "Edit";
            this.Server_Admin_Path_Selector_Button.UseVisualStyleBackColor = true;
            this.Server_Admin_Path_Selector_Button.Click += new System.EventHandler(this.Sa_edit_Click);
            // 
            // ConfigProperty_AdminFileName
            // 
            this.ConfigProperty_AdminFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_AdminFileName.Location = new System.Drawing.Point(13, 19);
            this.ConfigProperty_AdminFileName.Name = "ConfigProperty_AdminFileName";
            this.ConfigProperty_AdminFileName.Size = new System.Drawing.Size(98, 20);
            this.ConfigProperty_AdminFileName.TabIndex = 30;
            this.ConfigProperty_AdminFileName.Text = "serveradmin.xml";
            this.toolTip.SetToolTip(this.ConfigProperty_AdminFileName, "Server admin file name. \r\n\r\nPath relative to the SaveGameFolder.");
            this.ConfigProperty_AdminFileName.TextChanged += new System.EventHandler(this.AdminFileName_TextChanged);
            // 
            // Game_World_Settings_GroupBox
            // 
            this.Game_World_Settings_GroupBox.Controls.Add(this.ConfigProperty_GameMode);
            this.Game_World_Settings_GroupBox.Controls.Add(this.ConfigProperty_WorldGenSize);
            this.Game_World_Settings_GroupBox.Controls.Add(this.ConfigProperty_WorldGenSeed);
            this.Game_World_Settings_GroupBox.Controls.Add(this.ConfigProperty_GameName);
            this.Game_World_Settings_GroupBox.Controls.Add(this.ConfigProperty_GameWorld);
            this.Game_World_Settings_GroupBox.Location = new System.Drawing.Point(383, 420);
            this.Game_World_Settings_GroupBox.Name = "Game_World_Settings_GroupBox";
            this.Game_World_Settings_GroupBox.Size = new System.Drawing.Size(508, 98);
            this.Game_World_Settings_GroupBox.TabIndex = 28;
            this.Game_World_Settings_GroupBox.TabStop = false;
            this.Game_World_Settings_GroupBox.Text = "Game World Settings";
            // 
            // ConfigProperty_GameMode
            // 
            this.ConfigProperty_GameMode.DisplayMember = "a";
            this.ConfigProperty_GameMode.Enabled = false;
            this.ConfigProperty_GameMode.FormattingEnabled = true;
            this.ConfigProperty_GameMode.Items.AddRange(new object[] {
            "GameModeSurvival"});
            this.ConfigProperty_GameMode.Location = new System.Drawing.Point(6, 20);
            this.ConfigProperty_GameMode.Name = "ConfigProperty_GameMode";
            this.ConfigProperty_GameMode.Size = new System.Drawing.Size(160, 21);
            this.ConfigProperty_GameMode.TabIndex = 10;
            this.ConfigProperty_GameMode.Text = "GameModeSurvival";
            this.toolTip.SetToolTip(this.ConfigProperty_GameMode, "The only mode available at the moment is GameModeSurvival.");
            // 
            // ConfigProperty_WorldGenSize
            // 
            this.ConfigProperty_WorldGenSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_WorldGenSize.Location = new System.Drawing.Point(6, 47);
            this.ConfigProperty_WorldGenSize.Maximum = 16384;
            this.ConfigProperty_WorldGenSize.Minimum = 2048;
            this.ConfigProperty_WorldGenSize.Name = "ConfigProperty_WorldGenSize";
            this.ConfigProperty_WorldGenSize.Size = new System.Drawing.Size(496, 45);
            this.ConfigProperty_WorldGenSize.TabIndex = 9;
            this.toolTip.SetToolTip(this.ConfigProperty_WorldGenSize, resources.GetString("ConfigProperty_WorldGenSize.ToolTip"));
            this.ConfigProperty_WorldGenSize.Value = 2048;
            // 
            // ConfigProperty_WorldGenSeed
            // 
            this.ConfigProperty_WorldGenSeed.Location = new System.Drawing.Point(288, 20);
            this.ConfigProperty_WorldGenSeed.Name = "ConfigProperty_WorldGenSeed";
            this.ConfigProperty_WorldGenSeed.PasswordChar = '*';
            this.ConfigProperty_WorldGenSeed.Size = new System.Drawing.Size(115, 20);
            this.ConfigProperty_WorldGenSeed.TabIndex = 5;
            this.toolTip.SetToolTip(this.ConfigProperty_WorldGenSeed, "If RWG this is the seed for the generation of the new world. \r\n\r\nIf a world with " +
        "the resulting name already exists it will simply load it.");
            // 
            // ConfigProperty_GameName
            // 
            this.ConfigProperty_GameName.FormattingEnabled = true;
            this.ConfigProperty_GameName.Location = new System.Drawing.Point(172, 20);
            this.ConfigProperty_GameName.Name = "ConfigProperty_GameName";
            this.ConfigProperty_GameName.Size = new System.Drawing.Size(110, 21);
            this.ConfigProperty_GameName.TabIndex = 4;
            this.toolTip.SetToolTip(this.ConfigProperty_GameName, resources.GetString("ConfigProperty_GameName.ToolTip"));
            this.ConfigProperty_GameName.TextChanged += new System.EventHandler(this.Nazwa_TextChanged);
            // 
            // ConfigProperty_GameWorld
            // 
            this.ConfigProperty_GameWorld.DisplayMember = "a";
            this.ConfigProperty_GameWorld.FormattingEnabled = true;
            this.ConfigProperty_GameWorld.Items.AddRange(new object[] {
            "Navegane",
            "RWG"});
            this.ConfigProperty_GameWorld.Location = new System.Drawing.Point(409, 20);
            this.ConfigProperty_GameWorld.Name = "ConfigProperty_GameWorld";
            this.ConfigProperty_GameWorld.Size = new System.Drawing.Size(93, 21);
            this.ConfigProperty_GameWorld.TabIndex = 2;
            this.ConfigProperty_GameWorld.Text = "Navezgane";
            this.toolTip.SetToolTip(this.ConfigProperty_GameWorld, "\"RWG\" (see WorldGenSeed and WorldGenSize options below) or any already existing w" +
        "orld name in the Worlds folder (currently shipping with e.g. \"Navezgane\", \"PREGE" +
        "N01\", ...)");
            this.ConfigProperty_GameWorld.SelectedIndexChanged += new System.EventHandler(this.Mapa_SelectedIndexChanged);
            // 
            // ServerListAndPassword_GroupBox
            // 
            this.ServerListAndPassword_GroupBox.Controls.Add(this.ServerPassword);
            this.ServerListAndPassword_GroupBox.Controls.Add(this.ServerIsPublic);
            this.ServerListAndPassword_GroupBox.Location = new System.Drawing.Point(8, 467);
            this.ServerListAndPassword_GroupBox.Name = "ServerListAndPassword_GroupBox";
            this.ServerListAndPassword_GroupBox.Size = new System.Drawing.Size(369, 43);
            this.ServerListAndPassword_GroupBox.TabIndex = 25;
            this.ServerListAndPassword_GroupBox.TabStop = false;
            this.ServerListAndPassword_GroupBox.Text = "Servers List And Server Password";
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
            // Other_Game_Settings_GroupBox
            // 
            this.Other_Game_Settings_GroupBox.Controls.Add(this.ConfigProperty_EACEnabled);
            this.Other_Game_Settings_GroupBox.Controls.Add(this.Save_Logs_To_Files_CheckBox);
            this.Other_Game_Settings_GroupBox.Location = new System.Drawing.Point(11, 395);
            this.Other_Game_Settings_GroupBox.Name = "Other_Game_Settings_GroupBox";
            this.Other_Game_Settings_GroupBox.Size = new System.Drawing.Size(366, 66);
            this.Other_Game_Settings_GroupBox.TabIndex = 24;
            this.Other_Game_Settings_GroupBox.TabStop = false;
            this.Other_Game_Settings_GroupBox.Text = "Other Game Settings";
            // 
            // ConfigProperty_EACEnabled
            // 
            this.ConfigProperty_EACEnabled.AutoSize = true;
            this.ConfigProperty_EACEnabled.Checked = true;
            this.ConfigProperty_EACEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConfigProperty_EACEnabled.Location = new System.Drawing.Point(9, 41);
            this.ConfigProperty_EACEnabled.Name = "ConfigProperty_EACEnabled";
            this.ConfigProperty_EACEnabled.Size = new System.Drawing.Size(134, 17);
            this.ConfigProperty_EACEnabled.TabIndex = 3;
            this.ConfigProperty_EACEnabled.Text = "Enable Easy AntiCheat";
            this.toolTip.SetToolTip(this.ConfigProperty_EACEnabled, "Enables/Disables EasyAntiCheat.");
            this.ConfigProperty_EACEnabled.UseVisualStyleBackColor = true;
            this.ConfigProperty_EACEnabled.CheckedChanged += new System.EventHandler(this.VACEnabled_CheckedChanged);
            // 
            // Save_Logs_To_Files_CheckBox
            // 
            this.Save_Logs_To_Files_CheckBox.AutoSize = true;
            this.Save_Logs_To_Files_CheckBox.Location = new System.Drawing.Point(9, 18);
            this.Save_Logs_To_Files_CheckBox.Name = "Save_Logs_To_Files_CheckBox";
            this.Save_Logs_To_Files_CheckBox.Size = new System.Drawing.Size(117, 17);
            this.Save_Logs_To_Files_CheckBox.TabIndex = 1;
            this.Save_Logs_To_Files_CheckBox.Text = "Save Logs To Files";
            this.Save_Logs_To_Files_CheckBox.UseVisualStyleBackColor = true;
            this.Save_Logs_To_Files_CheckBox.CheckedChanged += new System.EventHandler(this.Save_logfiles_CheckedChanged);
            // 
            // autobots
            // 
            this.autobots.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autobots.Controls.Add(this.Player_Safe_Zone_Hours_Label);
            this.autobots.Controls.Add(this.Player_Safe_Zone_Level_Label);
            this.autobots.Controls.Add(this.ConfigProperty_PlayerSafeZoneHours);
            this.autobots.Controls.Add(this.ConfigProperty_PlayerSafeZoneLevel);
            this.autobots.Controls.Add(this.BedrollExpiryTime_GroupBox);
            this.autobots.Controls.Add(this.ConfigProperty_EnemySpawnMode);
            this.autobots.Controls.Add(this.BedrollDeadZoneSize_GroupBox);
            this.autobots.Controls.Add(this.BloodMoonEnemyCount_GroupBox);
            this.autobots.Controls.Add(this.AirDropMarker);
            this.autobots.Controls.Add(this.MaxSpawnedAnimals_GroupBox);
            this.autobots.Controls.Add(this.MaxSpawnedZombies_GroupBox);
            this.autobots.Location = new System.Drawing.Point(383, 6);
            this.autobots.Name = "autobots";
            this.autobots.Size = new System.Drawing.Size(508, 409);
            this.autobots.TabIndex = 38;
            this.autobots.TabStop = false;
            this.autobots.Text = "Spawn";
            // 
            // ConfigProperty_EnemySpawnMode
            // 
            this.ConfigProperty_EnemySpawnMode.AutoSize = true;
            this.ConfigProperty_EnemySpawnMode.Checked = true;
            this.ConfigProperty_EnemySpawnMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConfigProperty_EnemySpawnMode.Enabled = false;
            this.ConfigProperty_EnemySpawnMode.Location = new System.Drawing.Point(6, 45);
            this.ConfigProperty_EnemySpawnMode.Name = "ConfigProperty_EnemySpawnMode";
            this.ConfigProperty_EnemySpawnMode.Size = new System.Drawing.Size(144, 17);
            this.ConfigProperty_EnemySpawnMode.TabIndex = 16;
            this.ConfigProperty_EnemySpawnMode.Text = "Enable Enemy Spawning";
            this.toolTip.SetToolTip(this.ConfigProperty_EnemySpawnMode, "Enable/Disable enemy spawning.");
            this.ConfigProperty_EnemySpawnMode.UseVisualStyleBackColor = true;
            this.ConfigProperty_EnemySpawnMode.CheckedChanged += new System.EventHandler(this.EnemySpawnMode_CheckedChanged);
            // 
            // BedrollDeadZoneSize_GroupBox
            // 
            this.BedrollDeadZoneSize_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BedrollDeadZoneSize_GroupBox.Controls.Add(this.ConfigProperty_BedrollDeadZoneSize);
            this.BedrollDeadZoneSize_GroupBox.Location = new System.Drawing.Point(6, 339);
            this.BedrollDeadZoneSize_GroupBox.Name = "BedrollDeadZoneSize_GroupBox";
            this.BedrollDeadZoneSize_GroupBox.Size = new System.Drawing.Size(496, 63);
            this.BedrollDeadZoneSize_GroupBox.TabIndex = 15;
            this.BedrollDeadZoneSize_GroupBox.TabStop = false;
            this.BedrollDeadZoneSize_GroupBox.Text = "Minimum Enemy Spawn Block Distance From Bedroll";
            // 
            // ConfigProperty_BedrollDeadZoneSize
            // 
            this.ConfigProperty_BedrollDeadZoneSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_BedrollDeadZoneSize.Location = new System.Drawing.Point(6, 13);
            this.ConfigProperty_BedrollDeadZoneSize.Maximum = 150;
            this.ConfigProperty_BedrollDeadZoneSize.Name = "ConfigProperty_BedrollDeadZoneSize";
            this.ConfigProperty_BedrollDeadZoneSize.Size = new System.Drawing.Size(484, 45);
            this.ConfigProperty_BedrollDeadZoneSize.TabIndex = 8;
            this.toolTip.SetToolTip(this.ConfigProperty_BedrollDeadZoneSize, resources.GetString("ConfigProperty_BedrollDeadZoneSize.ToolTip"));
            this.ConfigProperty_BedrollDeadZoneSize.Value = 15;
            this.ConfigProperty_BedrollDeadZoneSize.Scroll += new System.EventHandler(this.BedrollDeadZoneSize_Scroll);
            // 
            // BloodMoonEnemyCount_GroupBox
            // 
            this.BloodMoonEnemyCount_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BloodMoonEnemyCount_GroupBox.Controls.Add(this.ConfigProperty_BloodMoonEnemyCount);
            this.BloodMoonEnemyCount_GroupBox.Location = new System.Drawing.Point(6, 275);
            this.BloodMoonEnemyCount_GroupBox.Name = "BloodMoonEnemyCount_GroupBox";
            this.BloodMoonEnemyCount_GroupBox.Size = new System.Drawing.Size(496, 64);
            this.BloodMoonEnemyCount_GroupBox.TabIndex = 14;
            this.BloodMoonEnemyCount_GroupBox.TabStop = false;
            this.BloodMoonEnemyCount_GroupBox.Text = "Zombies Spawned For Every Player During Blood Moon";
            // 
            // ConfigProperty_BloodMoonEnemyCount
            // 
            this.ConfigProperty_BloodMoonEnemyCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_BloodMoonEnemyCount.Location = new System.Drawing.Point(6, 13);
            this.ConfigProperty_BloodMoonEnemyCount.Maximum = 50;
            this.ConfigProperty_BloodMoonEnemyCount.Name = "ConfigProperty_BloodMoonEnemyCount";
            this.ConfigProperty_BloodMoonEnemyCount.Size = new System.Drawing.Size(484, 45);
            this.ConfigProperty_BloodMoonEnemyCount.TabIndex = 8;
            this.toolTip.SetToolTip(this.ConfigProperty_BloodMoonEnemyCount, "The number of zombies spawned during blood moons per player.");
            this.ConfigProperty_BloodMoonEnemyCount.Value = 8;
            this.ConfigProperty_BloodMoonEnemyCount.Scroll += new System.EventHandler(this.BloodMoonEnemyCount_Scroll);
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
            // MaxSpawnedAnimals_GroupBox
            // 
            this.MaxSpawnedAnimals_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxSpawnedAnimals_GroupBox.Controls.Add(this.ConfigProperty_MaxSpawnedAnimals);
            this.MaxSpawnedAnimals_GroupBox.Location = new System.Drawing.Point(6, 210);
            this.MaxSpawnedAnimals_GroupBox.Name = "MaxSpawnedAnimals_GroupBox";
            this.MaxSpawnedAnimals_GroupBox.Size = new System.Drawing.Size(496, 64);
            this.MaxSpawnedAnimals_GroupBox.TabIndex = 12;
            this.MaxSpawnedAnimals_GroupBox.TabStop = false;
            this.MaxSpawnedAnimals_GroupBox.Text = "Max Spawned Animals";
            this.toolTip.SetToolTip(this.MaxSpawnedAnimals_GroupBox, resources.GetString("MaxSpawnedAnimals_GroupBox.ToolTip"));
            // 
            // ConfigProperty_MaxSpawnedAnimals
            // 
            this.ConfigProperty_MaxSpawnedAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_MaxSpawnedAnimals.Location = new System.Drawing.Point(6, 13);
            this.ConfigProperty_MaxSpawnedAnimals.Maximum = 240;
            this.ConfigProperty_MaxSpawnedAnimals.Minimum = 1;
            this.ConfigProperty_MaxSpawnedAnimals.Name = "ConfigProperty_MaxSpawnedAnimals";
            this.ConfigProperty_MaxSpawnedAnimals.Size = new System.Drawing.Size(484, 45);
            this.ConfigProperty_MaxSpawnedAnimals.TabIndex = 8;
            this.toolTip.SetToolTip(this.ConfigProperty_MaxSpawnedAnimals, resources.GetString("ConfigProperty_MaxSpawnedAnimals.ToolTip"));
            this.ConfigProperty_MaxSpawnedAnimals.Value = 50;
            this.ConfigProperty_MaxSpawnedAnimals.Scroll += new System.EventHandler(this.MaxSpawnedAnimals_Scroll);
            // 
            // MaxSpawnedZombies_GroupBox
            // 
            this.MaxSpawnedZombies_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxSpawnedZombies_GroupBox.Controls.Add(this.ConfigProperty_MaxSpawnedZombies);
            this.MaxSpawnedZombies_GroupBox.Location = new System.Drawing.Point(6, 146);
            this.MaxSpawnedZombies_GroupBox.Name = "MaxSpawnedZombies_GroupBox";
            this.MaxSpawnedZombies_GroupBox.Size = new System.Drawing.Size(496, 64);
            this.MaxSpawnedZombies_GroupBox.TabIndex = 11;
            this.MaxSpawnedZombies_GroupBox.TabStop = false;
            this.MaxSpawnedZombies_GroupBox.Text = "Max Spawned Zombies";
            // 
            // ConfigProperty_MaxSpawnedZombies
            // 
            this.ConfigProperty_MaxSpawnedZombies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_MaxSpawnedZombies.Location = new System.Drawing.Point(6, 13);
            this.ConfigProperty_MaxSpawnedZombies.Maximum = 240;
            this.ConfigProperty_MaxSpawnedZombies.Minimum = 1;
            this.ConfigProperty_MaxSpawnedZombies.Name = "ConfigProperty_MaxSpawnedZombies";
            this.ConfigProperty_MaxSpawnedZombies.Size = new System.Drawing.Size(484, 45);
            this.ConfigProperty_MaxSpawnedZombies.TabIndex = 8;
            this.toolTip.SetToolTip(this.ConfigProperty_MaxSpawnedZombies, "Making this number too large (more than about 80) may cause servers to run at poo" +
        "r framerates which will effect lag and play quality for clients.");
            this.ConfigProperty_MaxSpawnedZombies.Value = 60;
            this.ConfigProperty_MaxSpawnedZombies.Scroll += new System.EventHandler(this.MaxSpawnedZombies_Scroll);
            // 
            // Web_Options_TabPage
            // 
            this.Web_Options_TabPage.Controls.Add(this.Terminal_Window_Group_Box);
            this.Web_Options_TabPage.Controls.Add(this.groupBox3);
            this.Web_Options_TabPage.Controls.Add(this.Server_Visibility_GroupBox);
            this.Web_Options_TabPage.Controls.Add(this.MaxUncoveredMapChunksPerPlayer_g);
            this.Web_Options_TabPage.Controls.Add(this.HideCommandExecutionLog_GroupBox);
            this.Web_Options_TabPage.Controls.Add(this.ServerDisabledNetworkProtocols_g);
            this.Web_Options_TabPage.Controls.Add(this.Telnet_Settings_GroupBox);
            this.Web_Options_TabPage.Controls.Add(this.port_g);
            this.Web_Options_TabPage.Controls.Add(this.Admin_Control_Panel_GroupBox);
            this.Web_Options_TabPage.ImageIndex = 12;
            this.Web_Options_TabPage.Location = new System.Drawing.Point(4, 50);
            this.Web_Options_TabPage.Name = "Web_Options_TabPage";
            this.Web_Options_TabPage.Size = new System.Drawing.Size(897, 630);
            this.Web_Options_TabPage.TabIndex = 3;
            this.Web_Options_TabPage.UseVisualStyleBackColor = true;
            // 
            // Terminal_Window_Group_Box
            // 
            this.Terminal_Window_Group_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Terminal_Window_Group_Box.Controls.Add(this.ConfigProperty_TerminalWindowEnabled);
            this.Terminal_Window_Group_Box.Location = new System.Drawing.Point(505, 180);
            this.Terminal_Window_Group_Box.Name = "Terminal_Window_Group_Box";
            this.Terminal_Window_Group_Box.Size = new System.Drawing.Size(382, 48);
            this.Terminal_Window_Group_Box.TabIndex = 53;
            this.Terminal_Window_Group_Box.TabStop = false;
            this.Terminal_Window_Group_Box.Text = "Terminal Window";
            // 
            // ConfigProperty_TerminalWindowEnabled
            // 
            this.ConfigProperty_TerminalWindowEnabled.AutoSize = true;
            this.ConfigProperty_TerminalWindowEnabled.Checked = true;
            this.ConfigProperty_TerminalWindowEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConfigProperty_TerminalWindowEnabled.Location = new System.Drawing.Point(6, 19);
            this.ConfigProperty_TerminalWindowEnabled.Name = "ConfigProperty_TerminalWindowEnabled";
            this.ConfigProperty_TerminalWindowEnabled.Size = new System.Drawing.Size(59, 17);
            this.ConfigProperty_TerminalWindowEnabled.TabIndex = 0;
            this.ConfigProperty_TerminalWindowEnabled.Text = "Enable";
            this.toolTip.SetToolTip(this.ConfigProperty_TerminalWindowEnabled, "Show a terminal window for log output / command input (Windows only).");
            this.ConfigProperty_TerminalWindowEnabled.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ConfigProperty_ServerMaxWorldTransferSpeedKiBs);
            this.groupBox3.Location = new System.Drawing.Point(8, 435);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 69);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Max World Transfer Speed (KiB/s)";
            // 
            // ConfigProperty_ServerMaxWorldTransferSpeedKiBs
            // 
            this.ConfigProperty_ServerMaxWorldTransferSpeedKiBs.Location = new System.Drawing.Point(7, 20);
            this.ConfigProperty_ServerMaxWorldTransferSpeedKiBs.Maximum = 1300;
            this.ConfigProperty_ServerMaxWorldTransferSpeedKiBs.Minimum = 32;
            this.ConfigProperty_ServerMaxWorldTransferSpeedKiBs.Name = "ConfigProperty_ServerMaxWorldTransferSpeedKiBs";
            this.ConfigProperty_ServerMaxWorldTransferSpeedKiBs.Size = new System.Drawing.Size(471, 45);
            this.ConfigProperty_ServerMaxWorldTransferSpeedKiBs.TabIndex = 0;
            this.ConfigProperty_ServerMaxWorldTransferSpeedKiBs.Value = 512;
            // 
            // Server_Visibility_GroupBox
            // 
            this.Server_Visibility_GroupBox.Controls.Add(this.ConfigProperty_ServerVisibility);
            this.Server_Visibility_GroupBox.Location = new System.Drawing.Point(279, 381);
            this.Server_Visibility_GroupBox.Name = "Server_Visibility_GroupBox";
            this.Server_Visibility_GroupBox.Size = new System.Drawing.Size(214, 48);
            this.Server_Visibility_GroupBox.TabIndex = 24;
            this.Server_Visibility_GroupBox.TabStop = false;
            this.Server_Visibility_GroupBox.Text = "Server Visibility";
            // 
            // ConfigProperty_ServerVisibility
            // 
            this.ConfigProperty_ServerVisibility.FormattingEnabled = true;
            this.ConfigProperty_ServerVisibility.Items.AddRange(new object[] {
            "Not Listed",
            "Only Listed To Friends",
            "Public"});
            this.ConfigProperty_ServerVisibility.Location = new System.Drawing.Point(6, 19);
            this.ConfigProperty_ServerVisibility.Name = "ConfigProperty_ServerVisibility";
            this.ConfigProperty_ServerVisibility.Size = new System.Drawing.Size(201, 21);
            this.ConfigProperty_ServerVisibility.TabIndex = 0;
            this.toolTip.SetToolTip(this.ConfigProperty_ServerVisibility, resources.GetString("ConfigProperty_ServerVisibility.ToolTip"));
            // 
            // MaxUncoveredMapChunksPerPlayer_g
            // 
            this.MaxUncoveredMapChunksPerPlayer_g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxUncoveredMapChunksPerPlayer_g.Controls.Add(this.ConfigProperty_MaxUncoveredMapChunksPerPlayer);
            this.MaxUncoveredMapChunksPerPlayer_g.Location = new System.Drawing.Point(505, 126);
            this.MaxUncoveredMapChunksPerPlayer_g.Name = "MaxUncoveredMapChunksPerPlayer_g";
            this.MaxUncoveredMapChunksPerPlayer_g.Size = new System.Drawing.Size(382, 48);
            this.MaxUncoveredMapChunksPerPlayer_g.TabIndex = 52;
            this.MaxUncoveredMapChunksPerPlayer_g.TabStop = false;
            this.MaxUncoveredMapChunksPerPlayer_g.Text = "Max uncovered map chunks per player";
            // 
            // ConfigProperty_MaxUncoveredMapChunksPerPlayer
            // 
            this.ConfigProperty_MaxUncoveredMapChunksPerPlayer.Location = new System.Drawing.Point(6, 19);
            this.ConfigProperty_MaxUncoveredMapChunksPerPlayer.Name = "ConfigProperty_MaxUncoveredMapChunksPerPlayer";
            this.ConfigProperty_MaxUncoveredMapChunksPerPlayer.Size = new System.Drawing.Size(70, 20);
            this.ConfigProperty_MaxUncoveredMapChunksPerPlayer.TabIndex = 0;
            this.ConfigProperty_MaxUncoveredMapChunksPerPlayer.Text = "131072";
            this.toolTip.SetToolTip(this.ConfigProperty_MaxUncoveredMapChunksPerPlayer, resources.GetString("ConfigProperty_MaxUncoveredMapChunksPerPlayer.ToolTip"));
            this.ConfigProperty_MaxUncoveredMapChunksPerPlayer.TextChanged += new System.EventHandler(this.MaxUncoveredMapChunksPerPlayer_TextChanged);
            // 
            // HideCommandExecutionLog_GroupBox
            // 
            this.HideCommandExecutionLog_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideCommandExecutionLog_GroupBox.Controls.Add(this.ConfigProperty_HideCommandExecutionLog);
            this.HideCommandExecutionLog_GroupBox.Location = new System.Drawing.Point(505, 3);
            this.HideCommandExecutionLog_GroupBox.Name = "HideCommandExecutionLog_GroupBox";
            this.HideCommandExecutionLog_GroupBox.Size = new System.Drawing.Size(382, 45);
            this.HideCommandExecutionLog_GroupBox.TabIndex = 51;
            this.HideCommandExecutionLog_GroupBox.TabStop = false;
            this.HideCommandExecutionLog_GroupBox.Text = "Hide Command Execution Log";
            // 
            // ConfigProperty_HideCommandExecutionLog
            // 
            this.ConfigProperty_HideCommandExecutionLog.FormattingEnabled = true;
            this.ConfigProperty_HideCommandExecutionLog.Items.AddRange(new object[] {
            "Show Everything",
            "Hide Only From Telnet / Control Panel",
            "Hide From Telnet / Control Panel / Remote Game Clients",
            "Hide Everything"});
            this.ConfigProperty_HideCommandExecutionLog.Location = new System.Drawing.Point(11, 17);
            this.ConfigProperty_HideCommandExecutionLog.Name = "ConfigProperty_HideCommandExecutionLog";
            this.ConfigProperty_HideCommandExecutionLog.Size = new System.Drawing.Size(365, 21);
            this.ConfigProperty_HideCommandExecutionLog.TabIndex = 31;
            this.toolTip.SetToolTip(this.ConfigProperty_HideCommandExecutionLog, "Hide logging of command execution.\r\n\r\n0 = show everything\r\n1 = hide only from Tel" +
        "net/ControlPanel\r\n2 = also hide from remote game clients\r\n3 = hide everything");
            // 
            // ServerDisabledNetworkProtocols_g
            // 
            this.ServerDisabledNetworkProtocols_g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerDisabledNetworkProtocols_g.Controls.Add(this.ConfigProperty_ServerDisabledNetworkProtocols);
            this.ServerDisabledNetworkProtocols_g.Controls.Add(this.RakNet);
            this.ServerDisabledNetworkProtocols_g.Controls.Add(this.SteamNetworking);
            this.ServerDisabledNetworkProtocols_g.Controls.Add(this.UNET);
            this.ServerDisabledNetworkProtocols_g.Location = new System.Drawing.Point(8, 275);
            this.ServerDisabledNetworkProtocols_g.Name = "ServerDisabledNetworkProtocols_g";
            this.ServerDisabledNetworkProtocols_g.Size = new System.Drawing.Size(485, 100);
            this.ServerDisabledNetworkProtocols_g.TabIndex = 31;
            this.ServerDisabledNetworkProtocols_g.TabStop = false;
            this.ServerDisabledNetworkProtocols_g.Text = "Disabled network protocols";
            // 
            // ConfigProperty_ServerDisabledNetworkProtocols
            // 
            this.ConfigProperty_ServerDisabledNetworkProtocols.FormattingEnabled = true;
            this.ConfigProperty_ServerDisabledNetworkProtocols.Items.AddRange(new object[] {
            "LiteNetLib",
            "SteamNetworking"});
            this.ConfigProperty_ServerDisabledNetworkProtocols.Location = new System.Drawing.Point(202, 19);
            this.ConfigProperty_ServerDisabledNetworkProtocols.Name = "ConfigProperty_ServerDisabledNetworkProtocols";
            this.ConfigProperty_ServerDisabledNetworkProtocols.Size = new System.Drawing.Size(215, 64);
            this.ConfigProperty_ServerDisabledNetworkProtocols.TabIndex = 33;
            this.toolTip.SetToolTip(this.ConfigProperty_ServerDisabledNetworkProtocols, " Dedicated servers should disable SteamNetworking if there is no NAT router in be" +
        "tween your users and the server or when port-forwarding is set up correctly.");
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
            // Telnet_Settings_GroupBox
            // 
            this.Telnet_Settings_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Telnet_Settings_GroupBox.Controls.Add(this.label7);
            this.Telnet_Settings_GroupBox.Controls.Add(this.ConfigProperty_TelnetFailedLoginsBlocktime);
            this.Telnet_Settings_GroupBox.Controls.Add(this.label6);
            this.Telnet_Settings_GroupBox.Controls.Add(this.ConfigProperty_TelnetFailedLoginLimit);
            this.Telnet_Settings_GroupBox.Controls.Add(this.ConfigProperty_TelnetEnabled);
            this.Telnet_Settings_GroupBox.Controls.Add(this.telnet_port_l);
            this.Telnet_Settings_GroupBox.Controls.Add(this.ConfigProperty_TelnetPort);
            this.Telnet_Settings_GroupBox.Controls.Add(this.telnet_psw_l);
            this.Telnet_Settings_GroupBox.Controls.Add(this.ConfigProperty_TelnetPassword);
            this.Telnet_Settings_GroupBox.Location = new System.Drawing.Point(8, 107);
            this.Telnet_Settings_GroupBox.Name = "Telnet_Settings_GroupBox";
            this.Telnet_Settings_GroupBox.Size = new System.Drawing.Size(485, 162);
            this.Telnet_Settings_GroupBox.TabIndex = 29;
            this.Telnet_Settings_GroupBox.TabStop = false;
            this.Telnet_Settings_GroupBox.Text = "Telnet Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Failed Login Blocked Time:";
            // 
            // ConfigProperty_TelnetFailedLoginsBlocktime
            // 
            this.ConfigProperty_TelnetFailedLoginsBlocktime.Location = new System.Drawing.Point(159, 119);
            this.ConfigProperty_TelnetFailedLoginsBlocktime.Name = "ConfigProperty_TelnetFailedLoginsBlocktime";
            this.ConfigProperty_TelnetFailedLoginsBlocktime.Size = new System.Drawing.Size(169, 20);
            this.ConfigProperty_TelnetFailedLoginsBlocktime.TabIndex = 20;
            this.ConfigProperty_TelnetFailedLoginsBlocktime.Text = "10";
            this.toolTip.SetToolTip(this.ConfigProperty_TelnetFailedLoginsBlocktime, "How long will the block persist (in seconds).");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Failed Login Limit:";
            // 
            // ConfigProperty_TelnetFailedLoginLimit
            // 
            this.ConfigProperty_TelnetFailedLoginLimit.Location = new System.Drawing.Point(159, 93);
            this.ConfigProperty_TelnetFailedLoginLimit.Name = "ConfigProperty_TelnetFailedLoginLimit";
            this.ConfigProperty_TelnetFailedLoginLimit.Size = new System.Drawing.Size(169, 20);
            this.ConfigProperty_TelnetFailedLoginLimit.TabIndex = 18;
            this.ConfigProperty_TelnetFailedLoginLimit.Text = "10";
            this.toolTip.SetToolTip(this.ConfigProperty_TelnetFailedLoginLimit, "After this many wrong passwords from a single remote client the client will be bl" +
        "ocked from connecting to the Telnet interface.");
            // 
            // ConfigProperty_TelnetEnabled
            // 
            this.ConfigProperty_TelnetEnabled.AutoSize = true;
            this.ConfigProperty_TelnetEnabled.Checked = true;
            this.ConfigProperty_TelnetEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConfigProperty_TelnetEnabled.Location = new System.Drawing.Point(9, 19);
            this.ConfigProperty_TelnetEnabled.Name = "ConfigProperty_TelnetEnabled";
            this.ConfigProperty_TelnetEnabled.Size = new System.Drawing.Size(59, 17);
            this.ConfigProperty_TelnetEnabled.TabIndex = 17;
            this.ConfigProperty_TelnetEnabled.Text = "Enable";
            this.toolTip.SetToolTip(this.ConfigProperty_TelnetEnabled, "Enable/Disable the telnet.");
            this.ConfigProperty_TelnetEnabled.UseVisualStyleBackColor = true;
            // 
            // telnet_port_l
            // 
            this.telnet_port_l.AutoSize = true;
            this.telnet_port_l.Location = new System.Drawing.Point(9, 72);
            this.telnet_port_l.Name = "telnet_port_l";
            this.telnet_port_l.Size = new System.Drawing.Size(29, 13);
            this.telnet_port_l.TabIndex = 16;
            this.telnet_port_l.Text = "Port:";
            // 
            // ConfigProperty_TelnetPort
            // 
            this.ConfigProperty_TelnetPort.Location = new System.Drawing.Point(96, 69);
            this.ConfigProperty_TelnetPort.Name = "ConfigProperty_TelnetPort";
            this.ConfigProperty_TelnetPort.Size = new System.Drawing.Size(49, 20);
            this.ConfigProperty_TelnetPort.TabIndex = 15;
            this.ConfigProperty_TelnetPort.Text = "8081";
            this.toolTip.SetToolTip(this.ConfigProperty_TelnetPort, "Port of the telnet server.");
            this.ConfigProperty_TelnetPort.TextChanged += new System.EventHandler(this.Telnet_port_TextChanged);
            // 
            // telnet_psw_l
            // 
            this.telnet_psw_l.AutoSize = true;
            this.telnet_psw_l.Location = new System.Drawing.Point(10, 46);
            this.telnet_psw_l.Name = "telnet_psw_l";
            this.telnet_psw_l.Size = new System.Drawing.Size(56, 13);
            this.telnet_psw_l.TabIndex = 14;
            this.telnet_psw_l.Text = "Password:";
            // 
            // ConfigProperty_TelnetPassword
            // 
            this.ConfigProperty_TelnetPassword.Location = new System.Drawing.Point(96, 43);
            this.ConfigProperty_TelnetPassword.Name = "ConfigProperty_TelnetPassword";
            this.ConfigProperty_TelnetPassword.PasswordChar = '*';
            this.ConfigProperty_TelnetPassword.Size = new System.Drawing.Size(169, 20);
            this.ConfigProperty_TelnetPassword.TabIndex = 13;
            this.toolTip.SetToolTip(this.ConfigProperty_TelnetPassword, "Password to gain entry to telnet interface.\r\n\r\nIf no password is set the server w" +
        "ill only listen on the local loopback interface.");
            this.ConfigProperty_TelnetPassword.TextChanged += new System.EventHandler(this.Telnet_psw_TextChanged);
            // 
            // port_g
            // 
            this.port_g.Controls.Add(this.ConfigProperty_ServerPort);
            this.port_g.Location = new System.Drawing.Point(8, 381);
            this.port_g.Name = "port_g";
            this.port_g.Size = new System.Drawing.Size(265, 48);
            this.port_g.TabIndex = 23;
            this.port_g.TabStop = false;
            this.port_g.Text = "Server port";
            // 
            // ConfigProperty_ServerPort
            // 
            this.ConfigProperty_ServerPort.Location = new System.Drawing.Point(6, 19);
            this.ConfigProperty_ServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.ConfigProperty_ServerPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ConfigProperty_ServerPort.Name = "ConfigProperty_ServerPort";
            this.ConfigProperty_ServerPort.Size = new System.Drawing.Size(120, 20);
            this.ConfigProperty_ServerPort.TabIndex = 1;
            this.toolTip.SetToolTip(this.ConfigProperty_ServerPort, "Port you want the server to listen on.");
            this.ConfigProperty_ServerPort.Value = new decimal(new int[] {
            26900,
            0,
            0,
            0});
            this.ConfigProperty_ServerPort.ValueChanged += new System.EventHandler(this.Port_TextChanged);
            // 
            // Admin_Control_Panel_GroupBox
            // 
            this.Admin_Control_Panel_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Admin_Control_Panel_GroupBox.Controls.Add(this.cpl_port);
            this.Admin_Control_Panel_GroupBox.Controls.Add(this.ConfigProperty_ControlPanelPort);
            this.Admin_Control_Panel_GroupBox.Controls.Add(this.cpl_pass);
            this.Admin_Control_Panel_GroupBox.Controls.Add(this.ConfigProperty_ControlPanelEnabled);
            this.Admin_Control_Panel_GroupBox.Controls.Add(this.ConfigProperty_ControlPanelPassword);
            this.Admin_Control_Panel_GroupBox.Location = new System.Drawing.Point(8, 3);
            this.Admin_Control_Panel_GroupBox.Name = "Admin_Control_Panel_GroupBox";
            this.Admin_Control_Panel_GroupBox.Size = new System.Drawing.Size(485, 98);
            this.Admin_Control_Panel_GroupBox.TabIndex = 26;
            this.Admin_Control_Panel_GroupBox.TabStop = false;
            this.Admin_Control_Panel_GroupBox.Text = "Control Panel";
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
            // ConfigProperty_ControlPanelPort
            // 
            this.ConfigProperty_ControlPanelPort.Location = new System.Drawing.Point(96, 68);
            this.ConfigProperty_ControlPanelPort.Name = "ConfigProperty_ControlPanelPort";
            this.ConfigProperty_ControlPanelPort.Size = new System.Drawing.Size(49, 20);
            this.ConfigProperty_ControlPanelPort.TabIndex = 11;
            this.ConfigProperty_ControlPanelPort.Text = "8080";
            this.toolTip.SetToolTip(this.ConfigProperty_ControlPanelPort, "Port of the control panel webpage.");
            this.ConfigProperty_ControlPanelPort.TextChanged += new System.EventHandler(this.Port_panel_TextChanged);
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
            // ConfigProperty_ControlPanelEnabled
            // 
            this.ConfigProperty_ControlPanelEnabled.AutoSize = true;
            this.ConfigProperty_ControlPanelEnabled.Location = new System.Drawing.Point(9, 19);
            this.ConfigProperty_ControlPanelEnabled.Name = "ConfigProperty_ControlPanelEnabled";
            this.ConfigProperty_ControlPanelEnabled.Size = new System.Drawing.Size(59, 17);
            this.ConfigProperty_ControlPanelEnabled.TabIndex = 9;
            this.ConfigProperty_ControlPanelEnabled.Text = "Enable";
            this.toolTip.SetToolTip(this.ConfigProperty_ControlPanelEnabled, "Enable/Disable the web control panel.");
            this.ConfigProperty_ControlPanelEnabled.UseVisualStyleBackColor = true;
            this.ConfigProperty_ControlPanelEnabled.CheckedChanged += new System.EventHandler(this.Ctrlp_CheckedChanged);
            // 
            // ConfigProperty_ControlPanelPassword
            // 
            this.ConfigProperty_ControlPanelPassword.Location = new System.Drawing.Point(96, 42);
            this.ConfigProperty_ControlPanelPassword.Name = "ConfigProperty_ControlPanelPassword";
            this.ConfigProperty_ControlPanelPassword.PasswordChar = '*';
            this.ConfigProperty_ControlPanelPassword.Size = new System.Drawing.Size(169, 20);
            this.ConfigProperty_ControlPanelPassword.TabIndex = 8;
            this.ConfigProperty_ControlPanelPassword.Text = "CHANGEME";
            this.toolTip.SetToolTip(this.ConfigProperty_ControlPanelPassword, "Password to gain entry to the control panel.");
            this.ConfigProperty_ControlPanelPassword.TextChanged += new System.EventHandler(this.Ctrlppass_TextChanged);
            // 
            // Mod_Options_TabPage
            // 
            this.Mod_Options_TabPage.Controls.Add(this.button1);
            this.Mod_Options_TabPage.Controls.Add(this.groupBox2);
            this.Mod_Options_TabPage.Controls.Add(this.groupBox1);
            this.Mod_Options_TabPage.Controls.Add(this.Retrieve_Mods_From_Nexus_Button);
            this.Mod_Options_TabPage.Controls.Add(this.Mods_List_GroupBox);
            this.Mod_Options_TabPage.ImageIndex = 6;
            this.Mod_Options_TabPage.Location = new System.Drawing.Point(4, 50);
            this.Mod_Options_TabPage.Name = "Mod_Options_TabPage";
            this.Mod_Options_TabPage.Size = new System.Drawing.Size(897, 630);
            this.Mod_Options_TabPage.TabIndex = 4;
            this.Mod_Options_TabPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "https://www.nexusmods.com/users/myaccount?tab=api";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(456, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 238);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mod Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Location = new System.Drawing.Point(7, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 238);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enable / Disable Installed Mods";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "hg",
            "das",
            "dg",
            "a",
            "da",
            "sd",
            "gas",
            "dg",
            "asd",
            "ga",
            "dfg",
            "d",
            "fgs",
            "df",
            "gsd",
            "fg",
            "sdgf",
            "kjhlkjh",
            "d",
            "fg",
            "dfg",
            "d",
            "fg",
            "ds",
            "fgs",
            "df",
            "s",
            "dh",
            "fg",
            "n",
            "x",
            "c",
            "b",
            "d",
            "fh",
            "ar",
            "h",
            "a",
            "h",
            "st"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(431, 214);
            this.checkedListBox1.TabIndex = 2;
            // 
            // Retrieve_Mods_From_Nexus_Button
            // 
            this.Retrieve_Mods_From_Nexus_Button.Location = new System.Drawing.Point(3, 4);
            this.Retrieve_Mods_From_Nexus_Button.Name = "Retrieve_Mods_From_Nexus_Button";
            this.Retrieve_Mods_From_Nexus_Button.Size = new System.Drawing.Size(291, 23);
            this.Retrieve_Mods_From_Nexus_Button.TabIndex = 1;
            this.Retrieve_Mods_From_Nexus_Button.Text = "Get Latest Mods List From Nexus (Last 30 Days)";
            this.Retrieve_Mods_From_Nexus_Button.UseVisualStyleBackColor = true;
            this.Retrieve_Mods_From_Nexus_Button.Click += new System.EventHandler(this.Retrieve_Mods_From_Nexus_Button_Click);
            // 
            // Mods_List_GroupBox
            // 
            this.Mods_List_GroupBox.Location = new System.Drawing.Point(300, 3);
            this.Mods_List_GroupBox.Name = "Mods_List_GroupBox";
            this.Mods_List_GroupBox.Size = new System.Drawing.Size(587, 297);
            this.Mods_List_GroupBox.TabIndex = 0;
            this.Mods_List_GroupBox.TabStop = false;
            this.Mods_List_GroupBox.Text = "Nexus Mods List";
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
            this.android_apk.Click += new System.EventHandler(this.Android_APK_Click);
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
            this.android_play.Click += new System.EventHandler(this.Android_Play_Click);
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
            // GitHub_Repo_Button
            // 
            this.GitHub_Repo_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GitHub_Repo_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitHub_Repo_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GitHub_Repo_Button.FlatAppearance.BorderSize = 0;
            this.GitHub_Repo_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GitHub_Repo_Button.Image = ((System.Drawing.Image)(resources.GetObject("GitHub_Repo_Button.Image")));
            this.GitHub_Repo_Button.Location = new System.Drawing.Point(737, 698);
            this.GitHub_Repo_Button.Margin = new System.Windows.Forms.Padding(0);
            this.GitHub_Repo_Button.Name = "GitHub_Repo_Button";
            this.GitHub_Repo_Button.Size = new System.Drawing.Size(43, 43);
            this.GitHub_Repo_Button.TabIndex = 35;
            this.GitHub_Repo_Button.UseVisualStyleBackColor = true;
            this.GitHub_Repo_Button.Click += new System.EventHandler(this.GitHub_Repo_Button_Click);
            // 
            // ConfigProperty_DropOnDeath
            // 
            this.ConfigProperty_DropOnDeath.FormattingEnabled = true;
            this.ConfigProperty_DropOnDeath.Items.AddRange(new object[] {
            "Nothing",
            "Everything",
            "Toolbelt Only",
            "Backpack Only",
            "Delete All"});
            this.ConfigProperty_DropOnDeath.Location = new System.Drawing.Point(9, 20);
            this.ConfigProperty_DropOnDeath.Name = "ConfigProperty_DropOnDeath";
            this.ConfigProperty_DropOnDeath.Size = new System.Drawing.Size(140, 21);
            this.ConfigProperty_DropOnDeath.TabIndex = 0;
            this.ConfigProperty_DropOnDeath.Text = "Everything";
            this.toolTip.SetToolTip(this.ConfigProperty_DropOnDeath, "What will be dropped on death.");
            // 
            // DropOnQuit_GroupBox
            // 
            this.DropOnQuit_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DropOnQuit_GroupBox.Controls.Add(this.ConfigProperty_DropOnQuit);
            this.DropOnQuit_GroupBox.Location = new System.Drawing.Point(361, 382);
            this.DropOnQuit_GroupBox.Name = "DropOnQuit_GroupBox";
            this.DropOnQuit_GroupBox.Size = new System.Drawing.Size(157, 48);
            this.DropOnQuit_GroupBox.TabIndex = 53;
            this.DropOnQuit_GroupBox.TabStop = false;
            this.DropOnQuit_GroupBox.Text = "Drop On Death";
            // 
            // ConfigProperty_DropOnQuit
            // 
            this.ConfigProperty_DropOnQuit.FormattingEnabled = true;
            this.ConfigProperty_DropOnQuit.Items.AddRange(new object[] {
            "Nothing",
            "Everything",
            "Toolbelt Only",
            "Backpack Only"});
            this.ConfigProperty_DropOnQuit.Location = new System.Drawing.Point(9, 20);
            this.ConfigProperty_DropOnQuit.Name = "ConfigProperty_DropOnQuit";
            this.ConfigProperty_DropOnQuit.Size = new System.Drawing.Size(141, 21);
            this.ConfigProperty_DropOnQuit.TabIndex = 0;
            this.ConfigProperty_DropOnQuit.Text = "Nothing";
            this.toolTip.SetToolTip(this.ConfigProperty_DropOnQuit, "What will get dropped on quit.");
            // 
            // BedrollExpiryTime_GroupBox
            // 
            this.BedrollExpiryTime_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BedrollExpiryTime_GroupBox.Controls.Add(this.ConfigProperty_BedrollExpiryTime);
            this.BedrollExpiryTime_GroupBox.Location = new System.Drawing.Point(6, 77);
            this.BedrollExpiryTime_GroupBox.Name = "BedrollExpiryTime_GroupBox";
            this.BedrollExpiryTime_GroupBox.Size = new System.Drawing.Size(496, 63);
            this.BedrollExpiryTime_GroupBox.TabIndex = 17;
            this.BedrollExpiryTime_GroupBox.TabStop = false;
            this.BedrollExpiryTime_GroupBox.Text = "Bedroll Offline Expiry ";
            // 
            // ConfigProperty_BedrollExpiryTime
            // 
            this.ConfigProperty_BedrollExpiryTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_BedrollExpiryTime.Location = new System.Drawing.Point(6, 13);
            this.ConfigProperty_BedrollExpiryTime.Maximum = 150;
            this.ConfigProperty_BedrollExpiryTime.Name = "ConfigProperty_BedrollExpiryTime";
            this.ConfigProperty_BedrollExpiryTime.Size = new System.Drawing.Size(484, 45);
            this.ConfigProperty_BedrollExpiryTime.TabIndex = 8;
            this.toolTip.SetToolTip(this.ConfigProperty_BedrollExpiryTime, "Number of days a bedroll stays active after owner was last online.");
            this.ConfigProperty_BedrollExpiryTime.Value = 15;
            // 
            // ServerMaxAllowedViewDistance_GroupBox
            // 
            this.ServerMaxAllowedViewDistance_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerMaxAllowedViewDistance_GroupBox.Controls.Add(this.ConfigProperty_ServerMaxAllowedViewDistance);
            this.ServerMaxAllowedViewDistance_GroupBox.Location = new System.Drawing.Point(524, 217);
            this.ServerMaxAllowedViewDistance_GroupBox.Name = "ServerMaxAllowedViewDistance_GroupBox";
            this.ServerMaxAllowedViewDistance_GroupBox.Size = new System.Drawing.Size(179, 65);
            this.ServerMaxAllowedViewDistance_GroupBox.TabIndex = 32;
            this.ServerMaxAllowedViewDistance_GroupBox.TabStop = false;
            this.ServerMaxAllowedViewDistance_GroupBox.Text = "Server Max Allowed View Distance";
            // 
            // ConfigProperty_ServerMaxAllowedViewDistance
            // 
            this.ConfigProperty_ServerMaxAllowedViewDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_ServerMaxAllowedViewDistance.Location = new System.Drawing.Point(6, 13);
            this.ConfigProperty_ServerMaxAllowedViewDistance.Maximum = 12;
            this.ConfigProperty_ServerMaxAllowedViewDistance.Minimum = 6;
            this.ConfigProperty_ServerMaxAllowedViewDistance.Name = "ConfigProperty_ServerMaxAllowedViewDistance";
            this.ConfigProperty_ServerMaxAllowedViewDistance.Size = new System.Drawing.Size(167, 45);
            this.ConfigProperty_ServerMaxAllowedViewDistance.TabIndex = 9;
            this.toolTip.SetToolTip(this.ConfigProperty_ServerMaxAllowedViewDistance, "Max viewdistance a client may request (6 - 12). \r\n\r\nHigh impact on memory usage a" +
        "nd performance.");
            this.ConfigProperty_ServerMaxAllowedViewDistance.Value = 12;
            // 
            // ZombieDaySpeed_GroupBox
            // 
            this.ZombieDaySpeed_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZombieDaySpeed_GroupBox.Controls.Add(this.ConfigProperty_ZombieMove);
            this.ZombieDaySpeed_GroupBox.Location = new System.Drawing.Point(708, 217);
            this.ZombieDaySpeed_GroupBox.Name = "ZombieDaySpeed_GroupBox";
            this.ZombieDaySpeed_GroupBox.Size = new System.Drawing.Size(179, 49);
            this.ZombieDaySpeed_GroupBox.TabIndex = 43;
            this.ZombieDaySpeed_GroupBox.TabStop = false;
            this.ZombieDaySpeed_GroupBox.Text = "Zombie Day Speed";
            // 
            // ConfigProperty_ZombieMove
            // 
            this.ConfigProperty_ZombieMove.FormattingEnabled = true;
            this.ConfigProperty_ZombieMove.Items.AddRange(new object[] {
            "Walk",
            "Job",
            "Run",
            "Sprint",
            "Nightmare"});
            this.ConfigProperty_ZombieMove.Location = new System.Drawing.Point(9, 20);
            this.ConfigProperty_ZombieMove.Name = "ConfigProperty_ZombieMove";
            this.ConfigProperty_ZombieMove.Size = new System.Drawing.Size(162, 21);
            this.ConfigProperty_ZombieMove.TabIndex = 0;
            this.ConfigProperty_ZombieMove.Text = "Walk";
            this.toolTip.SetToolTip(this.ConfigProperty_ZombieMove, "Speed of a regular zombie.");
            // 
            // ZombieNightSpeed_GroupBox
            // 
            this.ZombieNightSpeed_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZombieNightSpeed_GroupBox.Controls.Add(this.ConfigProperty_ZombieMoveNight);
            this.ZombieNightSpeed_GroupBox.Location = new System.Drawing.Point(708, 272);
            this.ZombieNightSpeed_GroupBox.Name = "ZombieNightSpeed_GroupBox";
            this.ZombieNightSpeed_GroupBox.Size = new System.Drawing.Size(179, 49);
            this.ZombieNightSpeed_GroupBox.TabIndex = 44;
            this.ZombieNightSpeed_GroupBox.TabStop = false;
            this.ZombieNightSpeed_GroupBox.Text = "Zombie Night Speed";
            // 
            // ConfigProperty_ZombieMoveNight
            // 
            this.ConfigProperty_ZombieMoveNight.FormattingEnabled = true;
            this.ConfigProperty_ZombieMoveNight.Items.AddRange(new object[] {
            "Walk",
            "Jog",
            "Run",
            "Sprint",
            "Nightmare"});
            this.ConfigProperty_ZombieMoveNight.Location = new System.Drawing.Point(9, 20);
            this.ConfigProperty_ZombieMoveNight.Name = "ConfigProperty_ZombieMoveNight";
            this.ConfigProperty_ZombieMoveNight.Size = new System.Drawing.Size(162, 21);
            this.ConfigProperty_ZombieMoveNight.TabIndex = 0;
            this.ConfigProperty_ZombieMoveNight.Text = "Sprint";
            this.toolTip.SetToolTip(this.ConfigProperty_ZombieMoveNight, "Speed of a regular zombie at night.");
            // 
            // ZombieBloodMoonSpeed_GroupBox
            // 
            this.ZombieBloodMoonSpeed_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZombieBloodMoonSpeed_GroupBox.Controls.Add(this.ConfigProperty_ZombieBMMove);
            this.ZombieBloodMoonSpeed_GroupBox.Location = new System.Drawing.Point(708, 381);
            this.ZombieBloodMoonSpeed_GroupBox.Name = "ZombieBloodMoonSpeed_GroupBox";
            this.ZombieBloodMoonSpeed_GroupBox.Size = new System.Drawing.Size(179, 49);
            this.ZombieBloodMoonSpeed_GroupBox.TabIndex = 46;
            this.ZombieBloodMoonSpeed_GroupBox.TabStop = false;
            this.ZombieBloodMoonSpeed_GroupBox.Text = "Zombie Blood Moon Speed";
            // 
            // ConfigProperty_ZombieBMMove
            // 
            this.ConfigProperty_ZombieBMMove.FormattingEnabled = true;
            this.ConfigProperty_ZombieBMMove.Items.AddRange(new object[] {
            "Walk",
            "Jog",
            "Run",
            "Sprint",
            "Nightmare"});
            this.ConfigProperty_ZombieBMMove.Location = new System.Drawing.Point(9, 20);
            this.ConfigProperty_ZombieBMMove.Name = "ConfigProperty_ZombieBMMove";
            this.ConfigProperty_ZombieBMMove.Size = new System.Drawing.Size(162, 21);
            this.ConfigProperty_ZombieBMMove.TabIndex = 0;
            this.ConfigProperty_ZombieBMMove.Text = "Sprint";
            this.toolTip.SetToolTip(this.ConfigProperty_ZombieBMMove, "Speed of a zombie on the blood moon.");
            // 
            // ZombieFeralSpeed_GroupBox
            // 
            this.ZombieFeralSpeed_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZombieFeralSpeed_GroupBox.Controls.Add(this.ConfigProperty_ZombieFeralMove);
            this.ZombieFeralSpeed_GroupBox.Location = new System.Drawing.Point(708, 326);
            this.ZombieFeralSpeed_GroupBox.Name = "ZombieFeralSpeed_GroupBox";
            this.ZombieFeralSpeed_GroupBox.Size = new System.Drawing.Size(179, 49);
            this.ZombieFeralSpeed_GroupBox.TabIndex = 45;
            this.ZombieFeralSpeed_GroupBox.TabStop = false;
            this.ZombieFeralSpeed_GroupBox.Text = "Zombie Feral Speed";
            // 
            // ConfigProperty_ZombieFeralMove
            // 
            this.ConfigProperty_ZombieFeralMove.FormattingEnabled = true;
            this.ConfigProperty_ZombieFeralMove.Items.AddRange(new object[] {
            "Walk",
            "Job",
            "Run",
            "Sprint",
            "Nightmare"});
            this.ConfigProperty_ZombieFeralMove.Location = new System.Drawing.Point(9, 20);
            this.ConfigProperty_ZombieFeralMove.Name = "ConfigProperty_ZombieFeralMove";
            this.ConfigProperty_ZombieFeralMove.Size = new System.Drawing.Size(162, 21);
            this.ConfigProperty_ZombieFeralMove.TabIndex = 0;
            this.ConfigProperty_ZombieFeralMove.Text = "Sprint";
            this.toolTip.SetToolTip(this.ConfigProperty_ZombieFeralMove, "Speed of a feral zombie.");
            // 
            // BloodMoon_GroupBox
            // 
            this.BloodMoon_GroupBox.Controls.Add(this.BloodMoonWarning_Label);
            this.BloodMoon_GroupBox.Controls.Add(this.ConfigProperty_BloodMoonWarning);
            this.BloodMoon_GroupBox.Controls.Add(this.ConfigProperty_BloodMoonRange);
            this.BloodMoon_GroupBox.Controls.Add(this.BloodMoonRange_Label);
            this.BloodMoon_GroupBox.Controls.Add(this.BloodMoonFrequency_Label);
            this.BloodMoon_GroupBox.Controls.Add(this.ConfigProperty_BloodMoonFrequency);
            this.BloodMoon_GroupBox.Location = new System.Drawing.Point(383, 524);
            this.BloodMoon_GroupBox.Name = "BloodMoon_GroupBox";
            this.BloodMoon_GroupBox.Size = new System.Drawing.Size(508, 98);
            this.BloodMoon_GroupBox.TabIndex = 29;
            this.BloodMoon_GroupBox.TabStop = false;
            this.BloodMoon_GroupBox.Text = "Blood Moon Settings";
            // 
            // ConfigProperty_BloodMoonFrequency
            // 
            this.ConfigProperty_BloodMoonFrequency.Location = new System.Drawing.Point(128, 19);
            this.ConfigProperty_BloodMoonFrequency.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ConfigProperty_BloodMoonFrequency.Name = "ConfigProperty_BloodMoonFrequency";
            this.ConfigProperty_BloodMoonFrequency.Size = new System.Drawing.Size(120, 20);
            this.ConfigProperty_BloodMoonFrequency.TabIndex = 11;
            this.toolTip.SetToolTip(this.ConfigProperty_BloodMoonFrequency, "What frequency (in days) should a blood moon take place. Set to \"0\" for no blood " +
        "moons.");
            // 
            // BloodMoonFrequency_Label
            // 
            this.BloodMoonFrequency_Label.AutoSize = true;
            this.BloodMoonFrequency_Label.Location = new System.Drawing.Point(7, 23);
            this.BloodMoonFrequency_Label.Name = "BloodMoonFrequency_Label";
            this.BloodMoonFrequency_Label.Size = new System.Drawing.Size(117, 13);
            this.BloodMoonFrequency_Label.TabIndex = 12;
            this.BloodMoonFrequency_Label.Text = "Blood Moon Frequency";
            // 
            // BloodMoonRange_Label
            // 
            this.BloodMoonRange_Label.AutoSize = true;
            this.BloodMoonRange_Label.Location = new System.Drawing.Point(6, 57);
            this.BloodMoonRange_Label.Name = "BloodMoonRange_Label";
            this.BloodMoonRange_Label.Size = new System.Drawing.Size(112, 13);
            this.BloodMoonRange_Label.TabIndex = 13;
            this.BloodMoonRange_Label.Text = "Blood Moon Deviation";
            // 
            // ConfigProperty_BloodMoonRange
            // 
            this.ConfigProperty_BloodMoonRange.Location = new System.Drawing.Point(122, 53);
            this.ConfigProperty_BloodMoonRange.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ConfigProperty_BloodMoonRange.Name = "ConfigProperty_BloodMoonRange";
            this.ConfigProperty_BloodMoonRange.Size = new System.Drawing.Size(120, 20);
            this.ConfigProperty_BloodMoonRange.TabIndex = 14;
            this.toolTip.SetToolTip(this.ConfigProperty_BloodMoonRange, "How many days can the actual blood moon day randomly deviate from the above setti" +
        "ng. Setting this to 0 makes blood moons happen exactly each Nth day as specified" +
        " in BloodMoonFrequency.");
            // 
            // BloodMoonWarning_Label
            // 
            this.BloodMoonWarning_Label.AutoSize = true;
            this.BloodMoonWarning_Label.Location = new System.Drawing.Point(272, 25);
            this.BloodMoonWarning_Label.Name = "BloodMoonWarning_Label";
            this.BloodMoonWarning_Label.Size = new System.Drawing.Size(107, 13);
            this.BloodMoonWarning_Label.TabIndex = 16;
            this.BloodMoonWarning_Label.Text = "Blood Moon Warning";
            // 
            // ConfigProperty_BloodMoonWarning
            // 
            this.ConfigProperty_BloodMoonWarning.Location = new System.Drawing.Point(382, 21);
            this.ConfigProperty_BloodMoonWarning.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ConfigProperty_BloodMoonWarning.Name = "ConfigProperty_BloodMoonWarning";
            this.ConfigProperty_BloodMoonWarning.Size = new System.Drawing.Size(120, 20);
            this.ConfigProperty_BloodMoonWarning.TabIndex = 15;
            this.toolTip.SetToolTip(this.ConfigProperty_BloodMoonWarning, "The Hour number that the red day number begins on a blood moon day. Setting this " +
        "to -1 makes the red never show.");
            // 
            // ConfigProperty_AirDropMarker
            // 
            this.ConfigProperty_AirDropMarker.AutoSize = true;
            this.ConfigProperty_AirDropMarker.Location = new System.Drawing.Point(6, 86);
            this.ConfigProperty_AirDropMarker.Name = "ConfigProperty_AirDropMarker";
            this.ConfigProperty_AirDropMarker.Size = new System.Drawing.Size(135, 17);
            this.ConfigProperty_AirDropMarker.TabIndex = 20;
            this.ConfigProperty_AirDropMarker.Text = "Show Air Drop On Map";
            this.toolTip.SetToolTip(this.ConfigProperty_AirDropMarker, "Sets if a marker is added to map/compass for air drops.");
            this.ConfigProperty_AirDropMarker.UseVisualStyleBackColor = true;
            // 
            // ConfigProperty_PlayerKillingMode
            // 
            this.ConfigProperty_PlayerKillingMode.FormattingEnabled = true;
            this.ConfigProperty_PlayerKillingMode.Items.AddRange(new object[] {
            "No Killing",
            "Kill Allies Only",
            "Kill Strangers Only",
            "Kill Everyone"});
            this.ConfigProperty_PlayerKillingMode.Location = new System.Drawing.Point(9, 19);
            this.ConfigProperty_PlayerKillingMode.Name = "ConfigProperty_PlayerKillingMode";
            this.ConfigProperty_PlayerKillingMode.Size = new System.Drawing.Size(162, 21);
            this.ConfigProperty_PlayerKillingMode.TabIndex = 0;
            this.ConfigProperty_PlayerKillingMode.Text = "Kill Everyone";
            this.toolTip.SetToolTip(this.ConfigProperty_PlayerKillingMode, "Player Killing Settings");
            // 
            // PartySharedKillRange_GroupBox
            // 
            this.PartySharedKillRange_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PartySharedKillRange_GroupBox.Controls.Add(this.ConfigProperty_PartySharedKillRange);
            this.PartySharedKillRange_GroupBox.Location = new System.Drawing.Point(708, 487);
            this.PartySharedKillRange_GroupBox.Name = "PartySharedKillRange_GroupBox";
            this.PartySharedKillRange_GroupBox.Size = new System.Drawing.Size(179, 68);
            this.PartySharedKillRange_GroupBox.TabIndex = 51;
            this.PartySharedKillRange_GroupBox.TabStop = false;
            this.PartySharedKillRange_GroupBox.Text = "Party Shared XP Distance";
            // 
            // ConfigProperty_PartySharedKillRange
            // 
            this.ConfigProperty_PartySharedKillRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_PartySharedKillRange.Location = new System.Drawing.Point(6, 19);
            this.ConfigProperty_PartySharedKillRange.Maximum = 1000;
            this.ConfigProperty_PartySharedKillRange.Minimum = 1;
            this.ConfigProperty_PartySharedKillRange.Name = "ConfigProperty_PartySharedKillRange";
            this.ConfigProperty_PartySharedKillRange.Size = new System.Drawing.Size(167, 45);
            this.ConfigProperty_PartySharedKillRange.SmallChange = 10;
            this.ConfigProperty_PartySharedKillRange.TabIndex = 10;
            this.ConfigProperty_PartySharedKillRange.TickFrequency = 10;
            this.toolTip.SetToolTip(this.ConfigProperty_PartySharedKillRange, "The distance you must be within to receive party shared kill xp and quest party k" +
        "ill objective credit.");
            this.ConfigProperty_PartySharedKillRange.Value = 100;
            // 
            // ConfigProperty_LandClaimDecayMode
            // 
            this.ConfigProperty_LandClaimDecayMode.FormattingEnabled = true;
            this.ConfigProperty_LandClaimDecayMode.Items.AddRange(new object[] {
            "Linear",
            "Exponential",
            "Full Protection"});
            this.ConfigProperty_LandClaimDecayMode.Location = new System.Drawing.Point(7, 19);
            this.ConfigProperty_LandClaimDecayMode.Name = "ConfigProperty_LandClaimDecayMode";
            this.ConfigProperty_LandClaimDecayMode.Size = new System.Drawing.Size(121, 21);
            this.ConfigProperty_LandClaimDecayMode.TabIndex = 0;
            this.ConfigProperty_LandClaimDecayMode.Text = "Linear";
            this.toolTip.SetToolTip(this.ConfigProperty_LandClaimDecayMode, "Controls how offline players land claims decay. \r\n\r\nAll claims have full protecti" +
        "on for the first 24hrs.");
            // 
            // LandClaimCount_GroupBox
            // 
            this.LandClaimCount_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LandClaimCount_GroupBox.Controls.Add(this.ConfigProperty_LandClaimCount);
            this.LandClaimCount_GroupBox.Location = new System.Drawing.Point(9, 72);
            this.LandClaimCount_GroupBox.Name = "LandClaimCount_GroupBox";
            this.LandClaimCount_GroupBox.Size = new System.Drawing.Size(176, 51);
            this.LandClaimCount_GroupBox.TabIndex = 4;
            this.LandClaimCount_GroupBox.TabStop = false;
            this.LandClaimCount_GroupBox.Text = "Land Claim Count";
            // 
            // ConfigProperty_LandClaimCount
            // 
            this.ConfigProperty_LandClaimCount.Location = new System.Drawing.Point(10, 20);
            this.ConfigProperty_LandClaimCount.Name = "ConfigProperty_LandClaimCount";
            this.ConfigProperty_LandClaimCount.Size = new System.Drawing.Size(120, 20);
            this.ConfigProperty_LandClaimCount.TabIndex = 0;
            this.toolTip.SetToolTip(this.ConfigProperty_LandClaimCount, "Maximum allowed land claims per player.");
            this.ConfigProperty_LandClaimCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Player_Safe_Zone_Hours_Label
            // 
            this.Player_Safe_Zone_Hours_Label.AutoSize = true;
            this.Player_Safe_Zone_Hours_Label.Location = new System.Drawing.Point(296, 49);
            this.Player_Safe_Zone_Hours_Label.Name = "Player_Safe_Zone_Hours_Label";
            this.Player_Safe_Zone_Hours_Label.Size = new System.Drawing.Size(120, 13);
            this.Player_Safe_Zone_Hours_Label.TabIndex = 21;
            this.Player_Safe_Zone_Hours_Label.Text = "Player Safe Zone Hours";
            // 
            // Player_Safe_Zone_Level_Label
            // 
            this.Player_Safe_Zone_Level_Label.AutoSize = true;
            this.Player_Safe_Zone_Level_Label.Location = new System.Drawing.Point(296, 23);
            this.Player_Safe_Zone_Level_Label.Name = "Player_Safe_Zone_Level_Label";
            this.Player_Safe_Zone_Level_Label.Size = new System.Drawing.Size(118, 13);
            this.Player_Safe_Zone_Level_Label.TabIndex = 20;
            this.Player_Safe_Zone_Level_Label.Text = "Player Safe Zone Level";
            // 
            // ConfigProperty_PlayerSafeZoneHours
            // 
            this.ConfigProperty_PlayerSafeZoneHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_PlayerSafeZoneHours.Location = new System.Drawing.Point(423, 46);
            this.ConfigProperty_PlayerSafeZoneHours.Name = "ConfigProperty_PlayerSafeZoneHours";
            this.ConfigProperty_PlayerSafeZoneHours.Size = new System.Drawing.Size(54, 20);
            this.ConfigProperty_PlayerSafeZoneHours.TabIndex = 19;
            this.ConfigProperty_PlayerSafeZoneHours.Text = "5";
            this.toolTip.SetToolTip(this.ConfigProperty_PlayerSafeZoneHours, "Hours in world time this safe zone exists.");
            // 
            // ConfigProperty_PlayerSafeZoneLevel
            // 
            this.ConfigProperty_PlayerSafeZoneLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigProperty_PlayerSafeZoneLevel.Location = new System.Drawing.Point(423, 20);
            this.ConfigProperty_PlayerSafeZoneLevel.Name = "ConfigProperty_PlayerSafeZoneLevel";
            this.ConfigProperty_PlayerSafeZoneLevel.Size = new System.Drawing.Size(54, 20);
            this.ConfigProperty_PlayerSafeZoneLevel.TabIndex = 18;
            this.ConfigProperty_PlayerSafeZoneLevel.Text = "5";
            this.toolTip.SetToolTip(this.ConfigProperty_PlayerSafeZoneLevel, "If a player is less or equal this level he will create a safe zone (no enemies) w" +
        "hen spawned.");
            // 
            // Server_Panel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(961, 747);
            this.Controls.Add(this.GitHub_Repo_Button);
            this.Controls.Add(this.discord_b);
            this.Controls.Add(this.dbg_btn_2);
            this.Controls.Add(this.help_b);
            this.Controls.Add(this.contact_b);
            this.Controls.Add(this.dbg_btn);
            this.Controls.Add(this.forumklik);
            this.Controls.Add(this.don_l);
            this.Controls.Add(this.www7dsm);
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
            this.ManagePlayers_TabPage.ResumeLayout(false);
            this.ManagePlayers_TabPage.PerformLayout();
            this.Chat_GroupBox.ResumeLayout(false);
            this.Chat_GroupBox.PerformLayout();
            this.Player_GroupBox.ResumeLayout(false);
            this.Kick_GroupBox.ResumeLayout(false);
            this.Ban_GroupBox.ResumeLayout(false);
            this.Ban_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ban_Slider_TrackBar)).EndInit();
            this.GameSettings_TabPage.ResumeLayout(false);
            this.main_page_opts.ResumeLayout(false);
            this.Game_Options_TabPage.ResumeLayout(false);
            this.XPMultiplier_GroupBox.ResumeLayout(false);
            this.XPMultiplier_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_XPMultiplier)).EndInit();
            this.BlockDamageAI_GroupBox.ResumeLayout(false);
            this.BlockDamageAI_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BlockDamageAI)).EndInit();
            this.Server_Reserved_Slots_GroupBox.ResumeLayout(false);
            this.Server_Reserved_Slots_GroupBox.PerformLayout();
            this.Player_Killing_Mode_GroupBox.ResumeLayout(false);
            this.AirDropFrequency_GroupBox.ResumeLayout(false);
            this.AirDropFrequency_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_AirDropFrequency)).EndInit();
            this.Land_Claim_GroupBox.ResumeLayout(false);
            this.BlockDamageAIBM_GroupBox.ResumeLayout(false);
            this.BlockDamageAIBM_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BlockDamageAIBM)).EndInit();
            this.LandClaimDecayMode_GroupBox.ResumeLayout(false);
            this.LandClaimDurabilityModifier_GroupBox.ResumeLayout(false);
            this.LandClaimDurabilityModifier_GroupBox.PerformLayout();
            this.LandClaimSize_GroupBox.ResumeLayout(false);
            this.LandClaimSize_GroupBox.PerformLayout();
            this.LandClaimDeadZone_GroupBox.ResumeLayout(false);
            this.LandClaimDeadZone_GroupBox.PerformLayout();
            this.LandClaimExpiryTime_GroupBox.ResumeLayout(false);
            this.LandClaimExpiryTime_GroupBox.PerformLayout();
            this.LootRespawnDays_GroupBox.ResumeLayout(false);
            this.LootRespawnDays_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_LootRespawnDays)).EndInit();
            this.LootAbundance_GroupBox.ResumeLayout(false);
            this.LootAbundance_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_LootAbundance)).EndInit();
            this.Max_Players_GroupBox.ResumeLayout(false);
            this.Max_Players_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_ServerMaxPlayerCount)).EndInit();
            this.Game_Mode_Settings_GroupBox.ResumeLayout(false);
            this.Game_Mode_Settings_GroupBox.PerformLayout();
            this.DayLightLength_GroupBox.ResumeLayout(false);
            this.DayLightLength_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_DayLightLength)).EndInit();
            this.DayNightLength_GroupBox.ResumeLayout(false);
            this.DayNightLength_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_DayNightLength)).EndInit();
            this.BlockDamagePlayer_GroupBox.ResumeLayout(false);
            this.BlockDamagePlayer_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BlockDamagePlayer)).EndInit();
            this.DropOnDeath_GroupBox.ResumeLayout(false);
            this.GameDifficulty_GroupBox.ResumeLayout(false);
            this.GameDifficulty_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_GameDifficulty)).EndInit();
            this.Server_Options_TabPage.ResumeLayout(false);
            this.Server_Login_Confirmation_Text_GroupBox.ResumeLayout(false);
            this.Server_Password_GroupBox.ResumeLayout(false);
            this.Server_Password_GroupBox.PerformLayout();
            this.Server_Name_GroupBox.ResumeLayout(false);
            this.Server_Name_GroupBox.PerformLayout();
            this.ServerWebsiteURL_GroupBox.ResumeLayout(false);
            this.ServerWebsiteURL_GroupBox.PerformLayout();
            this.ServerDescription_GroupBox.ResumeLayout(false);
            this.ServerDescription_GroupBox.PerformLayout();
            this.User_Data_Folder_GroupBox.ResumeLayout(false);
            this.User_Data_Folder_GroupBox.PerformLayout();
            this.Save_Game_Folder_GroupBox.ResumeLayout(false);
            this.Save_Game_Folder_GroupBox.PerformLayout();
            this.Server_Admin_Config_File_GroupBox.ResumeLayout(false);
            this.Server_Admin_Config_File_GroupBox.PerformLayout();
            this.Game_World_Settings_GroupBox.ResumeLayout(false);
            this.Game_World_Settings_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_WorldGenSize)).EndInit();
            this.ServerListAndPassword_GroupBox.ResumeLayout(false);
            this.ServerListAndPassword_GroupBox.PerformLayout();
            this.Other_Game_Settings_GroupBox.ResumeLayout(false);
            this.Other_Game_Settings_GroupBox.PerformLayout();
            this.autobots.ResumeLayout(false);
            this.autobots.PerformLayout();
            this.BedrollDeadZoneSize_GroupBox.ResumeLayout(false);
            this.BedrollDeadZoneSize_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BedrollDeadZoneSize)).EndInit();
            this.BloodMoonEnemyCount_GroupBox.ResumeLayout(false);
            this.BloodMoonEnemyCount_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BloodMoonEnemyCount)).EndInit();
            this.MaxSpawnedAnimals_GroupBox.ResumeLayout(false);
            this.MaxSpawnedAnimals_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_MaxSpawnedAnimals)).EndInit();
            this.MaxSpawnedZombies_GroupBox.ResumeLayout(false);
            this.MaxSpawnedZombies_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_MaxSpawnedZombies)).EndInit();
            this.Web_Options_TabPage.ResumeLayout(false);
            this.Terminal_Window_Group_Box.ResumeLayout(false);
            this.Terminal_Window_Group_Box.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_ServerMaxWorldTransferSpeedKiBs)).EndInit();
            this.Server_Visibility_GroupBox.ResumeLayout(false);
            this.MaxUncoveredMapChunksPerPlayer_g.ResumeLayout(false);
            this.MaxUncoveredMapChunksPerPlayer_g.PerformLayout();
            this.HideCommandExecutionLog_GroupBox.ResumeLayout(false);
            this.ServerDisabledNetworkProtocols_g.ResumeLayout(false);
            this.ServerDisabledNetworkProtocols_g.PerformLayout();
            this.Telnet_Settings_GroupBox.ResumeLayout(false);
            this.Telnet_Settings_GroupBox.PerformLayout();
            this.port_g.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_ServerPort)).EndInit();
            this.Admin_Control_Panel_GroupBox.ResumeLayout(false);
            this.Admin_Control_Panel_GroupBox.PerformLayout();
            this.Mod_Options_TabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
            this.DropOnQuit_GroupBox.ResumeLayout(false);
            this.BedrollExpiryTime_GroupBox.ResumeLayout(false);
            this.BedrollExpiryTime_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BedrollExpiryTime)).EndInit();
            this.ServerMaxAllowedViewDistance_GroupBox.ResumeLayout(false);
            this.ServerMaxAllowedViewDistance_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_ServerMaxAllowedViewDistance)).EndInit();
            this.ZombieDaySpeed_GroupBox.ResumeLayout(false);
            this.ZombieNightSpeed_GroupBox.ResumeLayout(false);
            this.ZombieBloodMoonSpeed_GroupBox.ResumeLayout(false);
            this.ZombieFeralSpeed_GroupBox.ResumeLayout(false);
            this.BloodMoon_GroupBox.ResumeLayout(false);
            this.BloodMoon_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BloodMoonFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BloodMoonRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_BloodMoonWarning)).EndInit();
            this.PartySharedKillRange_GroupBox.ResumeLayout(false);
            this.PartySharedKillRange_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_PartySharedKillRange)).EndInit();
            this.LandClaimCount_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConfigProperty_LandClaimCount)).EndInit();
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
        private System.Windows.Forms.TabPage ManagePlayers_TabPage;
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
        private System.Windows.Forms.TabPage Server_Options_TabPage;
        private System.Windows.Forms.TabPage Game_Options_TabPage;
        private System.Windows.Forms.GroupBox DropOnDeath_GroupBox;
        private System.Windows.Forms.GroupBox GameDifficulty_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_GameDifficulty;
        private System.Windows.Forms.GroupBox Game_World_Settings_GroupBox;
        private System.Windows.Forms.ComboBox ConfigProperty_GameName;
        private System.Windows.Forms.TextBox ConfigProperty_ServerName;
        private System.Windows.Forms.ComboBox ConfigProperty_GameWorld;
        private System.Windows.Forms.GroupBox Admin_Control_Panel_GroupBox;
        private System.Windows.Forms.Label cpl_port;
        private System.Windows.Forms.TextBox ConfigProperty_ControlPanelPort;
        private System.Windows.Forms.Label cpl_pass;
        private System.Windows.Forms.CheckBox ConfigProperty_ControlPanelEnabled;
        private System.Windows.Forms.TextBox ConfigProperty_ControlPanelPassword;
        private System.Windows.Forms.GroupBox port_g;
        private System.Windows.Forms.GroupBox ServerListAndPassword_GroupBox;
        private System.Windows.Forms.TextBox ServerPassword;
        private System.Windows.Forms.CheckBox ServerIsPublic;
        private System.Windows.Forms.GroupBox Other_Game_Settings_GroupBox;
        private System.Windows.Forms.CheckBox Save_Logs_To_Files_CheckBox;
        private System.Windows.Forms.GroupBox DayLightLength_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_DayLightLength;
        private System.Windows.Forms.GroupBox DayNightLength_GroupBox;
        private System.Windows.Forms.CheckBox DayNightLength_Realtime_Mode;
        private System.Windows.Forms.TrackBar ConfigProperty_DayNightLength;
        private System.Windows.Forms.GroupBox autobots;
        private System.Windows.Forms.GroupBox Game_Mode_Settings_GroupBox;
        private System.Windows.Forms.CheckBox ConfigProperty_BuildCreate;
        private System.Windows.Forms.GroupBox Max_Players_GroupBox;
        private System.Windows.Forms.GroupBox Telnet_Settings_GroupBox;
        private System.Windows.Forms.Label telnet_port_l;
        private System.Windows.Forms.TextBox ConfigProperty_TelnetPort;
        private System.Windows.Forms.Label telnet_psw_l;
        private System.Windows.Forms.TextBox ConfigProperty_TelnetPassword;
        private System.Windows.Forms.TextBox ConfigProperty_AdminFileName;
        private System.Windows.Forms.GroupBox Server_Admin_Config_File_GroupBox;
        private System.Windows.Forms.GroupBox LootAbundance_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_LootAbundance;
        private System.Windows.Forms.GroupBox LootRespawnDays_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_LootRespawnDays;
        private System.Windows.Forms.Button Server_Admin_Path_Selector_Button;
        private System.Windows.Forms.Button Browse_Game_File_Path_Button;
        private System.Windows.Forms.GroupBox LandClaimDeadZone_GroupBox;
        private System.Windows.Forms.TextBox ConfigProperty_LandClaimDeadZone;
        private System.Windows.Forms.GroupBox LandClaimSize_GroupBox;
        private System.Windows.Forms.TextBox ConfigProperty_LandClaimSize;
        private System.Windows.Forms.GroupBox LandClaimDurabilityModifier_GroupBox;
        private System.Windows.Forms.Label Land_Claim_Durability_Offline_Label;
        private System.Windows.Forms.Label Land_Claim_Durability_Online_Label;
        private System.Windows.Forms.TextBox ConfigProperty_LandClaimOfflineDurabilityModifier;
        private System.Windows.Forms.TextBox ConfigProperty_LandClaimOnlineDurabilityModifier;
        private System.Windows.Forms.GroupBox LandClaimDecayMode_GroupBox;
        private System.Windows.Forms.GroupBox LandClaimExpiryTime_GroupBox;
        private System.Windows.Forms.TextBox ConfigProperty_LandClaimExpiryTime;
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
        private System.Windows.Forms.GroupBox Save_Game_Folder_GroupBox;
        private System.Windows.Forms.TextBox ConfigProperty_SaveGameFolder;
        private System.Windows.Forms.CheckBox Server_Commands_Say_Switch_CheckBox;
        private System.ComponentModel.BackgroundWorker stats;
        private System.Windows.Forms.GroupBox AirDropFrequency_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_AirDropFrequency;
        private System.Windows.Forms.CheckBox ConfigProperty_EnemyDifficulty;
        private System.Windows.Forms.Button Connect_Running_Server_Button;
        private System.ComponentModel.BackgroundWorker reboot_telnet;
        private System.Windows.Forms.CheckBox ConfigProperty_EACEnabled;
        private System.Windows.Forms.GroupBox MaxSpawnedZombies_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_MaxSpawnedZombies;
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
        private System.Windows.Forms.GroupBox User_Data_Folder_GroupBox;
        private System.Windows.Forms.Button configfile_e;
        private System.Windows.Forms.TextBox ConfigProperty_UserDataFolder;
        private System.Windows.Forms.GroupBox ServerWebsiteURL_GroupBox;
        private System.Windows.Forms.TextBox ConfigProperty_ServerWebsiteURL;
        private System.Windows.Forms.GroupBox ServerDescription_GroupBox;
        private System.Windows.Forms.TextBox ConfigProperty_ServerDescription;
        private System.Windows.Forms.CheckBox ConfigProperty_PersistentPlayerProfiles;
        private System.Windows.Forms.CheckBox Settings_Skip_Profiles_CheckBox;
        private System.ComponentModel.BackgroundWorker server_stop_tasks;
        private System.Windows.Forms.GroupBox MaxSpawnedAnimals_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_MaxSpawnedAnimals;
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
        public System.Windows.Forms.TrackBar ConfigProperty_ServerMaxPlayerCount;
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
        private System.Windows.Forms.TabPage Web_Options_TabPage;
        private System.Windows.Forms.GroupBox Server_Reserved_Slots_GroupBox;
        private System.Windows.Forms.TextBox ConfigProperty_ServerAdminSlotsPermission;
        private System.Windows.Forms.Label Admin_Slot_Text_Label;
        private System.Windows.Forms.Label Admin_Reserve_Text_Label;
        private System.Windows.Forms.TextBox ConfigProperty_ServerAdminSlots;
        private System.Windows.Forms.TextBox ConfigProperty_ServerReservedSlotsPermission;
        private System.Windows.Forms.Label Player_Slot_Text_Label;
        private System.Windows.Forms.Label Player_Reserve_Text_Label;
        private System.Windows.Forms.TextBox ConfigProperty_ServerReservedSlots;
        private System.Windows.Forms.GroupBox ServerDisabledNetworkProtocols_g;
        private System.Windows.Forms.CheckBox UNET;
        private System.Windows.Forms.CheckBox RakNet;
        private System.Windows.Forms.CheckBox SteamNetworking;
        private System.Windows.Forms.GroupBox BloodMoonEnemyCount_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_BloodMoonEnemyCount;
        private System.Windows.Forms.GroupBox HideCommandExecutionLog_GroupBox;
        private System.Windows.Forms.GroupBox BedrollDeadZoneSize_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_BedrollDeadZoneSize;
        private System.Windows.Forms.GroupBox MaxUncoveredMapChunksPerPlayer_g;
        private System.Windows.Forms.TextBox ConfigProperty_MaxUncoveredMapChunksPerPlayer;
        private System.Windows.Forms.CheckBox ConfigProperty_EnemySpawnMode;
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
        private System.Windows.Forms.PictureBox SQL_Update_Time_Info_PictureBox;
        private System.Windows.Forms.PictureBox SQL_Host_Info_PictureBox;
        private System.Windows.Forms.PictureBox SQL_Username_Info_PictureBox;
        private System.Windows.Forms.PictureBox SQL_Database_Name_Info_PictureBox;
        private System.Windows.Forms.PictureBox SQL_Password_Info_PictureBox;
        private System.Windows.Forms.Label Private_IP_Address_Label;
        private System.Windows.Forms.Button GitHub_Repo_Button;
        private System.Windows.Forms.TabPage Mod_Options_TabPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Retrieve_Mods_From_Nexus_Button;
        private System.Windows.Forms.GroupBox Mods_List_GroupBox;
        private System.Windows.Forms.GroupBox Server_Name_GroupBox;
        private System.Windows.Forms.GroupBox Server_Login_Confirmation_Text_GroupBox;
        private System.Windows.Forms.RichTextBox ConfigProperty_ServerLoginConfirmationText;
        private System.Windows.Forms.GroupBox Server_Password_GroupBox;
        private System.Windows.Forms.TextBox ConfigProperty_ServerPassword;
        private System.Windows.Forms.GroupBox Server_Visibility_GroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar ConfigProperty_ServerMaxWorldTransferSpeedKiBs;
        private System.Windows.Forms.ComboBox ConfigProperty_ServerVisibility;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ConfigProperty_TelnetFailedLoginsBlocktime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ConfigProperty_TelnetFailedLoginLimit;
        private System.Windows.Forms.CheckBox ConfigProperty_TelnetEnabled;
        private System.Windows.Forms.GroupBox Terminal_Window_Group_Box;
        private System.Windows.Forms.CheckBox ConfigProperty_TerminalWindowEnabled;
        private System.Windows.Forms.TrackBar ConfigProperty_WorldGenSize;
        private System.Windows.Forms.TextBox ConfigProperty_WorldGenSeed;
        private System.Windows.Forms.ComboBox ConfigProperty_GameMode;
        private System.Windows.Forms.CheckedListBox ConfigProperty_ServerDisabledNetworkProtocols;
        private System.Windows.Forms.NumericUpDown ConfigProperty_ServerPort;
        private System.Windows.Forms.ComboBox ConfigProperty_HideCommandExecutionLog;
        private System.Windows.Forms.GroupBox XPMultiplier_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_XPMultiplier;
        private System.Windows.Forms.GroupBox BlockDamageAI_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_BlockDamageAI;
        private System.Windows.Forms.GroupBox BlockDamageAIBM_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_BlockDamageAIBM;
        private System.Windows.Forms.GroupBox BlockDamagePlayer_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_BlockDamagePlayer;
        private System.Windows.Forms.ComboBox ConfigProperty_DropOnDeath;
        private System.Windows.Forms.GroupBox DropOnQuit_GroupBox;
        private System.Windows.Forms.ComboBox ConfigProperty_DropOnQuit;
        private System.Windows.Forms.GroupBox BedrollExpiryTime_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_BedrollExpiryTime;
        private System.Windows.Forms.GroupBox ServerMaxAllowedViewDistance_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_ServerMaxAllowedViewDistance;
        private System.Windows.Forms.GroupBox ZombieBloodMoonSpeed_GroupBox;
        private System.Windows.Forms.ComboBox ConfigProperty_ZombieBMMove;
        private System.Windows.Forms.GroupBox ZombieNightSpeed_GroupBox;
        private System.Windows.Forms.ComboBox ConfigProperty_ZombieMoveNight;
        private System.Windows.Forms.GroupBox ZombieFeralSpeed_GroupBox;
        private System.Windows.Forms.ComboBox ConfigProperty_ZombieFeralMove;
        private System.Windows.Forms.GroupBox ZombieDaySpeed_GroupBox;
        private System.Windows.Forms.ComboBox ConfigProperty_ZombieMove;
        private System.Windows.Forms.GroupBox BloodMoon_GroupBox;
        private System.Windows.Forms.Label BloodMoonWarning_Label;
        private System.Windows.Forms.NumericUpDown ConfigProperty_BloodMoonWarning;
        private System.Windows.Forms.NumericUpDown ConfigProperty_BloodMoonRange;
        private System.Windows.Forms.Label BloodMoonRange_Label;
        private System.Windows.Forms.Label BloodMoonFrequency_Label;
        private System.Windows.Forms.NumericUpDown ConfigProperty_BloodMoonFrequency;
        private System.Windows.Forms.CheckBox ConfigProperty_AirDropMarker;
        private System.Windows.Forms.GroupBox PartySharedKillRange_GroupBox;
        private System.Windows.Forms.TrackBar ConfigProperty_PartySharedKillRange;
        private System.Windows.Forms.ComboBox ConfigProperty_PlayerKillingMode;
        private System.Windows.Forms.ComboBox ConfigProperty_LandClaimDecayMode;
        private System.Windows.Forms.GroupBox LandClaimCount_GroupBox;
        private System.Windows.Forms.NumericUpDown ConfigProperty_LandClaimCount;
        private System.Windows.Forms.Label Player_Safe_Zone_Hours_Label;
        private System.Windows.Forms.Label Player_Safe_Zone_Level_Label;
        private System.Windows.Forms.TextBox ConfigProperty_PlayerSafeZoneHours;
        private System.Windows.Forms.TextBox ConfigProperty_PlayerSafeZoneLevel;
    }
}