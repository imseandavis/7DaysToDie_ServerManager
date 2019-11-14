namespace _7DaysServerManager
{
    partial class contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contact));
            this.to_t = new System.Windows.Forms.TextBox();
            this.to_l = new System.Windows.Forms.Label();
            this.from_t = new System.Windows.Forms.TextBox();
            this.from_l = new System.Windows.Forms.Label();
            this.topic_l = new System.Windows.Forms.Label();
            this.topic_t = new System.Windows.Forms.TextBox();
            this.tresc = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // to_t
            // 
            this.to_t.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.to_t.Enabled = false;
            this.to_t.Location = new System.Drawing.Point(55, 12);
            this.to_t.Name = "to_t";
            this.to_t.Size = new System.Drawing.Size(397, 20);
            this.to_t.TabIndex = 0;
            this.to_t.Text = "pionner@smartmoose.org";
            // 
            // to_l
            // 
            this.to_l.AutoSize = true;
            this.to_l.Location = new System.Drawing.Point(16, 15);
            this.to_l.Name = "to_l";
            this.to_l.Size = new System.Drawing.Size(23, 13);
            this.to_l.TabIndex = 1;
            this.to_l.Text = "To:";
            // 
            // from_t
            // 
            this.from_t.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.from_t.Location = new System.Drawing.Point(55, 38);
            this.from_t.Name = "from_t";
            this.from_t.Size = new System.Drawing.Size(397, 20);
            this.from_t.TabIndex = 2;
            this.from_t.Text = "(if you want to receive response, enter your email here)";
            this.from_t.Enter += new System.EventHandler(this.from_t_Enter);
            this.from_t.Leave += new System.EventHandler(this.from_t_Leave);
            // 
            // from_l
            // 
            this.from_l.AutoSize = true;
            this.from_l.Location = new System.Drawing.Point(16, 41);
            this.from_l.Name = "from_l";
            this.from_l.Size = new System.Drawing.Size(33, 13);
            this.from_l.TabIndex = 3;
            this.from_l.Text = "From:";
            // 
            // topic_l
            // 
            this.topic_l.AutoSize = true;
            this.topic_l.Location = new System.Drawing.Point(16, 79);
            this.topic_l.Name = "topic_l";
            this.topic_l.Size = new System.Drawing.Size(37, 13);
            this.topic_l.TabIndex = 4;
            this.topic_l.Text = "Topic:";
            // 
            // topic_t
            // 
            this.topic_t.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topic_t.Location = new System.Drawing.Point(55, 76);
            this.topic_t.Name = "topic_t";
            this.topic_t.Size = new System.Drawing.Size(397, 20);
            this.topic_t.TabIndex = 5;
            // 
            // tresc
            // 
            this.tresc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tresc.Location = new System.Drawing.Point(19, 117);
            this.tresc.Name = "tresc";
            this.tresc.Size = new System.Drawing.Size(433, 157);
            this.tresc.TabIndex = 6;
            this.tresc.Text = "";
            // 
            // send
            // 
            this.send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.send.Location = new System.Drawing.Point(387, 280);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(65, 23);
            this.send.TabIndex = 7;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "You can just send me an email at pionner@smartmoose.org and I\'ll read it.";
            // 
            // contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.tresc);
            this.Controls.Add(this.topic_t);
            this.Controls.Add(this.topic_l);
            this.Controls.Add(this.from_l);
            this.Controls.Add(this.from_t);
            this.Controls.Add(this.to_l);
            this.Controls.Add(this.to_t);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox to_t;
        private System.Windows.Forms.Label to_l;
        private System.Windows.Forms.TextBox from_t;
        private System.Windows.Forms.Label from_l;
        private System.Windows.Forms.Label topic_l;
        private System.Windows.Forms.TextBox topic_t;
        private System.Windows.Forms.RichTextBox tresc;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label1;
    }
}