namespace formlarg
{
    partial class AdminBosF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBosF));
            pbBesinEkle = new PictureBox();
            pbOgunEkle = new PictureBox();
            pbAnaliz = new PictureBox();
            lblDietAppA = new Label();
            lblBesinEkle = new Label();
            lblEkDegisimler = new Label();
            lblAnalizA = new Label();
            lblAdmin = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBesinEkle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOgunEkle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAnaliz).BeginInit();
            SuspendLayout();
            // 
            // pbBesinEkle
            // 
            pbBesinEkle.BackColor = Color.FromArgb(255, 208, 177);
            pbBesinEkle.Image = (Image)resources.GetObject("pbBesinEkle.Image");
            pbBesinEkle.Location = new Point(177, 9);
            pbBesinEkle.Name = "pbBesinEkle";
            pbBesinEkle.Size = new Size(43, 38);
            pbBesinEkle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBesinEkle.TabIndex = 0;
            pbBesinEkle.TabStop = false;
            // 
            // pbOgunEkle
            // 
            pbOgunEkle.BackColor = Color.FromArgb(255, 208, 177);
            pbOgunEkle.Image = (Image)resources.GetObject("pbOgunEkle.Image");
            pbOgunEkle.Location = new Point(327, 9);
            pbOgunEkle.Name = "pbOgunEkle";
            pbOgunEkle.Size = new Size(42, 38);
            pbOgunEkle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOgunEkle.TabIndex = 1;
            pbOgunEkle.TabStop = false;
            // 
            // pbAnaliz
            // 
            pbAnaliz.BackColor = Color.FromArgb(255, 208, 177);
            pbAnaliz.Image = (Image)resources.GetObject("pbAnaliz.Image");
            pbAnaliz.Location = new Point(496, 9);
            pbAnaliz.Name = "pbAnaliz";
            pbAnaliz.Size = new Size(45, 38);
            pbAnaliz.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnaliz.TabIndex = 2;
            pbAnaliz.TabStop = false;
            // 
            // lblDietAppA
            // 
            lblDietAppA.AutoSize = true;
            lblDietAppA.BackColor = Color.FromArgb(255, 208, 177);
            lblDietAppA.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDietAppA.Location = new Point(22, 9);
            lblDietAppA.Name = "lblDietAppA";
            lblDietAppA.Size = new Size(108, 32);
            lblDietAppA.TabIndex = 4;
            lblDietAppA.Text = "DietApp";
            // 
            // lblBesinEkle
            // 
            lblBesinEkle.AutoSize = true;
            lblBesinEkle.BackColor = Color.FromArgb(255, 208, 177);
            lblBesinEkle.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBesinEkle.Location = new Point(226, 18);
            lblBesinEkle.Name = "lblBesinEkle";
            lblBesinEkle.Size = new Size(86, 23);
            lblBesinEkle.TabIndex = 5;
            lblBesinEkle.Text = "Besin Ekle";
            // 
            // lblEkDegisimler
            // 
            lblEkDegisimler.AutoSize = true;
            lblEkDegisimler.BackColor = Color.FromArgb(255, 208, 177);
            lblEkDegisimler.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEkDegisimler.Location = new Point(365, 17);
            lblEkDegisimler.Name = "lblEkDegisimler";
            lblEkDegisimler.Size = new Size(113, 23);
            lblEkDegisimler.TabIndex = 6;
            lblEkDegisimler.Text = "Ek Değişimler";
            // 
            // lblAnalizA
            // 
            lblAnalizA.AutoSize = true;
            lblAnalizA.BackColor = Color.FromArgb(255, 208, 177);
            lblAnalizA.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAnalizA.Location = new Point(560, 18);
            lblAnalizA.Name = "lblAnalizA";
            lblAnalizA.Size = new Size(56, 23);
            lblAnalizA.TabIndex = 7;
            lblAnalizA.Text = "Analiz";
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.BackColor = Color.FromArgb(255, 208, 177);
            lblAdmin.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdmin.Location = new Point(688, 18);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(60, 23);
            lblAdmin.TabIndex = 8;
            lblAdmin.Text = "Admin";
            // 
            // AdminBosF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 436);
            Controls.Add(lblAdmin);
            Controls.Add(lblAnalizA);
            Controls.Add(lblEkDegisimler);
            Controls.Add(lblBesinEkle);
            Controls.Add(lblDietAppA);
            Controls.Add(pbAnaliz);
            Controls.Add(pbOgunEkle);
            Controls.Add(pbBesinEkle);
            DoubleBuffered = true;
            Name = "AdminBosF";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbBesinEkle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOgunEkle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAnaliz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBesinEkle;
        private PictureBox pbOgunEkle;
        private PictureBox pbAnaliz;
        private Label lblDietAppA;
        private Label lblBesinEkle;
        private Label lblEkDegisimler;
        private Label lblAnalizA;
        private Label lblAdmin;
    }
}
