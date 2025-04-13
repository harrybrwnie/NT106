namespace Lab_3
{
    partial class TCPListenerb4
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
            btnListen = new Button();
            rtbMessage = new RichTextBox();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.Font = new Font("Segoe UI", 16F);
            btnListen.Location = new Point(819, 84);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(230, 54);
            btnListen.TabIndex = 0;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // rtbMessage
            // 
            rtbMessage.BackColor = SystemColors.ButtonHighlight;
            rtbMessage.Location = new Point(67, 226);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.ReadOnly = true;
            rtbMessage.Size = new Size(982, 382);
            rtbMessage.TabIndex = 1;
            rtbMessage.Text = "";
            // 
            // TCPListenerb4
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 658);
            Controls.Add(rtbMessage);
            Controls.Add(btnListen);
            Name = "TCPListenerb4";
            Text = "TCPListenerb4";
            FormClosing += TCPListenerb4_FormClosing_1;
            ResumeLayout(false);
        }

        #endregion

        private Button btnListen;
        private RichTextBox rtbMessage;
    }
}