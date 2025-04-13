namespace Lab_3
{
    partial class TCPClientb4
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
            rtbChat = new RichTextBox();
            lblName = new Label();
            tbName = new TextBox();
            lblMessage = new Label();
            tbMessage = new TextBox();
            btnConnect = new Button();
            btnSend = new Button();
            SuspendLayout();
            // 
            // rtbChat
            // 
            rtbChat.Location = new Point(56, 72);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(1173, 423);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(78, 607);
            lblName.Name = "lblName";
            lblName.Size = new Size(69, 30);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(78, 663);
            tbName.Name = "tbName";
            tbName.Size = new Size(175, 35);
            tbName.TabIndex = 2;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(78, 729);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(95, 30);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "Message";
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(78, 779);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(638, 35);
            tbMessage.TabIndex = 4;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(873, 638);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(131, 40);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(873, 774);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(131, 40);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // TCPClientb4
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 855);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Controls.Add(tbMessage);
            Controls.Add(lblMessage);
            Controls.Add(tbName);
            Controls.Add(lblName);
            Controls.Add(rtbChat);
            Name = "TCPClientb4";
            Text = "TCPClientb4";
            FormClosing += TCPClientb4_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbChat;
        private Label lblName;
        private TextBox tbName;
        private Label lblMessage;
        private TextBox tbMessage;
        private Button btnConnect;
        private Button btnSend;
    }
}