using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void readFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string name = ofd.SafeFileName.ToString();
            url.Text = fs.Name.ToString();
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            //Count number of characters in a file
            charCount.Text = content.Length.ToString();
            //Count number of lines in a file
            content = content.Replace("\r\n", "\r");
            lineCount.Text = richTextBox1.Lines.Count().ToString();
            content = content.Replace('\r', ' ');
            //Count number of words in a file
            string[] source = content.Split(new char[] {'.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            wordCount.Text = source.Count().ToString();
            tenFile.Text = name;
            sr.Close();
        }
    }
}
