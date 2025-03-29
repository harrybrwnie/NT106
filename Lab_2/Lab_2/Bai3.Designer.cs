namespace Lab_2
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
            this.readFilebtn = new System.Windows.Forms.Button();
            this.readTextBox = new System.Windows.Forms.RichTextBox();
            this.mathbtn = new System.Windows.Forms.Button();
            this.writeFilebtn = new System.Windows.Forms.Button();
            this.writeTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // readFilebtn
            // 
            this.readFilebtn.Location = new System.Drawing.Point(339, 42);
            this.readFilebtn.Name = "readFilebtn";
            this.readFilebtn.Size = new System.Drawing.Size(124, 39);
            this.readFilebtn.TabIndex = 0;
            this.readFilebtn.Text = "Đọc File";
            this.readFilebtn.UseVisualStyleBackColor = true;
            this.readFilebtn.Click += new System.EventHandler(this.readFilebtn_Click);
            // 
            // readTextBox
            // 
            this.readTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.readTextBox.Location = new System.Drawing.Point(12, 42);
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.ReadOnly = true;
            this.readTextBox.Size = new System.Drawing.Size(321, 275);
            this.readTextBox.TabIndex = 1;
            this.readTextBox.Text = "";
            // 
            // mathbtn
            // 
            this.mathbtn.Location = new System.Drawing.Point(339, 114);
            this.mathbtn.Name = "mathbtn";
            this.mathbtn.Size = new System.Drawing.Size(124, 39);
            this.mathbtn.TabIndex = 2;
            this.mathbtn.Text = "Tính toán";
            this.mathbtn.UseVisualStyleBackColor = true;
            this.mathbtn.Click += new System.EventHandler(this.mathbtn_Click);
            // 
            // writeFilebtn
            // 
            this.writeFilebtn.Location = new System.Drawing.Point(339, 188);
            this.writeFilebtn.Name = "writeFilebtn";
            this.writeFilebtn.Size = new System.Drawing.Size(124, 39);
            this.writeFilebtn.TabIndex = 3;
            this.writeFilebtn.Text = "Ghi File";
            this.writeFilebtn.UseVisualStyleBackColor = true;
            this.writeFilebtn.Click += new System.EventHandler(this.writeFilebtn_Click);
            // 
            // writeTextBox
            // 
            this.writeTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.writeTextBox.Location = new System.Drawing.Point(469, 42);
            this.writeTextBox.Name = "writeTextBox";
            this.writeTextBox.ReadOnly = true;
            this.writeTextBox.Size = new System.Drawing.Size(319, 275);
            this.writeTextBox.TabIndex = 4;
            this.writeTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "INPUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(589, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "OUTPUT";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.writeTextBox);
            this.Controls.Add(this.writeFilebtn);
            this.Controls.Add(this.mathbtn);
            this.Controls.Add(this.readTextBox);
            this.Controls.Add(this.readFilebtn);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readFilebtn;
        private System.Windows.Forms.RichTextBox readTextBox;
        private System.Windows.Forms.Button mathbtn;
        private System.Windows.Forms.Button writeFilebtn;
        private System.Windows.Forms.RichTextBox writeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}