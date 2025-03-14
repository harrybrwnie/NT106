namespace Lab_1
{
    partial class Lab1_bai1
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
            iNum1 = new TextBox();
            label3 = new Label();
            iNum2 = new TextBox();
            label4 = new Label();
            iSum = new TextBox();
            bTinh = new Button();
            bXoa = new Button();
            bThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Tổng 2 số nguyên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 52);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Số thứ 1";
            // 
            // iNum1
            // 
            iNum1.Location = new Point(132, 52);
            iNum1.Margin = new Padding(2, 1, 2, 1);
            iNum1.Name = "iNum1";
            iNum1.Size = new Size(102, 23);
            iNum1.TabIndex = 2;
            iNum1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 85);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Số thứ 2";
            // 
            // iNum2
            // 
            iNum2.Location = new Point(132, 85);
            iNum2.Margin = new Padding(2, 1, 2, 1);
            iNum2.Name = "iNum2";
            iNum2.Size = new Size(102, 23);
            iNum2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 118);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 5;
            label4.Text = "Tổng";
            // 
            // iSum
            // 
            iSum.Location = new Point(132, 117);
            iSum.Margin = new Padding(2, 1, 2, 1);
            iSum.Name = "iSum";
            iSum.ReadOnly = true;
            iSum.Size = new Size(102, 23);
            iSum.TabIndex = 6;
            // 
            // bTinh
            // 
            bTinh.Location = new Point(296, 151);
            bTinh.Margin = new Padding(2, 1, 2, 1);
            bTinh.Name = "bTinh";
            bTinh.Size = new Size(75, 27);
            bTinh.TabIndex = 7;
            bTinh.Text = "Tính";
            bTinh.UseVisualStyleBackColor = true;
            bTinh.Click += bTinh_Click;
            // 
            // bXoa
            // 
            bXoa.Location = new Point(162, 151);
            bXoa.Margin = new Padding(2, 1, 2, 1);
            bXoa.Name = "bXoa";
            bXoa.Size = new Size(75, 27);
            bXoa.TabIndex = 8;
            bXoa.Text = "Xóa";
            bXoa.UseVisualStyleBackColor = true;
            bXoa.Click += bXoa_Click;
            // 
            // bThoat
            // 
            bThoat.Location = new Point(27, 151);
            bThoat.Margin = new Padding(2, 1, 2, 1);
            bThoat.Name = "bThoat";
            bThoat.Size = new Size(75, 27);
            bThoat.TabIndex = 9;
            bThoat.Text = "Thoát";
            bThoat.UseVisualStyleBackColor = true;
            bThoat.Click += bThoat_Click;
            // 
            // Lab1_bai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 188);
            Controls.Add(bThoat);
            Controls.Add(bXoa);
            Controls.Add(bTinh);
            Controls.Add(iSum);
            Controls.Add(label4);
            Controls.Add(iNum2);
            Controls.Add(label3);
            Controls.Add(iNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Lab1_bai1";
            Text = "bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox iNum1;
        private Label label3;
        private TextBox iNum2;
        private Label label4;
        private TextBox iSum;
        private Button bTinh;
        private Button bXoa;
        private Button bThoat;
    }
}