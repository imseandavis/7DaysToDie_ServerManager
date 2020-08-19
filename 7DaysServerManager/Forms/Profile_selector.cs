using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;

namespace _7DaysServerManager
{
    public partial class Profile_selector : Form
    {
        bool killapp = true;
        bool change_name_mode = false;

        public Profile_selector()
        {
            InitializeComponent();
        }

        private void Okay_Click(object sender, EventArgs e)
        {
            if (change_name_mode)
            {
                if (new_profilename.Text != "")
                {
                    new_profilename.Enabled = false;

                    String[] values = Registry.CurrentUser.OpenSubKey(@"Software\7DSM\" + profilename.Text).GetValueNames();

                    foreach (String value in values)
                    {
                        string val = Convert.ToString(Registry.GetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + profilename.Text, value, null));
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\" + new_profilename.Text, value, val);
                    }

                    Registry.CurrentUser.DeleteSubKeyTree(@"Software\7DSM\" + profilename.Text);

                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM", "last_profile", new_profilename.Text);

                    new_profilename.Enabled = true;
                    Rename_Click(null, null);
                    Reload_profiles();

                    MessageBox.Show("Profile renamed from \"" + new_profilename.Text + "\" to \"" + profilename.Text + "\".");
                }
                else
                {
                    Rename_Click(null, null);
                }

            }
            else
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM", "last_profile", profilename.Text);

                killapp = false;

                try
                {
                    monitor_changes.CancelAsync();
                }
                catch { }

                this.Close();
            }
 
        }

        private void Profile_selector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing && killapp)
            {
                e.Cancel = true;
                Environment.Exit(0);
            }
        }

        private void Reload_profiles()
        {
            int profiles_total = 0;
            try
            {
                profilename.Items.Clear();

                String[] values = Registry.CurrentUser.OpenSubKey(@"Software\7DSM").GetSubKeyNames();
                
                foreach (String value in values)
                {
                    profilename.Items.Add(value);
                    profiles_total++;
                }
            }catch{}
            try{
                if (profiles_total == 0)
                {
                    profilename.Items.Add("no profiles");
                    profilename.SelectedIndex = 0;
                    profilename.Enabled = false;
                    okay.Enabled = false;
                    delete.Enabled = false;
                    rename.Enabled = false;
                }
                else
                {
                    profilename.Enabled = true;
                    okay.Enabled = true;
                    delete.Enabled = true;
                    rename.Enabled = true;

                    if(Convert.ToString(profilename.SelectedIndex = profilename.FindString((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\7DSM", "last_profile", null)))=="-1")
                            profilename.SelectedIndex = 0;

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Exception while loading profiles:\n\n\n" + ex);
            }
        }


        private void Update_Old_Version()
        {
            try
            {
                String[] values = Registry.CurrentUser.OpenSubKey(@"Software\7DaysServerManager").GetValueNames();

                DialogResult dialogResult = MessageBox.Show("I found configuration from older versions of 7DSM.\nDo You want to import it to 7DSM?\nIf you do, it will be inaccessible from older versions of 7DSM.\nIf you don't, I'll ask you next time.", "Import", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Create New Key And Store Old 7DSM Configuration                    
                    foreach (String value in values)
                    {
                        string val = Convert.ToString(Registry.GetValue(@"HKEY_CURRENT_USER\Software\7DaysServerManager", value, null));
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM\Old 7DSM configuration", value, val);
                    }

                    Registry.CurrentUser.DeleteSubKeyTree(@"Software\7DaysServerManager");
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM", "last_profile", "Old 7DSM configuration");

                    MessageBox.Show("Profile created from imported configuration is named \"Old 7DSM configuration\".");
                }
                
            }
            catch {
                MessageBox.Show("Couldn't Find the Registry Key For 7DSM!");
            }
        }

        private void Profile_selector_Load(object sender, EventArgs e)
        {
            if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\7DSM", "skip_profiles", null) == "1")
            {
                killapp = false;
                this.Close();
            }
            else
            {
                monitor_changes.RunWorkerAsync();
                Update_Old_Version();
                Reload_profiles();
            }
        }

        private void Newprofile_Click(object sender, EventArgs e)
        {
            New_Profile sp = new New_Profile();
            sp.ShowDialog();
        }



        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Removing profile \"" + profilename.Text + "\"\nAre you sure?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                Registry.CurrentUser.DeleteSubKeyTree(@"Software\7DSM\"+ profilename.Text);
                MessageBox.Show("Profile removed");
                Reload_profiles();
            }
        }

        private void Monitor_changes_DoWork(object sender, DoWorkEventArgs e)
        {
            while (e.Cancel==false)
            {
                if (DataContainer.reload_now == true)
                {
                    profilename.Invoke((MethodInvoker)delegate
                    {
                        Reload_profiles();
                    });
                    DataContainer.reload_now = false;
                }
                Thread.Sleep(500);

            }
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            if (change_name_mode)
            {
                change_name_mode = false;
                new_profilename.Text = profilename.Text;
                newprofile.Enabled = true;
                delete.Enabled = true;
                profilename.Visible = true;
                new_profilename.Visible = false;
                rename.Text = "Rename";
                okay.Text = "Ok";
            }
            else
            {
                change_name_mode = true;
                new_profilename.Text = profilename.Text;
                newprofile.Enabled = false;
                delete.Enabled = false;
                profilename.Visible = false;
                new_profilename.Visible = true;
                rename.Text = "Cancel";
                okay.Text = "Apply";
            }
        }

        private void Skip_CheckedChanged(object sender, EventArgs e)
        {
            if(skip.Checked)
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM", "skip_profiles", "1");
            else
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\7DSM", "skip_profiles", "0");
        }

    }

    public static class DataContainer
    {
        public static bool reload_now;
    }
}