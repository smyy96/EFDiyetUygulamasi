namespace EFDiyet.UI
{
    partial class AdminAddNutrition
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnFormClear = new Button();
            dataGridView1 = new DataGridView();
            btn_BesinGuncelle = new Button();
            btn_BesinSil = new Button();
            btn_BesinEkle = new Button();
            panel2 = new Panel();
            cmbCategory = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbNutriVal = new ComboBox();
            cmbPortion = new ComboBox();
            label_BesinDegeri = new Label();
            label_BesinKategori = new Label();
            label_Porsiyon = new Label();
            txt_BesinPorsiyon = new TextBox();
            txt_BesinKalori = new TextBox();
            txt_BesinAdi = new TextBox();
            label_BesinFotoYukle = new Label();
            pictureBox_BesinFoto = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_BesinFoto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnFormClear);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btn_BesinGuncelle);
            panel1.Controls.Add(btn_BesinSil);
            panel1.Controls.Add(btn_BesinEkle);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 422);
            panel1.TabIndex = 9;
            // 
            // btnFormClear
            // 
            btnFormClear.ForeColor = Color.DarkRed;
            btnFormClear.Location = new Point(54, 394);
            btnFormClear.Margin = new Padding(3, 2, 3, 2);
            btnFormClear.Name = "btnFormClear";
            btnFormClear.Size = new Size(174, 24);
            btnFormClear.TabIndex = 6;
            btnFormClear.Text = "Sayfayı Temizle";
            btnFormClear.UseVisualStyleBackColor = true;
            btnFormClear.Click += btnFormClear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 208, 177);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.GridColor = Color.FromArgb(254, 222, 200);
            dataGridView1.Location = new Point(304, 6);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 10;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(529, 403);
            dataGridView1.TabIndex = 5;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // btn_BesinGuncelle
            // 
            btn_BesinGuncelle.ForeColor = Color.DarkRed;
            btn_BesinGuncelle.Location = new Point(192, 368);
            btn_BesinGuncelle.Margin = new Padding(3, 2, 3, 2);
            btn_BesinGuncelle.Name = "btn_BesinGuncelle";
            btn_BesinGuncelle.Size = new Size(82, 24);
            btn_BesinGuncelle.TabIndex = 4;
            btn_BesinGuncelle.Text = "Güncelle";
            btn_BesinGuncelle.UseVisualStyleBackColor = true;
            btn_BesinGuncelle.Click += btn_BesinGuncelle_Click;
            // 
            // btn_BesinSil
            // 
            btn_BesinSil.ForeColor = Color.DarkRed;
            btn_BesinSil.Location = new Point(104, 368);
            btn_BesinSil.Margin = new Padding(3, 2, 3, 2);
            btn_BesinSil.Name = "btn_BesinSil";
            btn_BesinSil.Size = new Size(82, 24);
            btn_BesinSil.TabIndex = 3;
            btn_BesinSil.Text = "Sil";
            btn_BesinSil.UseVisualStyleBackColor = true;
            btn_BesinSil.Click += btn_BesinSil_Click;
            // 
            // btn_BesinEkle
            // 
            btn_BesinEkle.ForeColor = Color.DarkRed;
            btn_BesinEkle.Location = new Point(17, 368);
            btn_BesinEkle.Margin = new Padding(3, 2, 3, 2);
            btn_BesinEkle.Name = "btn_BesinEkle";
            btn_BesinEkle.Size = new Size(82, 24);
            btn_BesinEkle.TabIndex = 2;
            btn_BesinEkle.Text = "Ekle";
            btn_BesinEkle.UseVisualStyleBackColor = true;
            btn_BesinEkle.Click += btn_BesinEkle_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 208, 177);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(cmbCategory);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmbNutriVal);
            panel2.Controls.Add(cmbPortion);
            panel2.Controls.Add(label_BesinDegeri);
            panel2.Controls.Add(label_BesinKategori);
            panel2.Controls.Add(label_Porsiyon);
            panel2.Controls.Add(txt_BesinPorsiyon);
            panel2.Controls.Add(txt_BesinKalori);
            panel2.Controls.Add(txt_BesinAdi);
            panel2.Controls.Add(label_BesinFotoYukle);
            panel2.Controls.Add(pictureBox_BesinFoto);
            panel2.Location = new Point(8, 6);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 356);
            panel2.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(122, 282);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(133, 23);
            cmbCategory.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(125, 308);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 17;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(125, 265);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 16;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(125, 221);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 15;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(32, 176);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 14;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(32, 135);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 13;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(30, 93);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "label1";
            // 
            // cmbNutriVal
            // 
            cmbNutriVal.FormattingEnabled = true;
            cmbNutriVal.Location = new Point(122, 323);
            cmbNutriVal.Margin = new Padding(3, 2, 3, 2);
            cmbNutriVal.Name = "cmbNutriVal";
            cmbNutriVal.Size = new Size(133, 23);
            cmbNutriVal.TabIndex = 11;
            // 
            // cmbPortion
            // 
            cmbPortion.FormattingEnabled = true;
            cmbPortion.Location = new Point(122, 239);
            cmbPortion.Margin = new Padding(3, 2, 3, 2);
            cmbPortion.Name = "cmbPortion";
            cmbPortion.Size = new Size(133, 23);
            cmbPortion.TabIndex = 9;
            // 
            // label_BesinDegeri
            // 
            label_BesinDegeri.AutoSize = true;
            label_BesinDegeri.Location = new Point(44, 330);
            label_BesinDegeri.Name = "label_BesinDegeri";
            label_BesinDegeri.Size = new Size(72, 15);
            label_BesinDegeri.TabIndex = 8;
            label_BesinDegeri.Text = "Besin Değeri";
            // 
            // label_BesinKategori
            // 
            label_BesinKategori.AutoSize = true;
            label_BesinKategori.Location = new Point(44, 285);
            label_BesinKategori.Name = "label_BesinKategori";
            label_BesinKategori.Size = new Size(51, 15);
            label_BesinKategori.TabIndex = 7;
            label_BesinKategori.Text = "Kategori";
            // 
            // label_Porsiyon
            // 
            label_Porsiyon.AutoSize = true;
            label_Porsiyon.Location = new Point(44, 244);
            label_Porsiyon.Name = "label_Porsiyon";
            label_Porsiyon.Size = new Size(53, 15);
            label_Porsiyon.TabIndex = 6;
            label_Porsiyon.Text = "Porsiyon";
            // 
            // txt_BesinPorsiyon
            // 
            txt_BesinPorsiyon.Location = new Point(29, 194);
            txt_BesinPorsiyon.Margin = new Padding(3, 2, 3, 2);
            txt_BesinPorsiyon.Name = "txt_BesinPorsiyon";
            txt_BesinPorsiyon.PlaceholderText = "Porsiyon miktarını giriniz";
            txt_BesinPorsiyon.Size = new Size(162, 23);
            txt_BesinPorsiyon.TabIndex = 5;
            // 
            // txt_BesinKalori
            // 
            txt_BesinKalori.Location = new Point(29, 151);
            txt_BesinKalori.Margin = new Padding(3, 2, 3, 2);
            txt_BesinKalori.Name = "txt_BesinKalori";
            txt_BesinKalori.PlaceholderText = "Kaloriyi giriniz";
            txt_BesinKalori.Size = new Size(162, 23);
            txt_BesinKalori.TabIndex = 4;
            // 
            // txt_BesinAdi
            // 
            txt_BesinAdi.Location = new Point(27, 110);
            txt_BesinAdi.Margin = new Padding(3, 2, 3, 2);
            txt_BesinAdi.Name = "txt_BesinAdi";
            txt_BesinAdi.PlaceholderText = "Besin Adını Giriniz";
            txt_BesinAdi.Size = new Size(162, 23);
            txt_BesinAdi.TabIndex = 3;
            // 
            // label_BesinFotoYukle
            // 
            label_BesinFotoYukle.AutoSize = true;
            label_BesinFotoYukle.ForeColor = Color.RosyBrown;
            label_BesinFotoYukle.Location = new Point(22, 6);
            label_BesinFotoYukle.Name = "label_BesinFotoYukle";
            label_BesinFotoYukle.Size = new Size(159, 15);
            label_BesinFotoYukle.TabIndex = 2;
            label_BesinFotoYukle.Text = "Besinin fotoğrafını yükleyiniz";
            label_BesinFotoYukle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox_BesinFoto
            // 
            pictureBox_BesinFoto.BackColor = Color.FromArgb(255, 208, 177);
            pictureBox_BesinFoto.BackgroundImage = Properties.Resources.user__2_;
            pictureBox_BesinFoto.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_BesinFoto.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_BesinFoto.Location = new Point(30, 23);
            pictureBox_BesinFoto.Margin = new Padding(3, 2, 3, 2);
            pictureBox_BesinFoto.Name = "pictureBox_BesinFoto";
            pictureBox_BesinFoto.Size = new Size(86, 65);
            pictureBox_BesinFoto.TabIndex = 0;
            pictureBox_BesinFoto.TabStop = false;
            pictureBox_BesinFoto.Click += pictureBox_BesinFoto_Click;
            // 
            // AdminAddNutrition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AdminAddNutrition";
            Size = new Size(848, 422);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_BesinFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_BesinGuncelle;
        private Button btn_BesinSil;
        private Button btn_BesinEkle;
        private Panel panel2;
        private ComboBox cmbCategory;
        private ComboBox cmbPortion;
        private Label label_BesinDegeri;
        private Label label_BesinKategori;
        private Label label_Porsiyon;
        private TextBox txt_BesinPorsiyon;
        private TextBox txt_BesinKalori;
        private TextBox txt_BesinAdi;
        private Label label_BesinFotoYukle;
        private PictureBox pictureBox_BesinFoto;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnFormClear;
        private ComboBox cmbNutriVal;
        private DataGridView dataGridView1;
    }
}
