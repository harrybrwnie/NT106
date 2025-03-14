namespace Lab_1
{
    partial class Lab1_bai4
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
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập thông tin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 88);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập một số: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(428, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 121);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Chọn: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Decimal", "Binary", "Hexadecimal" });
            comboBox1.Location = new Point(147, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Decimal", "Binary", "Hexadecimal" });
            comboBox2.Location = new Point(426, 113);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(149, 23);
            comboBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 116);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 6;
            label4.Text = "Sang";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlText;
            button2.ForeColor = Color.Snow;
            button2.Location = new Point(147, 159);
            button2.Name = "button2";
            button2.Size = new Size(428, 29);
            button2.TabIndex = 8;
            button2.Text = "Thực hiện";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 215);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 9;
            label5.Text = "Kết quả";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 215);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(428, 23);
            textBox2.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(147, 278);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(426, 278);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Lab1_bai4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab1_bai4";
            Text = "Lab1_bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label4;
        private Button button2;
        private Label label5;
        private TextBox textBox2;
        private Button button1;
        private Button button3;
    }
}