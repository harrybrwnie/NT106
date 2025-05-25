using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGunaUI
{
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
            InitLoginUI();
        }

        private void InitLoginUI()
        {
            this.Text = "Đăng nhập";
            this.Size = new System.Drawing.Size(400, 300);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;

            var lblTitle = new Label
            {
                Text = "ĐĂNG NHẬP",
                Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold),
                AutoSize = true,
                Location = new System.Drawing.Point(140, 20)
            };

            var txtUsername = new Guna2TextBox
            {
                PlaceholderText = "Tên đăng nhập",
                Size = new System.Drawing.Size(280, 36),
                Location = new System.Drawing.Point(60, 70),
                BorderRadius = 10
            };

            var txtPassword = new Guna2TextBox
            {
                PlaceholderText = "Mật khẩu",
                Size = new System.Drawing.Size(280, 36),
                Location = new System.Drawing.Point(60, 120),
                UseSystemPasswordChar = true,
                BorderRadius = 10
            };

            var btnLogin = new Guna2Button
            {
                Text = "Đăng nhập",
                Size = new System.Drawing.Size(280, 36),
                Location = new System.Drawing.Point(60, 180),
                BorderRadius = 10
            };

            this.Controls.Add(lblTitle);
            this.Controls.Add(txtUsername);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);
        }
    }
}
