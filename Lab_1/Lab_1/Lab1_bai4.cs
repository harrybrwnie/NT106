using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab_1
{
    public partial class Lab1_bai4 : Form
    {
        public Lab1_bai4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool IsBinary(string input)
            {
                return input.All(c => c == '0' || c == '1');
            }
            bool IsHexaDecimal(string input)
            {
                return input.All(c => (c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F'));
            }
            int GetBaseFromComboBox(ComboBox comboBox)
            {
                string? selected = comboBox.SelectedItem?.ToString();
                switch (selected)
                {
                    case "Decimal":
                        return 10;
                    case "Binary":
                        return 2;
                    case "Hexadecimal":
                        return 16;
                    default:
                        return 0;
                }
            }
            int baseFrom = GetBaseFromComboBox(comboBox1);
            int baseTo = GetBaseFromComboBox(comboBox2);
            BigInteger number;
            if (BigInteger.TryParse(textBox1.Text, out number) || (IsHexaDecimal(textBox1.Text) && baseFrom == 16))
            {
                string output = "";
                if (baseFrom == 0 || baseTo == 0)
                {
                    MessageBox.Show("Vui lòng chọn hệ cơ số!");
                    return;
                }
                if (baseFrom == 2)
                {
                    if (!IsBinary(textBox1.Text))
                    {
                        MessageBox.Show("Số không hợp lệ!");
                        return;
                    }
                    if (baseTo == 10)
                    {
                        output = Convert.ToInt64(textBox1.Text, 2).ToString();
                    }
                    else if (baseTo == 16)
                    {
                        output = Convert.ToString(Convert.ToInt64(textBox1.Text, 2), 16).ToUpper();
                    }
                    else if (baseFrom == baseTo)
                    {
                        output = textBox1.Text;
                    }
                }
                else if (baseFrom == 10)
                {
                    if(baseTo == 2)
                    {
                        output = Convert.ToString((long)number, 2);
                    }
                    else if (baseTo == 16)
                    {
                        output = Convert.ToString((long)number, 16).ToUpper();
                    }
                    else if (baseFrom == baseTo)
                    {
                        output = textBox1.Text;
                    }
                }
                else if (baseFrom == 16)
                {
                    if (!IsHexaDecimal(textBox1.Text))
                    {
                        MessageBox.Show("Nhập sai định dạng hệ thập lục phân!");
                        return;
                    }
                    else if (baseTo == 10)
                    {
                        output = Convert.ToInt64(textBox1.Text, 16).ToString();
                    }
                    else if (baseTo == 2)
                    {
                        output = Convert.ToString(Convert.ToInt64(textBox1.Text, 16), 2);
                    }
                    else if (baseFrom == baseTo)
                    {
                        output = textBox1.Text;
                    }
                }
                textBox2.Text = output;
            }
            else
            {
                MessageBox.Show("Số không hợp lệ!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
