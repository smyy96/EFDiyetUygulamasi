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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AddNutrition));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox_BesinFoto = new PictureBox();
            txt_BesinEkle = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_BesinFotoYukle = new Button();
            label_BesinFotoYukle = new Label();
            lblAdmin = new Label();
            lblAnalizA = new Label();
            lblOgunEkle = new Label();
            pbBesinEkle = new PictureBox();
            lblBesinEkle = new Label();
            pbOgunEkle = new PictureBox();
            lblDietAppA = new Label();
            pbAnaliz = new PictureBox();
            pbCikisAdmin = new PictureBox();
            txt_BesinAdi = new TextBox();
            txt_BesinKalori = new TextBox();
            txt_BesinPorsiyon = new TextBox();
            label_Porsiyon = new Label();
            label_BesinKategori = new Label();
            label_BesinDegeri = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            btn_BesinEkle = new Button();
            btn_BesinSil = new Button();
            btn_BesinGuncelle = new Button();
            dataGridView1 = new DataGridView();
            BesinAdi = new DataGridViewTextBoxColumn();
            BesinKalori = new DataGridViewTextBoxColumn();
            BesinPorsiyon = new DataGridViewTextBoxColumn();
            BesinKategori = new DataGridViewTextBoxColumn();
            BesinDegeri = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox_BesinFoto).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBesinEkle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOgunEkle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAnaliz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCikisAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_BesinFoto
            // 
            pictureBox_BesinFoto.Location = new Point(34, 39);
            pictureBox_BesinFoto.Name = "pictureBox_BesinFoto";
            pictureBox_BesinFoto.Size = new Size(94, 82);
            pictureBox_BesinFoto.TabIndex = 0;
            pictureBox_BesinFoto.TabStop = false;
            // 
            // txt_BesinEkle
            // 
            txt_BesinEkle.AutoSize = true;
            txt_BesinEkle.BackColor = Color.FromArgb(255, 208, 177);
            txt_BesinEkle.BorderStyle = BorderStyle.FixedSingle;
            txt_BesinEkle.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold);
            txt_BesinEkle.Location = new Point(486, 83);
            txt_BesinEkle.Name = "txt_BesinEkle";
            txt_BesinEkle.Size = new Size(109, 32);
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
            panel1.Location = new Point(32, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 464);
            panel1.TabIndex = 8;
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
            panel2.Location = new Point(30, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 421);
            panel2.TabIndex = 1;
            // 
            // btn_BesinFotoYukle
            // 
            btn_BesinFotoYukle.ForeColor = Color.DarkRed;
            btn_BesinFotoYukle.Location = new Point(34, 127);
            btn_BesinFotoYukle.Name = "btn_BesinFotoYukle";
            btn_BesinFotoYukle.Size = new Size(94, 29);
            btn_BesinFotoYukle.TabIndex = 1;
            btn_BesinFotoYukle.Text = "Yükle";
            btn_BesinFotoYukle.UseVisualStyleBackColor = true;
            // 
            // label_BesinFotoYukle
            // 
            label_BesinFotoYukle.AutoSize = true;
            label_BesinFotoYukle.ForeColor = Color.RosyBrown;
            label_BesinFotoYukle.Location = new Point(25, 16);
            label_BesinFotoYukle.Name = "label_BesinFotoYukle";
            label_BesinFotoYukle.Size = new Size(199, 20);
            label_BesinFotoYukle.TabIndex = 2;
            label_BesinFotoYukle.Text = "Besinin fotoğrafını yükleyiniz";
            label_BesinFotoYukle.TextAlign = ContentAlignment.MiddleLeft;
            label_BesinFotoYukle.Click += label1_Click;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.BackColor = Color.FromArgb(255, 208, 177);
            lblAdmin.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdmin.Location = new Point(786, 21);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(79, 30);
            lblAdmin.TabIndex = 26;
            lblAdmin.Text = "Admin";
            // 
            // lblAnalizA
            // 
            lblAnalizA.AutoSize = true;
            lblAnalizA.BackColor = Color.FromArgb(255, 208, 177);
            lblAnalizA.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAnalizA.Location = new Point(684, 21);
            lblAnalizA.Name = "lblAnalizA";
            lblAnalizA.Size = new Size(74, 30);
            lblAnalizA.TabIndex = 25;
            lblAnalizA.Text = "Analiz";
            // 
            // lblOgunEkle
            // 
            lblOgunEkle.AutoSize = true;
            lblOgunEkle.BackColor = Color.FromArgb(255, 208, 177);
            lblOgunEkle.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOgunEkle.Location = new Point(479, 21);
            lblOgunEkle.Name = "lblOgunEkle";
            lblOgunEkle.Size = new Size(116, 30);
            lblOgunEkle.TabIndex = 24;
            lblOgunEkle.Text = "Öğün Ekle";
            // 
            // pbBesinEkle
            // 
            pbBesinEkle.BackColor = Color.FromArgb(255, 208, 177);
            pbBesinEkle.BorderStyle = BorderStyle.Fixed3D;
            pbBesinEkle.Image = (Image)resources.GetObject("pbBesinEkle.Image");
            pbBesinEkle.Location = new Point(246, 9);
            pbBesinEkle.Margin = new Padding(3, 4, 3, 4);
            pbBesinEkle.Name = "pbBesinEkle";
            pbBesinEkle.Size = new Size(49, 49);
            pbBesinEkle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBesinEkle.TabIndex = 18;
            pbBesinEkle.TabStop = false;
            // 
            // lblBesinEkle
            // 
            lblBesinEkle.AutoSize = true;
            lblBesinEkle.BackColor = Color.FromArgb(255, 208, 177);
            lblBesinEkle.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBesinEkle.Location = new Point(302, 21);
            lblBesinEkle.Name = "lblBesinEkle";
            lblBesinEkle.Size = new Size(113, 30);
            lblBesinEkle.TabIndex = 23;
            lblBesinEkle.Text = "Besin Ekle";
            // 
            // pbOgunEkle
            // 
            pbOgunEkle.BackColor = Color.FromArgb(255, 208, 177);
            pbOgunEkle.BorderStyle = BorderStyle.Fixed3D;
            pbOgunEkle.Image = (Image)resources.GetObject("pbOgunEkle.Image");
            pbOgunEkle.Location = new Point(425, 9);
            pbOgunEkle.Margin = new Padding(3, 4, 3, 4);
            pbOgunEkle.Name = "pbOgunEkle";
            pbOgunEkle.Size = new Size(48, 49);
            pbOgunEkle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOgunEkle.TabIndex = 19;
            pbOgunEkle.TabStop = false;
            // 
            // lblDietAppA
            // 
            lblDietAppA.AutoSize = true;
            lblDietAppA.BackColor = Color.FromArgb(255, 208, 177);
            lblDietAppA.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDietAppA.Location = new Point(69, 9);
            lblDietAppA.Name = "lblDietAppA";
            lblDietAppA.Size = new Size(136, 41);
            lblDietAppA.TabIndex = 22;
            lblDietAppA.Text = "DietApp";
            // 
            // pbAnaliz
            // 
            pbAnaliz.BackColor = Color.FromArgb(255, 208, 177);
            pbAnaliz.BorderStyle = BorderStyle.Fixed3D;
            pbAnaliz.Image = (Image)resources.GetObject("pbAnaliz.Image");
            pbAnaliz.Location = new Point(611, 9);
            pbAnaliz.Margin = new Padding(3, 4, 3, 4);
            pbAnaliz.Name = "pbAnaliz";
            pbAnaliz.Size = new Size(51, 49);
            pbAnaliz.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnaliz.TabIndex = 20;
            pbAnaliz.TabStop = false;
            // 
            // pbCikisAdmin
            // 
            pbCikisAdmin.BackColor = Color.FromArgb(255, 208, 177);
            pbCikisAdmin.BorderStyle = BorderStyle.Fixed3D;
            pbCikisAdmin.Image = (Image)resources.GetObject("pbCikisAdmin.Image");
            pbCikisAdmin.Location = new Point(902, 18);
            pbCikisAdmin.Margin = new Padding(3, 4, 3, 4);
            pbCikisAdmin.Name = "pbCikisAdmin";
            pbCikisAdmin.Size = new Size(42, 40);
            pbCikisAdmin.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCikisAdmin.TabIndex = 21;
            pbCikisAdmin.TabStop = false;
            // 
            // txt_BesinAdi
            // 
            txt_BesinAdi.Location = new Point(34, 179);
            txt_BesinAdi.Name = "txt_BesinAdi";
            txt_BesinAdi.PlaceholderText = "Besin Adını Giriniz";
            txt_BesinAdi.Size = new Size(185, 27);
            txt_BesinAdi.TabIndex = 3;
            // 
            // txt_BesinKalori
            // 
            txt_BesinKalori.Location = new Point(34, 212);
            txt_BesinKalori.Name = "txt_BesinKalori";
            txt_BesinKalori.PlaceholderText = "Kaloriyi giriniz";
            txt_BesinKalori.Size = new Size(185, 27);
            txt_BesinKalori.TabIndex = 4;
            // 
            // txt_BesinPorsiyon
            // 
            txt_BesinPorsiyon.Location = new Point(34, 245);
            txt_BesinPorsiyon.Name = "txt_BesinPorsiyon";
            txt_BesinPorsiyon.PlaceholderText = "Porsiyon miktarını giriniz";
            txt_BesinPorsiyon.Size = new Size(185, 27);
            txt_BesinPorsiyon.TabIndex = 5;
            // 
            // label_Porsiyon
            // 
            label_Porsiyon.AutoSize = true;
            label_Porsiyon.Location = new Point(30, 296);
            label_Porsiyon.Name = "label_Porsiyon";
            label_Porsiyon.Size = new Size(64, 20);
            label_Porsiyon.TabIndex = 6;
            label_Porsiyon.Text = "Porsiyon";
            // 
            // label_BesinKategori
            // 
            label_BesinKategori.AutoSize = true;
            label_BesinKategori.Location = new Point(30, 332);
            label_BesinKategori.Name = "label_BesinKategori";
            label_BesinKategori.Size = new Size(66, 20);
            label_BesinKategori.TabIndex = 7;
            label_BesinKategori.Text = "Kategori";
            // 
            // label_BesinDegeri
            // 
            label_BesinDegeri.AutoSize = true;
            label_BesinDegeri.Location = new Point(30, 366);
            label_BesinDegeri.Name = "label_BesinDegeri";
            label_BesinDegeri.Size = new Size(93, 20);
            label_BesinDegeri.TabIndex = 8;
            label_BesinDegeri.Text = "Besin Değeri";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(139, 293);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(139, 363);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(139, 327);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 11;
            // 
            // btn_BesinEkle
            // 
            btn_BesinEkle.ForeColor = Color.DarkRed;
            btn_BesinEkle.Location = new Point(43, 430);
            btn_BesinEkle.Name = "btn_BesinEkle";
            btn_BesinEkle.Size = new Size(94, 29);
            btn_BesinEkle.TabIndex = 2;
            btn_BesinEkle.Text = "Ekle";
            btn_BesinEkle.UseVisualStyleBackColor = true;
            // 
            // btn_BesinSil
            // 
            btn_BesinSil.ForeColor = Color.DarkRed;
            btn_BesinSil.Location = new Point(143, 430);
            btn_BesinSil.Name = "btn_BesinSil";
            btn_BesinSil.Size = new Size(94, 29);
            btn_BesinSil.TabIndex = 3;
            btn_BesinSil.Text = "Sil";
            btn_BesinSil.UseVisualStyleBackColor = true;
            // 
            // btn_BesinGuncelle
            // 
            btn_BesinGuncelle.ForeColor = Color.DarkRed;
            btn_BesinGuncelle.Location = new Point(243, 430);
            btn_BesinGuncelle.Name = "btn_BesinGuncelle";
            btn_BesinGuncelle.Size = new Size(94, 29);
            btn_BesinGuncelle.TabIndex = 4;
            btn_BesinGuncelle.Text = "Güncelle";
            btn_BesinGuncelle.UseVisualStyleBackColor = true;
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
            dataGridView1.Location = new Point(420, 21);
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
            dataGridView1.Size = new Size(514, 411);
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
            // Admin_AddNutrition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 222, 200);
            ClientSize = new Size(1030, 579);
            Controls.Add(lblAdmin);
            Controls.Add(txt_BesinEkle);
            Controls.Add(lblAnalizA);
            Controls.Add(lblOgunEkle);
            Controls.Add(pbBesinEkle);
            Controls.Add(lblBesinEkle);
            Controls.Add(pbOgunEkle);
            Controls.Add(lblDietAppA);
            Controls.Add(pbAnaliz);
            Controls.Add(pbCikisAdmin);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F);
            Name = "Admin_AddNutrition";
            Text = "Admin_AddMeal";
            ((System.ComponentModel.ISupportInitialize)pictureBox_BesinFoto).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBesinEkle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOgunEkle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAnaliz).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCikisAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label lblOgunEkle;
        private PictureBox pbBesinEkle;
        private Label lblBesinEkle;
        private PictureBox pbOgunEkle;
        private Label lblDietAppA;
        private PictureBox pbAnaliz;
        private PictureBox pbCikisAdmin;
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
    }
}