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
    public partial class Survey_Form : Form
    {
        public Survey_Form()
        {
            InitializeComponent();
            this.Text = Language("ankieta");
            Complete_Survey_Now_Button.Text = Language("ankieta_tak");
            Complete_Survey_Later_Button.Text = Language("ankieta_potem");
            Never_Complete_Survey_Button.Text = Language("ankieta_nie");
            Survey_Label.Text = Language("ankieta_ask");
        }

        public string Language(string text)
        {
            ResourceManager rm = new ResourceManager("_7DaysServerManager.lang.lang_en", this.GetType().Assembly);

            /*if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "lang", null) == "en")
            {
                rm = new ResourceManager("_7DaysServerManager.lang.lang_en", this.GetType().Assembly);
            }*/

            return rm.GetString(text);
        }

        private void Later_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "survey_done", "0");
            this.Close();
        }

        private void Never_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "survey_done", "1");
            this.Close();
        }

        private void Now_Click(object sender, EventArgs e)
        {
            ank.Visible = true;
            Survey_Smile_PictureBox.Visible = false;
            Complete_Survey_Now_Button.Visible = false;
            Never_Complete_Survey_Button.Visible = false;
            Complete_Survey_Later_Button.Visible = false;
            Survey_Label.Visible = false;
            this.ControlBox = true;
            this.Width = 800;
            this.Height = 600;
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "survey_done", "1");
        }

        private void Survey_Load(object sender, EventArgs e)
        {

        }


    }
}
