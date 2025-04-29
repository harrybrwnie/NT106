using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Bai1 b1 = new Bai1();
            b1.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Bai2 b2 = new Bai2();
            b2.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Bai3 b3 = new Bai3();
            b3.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Bai4 b4 = new Bai4();
            b4.Show();
        }
    }
}
