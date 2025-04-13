using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class TCPClientb3 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        public TCPClientb3()
        {
            InitializeComponent();
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null && client.Connected)
                {
                    string message = "Hello Server";
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    stream.Flush();
                }
                else
                {
                    MessageBox.Show("Chưa kết nối đến server");
                }
            }
            catch (Exception ex)
            {
             MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void TCPClientb3_Load(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", 8080);
                stream = client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi:" + ex.Message);
            }
        }
    }
}
