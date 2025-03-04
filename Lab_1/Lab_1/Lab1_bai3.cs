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
    public partial class Lab1_bai3 : Form
    {
        public Lab1_bai3()
        {
            InitializeComponent();
        }

        private void bThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bXoa_Click(object sender, EventArgs e)
        {
            strNum.Clear();
        }

        private void bDoc_Click(object sender, EventArgs e)
        {
            int num;
            if(!int.TryParse(strNum.Text, out num))
            {
                MessageBox.Show("Nhap so nguyen");
                return;
            }

            string[] DonVi = {"không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"};
            string[] Chuc = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

        
            if(num == 0)
            {
                strKQ.Text = "không";
            }
            int tram = num / 100;
            int chuc = (num % 100) / 10;
            int donvi = num % 10;

            string res = "";
            if(tram > 0)
            {
                res += DonVi[tram] + " trăm";
                if (chuc == 0 && donvi > 0) res += " lẻ";
            }
            if(chuc > 0)
            {
                if (res != "") res += " ";
                res += Chuc[chuc];
            }
            if(donvi > 0)
            {
                if(chuc > 1)
                {
                    if (donvi == 1) res += " mốt";
                    else if (donvi == 5) res += " lăm";
                    else res += " " + DonVi[donvi];
                }
                else if(chuc == 1)
                {
                    res += " " + DonVi[donvi];
                }
                else
                {
                    res += " " + DonVi[donvi];
                }
            }
            strKQ.Text = res;
        }
    }
}
