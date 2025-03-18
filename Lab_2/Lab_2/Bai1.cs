using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Bai1: Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void bRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdl = new OpenFileDialog();
            fdl.ShowDialog();
            FileStream fs = new FileStream(fdl.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string content = sr.ReadToEnd();
            rtbContent.Text = content;
            fs.Close();
        }

        private void bWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
      
            StreamWriter sw = new StreamWriter(sfd.FileName, false);
            sw.Write(rtbContent.Text.ToUpper());
            sw.Close();
        }
    }
}
