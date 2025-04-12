using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
namespace Lab_3
{
    public partial class UDPClientb1 : Form
    {
        public UDPClientb1()
        {
            InitializeComponent();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string ip = tbIPRemoteHost.Text.Trim();
            string Strport = tbPort.Text.Trim();
            string message = tbMessage.Text.Trim();

            if(!IPAddress.TryParse(ip, out IPAddress ipaddress)) { 
                MessageBox.Show("IP khong hop le");
                return;
            }

            if(!int.TryParse(Strport, out int port))
            {
                MessageBox.Show("Port khong hop le");
                return;
            }

            using (UdpClient client = new UdpClient())
            {
                try
                {
                    client.Connect(ipaddress, port);
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    await client.SendAsync(data, data.Length);

                    var result = await client.ReceiveAsync();
                    
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Loi " + ex.Message);
                }
            }

        }
    }
}
