using System;
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
    public partial class profile_selector : Form
    {
        bool killapp = true;
        bool change_name_mode = false;

        public profile_selector()
        {
            InitializeComponent();
        }

        private void okay_Click(object sender, EventArgs e)
        {
            if (change_name_mode)
            {
                if (new_profilename.Text != "")
                {
                    new_profilename.Enabled = false;

                    String[] values = Registry.CurrentUser.OpenSubKey(@"Software\pionner\7DSM\" + profilename.Text).GetValueNames();

                    foreach (String value in values)
                    {
                        string val = Convert.ToString(Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profilename.Text, value, null));
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + new_profilename.Text, value, val);
                    }

                    Registry.CurrentUser.DeleteSubKeyTree(@"Software\pionner\7DSM\" + profilename.Text);

                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "last_profile", new_profilename.Text);

                    new_profilename.Enabled = true;
                    rename_Click(null, null);
                    reload_profiles();

                    MessageBox.Show("Profile renamed from \"" + new_profilename.Text + "\" to \"" + profilename.Text + "\".");
                }
                else
                {
                    rename_Click(null, null);
                }

            }
            else
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "last_profile", profilename.Text);

                killapp = false;

                try
                {
                    monitor_changes.CancelAsync();
                }
                catch { }

                this.Close();
            }
           
            
        }

        private void profile_selector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing && killapp)
            {
                e.Cancel = true;
                Environment.Exit(0);
            }
        }

        private void reload_profiles()
        {
            int profiles_total = 0;
            try
            {
                profilename.Items.Clear();

                String[] values = Registry.CurrentUser.OpenSubKey(@"Software\pionner\7DSM").GetSubKeyNames();
                
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

                    if(Convert.ToString(profilename.SelectedIndex = profilename.FindString((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "last_profile", null)))=="-1")
                            profilename.SelectedIndex = 0;

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Exception while loading profiles:\n\n\n" + ex);
            }
        }


        private void load_old_ver()
        {
            try
            {
                String[] values = Registry.CurrentUser.OpenSubKey(@"Software\pionner\7DaysServerManager").GetValueNames();

                DialogResult dialogResult = MessageBox.Show("I found configuration from older versions of 7DSM.\nDo You want to import it to 7DSM?\nIf you do, it will be inaccessible from older versions of 7DSM.\nIf you don't, I'll ask you next time.", "Import", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (String value in values)
                    {
                        string val = Convert.ToString(Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DaysServerManager", value, null));
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\Old 7DSM configuration", value, val);
                    }

                    Registry.CurrentUser.DeleteSubKeyTree(@"Software\pionner\7DaysServerManager");

                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "last_profile", "Old 7DSM configuration");

                    MessageBox.Show("Profile created from imported configuration is named \"Old 7DSM configuration\".");
                }
                
            }
            catch { }
        }

        private void profile_selector_Load(object sender, EventArgs e)
        {
            if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "skip_profiles", null) == "1")
            {
                killapp = false;
                this.Close();
            }
            else
            {
                monitor_changes.RunWorkerAsync();
                load_old_ver();
                reload_profiles();
            }
        }

        private void newprofile_Click(object sender, EventArgs e)
        {
            new_profile sp = new new_profile();
            sp.ShowDialog();
        }



        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Removing profile \"" + profilename.Text + "\"\nAre you sure?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                Registry.CurrentUser.DeleteSubKeyTree(@"Software\pionner\7DSM\"+ profilename.Text);
                MessageBox.Show("Profile removed");
                reload_profiles();
            }
        }

        private void monitor_changes_DoWork(object sender, DoWorkEventArgs e)
        {
            while (e.Cancel==false)
            {
                if (DataContainer.reload_now == true)
                {
                    profilename.Invoke((MethodInvoker)delegate
                    {
                        reload_profiles();
                    });
                    DataContainer.reload_now = false;
                }
                System.Threading.Thread.Sleep(500);

            }
        }

        private void rename_Click(object sender, EventArgs e)
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

        private void skip_CheckedChanged(object sender, EventArgs e)
        {
            if(skip.Checked)
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "skip_profiles", "1");
            else
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM", "skip_profiles", "0");
        }

    }

    public static class DataContainer
    {
        public static bool reload_now;
    }
}
