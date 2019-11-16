using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Application.Run(new profile_selector());*/

            profile_selector ps = new profile_selector();
            ps.ShowDialog();
            Application.Run(new Server_Panel_Form());


        }
    }
}
