namespace EFDiyet.UI
{
    partial class userprofil
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(49, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 106);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(49, 274);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(351, 226);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(151, 23);
            textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(341, 274);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(151, 23);
            textBox7.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 154);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 9;
            label1.Text = "ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 208);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 256);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 11;
            label3.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 314);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 12;
            label4.Text = "cinsiyet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(351, 154);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 13;
            label5.Text = "dogumtarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 208);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 14;
            label6.Text = "kilo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(341, 256);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 15;
            label7.Text = "boy";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(49, 342);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(351, 173);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(157, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(330, 324);
            button1.Name = "button1";
            button1.Size = new Size(140, 57);
            button1.TabIndex = 18;
            button1.Text = "güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(500, 332);
            button2.Name = "button2";
            button2.Size = new Size(140, 57);
            button2.TabIndex = 19;
            button2.Text = "kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // userprofil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "userprofil";
            Text = "userprofil";
            Load += userprofil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
    }
}