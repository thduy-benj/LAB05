using MailKit.Net.Smtp;
using MimeKit;

namespace lab05
{
    public partial class Bai6_SendMail : Form
    {
        SmtpClient smtpClient = new SmtpClient();
        string mailto = string.Empty;
        public Bai6_SendMail(string smtpHost, string smtpPort, string email, string password, bool isreply, string from, string to)
        {
            InitializeComponent();
            smtpClient.Connect(smtpHost, int.Parse(smtpPort), true);
            try
            {
                smtpClient.Authenticate(email, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            tbFrom.Text = from;
            tbFrom.Enabled = false;

            if (isreply)
            {
                label6.Visible = false;
                tbFilePath.Visible = false;
                btnBrowse.Visible = false;
                content.Height = 360;
                this.Text = "Reply Mail";
                tbFrom.Text = to;
                mailto = to.Split("<")[1].Split(">")[0].Trim();
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = ofd.FileName;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(tbName.Text, tbFrom.Text));
            if (mailto == "") mailto = tbTo.Text;
            message.To.Add(new MailboxAddress("", mailto));
            message.Subject = tbSub.Text;
            string bodyType = "plain";
            if (cbHTML.Checked)
            {
                bodyType = "HTML";
            }
            var builder = new BodyBuilder();
            builder.TextBody = content.Text;
            if (tbFilePath.Text != "")
            {
                builder.Attachments.Add(tbFilePath.Text);
            }
            message.Body = new TextPart(bodyType);
            message.Body = builder.ToMessageBody();
            smtpClient.Send(message);
            MessageBox.Show("Đã gửi thư xong!");
        }
    }
}
