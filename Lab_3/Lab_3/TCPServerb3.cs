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
    public partial class TCPServerb3 : Form
    {
        private TcpListener server;
        private Task serverTask;
        private CancellationTokenSource cts;
        public TCPServerb3()
        {
            InitializeComponent();
        }

        private void Listenbtn_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            Listenbtn.Enabled = false;
            serverTask = Task.Run(() => StartListening(cts.Token));
            AppendLog("Server running on 127.0.0.1:8080");
        }
        private void StartListening(CancellationToken token)
        {
            try
            {
                server = new TcpListener(IPAddress.Any, 8080);
                server.Start();

                while (!token.IsCancellationRequested)
                {
                    if (server.Pending())
                    {
                        TcpClient client = server.AcceptTcpClient();
                        AppendLog("New client connected");
                        Task.Run(() => HandleClient(client));
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
            }
            catch (Exception ex)
            {
                AppendLog("Loi server: " + ex.Message);
            }
        }

        private void HandleClient(TcpClient client)
        {
            try
            {
                using (client)
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] buffer = new byte[1024];
                    int byteRead;

                    while ((byteRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        string msg = Encoding.UTF8.GetString(buffer, 0, byteRead);
                        AppendLog("Client: " + msg);
                    }
                }
            }
            catch (Exception ex)
            {
                AppendLog("Lỗi:" + ex.Message);
            }
        }
        private void AppendLog(string msg)
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke((MethodInvoker)(() => textBox1.AppendText(msg + Environment.NewLine)));
            }
            else
            {
                textBox1.AppendText(msg + Environment.NewLine);
            }
        }

        private void TCPServerb3_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts?.Cancel();
            server?.Stop();
            serverTask?.Wait();
        }
    }
}
