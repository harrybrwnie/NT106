namespace Lab_2
{
    partial class Bai1
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
            this.bRead = new System.Windows.Forms.Button();
            this.bWrite = new System.Windows.Forms.Button();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bRead
            // 
            this.bRead.Location = new System.Drawing.Point(73, 122);
            this.bRead.Name = "bRead";
            this.bRead.Size = new System.Drawing.Size(152, 69);
            this.bRead.TabIndex = 0;
            this.bRead.Text = "Đọc File";
            this.bRead.UseVisualStyleBackColor = true;
            this.bRead.Click += new System.EventHandler(this.bRead_Click);
            // 
            // bWrite
            // 
            this.bWrite.Location = new System.Drawing.Point(73, 262);
            this.bWrite.Name = "bWrite";
            this.bWrite.Size = new System.Drawing.Size(152, 69);
            this.bWrite.TabIndex = 1;
            this.bWrite.Text = "Ghi File";
            this.bWrite.UseVisualStyleBackColor = true;
            this.bWrite.Click += new System.EventHandler(this.bWrite_Click);
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(344, 68);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(374, 321);
            this.rtbContent.TabIndex = 2;
            this.rtbContent.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.bWrite);
            this.Controls.Add(this.bRead);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bRead;
        private System.Windows.Forms.Button bWrite;
        private System.Windows.Forms.RichTextBox rtbContent;
    }
}