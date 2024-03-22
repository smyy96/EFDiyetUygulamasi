using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace efdiyet
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();

        }

        private void RoundTextBox1(System.Windows.Forms.TextBox txtEmail, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(txtEmail.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(txtEmail.Width - radius, txtEmail.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, txtEmail.Height - radius, radius, radius, 90, 90);
            txtEmail.Region = new Region(path);
        }
        private void RoundTextBox2(System.Windows.Forms.TextBox txtSifre, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(txtSifre.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(txtSifre.Width - radius, txtSifre.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, txtSifre.Height - radius, radius, radius, 90, 90);
            txtSifre.Region = new Region(path);
        }

        private void RoundButton1(System.Windows.Forms.Button btnGirisYap, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnGirisYap.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnGirisYap.Width - radius, btnGirisYap.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnGirisYap.Height - radius, radius, radius, 90, 90);
            btnGirisYap.Region = new Region(path);
        }
        private void RoundButton2(System.Windows.Forms.Button btnKayitOl, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnKayitOl.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnKayitOl.Width - radius, btnKayitOl.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnKayitOl.Height - radius, radius, radius, 90, 90);
            btnKayitOl.Region = new Region(path);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            RoundTextBox1(txtEmail, 30);
            RoundTextBox2(txtSifre, 30);
            RoundButton1(btnGirisYap, 30);
            RoundButton2(btnKayitOl, 30);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}