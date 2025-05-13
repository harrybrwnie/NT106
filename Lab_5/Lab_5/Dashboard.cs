using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MimeKit;
using MailKit.Security;

namespace Lab_5
{
    public partial class Dashboard: Form
    {

        private string userEmail;
        private string userPassword;

        public Dashboard(string userEmail, string userPassword)
        {
            InitializeComponent();
            this.userEmail = userEmail;
            this.userPassword = userPassword;

            lvEmails.Columns.Add("Tiêu đề", 200);
            lvEmails.Columns.Add("Người gửi", 150);
            lvEmails.Columns.Add("Ngày", 120);
            lvEmails.View = View.Details;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadEmails();
        }

        private void LoadEmails()
        {
            try
            {
                using(var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                    client.Authenticate(userEmail, userPassword);

                    var inbox = client.Inbox;
                    inbox.Open(MailKit.FolderAccess.ReadOnly);

                    lvEmails.Items.Clear();

                    for(int i = 0; i < 20; ++i)
                    {
                        var msg = inbox.GetMessage(i);
                        var item = new ListViewItem(msg.Subject);
                        item.SubItems.Add(msg.From.ToString());
                        item.SubItems.Add(msg.Date.ToString("g"));
                        lvEmails.Items.Add(item);
                    }

                    client.Disconnect(true);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi tai email: " + ex.Message);
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            SendMail sendForm = new SendMail(userEmail, userPassword);
            sendForm.Show();
        }
    }
}
