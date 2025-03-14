namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab1_bai1 b1 = new Lab1_bai1();
            b1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab1_bai2 b2 = new Lab1_bai2();
            b2.Show();
        }

        private void bBai3_Click(object sender, EventArgs e)
        {
            Lab1_bai3 b3 = new Lab1_bai3();
            b3.Show();
        }

        private void bBai4_Click(object sender, EventArgs e)
        {
            Lab1_bai4 b4 = new Lab1_bai4();
            b4.Show();
        }

        private void bBai5_Click(object sender, EventArgs e)
        {
            Lab1_bai5 b5 = new Lab1_bai5();
            b5.Show();
        }
    }
}
