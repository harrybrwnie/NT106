﻿namespace Lab_4
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
            this.urltxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DatatxtBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // urltxtBox
            // 
            this.urltxtBox.Location = new System.Drawing.Point(12, 12);
            this.urltxtBox.Name = "urltxtBox";
            this.urltxtBox.Size = new System.Drawing.Size(443, 20);
            this.urltxtBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "GET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatatxtBox
            // 
            this.DatatxtBox.Location = new System.Drawing.Point(13, 39);
            this.DatatxtBox.Name = "DatatxtBox";
            this.DatatxtBox.Size = new System.Drawing.Size(592, 265);
            this.DatatxtBox.TabIndex = 2;
            this.DatatxtBox.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 316);
            this.Controls.Add(this.DatatxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urltxtBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urltxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox DatatxtBox;
    }
}