namespace formlarg
{
    partial class UserAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAnalysis));
            lblDietAppA = new Label();
            lblAnalizA = new Label();
            lblKategoriyeGore = new Label();
            lblOguneGore = new Label();
            rbHaftalik = new RadioButton();
            lblGenelTuketilen = new Label();
            rbAylik = new RadioButton();
            panel1 = new Panel();
            dgvGenelTuketilen = new DataGridView();
            dgvKategoriyeGore = new DataGridView();
            dgvOguneGore = new DataGridView();
            pbAnaliz = new PictureBox();
            lblKullanici = new Label();
            lblGecmis = new Label();
            lblAnasayfa = new Label();
            pbGecmis = new PictureBox();
            pbAnasayfa = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenelTuketilen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriyeGore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOguneGore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAnaliz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGecmis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAnasayfa).BeginInit();
            SuspendLayout();
            // 
            // lblDietAppA
            // 
            lblDietAppA.AutoSize = true;
            lblDietAppA.BackColor = Color.FromArgb(255, 208, 177);
            lblDietAppA.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDietAppA.ForeColor = Color.FromArgb(64, 0, 0);
            lblDietAppA.Location = new Point(28, 9);
            lblDietAppA.Name = "lblDietAppA";
            lblDietAppA.Size = new Size(108, 32);
            lblDietAppA.TabIndex = 5;
            lblDietAppA.Text = "DietApp";
            // 
            // lblAnalizA
            // 
            lblAnalizA.AutoSize = true;
            lblAnalizA.BackColor = Color.FromArgb(255, 208, 177);
            lblAnalizA.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAnalizA.Location = new Point(556, 18);
            lblAnalizA.Name = "lblAnalizA";
            lblAnalizA.Size = new Size(56, 23);
            lblAnalizA.TabIndex = 15;
            lblAnalizA.Text = "Analiz";
            // 
            // lblKategoriyeGore
            // 
            lblKategoriyeGore.AutoSize = true;
            lblKategoriyeGore.BackColor = Color.Firebrick;
            lblKategoriyeGore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKategoriyeGore.ForeColor = Color.White;
            lblKategoriyeGore.Location = new Point(19, 8);
            lblKategoriyeGore.Name = "lblKategoriyeGore";
            lblKategoriyeGore.Size = new Size(110, 19);
            lblKategoriyeGore.TabIndex = 21;
            lblKategoriyeGore.Text = "Kategoriye Göre";
            // 
            // lblOguneGore
            // 
            lblOguneGore.AutoSize = true;
            lblOguneGore.BackColor = Color.Firebrick;
            lblOguneGore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOguneGore.ForeColor = Color.White;
            lblOguneGore.Location = new Point(19, 193);
            lblOguneGore.Name = "lblOguneGore";
            lblOguneGore.Size = new Size(85, 19);
            lblOguneGore.TabIndex = 22;
            lblOguneGore.Text = "Öğüne Göre";
            // 
            // rbHaftalik
            // 
            rbHaftalik.AutoSize = true;
            rbHaftalik.BackColor = Color.Firebrick;
            rbHaftalik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbHaftalik.ForeColor = Color.White;
            rbHaftalik.Location = new Point(429, 8);
            rbHaftalik.Name = "rbHaftalik";
            rbHaftalik.Size = new Size(142, 25);
            rbHaftalik.TabIndex = 24;
            rbHaftalik.TabStop = true;
            rbHaftalik.Text = "Haftalık Listele";
            rbHaftalik.UseVisualStyleBackColor = false;
            // 
            // lblGenelTuketilen
            // 
            lblGenelTuketilen.AutoSize = true;
            lblGenelTuketilen.BackColor = Color.Firebrick;
            lblGenelTuketilen.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGenelTuketilen.ForeColor = Color.White;
            lblGenelTuketilen.Location = new Point(406, 49);
            lblGenelTuketilen.Name = "lblGenelTuketilen";
            lblGenelTuketilen.Size = new Size(143, 19);
            lblGenelTuketilen.TabIndex = 25;
            lblGenelTuketilen.Text = "Genel Tüketilen Besin";
            // 
            // rbAylik
            // 
            rbAylik.AutoSize = true;
            rbAylik.BackColor = Color.Firebrick;
            rbAylik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbAylik.ForeColor = Color.White;
            rbAylik.Location = new Point(609, 6);
            rbAylik.Name = "rbAylik";
            rbAylik.Size = new Size(120, 25);
            rbAylik.TabIndex = 26;
            rbAylik.TabStop = true;
            rbAylik.Text = "Aylık Listele";
            rbAylik.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvGenelTuketilen);
            panel1.Controls.Add(dgvKategoriyeGore);
            panel1.Controls.Add(dgvOguneGore);
            panel1.Controls.Add(rbAylik);
            panel1.Controls.Add(lblGenelTuketilen);
            panel1.Controls.Add(rbHaftalik);
            panel1.Controls.Add(lblOguneGore);
            panel1.Controls.Add(lblKategoriyeGore);
            panel1.Location = new Point(8, 64);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 375);
            panel1.TabIndex = 20;
            // 
            // dgvGenelTuketilen
            // 
            dgvGenelTuketilen.BackgroundColor = Color.FromArgb(255, 208, 177);
            dgvGenelTuketilen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenelTuketilen.Location = new Point(406, 71);
            dgvGenelTuketilen.Name = "dgvGenelTuketilen";
            dgvGenelTuketilen.Size = new Size(353, 295);
            dgvGenelTuketilen.TabIndex = 29;
            // 
            // dgvKategoriyeGore
            // 
            dgvKategoriyeGore.BackgroundColor = Color.FromArgb(255, 208, 177);
            dgvKategoriyeGore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategoriyeGore.Location = new Point(19, 30);
            dgvKategoriyeGore.Name = "dgvKategoriyeGore";
            dgvKategoriyeGore.Size = new Size(353, 151);
            dgvKategoriyeGore.TabIndex = 28;
            // 
            // dgvOguneGore
            // 
            dgvOguneGore.BackgroundColor = Color.FromArgb(255, 208, 177);
            dgvOguneGore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOguneGore.Location = new Point(19, 215);
            dgvOguneGore.Name = "dgvOguneGore";
            dgvOguneGore.Size = new Size(353, 151);
            dgvOguneGore.TabIndex = 27;
            // 
            // pbAnaliz
            // 
            pbAnaliz.BackColor = Color.FromArgb(255, 208, 177);
            pbAnaliz.Image = (Image)resources.GetObject("pbAnaliz.Image");
            pbAnaliz.Location = new Point(492, 9);
            pbAnaliz.Name = "pbAnaliz";
            pbAnaliz.Size = new Size(45, 37);
            pbAnaliz.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnaliz.TabIndex = 11;
            pbAnaliz.TabStop = false;
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.BackColor = Color.FromArgb(255, 208, 177);
            lblKullanici.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKullanici.Location = new Point(681, 18);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(73, 23);
            lblKullanici.TabIndex = 27;
            lblKullanici.Text = "Kullanıcı";
            // 
            // lblGecmis
            // 
            lblGecmis.AutoSize = true;
            lblGecmis.BackColor = Color.FromArgb(255, 208, 177);
            lblGecmis.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGecmis.Location = new Point(393, 17);
            lblGecmis.Name = "lblGecmis";
            lblGecmis.Size = new Size(65, 23);
            lblGecmis.TabIndex = 25;
            lblGecmis.Text = "Geçmiş";
            // 
            // lblAnasayfa
            // 
            lblAnasayfa.AutoSize = true;
            lblAnasayfa.BackColor = Color.FromArgb(255, 208, 177);
            lblAnasayfa.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAnasayfa.Location = new Point(215, 18);
            lblAnasayfa.Name = "lblAnasayfa";
            lblAnasayfa.Size = new Size(93, 23);
            lblAnasayfa.TabIndex = 24;
            lblAnasayfa.Text = "ANASAYFA";
            // 
            // pbGecmis
            // 
            pbGecmis.BackColor = Color.FromArgb(255, 208, 177);
            pbGecmis.Image = (Image)resources.GetObject("pbGecmis.Image");
            pbGecmis.Location = new Point(332, 9);
            pbGecmis.Name = "pbGecmis";
            pbGecmis.Size = new Size(42, 37);
            pbGecmis.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGecmis.TabIndex = 22;
            pbGecmis.TabStop = false;
            // 
            // pbAnasayfa
            // 
            pbAnasayfa.BackColor = Color.FromArgb(255, 208, 177);
            pbAnasayfa.Image = (Image)resources.GetObject("pbAnasayfa.Image");
            pbAnasayfa.Location = new Point(166, 9);
            pbAnasayfa.Name = "pbAnasayfa";
            pbAnasayfa.Size = new Size(43, 37);
            pbAnasayfa.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnasayfa.TabIndex = 21;
            pbAnasayfa.TabStop = false;
            // 
            // UserAnalysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblKullanici);
            Controls.Add(lblGecmis);
            Controls.Add(lblAnasayfa);
            Controls.Add(pbGecmis);
            Controls.Add(pbAnasayfa);
            Controls.Add(panel1);
            Controls.Add(lblAnalizA);
            Controls.Add(pbAnaliz);
            Controls.Add(lblDietAppA);
            DoubleBuffered = true;
            Name = "UserAnalysis";
            Text = "AdminAnalysis";
            Load += AdminAnalysis_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenelTuketilen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriyeGore).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOguneGore).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAnaliz).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGecmis).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAnasayfa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDietAppA;
        private Label lblAnalizA;
        private DataGridViewTextBoxColumn BesinKalori;
        private DataGridViewTextBoxColumn BesinPorsiyon;
        private DataGridViewTextBoxColumn BesinKategori;
        private DataGridViewTextBoxColumn BesinDegeri;
        private DataGridView dgvGenelTuketilen;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridView dgvOguneGore;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Label lblKategoriyeGore;
        private Label lblOguneGore;
        private RadioButton rbHaftalik;
        private Label lblGenelTuketilen;
        private RadioButton rbAylik;
        private Panel panel1;
        private DataGridView dgvKategoriyeGore;
        private PictureBox pbAnaliz;
        private Label lblKullanici;
        private Label lblGecmis;
        private Label lblAnasayfa;
        private PictureBox pbGecmis;
        private PictureBox pbAnasayfa;
    }
}