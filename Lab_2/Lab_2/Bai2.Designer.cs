﻿namespace Lab_2
{
    partial class Bai2
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
            this.readFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.lineCount = new System.Windows.Forms.TextBox();
            this.wordCount = new System.Windows.Forms.TextBox();
            this.charCount = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // readFile
            // 
            this.readFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readFile.Location = new System.Drawing.Point(52, 12);
            this.readFile.Name = "readFile";
            this.readFile.Size = new System.Drawing.Size(172, 49);
            this.readFile.TabIndex = 0;
            this.readFile.Text = "Đọc file";
            this.readFile.UseVisualStyleBackColor = true;
            this.readFile.Click += new System.EventHandler(this.readFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số dòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số ký tự";
            // 
            // fileName
            // 
            this.fileName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileName.Location = new System.Drawing.Point(124, 82);
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Size = new System.Drawing.Size(179, 20);
            this.fileName.TabIndex = 6;
            // 
            // url
            // 
            this.url.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.url.Location = new System.Drawing.Point(124, 121);
            this.url.Name = "url";
            this.url.ReadOnly = true;
            this.url.Size = new System.Drawing.Size(179, 20);
            this.url.TabIndex = 7;
            // 
            // lineCount
            // 
            this.lineCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineCount.Location = new System.Drawing.Point(124, 155);
            this.lineCount.Name = "lineCount";
            this.lineCount.ReadOnly = true;
            this.lineCount.Size = new System.Drawing.Size(179, 20);
            this.lineCount.TabIndex = 8;
            // 
            // wordCount
            // 
            this.wordCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.wordCount.Location = new System.Drawing.Point(124, 189);
            this.wordCount.Name = "wordCount";
            this.wordCount.ReadOnly = true;
            this.wordCount.Size = new System.Drawing.Size(179, 20);
            this.wordCount.TabIndex = 9;
            // 
            // charCount
            // 
            this.charCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.charCount.Location = new System.Drawing.Point(124, 228);
            this.charCount.Name = "charCount";
            this.charCount.ReadOnly = true;
            this.charCount.Size = new System.Drawing.Size(179, 20);
            this.charCount.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Location = new System.Drawing.Point(320, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(468, 426);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.charCount);
            this.Controls.Add(this.wordCount);
            this.Controls.Add(this.lineCount);
            this.Controls.Add(this.url);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readFile);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox lineCount;
        private System.Windows.Forms.TextBox wordCount;
        private System.Windows.Forms.TextBox charCount;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}