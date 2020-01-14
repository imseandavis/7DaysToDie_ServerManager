using System;
using System.Windows.Forms;
using Syncfusion.Licensing;

namespace _7DaysServerManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 7 Days To Die Project License for Sync Fusion
            SyncfusionLicenseProvider.RegisterLicense("MTgzMTE3QDMxMzcyZTM0MmUzMGVGZVJaamNGcTJRU084dFVNY1ZMdHNFZldyKzNXQ1hHK2NmMWo4RkdlT0k9");

            // Enable WinForm Visual Styles
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Init And Display The Profile Selector Screen
            Profile_selector ProfileSelector = new Profile_selector();
            ProfileSelector.ShowDialog();
            
            //Once The Profile Selection Has Completed, Startup the Server Manager
            Application.Run(new Server_Panel_Form());
        }
    }
}
