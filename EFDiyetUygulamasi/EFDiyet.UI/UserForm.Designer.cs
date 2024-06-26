namespace EFDiyet.UI
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            lblKullanici = new Label();
            lblAnalizU = new Label();
            lblGecmis = new Label();
            lblAnasayfa = new Label();
            lblDietAppU = new Label();
            pbUserProfile = new PictureBox();
            pbAnalizU = new PictureBox();
            pbGecmis = new PictureBox();
            pbAnasayfa = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbUserProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAnalizU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGecmis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAnasayfa).BeginInit();
            SuspendLayout();
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.BackColor = Color.FromArgb(255, 208, 177);
            lblKullanici.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKullanici.Location = new Point(699, 8);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(78, 46);
            lblKullanici.TabIndex = 17;
            lblKullanici.Text = "Kullanıcı \r\nProfile";
            lblKullanici.TextAlign = ContentAlignment.MiddleCenter;
            lblKullanici.Click += lblKullanici_Click;
            // 
            // lblAnalizU
            // 
            lblAnalizU.AutoSize = true;
            lblAnalizU.BackColor = Color.FromArgb(255, 208, 177);
            lblAnalizU.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAnalizU.Location = new Point(556, 20);
            lblAnalizU.Name = "lblAnalizU";
            lblAnalizU.Size = new Size(56, 23);
            lblAnalizU.TabIndex = 16;
            lblAnalizU.Text = "Analiz";
            lblAnalizU.Click += lblAnalizU_Click;
            // 
            // lblGecmis
            // 
            lblGecmis.AutoSize = true;
            lblGecmis.BackColor = Color.FromArgb(255, 208, 177);
            lblGecmis.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGecmis.Location = new Point(391, 20);
            lblGecmis.Name = "lblGecmis";
            lblGecmis.Size = new Size(65, 23);
            lblGecmis.TabIndex = 15;
            lblGecmis.Text = "Geçmiş";
            lblGecmis.Click += lblGecmis_Click;
            // 
            // lblAnasayfa
            // 
            lblAnasayfa.AutoSize = true;
            lblAnasayfa.BackColor = Color.FromArgb(255, 208, 177);
            lblAnasayfa.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAnasayfa.Location = new Point(216, 20);
            lblAnasayfa.Name = "lblAnasayfa";
            lblAnasayfa.Size = new Size(93, 23);
            lblAnasayfa.TabIndex = 14;
            lblAnasayfa.Text = "ANASAYFA";
            lblAnasayfa.Click += lblAnasayfa_Click;
            // 
            // lblDietAppU
            // 
            lblDietAppU.AutoSize = true;
            lblDietAppU.BackColor = Color.FromArgb(255, 208, 177);
            lblDietAppU.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDietAppU.Location = new Point(25, 14);
            lblDietAppU.Name = "lblDietAppU";
            lblDietAppU.Size = new Size(108, 32);
            lblDietAppU.TabIndex = 13;
            lblDietAppU.Text = "DietApp";
            lblDietAppU.Click += lblDietAppU_Click;
            // 
            // pbUserProfile
            // 
            pbUserProfile.BackColor = Color.FromArgb(255, 208, 177);
            pbUserProfile.Image = Properties.Resources.user;
            pbUserProfile.Location = new Point(654, 13);
            pbUserProfile.Name = "pbUserProfile";
            pbUserProfile.Size = new Size(37, 36);
            pbUserProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserProfile.TabIndex = 12;
            pbUserProfile.TabStop = false;
            pbUserProfile.Click += pbUserProfile_Click;
            // 
            // pbAnalizU
            // 
            pbAnalizU.BackColor = Color.FromArgb(255, 208, 177);
            pbAnalizU.Image = (Image)resources.GetObject("pbAnalizU.Image");
            pbAnalizU.Location = new Point(503, 12);
            pbAnalizU.Name = "pbAnalizU";
            pbAnalizU.Size = new Size(45, 37);
            pbAnalizU.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnalizU.TabIndex = 11;
            pbAnalizU.TabStop = false;
            pbAnalizU.Click += pbAnalizU_Click;
            // 
            // pbGecmis
            // 
            pbGecmis.BackColor = Color.FromArgb(255, 208, 177);
            pbGecmis.Image = (Image)resources.GetObject("pbGecmis.Image");
            pbGecmis.Location = new Point(344, 12);
            pbGecmis.Name = "pbGecmis";
            pbGecmis.Size = new Size(42, 37);
            pbGecmis.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGecmis.TabIndex = 10;
            pbGecmis.TabStop = false;
            pbGecmis.Click += pbGecmis_Click;
            // 
            // pbAnasayfa
            // 
            pbAnasayfa.BackColor = Color.FromArgb(255, 208, 177);
            pbAnasayfa.Image = (Image)resources.GetObject("pbAnasayfa.Image");
            pbAnasayfa.Location = new Point(172, 12);
            pbAnasayfa.Name = "pbAnasayfa";
            pbAnasayfa.Size = new Size(43, 37);
            pbAnasayfa.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnasayfa.TabIndex = 9;
            pbAnasayfa.TabStop = false;
            pbAnasayfa.Click += pbAnasayfa_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Location = new Point(5, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 407);
            panel1.TabIndex = 18;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 486);
            Controls.Add(panel1);
            Controls.Add(lblKullanici);
            Controls.Add(lblAnalizU);
            Controls.Add(lblGecmis);
            Controls.Add(lblAnasayfa);
            Controls.Add(lblDietAppU);
            Controls.Add(pbUserProfile);
            Controls.Add(pbAnalizU);
            Controls.Add(pbGecmis);
            Controls.Add(pbAnasayfa);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Sayfası";
            FormClosed += UserForm_FormClosed;
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbUserProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAnalizU).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGecmis).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAnasayfa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKullanici;
        private Label lblAnalizU;
        private Label lblGecmis;
        private Label lblAnasayfa;
        private Label lblDietAppU;
        private PictureBox pbUserProfile;
        private PictureBox pbAnalizU;
        private PictureBox pbGecmis;
        private PictureBox pbAnasayfa;
        private Panel panel1;
    }
}