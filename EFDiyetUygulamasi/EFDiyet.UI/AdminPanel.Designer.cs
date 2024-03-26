namespace EFDiyet.UI
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            lblAdmin = new Label();
            lblAnalizA = new Label();
            lblEkDegisimler = new Label();
            lblBesinEkle = new Label();
            pbAnaliz = new PictureBox();
            pbOgunEkle = new PictureBox();
            pbBesinEkle = new PictureBox();
            lblDietAppA = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbAnaliz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOgunEkle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBesinEkle).BeginInit();
            SuspendLayout();
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.BackColor = Color.FromArgb(255, 208, 177);
            lblAdmin.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdmin.Location = new Point(753, 22);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(60, 23);
            lblAdmin.TabIndex = 24;
            lblAdmin.Text = "Admin";
            lblAdmin.Click += lblAdmin_Click;
            // 
            // lblAnalizA
            // 
            lblAnalizA.AutoSize = true;
            lblAnalizA.BackColor = Color.FromArgb(255, 208, 177);
            lblAnalizA.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAnalizA.Location = new Point(605, 22);
            lblAnalizA.Name = "lblAnalizA";
            lblAnalizA.Size = new Size(56, 23);
            lblAnalizA.TabIndex = 23;
            lblAnalizA.Text = "Analiz";
            lblAnalizA.Click += lblAnalizA_Click;
            // 
            // lblEkDegisimler
            // 
            lblEkDegisimler.AutoSize = true;
            lblEkDegisimler.BackColor = Color.FromArgb(255, 208, 177);
            lblEkDegisimler.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEkDegisimler.Location = new Point(404, 21);
            lblEkDegisimler.Name = "lblEkDegisimler";
            lblEkDegisimler.Size = new Size(113, 23);
            lblEkDegisimler.TabIndex = 22;
            lblEkDegisimler.Text = "Ek Degisimler";
            lblEkDegisimler.Click += lblEkDegisimler_Click;
            // 
            // lblBesinEkle
            // 
            lblBesinEkle.AutoSize = true;
            lblBesinEkle.BackColor = Color.FromArgb(255, 208, 177);
            lblBesinEkle.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBesinEkle.Location = new Point(243, 22);
            lblBesinEkle.Name = "lblBesinEkle";
            lblBesinEkle.Size = new Size(86, 23);
            lblBesinEkle.TabIndex = 21;
            lblBesinEkle.Text = "Besin Ekle";
            lblBesinEkle.Click += lblBesinEkle_Click;
            // 
            // pbAnaliz
            // 
            pbAnaliz.BackColor = Color.FromArgb(255, 208, 177);
            pbAnaliz.Image = (Image)resources.GetObject("pbAnaliz.Image");
            pbAnaliz.Location = new Point(555, 13);
            pbAnaliz.Name = "pbAnaliz";
            pbAnaliz.Size = new Size(45, 37);
            pbAnaliz.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnaliz.TabIndex = 20;
            pbAnaliz.TabStop = false;
            pbAnaliz.Click += pbAnaliz_Click;
            // 
            // pbOgunEkle
            // 
            pbOgunEkle.BackColor = Color.FromArgb(255, 208, 177);
            pbOgunEkle.Image = (Image)resources.GetObject("pbOgunEkle.Image");
            pbOgunEkle.Location = new Point(363, 13);
            pbOgunEkle.Name = "pbOgunEkle";
            pbOgunEkle.Size = new Size(38, 37);
            pbOgunEkle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOgunEkle.TabIndex = 19;
            pbOgunEkle.TabStop = false;
            pbOgunEkle.Click += pbOgunEkle_Click;
            // 
            // pbBesinEkle
            // 
            pbBesinEkle.BackColor = Color.FromArgb(255, 208, 177);
            pbBesinEkle.Image = (Image)resources.GetObject("pbBesinEkle.Image");
            pbBesinEkle.Location = new Point(196, 13);
            pbBesinEkle.Name = "pbBesinEkle";
            pbBesinEkle.Size = new Size(43, 37);
            pbBesinEkle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBesinEkle.TabIndex = 18;
            pbBesinEkle.TabStop = false;
            pbBesinEkle.Click += pbBesinEkle_Click;
            // 
            // lblDietAppA
            // 
            lblDietAppA.AutoSize = true;
            lblDietAppA.BackColor = Color.FromArgb(255, 208, 177);
            lblDietAppA.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDietAppA.ForeColor = Color.FromArgb(64, 0, 0);
            lblDietAppA.Location = new Point(36, 15);
            lblDietAppA.Name = "lblDietAppA";
            lblDietAppA.Size = new Size(108, 32);
            lblDietAppA.TabIndex = 17;
            lblDietAppA.Text = "DietApp";
            lblDietAppA.Click += lblDietAppA_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Location = new Point(13, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 431);
            panel1.TabIndex = 25;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(873, 527);
            Controls.Add(panel1);
            Controls.Add(lblAdmin);
            Controls.Add(lblAnalizA);
            Controls.Add(lblEkDegisimler);
            Controls.Add(lblBesinEkle);
            Controls.Add(pbOgunEkle);
            Controls.Add(pbAnaliz);
            Controls.Add(pbBesinEkle);
            Controls.Add(lblDietAppA);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Sayfası";
            FormClosed += AdminPanel_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pbAnaliz).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOgunEkle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBesinEkle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdmin;
        private Label lblAnalizA;
        private Label lblEkDegisimler;
        private Label lblBesinEkle;
        private PictureBox pbAnaliz;
        private PictureBox pbOgunEkle;
        private PictureBox pbBesinEkle;
        private Label lblDietAppA;
        private Panel panel1;
    }
}