using MailKit;
using MailKit.Net.Imap;
using MimeKit;

namespace lab05
{
    public partial class Bai6 : Form
    {
        ImapClient ImapClient = new ImapClient();

        public Bai6()
        {
            InitializeComponent();
        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            btnLogOut.Visible = false;
            btnRefresh.Visible = false;
            btnSend.Visible = false;

            tbIMAP.Text = "imap.gmail.com";
            tbImapPort.Text = "993";

            tbSMTP.Text = "smtp.gmail.com";
            tbSmtpPort.Text = "465";

            tbEmail.Text = "email";
            tbPassword.Text = "password";
            tbPassword.PasswordChar = '*';
        }

        private void SetStatus(bool status)
        {
            btnRefresh.Visible = status;
            btnSend.Visible = status;
            btnLogOut.Visible = status;

            btnLogin.Visible = !status;
            tbEmail.Enabled = !status;
            tbPassword.Enabled = !status;
            tbIMAP.Enabled = !status;
            tbImapPort.Enabled = !status;
            tbSMTP.Enabled = !status;
            tbSmtpPort.Enabled = !status;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SetStatus(true);
            ImapClient.Connect(tbIMAP.Text, int.Parse(tbImapPort.Text), true);
            try
            {
                ImapClient.Authenticate(tbEmail.Text, tbPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            var inbox = ImapClient.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            lvEmails.Items.Clear();
            for (int i = inbox.Count; i > inbox.Count - 19; i--)
            {
                try
                {
                    var message = inbox.GetMessage(i);
                    string[] subItem = { message.From.ToString(), message.Subject.ToString(), message.Date.ToString("f") };
                    lvEmails.Items.Add(i.ToString()).SubItems.AddRange(subItem);
                }
                catch { }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ImapClient.Disconnect(true);
            ImapClient.Connect(tbIMAP.Text, int.Parse(tbImapPort.Text), true);
            try
            {
                ImapClient.Authenticate(tbEmail.Text, tbPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var inbox = ImapClient.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            lvEmails.Items.Clear();
            for (int i = inbox.Count; i > inbox.Count - 19; i--)
            {
                try
                {
                    var message = inbox.GetMessage(i);
                    string[] subItem = { message.From.ToString(), message.Subject.ToString(), message.Date.ToString("f") };
                    lvEmails.Items.Add(i.ToString()).SubItems.AddRange(subItem);
                }
                catch { }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Bai6_SendMail bai6_SendMail = new Bai6_SendMail(tbSMTP.Text, tbSmtpPort.Text, tbEmail.Text, tbPassword.Text, false, tbEmail.Text, tbEmail.Text);
            bai6_SendMail.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SetStatus(false);
            ImapClient.Disconnect(true);
            lvEmails.Items.Clear();
        }

        private void lvEmails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var inbox = ImapClient.Inbox;
            var senderList = (ListView)sender;
            var clickedItem = senderList.HitTest(e.Location).Item;
            if (clickedItem != null)
            {
                var message = inbox.GetMessage(int.Parse(clickedItem.Text));
                var body = message.BodyParts.OfType<TextPart>().FirstOrDefault(x => x.IsHtml);
                if (body == null)
                {
                    MessageBox.Show("body is null !!");
                    return;
                }
                Bai6_ViewMessage bai6_ViewMessage = new Bai6_ViewMessage(body.Text, message.From.ToString(), tbEmail.Text, message.Subject, tbEmail.Text, tbPassword.Text);
                bai6_ViewMessage.ShowDialog();
            }
        }
    }
}
