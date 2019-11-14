using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace _7DaysServerManager
{
    public partial class error_reporter : Form
    {

        public error_reporter()
        {
            InitializeComponent();
        }



        public error_reporter(string err)
        {
            InitializeComponent();
            
            rep.Text = "7DSM version: " + server_panel.ver + "\n\nException: " + err;

            if (err.Contains("Report by user"))
            {
                er_l1.Text = "\n\nAutomatically collected informations:";
                halp_l.Text = "Please describe the problem";
            }


            

        }

        private void send_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                System.Collections.Specialized.NameValueCollection reqparm = new System.Collections.Specialized.NameValueCollection();
                reqparm.Add("ver", server_panel.ver);
                reqparm.Add("exc", rep.Text);
                reqparm.Add("opt", opt.Text);
                byte[] responsebytes = client.UploadValues("https://7dsm.smartmoose.org/system/error.php", "POST", reqparm);
                string responsebody = Encoding.UTF8.GetString(responsebytes);
                if(responsebody=="0")
                    MessageBox.Show("Report sent, thank you.", "Report sent");
                else
                    MessageBox.Show("Error while sending error report... I feel almost like in Microsoft right now.", "Error");
            }

            
            this.Close();
        }

        private void error_reporter_Load(object sender, EventArgs e)
        {
            
        }


    }
}
