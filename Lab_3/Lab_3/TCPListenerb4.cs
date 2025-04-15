
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class TCPListenerb4 : Form
    {
        private TcpListener listener;
        private CancellationTokenSource cts;
        private ConcurrentDictionary<TcpClient, string> clients = new ConcurrentDictionary<TcpClient, string>();
        private List<string> chatLog = new List<string>();
        private const int PORT = 8080;

        public TCPListenerb4()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            _ = StartServer(cts.Token);
            AppendMessage($"Server đang lắng nghe tại 127.0.0.1:{PORT}");
            btnListen.Enabled = false;
        }

        private async Task StartServer(CancellationToken token)
        {
            listener = new TcpListener(IPAddress.Loopback, PORT);
            listener.Start();

            try
            {
                while (!token.IsCancellationRequested)
                {
                    TcpClient client = await listener.AcceptTcpClientAsync();
                    _ = HandleClient(client, token);
                    
                }
            }
            catch (Exception ex)
            {
                AppendMessage("Lỗi server: " + ex.Message);
            }
        }

        private async Task HandleClient(TcpClient client, CancellationToken token)
        {
            string clientName = "";
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];

                int nameLength = await stream.ReadAsync(buffer, 0, buffer.Length, token);
                clientName = Encoding.UTF8.GetString(buffer, 0, nameLength).Trim();

                if (clients.Values.Contains(clientName))
                {
                    string warning = "Tên đã tồn tại. Hãy dùng tên khác.";
                    byte[] warningBytes = Encoding.UTF8.GetBytes(warning);
                    await stream.WriteAsync(warningBytes, 0, warningBytes.Length);
                    stream.Close();
                    client.Close();
                    return;
                }

                clients[client] = clientName;

                IPEndPoint clientEP = (IPEndPoint)client.Client.RemoteEndPoint;
                string connectMsg = $"New client connected from: {clientEP.Address}:{clientEP.Port}";
                AppendMessage(connectMsg);
                await BroadcastMessage(connectMsg);

                foreach (var line in chatLog)
                {
                    byte[] logBytes = Encoding.UTF8.GetBytes(line + "\n");
                    await stream.WriteAsync(logBytes, 0, logBytes.Length);
                    await Task.Delay(10);
                }

                while (!token.IsCancellationRequested)
                {
                    int byteCount = await stream.ReadAsync(buffer, 0, buffer.Length, token);
                    if (byteCount == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, byteCount).Trim();
                    IPEndPoint senderEP = (IPEndPoint)client.Client.RemoteEndPoint;
                    string fullMessage = $"[{senderEP.Address}:{senderEP.Port}] {clientName}: {message}";
                    AppendMessage(fullMessage);
                    chatLog.Add(fullMessage);
                    await BroadcastMessage($"{clientName}: {message}");
                }
            }
            catch (Exception ex)
            {
                AppendMessage("Lỗi xử lý client: " + ex.Message);
            }
            finally
            {
                if (clients.TryRemove(client, out string name))
                {
                    AppendMessage($"Client {name} đã ngắt kết nối.");
                }
                client.Close();
            }
        }

        private async Task BroadcastMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message + "\n");

            foreach (var client in clients.Keys)
            {
                if (client.Connected)
                {
                    try
                    {
                        await client.GetStream().WriteAsync(data, 0, data.Length);
                    }
                    catch { }
                }
            }
        }

        private void AppendMessage(string msg)
        {
            if (rtbMessage.InvokeRequired)
            {
                rtbMessage.Invoke(new Action(() =>
                    rtbMessage.AppendText($"{msg}\n")
                ));
            }
            else
            {
                rtbMessage.AppendText($"{msg}\n");
            }
        }


        private void TCPListenerb4_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            cts?.Cancel();
            listener?.Stop();
        }
    }
}