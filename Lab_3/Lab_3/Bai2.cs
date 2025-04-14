using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Bai2 : Form
    {
        private Socket serverSocket;
        private CancellationTokenSource cts;
        private Task listenTask;
        public Bai2()
        {
            InitializeComponent();
        }

        private void Listenbtn_Click(object sender, EventArgs e)
        {
            Listenbtn.Enabled = false;
            cts = new CancellationTokenSource();
            listenTask = Task.Run(() => StartListening(cts.Token));
            AppendLog("Telnet running on port 8080");
        }

        private void StartListening(CancellationToken token)
        {
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 8080);
                serverSocket.Bind(localEndPoint);
                serverSocket.Listen(10);

                while(!token.IsCancellationRequested)
                {
                    if(serverSocket.Poll(1000, SelectMode.SelectRead))
                    {
                        Socket clientSocket = serverSocket.Accept();
                        string clientIP = ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString();
                        Task.Run(() => HandleClient(clientSocket));
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
            }
            catch (SocketException se)
            {
                AppendLog("Socket loi:"  + se.Message);
            }
            catch(Exception ex)
            {
                AppendLog("Loi: " + ex.Message);
            }
        }
        private void AppendLog(string text)
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke((MethodInvoker)(() => textBox1.AppendText(text)));
            }
            else
            {
                textBox1.AppendText(text + Environment.NewLine);
            }
        }
        private void HandleClient(Socket client)
        {
            try
            {
                byte[] buffer = new byte[1024];
                int received;

                while ((received = client.Receive(buffer)) > 0)
                {
                    string data = Encoding.UTF8.GetString(buffer, 0, received);
                    AppendLog($"Client: {data}");
                }
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
            catch (Exception ex)
            {
                AppendLog("Loi khi xu ly:" + ex.Message);
            }
        }

        private void Bai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts?.Cancel();
            serverSocket?.Close();
            listenTask?.Wait();
        }
    }
}
