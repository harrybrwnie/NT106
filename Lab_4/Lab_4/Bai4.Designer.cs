namespace Lab_4
{
    partial class Bai4
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
            this.UrltxtBox = new System.Windows.Forms.TextBox();
            this.Gobtn = new System.Windows.Forms.Button();
            this.Downloadbtn = new System.Windows.Forms.Button();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // UrltxtBox
            // 
            this.UrltxtBox.Location = new System.Drawing.Point(12, 8);
            this.UrltxtBox.Name = "UrltxtBox";
            this.UrltxtBox.Size = new System.Drawing.Size(650, 20);
            this.UrltxtBox.TabIndex = 2;
            // 
            // Gobtn
            // 
            this.Gobtn.Location = new System.Drawing.Point(668, 5);
            this.Gobtn.Name = "Gobtn";
            this.Gobtn.Size = new System.Drawing.Size(75, 23);
            this.Gobtn.TabIndex = 3;
            this.Gobtn.Text = "Go";
            this.Gobtn.UseVisualStyleBackColor = true;
            this.Gobtn.Click += new System.EventHandler(this.Gobtn_Click);
            // 
            // Downloadbtn
            // 
            this.Downloadbtn.Location = new System.Drawing.Point(750, 5);
            this.Downloadbtn.Name = "Downloadbtn";
            this.Downloadbtn.Size = new System.Drawing.Size(75, 23);
            this.Downloadbtn.TabIndex = 4;
            this.Downloadbtn.Text = "Download";
            this.Downloadbtn.UseVisualStyleBackColor = true;
            this.Downloadbtn.Click += new System.EventHandler(this.Downloadbtn_Click);
            // 
            // Viewbtn
            // 
            this.Viewbtn.Location = new System.Drawing.Point(831, 5);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(75, 23);
            this.Viewbtn.TabIndex = 5;
            this.Viewbtn.Text = "View Source";
            this.Viewbtn.UseVisualStyleBackColor = true;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(0, 34);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(967, 432);
            this.webBrowser1.TabIndex = 6;
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 466);
            this.Controls.Add(this.Viewbtn);
            this.Controls.Add(this.Downloadbtn);
            this.Controls.Add(this.Gobtn);
            this.Controls.Add(this.UrltxtBox);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UrltxtBox;
        private System.Windows.Forms.Button Gobtn;
        private System.Windows.Forms.Button Downloadbtn;
        private System.Windows.Forms.Button Viewbtn;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}