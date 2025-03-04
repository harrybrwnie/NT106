namespace Lab_1
{
    partial class Lab1_bai3
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
            label1 = new Label();
            strNum = new TextBox();
            label2 = new Label();
            strKQ = new TextBox();
            bThoat = new Button();
            bXoa = new Button();
            bDoc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 81);
            label1.Name = "label1";
            label1.Size = new Size(204, 36);
            label1.TabIndex = 0;
            label1.Text = "Nhập số nguyên";
            // 
            // strNum
            // 
            strNum.Location = new Point(387, 81);
            strNum.Name = "strNum";
            strNum.Size = new Size(200, 42);
            strNum.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 263);
            label2.Name = "label2";
            label2.Size = new Size(103, 36);
            label2.TabIndex = 2;
            label2.Text = "Kết quả";
            // 
            // strKQ
            // 
            strKQ.Location = new Point(72, 342);
            strKQ.Name = "strKQ";
            strKQ.ReadOnly = true;
            strKQ.Size = new Size(515, 42);
            strKQ.TabIndex = 3;
            // 
            // bThoat
            // 
            bThoat.Location = new Point(638, 81);
            bThoat.Name = "bThoat";
            bThoat.Size = new Size(150, 46);
            bThoat.TabIndex = 4;
            bThoat.Text = "Thoát";
            bThoat.UseVisualStyleBackColor = true;
            bThoat.Click += bThoat_Click;
            // 
            // bXoa
            // 
            bXoa.Location = new Point(638, 203);
            bXoa.Name = "bXoa";
            bXoa.Size = new Size(150, 46);
            bXoa.TabIndex = 5;
            bXoa.Text = "Xóa";
            bXoa.UseVisualStyleBackColor = true;
            bXoa.Click += bXoa_Click;
            // 
            // bDoc
            // 
            bDoc.Location = new Point(638, 338);
            bDoc.Name = "bDoc";
            bDoc.Size = new Size(150, 46);
            bDoc.TabIndex = 6;
            bDoc.Text = "Đọc";
            bDoc.UseVisualStyleBackColor = true;
            bDoc.Click += bDoc_Click;
            // 
            // Lab1_bai3
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bDoc);
            Controls.Add(bXoa);
            Controls.Add(bThoat);
            Controls.Add(strKQ);
            Controls.Add(label2);
            Controls.Add(strNum);
            Controls.Add(label1);
            Name = "Lab1_bai3";
            Text = "Lab1_bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox strNum;
        private Label label2;
        private TextBox strKQ;
        private Button bThoat;
        private Button bXoa;
        private Button bDoc;
    }
}