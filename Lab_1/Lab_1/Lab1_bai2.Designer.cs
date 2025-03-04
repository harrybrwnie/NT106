namespace Lab_1
{
    partial class Lab1_bai2
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
            label2 = new Label();
            label3 = new Label();
            iNum1 = new TextBox();
            iNum2 = new TextBox();
            iNum3 = new TextBox();
            label4 = new Label();
            iMax = new TextBox();
            label5 = new Label();
            iMin = new TextBox();
            bThoat = new Button();
            bXoa = new Button();
            bTim = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 104);
            label1.Name = "label1";
            label1.Size = new Size(111, 36);
            label1.TabIndex = 0;
            label1.Text = "Số thứ 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 202);
            label2.Name = "label2";
            label2.Size = new Size(111, 36);
            label2.TabIndex = 1;
            label2.Text = "Số thứ 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 296);
            label3.Name = "label3";
            label3.Size = new Size(111, 36);
            label3.TabIndex = 2;
            label3.Text = "Số thứ 3";
            // 
            // iNum1
            // 
            iNum1.Location = new Point(220, 104);
            iNum1.Name = "iNum1";
            iNum1.Size = new Size(200, 42);
            iNum1.TabIndex = 3;
            // 
            // iNum2
            // 
            iNum2.Location = new Point(220, 199);
            iNum2.Name = "iNum2";
            iNum2.Size = new Size(200, 42);
            iNum2.TabIndex = 4;
            // 
            // iNum3
            // 
            iNum3.Location = new Point(220, 296);
            iNum3.Name = "iNum3";
            iNum3.Size = new Size(200, 42);
            iNum3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 382);
            label4.Name = "label4";
            label4.Size = new Size(147, 36);
            label4.TabIndex = 6;
            label4.Text = "Số lớn nhất";
            // 
            // iMax
            // 
            iMax.Location = new Point(220, 382);
            iMax.Name = "iMax";
            iMax.ReadOnly = true;
            iMax.Size = new Size(154, 42);
            iMax.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 385);
            label5.Name = "label5";
            label5.Size = new Size(155, 36);
            label5.TabIndex = 8;
            label5.Text = "Số nhỏ nhất";
            // 
            // iMin
            // 
            iMin.Location = new Point(588, 382);
            iMin.Name = "iMin";
            iMin.ReadOnly = true;
            iMin.Size = new Size(161, 42);
            iMin.TabIndex = 9;
            // 
            // bThoat
            // 
            bThoat.Location = new Point(568, 104);
            bThoat.Name = "bThoat";
            bThoat.Size = new Size(150, 46);
            bThoat.TabIndex = 10;
            bThoat.Text = "Thoát";
            bThoat.UseVisualStyleBackColor = true;
            bThoat.Click += bThoat_Click;
            // 
            // bXoa
            // 
            bXoa.Location = new Point(568, 202);
            bXoa.Name = "bXoa";
            bXoa.Size = new Size(150, 46);
            bXoa.TabIndex = 11;
            bXoa.Text = "Xóa";
            bXoa.UseVisualStyleBackColor = true;
            bXoa.Click += bXoa_Click;
            // 
            // bTim
            // 
            bTim.Location = new Point(568, 296);
            bTim.Name = "bTim";
            bTim.Size = new Size(150, 46);
            bTim.TabIndex = 12;
            bTim.Text = "Tìm";
            bTim.UseVisualStyleBackColor = true;
            bTim.Click += bTim_Click;
            // 
            // Lab1_bai2
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bTim);
            Controls.Add(bXoa);
            Controls.Add(bThoat);
            Controls.Add(iMin);
            Controls.Add(label5);
            Controls.Add(iMax);
            Controls.Add(label4);
            Controls.Add(iNum3);
            Controls.Add(iNum2);
            Controls.Add(iNum1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab1_bai2";
            Text = "Lab1_bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox iNum1;
        private TextBox iNum2;
        private TextBox iNum3;
        private Label label4;
        private TextBox iMax;
        private Label label5;
        private TextBox iMin;
        private Button bThoat;
        private Button bXoa;
        private Button bTim;
    }
}