using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

private void readFile_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        if (ofd.ShowDialog() == DialogResult.OK)  // Kiểm tra nếu đã chọn file
        {
            try
            {
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                {
                    string content = sr.ReadToEnd().Trim();  // Xóa khoảng trắng dư thừa
                    richTextBox1.Text = content;
                    fileName.Text = ofd.SafeFileName;
                    url.Text = ofd.FileName;
                    charCount.Text = content.Length.ToString();
                    if (string.IsNullOrEmpty(content))
                    {
                       MessageBox.Show("File trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                        // Đếm số dòng chính xác
                        string[] lines = content.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    lineCount.Text = lines.Length.ToString();

                    // Tìm tất cả các từ (bao gồm số thập phân)
                    string pattern = @"\b\d+\.\d+\b|\b\w+\b";  // Nhận diện số thập phân và từ thông thường
                    MatchCollection matches = Regex.Matches(content, pattern);

                    wordCount.Text = matches.Count.ToString();  // Đếm số từ chính xác
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message);
            }
        }
    }



}
}
