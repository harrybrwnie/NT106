namespace Lab_5
{
    partial class Dashboard
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
            this.lvEmails = new System.Windows.Forms.ListView();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvEmails
            // 
            this.lvEmails.HideSelection = false;
            this.lvEmails.Location = new System.Drawing.Point(236, 49);
            this.lvEmails.Name = "lvEmails";
            this.lvEmails.Size = new System.Drawing.Size(778, 454);
            this.lvEmails.TabIndex = 0;
            this.lvEmails.UseCompatibleStateImageBehavior = false;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(26, 49);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(145, 84);
            this.btnSendMail.TabIndex = 1;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 544);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.lvEmails);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvEmails;
        private System.Windows.Forms.Button btnSendMail;
    }
}