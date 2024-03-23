using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlarg
{
    public partial class AdminEkDegisimler : Form
    {
        public AdminEkDegisimler()
        {
            InitializeComponent();
        }
        private void RoundButton1(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnOgunEkle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnOgunEkle.Width - radius, btnOgunEkle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnOgunEkle.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton2(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnOgunSil.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnOgunSil.Width - radius, btnOgunSil.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnOgunSil.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton3(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnOgunGuncelle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnOgunGuncelle.Width - radius, btnOgunGuncelle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnOgunGuncelle.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton4(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnKategoriEkle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnKategoriEkle.Width - radius, btnKategoriEkle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnKategoriEkle.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton5(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnKategoriSil.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnKategoriSil.Width - radius, btnKategoriSil.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnKategoriSil.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton6(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnKategoriGuncelle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnKategoriGuncelle.Width - radius, btnKategoriGuncelle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnKategoriGuncelle.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton7(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnBeDeEkle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnBeDeEkle.Width - radius, btnBeDeEkle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnBeDeEkle.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton8(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnBeDeSil.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnBeDeSil.Width - radius, btnBeDeSil.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnBeDeSil.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton9(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnBeDeGuncelle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnBeDeGuncelle.Width - radius, btnBeDeGuncelle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnBeDeGuncelle.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundDGV1(System.Windows.Forms.DataGridView dataGridView, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(dgvOgunEkle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(dgvOgunEkle.Width - radius, dgvOgunEkle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, dgvOgunEkle.Height - radius, radius, radius, 90, 90);
            dataGridView.Region = new Region(path);
        }
        private void RoundDGV2(System.Windows.Forms.DataGridView dataGridView, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(dgvKategoriEkle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(dgvKategoriEkle.Width - radius, dgvKategoriEkle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, dgvKategoriEkle.Height - radius, radius, radius, 90, 90);
            dataGridView.Region = new Region(path);
        }
        private void RoundDGV3(System.Windows.Forms.DataGridView dataGridView, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(dgvBeDe.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(dgvBeDe.Width - radius, dgvBeDe.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, dgvBeDe.Height - radius, radius, radius, 90, 90);
            dataGridView.Region = new Region(path);
        }
        




        private void AdminEkDegisimler_Load(object sender, EventArgs e)
        {
            RoundButton1(btnOgunEkle, 30);
            RoundButton2(btnOgunSil, 30);
            RoundButton3(btnOgunGuncelle, 30);
            RoundButton4(btnKategoriEkle, 30);
            RoundButton5(btnKategoriSil, 30);
            RoundButton6(btnKategoriGuncelle, 30);
            RoundButton7(btnBeDeEkle, 30);
            RoundButton8(btnBeDeSil, 30);
            RoundButton9(btnBeDeGuncelle, 30);
            RoundDGV1(dgvOgunEkle, 20);
            RoundDGV1(dgvKategoriEkle, 20);
            RoundDGV1(dgvBeDe, 20);
          
        }

    }
}
