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
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbText.Location = new System.Drawing.Point(45, 63);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(659, 33);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Nhập MSSV, Họ tên, SĐT,  Điểm Toán, Điểm Văn";
            this.lbText.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(51, 129);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(653, 153);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "";
            // 
            // btGhi
            // 
            this.btGhi.Location = new System.Drawing.Point(51, 336);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(167, 78);
            this.btGhi.TabIndex = 2;
            this.btGhi.Text = "Ghi File";
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // bXoa
            // 
            this.bXoa.Location = new System.Drawing.Point(303, 336);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(167, 78);
            this.bXoa.TabIndex = 3;
            this.bXoa.Text = "Xóa";
            this.bXoa.UseVisualStyleBackColor = true;
            this.bXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // bXuat
            // 
            this.bXuat.Location = new System.Drawing.Point(537, 336);
            this.bXuat.Name = "bXuat";
            this.bXuat.Size = new System.Drawing.Size(167, 78);
            this.bXuat.TabIndex = 4;
            this.bXuat.Text = "Xuất File";
            this.bXuat.UseVisualStyleBackColor = true;
            this.bXuat.Click += new System.EventHandler(this.bXuat_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bXuat);
            this.Controls.Add(this.bXoa);
            this.Controls.Add(this.btGhi);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbText);
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