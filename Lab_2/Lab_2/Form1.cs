﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bBai1_Click(object sender, EventArgs e)
        {
            Bai1 b1 = new Bai1();
            b1.Show();
        }

        private void bBai2_Click(object sender, EventArgs e)
        {
            Bai2 b2 = new Bai2();
            b2.Show();
        }

        private void bBai3_Click(object sender, EventArgs e)
        {
            Bai3 b3 = new Bai3();
            b3.Show();
        }

        private void bBai4_Click(object sender, EventArgs e)
        {
            Bai4 b4 = new Bai4();
            b4.Show();
        }

        private void bBai5_Click(object sender, EventArgs e)
        {
            Bai5 b5 = new Bai5();
            b5.Show();
        }
    }
}
