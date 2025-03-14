namespace Lab_1
{
    partial class Lab1_bai5
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
            lblPhanMemQuanLyDiem = new Label();
            lblDanhSachDiem = new Label();
            tbInput = new TextBox();
            bXuat = new Button();
            lblSoMonFail = new Label();
            tbDiemTB = new TextBox();
            tbDiemCaoNhat = new TextBox();
            tbSoMonPass = new TextBox();
            tbXepLoai = new TextBox();
            tbDiemThapNhat = new TextBox();
            tbSoMonFail = new TextBox();
            lbldiemtb = new Label();
            lbldiemcaonhat = new Label();
            lblsomondau = new Label();
            lblxeploai = new Label();
            lblthapnhat = new Label();
            gbDiem = new GroupBox();
            label3 = new Label();
            tbDisplay = new TextBox();
            gbDiem.SuspendLayout();
            SuspendLayout();
            // 
            // lblPhanMemQuanLyDiem
            // 
            lblPhanMemQuanLyDiem.AutoSize = true;
            lblPhanMemQuanLyDiem.Location = new Point(383, 21);
            lblPhanMemQuanLyDiem.Name = "lblPhanMemQuanLyDiem";
            lblPhanMemQuanLyDiem.Size = new Size(293, 36);
            lblPhanMemQuanLyDiem.TabIndex = 0;
            lblPhanMemQuanLyDiem.Text = "Phần mềm quản lý điểm";
            lblPhanMemQuanLyDiem.Click += label1_Click;
            // 
            // lblDanhSachDiem
            // 
            lblDanhSachDiem.AutoSize = true;
            lblDanhSachDiem.Location = new Point(25, 119);
            lblDanhSachDiem.Name = "lblDanhSachDiem";
            lblDanhSachDiem.Size = new Size(198, 36);
            lblDanhSachDiem.TabIndex = 1;
            lblDanhSachDiem.Text = "Danh sách điểm";
            // 
            // tbInput
            // 
            tbInput.Location = new Point(276, 116);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(494, 42);
            tbInput.TabIndex = 2;
            // 
            // bXuat
            // 
            bXuat.Location = new Point(858, 114);
            bXuat.Name = "bXuat";
            bXuat.Size = new Size(150, 46);
            bXuat.TabIndex = 3;
            bXuat.Text = "Xuất";
            bXuat.UseVisualStyleBackColor = true;
            bXuat.Click += bXuat_Click;
            // 
            // lblSoMonFail
            // 
            lblSoMonFail.AutoSize = true;
            lblSoMonFail.Location = new Point(732, 694);
            lblSoMonFail.Name = "lblSoMonFail";
            lblSoMonFail.Size = new Size(233, 36);
            lblSoMonFail.TabIndex = 9;
            lblSoMonFail.Text = "Số môn không đậu";
            // 
            // tbDiemTB
            // 
            tbDiemTB.Location = new Point(383, 517);
            tbDiemTB.Name = "tbDiemTB";
            tbDiemTB.ReadOnly = true;
            tbDiemTB.Size = new Size(200, 42);
            tbDiemTB.TabIndex = 10;
            // 
            // tbDiemCaoNhat
            // 
            tbDiemCaoNhat.Location = new Point(383, 613);
            tbDiemCaoNhat.Name = "tbDiemCaoNhat";
            tbDiemCaoNhat.ReadOnly = true;
            tbDiemCaoNhat.Size = new Size(200, 42);
            tbDiemCaoNhat.TabIndex = 11;
            // 
            // tbSoMonPass
            // 
            tbSoMonPass.Location = new Point(383, 694);
            tbSoMonPass.Name = "tbSoMonPass";
            tbSoMonPass.ReadOnly = true;
            tbSoMonPass.Size = new Size(200, 42);
            tbSoMonPass.TabIndex = 12;
            // 
            // tbXepLoai
            // 
            tbXepLoai.Location = new Point(1003, 494);
            tbXepLoai.Name = "tbXepLoai";
            tbXepLoai.ReadOnly = true;
            tbXepLoai.Size = new Size(200, 42);
            tbXepLoai.TabIndex = 13;
            // 
            // tbDiemThapNhat
            // 
            tbDiemThapNhat.Location = new Point(1027, 574);
            tbDiemThapNhat.Name = "tbDiemThapNhat";
            tbDiemThapNhat.ReadOnly = true;
            tbDiemThapNhat.Size = new Size(200, 42);
            tbDiemThapNhat.TabIndex = 14;
            // 
            // tbSoMonFail
            // 
            tbSoMonFail.Location = new Point(1059, 697);
            tbSoMonFail.Name = "tbSoMonFail";
            tbSoMonFail.ReadOnly = true;
            tbSoMonFail.Size = new Size(200, 42);
            tbSoMonFail.TabIndex = 15;
            // 
            // lbldiemtb
            // 
            lbldiemtb.AutoSize = true;
            lbldiemtb.Location = new Point(84, 523);
            lbldiemtb.Name = "lbldiemtb";
            lbldiemtb.Size = new Size(206, 36);
            lbldiemtb.TabIndex = 16;
            lbldiemtb.Text = "Điểm Trung Bình";
            // 
            // lbldiemcaonhat
            // 
            lbldiemcaonhat.AutoSize = true;
            lbldiemcaonhat.Location = new Point(109, 623);
            lbldiemcaonhat.Name = "lbldiemcaonhat";
            lbldiemcaonhat.Size = new Size(272, 36);
            lbldiemcaonhat.TabIndex = 17;
            lbldiemcaonhat.Text = "Môn có điểm cao nhất";
            // 
            // lblsomondau
            // 
            lblsomondau.AutoSize = true;
            lblsomondau.Location = new Point(88, 708);
            lblsomondau.Name = "lblsomondau";
            lblsomondau.Size = new Size(153, 36);
            lblsomondau.TabIndex = 18;
            lblsomondau.Text = "Số môn đậu";
            // 
            // lblxeploai
            // 
            lblxeploai.AutoSize = true;
            lblxeploai.Location = new Point(734, 508);
            lblxeploai.Name = "lblxeploai";
            lblxeploai.Size = new Size(195, 36);
            lblxeploai.TabIndex = 19;
            lblxeploai.Text = "Xếp loại học lực";
            // 
            // lblthapnhat
            // 
            lblthapnhat.AutoSize = true;
            lblthapnhat.Location = new Point(747, 603);
            lblthapnhat.Name = "lblthapnhat";
            lblthapnhat.Size = new Size(284, 36);
            lblthapnhat.TabIndex = 20;
            lblthapnhat.Text = "Môn có điểm thấp nhất";
            // 
            // gbDiem
            // 
            gbDiem.Controls.Add(tbDisplay);
            gbDiem.Controls.Add(label3);
            gbDiem.Location = new Point(62, 209);
            gbDiem.Name = "gbDiem";
            gbDiem.Size = new Size(1197, 279);
            gbDiem.TabIndex = 21;
            gbDiem.TabStop = false;
            gbDiem.Text = "Danh sách điểm các môn học";
            gbDiem.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 64);
            label3.Name = "label3";
            label3.Size = new Size(0, 36);
            label3.TabIndex = 0;
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(47, 61);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.ReadOnly = true;
            tbDisplay.Size = new Size(1118, 191);
            tbDisplay.TabIndex = 1;
            // 
            // Lab1_bai5
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 825);
            Controls.Add(gbDiem);
            Controls.Add(lblthapnhat);
            Controls.Add(lblxeploai);
            Controls.Add(lblsomondau);
            Controls.Add(lbldiemcaonhat);
            Controls.Add(lbldiemtb);
            Controls.Add(tbSoMonFail);
            Controls.Add(tbDiemThapNhat);
            Controls.Add(tbXepLoai);
            Controls.Add(tbSoMonPass);
            Controls.Add(tbDiemCaoNhat);
            Controls.Add(tbDiemTB);
            Controls.Add(lblSoMonFail);
            Controls.Add(bXuat);
            Controls.Add(tbInput);
            Controls.Add(lblDanhSachDiem);
            Controls.Add(lblPhanMemQuanLyDiem);
            Name = "Lab1_bai5";
            Text = "Lab1_bai5";
            Load += Lab1_bai5_Load;
            gbDiem.ResumeLayout(false);
            gbDiem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhanMemQuanLyDiem;
        private Label lblDanhSachDiem;
        private TextBox tbInput;
        private Button bXuat;
        private Label lblDiemTB;
        private Label lblSoMonPass;
        private Label lblSoMonFail;
        private TextBox tbDiemTB;
        private TextBox tbDiemCaoNhat;
        private TextBox tbSoMonPass;
        private TextBox tbXepLoai;
        private TextBox tbDiemThapNhat;
        private TextBox tbSoMonFail;
        private Label lbldiemtb;
        private Label lbldiemcaonhat;
        private Label lblsomondau;
        private Label lblxeploai;
        private Label lblthapnhat;
        private GroupBox gbDiem;
        private Label label3;
        private TextBox tbDisplay;
    }
}