﻿using EFDiyet.BLL.Manager.Concrete;
using EFDiyet.BLL.Model;
using EFDiyet.DAL.Context.Entities.Concrete;
using EFDiyet.DAL.Context.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyet.UI
{
    public partial class BesinEkleAdmin : Form
    {
        public BesinEkleAdmin()
        {
            InitializeComponent();
            dataGridViewRefresh();

            comboBoxEnumAdded();
            comboBoxCategoryAdded();
            comboBoxNutriValAdded();

        }

        NutritionValueModel nutritionValueSelected;
        byte[] imageData;
        int deletedID;

        private void comboBoxNutriValAdded()
        {
            NutritionValueManager manager = new NutritionValueManager();
            var data = manager.GetAll().Select(n => new { Id = n.Id, NutritionValueName = n.NutritionValueName }).ToList();
            comboBox3.DataSource = data;
            comboBox3.DisplayMember = "NutritionValueName";
            comboBox3.ValueMember = "Id";
            comboBox3.SelectedIndex = -1;
        }

        private void comboBoxCategoryAdded()
        {
            CategoryManager manager = new CategoryManager();
            var data = manager.GetAll().Select(c => new { Id = c.Id, CategoryName = c.CategoryName }).ToList();
            comboBox2.DataSource = data;
            comboBox2.DisplayMember = "CategoryName";
            comboBox2.ValueMember = "Id";
            comboBox2.SelectedIndex = -1;
        }

        private void comboBoxEnumAdded()
        {

            comboBox1.DataSource = Enum.GetValues(typeof(Portion))
            .Cast<Portion>()
            .Select(e => new { Value = e, Description = e.ToString() })
            .ToList();
            comboBox1.DisplayMember = "Description";
            comboBox1.ValueMember = "Value";
            comboBox1.SelectedIndex = -1;
        }

        private void dataGridViewRefresh()
        {

            NutritionManager nutritionManager = new NutritionManager();
            var data = nutritionManager.GetNutritionDetails()
                .Select
               (n => new
               {
                   Id = n.Id,
                   Nutrion_Name = n.NutritionName,
                   Kalorisi = n.Calories,
                   Kategori_Adı = n.Category.CategoryName,
                   Besin_Değeri = n.NutritionValue.NutritionValueName,
                   Porsiyon = n.Portion,
                   PorsiyonMiktari = n.PortionSize,
                   Resim = n.Image
               }).ToList();
            dataGridView1.DataSource = data;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormControl())
            {
                NutritionManager nutritionManager = new NutritionManager();
                NutritionModel model = new NutritionModel();

                model.NutritionName = textBox1.Text;
                model.Calories = float.Parse(textBox2.Text);
                model.PortionSize = float.Parse(textBox3.Text);
                model.Portion = (Portion)comboBox1.SelectedValue;
                model.CategoryId = (int)(comboBox2.SelectedValue);
                model.NutritionValueId = (int)(comboBox3.SelectedValue);
                model.Image = imageData;

                nutritionManager.Insert(model);
                MessageBox.Show("Kaydınız Başarıyla Oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormClear();

            }
        }

        private void FormClear()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            pictureBox1.Image = null;
            //dataGridViewRefresh();
        }

        private bool FormControl()
        {
            labelClear();
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                label4.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                label5.Text = "Hatalı Giriş Yaptınız.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text) || !(int.TryParse(textBox3.Text, out int b)))
            {
                label6.Text = "Hatalı Giriş Yaptınız.";
                return false;
            }
            if (comboBox1.SelectedIndex <= -1)
            {
                label7.Text = "Bir değer seçmelisiniz";
                return false;
            }
            if (comboBox2.SelectedIndex <= -1)
            {
                label8.Text = "Bir değer seçmelisiniz";
                return false;
            }
            if (comboBox3.SelectedIndex <= -1)
            {
                label9.Text = "Bir değer seçmelisiniz";
                return false;
            }


            return true;
        }

        private void labelClear()
        {
            foreach (Control control in Controls)
            {
                if (control is Label label)
                {
                    if (label.Name.StartsWith("label") && int.TryParse(label.Name.Substring(5), out int number) && number >= 4 && number <= 9)
                    {
                        label.Text = "";
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    string extension = Path.GetExtension(filePath);
                    if (extension != ".jpg" && extension != ".jpeg" && extension != ".png" && extension != ".gif")
                    {
                        MessageBox.Show("Lütfen bir resim dosyası seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    imageData = File.ReadAllBytes(filePath);

                    try
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim yükleme hatası: " + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NutritionManager nutritionManager = new NutritionManager();

            if (deletedID == null && deletedID < 0)
            {
                Console.WriteLine("Herhangi bir seçim yapmadınız ya da veri mevcut değil.\nTabloda seçmek istediğiniz değere çift tıklayarak seçim yapınız.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Siliniyor..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var entity = nutritionManager.GetById(deletedID);
                    entity.Image = null;
                    nutritionManager.Delete(entity);
                    MessageBox.Show("Başarıyla veri silindi.");
                    dataGridViewRefresh();
                    FormClear();
                }
            }
            deletedID = 0;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //var selectedNutriValue = (dataGridView1.SelectedRows[0]).DataBoundItem;
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            deletedID = (int)(dataGridView1.Rows[rowIndex].Cells[0].Value);

            textBox1.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();

            comboBox1.SelectedValue = dataGridView1.Rows[rowIndex].Cells[5].Value;

            int idcategory = (int)dataGridView1.Rows[rowIndex].Cells["Id"].Value;
            int idnitV = (int)dataGridView1.Rows[rowIndex].Cells["Id"].Value;
            SelectItemInComboBox(idnitV, comboBox3);
            SelectItemInComboBox(idcategory, comboBox2);


            byte[] imageData = null;
            object cellValue = dataGridView1.Rows[rowIndex].Cells[7].Value;

            if (cellValue != null && cellValue is byte[])
            {
                imageData = (byte[])cellValue;
            }
            if (cellValue == null)
                pictureBox1.Image = null;

            //if (imageData != null)
            //{
            //    using (MemoryStream ms = new MemoryStream(imageData))
            //    {
            //        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //        pictureBox1.Image = Image.FromStream(ms);
            //    }
            //}

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    try
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Resim yükleme hatası: " + ex.ToString());
                        pictureBox1.Image = null; // Resim yüklenemedi, pictureBox1'i temizle
                    }
                }
            }
            else
            {
                pictureBox1.Image = null; // Boş resim verisi, pictureBox1'i temizle
            }
        }


        private void SelectItemInComboBox(int Id, ComboBox comboBox)
        {
            foreach (var item in comboBox.Items)
            {
                dynamic dataItem = item;
                if (dataItem.Id == Id)
                {
                    comboBox.SelectedItem = item;
                    return;
                }
            }
            comboBox.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormClear();
        }
    }
}
