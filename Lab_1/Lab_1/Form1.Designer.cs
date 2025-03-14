namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bBai1 = new Button();
            bBai2 = new Button();
            bBai3 = new Button();
            bBai4 = new Button();
            bBai5 = new Button();
            SuspendLayout();
            // 
            // bBai1
            // 
            bBai1.Location = new Point(68, 101);
            bBai1.Margin = new Padding(4, 2, 4, 2);
            bBai1.Name = "bBai1";
            bBai1.Size = new Size(150, 74);
            bBai1.TabIndex = 0;
            bBai1.Text = "Bai 1";
            bBai1.UseVisualStyleBackColor = true;
            bBai1.Click += button1_Click;
            // 
            // bBai2
            // 
            bBai2.Location = new Point(440, 101);
            bBai2.Margin = new Padding(4, 2, 4, 2);
            bBai2.Name = "bBai2";
            bBai2.Size = new Size(150, 74);
            bBai2.TabIndex = 1;
            bBai2.Text = "Bài 2";
            bBai2.UseVisualStyleBackColor = true;
            bBai2.Click += button2_Click;
            // 
            // bBai3
            // 
            bBai3.Location = new Point(68, 209);
            bBai3.Margin = new Padding(4, 2, 4, 2);
            bBai3.Name = "bBai3";
            bBai3.Size = new Size(150, 65);
            bBai3.TabIndex = 2;
            bBai3.Text = "Bài 3";
            bBai3.UseVisualStyleBackColor = true;
            bBai3.Click += bBai3_Click;
            // 
            // bBai4
            // 
            bBai4.Location = new Point(440, 209);
            bBai4.Margin = new Padding(4, 2, 4, 2);
            bBai4.Name = "bBai4";
            bBai4.Size = new Size(150, 65);
            bBai4.TabIndex = 3;
            bBai4.Text = "Bài 4";
            bBai4.UseVisualStyleBackColor = true;
            bBai4.Click += bBai4_Click;
            // 
            // bBai5
            // 
            bBai5.Location = new Point(68, 326);
            bBai5.Name = "bBai5";
            bBai5.Size = new Size(150, 46);
            bBai5.TabIndex = 4;
            bBai5.Text = "Bài 5";
            bBai5.UseVisualStyleBackColor = true;
            bBai5.Click += bBai5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(bBai5);
            Controls.Add(bBai4);
            Controls.Add(bBai3);
            Controls.Add(bBai2);
            Controls.Add(bBai1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Lab_1";
            ResumeLayout(false);
        }

        #endregion

        private Button bBai1;
        private Button bBai2;
        private Button bBai3;
        private Button bBai4;
        private Button bBai5;
    }
}
