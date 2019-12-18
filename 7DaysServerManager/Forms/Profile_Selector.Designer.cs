namespace _7DaysServerManager
{
    partial class Profile_selector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_selector));
            this.profilename = new System.Windows.Forms.ComboBox();
            this.newprofile = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.okay = new System.Windows.Forms.Button();
            this.prof_l = new System.Windows.Forms.Label();
            this.monitor_changes = new System.ComponentModel.BackgroundWorker();
            this.rename = new System.Windows.Forms.Button();
            this.new_profilename = new System.Windows.Forms.TextBox();
            this.skip = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // profilename
            // 
            this.profilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profilename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profilename.FormattingEnabled = true;
            this.profilename.Location = new System.Drawing.Point(12, 30);
            this.profilename.Name = "profilename";
            this.profilename.Size = new System.Drawing.Size(237, 21);
            this.profilename.TabIndex = 0;
            // 
            // newprofile
            // 
            this.newprofile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newprofile.Location = new System.Drawing.Point(12, 57);
            this.newprofile.Name = "newprofile";
            this.newprofile.Size = new System.Drawing.Size(75, 23);
            this.newprofile.TabIndex = 1;
            this.newprofile.Text = "New";
            this.newprofile.UseVisualStyleBackColor = true;
            this.newprofile.Click += new System.EventHandler(this.Newprofile_Click);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Location = new System.Drawing.Point(93, 57);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // okay
            // 
            this.okay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okay.Location = new System.Drawing.Point(174, 86);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(75, 23);
            this.okay.TabIndex = 3;
            this.okay.Text = "Ok";
            this.okay.UseVisualStyleBackColor = true;
            this.okay.Click += new System.EventHandler(this.Okay_Click);
            // 
            // prof_l
            // 
            this.prof_l.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prof_l.AutoSize = true;
            this.prof_l.Location = new System.Drawing.Point(12, 9);
            this.prof_l.Name = "prof_l";
            this.prof_l.Size = new System.Drawing.Size(71, 13);
            this.prof_l.TabIndex = 4;
            this.prof_l.Text = "Select profile:";
            // 
            // monitor_changes
            // 
            this.monitor_changes.WorkerSupportsCancellation = true;
            this.monitor_changes.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Monitor_changes_DoWork);
            // 
            // rename
            // 
            this.rename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rename.Location = new System.Drawing.Point(174, 57);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(75, 23);
            this.rename.TabIndex = 5;
            this.rename.Text = "Rename";
            this.rename.UseVisualStyleBackColor = true;
            this.rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // new_profilename
            // 
            this.new_profilename.Location = new System.Drawing.Point(12, 31);
            this.new_profilename.Name = "new_profilename";
            this.new_profilename.Size = new System.Drawing.Size(237, 20);
            this.new_profilename.TabIndex = 6;
            this.new_profilename.Visible = false;
            // 
            // skip
            // 
            this.skip.AutoSize = true;
            this.skip.Location = new System.Drawing.Point(12, 90);
            this.skip.Name = "skip";
            this.skip.Size = new System.Drawing.Size(107, 17);
            this.skip.TabIndex = 7;
            this.skip.Text = "Skip this in future";
            this.skip.UseVisualStyleBackColor = true;
            this.skip.CheckedChanged += new System.EventHandler(this.Skip_CheckedChanged);
            // 
            // profile_selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 121);
            this.Controls.Add(this.skip);
            this.Controls.Add(this.new_profilename);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.prof_l);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.newprofile);
            this.Controls.Add(this.profilename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "profile_selector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7DSM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profile_selector_FormClosing);
            this.Load += new System.EventHandler(this.Profile_selector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox profilename;
        private System.Windows.Forms.Button newprofile;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button okay;
        private System.Windows.Forms.Label prof_l;
        private System.ComponentModel.BackgroundWorker monitor_changes;
        private System.Windows.Forms.Button rename;
        private System.Windows.Forms.TextBox new_profilename;
        private System.Windows.Forms.CheckBox skip;
    }
}