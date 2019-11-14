using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;



namespace _7DaysServerManager
{
    public partial class contact : Form
    {
        public contact()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (from_t.Text == "" || from_t.Text == "(if you want to receive response, enter your email here)" || topic_t.Text == "" || tresc.Text == "")
            {
                MessageBox.Show("Please fill all fields.","You forgot something.");
            }else{
                var fromAddress = new MailAddress("7DSM_publicly_available_account@smartmoose.org", from_t.Text);
                var toAddress = new MailAddress("pionner@smartmoose.org", "pionner");
                var fromPassword = "i_knew_you_would_decompile_it";



                var smtp = new SmtpClient
                {
                    Host = "ssl0.ovh.net",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = topic_t.Text,
                    Body = tresc.Text
                })
                {
                    smtp.Send(message);
                }

                MessageBox.Show("Message sent", "We did it!");
                this.Close();
            }
        }

        private void from_t_Enter(object sender, EventArgs e)
        {
            if(from_t.Text == "(if you want to receive response, enter your email here)")
                from_t.Text = "";
        }

        private void from_t_Leave(object sender, EventArgs e)
        {
            if (from_t.Text == "")
                from_t.Text = "(if you want to receive response, enter your email here)";
        }
    }
}
