namespace _7DaysServerManager
{
    partial class error_reporter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(error_reporter));
            this.er_l1 = new System.Windows.Forms.Label();
            this.rep = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.halp_l = new System.Windows.Forms.Label();
            this.opt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // er_l1
            // 
            this.er_l1.AutoSize = true;
            this.er_l1.Location = new System.Drawing.Point(12, 9);
            this.er_l1.Name = "er_l1";
            this.er_l1.Size = new System.Drawing.Size(388, 39);
            this.er_l1.TabIndex = 0;
            this.er_l1.Text = "An error occured in 7 Days Server Manager.\r\nI\'ve collected some informations on i" +
    "t.\r\nPlease, click \"Send report\", that will help me repair the problem in future " +
    "updates.";
            // 
            // rep
            // 
            this.rep.Location = new System.Drawing.Point(15, 51);
            this.rep.Name = "rep";
            this.rep.ReadOnly = true;
            this.rep.Size = new System.Drawing.Size(385, 141);
            this.rep.TabIndex = 1;
            this.rep.Text = "";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(15, 334);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(385, 34);
            this.send.TabIndex = 2;
            this.send.Text = "Send report";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // halp_l
            // 
            this.halp_l.AutoSize = true;
            this.halp_l.Location = new System.Drawing.Point(12, 202);
            this.halp_l.Name = "halp_l";
            this.halp_l.Size = new System.Drawing.Size(343, 13);
            this.halp_l.TabIndex = 3;
            this.halp_l.Text = "(Optional) Please describe what were you doing while problem occurred";
            // 
            // opt
            // 
            this.opt.Location = new System.Drawing.Point(15, 218);
            this.opt.Name = "opt";
            this.opt.Size = new System.Drawing.Size(385, 110);
            this.opt.TabIndex = 4;
            this.opt.Text = "";
            // 
            // error_reporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 389);
            this.Controls.Add(this.opt);
            this.Controls.Add(this.halp_l);
            this.Controls.Add(this.send);
            this.Controls.Add(this.rep);
            this.Controls.Add(this.er_l1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "error_reporter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Reporter";
            this.Load += new System.EventHandler(this.error_reporter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label er_l1;
        private System.Windows.Forms.RichTextBox rep;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label halp_l;
        private System.Windows.Forms.RichTextBox opt;
    }
}