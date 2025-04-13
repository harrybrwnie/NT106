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
using System.Collections.Concurrent;

namespace Lab_3
{
    public partial class TCPClientb4 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private CancellationTokenSource cts;
        private const int PORT = 8080;
        private bool connected = false;

        public TCPClientb4()
        {
            InitializeComponent();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên không được để trống");
                return;
            }

            try
            {
                client = new TcpClient();
                await client.ConnectAsync("127.0.0.1", PORT);
                stream = client.GetStream();

                byte[] nameBytes = Encoding.UTF8.GetBytes(name);
                await stream.WriteAsync(nameBytes, 0, nameBytes.Length);

                cts = new CancellationTokenSource();
                _ = Task.Run(() => ReceiveLoop(cts.Token));
                connected = true;
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi kết nối: " + ex.Message);
               
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                MessageBox.Show("Vui lòng kết nối trước khi gửi tin nhắn");
                return;
            }
            ////////////
            btnConnect.Enabled = false;
            tbName.ReadOnly = true;
            string msg = tbMessage.Text.Trim();
            if (string.IsNullOrEmpty(msg)) return;

            byte[] data = Encoding.UTF8.GetBytes(msg);
            await stream.WriteAsync(data, 0, data.Length);
            tbMessage.Clear();
        }

        private async Task ReceiveLoop(CancellationToken token)
        {
            byte[] buffer = new byte[1024];

            try
            {
                while (!token.IsCancellationRequested)
                {
                    int byteCount = await stream.ReadAsync(buffer, 0, buffer.Length, token);
                    if (byteCount == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, byteCount);
                    if (!message.StartsWith("New client connected") &&
                        !message.Contains("đã thoát") &&
                        !message.Contains("Lỗi"))
                        AppendChat(message);

                    if (message.Contains("Tên đã tồn tại"))
                    {
                        stream?.Close();
                        client?.Close();
                        connected = false;

                        if (tbName.InvokeRequired)
                            tbName.Invoke(new Action(() =>
                            {
                                tbName.Enabled = true;
                                btnConnect.Enabled = true;
                            }));
                        else
                        {
                            tbName.Enabled = true;
                            btnConnect.Enabled = true;
                        }
                    }
                    else if (!tbName.Enabled)
                    {
                        if (!string.IsNullOrWhiteSpace(tbName.Text) && tbName.Enabled)
                        {
                            if (tbName.InvokeRequired)
                                tbName.Invoke(new Action(() => tbName.ReadOnly = true));
                            else
                                tbName.ReadOnly = true;
                        }
                    }
                }
            }
            catch
            {
                AppendChat("⛔ Mất kết nối đến server.");
                
            }
        }

        private void AppendChat(string msg)
        {
            if (rtbChat.InvokeRequired)
                rtbChat.Invoke(new Action(() => rtbChat.AppendText(msg)));
            else
                rtbChat.AppendText(msg);
        }

        private void TCPClientb4_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                stream?.Close();
                client?.Close();
            }
            catch { }

            cts?.Cancel();
        }

    }
}
