namespace _7DaysServerManager
{
    partial class New_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Profile));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.profname = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.fr_hi = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.manual = new System.Windows.Forms.Button();
            this.fr_detect = new System.Windows.Forms.Label();
            this.auto = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.fr_fin = new System.Windows.Forms.Button();
            this.fr_end = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.licz = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pb = new System.Windows.Forms.ToolStripProgressBar();
            this.select_dir = new System.Windows.Forms.FolderBrowserDialog();
            this.exe_name = new System.Windows.Forms.TextBox();
            this.exe_n_l = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(249, 188);
            this.tabControl1.TabIndex = 35;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.profname);
            this.tabPage2.Controls.Add(this.next);
            this.tabPage2.Controls.Add(this.fr_hi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(241, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1";
            // 
            // profname
            // 
            this.profname.Location = new System.Drawing.Point(6, 99);
            this.profname.Name = "profname";
            this.profname.Size = new System.Drawing.Size(226, 20);
            this.profname.TabIndex = 2;
            // 
            // next
            // 
            this.next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.next.Location = new System.Drawing.Point(158, 130);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 1;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.Next_Click);
            // 
            // fr_hi
            // 
            this.fr_hi.Location = new System.Drawing.Point(9, 14);
            this.fr_hi.Name = "fr_hi";
            this.fr_hi.Size = new System.Drawing.Size(224, 82);
            this.fr_hi.TabIndex = 0;
            this.fr_hi.Text = "fr_hi";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.exe_n_l);
            this.tabPage3.Controls.Add(this.exe_name);
            this.tabPage3.Controls.Add(this.manual);
            this.tabPage3.Controls.Add(this.fr_detect);
            this.tabPage3.Controls.Add(this.auto);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(241, 162);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2";
            // 
            // manual
            // 
            this.manual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manual.Location = new System.Drawing.Point(12, 127);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(221, 23);
            this.manual.TabIndex = 2;
            this.manual.Text = "manual";
            this.manual.UseVisualStyleBackColor = true;
            this.manual.Click += new System.EventHandler(this.Manual_Click);
            // 
            // fr_detect
            // 
            this.fr_detect.Location = new System.Drawing.Point(9, 13);
            this.fr_detect.Name = "fr_detect";
            this.fr_detect.Size = new System.Drawing.Size(224, 82);
            this.fr_detect.TabIndex = 1;
            this.fr_detect.Text = "fr_detect";
            // 
            // auto
            // 
            this.auto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auto.Location = new System.Drawing.Point(12, 98);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(221, 23);
            this.auto.TabIndex = 0;
            this.auto.Text = "auto";
            this.auto.UseVisualStyleBackColor = true;
            this.auto.Click += new System.EventHandler(this.Auto_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.fr_fin);
            this.tabPage4.Controls.Add(this.fr_end);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(241, 162);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "3";
            // 
            // fr_fin
            // 
            this.fr_fin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fr_fin.Location = new System.Drawing.Point(3, 136);
            this.fr_fin.Name = "fr_fin";
            this.fr_fin.Size = new System.Drawing.Size(235, 23);
            this.fr_fin.TabIndex = 2;
            this.fr_fin.Text = "fr_fin";
            this.fr_fin.UseVisualStyleBackColor = true;
            this.fr_fin.Click += new System.EventHandler(this.Fr_fin_Click);
            // 
            // fr_end
            // 
            this.fr_end.Location = new System.Drawing.Point(8, 10);
            this.fr_end.Name = "fr_end";
            this.fr_end.Size = new System.Drawing.Size(224, 82);
            this.fr_end.TabIndex = 1;
            this.fr_end.Text = "fr_end";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licz,
            this.toolStripStatusLabel2,
            this.pb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 189);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(248, 22);
            this.statusStrip1.TabIndex = 36;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // licz
            // 
            this.licz.Name = "licz";
            this.licz.Size = new System.Drawing.Size(13, 17);
            this.licz.Text = "1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(18, 17);
            this.toolStripStatusLabel2.Text = "/3";
            // 
            // pb
            // 
            this.pb.Maximum = 2;
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(100, 16);
            // 
            // select_dir
            // 
            this.select_dir.Description = "Select game directory";
            this.select_dir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.select_dir.ShowNewFolderButton = false;
            this.select_dir.HelpRequest += new System.EventHandler(this.Select_dir_HelpRequest);
            // 
            // exe_name
            // 
            this.exe_name.Location = new System.Drawing.Point(74, 71);
            this.exe_name.Name = "exe_name";
            this.exe_name.Size = new System.Drawing.Size(158, 20);
            this.exe_name.TabIndex = 3;
            this.exe_name.Text = "7DaysToDie.exe";
            // 
            // exe_n_l
            // 
            this.exe_n_l.AutoSize = true;
            this.exe_n_l.Location = new System.Drawing.Point(9, 74);
            this.exe_n_l.Name = "exe_n_l";
            this.exe_n_l.Size = new System.Drawing.Size(59, 13);
            this.exe_n_l.TabIndex = 4;
            this.exe_n_l.Text = ".exe name:";
            // 
            // new_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 211);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "new_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New profile";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.First_run_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label fr_hi;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button manual;
        private System.Windows.Forms.Label fr_detect;
        private System.Windows.Forms.Button auto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel licz;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar pb;
        private System.Windows.Forms.FolderBrowserDialog select_dir;
        private System.Windows.Forms.Label fr_end;
        private System.Windows.Forms.Button fr_fin;
        private System.Windows.Forms.TextBox profname;
        private System.Windows.Forms.Label exe_n_l;
        private System.Windows.Forms.TextBox exe_name;
    }
}