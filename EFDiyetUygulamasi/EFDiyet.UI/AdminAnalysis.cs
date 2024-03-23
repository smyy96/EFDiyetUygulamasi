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
    public partial class AdminAnalysis : Form
    {
        public AdminAnalysis()
        {
            InitializeComponent();
        }


        private void RoundRadioButton(System.Windows.Forms.RadioButton radioButton, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(rbHaftalik.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(rbHaftalik.Width - radius, rbHaftalik.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, rbHaftalik.Height - radius, radius, radius, 90, 90);
            radioButton.Region = new Region(path);
        }

        private void RoundRadioButton2(System.Windows.Forms.RadioButton radioButton, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(rbAylik.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(rbAylik.Width - radius, rbAylik.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, rbAylik.Height - radius, radius, radius, 90, 90);
            radioButton.Region = new Region(path);
        }
        private void RoundDGV(System.Windows.Forms.DataGridView dataGridView, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(dgvKategoriyeGore.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(dgvKategoriyeGore.Width - radius, dgvKategoriyeGore.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, dgvKategoriyeGore.Height - radius, radius, radius, 90, 90);
            dataGridView.Region = new Region(path);
        }
        private void RoundDGV2(System.Windows.Forms.DataGridView dataGridView, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(dgvKategoriyeGore.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(dgvKategoriyeGore.Width - radius, dgvKategoriyeGore.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, dgvKategoriyeGore.Height - radius, radius, radius, 90, 90);
            dataGridView.Region = new Region(path);
        }
        private void RoundDGV3(System.Windows.Forms.DataGridView dataGridView, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(dgvGenelTuketilen.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(dgvGenelTuketilen.Width - radius, dgvGenelTuketilen.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, dgvGenelTuketilen.Height - radius, radius, radius, 90, 90);
            dataGridView.Region = new Region(path);
        }


        private void AdminAnalysis_Load(object sender, EventArgs e)
        {
            
            RoundRadioButton(rbHaftalik, 20);
            RoundRadioButton2(rbAylik, 20);
            RoundDGV(dgvKategoriyeGore, 20);
            RoundDGV2(dgvOguneGore, 20);
            RoundDGV3(dgvGenelTuketilen, 20);

        }
    }


}
