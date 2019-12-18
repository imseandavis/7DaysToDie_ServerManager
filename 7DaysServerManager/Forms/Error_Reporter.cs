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
    public partial class Error_Reporter : Form
    {

        public Error_Reporter()
        {
            InitializeComponent();
        }

        public Error_Reporter(string err)
        {
            InitializeComponent();
            
            rep.Text = "7DSM version: " + Server_Panel_Form.ver + "\n\nException: " + err;

            if (err.Contains("Report by user"))
            {
                er_l1.Text = "\n\nAutomatically collected informations:";
                halp_l.Text = "Please describe the problem";
            }

        }

        private void Send_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                System.Collections.Specialized.NameValueCollection reqparm = new System.Collections.Specialized.NameValueCollection
                {
                    { "ver", Server_Panel_Form.ver },
                    { "exc", rep.Text },
                    { "opt", opt.Text }
                };
                byte[] responsebytes = client.UploadValues("https://7dsm.smartmoose.org/system/error.php", "POST", reqparm);
                string responsebody = Encoding.UTF8.GetString(responsebytes);
                if(responsebody=="0")
                    MessageBox.Show("Report sent, thank you.", "Report sent");
                else
                    MessageBox.Show("Error while sending error report... I feel almost like in Microsoft right now.", "Error");
            }

            this.Close();
        }

        private void Error_reporter_Load(object sender, EventArgs e)
        {
            
        }

    }
}
