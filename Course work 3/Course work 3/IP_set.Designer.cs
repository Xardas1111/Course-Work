namespace Course_work_3
{
    partial class IP_set
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
            this.ip_box = new System.Windows.Forms.TextBox();
            this.Confirm_ip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ip_box
            // 
            this.ip_box.Location = new System.Drawing.Point(68, 12);
            this.ip_box.Name = "ip_box";
            this.ip_box.Size = new System.Drawing.Size(151, 20);
            this.ip_box.TabIndex = 0;
            // 
            // Confirm_ip
            // 
            this.Confirm_ip.Location = new System.Drawing.Point(106, 38);
            this.Confirm_ip.Name = "Confirm_ip";
            this.Confirm_ip.Size = new System.Drawing.Size(75, 23);
            this.Confirm_ip.TabIndex = 1;
            this.Confirm_ip.Text = "OK";
            this.Confirm_ip.UseVisualStyleBackColor = true;
            this.Confirm_ip.Click += new System.EventHandler(this.Confirm_ip_Click);
            // 
            // IP_set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 65);
            this.Controls.Add(this.Confirm_ip);
            this.Controls.Add(this.ip_box);
            this.Name = "IP_set";
            this.Text = "IP_set";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_box;
        private System.Windows.Forms.Button Confirm_ip;
    }
}