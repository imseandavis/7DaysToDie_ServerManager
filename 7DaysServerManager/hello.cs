﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace _7DaysServerManager
{
    public partial class hello : Form
    {
        public hello()
        {
            InitializeComponent();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
            
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void diablestart_CheckedChanged(object sender, EventArgs e)
        {

            if (diablestart.Checked)
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "show_hello_msg", "0");
            }
            else
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "show_hello_msg", "1");
            }
        }

        private void hello_Load(object sender, EventArgs e)
        {

        }

        private void showme_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=S26A3894C2JGA");
            this.Close();
        }
    }
}
