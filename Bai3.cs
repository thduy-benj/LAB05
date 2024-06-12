using System.Security.Authentication;
using MailKit.Net.Pop3;
using MailKit.Security;

namespace lab05
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void GetMail(string username, string password)
        {
            using (var pop3Client = new Pop3Client())
            {
                try
                {
                    pop3Client.Connect("pop.gmail.com", 995, SecureSocketOptions.SslOnConnect);
                    pop3Client.Authenticate(username, password);

                    tbMail.ReadOnly = true;
                    tbPass.ReadOnly = true;

                    dataGridView1.Rows.Clear();

                    int messageCount = pop3Client.GetMessageCount();
                    int startIndex = Math.Max(0, messageCount - 20); // Get the last 20 messages or less

                    for (int i = messageCount - 1; i >= startIndex; i--)
                    {
                        var message = pop3Client.GetMessage(i);

                        var from = message.From.ToString();
                        var subject = message.Subject;
                        var date = message.Date.LocalDateTime.ToString();

                        dataGridView1.Rows.Add(subject, from, date);
                    }

                    pop3Client.Disconnect(true);
                }
                catch (MailKit.Security.AuthenticationException)
                {
                    MessageBox.Show("Incorrect password");
                    tbPass.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string email = tbMail.Text.Trim();
            string password = tbPass.Text; // Đây là nơi bạn nhập mật khẩu ứng dụng

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            GetMail(email, password);
        }
    }
}
