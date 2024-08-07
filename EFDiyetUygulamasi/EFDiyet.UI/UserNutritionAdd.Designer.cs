﻿namespace EFDiyet.UI
{
    partial class UserNutritionAdd
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
            dtg_Nutrition = new DataGridView();
            panel1 = new Panel();
            txt_PortionSize = new TextBox();
            label8 = new Label();
            txt_Portion = new TextBox();
            label7 = new Label();
            txt_Calorie = new TextBox();
            label6 = new Label();
            txt_NutriValue = new TextBox();
            label5 = new Label();
            txt_NutriCCategory = new TextBox();
            label4 = new Label();
            txt_NutriName = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            cmb_Meals = new ComboBox();
            txt_BesinAdeti = new TextBox();
            btn_NutritionAdd = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_Nutrition).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_Nutrition
            // 
            dtg_Nutrition.BackgroundColor = Color.Linen;
            dtg_Nutrition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Nutrition.Location = new Point(15, 13);
            dtg_Nutrition.Margin = new Padding(3, 4, 3, 4);
            dtg_Nutrition.Name = "dtg_Nutrition";
            dtg_Nutrition.RowHeadersWidth = 51;
            dtg_Nutrition.Size = new Size(447, 515);
            dtg_Nutrition.TabIndex = 0;
            dtg_Nutrition.DoubleClick += dtg_Nutrition_DoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(txt_PortionSize);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_Portion);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_Calorie);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_NutriValue);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_NutriCCategory);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_NutriName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Font = new Font("Georgia", 9F);
            panel1.Location = new Point(481, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 269);
            panel1.TabIndex = 1;
            // 
            // txt_PortionSize
            // 
            txt_PortionSize.Location = new Point(269, 148);
            txt_PortionSize.Margin = new Padding(3, 4, 3, 4);
            txt_PortionSize.Name = "txt_PortionSize";
            txt_PortionSize.ReadOnly = true;
            txt_PortionSize.Size = new Size(127, 25);
            txt_PortionSize.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Georgia", 9F);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(135, 153);
            label8.Name = "label8";
            label8.Size = new Size(128, 18);
            label8.TabIndex = 11;
            label8.Text = "Porsiyon Miktarı :";
            // 
            // txt_Portion
            // 
            txt_Portion.Location = new Point(267, 109);
            txt_Portion.Margin = new Padding(3, 4, 3, 4);
            txt_Portion.Name = "txt_Portion";
            txt_Portion.ReadOnly = true;
            txt_Portion.Size = new Size(127, 25);
            txt_Portion.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Georgia", 9F);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(157, 77);
            label7.Name = "label7";
            label7.Size = new Size(61, 18);
            label7.TabIndex = 9;
            label7.Text = "Kalori : ";
            // 
            // txt_Calorie
            // 
            txt_Calorie.Location = new Point(267, 69);
            txt_Calorie.Margin = new Padding(3, 4, 3, 4);
            txt_Calorie.Name = "txt_Calorie";
            txt_Calorie.ReadOnly = true;
            txt_Calorie.Size = new Size(127, 25);
            txt_Calorie.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Georgia", 9F);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(157, 33);
            label6.Name = "label6";
            label6.Size = new Size(100, 18);
            label6.TabIndex = 7;
            label6.Text = "Besin Değeri :";
            // 
            // txt_NutriValue
            // 
            txt_NutriValue.Location = new Point(267, 25);
            txt_NutriValue.Margin = new Padding(3, 4, 3, 4);
            txt_NutriValue.Name = "txt_NutriValue";
            txt_NutriValue.ReadOnly = true;
            txt_NutriValue.Size = new Size(127, 25);
            txt_NutriValue.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 9F);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(157, 117);
            label5.Name = "label5";
            label5.Size = new Size(79, 18);
            label5.TabIndex = 5;
            label5.Text = "Porsiyon : ";
            // 
            // txt_NutriCCategory
            // 
            txt_NutriCCategory.Location = new Point(98, 228);
            txt_NutriCCategory.Margin = new Padding(3, 4, 3, 4);
            txt_NutriCCategory.Name = "txt_NutriCCategory";
            txt_NutriCCategory.ReadOnly = true;
            txt_NutriCCategory.Size = new Size(163, 25);
            txt_NutriCCategory.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 9F);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(14, 227);
            label4.Name = "label4";
            label4.Size = new Size(73, 18);
            label4.TabIndex = 3;
            label4.Text = "Kategori :";
            // 
            // txt_NutriName
            // 
            txt_NutriName.Location = new Point(98, 187);
            txt_NutriName.Margin = new Padding(3, 4, 3, 4);
            txt_NutriName.Name = "txt_NutriName";
            txt_NutriName.ReadOnly = true;
            txt_NutriName.Size = new Size(163, 25);
            txt_NutriName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 9F);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(14, 191);
            label3.Name = "label3";
            label3.Size = new Size(53, 18);
            label3.TabIndex = 1;
            label3.Text = "Besin :";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 39);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cmb_Meals
            // 
            cmb_Meals.FormattingEnabled = true;
            cmb_Meals.Location = new Point(98, 47);
            cmb_Meals.Margin = new Padding(3, 4, 3, 4);
            cmb_Meals.Name = "cmb_Meals";
            cmb_Meals.Size = new Size(221, 27);
            cmb_Meals.TabIndex = 2;
            // 
            // txt_BesinAdeti
            // 
            txt_BesinAdeti.Location = new Point(99, 119);
            txt_BesinAdeti.Margin = new Padding(3, 4, 3, 4);
            txt_BesinAdeti.Name = "txt_BesinAdeti";
            txt_BesinAdeti.Size = new Size(222, 27);
            txt_BesinAdeti.TabIndex = 3;
            // 
            // btn_NutritionAdd
            // 
            btn_NutritionAdd.BackColor = Color.Transparent;
            btn_NutritionAdd.BackgroundImage = Properties.Resources._17114429891631;
            btn_NutritionAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btn_NutritionAdd.FlatAppearance.BorderSize = 0;
            btn_NutritionAdd.FlatStyle = FlatStyle.Flat;
            btn_NutritionAdd.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_NutritionAdd.Location = new Point(149, 156);
            btn_NutritionAdd.Margin = new Padding(3, 4, 3, 4);
            btn_NutritionAdd.Name = "btn_NutritionAdd";
            btn_NutritionAdd.Size = new Size(133, 68);
            btn_NutritionAdd.TabIndex = 4;
            btn_NutritionAdd.Text = "Besin Ekle";
            btn_NutritionAdd.UseVisualStyleBackColor = false;
            btn_NutritionAdd.Click += btn_NutritionAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(98, 19);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 5;
            label1.Text = "Öğün Seçiniz";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cmb_Meals);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_BesinAdeti);
            panel2.Controls.Add(btn_NutritionAdd);
            panel2.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold);
            panel2.ForeColor = Color.Crimson;
            panel2.Location = new Point(481, 299);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 229);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(102, 91);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 6;
            label2.Text = "Besin Adeti";
            // 
            // UserNutritionAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dtg_Nutrition);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserNutritionAdd";
            Size = new Size(903, 543);
            Load += UserNutritionAdd_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Nutrition).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_Nutrition;
        private Panel panel1;
        private ComboBox cmb_Meals;
        private TextBox txt_BesinAdeti;
        private Button btn_NutritionAdd;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox txt_NutriName;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txt_NutriCCategory;
        private Label label4;
        private TextBox txt_PortionSize;
        private Label label8;
        private TextBox txt_Portion;
        private Label label7;
        private TextBox txt_Calorie;
        private Label label6;
        private TextBox txt_NutriValue;
        private Label label5;
    }
}
