namespace _7DaysServerManager
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.info = new System.Windows.Forms.RichTextBox();
            this.tit = new System.Windows.Forms.Label();
            this.icn = new System.Windows.Forms.PictureBox();
            this.license = new System.Windows.Forms.Button();
            this.ver = new System.Windows.Forms.Label();
            this.by = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icn)).BeginInit();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(12, 64);
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Size = new System.Drawing.Size(428, 319);
            this.info.TabIndex = 10;
            this.info.Text = resources.GetString("info.Text");
            this.info.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // tit
            // 
            this.tit.AutoSize = true;
            this.tit.BackColor = System.Drawing.Color.Transparent;
            this.tit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.tit.Location = new System.Drawing.Point(67, 9);
            this.tit.Name = "tit";
            this.tit.Size = new System.Drawing.Size(184, 18);
            this.tit.TabIndex = 11;
            this.tit.Text = "7 Days Server Manager";
            this.tit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // icn
            // 
            this.icn.Image = ((System.Drawing.Image)(resources.GetObject("icn.Image")));
            this.icn.Location = new System.Drawing.Point(12, 9);
            this.icn.Name = "icn";
            this.icn.Size = new System.Drawing.Size(52, 49);
            this.icn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icn.TabIndex = 12;
            this.icn.TabStop = false;
            // 
            // license
            // 
            this.license.Location = new System.Drawing.Point(365, 389);
            this.license.Name = "license";
            this.license.Size = new System.Drawing.Size(75, 23);
            this.license.TabIndex = 13;
            this.license.Text = "License";
            this.license.UseVisualStyleBackColor = true;
            this.license.Click += new System.EventHandler(this.license_Click);
            // 
            // ver
            // 
            this.ver.AutoSize = true;
            this.ver.BackColor = System.Drawing.Color.Transparent;
            this.ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ver.Location = new System.Drawing.Point(70, 27);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(22, 13);
            this.ver.TabIndex = 14;
            this.ver.Text = "ver";
            // 
            // by
            // 
            this.by.AutoSize = true;
            this.by.BackColor = System.Drawing.Color.Transparent;
            this.by.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.by.Location = new System.Drawing.Point(70, 40);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(56, 13);
            this.by.TabIndex = 15;
            this.by.Text = "by Sean Davis";
            this.by.Click += new System.EventHandler(this.by_Click);
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 421);
            this.Controls.Add(this.by);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.license);
            this.Controls.Add(this.icn);
            this.Controls.Add(this.tit);
            this.Controls.Add(this.info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "about";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About 7 Days Server Manager";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.about_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.icn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Label tit;
        private System.Windows.Forms.PictureBox icn;
        private System.Windows.Forms.Button license;
        private System.Windows.Forms.Label ver;
        private System.Windows.Forms.Label by;
    }
}