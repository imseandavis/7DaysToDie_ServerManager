using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace _7DaysServerManager
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {

            bool dl_dev = false;

            if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "dev", null) == "1")
                dl_dev = true;


            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

            if(dl_dev)
                webClient.DownloadFileAsync(new Uri("https://7dsm.smartmoose.org/system/server_updater_dev.exe"), "server_updater.exe");
            else
                webClient.DownloadFileAsync(new Uri("https://7dsm.smartmoose.org/system/server_updater.exe"), "server_updater.exe");
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            //MessageBox.Show("Download completed!");
            System.Diagnostics.Process.Start("server_updater.exe");
            Application.Exit();
        }
    }
}
