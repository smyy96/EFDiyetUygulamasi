namespace EFDiyet.UI
{
    partial class AdminAdditionalData
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tcAdmin = new TabControl();
            tabpOgunEkle = new TabPage();
            btnOgunGuncelle = new Button();
            dgvOgunEkle = new DataGridView();
            btnOgunSil = new Button();
            tbOgunEkle = new TextBox();
            btnOgunEkle = new Button();
            tabpKategoriEkle = new TabPage();
            btnKategoriGuncelle = new Button();
            dgvKategoriEkle = new DataGridView();
            btnKategoriSil = new Button();
            tbKategoriEkle = new TextBox();
            btnKategoriEkle = new Button();
            tabpBeDe = new TabPage();
            btnBeDeGuncelle = new Button();
            dgvBeDe = new DataGridView();
            btnBeDeSil = new Button();
            tbBeDe = new TextBox();
            btnBeDeEkle = new Button();
            tcAdmin.SuspendLayout();
            tabpOgunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgunEkle).BeginInit();
            tabpKategoriEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriEkle).BeginInit();
            tabpBeDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBeDe).BeginInit();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tabpOgunEkle);
            tcAdmin.Controls.Add(tabpKategoriEkle);
            tcAdmin.Controls.Add(tabpBeDe);
            tcAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tcAdmin.Location = new Point(37, 26);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(776, 367);
            tcAdmin.SizeMode = TabSizeMode.FillToRight;
            tcAdmin.TabIndex = 26;
            // 
            // tabpOgunEkle
            // 
            tabpOgunEkle.Controls.Add(btnOgunGuncelle);
            tabpOgunEkle.Controls.Add(dgvOgunEkle);
            tabpOgunEkle.Controls.Add(btnOgunSil);
            tabpOgunEkle.Controls.Add(tbOgunEkle);
            tabpOgunEkle.Controls.Add(btnOgunEkle);
            tabpOgunEkle.Font = new Font("Javanese Text", 11F, FontStyle.Bold);
            tabpOgunEkle.ForeColor = Color.FromArgb(64, 0, 0);
            tabpOgunEkle.Location = new Point(4, 24);
            tabpOgunEkle.Name = "tabpOgunEkle";
            tabpOgunEkle.Padding = new Padding(3);
            tabpOgunEkle.Size = new Size(768, 339);
            tabpOgunEkle.TabIndex = 0;
            tabpOgunEkle.Text = "   ÖĞÜN DÜZENLEME  ";
            tabpOgunEkle.UseVisualStyleBackColor = true;
            // 
            // btnOgunGuncelle
            // 
            btnOgunGuncelle.BackColor = Color.FromArgb(64, 0, 0);
            btnOgunGuncelle.FlatAppearance.BorderSize = 0;
            btnOgunGuncelle.FlatStyle = FlatStyle.Flat;
            btnOgunGuncelle.ForeColor = Color.White;
            btnOgunGuncelle.Location = new Point(424, 281);
            btnOgunGuncelle.Name = "btnOgunGuncelle";
            btnOgunGuncelle.Size = new Size(293, 38);
            btnOgunGuncelle.TabIndex = 2;
            btnOgunGuncelle.Text = "Güncelle";
            btnOgunGuncelle.UseVisualStyleBackColor = false;
            btnOgunGuncelle.Click += btnOgunGuncelle_Click;
            // 
            // dgvOgunEkle
            // 
            dgvOgunEkle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgunEkle.BackgroundColor = Color.FromArgb(255, 208, 177);
            dgvOgunEkle.BorderStyle = BorderStyle.None;
            dgvOgunEkle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvOgunEkle.DefaultCellStyle = dataGridViewCellStyle1;
            dgvOgunEkle.GridColor = Color.DimGray;
            dgvOgunEkle.Location = new Point(20, 21);
            dgvOgunEkle.Name = "dgvOgunEkle";
            dgvOgunEkle.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOgunEkle.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOgunEkle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgunEkle.Size = new Size(344, 298);
            dgvOgunEkle.TabIndex = 4;
            dgvOgunEkle.DoubleClick += dgvOgunEkle_DoubleClick;
            // 
            // btnOgunSil
            // 
            btnOgunSil.BackColor = Color.FromArgb(123, 0, 0);
            btnOgunSil.BackgroundImageLayout = ImageLayout.None;
            btnOgunSil.FlatAppearance.BorderSize = 0;
            btnOgunSil.FlatStyle = FlatStyle.Flat;
            btnOgunSil.ForeColor = Color.White;
            btnOgunSil.Location = new Point(424, 193);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(293, 38);
            btnOgunSil.TabIndex = 1;
            btnOgunSil.Text = "Sil";
            btnOgunSil.UseVisualStyleBackColor = false;
            btnOgunSil.Click += btnOgunSil_Click;
            // 
            // tbOgunEkle
            // 
            tbOgunEkle.BackColor = Color.White;
            tbOgunEkle.Cursor = Cursors.IBeam;
            tbOgunEkle.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbOgunEkle.Location = new Point(424, 21);
            tbOgunEkle.Multiline = true;
            tbOgunEkle.Name = "tbOgunEkle";
            tbOgunEkle.Size = new Size(293, 38);
            tbOgunEkle.TabIndex = 3;
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.BackColor = Color.Firebrick;
            btnOgunEkle.FlatAppearance.BorderSize = 0;
            btnOgunEkle.FlatStyle = FlatStyle.Flat;
            btnOgunEkle.ForeColor = Color.White;
            btnOgunEkle.Location = new Point(424, 99);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(293, 38);
            btnOgunEkle.TabIndex = 0;
            btnOgunEkle.Text = "Ekle";
            btnOgunEkle.UseVisualStyleBackColor = false;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // tabpKategoriEkle
            // 
            tabpKategoriEkle.Controls.Add(btnKategoriGuncelle);
            tabpKategoriEkle.Controls.Add(dgvKategoriEkle);
            tabpKategoriEkle.Controls.Add(btnKategoriSil);
            tabpKategoriEkle.Controls.Add(tbKategoriEkle);
            tabpKategoriEkle.Controls.Add(btnKategoriEkle);
            tabpKategoriEkle.Font = new Font("Javanese Text", 11F, FontStyle.Bold);
            tabpKategoriEkle.ForeColor = Color.FromArgb(64, 0, 0);
            tabpKategoriEkle.Location = new Point(4, 24);
            tabpKategoriEkle.Name = "tabpKategoriEkle";
            tabpKategoriEkle.Padding = new Padding(3);
            tabpKategoriEkle.Size = new Size(768, 339);
            tabpKategoriEkle.TabIndex = 1;
            tabpKategoriEkle.Text = "  KATEGORİ DÜZENLEME  ";
            tabpKategoriEkle.UseVisualStyleBackColor = true;
            // 
            // btnKategoriGuncelle
            // 
            btnKategoriGuncelle.BackColor = Color.FromArgb(64, 0, 0);
            btnKategoriGuncelle.FlatAppearance.BorderSize = 0;
            btnKategoriGuncelle.FlatStyle = FlatStyle.Flat;
            btnKategoriGuncelle.ForeColor = Color.White;
            btnKategoriGuncelle.Location = new Point(424, 281);
            btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            btnKategoriGuncelle.Size = new Size(293, 38);
            btnKategoriGuncelle.TabIndex = 7;
            btnKategoriGuncelle.Text = "Güncelle";
            btnKategoriGuncelle.UseVisualStyleBackColor = false;
            btnKategoriGuncelle.Click += btnKategoriGuncelle_Click;
            // 
            // dgvKategoriEkle
            // 
            dgvKategoriEkle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKategoriEkle.BackgroundColor = Color.FromArgb(255, 208, 177);
            dgvKategoriEkle.BorderStyle = BorderStyle.None;
            dgvKategoriEkle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvKategoriEkle.DefaultCellStyle = dataGridViewCellStyle3;
            dgvKategoriEkle.Location = new Point(20, 21);
            dgvKategoriEkle.Name = "dgvKategoriEkle";
            dgvKategoriEkle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategoriEkle.Size = new Size(344, 298);
            dgvKategoriEkle.TabIndex = 9;
            dgvKategoriEkle.DoubleClick += dgvKategoriEkle_DoubleClick;
            // 
            // btnKategoriSil
            // 
            btnKategoriSil.BackColor = Color.FromArgb(123, 0, 0);
            btnKategoriSil.FlatAppearance.BorderSize = 0;
            btnKategoriSil.FlatStyle = FlatStyle.Flat;
            btnKategoriSil.ForeColor = Color.White;
            btnKategoriSil.Location = new Point(424, 193);
            btnKategoriSil.Name = "btnKategoriSil";
            btnKategoriSil.Size = new Size(293, 38);
            btnKategoriSil.TabIndex = 6;
            btnKategoriSil.Text = "Sil";
            btnKategoriSil.UseVisualStyleBackColor = false;
            btnKategoriSil.Click += btnKategoriSil_Click;
            // 
            // tbKategoriEkle
            // 
            tbKategoriEkle.BackColor = Color.White;
            tbKategoriEkle.Cursor = Cursors.IBeam;
            tbKategoriEkle.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbKategoriEkle.Location = new Point(424, 21);
            tbKategoriEkle.Multiline = true;
            tbKategoriEkle.Name = "tbKategoriEkle";
            tbKategoriEkle.Size = new Size(293, 38);
            tbKategoriEkle.TabIndex = 8;
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.BackColor = Color.Firebrick;
            btnKategoriEkle.FlatAppearance.BorderSize = 0;
            btnKategoriEkle.FlatStyle = FlatStyle.Flat;
            btnKategoriEkle.ForeColor = Color.White;
            btnKategoriEkle.Location = new Point(424, 99);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(293, 38);
            btnKategoriEkle.TabIndex = 5;
            btnKategoriEkle.Text = "Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = false;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // tabpBeDe
            // 
            tabpBeDe.Controls.Add(btnBeDeGuncelle);
            tabpBeDe.Controls.Add(dgvBeDe);
            tabpBeDe.Controls.Add(btnBeDeSil);
            tabpBeDe.Controls.Add(tbBeDe);
            tabpBeDe.Controls.Add(btnBeDeEkle);
            tabpBeDe.Font = new Font("Javanese Text", 11F, FontStyle.Bold);
            tabpBeDe.ForeColor = Color.FromArgb(64, 0, 0);
            tabpBeDe.Location = new Point(4, 24);
            tabpBeDe.Name = "tabpBeDe";
            tabpBeDe.Padding = new Padding(3);
            tabpBeDe.Size = new Size(768, 339);
            tabpBeDe.TabIndex = 2;
            tabpBeDe.Text = "  BESİN DEĞERİ DÜZENLEME  ";
            tabpBeDe.UseVisualStyleBackColor = true;
            // 
            // btnBeDeGuncelle
            // 
            btnBeDeGuncelle.BackColor = Color.FromArgb(64, 0, 0);
            btnBeDeGuncelle.FlatAppearance.BorderSize = 0;
            btnBeDeGuncelle.FlatStyle = FlatStyle.Flat;
            btnBeDeGuncelle.ForeColor = Color.White;
            btnBeDeGuncelle.Location = new Point(424, 281);
            btnBeDeGuncelle.Name = "btnBeDeGuncelle";
            btnBeDeGuncelle.Size = new Size(293, 38);
            btnBeDeGuncelle.TabIndex = 12;
            btnBeDeGuncelle.Text = "Güncelle";
            btnBeDeGuncelle.UseVisualStyleBackColor = false;
            btnBeDeGuncelle.Click += btnBeDeGuncelle_Click;
            // 
            // dgvBeDe
            // 
            dgvBeDe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBeDe.BackgroundColor = Color.FromArgb(255, 208, 177);
            dgvBeDe.BorderStyle = BorderStyle.None;
            dgvBeDe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvBeDe.DefaultCellStyle = dataGridViewCellStyle4;
            dgvBeDe.Location = new Point(20, 21);
            dgvBeDe.Name = "dgvBeDe";
            dgvBeDe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBeDe.Size = new Size(344, 298);
            dgvBeDe.TabIndex = 14;
            dgvBeDe.DoubleClick += dgvBeDe_DoubleClick;
            // 
            // btnBeDeSil
            // 
            btnBeDeSil.BackColor = Color.FromArgb(123, 0, 0);
            btnBeDeSil.FlatAppearance.BorderColor = Color.FromArgb(115, 0, 0);
            btnBeDeSil.FlatAppearance.BorderSize = 0;
            btnBeDeSil.FlatStyle = FlatStyle.Flat;
            btnBeDeSil.ForeColor = Color.White;
            btnBeDeSil.Location = new Point(424, 193);
            btnBeDeSil.Name = "btnBeDeSil";
            btnBeDeSil.Size = new Size(293, 38);
            btnBeDeSil.TabIndex = 11;
            btnBeDeSil.Text = "Sil";
            btnBeDeSil.UseVisualStyleBackColor = false;
            btnBeDeSil.Click += btnBeDeSil_Click;
            // 
            // tbBeDe
            // 
            tbBeDe.BackColor = Color.White;
            tbBeDe.Cursor = Cursors.IBeam;
            tbBeDe.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbBeDe.Location = new Point(424, 21);
            tbBeDe.Multiline = true;
            tbBeDe.Name = "tbBeDe";
            tbBeDe.Size = new Size(293, 38);
            tbBeDe.TabIndex = 13;
            // 
            // btnBeDeEkle
            // 
            btnBeDeEkle.BackColor = Color.Firebrick;
            btnBeDeEkle.FlatAppearance.BorderColor = Color.Firebrick;
            btnBeDeEkle.FlatAppearance.BorderSize = 0;
            btnBeDeEkle.FlatStyle = FlatStyle.Flat;
            btnBeDeEkle.ForeColor = Color.White;
            btnBeDeEkle.Location = new Point(424, 99);
            btnBeDeEkle.Name = "btnBeDeEkle";
            btnBeDeEkle.Size = new Size(293, 38);
            btnBeDeEkle.TabIndex = 10;
            btnBeDeEkle.Text = "Ekle";
            btnBeDeEkle.UseVisualStyleBackColor = false;
            btnBeDeEkle.Click += btnBeDeEkle_Click;
            // 
            // AdminAdditionalData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(tcAdmin);
            Name = "AdminAdditionalData";
            Size = new Size(848, 422);
            Load += AdminAdditionalData_Load;
            tcAdmin.ResumeLayout(false);
            tabpOgunEkle.ResumeLayout(false);
            tabpOgunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgunEkle).EndInit();
            tabpKategoriEkle.ResumeLayout(false);
            tabpKategoriEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriEkle).EndInit();
            tabpBeDe.ResumeLayout(false);
            tabpBeDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBeDe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tabpOgunEkle;
        private Button btnOgunGuncelle;
        private DataGridView dgvOgunEkle;
        private Button btnOgunSil;
        private TextBox tbOgunEkle;
        private Button btnOgunEkle;
        private TabPage tabpKategoriEkle;
        private Button btnKategoriGuncelle;
        private DataGridView dgvKategoriEkle;
        private Button btnKategoriSil;
        private TextBox tbKategoriEkle;
        private Button btnKategoriEkle;
        private TabPage tabpBeDe;
        private Button btnBeDeGuncelle;
        private DataGridView dgvBeDe;
        private Button btnBeDeSil;
        private TextBox tbBeDe;
        private Button btnBeDeEkle;
    }
}
