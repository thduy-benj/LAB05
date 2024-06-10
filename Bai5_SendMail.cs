using MimeKit;
using MailKit.Net.Smtp;

namespace lab05
{
    public partial class Bai5_SendMail : Form
    {
        SmtpClient smtpClient = new SmtpClient();
        public Bai5_SendMail()
        {
            InitializeComponent();
        }

        private void Bai5_SendMail_Load(object sender, EventArgs e)
        {
            tbFrom.Text = "21520780@gm.uit.edu.vn";
            tbTo.Text = "21520780@gm.uit.edu.vn";

            smtpClient.Connect("smtp.gmail.com", 465, true);
            smtpClient.Authenticate(tbFrom.Text, "rgow rmeq xxuk rlpc");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(tbName.Text, tbFrom.Text));
                message.To.Add(new MailboxAddress("", tbTo.Text));
                message.Subject = "Đóng góp món ăn";
                message.Body = new TextPart("plain")
                {
                    Text = rtbBody.Text
                };
                smtpClient.Send(message);
                MessageBox.Show("đã gửi thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi gửi");
            }

        }
    }
}
