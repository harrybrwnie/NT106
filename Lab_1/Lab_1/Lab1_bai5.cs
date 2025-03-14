using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Lab1_bai5 : Form
    {
        public Lab1_bai5()
        {
            InitializeComponent();
        }

        private void Lab1_bai5_Load(object sender, EventArgs e)
        {
            
        }

        private string XepLoai(List<double> diemList, double diemTB)
        {

            double diemThapNhat = diemList.Min();
            if (diemTB >= 8 && diemThapNhat >= 6.5) return "Gioi";
            else if (diemTB >= 6.5 && diemThapNhat >= 5) return "Kha";
            else if (diemTB >= 5 && diemThapNhat >= 3.5) return "TB";
            else if (diemTB >= 3.5 && diemThapNhat >= 2) return "Yeu";
            else return "Kem";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bXuat_Click(object sender, EventArgs e)
        {
            gbDiem.Visible = true;
            string input = tbInput.Text;
            string[] diemString = input.Split(',');
            
            List<double> diemList = new List<double>();

            int soMonPass = 0;

            for(int i = 0; i < diemString.Length; ++i)
            {
                if (double.TryParse(diemString[i].Trim(), out double diem))
                {

                    diemList.Add(diem);
                    if (i % 4 == 0 && i != 0)
                    {
                        tbDisplay.AppendText($"\nMôn {i + 1}: {diem}\t");
                    }
                    else
                    {
                        tbDisplay.AppendText($"Môn {i + 1}: {diem}\t");
                    }
                    if (diem >= 5) ++soMonPass;
                }
            }

            double diemTB = diemList.Average();
            double diemCaoNhat = diemList.Max();
            double diemThapNhat = diemList.Min();
            int soMonFail = diemString.Length - soMonPass;
            string HocLuc = XepLoai(diemList, diemTB);

            tbDiemTB.Text = Convert.ToString(diemTB);
            tbDiemCaoNhat.Text = Convert.ToString(diemCaoNhat);
            tbSoMonPass.Text = Convert.ToString(soMonPass);
            tbDiemThapNhat.Text = Convert.ToString(diemThapNhat);
            tbXepLoai.Text = Convert.ToString(HocLuc);
            tbSoMonFail.Text = Convert.ToString(soMonFail);
            
        }
    }
}
