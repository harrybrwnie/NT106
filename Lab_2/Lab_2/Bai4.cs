using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Bai4: Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        [Serializable]
        class HocVien
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public string SDT { get; set; }
            public float DiemToan { get; set; }
            public float DiemVan { get; set; }
            public float DiemTB => (DiemToan + DiemVan) / 2;

            public override string ToString()
            {
                return $"{MSSV}\n{SDT}\n{DiemToan}\n{DiemVan}\n{DiemTB}\n";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ!");
                return;
            }

            // Tách input theo dòng (xuống dòng "\n")
            string[] parts = input.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Kiểm tra có đúng 5 dòng không
            if (parts.Length != 5)
            {
                MessageBox.Show("Vui lòng nhập đúng 5 dòng: MSSV, Họ Tên, SDT, Điểm Toán, Điểm Văn");
                return;
            }

            // Kiểm tra MSSV có đúng 8 số không
            if (!Regex.IsMatch(parts[0], @"^\d{8}$"))
            {
                MessageBox.Show("MSSV phải có đúng 8 chữ số!");
                return;
            }
            if (!Regex.IsMatch(parts[2], @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số và không chứa ký tự khác!");
                return;
            }

            // Kiểm tra Điểm Toán có hợp lệ không
            if (!float.TryParse(parts[3], out float diemToan) || diemToan < 0 || diemToan > 10)
            {
                MessageBox.Show("Điểm Toán phải là số thực trong khoảng 0 đến 10!");
                return;
            }

            // Kiểm tra Điểm Văn có hợp lệ không
            if (!float.TryParse(parts[4], out float diemVan) || diemVan < 0 || diemVan > 10)
            {
                MessageBox.Show("Điểm Văn phải là số thực trong khoảng 0 đến 10!");
                return;
            }

            try
            {
                HocVien hv = new HocVien()
                {
                    MSSV = parts[0],
                    HoTen = parts[1],
                    SDT = parts[2],
                    DiemToan = diemToan,
                    DiemVan = diemVan
                };

                // Lưu vào file bằng BinaryFormatter (input.dat)
                using (FileStream fs = new FileStream("input.dat", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, hv);
                }

                // Lưu vào file input.txt (có thể đọc được)
                File.WriteAllText("input.txt", $"{hv.MSSV}\n{hv.HoTen}\n{hv.SDT}\n{hv.DiemToan}\n{hv.DiemVan}");
                File.WriteAllText("output.txt", $"{hv.MSSV}\n{hv.HoTen}\n{hv.SDT}\n{hv.DiemToan}\n{hv.DiemVan}\n{hv.DiemTB}");

                MessageBox.Show("Lưu dữ liệu thành công vào input.dat, input.txt, và output.txt!");
                tbInput.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



        private void bXuat_Click(object sender, EventArgs e)
        {
            tbInput.ReadOnly = true;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn file để mở",
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedFile = openFileDialog.FileName;
                    string content = File.ReadAllText(selectedFile);
                    tbInput.Text = content;
                    MessageBox.Show($"Đã đọc nội dung từ {selectedFile}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đọc file: " + ex.Message);
                }
            }
        }

        private void bXoa_Click(object sender, EventArgs e)
         
        {
            tbInput.Clear();
            tbInput.ReadOnly = false;
        }
    }
}
