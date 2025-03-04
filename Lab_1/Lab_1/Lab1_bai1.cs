using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Lab1_bai1 : Form
    {
        public Lab1_bai1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bXoa_Click(object sender, EventArgs e)
        {
            iNum1.Clear();
            iNum2.Clear();
        }

        private void bTinh_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if(!int.TryParse(iNum1.Text, out num1) || !int.TryParse(iNum2.Text, out num2))
            {
                MessageBox.Show("Nhap so nguyen");
                return;
            }
            iSum.Text = Convert.ToString(num1 + num2);
        }
    }
}
