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
    public partial class Bai1: Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        private string GetHTML(string szURL)
        {
            WebRequest request = WebRequest.Create(szURL);
            using (WebResponse response = request.GetResponse())
            using (Stream data = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(data))
            {
                return reader.ReadToEnd();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DatatxtBox.Clear();
            string url = urltxtBox.Text;
            if(string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Vui long nhap dung url");
                return;
            }

            try
            {
                string htmlContent = GetHTML(url);
                DatatxtBox.Text = htmlContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khi tai trang: " + ex.Message);
            }
        }
        
    }
}
