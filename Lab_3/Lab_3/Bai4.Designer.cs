namespace Lab_3
{
    partial class Bai4
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
            btnTCPClient = new Button();
            btnTCPListener = new Button();
            SuspendLayout();
            // 
            // btnTCPClient
            // 
            btnTCPClient.Font = new Font("Segoe UI", 16F);
            btnTCPClient.Location = new Point(100, 180);
            btnTCPClient.Name = "btnTCPClient";
            btnTCPClient.Size = new Size(406, 238);
            btnTCPClient.TabIndex = 0;
            btnTCPClient.Text = "TCP Client";
            btnTCPClient.UseVisualStyleBackColor = true;
            btnTCPClient.Click += btnTCPClient_Click;
            // 
            // btnTCPListener
            // 
            btnTCPListener.Font = new Font("Segoe UI", 16F);
            btnTCPListener.Location = new Point(625, 180);
            btnTCPListener.Name = "btnTCPListener";
            btnTCPListener.Size = new Size(406, 238);
            btnTCPListener.TabIndex = 1;
            btnTCPListener.Text = "TCP Listener";
            btnTCPListener.UseVisualStyleBackColor = true;
            btnTCPListener.Click += btnTCPListener_Click;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 662);
            Controls.Add(btnTCPListener);
            Controls.Add(btnTCPClient);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Bai4";
            Text = "Bai4";
            Load += Bai4_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTCPClient;
        private Button btnTCPListener;
    }
}