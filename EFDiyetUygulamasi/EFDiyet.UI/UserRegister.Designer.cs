namespace EFDiyet.UI
{
    partial class UserRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegister));
            panel1 = new Panel();
            label8 = new Label();
            label_DogumTarihi = new Label();
            btn_erkek = new RadioButton();
            btn_kadin = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            label_yasControl = new Label();
            cmbScrtyQue = new ComboBox();
            label_GuvenlikSorusu = new Label();
            label_Parola = new Label();
            txt_Parola = new TextBox();
            txt_ParolaTekrar = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label_GuvenlikSorusuCevabi = new Label();
            txt_GuvenlikSorusuCevabi = new TextBox();
            btn_Kayit = new Button();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pctBxImage = new PictureBox();
            txt_Kilo = new TextBox();
            txt_Ad = new TextBox();
            label_Kilo = new Label();
            txt_Soyad = new TextBox();
            txt_Boy = new TextBox();
            txt_Mail = new TextBox();
            label_Boy = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBxImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 222, 200);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label_DogumTarihi);
            panel1.Controls.Add(btn_erkek);
            panel1.Controls.Add(btn_kadin);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label_yasControl);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.RosyBrown;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 431);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 156);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 18;
            label8.Text = "label8";
            // 
            // label_DogumTarihi
            // 
            label_DogumTarihi.AutoSize = true;
            label_DogumTarihi.Location = new Point(10, 69);
            label_DogumTarihi.Name = "label_DogumTarihi";
            label_DogumTarihi.Size = new Size(132, 15);
            label_DogumTarihi.TabIndex = 5;
            label_DogumTarihi.Text = "Doğum Tarihinizi Giriniz";
            // 
            // btn_erkek
            // 
            btn_erkek.AutoSize = true;
            btn_erkek.Location = new Point(118, 178);
            btn_erkek.Margin = new Padding(3, 2, 3, 2);
            btn_erkek.Name = "btn_erkek";
            btn_erkek.Size = new Size(53, 19);
            btn_erkek.TabIndex = 4;
            btn_erkek.TabStop = true;
            btn_erkek.Text = "Erkek";
            btn_erkek.UseVisualStyleBackColor = true;
            // 
            // btn_kadin
            // 
            btn_kadin.AutoSize = true;
            btn_kadin.Location = new Point(40, 178);
            btn_kadin.Margin = new Padding(3, 2, 3, 2);
            btn_kadin.Name = "btn_kadin";
            btn_kadin.Size = new Size(55, 19);
            btn_kadin.TabIndex = 3;
            btn_kadin.TabStop = true;
            btn_kadin.Text = "Kadın";
            btn_kadin.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(10, 86);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2024, 3, 22, 0, 0, 0, 0);
            // 
            // label_yasControl
            // 
            label_yasControl.Font = new Font("Segoe UI", 7F);
            label_yasControl.ForeColor = Color.DarkRed;
            label_yasControl.Location = new Point(10, 346);
            label_yasControl.Name = "label_yasControl";
            label_yasControl.Size = new Size(228, 23);
            label_yasControl.TabIndex = 1;
            label_yasControl.Text = "Bu uygulama 18-35 yaş arası bireyleri kapsamaktadır!";
            label_yasControl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbScrtyQue
            // 
            cmbScrtyQue.FormattingEnabled = true;
            cmbScrtyQue.Items.AddRange(new object[] { "Hangi futbol takımını tutuyorsunuz?", "İlkokul öğretmeninizin adı nedir?", "İlk evcil hayvanınızın adı nedir?", "İlk aşkınızın adı nedir?", "En sevdiğiniz film hangisidir?", "En sevdiğiniz renk nedir?", "En sevdiğiniz yiyecek nedir?", "İlk çocukluk arkadaşınızın adı nedir?" });
            cmbScrtyQue.Location = new Point(22, 104);
            cmbScrtyQue.Margin = new Padding(3, 2, 3, 2);
            cmbScrtyQue.Name = "cmbScrtyQue";
            cmbScrtyQue.Size = new Size(162, 23);
            cmbScrtyQue.TabIndex = 6;
            // 
            // label_GuvenlikSorusu
            // 
            label_GuvenlikSorusu.AutoSize = true;
            label_GuvenlikSorusu.BackColor = Color.RosyBrown;
            label_GuvenlikSorusu.BorderStyle = BorderStyle.Fixed3D;
            label_GuvenlikSorusu.Location = new Point(25, 85);
            label_GuvenlikSorusu.Name = "label_GuvenlikSorusu";
            label_GuvenlikSorusu.Size = new Size(133, 17);
            label_GuvenlikSorusu.TabIndex = 7;
            label_GuvenlikSorusu.Text = "Güvenlik Sorusu Seçiniz";
            // 
            // label_Parola
            // 
            label_Parola.AutoSize = true;
            label_Parola.BackColor = Color.RosyBrown;
            label_Parola.BorderStyle = BorderStyle.Fixed3D;
            label_Parola.Location = new Point(27, 238);
            label_Parola.Name = "label_Parola";
            label_Parola.Size = new Size(101, 17);
            label_Parola.TabIndex = 9;
            label_Parola.Text = "Parola Belirleyiniz\r\n";
            // 
            // txt_Parola
            // 
            txt_Parola.ForeColor = Color.DarkGray;
            txt_Parola.Location = new Point(27, 259);
            txt_Parola.Margin = new Padding(3, 2, 3, 2);
            txt_Parola.Name = "txt_Parola";
            txt_Parola.PlaceholderText = "Parolanızı giriniz";
            txt_Parola.Size = new Size(152, 23);
            txt_Parola.TabIndex = 10;
            // 
            // txt_ParolaTekrar
            // 
            txt_ParolaTekrar.ForeColor = Color.DarkGray;
            txt_ParolaTekrar.Location = new Point(27, 285);
            txt_ParolaTekrar.Margin = new Padding(3, 2, 3, 2);
            txt_ParolaTekrar.Name = "txt_ParolaTekrar";
            txt_ParolaTekrar.PlaceholderText = "Parolanızı tekrar giriniz";
            txt_ParolaTekrar.Size = new Size(152, 23);
            txt_ParolaTekrar.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(244, 0);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(633, 431);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label_GuvenlikSorusuCevabi);
            panel3.Controls.Add(txt_GuvenlikSorusuCevabi);
            panel3.Controls.Add(btn_Kayit);
            panel3.Controls.Add(label_GuvenlikSorusu);
            panel3.Controls.Add(cmbScrtyQue);
            panel3.Controls.Add(label_Parola);
            panel3.Controls.Add(txt_ParolaTekrar);
            panel3.Controls.Add(txt_Parola);
            panel3.Location = new Point(558, 8);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 398);
            panel3.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 149);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 22;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 64);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 21;
            label6.Text = "label6";
            // 
            // label_GuvenlikSorusuCevabi
            // 
            label_GuvenlikSorusuCevabi.AutoSize = true;
            label_GuvenlikSorusuCevabi.BackColor = Color.RosyBrown;
            label_GuvenlikSorusuCevabi.BorderStyle = BorderStyle.Fixed3D;
            label_GuvenlikSorusuCevabi.Location = new Point(23, 169);
            label_GuvenlikSorusuCevabi.Name = "label_GuvenlikSorusuCevabi";
            label_GuvenlikSorusuCevabi.Size = new Size(200, 17);
            label_GuvenlikSorusuCevabi.TabIndex = 14;
            label_GuvenlikSorusuCevabi.Text = "Güvenlik Sorusunun Cevabını Giriniz";
            // 
            // txt_GuvenlikSorusuCevabi
            // 
            txt_GuvenlikSorusuCevabi.Location = new Point(24, 190);
            txt_GuvenlikSorusuCevabi.Margin = new Padding(3, 2, 3, 2);
            txt_GuvenlikSorusuCevabi.Name = "txt_GuvenlikSorusuCevabi";
            txt_GuvenlikSorusuCevabi.Size = new Size(184, 23);
            txt_GuvenlikSorusuCevabi.TabIndex = 13;
            // 
            // btn_Kayit
            // 
            btn_Kayit.Location = new Point(141, 330);
            btn_Kayit.Margin = new Padding(3, 2, 3, 2);
            btn_Kayit.Name = "btn_Kayit";
            btn_Kayit.Size = new Size(82, 26);
            btn_Kayit.TabIndex = 12;
            btn_Kayit.Text = "Kayıt Ol";
            btn_Kayit.UseVisualStyleBackColor = true;
            btn_Kayit.Click += btn_Kayit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pctBxImage);
            panel2.Controls.Add(txt_Kilo);
            panel2.Controls.Add(txt_Ad);
            panel2.Controls.Add(label_Kilo);
            panel2.Controls.Add(txt_Soyad);
            panel2.Controls.Add(txt_Boy);
            panel2.Controls.Add(txt_Mail);
            panel2.Controls.Add(label_Boy);
            panel2.Location = new Point(278, 8);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 398);
            panel2.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 314);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 20;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 244);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 19;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 195);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 18;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 150);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 17;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 102);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 16;
            label1.Text = "label1";
            // 
            // pctBxImage
            // 
            pctBxImage.BackColor = Color.White;
            pctBxImage.Location = new Point(62, 16);
            pctBxImage.Margin = new Padding(3, 2, 3, 2);
            pctBxImage.Name = "pctBxImage";
            pctBxImage.Size = new Size(123, 72);
            pctBxImage.TabIndex = 1;
            pctBxImage.TabStop = false;
            pctBxImage.Click += pctBxImage_Click;
            // 
            // txt_Kilo
            // 
            txt_Kilo.ForeColor = Color.DarkGray;
            txt_Kilo.Location = new Point(46, 350);
            txt_Kilo.Margin = new Padding(3, 2, 3, 2);
            txt_Kilo.Name = "txt_Kilo";
            txt_Kilo.PlaceholderText = "Örnek: 50.2 kg";
            txt_Kilo.Size = new Size(157, 23);
            txt_Kilo.TabIndex = 15;
            // 
            // txt_Ad
            // 
            txt_Ad.ForeColor = Color.DarkGray;
            txt_Ad.Location = new Point(46, 116);
            txt_Ad.Margin = new Padding(3, 2, 3, 2);
            txt_Ad.Name = "txt_Ad";
            txt_Ad.PlaceholderText = "Adınızı giriniz";
            txt_Ad.Size = new Size(157, 23);
            txt_Ad.TabIndex = 3;
            // 
            // label_Kilo
            // 
            label_Kilo.AutoSize = true;
            label_Kilo.BackColor = Color.RosyBrown;
            label_Kilo.BorderStyle = BorderStyle.Fixed3D;
            label_Kilo.ImageAlign = ContentAlignment.MiddleLeft;
            label_Kilo.Location = new Point(46, 331);
            label_Kilo.Name = "label_Kilo";
            label_Kilo.Size = new Size(90, 17);
            label_Kilo.TabIndex = 14;
            label_Kilo.Text = "Kilonuzu giriniz\r\n";
            label_Kilo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txt_Soyad
            // 
            txt_Soyad.ForeColor = Color.DarkGray;
            txt_Soyad.Location = new Point(46, 166);
            txt_Soyad.Margin = new Padding(3, 2, 3, 2);
            txt_Soyad.Name = "txt_Soyad";
            txt_Soyad.PlaceholderText = "Soyadınızı giriniz";
            txt_Soyad.Size = new Size(157, 23);
            txt_Soyad.TabIndex = 4;
            // 
            // txt_Boy
            // 
            txt_Boy.ForeColor = Color.DarkGray;
            txt_Boy.Location = new Point(46, 282);
            txt_Boy.Margin = new Padding(3, 2, 3, 2);
            txt_Boy.Name = "txt_Boy";
            txt_Boy.PlaceholderText = "Örnek: 160 cm";
            txt_Boy.Size = new Size(157, 23);
            txt_Boy.TabIndex = 13;
            // 
            // txt_Mail
            // 
            txt_Mail.ForeColor = Color.DarkGray;
            txt_Mail.Location = new Point(46, 212);
            txt_Mail.Margin = new Padding(3, 2, 3, 2);
            txt_Mail.Name = "txt_Mail";
            txt_Mail.PlaceholderText = "Mail adresi giriniz";
            txt_Mail.Size = new Size(157, 23);
            txt_Mail.TabIndex = 5;
            // 
            // label_Boy
            // 
            label_Boy.AutoSize = true;
            label_Boy.BackColor = Color.RosyBrown;
            label_Boy.BorderStyle = BorderStyle.Fixed3D;
            label_Boy.Location = new Point(46, 263);
            label_Boy.Name = "label_Boy";
            label_Boy.Size = new Size(97, 17);
            label_Boy.TabIndex = 12;
            label_Boy.Text = "Boyunuzu giriniz\r\n";
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 208, 177);
            ClientSize = new Size(873, 431);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            ForeColor = Color.DarkRed;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserRegister";
            Text = "Kullanıcı Kayıt";
            FormClosed += UserRegister_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctBxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_yasControl;
        private DateTimePicker dateTimePicker1;
        private RadioButton btn_erkek;
        private RadioButton btn_kadin;
        private ComboBox cmbScrtyQue;
        private Label label_GuvenlikSorusu;
        private Label label_Parola;
        private TextBox txt_Parola;
        private TextBox txt_ParolaTekrar;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pctBxImage;
        private TextBox txt_Kilo;
        private TextBox txt_Ad;
        private Label label_Kilo;
        private TextBox txt_Soyad;
        private TextBox txt_Boy;
        private TextBox txt_Mail;
        private Label label_Boy;
        private Label label_DogumTarihi;
        private Button btn_Kayit;
        private Label label_GuvenlikSorusuCevabi;
        private TextBox txt_GuvenlikSorusuCevabi;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}