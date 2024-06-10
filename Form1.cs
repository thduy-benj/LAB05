namespace lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai6 bai6 = new Bai6();
            bai6.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai5 bai5 = new Bai5();
            bai5.ShowDialog();
        }
    }
}