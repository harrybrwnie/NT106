namespace Lab_3
{
    partial class UDPServerb1
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
            lblPort = new Label();
            tbPort = new TextBox();
            btnListen = new Button();
            lbRecievedMessages = new Label();
            tbRecievedMessages = new RichTextBox();
            SuspendLayout();
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Font = new Font("Segoe UI", 16F);
            lblPort.Location = new Point(53, 61);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(90, 51);
            lblPort.TabIndex = 0;
            lblPort.Text = "Port";
            // 
            // tbPort
            // 
            tbPort.Location = new Point(189, 74);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(175, 35);
            tbPort.TabIndex = 1;
            // 
            // btnListen
            // 
            btnListen.Font = new Font("Segoe UI", 16F);
            btnListen.Location = new Point(894, 74);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(175, 71);
            btnListen.TabIndex = 2;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // lbRecievedMessages
            // 
            lbRecievedMessages.AutoSize = true;
            lbRecievedMessages.Font = new Font("Segoe UI", 16F);
            lbRecievedMessages.Location = new Point(78, 204);
            lbRecievedMessages.Name = "lbRecievedMessages";
            lbRecievedMessages.Size = new Size(344, 51);
            lbRecievedMessages.TabIndex = 3;
            lbRecievedMessages.Text = "Recieved Messages";
            // 
            // tbRecievedMessages
            // 
            tbRecievedMessages.Location = new Point(78, 277);
            tbRecievedMessages.Name = "tbRecievedMessages";
            tbRecievedMessages.ReadOnly = true;
            tbRecievedMessages.Size = new Size(991, 292);
            tbRecievedMessages.TabIndex = 4;
            tbRecievedMessages.Text = "";
            // 
            // UDPServerb1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 639);
            Controls.Add(tbRecievedMessages);
            Controls.Add(lbRecievedMessages);
            Controls.Add(btnListen);
            Controls.Add(tbPort);
            Controls.Add(lblPort);
            Name = "UDPServerb1";
            Text = "UDPServerb1";
            FormClosing += UDPServerb1_FormClosing_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPort;
        private TextBox tbPort;
        private Button btnListen;
        private Label lbRecievedMessages;
        private RichTextBox tbRecievedMessages;
    }
}