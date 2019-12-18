namespace _7DaysServerManager
{
    partial class Survey_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Survey_Form));
            this.ank = new System.Windows.Forms.WebBrowser();
            this.Survey_Label = new System.Windows.Forms.Label();
            this.Complete_Survey_Now_Button = new System.Windows.Forms.Button();
            this.Complete_Survey_Later_Button = new System.Windows.Forms.Button();
            this.Never_Complete_Survey_Button = new System.Windows.Forms.Button();
            this.Survey_Smile_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Survey_Smile_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ank
            // 
            this.ank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ank.Location = new System.Drawing.Point(0, 0);
            this.ank.MinimumSize = new System.Drawing.Size(20, 20);
            this.ank.Name = "ank";
            this.ank.Size = new System.Drawing.Size(414, 301);
            this.ank.TabIndex = 0;
            this.ank.Url = new System.Uri("https://docs.google.com/forms/d/1Kj--U8DDy9tNtb1zHV4SiiLL39XRKdaW1wYu0nyw8wM/view" +
        "form", System.UriKind.Absolute);
            this.ank.Visible = false;
            // 
            // Survey_Label
            // 
            this.Survey_Label.Location = new System.Drawing.Point(24, 16);
            this.Survey_Label.Name = "Survey_Label";
            this.Survey_Label.Size = new System.Drawing.Size(244, 104);
            this.Survey_Label.TabIndex = 1;
            this.Survey_Label.Text = "ankieta_ask";
            // 
            // Complete_Survey_Now_Button
            // 
            this.Complete_Survey_Now_Button.Location = new System.Drawing.Point(112, 126);
            this.Complete_Survey_Now_Button.Name = "Complete_Survey_Now_Button";
            this.Complete_Survey_Now_Button.Size = new System.Drawing.Size(193, 71);
            this.Complete_Survey_Now_Button.TabIndex = 2;
            this.Complete_Survey_Now_Button.Text = "Complete Survey";
            this.Complete_Survey_Now_Button.UseVisualStyleBackColor = true;
            this.Complete_Survey_Now_Button.Click += new System.EventHandler(this.Now_Click);
            // 
            // Complete_Survey_Later_Button
            // 
            this.Complete_Survey_Later_Button.Location = new System.Drawing.Point(112, 203);
            this.Complete_Survey_Later_Button.Name = "Complete_Survey_Later_Button";
            this.Complete_Survey_Later_Button.Size = new System.Drawing.Size(193, 41);
            this.Complete_Survey_Later_Button.TabIndex = 3;
            this.Complete_Survey_Later_Button.Text = "Remind Me Later";
            this.Complete_Survey_Later_Button.UseVisualStyleBackColor = true;
            this.Complete_Survey_Later_Button.Click += new System.EventHandler(this.Later_Click);
            // 
            // Never_Complete_Survey_Button
            // 
            this.Never_Complete_Survey_Button.Location = new System.Drawing.Point(112, 250);
            this.Never_Complete_Survey_Button.Name = "Never_Complete_Survey_Button";
            this.Never_Complete_Survey_Button.Size = new System.Drawing.Size(193, 41);
            this.Never_Complete_Survey_Button.TabIndex = 4;
            this.Never_Complete_Survey_Button.Text = "Don\'t Show This Window Again";
            this.Never_Complete_Survey_Button.UseVisualStyleBackColor = true;
            this.Never_Complete_Survey_Button.Click += new System.EventHandler(this.Never_Click);
            // 
            // Survey_Smile_PictureBox
            // 
            this.Survey_Smile_PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Survey_Smile_PictureBox.BackgroundImage")));
            this.Survey_Smile_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Survey_Smile_PictureBox.Location = new System.Drawing.Point(274, 16);
            this.Survey_Smile_PictureBox.Name = "Survey_Smile_PictureBox";
            this.Survey_Smile_PictureBox.Size = new System.Drawing.Size(128, 104);
            this.Survey_Smile_PictureBox.TabIndex = 5;
            this.Survey_Smile_PictureBox.TabStop = false;
            // 
            // Survey_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 301);
            this.ControlBox = false;
            this.Controls.Add(this.Survey_Smile_PictureBox);
            this.Controls.Add(this.Never_Complete_Survey_Button);
            this.Controls.Add(this.Complete_Survey_Later_Button);
            this.Controls.Add(this.Complete_Survey_Now_Button);
            this.Controls.Add(this.Survey_Label);
            this.Controls.Add(this.ank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Survey_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please Take A Moment To Provide Feedback.";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Survey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Survey_Smile_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser ank;
        private System.Windows.Forms.Label Survey_Label;
        private System.Windows.Forms.Button Complete_Survey_Now_Button;
        private System.Windows.Forms.Button Complete_Survey_Later_Button;
        private System.Windows.Forms.Button Never_Complete_Survey_Button;
        private System.Windows.Forms.PictureBox Survey_Smile_PictureBox;
    }
}