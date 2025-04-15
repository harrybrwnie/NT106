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
    public partial class Bai5: Form
    {
        public Bai5()
        {
            InitializeComponent();
            SetupListView();
        }
        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Tên File", 250);
            listView1.Columns.Add("Kích thước", 100);
            listView1.Columns.Add("Đuôi mở rộng", 100);
            listView1.Columns.Add("Ngày tạo", 150);
        }
        private void HienThiDanhSachFile(string thuMuc)
        {
            if (!Directory.Exists(thuMuc))
            {
                MessageBox.Show("Thư mục không tồn tại hoặc đã bị xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listView1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(thuMuc);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                ListViewItem item = new ListViewItem(file.Name);
                item.SubItems.Add(file.Length.ToString() + " bytes");
                item.SubItems.Add(file.Extension);
                item.SubItems.Add(file.CreationTime.ToString());
                listView1.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdl = new FolderBrowserDialog())
            {
                fdl.Description = "Chọn thư mục để duyệt";
                fdl.ShowNewFolderButton = false;
                if(fdl.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(fdl.SelectedPath))
                    {
                        return;
                    }
                    txtThuMuc.Text = fdl.SelectedPath;
                    HienThiDanhSachFile(fdl.SelectedPath);
                }
            }
        }
    }
}
