namespace EFDiyet.UI
{
    partial class UserHistory
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
            dtgv_NutritionUser = new DataGridView();
            dgv_NutritionDate = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            btn_NutritionDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_NutritionUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_NutritionDate).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgv_NutritionUser
            // 
            dtgv_NutritionUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_NutritionUser.BackgroundColor = Color.Linen;
            dtgv_NutritionUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_NutritionUser.Location = new Point(15, 13);
            dtgv_NutritionUser.Name = "dtgv_NutritionUser";
            dtgv_NutritionUser.Size = new Size(479, 380);
            dtgv_NutritionUser.TabIndex = 0;
            dtgv_NutritionUser.DoubleClick += dtgv_NutritionUser_DoubleClick;
            // 
            // dgv_NutritionDate
            // 
            dgv_NutritionDate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_NutritionDate.BackgroundColor = Color.Linen;
            dgv_NutritionDate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_NutritionDate.Location = new Point(511, 13);
            dgv_NutritionDate.Name = "dgv_NutritionDate";
            dgv_NutritionDate.Size = new Size(262, 267);
            dgv_NutritionDate.TabIndex = 1;
            dgv_NutritionDate.DoubleClick += dgv_NutritionDate_DoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_NutritionDelete);
            panel1.Location = new Point(511, 303);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 90);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(110, 48);
            label2.TabIndex = 8;
            label2.Text = "Silmek \r\nİstediğiniz \r\nBesini Seçiniz.";
            // 
            // btn_NutritionDelete
            // 
            btn_NutritionDelete.BackColor = Color.Transparent;
            btn_NutritionDelete.BackgroundImage = Properties.Resources._17114429891631;
            btn_NutritionDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btn_NutritionDelete.FlatAppearance.BorderSize = 0;
            btn_NutritionDelete.FlatStyle = FlatStyle.Flat;
            btn_NutritionDelete.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_NutritionDelete.Location = new Point(130, 21);
            btn_NutritionDelete.Name = "btn_NutritionDelete";
            btn_NutritionDelete.Size = new Size(116, 51);
            btn_NutritionDelete.TabIndex = 7;
            btn_NutritionDelete.Text = "Besin Sil";
            btn_NutritionDelete.UseVisualStyleBackColor = false;
            btn_NutritionDelete.Click += btn_NutritionDelete_Click;
            // 
            // UserHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            Controls.Add(panel1);
            Controls.Add(dgv_NutritionDate);
            Controls.Add(dtgv_NutritionUser);
            Name = "UserHistory";
            Size = new Size(790, 407);
            Load += UserHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_NutritionUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_NutritionDate).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgv_NutritionUser;
        private DataGridView dgv_NutritionDate;
        private Panel panel1;
        private Label label2;
        private Button btn_NutritionDelete;
    }
}
