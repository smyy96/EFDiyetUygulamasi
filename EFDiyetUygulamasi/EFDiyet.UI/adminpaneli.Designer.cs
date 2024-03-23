namespace EFDiyet.UI
{
    partial class adminpaneli
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            button5 = new Button();
            textBox2 = new TextBox();
            button6 = new Button();
            tabPage3 = new TabPage();
            button7 = new Button();
            dataGridView3 = new DataGridView();
            button8 = new Button();
            textBox3 = new TextBox();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(84, 284);
            button1.Name = "button1";
            button1.Size = new Size(57, 34);
            button1.TabIndex = 0;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(149, 284);
            button2.Name = "button2";
            button2.Size = new Size(62, 34);
            button2.TabIndex = 1;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(217, 284);
            button3.Name = "button3";
            button3.Size = new Size(77, 34);
            button3.TabIndex = 2;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Moccasin;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(98, 251);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(253, 198);
            dataGridView1.TabIndex = 4;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(406, 386);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(398, 358);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ögün ekleme";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(button6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(398, 358);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "kategori";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(179, 252);
            button4.Name = "button4";
            button4.Size = new Size(77, 34);
            button4.TabIndex = 7;
            button4.Text = "Güncelle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(31, 15);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(253, 198);
            dataGridView2.TabIndex = 9;
            dataGridView2.DoubleClick += dataGridView2_DoubleClick;
            // 
            // button5
            // 
            button5.Location = new Point(111, 252);
            button5.Name = "button5";
            button5.Size = new Size(62, 34);
            button5.TabIndex = 6;
            button5.Text = "Sil";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Moccasin;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(60, 219);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 27);
            textBox2.TabIndex = 8;
            // 
            // button6
            // 
            button6.Location = new Point(46, 252);
            button6.Name = "button6";
            button6.Size = new Size(57, 34);
            button6.TabIndex = 5;
            button6.Text = "Ekle";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(button9);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(398, 358);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "besinDegeriEkle";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(221, 281);
            button7.Name = "button7";
            button7.Size = new Size(77, 34);
            button7.TabIndex = 12;
            button7.Text = "Güncelle";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(73, 44);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(225, 166);
            dataGridView3.TabIndex = 14;
            dataGridView3.DoubleClick += dataGridView3_DoubleClick;
            // 
            // button8
            // 
            button8.Location = new Point(153, 281);
            button8.Name = "button8";
            button8.Size = new Size(62, 34);
            button8.TabIndex = 11;
            button8.Text = "Sil";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Moccasin;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(102, 248);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 27);
            textBox3.TabIndex = 13;
            // 
            // button9
            // 
            button9.Location = new Point(88, 281);
            button9.Name = "button9";
            button9.Size = new Size(57, 34);
            button9.TabIndex = 10;
            button9.Text = "Ekle";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // adminpaneli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 417);
            Controls.Add(tabControl1);
            Name = "adminpaneli";
            Text = "adminpaneli";
            FormClosed += adminpaneli_FormClosed;
            Load += adminpaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button4;
        private DataGridView dataGridView2;
        private Button button5;
        private TextBox textBox2;
        private Button button6;
        private TabPage tabPage3;
        private Button button7;
        private DataGridView dataGridView3;
        private Button button8;
        private TextBox textBox3;
        private Button button9;
    }
}