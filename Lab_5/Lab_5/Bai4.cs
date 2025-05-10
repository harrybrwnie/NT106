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
using MailKit.Security;

namespace Lab_5
{
    public partial class Bai4: Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbGmail.Text.Trim();
            string password = tbPassword.Text.Trim();

            try
            {
                using(var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                    client.Authenticate(email, password);

                    client.Disconnect(true);
                }

                Dashboard dashboard = new Dashboard(email, password);
                dashboard.Show();
                this.Hide();
            }
            catch (MailKit.Security.AuthenticationException)
            {
                MessageBox.Show("Sai tai khoan hoac mat khau");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi ket noi");
            }
        }
    }
}
