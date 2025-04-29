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
    public partial class Bai2: Form
    {
        public Bai2()
        {
            InitializeComponent();
            urltxtBox.Text = "http://www.contoso.com/PostAccepter.aspx";
        }

        private async void Postbtn_Click(object sender, EventArgs e)
        {
            try
            {
                responserichtxtBox.Clear();
                string url = urltxtBox.Text.Trim();
                string postData = contenttxtBox.Text;

                //Convert du lieu thanh mang byte
                byte[] dataBytes = Encoding.UTF8.GetBytes(postData);

                //Tao request voi phuong thuc POST
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";

                //Thiet lap content type
                request.ContentType = "application/x-www-form-urlencoded";
                //Thiet lap content length
                request.ContentLength = dataBytes.Length;
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64)";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                request.Headers.Add("Accept-Language", "en-US,en;q=0.5");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                //Ghi du lieu vao request stream
                using (Stream reqStream = await request.GetRequestStreamAsync())
                {
                   await reqStream.WriteAsync(dataBytes, 0, dataBytes.Length);
                }

                //Nhan response va doc ve
                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                using (Stream respStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(respStream, Encoding.UTF8))
                {
                    string text = await reader.ReadToEndAsync();
                    responserichtxtBox.Text = text;
                }
            }
            catch (WebException wex)
            {
                using (var resp = wex.Response as HttpWebResponse)
                {
                    responserichtxtBox.Text = $"Error: {wex.Message}\r\nStatus: {resp?.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                responserichtxtBox.Text = "Exception: " + ex.Message;
            }
        }
    }
}
