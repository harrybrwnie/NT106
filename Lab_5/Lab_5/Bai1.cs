using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Lab_5
{
    public partial class Bai1: Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTo.Text) ||
                string.IsNullOrWhiteSpace(tbSubject.Text) ||
                string.IsNullOrWhiteSpace(tbBody.Text))
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                return;
            }
            string from = tbFrom.Text.Trim();
            string to = tbTo.Text.Trim();
            string password = tbPassword.Text.Trim();
            string subject = tbSubject.Text.Trim();
            string body = tbBody.Text.Trim();

            try
            {
                using(SmtpClient smtpClient = new SmtpClient("127.0.0.1", 25))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(from, password);
                    smtpClient.EnableSsl = false;

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(from);
                    mail.To.Add(to);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = false;

                    smtpClient.Send(mail);

                    MessageBox.Show("Gui mail thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbPassword.Clear();
                    tbFrom.Clear();
                    tbTo.Clear();
                    tbSubject.Clear();
                    tbBody.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Loi gui mail: {ex.Message}", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
