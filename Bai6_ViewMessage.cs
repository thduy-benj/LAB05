namespace lab05
{
    public partial class Bai6_ViewMessage : Form
    {
        string from, to, email, pass;
        public Bai6_ViewMessage(string html, string from, string to, string sub, string email, string pass)
        {
            InitializeComponent();
            tbFrom.Text = from;
            tbTo.Text = to;
            this.Text = sub;
            this.from = to; 
            this.to = from;
            this.pass = pass; 
            this.email = email;
            InitBrowser(html);
        }

        public async void InitBrowser(string s)
        {
            await initizated();
            webView.CoreWebView2.NavigateToString(s);
        }

        private async Task initizated()
        {
            await webView.EnsureCoreWebView2Async(null);
        }
    }
}
