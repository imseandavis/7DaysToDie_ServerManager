namespace _7DaysServerManager
{
    partial class hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hello));
            this.diablestart = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.showme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diablestart
            // 
            this.diablestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.diablestart.AutoSize = true;
            this.diablestart.BackColor = System.Drawing.Color.Transparent;
            this.diablestart.ForeColor = System.Drawing.Color.Black;
            this.diablestart.Location = new System.Drawing.Point(12, 139);
            this.diablestart.Name = "diablestart";
            this.diablestart.Size = new System.Drawing.Size(116, 17);
            this.diablestart.TabIndex = 3;
            this.diablestart.Text = "Don\'t show it again";
            this.diablestart.UseVisualStyleBackColor = false;
            this.diablestart.CheckedChanged += new System.EventHandler(this.diablestart_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 92);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hi\r\n\r\nThis is free software. You can use it, share it and have fun with it.\r\n\r\nIf" +
    " you like it, please consider donating few dollars for the developer.\r\n\r\nThanks," +
    " pionner";
            // 
            // ok
            // 
            this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok.Location = new System.Drawing.Point(266, 135);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(93, 23);
            this.ok.TabIndex = 1;
            this.ok.Text = "Close";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // showme
            // 
            this.showme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showme.Location = new System.Drawing.Point(167, 135);
            this.showme.Name = "showme";
            this.showme.Size = new System.Drawing.Size(93, 23);
            this.showme.TabIndex = 5;
            this.showme.Text = "Donate now!";
            this.showme.UseVisualStyleBackColor = true;
            this.showme.Click += new System.EventHandler(this.showme_Click);
            // 
            // hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(371, 166);
            this.ControlBox = false;
            this.Controls.Add(this.showme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diablestart);
            this.Controls.Add(this.ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "hello";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello there:)";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.hello_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox diablestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button showme;
    }
}