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
            SuspendLayout();
            // 
            // bBai1
            // 
            bBai1.Location = new Point(69, 101);
            bBai1.Name = "bBai1";
            bBai1.Size = new Size(150, 46);
            bBai1.TabIndex = 0;
            bBai1.Text = "Bai 1";
            bBai1.UseVisualStyleBackColor = true;
            bBai1.Click += button1_Click;
            // 
            // bBai2
            // 
            bBai2.Location = new Point(441, 101);
            bBai2.Name = "bBai2";
            bBai2.Size = new Size(150, 46);
            bBai2.TabIndex = 1;
            bBai2.Text = "Bài 2";
            bBai2.UseVisualStyleBackColor = true;
            bBai2.Click += button2_Click;
            // 
            // bBai3
            // 
            bBai3.Location = new Point(69, 209);
            bBai3.Name = "bBai3";
            bBai3.Size = new Size(150, 46);
            bBai3.TabIndex = 2;
            bBai3.Text = "Bài 3";
            bBai3.UseVisualStyleBackColor = true;
            bBai3.Click += bBai3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bBai3);
            Controls.Add(bBai2);
            Controls.Add(bBai1);
            Name = "Form1";
            Text = "Lab_1";
            ResumeLayout(false);
        }

        #endregion

        private Button bBai1;
        private Button bBai2;
        private Button bBai3;
    }
}
