namespace Lab_4
{
    partial class Bai3
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
            this.urltxtBox = new System.Windows.Forms.TextBox();
            this.filePathtxtBox = new System.Windows.Forms.TextBox();
            this.Downloadbtn = new System.Windows.Forms.Button();
            this.responserichtxtBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // urltxtBox
            // 
            this.urltxtBox.Location = new System.Drawing.Point(12, 12);
            this.urltxtBox.Name = "urltxtBox";
            this.urltxtBox.Size = new System.Drawing.Size(475, 20);
            this.urltxtBox.TabIndex = 0;
            // 
            // filePathtxtBox
            // 
            this.filePathtxtBox.Location = new System.Drawing.Point(13, 39);
            this.filePathtxtBox.Name = "filePathtxtBox";
            this.filePathtxtBox.Size = new System.Drawing.Size(474, 20);
            this.filePathtxtBox.TabIndex = 1;
            // 
            // Downloadbtn
            // 
            this.Downloadbtn.Location = new System.Drawing.Point(493, 12);
            this.Downloadbtn.Name = "Downloadbtn";
            this.Downloadbtn.Size = new System.Drawing.Size(87, 47);
            this.Downloadbtn.TabIndex = 3;
            this.Downloadbtn.Text = "Download";
            this.Downloadbtn.UseVisualStyleBackColor = true;
            this.Downloadbtn.Click += new System.EventHandler(this.Downloadbtn_Click);
            // 
            // responserichtxtBox
            // 
            this.responserichtxtBox.Location = new System.Drawing.Point(12, 65);
            this.responserichtxtBox.Name = "responserichtxtBox";
            this.responserichtxtBox.Size = new System.Drawing.Size(567, 373);
            this.responserichtxtBox.TabIndex = 4;
            this.responserichtxtBox.Text = "";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.responserichtxtBox);
            this.Controls.Add(this.Downloadbtn);
            this.Controls.Add(this.filePathtxtBox);
            this.Controls.Add(this.urltxtBox);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urltxtBox;
        private System.Windows.Forms.TextBox filePathtxtBox;
        private System.Windows.Forms.Button Downloadbtn;
        private System.Windows.Forms.RichTextBox responserichtxtBox;
    }
}