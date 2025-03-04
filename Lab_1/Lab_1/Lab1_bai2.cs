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
    public partial class Lab1_bai2 : Form
    {
        public Lab1_bai2()
        {
            InitializeComponent();
        }

        private void bThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bXoa_Click(object sender, EventArgs e)
        {
            iNum1.Clear();
            iNum2.Clear();
            iNum3.Clear();
        }

        private void bTim_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            if(!double.TryParse(iNum1.Text, out num1) || !double.TryParse(iNum2.Text, out num2) || !double.TryParse(iNum3.Text, out num3))
            {
                MessageBox.Show("Nhap so");
                return;
            }
            double maxNum = Math.Max(num1, Math.Max(num2, num3));
            double minNum = Math.Min(num1, Math.Min(num2, num3));
            iMax.Text = Convert.ToString(maxNum);
            iMin.Text = Convert.ToString(minNum);
        }
    }
}
