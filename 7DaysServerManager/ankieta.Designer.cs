namespace _7DaysServerManager
{
    partial class ankieta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ankieta));
            this.ank = new System.Windows.Forms.WebBrowser();
            this.ankieta_ask = new System.Windows.Forms.Label();
            this.tak = new System.Windows.Forms.Button();
            this.potem = new System.Windows.Forms.Button();
            this.nigdy = new System.Windows.Forms.Button();
            this.smile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.smile)).BeginInit();
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
            // ankieta_ask
            // 
            this.ankieta_ask.Location = new System.Drawing.Point(24, 16);
            this.ankieta_ask.Name = "ankieta_ask";
            this.ankieta_ask.Size = new System.Drawing.Size(244, 104);
            this.ankieta_ask.TabIndex = 1;
            this.ankieta_ask.Text = "ankieta_ask";
            // 
            // tak
            // 
            this.tak.Location = new System.Drawing.Point(112, 126);
            this.tak.Name = "tak";
            this.tak.Size = new System.Drawing.Size(193, 71);
            this.tak.TabIndex = 2;
            this.tak.Text = "Tak, wypełnię ankietę teraz:)";
            this.tak.UseVisualStyleBackColor = true;
            this.tak.Click += new System.EventHandler(this.tak_Click);
            // 
            // potem
            // 
            this.potem.Location = new System.Drawing.Point(112, 203);
            this.potem.Name = "potem";
            this.potem.Size = new System.Drawing.Size(193, 41);
            this.potem.TabIndex = 3;
            this.potem.Text = "Tak, wypełnię ankietę, ale następnym razem.";
            this.potem.UseVisualStyleBackColor = true;
            this.potem.Click += new System.EventHandler(this.potem_Click);
            // 
            // nigdy
            // 
            this.nigdy.Location = new System.Drawing.Point(112, 250);
            this.nigdy.Name = "nigdy";
            this.nigdy.Size = new System.Drawing.Size(193, 41);
            this.nigdy.TabIndex = 4;
            this.nigdy.Text = "Jestem bardzo złym człowiekiem, nie pokazuj mi tego okna ponownie.";
            this.nigdy.UseVisualStyleBackColor = true;
            this.nigdy.Click += new System.EventHandler(this.nigdy_Click);
            // 
            // smile
            // 
            this.smile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smile.BackgroundImage")));
            this.smile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.smile.Location = new System.Drawing.Point(274, 16);
            this.smile.Name = "smile";
            this.smile.Size = new System.Drawing.Size(128, 104);
            this.smile.TabIndex = 5;
            this.smile.TabStop = false;
            // 
            // ankieta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 301);
            this.ControlBox = false;
            this.Controls.Add(this.smile);
            this.Controls.Add(this.nigdy);
            this.Controls.Add(this.potem);
            this.Controls.Add(this.tak);
            this.Controls.Add(this.ankieta_ask);
            this.Controls.Add(this.ank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ankieta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poświęcisz mi chwilę?";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ankieta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser ank;
        private System.Windows.Forms.Label ankieta_ask;
        private System.Windows.Forms.Button tak;
        private System.Windows.Forms.Button potem;
        private System.Windows.Forms.Button nigdy;
        private System.Windows.Forms.PictureBox smile;
    }
}