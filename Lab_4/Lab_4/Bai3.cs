using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
            urltxtBox.Text = "http://uit.edu.vn";
            filePathtxtBox.Text = @"D:\uit.html";
        }

        private async void Downloadbtn_Click(object sender, EventArgs e)
        {
            // 1. Lay va validate input
            string url = urltxtBox.Text;
            string filePath = filePathtxtBox.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Vui long nhap URL", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Uri.TryCreate(url, UriKind.Absolute, out var uri) ||
                (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
            {
                MessageBox.Show("URL khong hop le", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Vui lòng nhập đường dẫn lưu file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string folder = Path.GetDirectoryName(filePath);
            if (string.IsNullOrWhiteSpace(folder) || !Directory.Exists(folder))
            {
                MessageBox.Show("Thư mục lưu file không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Downloadbtn.Enabled = false;
            try
            {
                using (var client = new WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    string html = await client.DownloadStringTaskAsync(uri);

                    File.WriteAllText(filePath, html, Encoding.UTF8);
                    responserichtxtBox.Text = html;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Downloadbtn.Enabled = true;
            }
        }
    }
}
