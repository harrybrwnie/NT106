namespace Lab_4
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
            this.urltxtBox = new System.Windows.Forms.TextBox();
            this.contenttxtBox = new System.Windows.Forms.TextBox();
            this.Postbtn = new System.Windows.Forms.Button();
            this.responserichtxtBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // urltxtBox
            // 
            this.urltxtBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.urltxtBox.Location = new System.Drawing.Point(12, 12);
            this.urltxtBox.Name = "urltxtBox";
            this.urltxtBox.ReadOnly = true;
            this.urltxtBox.Size = new System.Drawing.Size(456, 20);
            this.urltxtBox.TabIndex = 0;
            // 
            // contenttxtBox
            // 
            this.contenttxtBox.Location = new System.Drawing.Point(13, 39);
            this.contenttxtBox.Name = "contenttxtBox";
            this.contenttxtBox.Size = new System.Drawing.Size(455, 20);
            this.contenttxtBox.TabIndex = 1;
            // 
            // Postbtn
            // 
            this.Postbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.Postbtn.Location = new System.Drawing.Point(474, 12);
            this.Postbtn.Name = "Postbtn";
            this.Postbtn.Size = new System.Drawing.Size(122, 47);
            this.Postbtn.TabIndex = 2;
            this.Postbtn.Text = "Post";
            this.Postbtn.UseVisualStyleBackColor = true;
            this.Postbtn.Click += new System.EventHandler(this.Postbtn_Click);
            // 
            // responserichtxtBox
            // 
            this.responserichtxtBox.Location = new System.Drawing.Point(12, 65);
            this.responserichtxtBox.Name = "responserichtxtBox";
            this.responserichtxtBox.Size = new System.Drawing.Size(584, 377);
            this.responserichtxtBox.TabIndex = 3;
            this.responserichtxtBox.Text = "";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 454);
            this.Controls.Add(this.responserichtxtBox);
            this.Controls.Add(this.Postbtn);
            this.Controls.Add(this.contenttxtBox);
            this.Controls.Add(this.urltxtBox);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urltxtBox;
        private System.Windows.Forms.TextBox contenttxtBox;
        private System.Windows.Forms.Button Postbtn;
        private System.Windows.Forms.RichTextBox responserichtxtBox;
    }
}