﻿using System;
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
    public partial class SourceForm : Form
    {
        public SourceForm(string html)
        {
            InitializeComponent();
            richTextBox1.Text = html;
        }
    }
}
