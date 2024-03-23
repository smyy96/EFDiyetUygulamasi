
namespace efdiyet
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            cmbSifreGoster = new CheckBox();
            btnGirisYap = new Button();
            btnKayitOl = new Button();
            lblHenuz = new Label();
            lblGirisYapin = new Label();
            lblDietapp = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(84, 162);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "  E-Mail";
            txtEmail.Size = new Size(250, 20);
            txtEmail.TabIndex = 16;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.White;
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Cursor = Cursors.IBeam;
            txtSifre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.ForeColor = Color.DimGray;
            txtSifre.Location = new Point(84, 203);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.PlaceholderText = "  Şifre";
            txtSifre.Size = new Size(250, 20);
            txtSifre.TabIndex = 16;
            // 
            // cmbSifreGoster
            // 
            cmbSifreGoster.AutoSize = true;
            cmbSifreGoster.BackColor = Color.FromArgb(254, 222, 201);
            cmbSifreGoster.ForeColor = Color.FromArgb(64, 0, 0);
            cmbSifreGoster.Location = new Point(84, 236);
            cmbSifreGoster.Name = "cmbSifreGoster";
            cmbSifreGoster.Size = new Size(95, 19);
            cmbSifreGoster.TabIndex = 2;
            cmbSifreGoster.Text = "Şifreyi Göster";
            cmbSifreGoster.TextAlign = ContentAlignment.MiddleRight;
            cmbSifreGoster.UseVisualStyleBackColor = false;
            cmbSifreGoster.Click += cmbSifreGoster_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.LightGray;
            btnGirisYap.FlatAppearance.BorderSize = 0;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.ForeColor = Color.FromArgb(64, 0, 0);
            btnGirisYap.Location = new Point(84, 273);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(250, 26);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.LightGray;
            btnKayitOl.FlatAppearance.BorderSize = 0;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.ForeColor = Color.FromArgb(64, 0, 0);
            btnKayitOl.Location = new Point(84, 342);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(250, 25);
            btnKayitOl.TabIndex = 4;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // lblHenuz
            // 
            lblHenuz.AutoSize = true;
            lblHenuz.BackColor = Color.FromArgb(254, 222, 201);
            lblHenuz.ForeColor = Color.FromArgb(64, 0, 0);
            lblHenuz.Location = new Point(135, 324);
            lblHenuz.Name = "lblHenuz";
            lblHenuz.Size = new Size(150, 15);
            lblHenuz.TabIndex = 5;
            lblHenuz.Text = "Henüz bir hesabın yok mu?";
            // 
            // lblGirisYapin
            // 
            lblGirisYapin.AutoSize = true;
            lblGirisYapin.BackColor = Color.FromArgb(254, 222, 201);
            lblGirisYapin.ForeColor = Color.FromArgb(64, 0, 0);
            lblGirisYapin.Location = new Point(84, 143);
            lblGirisYapin.Name = "lblGirisYapin";
            lblGirisYapin.Size = new Size(62, 15);
            lblGirisYapin.TabIndex = 6;
            lblGirisYapin.Text = "Giriş Yapın";
            lblGirisYapin.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDietapp
            // 
            lblDietapp.AutoSize = true;
            lblDietapp.BackColor = Color.FromArgb(254, 222, 201);
            lblDietapp.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDietapp.ForeColor = Color.FromArgb(64, 0, 0);
            lblDietapp.Location = new Point(144, 81);
            lblDietapp.Name = "lblDietapp";
            lblDietapp.Size = new Size(124, 37);
            lblDietapp.TabIndex = 7;
            lblDietapp.Text = "DietApp";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 208, 177);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(362, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 374);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblDietapp);
            Controls.Add(lblGirisYapin);
            Controls.Add(lblHenuz);
            Controls.Add(btnKayitOl);
            Controls.Add(btnGirisYap);
            Controls.Add(cmbSifreGoster);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            DoubleBuffered = true;
            Name = "LoginForm";
            Text = "Giriş Sayfası";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtSifre;
        private CheckBox cmbSifreGoster;
        private Button btnGirisYap;
        private Button btnKayitOl;
        private Label lblHenuz;
        private Label lblGirisYapin;
        private Label lblDietapp;
        private PictureBox pictureBox1;
    }
}
