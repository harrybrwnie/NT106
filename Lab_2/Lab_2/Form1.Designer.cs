namespace Lab_2
{
    partial class Form1
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
            this.bBai1 = new System.Windows.Forms.Button();
            this.bBai2 = new System.Windows.Forms.Button();
            this.bBai3 = new System.Windows.Forms.Button();
            this.bBai4 = new System.Windows.Forms.Button();
            this.bBai5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bBai1
            // 
            this.bBai1.Location = new System.Drawing.Point(98, 80);
            this.bBai1.Name = "bBai1";
            this.bBai1.Size = new System.Drawing.Size(121, 70);
            this.bBai1.TabIndex = 0;
            this.bBai1.Text = "Bài 1";
            this.bBai1.UseVisualStyleBackColor = true;
            this.bBai1.Click += new System.EventHandler(this.bBai1_Click);
            // 
            // bBai2
            // 
            this.bBai2.Location = new System.Drawing.Point(369, 80);
            this.bBai2.Name = "bBai2";
            this.bBai2.Size = new System.Drawing.Size(121, 70);
            this.bBai2.TabIndex = 1;
            this.bBai2.Text = "Bài 2";
            this.bBai2.UseVisualStyleBackColor = true;
            // 
            // bBai3
            // 
            this.bBai3.Location = new System.Drawing.Point(98, 213);
            this.bBai3.Name = "bBai3";
            this.bBai3.Size = new System.Drawing.Size(121, 70);
            this.bBai3.TabIndex = 2;
            this.bBai3.Text = "Bài 3";
            this.bBai3.UseVisualStyleBackColor = true;
            // 
            // bBai4
            // 
            this.bBai4.Location = new System.Drawing.Point(357, 213);
            this.bBai4.Name = "bBai4";
            this.bBai4.Size = new System.Drawing.Size(121, 70);
            this.bBai4.TabIndex = 3;
            this.bBai4.Text = "Bài 4";
            this.bBai4.UseVisualStyleBackColor = true;
            // 
            // bBai5
            // 
            this.bBai5.Location = new System.Drawing.Point(98, 346);
            this.bBai5.Name = "bBai5";
            this.bBai5.Size = new System.Drawing.Size(121, 70);
            this.bBai5.TabIndex = 4;
            this.bBai5.Text = "Bài 5";
            this.bBai5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bBai5);
            this.Controls.Add(this.bBai4);
            this.Controls.Add(this.bBai3);
            this.Controls.Add(this.bBai2);
            this.Controls.Add(this.bBai1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBai1;
        private System.Windows.Forms.Button bBai2;
        private System.Windows.Forms.Button bBai3;
        private System.Windows.Forms.Button bBai4;
        private System.Windows.Forms.Button bBai5;
    }
}

