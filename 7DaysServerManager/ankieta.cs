using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using System.Xml;
using System.Resources;

namespace _7DaysServerManager
{
    public partial class ankieta : Form
    {
        public ankieta()
        {
            InitializeComponent();
            this.Text = lang("ankieta");
            tak.Text = lang("ankieta_tak");
            potem.Text = lang("ankieta_potem");
            nigdy.Text = lang("ankieta_nie");
            ankieta_ask.Text = lang("ankieta_ask");
        }

        public string lang(string text)
        {
            ResourceManager rm = new ResourceManager("_7DaysServerManager.lang.lang_en", this.GetType().Assembly);

            /*if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "lang", null) == "en")
            {
                rm = new ResourceManager("_7DaysServerManager.lang.lang_en", this.GetType().Assembly);
            }*/

            return rm.GetString(text);
        }

        private void potem_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "survey_done", "0");
            this.Close();
        }

        private void nigdy_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "survey_done", "1");
            this.Close();
        }

        private void tak_Click(object sender, EventArgs e)
        {
            ank.Visible = true;
            smile.Visible = false;
            tak.Visible = false;
            nigdy.Visible = false;
            potem.Visible = false;
            ankieta_ask.Visible = false;
            this.ControlBox = true;
            this.Width = 800;
            this.Height = 600;
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "survey_done", "1");
        }

        private void ankieta_Load(object sender, EventArgs e)
        {

        }


    }
}
