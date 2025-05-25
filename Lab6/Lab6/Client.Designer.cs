namespace Lab6
{
    partial class Client
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

        //private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSendGuess;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.CheckBox chkAutoPlay;

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSendGuess = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.chkAutoPlay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(211, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(353, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(15, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(179, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên người chơi:";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(211, 55);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(353, 26);
            this.txtGuess.TabIndex = 4;
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGuess.Location = new System.Drawing.Point(15, 55);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(142, 29);
            this.lblGuess.TabIndex = 3;
            this.lblGuess.Text = "Số dự đoán:";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConnect.Location = new System.Drawing.Point(20, 107);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(289, 44);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSendGuess
            // 
            this.btnSendGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSendGuess.Location = new System.Drawing.Point(20, 157);
            this.btnSendGuess.Name = "btnSendGuess";
            this.btnSendGuess.Size = new System.Drawing.Size(289, 43);
            this.btnSendGuess.TabIndex = 5;
            this.btnSendGuess.Text = "Gửi";
            this.btnSendGuess.UseVisualStyleBackColor = true;
            this.btnSendGuess.Click += new System.EventHandler(this.btnSendGuess_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtbLog.Location = new System.Drawing.Point(12, 323);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(1130, 476);
            this.rtbLog.TabIndex = 8;
            this.rtbLog.Text = "";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Location = new System.Drawing.Point(380, 55);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(0, 20);
            this.lblCountdown.TabIndex = 6;
            // 
            // chkAutoPlay
            // 
            this.chkAutoPlay.AutoSize = true;
            this.chkAutoPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkAutoPlay.Location = new System.Drawing.Point(20, 226);
            this.chkAutoPlay.Name = "chkAutoPlay";
            this.chkAutoPlay.Size = new System.Drawing.Size(180, 33);
            this.chkAutoPlay.TabIndex = 7;
            this.chkAutoPlay.Text = "Tự động chơi";
            this.chkAutoPlay.UseVisualStyleBackColor = true;
            this.chkAutoPlay.CheckedChanged += new System.EventHandler(this.chkAutoPlay_CheckedChanged);
            // 
            // Client
            // 
            this.ClientSize = new System.Drawing.Size(1157, 811);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.chkAutoPlay);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.btnSendGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Client";
            this.Text = "Guess Number Game Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}