namespace LAB05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai1 b1 = new bai1();
            b1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bai2 b2 = new bai2();
            b2.Show();
        }
    }
}
