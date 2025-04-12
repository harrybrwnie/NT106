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
        private Thread listenThread;
        public Bai2()
        {
            InitializeComponent();
        }

        private void Listenbtn_Click(object sender, EventArgs e)
        {
            Listenbtn.Enabled = false;
            listenThread = new Thread(StartListening);
            listenThread.IsBackground = true;
            listenThread.Start();
            AppendLog("Telnet running on port 8080");
        }

        private void StartListening()
        {
            // Tao socket kieu TCP
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //Bind toi dia chi localhost va cong 8080
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 8080);
            serverSocket.Bind(localEndPoint);
            serverSocket.Listen(10);
            while (true)
            {
                try
                {
                    Socket clientSocket = serverSocket.Accept();

                    string clientIP = ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString();
                    AppendLog($"Telnet ket noi tu IP: {clientIP}");

                    Thread clientThread = new Thread(() => HandleClient(clientSocket));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
                catch (Exception ex)
                {
                    AppendLog("Loi: " + ex.Message);
                }
            }
        }
        private void AppendLog(string text)
        {
            if(textBox1.InvokeRequired)
            {
                textBox1.Invoke((MethodInvoker)(() => textBox1.AppendText(text + Environment.NewLine)));
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
    }
}
