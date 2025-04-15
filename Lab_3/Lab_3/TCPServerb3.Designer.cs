namespace Lab_3
{
    partial class TCPServerb3
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
            Listenbtn = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Listenbtn
            // 
            Listenbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Listenbtn.Location = new Point(422, 12);
            Listenbtn.Name = "Listenbtn";
            Listenbtn.Size = new Size(109, 40);
            Listenbtn.TabIndex = 0;
            Listenbtn.Text = "Listen";
            Listenbtn.UseVisualStyleBackColor = true;
            Listenbtn.Click += Listenbtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(12, 58);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(519, 362);
            textBox1.TabIndex = 1;
            // 
            // TCPServerb3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 432);
            Controls.Add(textBox1);
            Controls.Add(Listenbtn);
            Name = "TCPServerb3";
            Text = "TCPServerb3";
            FormClosing += TCPServerb3_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Listenbtn;
        private TextBox textBox1;
    }
}