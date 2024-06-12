using System.Net.Mail;
using System.Net;

namespace lab05
{
    public partial class Bai1 : Form
    {
        private const string PlaceholderFrom = "From";
        private const string PlaceholderTo = "To";
        private const string PlaceholderSubject = "Subject";
        private const string PlaceholderPassword = "Password";
        public Bai1()
        {
            InitializeComponent();
            SetPlaceholders();
        }
        private void SetPlaceholders()
        {
            SetPlaceholder(txtFrom, PlaceholderFrom);
            SetPlaceholder(txtTo, PlaceholderTo);
            SetPlaceholder(txtSubject, PlaceholderSubject);
            SetPlaceholder(textBox1, PlaceholderPassword);
        }

        private void SetPlaceholder(System.Windows.Forms.TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };
            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }
       
        private void btnSend_Click(object sender, EventArgs e)
        {
            string from = txtFrom.Text.Trim();
            string to = txtTo.Text.Trim();
            string subject = txtSubject.Text.Trim();
            string body = rtbBody.Text;
            string password = textBox1.Text.Trim();

            // Validate email inputs
            if (from == PlaceholderFrom || to == PlaceholderTo || subject == PlaceholderSubject || password == PlaceholderPassword)
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(from),
                    Subject = subject,
                    Body = body
                };
                mailMessage.To.Add(to);

                using (var smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential(from, password);
                    smtpClient.EnableSsl = true;

                    smtpClient.Send(mailMessage);
                }

                MessageBox.Show("ĐÃ GỬI THÀNH CÔNG!", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show($"SMTP Error: {smtpEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
