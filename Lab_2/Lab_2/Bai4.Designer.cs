namespace Lab_2
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
            this.lbText = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.RichTextBox();
            this.btGhi = new System.Windows.Forms.Button();
            this.bXoa = new System.Windows.Forms.Button();
            this.bXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbText.Location = new System.Drawing.Point(22, 33);
            this.lbText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(485, 25);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Nhập MSSV, Họ tên, SĐT,  Điểm Toán, Điểm Văn";
            this.lbText.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(27, 85);
            this.tbInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(481, 287);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "";
            // 
            // btGhi
            // 
            this.btGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGhi.Location = new System.Drawing.Point(544, 85);
            this.btGhi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(84, 41);
            this.btGhi.TabIndex = 2;
            this.btGhi.Text = "Ghi File";
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // bXoa
            // 
            this.bXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bXoa.Location = new System.Drawing.Point(544, 150);
            this.bXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(84, 41);
            this.bXoa.TabIndex = 3;
            this.bXoa.Text = "Xóa";
            this.bXoa.UseVisualStyleBackColor = true;
            this.bXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // bXuat
            // 
            this.bXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bXuat.Location = new System.Drawing.Point(544, 210);
            this.bXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bXuat.Name = "bXuat";
            this.bXuat.Size = new System.Drawing.Size(84, 41);
            this.bXuat.TabIndex = 4;
            this.bXuat.Text = "Xuất File";
            this.bXuat.UseVisualStyleBackColor = true;
            this.bXuat.Click += new System.EventHandler(this.bXuat_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 413);
            this.Controls.Add(this.bXuat);
            this.Controls.Add(this.bXoa);
            this.Controls.Add(this.btGhi);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.RichTextBox tbInput;
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.Button bXuat;
    }
}