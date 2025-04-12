using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnUDPClient_Click(object sender, EventArgs e)
        {
            UDPClientb1 udpclientb1 = new UDPClientb1();
            udpclientb1.Show();
        }

        private void btnUDPServer_Click(object sender, EventArgs e)
        {
            UDPServerb1 udpserverb1 = new UDPServerb1();
            udpserverb1.Show();
        }
    }
}
