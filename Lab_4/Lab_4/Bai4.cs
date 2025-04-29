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
using HtmlAgilityPack;
using System.IO;

namespace Lab_4
{
    public partial class Bai4: Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void Gobtn_Click(object sender, EventArgs e)
        {
            if (Uri.TryCreate(UrltxtBox.Text, UriKind.Absolute, out var uri))
                webBrowser1.Navigate(uri);
            else
                MessageBox.Show("URL không hợp lệ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            string html = webBrowser1.DocumentText;
            var srcForm = new SourceForm(html);
            srcForm.Show();
        }

        private async void Downloadbtn_Click(object sender, EventArgs e)
        {
            // A. Validate URL
            if (!Uri.TryCreate(UrltxtBox.Text, UriKind.Absolute, out var baseUri) ||
                (baseUri.Scheme != Uri.UriSchemeHttp && baseUri.Scheme != Uri.UriSchemeHttps))
            {
                MessageBox.Show("URL không hợp lệ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // B. Choose folder
            using (var fbd = new FolderBrowserDialog { Description = "Chọn thư mục lưu HTML và tài nguyên" })
            {
                if (fbd.ShowDialog() != DialogResult.OK)
                    return;

                string folder = fbd.SelectedPath;
                try
                {
                    using (var client = new WebClient())
                    {
                        client.Encoding = Encoding.UTF8;

                        // 1. Download raw HTML
                        string html = await client.DownloadStringTaskAsync(baseUri);

                        // 2. Parse HTML
                        var doc = new HtmlAgilityPack.HtmlDocument();
                        doc.LoadHtml(html);

                        // 2a. Ensure UTF-8 meta in head
                        var head = doc.DocumentNode.SelectSingleNode("//head");
                        if (head != null &&
                            doc.DocumentNode.SelectSingleNode("//meta[@charset]") == null)
                        {
                            var meta = HtmlNode.CreateNode("<meta charset=\"utf-8\" />");
                            head.PrependChild(meta);
                        }

                        // 3. Download images
                        string imgFolder = Path.Combine(folder, "images");
                        Directory.CreateDirectory(imgFolder);
                        var imgNodes = doc.DocumentNode.SelectNodes("//img[@src]");
                        if (imgNodes != null)
                        {
                            foreach (var img in imgNodes)
                            {
                                string src = img.GetAttributeValue("src", "");
                                try
                                {
                                    // Resolve URI
                                    Uri resUri = src.StartsWith("//")
                                        ? new Uri(baseUri.Scheme + ":" + src)
                                        : new Uri(baseUri, src);
                                    string fileName = Path.GetFileName(resUri.LocalPath);
                                    string localPath = Path.Combine(imgFolder, fileName);
                                    await client.DownloadFileTaskAsync(resUri, localPath);
                                    // Use forward slash for HTML paths
                                    img.SetAttributeValue("src", $"images/{fileName}");
                                }
                                catch
                                {
                                    // Ignore individual failures
                                }
                            }
                        }

                        // 4. Download CSS files
                        string cssFolder = Path.Combine(folder, "css");
                        Directory.CreateDirectory(cssFolder);
                        var cssNodes = doc.DocumentNode.SelectNodes("//link[@rel='stylesheet'][@href]");
                        if (cssNodes != null)
                        {
                            foreach (var link in cssNodes)
                            {
                                string href = link.GetAttributeValue("href", "");
                                try
                                {
                                    Uri resUri = href.StartsWith("//")
                                        ? new Uri(baseUri.Scheme + ":" + href)
                                        : new Uri(baseUri, href);
                                    string fileName = Path.GetFileName(resUri.LocalPath);
                                    string localPath = Path.Combine(cssFolder, fileName);
                                    await client.DownloadFileTaskAsync(resUri, localPath);
                                    link.SetAttributeValue("href", $"css/{fileName}");
                                }
                                catch { }
                            }
                        }

                        // 5. Download JavaScript files
                        string jsFolder = Path.Combine(folder, "js");
                        Directory.CreateDirectory(jsFolder);
                        var scriptNodes = doc.DocumentNode.SelectNodes("//script[@src]");
                        if (scriptNodes != null)
                        {
                            foreach (var script in scriptNodes)
                            {
                                string src = script.GetAttributeValue("src", "");
                                try
                                {
                                    Uri resUri = src.StartsWith("//")
                                        ? new Uri(baseUri.Scheme + ":" + src)
                                        : new Uri(baseUri, src);
                                    string fileName = Path.GetFileName(resUri.LocalPath);
                                    string localPath = Path.Combine(jsFolder, fileName);
                                    await client.DownloadFileTaskAsync(resUri, localPath);
                                    script.SetAttributeValue("src", $"js/{fileName}");
                                }
                                catch { }
                            }
                        }

                        // 6. Save updated HTML with BOM
                        string htmlPath = Path.Combine(folder, "index.html");
                        File.WriteAllText(htmlPath, doc.DocumentNode.OuterHtml, new UTF8Encoding(true));

                        MessageBox.Show($"Đã lưu HTML và tài nguyên vào: {folder}",
                            "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi download và xử lý: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
