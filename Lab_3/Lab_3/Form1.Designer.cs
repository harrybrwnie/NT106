namespace Lab_3
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
            btBai1 = new Button();
            btBai3 = new Button();
            btBai2 = new Button();
            btBai4 = new Button();
            SuspendLayout();
            // 
            // btBai1
            // 
            btBai1.Location = new Point(345, 205);
            btBai1.Name = "btBai1";
            btBai1.Size = new Size(217, 117);
            btBai1.TabIndex = 0;
            btBai1.Text = "Bài 1";
            btBai1.UseVisualStyleBackColor = true;
            btBai1.Click += btBai1_Click;
            // 
            // btBai3
            // 
            btBai3.Location = new Point(345, 456);
            btBai3.Name = "btBai3";
            btBai3.Size = new Size(217, 117);
            btBai3.TabIndex = 1;
            btBai3.Text = "Bài 3";
            btBai3.UseVisualStyleBackColor = true;
            btBai3.Click += btBai3_Click;
            // 
            // btBai2
            // 
            btBai2.Location = new Point(774, 205);
            btBai2.Name = "btBai2";
            btBai2.Size = new Size(217, 117);
            btBai2.TabIndex = 2;
            btBai2.Text = "Bài 2";
            btBai2.UseVisualStyleBackColor = true;
            btBai2.Click += btBai2_Click;
            // 
            // btBai4
            // 
            btBai4.Location = new Point(774, 456);
            btBai4.Name = "btBai4";
            btBai4.Size = new Size(217, 117);
            btBai4.TabIndex = 3;
            btBai4.Text = "Bài 4";
            btBai4.UseVisualStyleBackColor = true;
            btBai4.Click += btBai4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 788);
            Controls.Add(btBai4);
            Controls.Add(btBai2);
            Controls.Add(btBai3);
            Controls.Add(btBai1);
            Name = "Form1";
            Text = "Lab 3";
            ResumeLayout(false);
        }

        #endregion

        private Button btBai1;
        private Button btBai3;
        private Button btBai2;
        private Button btBai4;
    }
}
