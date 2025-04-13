namespace Lab_3
{
    partial class TCPClientb3
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
            Sendbtn = new Button();
            SuspendLayout();
            // 
            // Sendbtn
            // 
            Sendbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sendbtn.Location = new Point(12, 12);
            Sendbtn.Name = "Sendbtn";
            Sendbtn.Size = new Size(417, 46);
            Sendbtn.TabIndex = 0;
            Sendbtn.Text = "Send Message";
            Sendbtn.UseVisualStyleBackColor = true;
            Sendbtn.Click += Sendbtn_Click;
            // 
            // TCPClientb3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 70);
            Controls.Add(Sendbtn);
            Name = "TCPClientb3";
            Text = "TCPClientb3";
            Load += TCPClientb3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Sendbtn;
    }
}