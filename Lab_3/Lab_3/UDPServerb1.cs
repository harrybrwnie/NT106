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
        private UdpClient udpServer;
        public UDPServerb1()
        {
            InitializeComponent();
        }

        private CancellationTokenSource cts;

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbPort.Text.Trim(), out int port))
            {
                MessageBox.Show("Port khong hop le");
                return;
            }

            cts = new CancellationTokenSource();
            Task.Run(() => StartListening(port, cts.Token));
            AppendMessage($"Server dang lang nghe tai port {port}");
            btnListen.Enabled = false;
            tbPort.ReadOnly = true;
        }

        private void StartListening(int port, CancellationToken token)
        {
            try {
                udpServer = new UdpClient(port);
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

                while (!token.IsCancellationRequested)
                {
                    try
                    {
                        byte[] data = udpServer.Receive(ref remoteEP);
                        string message = Encoding.UTF8.GetString(data);
                        AppendMessage($"{remoteEP.Address} : {message}");
                    }
                    catch (SocketException ex)
                    {
                        AppendMessage("Socket closed: " + ex.Message);
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                AppendMessage("Lỗi khi bắt đầu server: " + ex.Message);
            }
        }

        private void AppendMessage(string message)
        {
            if (tbRecievedMessages == null || tbRecievedMessages.IsDisposed || !tbRecievedMessages.IsHandleCreated)
                return;

            if (tbRecievedMessages.InvokeRequired)
            {
                try
                {
                    tbRecievedMessages.Invoke(new Action(() =>
                    {
                        if (!tbRecievedMessages.IsDisposed && tbRecievedMessages.IsHandleCreated)
                            tbRecievedMessages.AppendText(message + Environment.NewLine);
                    }));
                }
                catch { }
            }
            else
            {
                if (!tbRecievedMessages.IsDisposed && tbRecievedMessages.IsHandleCreated)
                    tbRecievedMessages.AppendText(message + Environment.NewLine);
            }
        }

        private void UDPServerb1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //udpServer?.Close();
            cts?.Cancel();
            udpServer?.Close();
        }
    }
}
