namespace EFDiyet.UI
{
    partial class AdminAnalysisPage
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
            panel1 = new Panel();
            dgvGenelTuketilen = new DataGridView();
            dgvKategoriyeGore = new DataGridView();
            dgvOguneGore = new DataGridView();
            rbAylik = new RadioButton();
            lblGenelTuketilen = new Label();
            rbHaftalik = new RadioButton();
            cmbUsers = new ComboBox();
            lblOguneGore = new Label();
            lblKategoriyeGore = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenelTuketilen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriyeGore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOguneGore).BeginInit();
            SuspendLayout();
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
            panel1.Controls.Add(cmbUsers);
            panel1.Controls.Add(lblOguneGore);
            panel1.Controls.Add(lblKategoriyeGore);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 431);
            panel1.TabIndex = 21;
            // 
            // dgvGenelTuketilen
            // 
            dgvGenelTuketilen.BackgroundColor = Color.FromArgb(255, 208, 177);
            dgvGenelTuketilen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenelTuketilen.Location = new Point(406, 79);
            dgvGenelTuketilen.Name = "dgvGenelTuketilen";
            dgvGenelTuketilen.Size = new Size(417, 329);
            dgvGenelTuketilen.TabIndex = 29;
            // 
            // dgvKategoriyeGore
            // 
            dgvKategoriyeGore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKategoriyeGore.BackgroundColor = Color.FromArgb(255, 208, 177);
            dgvKategoriyeGore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategoriyeGore.Location = new Point(19, 80);
            dgvKategoriyeGore.Name = "dgvKategoriyeGore";
            dgvKategoriyeGore.Size = new Size(353, 136);
            dgvKategoriyeGore.TabIndex = 28;
            // 
            // dgvOguneGore
            // 
            dgvOguneGore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOguneGore.BackgroundColor = Color.FromArgb(255, 208, 177);
            dgvOguneGore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOguneGore.Location = new Point(19, 256);
            dgvOguneGore.Name = "dgvOguneGore";
            dgvOguneGore.Size = new Size(353, 153);
            dgvOguneGore.TabIndex = 27;
            // 
            // rbAylik
            // 
            rbAylik.AutoSize = true;
            rbAylik.BackColor = Color.Firebrick;
            rbAylik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbAylik.ForeColor = Color.White;
            rbAylik.Location = new Point(609, 10);
            rbAylik.Name = "rbAylik";
            rbAylik.Size = new Size(120, 25);
            rbAylik.TabIndex = 26;
            rbAylik.TabStop = true;
            rbAylik.Text = "Aylık Listele";
            rbAylik.UseVisualStyleBackColor = false;
            rbAylik.CheckedChanged += rbAylik_CheckedChanged;
            // 
            // lblGenelTuketilen
            // 
            lblGenelTuketilen.AutoSize = true;
            lblGenelTuketilen.BackColor = Color.Firebrick;
            lblGenelTuketilen.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGenelTuketilen.ForeColor = Color.White;
            lblGenelTuketilen.Location = new Point(406, 52);
            lblGenelTuketilen.Name = "lblGenelTuketilen";
            lblGenelTuketilen.Size = new Size(143, 19);
            lblGenelTuketilen.TabIndex = 25;
            lblGenelTuketilen.Text = "Genel Tüketilen Besin";
            // 
            // rbHaftalik
            // 
            rbHaftalik.AutoSize = true;
            rbHaftalik.BackColor = Color.Firebrick;
            rbHaftalik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbHaftalik.ForeColor = Color.White;
            rbHaftalik.Location = new Point(429, 12);
            rbHaftalik.Name = "rbHaftalik";
            rbHaftalik.Size = new Size(142, 25);
            rbHaftalik.TabIndex = 24;
            rbHaftalik.TabStop = true;
            rbHaftalik.Text = "Haftalık Listele";
            rbHaftalik.UseVisualStyleBackColor = false;
            rbHaftalik.CheckedChanged += rbHaftalik_CheckedChanged;
            // 
            // cmbUsers
            // 
            cmbUsers.FormattingEnabled = true;
            cmbUsers.Location = new Point(19, 18);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new Size(353, 23);
            cmbUsers.TabIndex = 23;
            cmbUsers.SelectedIndexChanged += cmbUsers_SelectedIndexChanged;
            // 
            // lblOguneGore
            // 
            lblOguneGore.AutoSize = true;
            lblOguneGore.BackColor = Color.Firebrick;
            lblOguneGore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOguneGore.ForeColor = Color.White;
            lblOguneGore.Location = new Point(19, 234);
            lblOguneGore.Name = "lblOguneGore";
            lblOguneGore.Size = new Size(85, 19);
            lblOguneGore.TabIndex = 22;
            lblOguneGore.Text = "Öğüne Göre";
            // 
            // lblKategoriyeGore
            // 
            lblKategoriyeGore.AutoSize = true;
            lblKategoriyeGore.BackColor = Color.Firebrick;
            lblKategoriyeGore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKategoriyeGore.ForeColor = Color.White;
            lblKategoriyeGore.Location = new Point(19, 58);
            lblKategoriyeGore.Name = "lblKategoriyeGore";
            lblKategoriyeGore.Size = new Size(110, 19);
            lblKategoriyeGore.TabIndex = 21;
            lblKategoriyeGore.Text = "Kategoriye Göre";
            // 
            // AdminAnalysisPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AdminAnalysisPage";
            Size = new Size(848, 431);
            Load += AdminAnalysisPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenelTuketilen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriyeGore).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOguneGore).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvGenelTuketilen;
        private DataGridView dgvKategoriyeGore;
        private DataGridView dgvOguneGore;
        private RadioButton rbAylik;
        private Label lblGenelTuketilen;
        private RadioButton rbHaftalik;
        private ComboBox cmbUsers;
        private Label lblOguneGore;
        private Label lblKategoriyeGore;
    }
}
