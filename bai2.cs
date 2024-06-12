using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB05
{
    public partial class bai2 : Form
    {
        private int totalEmailsRead = 0;

        public bai2()
        {
            InitializeComponent();
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("You need to enter both informtion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LoadEmails(email, password);
            }

        }
        private async Task LoadEmails(string email, string password)
        {
            try
            {
                using (var imapClient = new ImapClient())
                {
                    imapClient.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                    await imapClient.ConnectAsync("imap.gmail.com", 993, true);
                    await imapClient.AuthenticateAsync(email, password);

                    var inbox = imapClient.Inbox;
                    await inbox.OpenAsync(FolderAccess.ReadOnly);

                    dataGridView1.Rows.Clear();

                    int totalEmails = inbox.Count;
                    lbTotal.Text = $"Total Emails: {totalEmails}";

                    for (int i = 0; i < totalEmails; i++)
                    {
                        var message = await inbox.GetMessageAsync(i);
                        dataGridView1.Rows.Add(message.Subject, message.From.ToString(), message.Date.DateTime);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tăng biến đếm khi một thư được đọc
            totalEmailsRead++;
            lbRecent.Text = $"Recent Emails: {totalEmailsRead}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
