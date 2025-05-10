using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Bai3: Form
    {
        private List<string> attachedFilePaths = new List<string>();

        public Bai3()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "Chon file dinh kem";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                attachedFilePaths.Clear();
                attachedFilePaths.AddRange(ofd.FileNames);

                lstAttachments.Items.Clear();
                foreach(var path in attachedFilePaths)
                {
                    lstAttachments.Items.Add(Path.GetFileName(path));
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string from = tbFrom.Text.Trim();
            string to = tbTo.Text.Trim();
            string password = tbPassword.Text.Trim();
            string subject = tbSubject.Text.Trim();
            string body = tbBody.Text;

            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(from);
                message.To.Add(to);
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;

                foreach (var path in attachedFilePaths)
                {
                    message.Attachments.Add(new Attachment(path));
                }

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(from, password);
                smtpClient.Send(message);

                MessageBox.Show("Gui mail thanh cong");

                tbPassword.Clear();
                tbFrom.Clear();
                tbTo.Clear();
                tbSubject.Clear();
                tbBody.Clear();
                attachedFilePaths.Clear();
                lstAttachments.ClearSelected();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi gui mail" + ex.Message);
            }
        }
    }
}
