namespace Lab_3
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
            textBox1 = new TextBox();
            Listenbtn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Location = new Point(12, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(440, 293);
            textBox1.TabIndex = 0;
            // 
            // Listenbtn
            // 
            Listenbtn.Location = new Point(377, 12);
            Listenbtn.Name = "Listenbtn";
            Listenbtn.Size = new Size(75, 31);
            Listenbtn.TabIndex = 1;
            Listenbtn.Text = "Listen";
            Listenbtn.UseVisualStyleBackColor = true;
            Listenbtn.Click += Listenbtn_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 354);
            Controls.Add(Listenbtn);
            Controls.Add(textBox1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Bai2";
            Text = "Bai2";
            FormClosing += Bai2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Listenbtn;
    }
}