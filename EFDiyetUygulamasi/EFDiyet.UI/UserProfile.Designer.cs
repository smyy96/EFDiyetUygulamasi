namespace EFDiyet.UI
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            panel1 = new Panel();
            panel4 = new Panel();
            btn_Active = new Button();
            btn_Update = new Button();
            panel3 = new Panel();
            label11 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label5 = new Label();
            dtTime_BirthDay = new DateTimePicker();
            txt_Weight = new TextBox();
            txt_Height = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cmb_Gender = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            pctBx_ImageAdd = new PictureBox();
            txt_Surname = new TextBox();
            txt_Name = new TextBox();
            txt_Mail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBx_ImageAdd).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 407);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MistyRose;
            panel4.Controls.Add(btn_Active);
            panel4.Controls.Add(btn_Update);
            panel4.Location = new Point(557, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(218, 383);
            panel4.TabIndex = 41;
            // 
            // btn_Active
            // 
            btn_Active.BackgroundImage = Properties.Resources._1711442989163;
            btn_Active.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Active.FlatAppearance.BorderSize = 0;
            btn_Active.FlatStyle = FlatStyle.Flat;
            btn_Active.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Active.ForeColor = Color.Crimson;
            btn_Active.Location = new Point(28, 66);
            btn_Active.Name = "btn_Active";
            btn_Active.Size = new Size(164, 72);
            btn_Active.TabIndex = 38;
            btn_Active.Text = "Değişiklik için bilgileri etkinleştir.";
            btn_Active.UseVisualStyleBackColor = false;
            btn_Active.Click += btn_Active_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.MistyRose;
            btn_Update.BackgroundImage = (Image)resources.GetObject("btn_Update.BackgroundImage");
            btn_Update.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_Update.Location = new Point(51, 192);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(125, 71);
            btn_Update.TabIndex = 36;
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MistyRose;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dtTime_BirthDay);
            panel3.Controls.Add(txt_Weight);
            panel3.Controls.Add(txt_Height);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(cmb_Gender);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(288, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 385);
            panel3.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Firebrick;
            label11.Location = new Point(27, 92);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 38;
            label11.Text = "label11";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Firebrick;
            label14.Location = new Point(26, 306);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 41;
            label14.Text = "label14";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Firebrick;
            label13.Location = new Point(26, 236);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 40;
            label13.Text = "label13";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Firebrick;
            label12.Location = new Point(29, 164);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 39;
            label12.Text = "label12";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 9.75F);
            label5.Location = new Point(27, 116);
            label5.Name = "label5";
            label5.Size = new Size(91, 16);
            label5.TabIndex = 31;
            label5.Text = "Doğum Tarihi";
            // 
            // dtTime_BirthDay
            // 
            dtTime_BirthDay.Location = new Point(26, 138);
            dtTime_BirthDay.Name = "dtTime_BirthDay";
            dtTime_BirthDay.Size = new Size(189, 23);
            dtTime_BirthDay.TabIndex = 35;
            // 
            // txt_Weight
            // 
            txt_Weight.Font = new Font("Georgia", 9.75F);
            txt_Weight.Location = new Point(26, 211);
            txt_Weight.Name = "txt_Weight";
            txt_Weight.Size = new Size(189, 22);
            txt_Weight.TabIndex = 25;
            // 
            // txt_Height
            // 
            txt_Height.Font = new Font("Georgia", 9.75F);
            txt_Height.Location = new Point(26, 281);
            txt_Height.Name = "txt_Height";
            txt_Height.Size = new Size(189, 22);
            txt_Height.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 9.75F);
            label6.Location = new Point(30, 192);
            label6.Name = "label6";
            label6.Size = new Size(32, 16);
            label6.TabIndex = 32;
            label6.Text = "Kilo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 9.75F);
            label7.Location = new Point(32, 262);
            label7.Name = "label7";
            label7.Size = new Size(31, 16);
            label7.TabIndex = 33;
            label7.Text = "Boy";
            // 
            // cmb_Gender
            // 
            cmb_Gender.Font = new Font("Georgia", 9.75F);
            cmb_Gender.FormattingEnabled = true;
            cmb_Gender.Location = new Point(26, 66);
            cmb_Gender.Name = "cmb_Gender";
            cmb_Gender.Size = new Size(189, 24);
            cmb_Gender.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 9.75F);
            label4.Location = new Point(28, 47);
            label4.Name = "label4";
            label4.Size = new Size(57, 16);
            label4.TabIndex = 30;
            label4.Text = "Cinsiyet";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pctBx_ImageAdd);
            panel2.Controls.Add(txt_Surname);
            panel2.Controls.Add(txt_Name);
            panel2.Controls.Add(txt_Mail);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(20, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 385);
            panel2.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Firebrick;
            label10.Location = new Point(36, 335);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 37;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(33, 261);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 36;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(34, 189);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 35;
            label8.Text = "label8";
            // 
            // pctBx_ImageAdd
            // 
            pctBx_ImageAdd.BackgroundImage = Properties.Resources.user__1_;
            pctBx_ImageAdd.BorderStyle = BorderStyle.FixedSingle;
            pctBx_ImageAdd.Image = Properties.Resources.user__2_;
            pctBx_ImageAdd.Location = new Point(65, 19);
            pctBx_ImageAdd.Name = "pctBx_ImageAdd";
            pctBx_ImageAdd.Size = new Size(109, 106);
            pctBx_ImageAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBx_ImageAdd.TabIndex = 21;
            pctBx_ImageAdd.TabStop = false;
            pctBx_ImageAdd.Click += pctBx_ImageAdd_Click;
            // 
            // txt_Surname
            // 
            txt_Surname.Font = new Font("Georgia", 9.75F);
            txt_Surname.Location = new Point(31, 236);
            txt_Surname.Name = "txt_Surname";
            txt_Surname.Size = new Size(176, 22);
            txt_Surname.TabIndex = 23;
            // 
            // txt_Name
            // 
            txt_Name.Font = new Font("Georgia", 9.75F);
            txt_Name.Location = new Point(32, 167);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(175, 22);
            txt_Name.TabIndex = 22;
            // 
            // txt_Mail
            // 
            txt_Mail.Font = new Font("Georgia", 9.75F);
            txt_Mail.Location = new Point(33, 310);
            txt_Mail.Name = "txt_Mail";
            txt_Mail.Size = new Size(175, 22);
            txt_Mail.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 9.75F);
            label1.Location = new Point(34, 146);
            label1.Name = "label1";
            label1.Size = new Size(87, 16);
            label1.TabIndex = 27;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9.75F);
            label2.Location = new Point(34, 216);
            label2.Name = "label2";
            label2.Size = new Size(107, 16);
            label2.TabIndex = 28;
            label2.Text = "Kullanıcı Soyadı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 9.75F);
            label3.Location = new Point(35, 290);
            label3.Name = "label3";
            label3.Size = new Size(78, 16);
            label3.TabIndex = 29;
            label3.Text = "Mail Adresi";
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserProfile";
            Size = new Size(790, 407);
            Load += UserProfile_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctBx_ImageAdd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private DateTimePicker dtTime_BirthDay;
        private Button btn_Active;
        private TextBox txt_Weight;
        private TextBox txt_Height;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private PictureBox pctBx_ImageAdd;
        private TextBox txt_Surname;
        private TextBox txt_Name;
        private TextBox txt_Mail;
        private Label label1;
        private ComboBox cmb_Gender;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_Update;
        private Panel panel4;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}
