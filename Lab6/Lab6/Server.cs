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
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Lab6
{
    public partial class Server: Form
    {

        private TcpListener listener;
        private bool isRunning = false;
        private Thread listenThread;

        private int a = 10, b = 100;
        private int secretNumber;
        private int maxRounds = 5;
        private int currentRound = 0;
        private bool numberGuessed = false;

        private List<ClientInfo> clients = new List<ClientInfo>();
        private List<string> gameHistory = new List<string>();


        public class PastebinUploader
        {
            private const string ApiKey = "1L5691MFPQ7QAL2VPCvduP_NRsNWlh5b";  // Thay bằng API Key của bạn
            public const string PastebinUrl = "https://pastebin.com/api/api_post.php";

            public static Task<string> UploadHistoryToPastebin(string historyContent)
            {
                // Gọi helper async
                return UploadInternal(historyContent);
            }

            private static async Task<string> UploadInternal(string historyContent)
            {
                using (var client = new HttpClient())
                {
                    // Chuẩn bị body theo Pastebin API
                    var values = new Dictionary<string, string>();
                    values["api_dev_key"] = ApiKey;
                    values["api_option"] = "paste";
                    values["api_paste_code"] = historyContent;
                    values["api_paste_name"] = "game_history.txt";
                    values["api_paste_expire_date"] = "N";   // "N" = Never hết hạn

                    var content = new FormUrlEncodedContent(values);

                    HttpResponseMessage response = await client.PostAsync(PastebinUrl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string url = await response.Content.ReadAsStringAsync();
                        return url.Trim();  // Trả về URL paste của bạn
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public Server()
        {
            InitializeComponent();
            UpdateUI(false);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                listener = new TcpListener(IPAddress.Any, 5000);
                listener.Start();
                isRunning = true;

                listenThread = new Thread(ListenForClients);
                listenThread.IsBackground = true;
                listenThread.Start();

                Log("Server started");
                btnStart.Text = "Stop Server";

                currentRound = 0;
                StartNewRound();
                UpdateUI(true);
            }
            else
            {
                StopServer();
            }
        }

        private void StopServer()
        {
            isRunning = false;
            listener.Stop();
            listenThread?.Abort();
            Log("Server stopped");
            btnStart.Text = "Start Server";
            UpdateUI(false);
        }

        private void ListenForClients()
        {
            try
            {
                while (isRunning)
                {
                    TcpClient tcpClient = listener.AcceptTcpClient();
                    Thread clientThread = new Thread(() => HandleClient(tcpClient));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch { }
        }

        private void HandleClient(TcpClient tcpClient)
        {
            NetworkStream stream = tcpClient.GetStream();
            ClientInfo clientInfo = new ClientInfo(tcpClient);
            lock (clients)
            {
                clients.Add(clientInfo);
            }
            UpdatePlayerCount();

            try
            {
                while (isRunning)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break; // client disconnect

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    ProcessMessage(clientInfo, message.Trim());
                }
            }
            catch { }
            finally
            {
                lock (clients)
                {
                    clients.Remove(clientInfo);
                }
                UpdatePlayerCount();
                tcpClient.Close();
                Log($"Client {clientInfo.Name ?? "Unknown"} disconnected");
                UpdatePlayerList();
            }
        }

        private void ProcessMessage(ClientInfo client, string message)
        {
            var parts = message.Split('|');
            if (parts.Length == 0) return;

            string cmd = parts[0].ToUpper();

            if(cmd == "NAME" && parts.Length == 2)
            {
                client.Name = parts[1];
                SendMessage(client, $"Hello {client.Name}!");
                Log($"Client {client.Name}");
                SendRangeToClient(client);
                UpdatePlayerList();
            }
            else if (cmd == "GUESS" && parts.Length == 2 && int.TryParse(parts[1], out int guess))
            {
                if (numberGuessed)
                {
                    SendMessage(client, "RESULT|Lượt chơi đã kết thúc, chờ lượt mới.");
                    return;
                }

                if (guess == secretNumber)
                {
                    numberGuessed = true;
                    Log($"{client.Name} đoán đúng số {guess}!");
                    Broadcast($"WINNER|{client.Name} đoán đúng số {guess}!");
                    client.Points += 5;
                    currentRound++;

                    UpdatePlayerList();

                    if (currentRound >= maxRounds)
                    {
                        ClientInfo champion;
                        lock (client) {
                            champion = clients
                            .OrderByDescending(c => c.Points)
                                .ThenBy(c => c.Mistakes)
                                .FirstOrDefault();
                        }
                        if (champion != null)
                        {
                            string winner = $"FINAL_WINNER|{champion.Name}|{champion.Points}";
                            Broadcast(winner);
                            Log($"NgƯời thắng chung cuộc: {champion.Name} với {champion.Points} điểm, sai {champion.Mistakes} lượt");
                        }
                        Broadcast("GAME_OVER|Trò chơi kết thúc!");

                        Task.Run(async () =>
                        {
                            string link = await PastebinUploader.UploadHistoryToPastebin(string.Join("\n", gameHistory));
                            if (link != null)
                                Log($"Lịch sử trò chơi đã tải lên: {link}");
                                
                            else
                                Log("Lỗi khi tải lịch sử lên Pastebin");

                            SaveGameHistory();
                            Thread.Sleep(3000);
                            Invoke(new Action(() => this.Close()));
                        });
                    }
                    else
                    {
                        StartNewRound();
                    }
                }
                else
                {
                    SendMessage(client, guess < secretNumber ? "RESULT|Quá thấp" : "RESULT|Quá cao");
                    client.Mistakes++;
                    client.Points--;
                    client.Points = Math.Max(0, client.Points);
                    UpdatePlayerList();
                }
            }
        }

        private void SendRangeToClient(ClientInfo client)
        {
            SendMessage(client, $"RANGE|{a}|{b}");
        }

        private void Broadcast(string message)
        {
            lock (clients)
            {
                foreach (var c in clients)
                {
                    SendMessage(c, message);
                }
            }
            Log("[Broadcast] " + message);
        }

        private void SendMessage(ClientInfo client, string message)
        {
            try
            {
                NetworkStream stream = client.TcpClient.GetStream();
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch { }
        }

        private void StartNewRound()
        {
            Random rnd = new Random();
            secretNumber = rnd.Next(a + 1, b);
            numberGuessed = false;

            Broadcast($"NEW_ROUND|Lượt chơi thứ {currentRound + 1} bắt đầu! Đoán số trong khoảng {a} đến {b}.");
            Log($"Lượt chơi {currentRound + 1} bắt đầu. Số cần đoán: {secretNumber}");

            Invoke(new Action(() =>
            {
                lblSecretNumber.Text = secretNumber.ToString();
                lblRange.Text = $"{a} - {b}";
            }));

            Invoke(new Action(UpdateRoundLabel));
        }

        private void Log(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => {
                    rtbLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {text}\n");
                    rtbLog.ScrollToCaret();
                }));
            }
            else
            {
                rtbLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {text}\n");
                rtbLog.ScrollToCaret();
            }
            lock (gameHistory)
            {
                gameHistory.Add(text);
            }
        }

        private void UpdatePlayerCount()
        {
            if (InvokeRequired)
                Invoke(new Action(UpdatePlayerCount));
            else
                lblPlayerCount.Text = clients.Count.ToString();
        }

        private void UpdateRoundLabel()
        {
            lblCurrentRound.Text = (currentRound + 1).ToString();
        }

        private void UpdatePlayerList()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdatePlayerList));
                return;
            }
            dgvPlayers.Rows.Clear();
            lock (clients)
            {
                foreach (var c in clients)
                {
                    dgvPlayers.Rows.Add(c.Name, c.Points, c.Mistakes);
                }
            }
        }

        private void UpdateUI(bool running)
        {
            btnStart.Enabled = true;
            lblPlayerCount.Text = running ? "0" : "-";
            lblCurrentRound.Text = running ? "0" : "-";
            dgvPlayers.Enabled = running;
            rtbLog.Enabled = running;
        }

        private void SaveGameHistory()
        {
            try
            {
                string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "game_history.txt");
                lock (gameHistory)
                {
                    System.IO.File.WriteAllLines(path, gameHistory);
                }
                Log("Đã lưu lịch sử trò chơi vào game_history.txt");
            }
            catch (Exception ex)
            {
                Log("Lỗi khi lưu lịch sử: " + ex.Message);
            }
        }

        

        public class ClientInfo
        {
            public TcpClient TcpClient { get; }
            public string Name { get; set; } = null;
            public int Points { get; set; } = 0;
            public int Mistakes { get; set; } = 0;

            public ClientInfo(TcpClient tcpClient)
            {
                TcpClient = tcpClient;
            }
        }
        /*
        public static async Task<string> GetUserApiKey(string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = new StringContent($"api_dev_key={PastebinUploader.ApiKey}&api_user_name={username}&api_user_password={password}", Encoding.UTF8, "application/x-www-form-urlencoded");

                HttpResponseMessage response = await client.PostAsync(PastebinUploader.PastebinUrl, data);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return result;  // Trả về User API Key
                }
                else
                {
                    return null;  // Nếu có lỗi
                }
            }
        }
        */
    }
}
