namespace lab05
{
    public partial class Bai5_ViewMonAn : Form
    {
        public Bai5_ViewMonAn(string monAn, Image image)
        {
            InitializeComponent();
            label1.Text = monAn;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = image;
        }
    }
}
