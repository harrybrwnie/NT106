using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Client: Form
    {

        TcpClient client;
        NetworkStream stream;
        Thread listenThread;

        string playerName;
        int a = 0, b = 0;
        bool canSend = true;
        System.Windows.Forms.Timer countdownTimer;
        int countdownSeconds = 3;

        HashSet<int> triedNumbers = new HashSet<int>();
        Random random = new Random();

        System.Windows.Forms.Timer autoPlayTimer;

        public Client()
        {
            InitializeComponent();
            btnSendGuess.Enabled = false;
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000; // 1 giây
            countdownTimer.Tick += CountdownTimer_Tick;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            playerName = txtName.Text.Trim();
            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Vui lòng nhập tên người chơi.");
                return;
            }

            try
            {
                client = new TcpClient("127.0.0.1", 5000);
                stream = client.GetStream();

                listenThread = new Thread(ListenForMessages);
                listenThread.IsBackground = true;
                listenThread.Start();

                SendMessage($"NAME|{playerName}");
                Log($"Đã kết nối tới server với tên {playerName}");
                btnConnect.Enabled = false;
                btnSendGuess.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void ListenForMessages()
        {
            try
            {
                byte[] buffer = new byte[1024];
                int bytesRead;
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    ProcessMessage(message.Trim());
                }
            }
            catch
            {
                Log("Mất kết nối tới server.");
            }
        }

        private void btnSendGuess_Click(object sender, EventArgs e)
        {
            if (!canSend)
            {
                MessageBox.Show($"Bạn phải chờ {countdownSeconds} giây trước khi gửi tiếp.");
                return;
            }

            if (!int.TryParse(txtGuess.Text.Trim(), out int guess))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
                return;
            }

            if (guess < a || guess > b)
            {
                MessageBox.Show($"Số dự đoán phải nằm trong khoảng từ {a} đến {b}.");
                return;
            }

            if (triedNumbers.Contains(guess))
            {
                MessageBox.Show("Bạn đã dự đoán số này rồi, hãy chọn số khác.");
                return;
            }

            SendMessage($"GUESS|{guess}");
            triedNumbers.Add(guess);

            canSend = false;
            countdownSeconds = 3;
            lblCountdown.Text = $"Chờ {countdownSeconds} giây";
            countdownTimer.Start();
        }

        private void ProcessMessage(string message)
        {
            Invoke(new Action(() =>
            {
                var parts = message.Split('|');
                if (parts.Length == 0) return;

                string cmd = parts[0].ToUpper();

                if (cmd == "OK" && parts.Length == 2)
                {
                    Log(parts[1]);
                }
                else if (cmd == "RANGE" && parts.Length == 3)
                {
                    a = int.Parse(parts[1]);
                    b = int.Parse(parts[2]);
                    Log($"Phạm vi số cần đoán: từ {a} đến {b}");
                    triedNumbers.Clear();
                }
                else if (cmd == "RESULT" && parts.Length == 2)
                {
                    Log("Server: " + parts[1]);
                }
                else if (cmd == "WINNER" && parts.Length == 2)
                {
                    Log("Người thắng: " + parts[1]);
                }
                else if (cmd == "NEW_ROUND" && parts.Length == 2)
                {
                    Log(parts[1]);
                    canSend = true;
                    countdownSeconds = 3;
                    countdownTimer.Stop();
                    lblCountdown.Text = "";
                }
                else if (cmd == "GAME_OVER" && parts.Length == 2)
                {
                    Log(parts[1]);
                    SaveHistory();
                    MessageBox.Show("Game kết thúc, ứng dụng sẽ đóng.");
                    this.Close();
                }
            }));
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            countdownSeconds--;
            if (countdownSeconds <= 0)
            {
                countdownTimer.Stop();
                lblCountdown.Text = "";
                canSend = true;
            }
            else
            {
                lblCountdown.Text = $"Chờ {countdownSeconds} giây";
            }
        }

        private void SendMessage(string msg)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(msg);
                stream.Write(data, 0, data.Length);
            }
            catch
            {
                Log("Gửi dữ liệu thất bại.");
            }
        }

        private void Log(string text)
        {
            rtbLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {text}\n");
            rtbLog.ScrollToCaret();
        }

        private void chkAutoPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoPlay.Checked)
            {
                autoPlayTimer = new System.Windows.Forms.Timer();
                autoPlayTimer.Interval = 4000; // 4 giây để tránh xung đột với countdown
                autoPlayTimer.Tick += AutoPlayTimer_Tick;
                autoPlayTimer.Start();
                Log("Bật tự động chơi.");
            }
            else
            {
                autoPlayTimer?.Stop();
                autoPlayTimer = null;
                Log("Tắt tự động chơi.");
            }
        }

        private void SaveHistory()
        {
            try
            {
                string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "history.txt");
                System.IO.File.WriteAllText(path, rtbLog.Text);
                Log("Lịch sử trò chơi đã được lưu.");
            }
            catch (Exception ex)
            {
                Log("Lỗi khi lưu lịch sử: " + ex.Message);
            }
        }

        private void AutoPlayTimer_Tick(object sender, EventArgs e)
        {
            if (!canSend) return;

            int guess;
            do
            {
                guess = random.Next(a, b + 1);
            } while (triedNumbers.Contains(guess));

            txtGuess.Text = guess.ToString();
            btnSendGuess.PerformClick();
        }

    }
}
