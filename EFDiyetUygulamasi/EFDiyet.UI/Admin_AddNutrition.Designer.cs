namespace EFDiyet.UI
{
    partial class Admin_AddNutrition
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AddNutrition));
            pictureBox_BesinFoto = new PictureBox();
            txt_BesinEkle = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            BesinAdi = new DataGridViewTextBoxColumn();
            BesinKalori = new DataGridViewTextBoxColumn();
            BesinPorsiyon = new DataGridViewTextBoxColumn();
            BesinKategori = new DataGridViewTextBoxColumn();
            BesinDegeri = new DataGridViewTextBoxColumn();
            btn_BesinGuncelle = new Button();
            btn_BesinSil = new Button();
            btn_BesinEkle = new Button();
            panel2 = new Panel();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label_BesinDegeri = new Label();
            label_BesinKategori = new Label();
            label_Porsiyon = new Label();
            txt_BesinPorsiyon = new TextBox();
            txt_BesinKalori = new TextBox();
            txt_BesinAdi = new TextBox();
            label_BesinFotoYukle = new Label();
            btn_BesinFotoYukle = new Button();
            lblAdmin = new Label();
            lblAnalizA = new Label();
            pbBesinEkle = new PictureBox();
            lblBesinEkle = new Label();
            lblDietAppA = new Label();
            pbAnaliz = new PictureBox();
            lblEkDegisimler = new Label();
            pbEkDegisimler = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_BesinFoto).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBesinEkle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAnaliz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEkDegisimler).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_BesinFoto
            // 
            pictureBox_BesinFoto.Location = new Point(30, 29);
            pictureBox_BesinFoto.Margin = new Padding(3, 2, 3, 2);
            pictureBox_BesinFoto.Name = "pictureBox_BesinFoto";
            pictureBox_BesinFoto.Size = new Size(82, 62);
            pictureBox_BesinFoto.TabIndex = 0;
            pictureBox_BesinFoto.TabStop = false;
            // 
            // txt_BesinEkle
            // 
            txt_BesinEkle.AutoSize = true;
            txt_BesinEkle.BackColor = Color.FromArgb(255, 208, 177);
            txt_BesinEkle.BorderStyle = BorderStyle.FixedSingle;
            txt_BesinEkle.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold);
            txt_BesinEkle.Location = new Point(425, 62);
            txt_BesinEkle.Name = "txt_BesinEkle";
            txt_BesinEkle.Size = new Size(88, 25);
            txt_BesinEkle.TabIndex = 6;
            txt_BesinEkle.Text = "Besin Ekle";
            txt_BesinEkle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btn_BesinGuncelle);
            panel1.Controls.Add(btn_BesinSil);
            panel1.Controls.Add(btn_BesinEkle);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(28, 77);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 348);
            panel1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 208, 177);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BesinAdi, BesinKalori, BesinPorsiyon, BesinKategori, BesinDegeri });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.FromArgb(254, 222, 200);
            dataGridView1.Location = new Point(368, 16);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 10;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(450, 308);
            dataGridView1.TabIndex = 5;
            // 
            // BesinAdi
            // 
            BesinAdi.HeaderText = "Adı";
            BesinAdi.MinimumWidth = 6;
            BesinAdi.Name = "BesinAdi";
            BesinAdi.Width = 125;
            // 
            // BesinKalori
            // 
            BesinKalori.HeaderText = "Kalorisi";
            BesinKalori.MinimumWidth = 6;
            BesinKalori.Name = "BesinKalori";
            BesinKalori.Width = 125;
            // 
            // BesinPorsiyon
            // 
            BesinPorsiyon.HeaderText = "Porsiyon";
            BesinPorsiyon.MinimumWidth = 6;
            BesinPorsiyon.Name = "BesinPorsiyon";
            BesinPorsiyon.Width = 125;
            // 
            // BesinKategori
            // 
            BesinKategori.HeaderText = "Kategori";
            BesinKategori.MinimumWidth = 6;
            BesinKategori.Name = "BesinKategori";
            BesinKategori.Width = 125;
            // 
            // BesinDegeri
            // 
            BesinDegeri.HeaderText = "Besin Değeri";
            BesinDegeri.MinimumWidth = 6;
            BesinDegeri.Name = "BesinDegeri";
            BesinDegeri.Width = 125;
            // 
            // btn_BesinGuncelle
            // 
            btn_BesinGuncelle.ForeColor = Color.DarkRed;
            btn_BesinGuncelle.Location = new Point(213, 322);
            btn_BesinGuncelle.Margin = new Padding(3, 2, 3, 2);
            btn_BesinGuncelle.Name = "btn_BesinGuncelle";
            btn_BesinGuncelle.Size = new Size(82, 22);
            btn_BesinGuncelle.TabIndex = 4;
            btn_BesinGuncelle.Text = "Güncelle";
            btn_BesinGuncelle.UseVisualStyleBackColor = true;
            // 
            // btn_BesinSil
            // 
            btn_BesinSil.ForeColor = Color.DarkRed;
            btn_BesinSil.Location = new Point(125, 322);
            btn_BesinSil.Margin = new Padding(3, 2, 3, 2);
            btn_BesinSil.Name = "btn_BesinSil";
            btn_BesinSil.Size = new Size(82, 22);
            btn_BesinSil.TabIndex = 3;
            btn_BesinSil.Text = "Sil";
            btn_BesinSil.UseVisualStyleBackColor = true;
            // 
            // btn_BesinEkle
            // 
            btn_BesinEkle.ForeColor = Color.DarkRed;
            btn_BesinEkle.Location = new Point(38, 322);
            btn_BesinEkle.Margin = new Padding(3, 2, 3, 2);
            btn_BesinEkle.Name = "btn_BesinEkle";
            btn_BesinEkle.Size = new Size(82, 22);
            btn_BesinEkle.TabIndex = 2;
            btn_BesinEkle.Text = "Ekle";
            btn_BesinEkle.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 208, 177);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label_BesinDegeri);
            panel2.Controls.Add(label_BesinKategori);
            panel2.Controls.Add(label_Porsiyon);
            panel2.Controls.Add(txt_BesinPorsiyon);
            panel2.Controls.Add(txt_BesinKalori);
            panel2.Controls.Add(txt_BesinAdi);
            panel2.Controls.Add(label_BesinFotoYukle);
            panel2.Controls.Add(btn_BesinFotoYukle);
            panel2.Controls.Add(pictureBox_BesinFoto);
            panel2.Location = new Point(26, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 317);
            panel2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(122, 245);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(133, 23);
            comboBox3.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(122, 272);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(122, 220);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 9;
            // 
            // label_BesinDegeri
            // 
            label_BesinDegeri.AutoSize = true;
            label_BesinDegeri.Location = new Point(26, 274);
            label_BesinDegeri.Name = "label_BesinDegeri";
            label_BesinDegeri.Size = new Size(72, 15);
            label_BesinDegeri.TabIndex = 8;
            label_BesinDegeri.Text = "Besin Değeri";
            // 
            // label_BesinKategori
            // 
            label_BesinKategori.AutoSize = true;
            label_BesinKategori.Location = new Point(26, 249);
            label_BesinKategori.Name = "label_BesinKategori";
            label_BesinKategori.Size = new Size(51, 15);
            label_BesinKategori.TabIndex = 7;
            label_BesinKategori.Text = "Kategori";
            // 
            // label_Porsiyon
            // 
            label_Porsiyon.AutoSize = true;
            label_Porsiyon.Location = new Point(26, 222);
            label_Porsiyon.Name = "label_Porsiyon";
            label_Porsiyon.Size = new Size(53, 15);
            label_Porsiyon.TabIndex = 6;
            label_Porsiyon.Text = "Porsiyon";
            // 
            // txt_BesinPorsiyon
            // 
            txt_BesinPorsiyon.Location = new Point(30, 184);
            txt_BesinPorsiyon.Margin = new Padding(3, 2, 3, 2);
            txt_BesinPorsiyon.Name = "txt_BesinPorsiyon";
            txt_BesinPorsiyon.PlaceholderText = "Porsiyon miktarını giriniz";
            txt_BesinPorsiyon.Size = new Size(162, 23);
            txt_BesinPorsiyon.TabIndex = 5;
            // 
            // txt_BesinKalori
            // 
            txt_BesinKalori.Location = new Point(30, 159);
            txt_BesinKalori.Margin = new Padding(3, 2, 3, 2);
            txt_BesinKalori.Name = "txt_BesinKalori";
            txt_BesinKalori.PlaceholderText = "Kaloriyi giriniz";
            txt_BesinKalori.Size = new Size(162, 23);
            txt_BesinKalori.TabIndex = 4;
            // 
            // txt_BesinAdi
            // 
            txt_BesinAdi.Location = new Point(30, 134);
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
            label_BesinFotoYukle.Location = new Point(22, 12);
            label_BesinFotoYukle.Name = "label_BesinFotoYukle";
            label_BesinFotoYukle.Size = new Size(159, 15);
            label_BesinFotoYukle.TabIndex = 2;
            label_BesinFotoYukle.Text = "Besinin fotoğrafını yükleyiniz";
            label_BesinFotoYukle.TextAlign = ContentAlignment.MiddleLeft;
            label_BesinFotoYukle.Click += label1_Click;
            // 
            // btn_BesinFotoYukle
            // 
            btn_BesinFotoYukle.ForeColor = Color.DarkRed;
            btn_BesinFotoYukle.Location = new Point(30, 95);
            btn_BesinFotoYukle.Margin = new Padding(3, 2, 3, 2);
            btn_BesinFotoYukle.Name = "btn_BesinFotoYukle";
            btn_BesinFotoYukle.Size = new Size(82, 22);
            btn_BesinFotoYukle.TabIndex = 1;
            btn_BesinFotoYukle.Text = "Yükle";
            btn_BesinFotoYukle.UseVisualStyleBackColor = true;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.BackColor = Color.FromArgb(255, 208, 177);
            lblAdmin.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdmin.Location = new Point(787, 20);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(60, 23);
            lblAdmin.TabIndex = 26;
            lblAdmin.Text = "Admin";
            // 
            // lblAnalizA
            // 
            lblAnalizA.AutoSize = true;
            lblAnalizA.BackColor = Color.FromArgb(255, 208, 177);
            lblAnalizA.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAnalizA.Location = new Point(630, 20);
            lblAnalizA.Name = "lblAnalizA";
            lblAnalizA.Size = new Size(56, 23);
            lblAnalizA.TabIndex = 25;
            lblAnalizA.Text = "Analiz";
            // 
            // pbBesinEkle
            // 
            pbBesinEkle.BackColor = Color.FromArgb(255, 208, 177);
            pbBesinEkle.Image = (Image)resources.GetObject("pbBesinEkle.Image");
            pbBesinEkle.Location = new Point(201, 11);
            pbBesinEkle.Name = "pbBesinEkle";
            pbBesinEkle.Size = new Size(43, 38);
            pbBesinEkle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBesinEkle.TabIndex = 18;
            pbBesinEkle.TabStop = false;
            // 
            // lblBesinEkle
            // 
            lblBesinEkle.AutoSize = true;
            lblBesinEkle.BackColor = Color.FromArgb(255, 208, 177);
            lblBesinEkle.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBesinEkle.Location = new Point(250, 20);
            lblBesinEkle.Name = "lblBesinEkle";
            lblBesinEkle.Size = new Size(86, 23);
            lblBesinEkle.TabIndex = 23;
            lblBesinEkle.Text = "Besin Ekle";
            // 
            // lblDietAppA
            // 
            lblDietAppA.AutoSize = true;
            lblDietAppA.BackColor = Color.FromArgb(255, 208, 177);
            lblDietAppA.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDietAppA.Location = new Point(28, 11);
            lblDietAppA.Name = "lblDietAppA";
            lblDietAppA.Size = new Size(108, 32);
            lblDietAppA.TabIndex = 22;
            lblDietAppA.Text = "DietApp";
            // 
            // pbAnaliz
            // 
            pbAnaliz.BackColor = Color.FromArgb(255, 208, 177);
            pbAnaliz.Image = (Image)resources.GetObject("pbAnaliz.Image");
            pbAnaliz.Location = new Point(567, 11);
            pbAnaliz.Name = "pbAnaliz";
            pbAnaliz.Size = new Size(45, 38);
            pbAnaliz.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnaliz.TabIndex = 20;
            pbAnaliz.TabStop = false;
            // 
            // lblEkDegisimler
            // 
            lblEkDegisimler.AutoSize = true;
            lblEkDegisimler.BackColor = Color.FromArgb(255, 208, 177);
            lblEkDegisimler.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEkDegisimler.Location = new Point(418, 20);
            lblEkDegisimler.Name = "lblEkDegisimler";
            lblEkDegisimler.Size = new Size(113, 23);
            lblEkDegisimler.TabIndex = 28;
            lblEkDegisimler.Text = "Ek Degisimler";
            // 
            // pbEkDegisimler
            // 
            pbEkDegisimler.BackColor = Color.FromArgb(255, 208, 177);
            pbEkDegisimler.Image = (Image)resources.GetObject("pbEkDegisimler.Image");
            pbEkDegisimler.Location = new Point(374, 12);
            pbEkDegisimler.Name = "pbEkDegisimler";
            pbEkDegisimler.Size = new Size(38, 37);
            pbEkDegisimler.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEkDegisimler.TabIndex = 27;
            pbEkDegisimler.TabStop = false;
            // 
            // Admin_AddNutrition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 222, 200);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(901, 434);
            Controls.Add(lblEkDegisimler);
            Controls.Add(pbEkDegisimler);
            Controls.Add(lblAdmin);
            Controls.Add(txt_BesinEkle);
            Controls.Add(lblAnalizA);
            Controls.Add(pbBesinEkle);
            Controls.Add(lblBesinEkle);
            Controls.Add(lblDietAppA);
            Controls.Add(pbAnaliz);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin_AddNutrition";
            Text = "Admin_AddMeal";
            ((System.ComponentModel.ISupportInitialize)pictureBox_BesinFoto).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBesinEkle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAnaliz).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEkDegisimler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_BesinFoto;
        private Label txt_BesinEkle;
        private Panel panel1;
        private Panel panel2;
        private Button btn_BesinFotoYukle;
        private Label label_BesinFotoYukle;
        private Label lblAdmin;
        private Label lblAnalizA;
        private PictureBox pbBesinEkle;
        private Label lblBesinEkle;
        private Label lblDietAppA;
        private PictureBox pbAnaliz;
        private TextBox txt_BesinAdi;
        private TextBox txt_BesinKalori;
        private TextBox txt_BesinPorsiyon;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label_BesinDegeri;
        private Label label_BesinKategori;
        private Label label_Porsiyon;
        private Button btn_BesinGuncelle;
        private Button btn_BesinSil;
        private Button btn_BesinEkle;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BesinAdi;
        private DataGridViewTextBoxColumn BesinKalori;
        private DataGridViewTextBoxColumn BesinPorsiyon;
        private DataGridViewTextBoxColumn BesinKategori;
        private DataGridViewTextBoxColumn BesinDegeri;
        private Label lblEkDegisimler;
        private PictureBox pbEkDegisimler;
    }
}