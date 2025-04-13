namespace Lab_3
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
            TCPServerbtn = new Button();
            TCPClientbtn = new Button();
            SuspendLayout();
            // 
            // TCPServerbtn
            // 
            TCPServerbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TCPServerbtn.Location = new Point(57, 28);
            TCPServerbtn.Name = "TCPServerbtn";
            TCPServerbtn.Size = new Size(363, 52);
            TCPServerbtn.TabIndex = 0;
            TCPServerbtn.Text = "Open TCP Server";
            TCPServerbtn.UseVisualStyleBackColor = true;
            TCPServerbtn.Click += TCPServerbtn_Click;
            // 
            // TCPClientbtn
            // 
            TCPClientbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TCPClientbtn.Location = new Point(57, 86);
            TCPClientbtn.Name = "TCPClientbtn";
            TCPClientbtn.Size = new Size(363, 52);
            TCPClientbtn.TabIndex = 1;
            TCPClientbtn.Text = "Open TCP Client";
            TCPClientbtn.UseVisualStyleBackColor = true;
            TCPClientbtn.Click += TCPClientbtn_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 166);
            Controls.Add(TCPClientbtn);
            Controls.Add(TCPServerbtn);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button TCPServerbtn;
        private Button TCPClientbtn;
    }
}