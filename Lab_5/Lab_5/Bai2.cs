using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Bai2: Form
    {
        public Bai2()
        {
            InitializeComponent();
            lvEmails.Columns.Add("Tiêu đề", 200);
            lvEmails.Columns.Add("Người gửi", 150);
            lvEmails.Columns.Add("Ngày", 120);
            lvEmails.View = View.Details;
            tbTotal.ReadOnly = true;
            tbRecent.ReadOnly = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();

            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect("127.0.0.1", 143, MailKit.Security.SecureSocketOptions.None);

                    try
                    {
                        client.Authenticate(email, password);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Sai tai khoan hoac mat khau");
                        return;
                    }

                    tbEmail.Clear();
                    tbPassword.Clear();
                    tbRecent.Clear();
                    tbTotal.Clear();

                    var inbox = client.Inbox;
                    inbox.Open(MailKit.FolderAccess.ReadOnly);

                    tbTotal.Text = inbox.Count.ToString();

                    tbRecent.Text = inbox.Recent.ToString();

                    lvEmails.Items.Clear();

                    for(int i = 0; i < inbox.Count; ++i)
                    {
                        var message = inbox.GetMessage(i);
                        var item = new ListViewItem(message.Subject);
                        item.SubItems.Add(message.From.ToString());
                        item.SubItems.Add(message.Date.ToString("g"));
                        lvEmails.Items.Add(item);
                    }

                    client.Disconnect(true);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi khi tai mail" + ex.Message);
            }
        }
    }
}
