using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Bai3: Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void readFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            readTextBox.Text = content;
            fs.Close();
        }

        private void mathbtn_Click(object sender, EventArgs e)
        {
            string[] lines = readTextBox.Lines;
            foreach(string line in lines)
            {
                string expression = line.Trim();
                if (string.IsNullOrEmpty(expression)) continue;

                try
                {
                    object result = new DataTable().Compute(expression, null);
                    writeTextBox.AppendText($"{expression} = {result}\n");
                }
                catch
                {
                    MessageBox.Show("Lỗi!");
                    readTextBox.Clear();
                    writeTextBox.Clear();
                    return;
                }
            }
        }

        private void writeFilebtn_Click(object sender, EventArgs e)
        {
            string filePath = "output.txt";
            try
            {
                using(StreamWriter sw = new StreamWriter(filePath, false))
                {
                    sw.Write(writeTextBox.Text);
                }

                MessageBox.Show("Đã tạo và lưu thành công vào output.txt", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Lỗi khi tạo file", "Lỗi", MessageBoxButtons.OK);
            }
        }


    }
}
