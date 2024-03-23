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
            label_DogumTarihi = new Label();
            btn_erkek = new RadioButton();
            btn_kadin = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            label_yasControl = new Label();
            comboBox1 = new ComboBox();
            label_GuvenlikSorusu = new Label();
            label_Parola = new Label();
            txt_Parola = new TextBox();
            txt_ParolaTekrar = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label_GuvenlikSorusuCevabi = new Label();
            txt_GuvenlikSorusuCevabi = new TextBox();
            btn_Kayit = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btn_resim = new Button();
            textBox1 = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 222, 200);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label_DogumTarihi);
            panel1.Controls.Add(btn_erkek);
            panel1.Controls.Add(btn_kadin);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label_yasControl);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.RosyBrown;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 501);
            panel1.TabIndex = 0;
            // 
            // label_DogumTarihi
            // 
            label_DogumTarihi.AutoSize = true;
            label_DogumTarihi.Location = new Point(11, 92);
            label_DogumTarihi.Name = "label_DogumTarihi";
            label_DogumTarihi.Size = new Size(167, 20);
            label_DogumTarihi.TabIndex = 5;
            label_DogumTarihi.Text = "Doğum Tarihinizi Giriniz";
            // 
            // btn_erkek
            // 
            btn_erkek.AutoSize = true;
            btn_erkek.Location = new Point(135, 237);
            btn_erkek.Name = "btn_erkek";
            btn_erkek.Size = new Size(65, 24);
            btn_erkek.TabIndex = 4;
            btn_erkek.TabStop = true;
            btn_erkek.Text = "Erkek";
            btn_erkek.UseVisualStyleBackColor = true;
            // 
            // btn_kadin
            // 
            btn_kadin.AutoSize = true;
            btn_kadin.Location = new Point(46, 237);
            btn_kadin.Name = "btn_kadin";
            btn_kadin.Size = new Size(68, 24);
            btn_kadin.TabIndex = 3;
            btn_kadin.TabStop = true;
            btn_kadin.Text = "Kadın";
            btn_kadin.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(11, 115);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2024, 3, 22, 0, 0, 0, 0);
            // 
            // label_yasControl
            // 
            label_yasControl.Font = new Font("Segoe UI", 7F);
            label_yasControl.ForeColor = Color.DarkRed;
            label_yasControl.Location = new Point(11, 461);
            label_yasControl.Name = "label_yasControl";
            label_yasControl.Size = new Size(261, 31);
            label_yasControl.TabIndex = 1;
            label_yasControl.Text = "Bu uygulama 18-35 yaş arası bireyleri kapsamaktadır!";
            label_yasControl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hangi futbol takımını tutuyorsunuz?", "İlkokul öğretmeninizin adı nedir?", "İlk evcil hayvanınızın adı nedir?", "İlk aşkınızın adı nedir?", "En sevdiğiniz film hangisidir?", "En sevdiğiniz renk nedir?", "En sevdiğiniz yiyecek nedir?", "İlk çocukluk arkadaşınızın adı nedir?" });
            comboBox1.Location = new Point(17, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 28);
            comboBox1.TabIndex = 6;
            // 
            // label_GuvenlikSorusu
            // 
            label_GuvenlikSorusu.AutoSize = true;
            label_GuvenlikSorusu.BackColor = Color.RosyBrown;
            label_GuvenlikSorusu.BorderStyle = BorderStyle.Fixed3D;
            label_GuvenlikSorusu.Location = new Point(17, 31);
            label_GuvenlikSorusu.Name = "label_GuvenlikSorusu";
            label_GuvenlikSorusu.Size = new Size(165, 22);
            label_GuvenlikSorusu.TabIndex = 7;
            label_GuvenlikSorusu.Text = "Güvenlik Sorusu Seçiniz";
            // 
            // label_Parola
            // 
            label_Parola.AutoSize = true;
            label_Parola.BackColor = Color.RosyBrown;
            label_Parola.BorderStyle = BorderStyle.Fixed3D;
            label_Parola.Location = new Point(17, 269);
            label_Parola.Name = "label_Parola";
            label_Parola.Size = new Size(128, 22);
            label_Parola.TabIndex = 9;
            label_Parola.Text = "Parola Belirleyiniz\r\n";
            // 
            // txt_Parola
            // 
            txt_Parola.ForeColor = Color.DarkGray;
            txt_Parola.Location = new Point(17, 299);
            txt_Parola.Name = "txt_Parola";
            txt_Parola.PlaceholderText = "Parolanızı giriniz";
            txt_Parola.Size = new Size(173, 27);
            txt_Parola.TabIndex = 10;
            // 
            // txt_ParolaTekrar
            // 
            txt_ParolaTekrar.ForeColor = Color.DarkGray;
            txt_ParolaTekrar.Location = new Point(17, 332);
            txt_ParolaTekrar.Name = "txt_ParolaTekrar";
            txt_ParolaTekrar.PlaceholderText = "Parolanızı tekrar giriniz";
            txt_ParolaTekrar.Size = new Size(173, 27);
            txt_ParolaTekrar.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(279, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(815, 501);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label_GuvenlikSorusuCevabi);
            panel3.Controls.Add(txt_GuvenlikSorusuCevabi);
            panel3.Controls.Add(btn_Kayit);
            panel3.Controls.Add(label_GuvenlikSorusu);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label_Parola);
            panel3.Controls.Add(txt_ParolaTekrar);
            panel3.Controls.Add(txt_Parola);
            panel3.Location = new Point(729, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 451);
            panel3.TabIndex = 20;
            // 
            // label_GuvenlikSorusuCevabi
            // 
            label_GuvenlikSorusuCevabi.AutoSize = true;
            label_GuvenlikSorusuCevabi.BackColor = Color.RosyBrown;
            label_GuvenlikSorusuCevabi.BorderStyle = BorderStyle.Fixed3D;
            label_GuvenlikSorusuCevabi.Location = new Point(17, 151);
            label_GuvenlikSorusuCevabi.Name = "label_GuvenlikSorusuCevabi";
            label_GuvenlikSorusuCevabi.Size = new Size(246, 22);
            label_GuvenlikSorusuCevabi.TabIndex = 14;
            label_GuvenlikSorusuCevabi.Text = "Güvenlik Sorusunun Cevabını Giriniz";
            // 
            // txt_GuvenlikSorusuCevabi
            // 
            txt_GuvenlikSorusuCevabi.Location = new Point(17, 176);
            txt_GuvenlikSorusuCevabi.Name = "txt_GuvenlikSorusuCevabi";
            txt_GuvenlikSorusuCevabi.Size = new Size(210, 27);
            txt_GuvenlikSorusuCevabi.TabIndex = 13;
            // 
            // btn_Kayit
            // 
            btn_Kayit.Location = new Point(169, 392);
            btn_Kayit.Name = "btn_Kayit";
            btn_Kayit.Size = new Size(94, 35);
            btn_Kayit.TabIndex = 12;
            btn_Kayit.Text = "Kayıt Ol";
            btn_Kayit.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btn_resim);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(txt_Ad);
            panel2.Controls.Add(label_Kilo);
            panel2.Controls.Add(txt_Soyad);
            panel2.Controls.Add(txt_Boy);
            panel2.Controls.Add(txt_Mail);
            panel2.Controls.Add(label_Boy);
            panel2.Location = new Point(363, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 451);
            panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(81, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 79);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_resim
            // 
            btn_resim.BackColor = Color.RosyBrown;
            btn_resim.ForeColor = Color.DarkRed;
            btn_resim.Location = new Point(81, 116);
            btn_resim.Name = "btn_resim";
            btn_resim.Size = new Size(94, 29);
            btn_resim.TabIndex = 2;
            btn_resim.Text = "Yükle";
            btn_resim.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Location = new Point(70, 396);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Örnek: 50.2 kg";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 15;
            // 
            // txt_Ad
            // 
            txt_Ad.ForeColor = Color.DarkGray;
            txt_Ad.Location = new Point(70, 168);
            txt_Ad.Name = "txt_Ad";
            txt_Ad.PlaceholderText = "Adınızı giriniz";
            txt_Ad.Size = new Size(125, 27);
            txt_Ad.TabIndex = 3;
            // 
            // label_Kilo
            // 
            label_Kilo.AutoSize = true;
            label_Kilo.BackColor = Color.RosyBrown;
            label_Kilo.BorderStyle = BorderStyle.Fixed3D;
            label_Kilo.ImageAlign = ContentAlignment.MiddleLeft;
            label_Kilo.Location = new Point(70, 371);
            label_Kilo.Name = "label_Kilo";
            label_Kilo.Size = new Size(113, 22);
            label_Kilo.TabIndex = 14;
            label_Kilo.Text = "Kilonuzu giriniz\r\n";
            label_Kilo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txt_Soyad
            // 
            txt_Soyad.ForeColor = Color.DarkGray;
            txt_Soyad.Location = new Point(70, 201);
            txt_Soyad.Name = "txt_Soyad";
            txt_Soyad.PlaceholderText = "Soyadınızı giriniz";
            txt_Soyad.Size = new Size(125, 27);
            txt_Soyad.TabIndex = 4;
            // 
            // txt_Boy
            // 
            txt_Boy.ForeColor = Color.DarkGray;
            txt_Boy.Location = new Point(70, 323);
            txt_Boy.Name = "txt_Boy";
            txt_Boy.PlaceholderText = "Örnek: 160 cm";
            txt_Boy.Size = new Size(125, 27);
            txt_Boy.TabIndex = 13;
            // 
            // txt_Mail
            // 
            txt_Mail.ForeColor = Color.DarkGray;
            txt_Mail.Location = new Point(70, 251);
            txt_Mail.Name = "txt_Mail";
            txt_Mail.PlaceholderText = "Mail adresi giriniz";
            txt_Mail.Size = new Size(125, 27);
            txt_Mail.TabIndex = 5;
            // 
            // label_Boy
            // 
            label_Boy.AutoSize = true;
            label_Boy.BackColor = Color.RosyBrown;
            label_Boy.BorderStyle = BorderStyle.Fixed3D;
            label_Boy.Location = new Point(70, 300);
            label_Boy.Name = "label_Boy";
            label_Boy.Size = new Size(120, 22);
            label_Boy.TabIndex = 12;
            label_Boy.Text = "Boyunuzu giriniz\r\n";
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 208, 177);
            ClientSize = new Size(1085, 501);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            ForeColor = Color.DarkRed;
            Name = "UserRegister";
            Text = "Kullanıcı Kayıt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_yasControl;
        private DateTimePicker dateTimePicker1;
        private RadioButton btn_erkek;
        private RadioButton btn_kadin;
        private ComboBox comboBox1;
        private Label label_GuvenlikSorusu;
        private Label label_Parola;
        private TextBox txt_Parola;
        private TextBox txt_ParolaTekrar;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btn_resim;
        private TextBox textBox1;
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
    }
}