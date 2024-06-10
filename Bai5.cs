using MailKit;
using MailKit.Net.Imap;
using MimeKit;

namespace lab05
{
    public partial class Bai5 : Form
    {
        ImapClient imapClient = new ImapClient();
        ImageList imageList = new ImageList();
        List<KeyValuePair<string, Image>> listMonAn = new List<KeyValuePair<string, Image>>();
        public Bai5()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bai5_SendMail bai5_SendMail = new Bai5_SendMail();
            bai5_SendMail.ShowDialog();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {
            btnLoad.Enabled = false;
            btnAdd.Enabled = false;
            btnRandom.Enabled = false;
            lvMonAn.Enabled = false;

            tbEmail.Text = "21520780@gm.uit.edu.vn";
            tbPassword.Text = "rgow rmeq xxuk rlpc";
            tbPassword.PasswordChar = '*';

            imageList.ImageSize = new Size(100, 100);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            imapClient.Connect("imap.gmail.com", 993, true);
            try
            {
                imapClient.Authenticate(tbEmail.Text, tbPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btnSignIn.Enabled = false;
            btnLoad.Enabled = true;
            btnAdd.Enabled = true;
            btnRandom.Enabled = true;
            lvMonAn.Enabled = true;
            tbEmail.Enabled = false;
            tbPassword.Enabled = false;

            var inbox = imapClient.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            lvMonAn.Items.Clear();
            listMonAn.Clear();
            for (int i = inbox.Count; i >= inbox.Count - 20; i--)
            {
                try
                {
                    var message = inbox.GetMessage(i);
                    if (message.Subject.Equals("Đóng góp món ăn"))
                    {
                        var body = message.BodyParts.OfType<TextPart>().FirstOrDefault();

                        if (body == null)
                        {
                            MessageBox.Show("body is null !!");
                            return;
                        }
                        string[] lines = body.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < lines.Length; j += 2)
                        {
                            string monAn = lines[j];
                            string hinhAnh = lines[j + 1];
                            Image image = DownloadImageFromUrlAsync(hinhAnh);
                            imageList.Images.Add(image);
                            ListViewItem item = new ListViewItem(monAn, imageList.Images.Count - 1);
                            listMonAn.Add(new KeyValuePair<string, Image>(monAn, image));
                            lvMonAn.Items.Add(item);
                        }
                    }
                }
                catch { }
            }

            lvMonAn.LargeImageList = imageList;
        }

        public Image DownloadImageFromUrlAsync(string imageUrl)
        {
            using (var httpClient = new HttpClient())
            {
                var imageData = httpClient.GetByteArrayAsync(imageUrl).Result;
                using (var ms = new MemoryStream(imageData))
                {
                    var image = Image.FromStream(ms);
                    return image;
                }
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int index = new Random().Next(0, listMonAn.Count);
            Bai5_ViewMonAn bai5_ViewMonAn = new Bai5_ViewMonAn(listMonAn[index].Key, listMonAn[index].Value);
            bai5_ViewMonAn.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var inbox = imapClient.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            lvMonAn.Items.Clear();
            listMonAn.Clear();
            for (int i = inbox.Count; i >= inbox.Count - 20; i--)
            {
                try
                {
                    var message = inbox.GetMessage(i);
                    if (message.Subject.Equals("Đóng góp món ăn"))
                    {
                        var body = message.BodyParts.OfType<TextPart>().FirstOrDefault();

                        if (body == null)
                        {
                            MessageBox.Show("body is null !!");
                            return;
                        }
                        string[] lines = body.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < lines.Length; j += 2)
                        {
                            string monAn = lines[j];
                            string hinhAnh = lines[j + 1];
                            Image image = DownloadImageFromUrlAsync(hinhAnh);
                            imageList.Images.Add(image);
                            ListViewItem item = new ListViewItem(monAn, imageList.Images.Count - 1);
                            listMonAn.Add(new KeyValuePair<string, Image>(monAn, image));
                            lvMonAn.Items.Add(item);
                        }
                    }
                }
                catch { }
            }

            lvMonAn.LargeImageList = imageList;
            lvMonAn.SmallImageList = imageList;
        }
    }
}
