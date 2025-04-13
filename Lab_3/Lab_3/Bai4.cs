using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lab_3
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void btnTCPListener_Click(object sender, EventArgs e)
        {
            TCPListenerb4 tcplistenerb4 = new TCPListenerb4();
            tcplistenerb4.Show();
        }

        private void btnTCPClient_Click(object sender, EventArgs e)
        {
             TCPClientb4 b4 = new TCPClientb4();
             b4.Show();
            
        }
    }
}
