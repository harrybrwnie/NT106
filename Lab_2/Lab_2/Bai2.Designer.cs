namespace Lab_2
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tenFile = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.lineCount = new System.Windows.Forms.TextBox();
            this.wordCount = new System.Windows.Forms.TextBox();
            this.charCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readFile
            // 
            this.readFile.Location = new System.Drawing.Point(43, 27);
            this.readFile.Name = "readFile";
            this.readFile.Size = new System.Drawing.Size(168, 76);
            this.readFile.TabIndex = 0;
            this.readFile.Text = "Đọc File";
            this.readFile.UseVisualStyleBackColor = true;
            this.readFile.Click += new System.EventHandler(this.readFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số dòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số ký tự";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(384, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(404, 411);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // tenFile
            // 
            this.tenFile.Location = new System.Drawing.Point(114, 163);
            this.tenFile.Name = "tenFile";
            this.tenFile.ReadOnly = true;
            this.tenFile.Size = new System.Drawing.Size(239, 20);
            this.tenFile.TabIndex = 7;
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(114, 201);
            this.url.Name = "url";
            this.url.ReadOnly = true;
            this.url.Size = new System.Drawing.Size(239, 20);
            this.url.TabIndex = 8;
            // 
            // lineCount
            // 
            this.lineCount.Location = new System.Drawing.Point(114, 236);
            this.lineCount.Name = "lineCount";
            this.lineCount.ReadOnly = true;
            this.lineCount.Size = new System.Drawing.Size(239, 20);
            this.lineCount.TabIndex = 9;
            // 
            // wordCount
            // 
            this.wordCount.Location = new System.Drawing.Point(114, 272);
            this.wordCount.Name = "wordCount";
            this.wordCount.ReadOnly = true;
            this.wordCount.Size = new System.Drawing.Size(239, 20);
            this.wordCount.TabIndex = 10;
            // 
            // charCount
            // 
            this.charCount.Location = new System.Drawing.Point(114, 306);
            this.charCount.Name = "charCount";
            this.charCount.ReadOnly = true;
            this.charCount.Size = new System.Drawing.Size(239, 20);
            this.charCount.TabIndex = 11;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.charCount);
            this.Controls.Add(this.wordCount);
            this.Controls.Add(this.lineCount);
            this.Controls.Add(this.url);
            this.Controls.Add(this.tenFile);
            this.Controls.Add(this.richTextBox1);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tenFile;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox lineCount;
        private System.Windows.Forms.TextBox wordCount;
        private System.Windows.Forms.TextBox charCount;
    }
}