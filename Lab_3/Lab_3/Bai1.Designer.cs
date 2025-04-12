namespace Lab_3
{
    partial class Bai1
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
            btnUDPClient = new Button();
            btnUDPServer = new Button();
            SuspendLayout();
            // 
            // btnUDPClient
            // 
            btnUDPClient.Font = new Font("Segoe UI", 16F);
            btnUDPClient.Location = new Point(142, 186);
            btnUDPClient.Name = "btnUDPClient";
            btnUDPClient.Size = new Size(385, 244);
            btnUDPClient.TabIndex = 0;
            btnUDPClient.Text = "UDP Client";
            btnUDPClient.UseVisualStyleBackColor = true;
            btnUDPClient.Click += btnUDPClient_Click;
            // 
            // btnUDPServer
            // 
            btnUDPServer.Font = new Font("Segoe UI", 16F);
            btnUDPServer.Location = new Point(636, 186);
            btnUDPServer.Name = "btnUDPServer";
            btnUDPServer.Size = new Size(385, 244);
            btnUDPServer.TabIndex = 1;
            btnUDPServer.Text = "UDP Server";
            btnUDPServer.UseVisualStyleBackColor = true;
            btnUDPServer.Click += btnUDPServer_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 634);
            Controls.Add(btnUDPServer);
            Controls.Add(btnUDPClient);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUDPClient;
        private Button btnUDPServer;
    }
}