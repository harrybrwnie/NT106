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

namespace Lab_3
{
    public partial class UDPServerb1 : Form
    {
        public UDPServerb1()
        {
            InitializeComponent();
        }

        private CancellationTokenSource cts;

        private void btnListen_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(tbPort.Text.Trim(), out int port)) { 
                MessageBox.Show("Port khong hop le");
                return;
            }

            cts = new CancellationTokenSource();
            Task.Run(() => StartListening(port, cts.Token));
            AppendMessage($"Server dang lang nghe tai port {port}");
        }

        private void StartListening(int port, CancellationToken token)
        {
            try
            {
                using (UdpClient udpServer = new UdpClient(port))
                {
                    IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

                    while (!token.IsCancellationRequested)
                    {
                        byte[] data = udpServer.Receive(ref remoteEP);
                        string message = Encoding.UTF8.GetString(data);
                        string senderIP = remoteEP.Address.ToString();

                        AppendMessage($"{remoteEP.Address} : {message}");


                    }
                }
            }
                catch(Exception ex)
            {
                AppendMessage("Loi " + ex.Message);
            }
            
        }

        private void AppendMessage(string message)
        {
            if (tbRecievedMessages.InvokeRequired)
            {
                tbRecievedMessages.Invoke(new Action(() =>
                {
                    tbRecievedMessages.AppendText(message + Environment.NewLine);
                }));
            }
            else
            {
                tbRecievedMessages.AppendText(message + Environment.NewLine);
            }
        }

        private void UDPServerb1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts?.Cancel();
        }
    }
}
