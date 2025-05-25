namespace Lab6
{
    partial class Server
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPlayerCountLabel;
        private System.Windows.Forms.Label lblPlayerCount;
        private System.Windows.Forms.Label lblRoundLabel;
        private System.Windows.Forms.Label lblCurrentRound;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMistakes;
        private System.Windows.Forms.Label lblSecretNumberLabel;
        private System.Windows.Forms.Label lblSecretNumber;
        private System.Windows.Forms.Label lblRangeLabel;
        private System.Windows.Forms.Label lblRange;



        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPlayerCountLabel = new System.Windows.Forms.Label();
            this.lblPlayerCount = new System.Windows.Forms.Label();
            this.lblRoundLabel = new System.Windows.Forms.Label();
            this.lblCurrentRound = new System.Windows.Forms.Label();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMistakes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.lblSecretNumberLabel = new System.Windows.Forms.Label();
            this.lblSecretNumber = new System.Windows.Forms.Label();
            this.lblRangeLabel = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStart.Location = new System.Drawing.Point(15, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(254, 55);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPlayerCountLabel
            // 
            this.lblPlayerCountLabel.AutoSize = true;
            this.lblPlayerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPlayerCountLabel.Location = new System.Drawing.Point(292, 28);
            this.lblPlayerCountLabel.Name = "lblPlayerCountLabel";
            this.lblPlayerCountLabel.Size = new System.Drawing.Size(226, 29);
            this.lblPlayerCountLabel.TabIndex = 1;
            this.lblPlayerCountLabel.Text = "Số người đang chơi:";
            // 
            // lblPlayerCount
            // 
            this.lblPlayerCount.AutoSize = true;
            this.lblPlayerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPlayerCount.Location = new System.Drawing.Point(524, 28);
            this.lblPlayerCount.Name = "lblPlayerCount";
            this.lblPlayerCount.Size = new System.Drawing.Size(26, 29);
            this.lblPlayerCount.TabIndex = 2;
            this.lblPlayerCount.Text = "0";
            // 
            // lblRoundLabel
            // 
            this.lblRoundLabel.AutoSize = true;
            this.lblRoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRoundLabel.Location = new System.Drawing.Point(571, 28);
            this.lblRoundLabel.Name = "lblRoundLabel";
            this.lblRoundLabel.Size = new System.Drawing.Size(116, 29);
            this.lblRoundLabel.TabIndex = 3;
            this.lblRoundLabel.Text = "Lượt chơi:";
            // 
            // lblCurrentRound
            // 
            this.lblCurrentRound.AutoSize = true;
            this.lblCurrentRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCurrentRound.Location = new System.Drawing.Point(693, 28);
            this.lblCurrentRound.Name = "lblCurrentRound";
            this.lblCurrentRound.Size = new System.Drawing.Size(26, 29);
            this.lblCurrentRound.TabIndex = 4;
            this.lblCurrentRound.Text = "0";
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colPoints,
            this.colMistakes});
            this.dgvPlayers.Location = new System.Drawing.Point(15, 94);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.RowHeadersWidth = 100;
            this.dgvPlayers.RowTemplate.Height = 100;
            this.dgvPlayers.Size = new System.Drawing.Size(1174, 242);
            this.dgvPlayers.TabIndex = 5;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên người chơi";
            this.colName.MinimumWidth = 100;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 400;
            // 
            // colPoints
            // 
            this.colPoints.HeaderText = "Điểm";
            this.colPoints.MinimumWidth = 8;
            this.colPoints.Name = "colPoints";
            this.colPoints.ReadOnly = true;
            this.colPoints.Width = 400;
            // 
            // colMistakes
            // 
            this.colMistakes.HeaderText = "Lượt đoán sai";
            this.colMistakes.MinimumWidth = 8;
            this.colMistakes.Name = "colMistakes";
            this.colMistakes.ReadOnly = true;
            this.colMistakes.Width = 370;
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(15, 356);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(1174, 444);
            this.rtbLog.TabIndex = 6;
            this.rtbLog.Text = "";
            // 
            // lblSecretNumberLabel
            // 
            this.lblSecretNumberLabel.AutoSize = true;
            this.lblSecretNumberLabel.Location = new System.Drawing.Point(742, 28);
            this.lblSecretNumberLabel.Name = "lblSecretNumberLabel";
            this.lblSecretNumberLabel.Size = new System.Drawing.Size(131, 29);
            this.lblSecretNumberLabel.TabIndex = 7;
            this.lblSecretNumberLabel.Text = "Số cần tìm:";
            // 
            // lblSecretNumber
            // 
            this.lblSecretNumber.AutoSize = true;
            this.lblSecretNumber.Location = new System.Drawing.Point(879, 28);
            this.lblSecretNumber.Name = "lblSecretNumber";
            this.lblSecretNumber.Size = new System.Drawing.Size(21, 29);
            this.lblSecretNumber.TabIndex = 8;
            this.lblSecretNumber.Text = "-";
            // 
            // lblRangeLabel
            // 
            this.lblRangeLabel.AutoSize = true;
            this.lblRangeLabel.Location = new System.Drawing.Point(917, 28);
            this.lblRangeLabel.Name = "lblRangeLabel";
            this.lblRangeLabel.Size = new System.Drawing.Size(136, 29);
            this.lblRangeLabel.TabIndex = 9;
            this.lblRangeLabel.Text = "Phạm vi số:";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(1059, 28);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(21, 29);
            this.lblRange.TabIndex = 10;
            this.lblRange.Text = "-";
            // 
            // Server
            // 
            this.ClientSize = new System.Drawing.Size(1210, 812);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.lblCurrentRound);
            this.Controls.Add(this.lblRoundLabel);
            this.Controls.Add(this.lblPlayerCount);
            this.Controls.Add(this.lblPlayerCountLabel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblSecretNumberLabel);
            this.Controls.Add(this.lblSecretNumber);
            this.Controls.Add(this.lblRangeLabel);
            this.Controls.Add(this.lblRange);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "Server";
            this.Text = "Guess Number Game Server";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}