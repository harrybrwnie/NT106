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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void TCPServerbtn_Click(object sender, EventArgs e)
        {
            TCPServerb3 tcpserver = new TCPServerb3();
            TCPServerbtn.Enabled = false;
            tcpserver.FormClosed += (s, args) =>
            {
                TCPServerbtn.Enabled = true;
            };
            tcpserver.Show();
        }

        private void TCPClientbtn_Click(object sender, EventArgs e)
        {
            TCPClientb3 tcpclient = new TCPClientb3();
            TCPClientbtn.Enabled = false;
            tcpclient.FormClosed += (s, args) =>
            {
                TCPClientbtn.Enabled = true;
            };
            tcpclient.Show();
        }
    }
}
