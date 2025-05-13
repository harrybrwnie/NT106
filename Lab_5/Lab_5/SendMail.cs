using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class SendMail: Form
    {

        private string userEmail;
        private string userPassword;
        private List<string> attachedFiles = new List<string>();

        public SendMail(string userEmail, string userPassword)
        {
            InitializeComponent();
            this.userEmail = userEmail;
            this.userPassword = userPassword;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                attachedFiles.Clear();
                attachedFiles.AddRange(ofd.FileNames);

                lvAttach.Items.Clear();
                foreach(var file in attachedFiles)
                {
                    lvAttach.Items.Add(Path.GetFileName(file));
                }
            }
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
            string to = tbTo.Text.Trim();
            string subject = tbSubject.Text.Trim();
            string body = tbBody.Text;

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(userEmail);
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                foreach(var file in attachedFiles)
                {
                    mail.Attachments.Add(new Attachment(file));
                }

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(userEmail, userPassword);
                smtp.Send(mail);

                MessageBox.Show("Gui email thanh cong");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi gui email" + ex.Message);
            }
        }
    }
}
