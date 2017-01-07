using System;
using System.Net;
using System.Windows.Forms;

namespace UrlDownloader
{
    public partial class SimpleUrlDownloader : Form
    {
        public SimpleUrlDownloader()
        {
            InitializeComponent();
        }

        private void dlButton_Click(object sender, EventArgs e)
        {
            if (dlURLBox.Text != "")
            {
                try
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        WebClient client = new WebClient();
                        client.DownloadProgressChanged += (snd, evn) => { dlProgBar.Value = evn.ProgressPercentage; };
                        client.DownloadFileCompleted += (snd, evn) => { MessageBox.Show("File downloaded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); };
                        client.DownloadFileAsync(new Uri(dlURLBox.Text), dialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Url cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
