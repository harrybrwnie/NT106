namespace Lab6
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(54, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(712, 29);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "NT106.P21.ANTT.1 - Phan Cảnh Đăng Huân - Phạm Lê Đăng Kha";
            // 
            // btnClient
            // 
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClient.Location = new System.Drawing.Point(159, 181);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(162, 107);
            this.btnClient.TabIndex = 4;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnServer
            // 
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnServer.Location = new System.Drawing.Point(522, 181);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(162, 107);
            this.btnServer.TabIndex = 5;
            this.btnServer.Text = "Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnServer;
    }
}

