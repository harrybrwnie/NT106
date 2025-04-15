namespace Lab_3
{
    partial class UDPClientb1
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
            lblIPRemoteHost = new Label();
            tbIPRemoteHost = new TextBox();
            lblPort = new Label();
            tbPort = new TextBox();
            lblMessage = new Label();
            rtbMessage = new RichTextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // lblIPRemoteHost
            // 
            lblIPRemoteHost.AutoSize = true;
            lblIPRemoteHost.Location = new Point(74, 44);
            lblIPRemoteHost.Name = "lblIPRemoteHost";
            lblIPRemoteHost.Size = new Size(157, 30);
            lblIPRemoteHost.TabIndex = 0;
            lblIPRemoteHost.Text = "IP Remote Host";
            // 
            // tbIPRemoteHost
            // 
            tbIPRemoteHost.Location = new Point(74, 123);
            tbIPRemoteHost.Name = "tbIPRemoteHost";
            tbIPRemoteHost.Size = new Size(393, 35);
            tbIPRemoteHost.TabIndex = 1;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(587, 44);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(50, 30);
            lblPort.TabIndex = 2;
            lblPort.Text = "Port";
            // 
            // tbPort
            // 
            tbPort.Location = new Point(587, 123);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(237, 35);
            tbPort.TabIndex = 3;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(74, 252);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(95, 30);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "Message";
            // 
            // rtbMessage
            // 
            rtbMessage.Location = new Point(70, 341);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Size = new Size(965, 168);
            rtbMessage.TabIndex = 5;
            rtbMessage.Text = "";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(74, 566);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(180, 65);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // UDPClientb1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 719);
            Controls.Add(btnSend);
            Controls.Add(rtbMessage);
            Controls.Add(lblMessage);
            Controls.Add(tbPort);
            Controls.Add(lblPort);
            Controls.Add(tbIPRemoteHost);
            Controls.Add(lblIPRemoteHost);
            Name = "UDPClientb1";
            Text = "UDPClientb1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIPRemoteHost;
        private TextBox tbIPRemoteHost;
        private Label lblPort;
        private TextBox tbPort;
        private Label lblMessage;
        private RichTextBox rtbMessage;
        private Button btnSend;
    }
}