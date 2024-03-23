using EFDiyet.BLL.Manager.Concrete;
using EFDiyet.BLL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyet.UI
{
    public partial class adminpaneli : Form
    {
        public adminpaneli()
        {
            InitializeComponent();
            MealManager mealManager = new MealManager();
            dataGridView1.DataSource = mealManager.GetAll();

            CategoryManager categoryManager = new CategoryManager();
            dataGridView2.DataSource = categoryManager.GetAll();

            NutritionValueManager nutritionValue = new NutritionValueManager();
            dataGridView3.DataSource = nutritionValue.GetAll();
        }

        MealModel selectedMeal;
        CategoryModel selectedCategory;
        NutritionValueModel selectedNutriValue;


        private void adminpaneli_Load(object sender, EventArgs e)
        {



        }

        private void adminpaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            giris form = Application.OpenForms.OfType<giris>().FirstOrDefault();
            form.FormClear();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MealManager mealManager = new MealManager();
            bool control = textControl(textBox1.Text);
            if (control)
            {
                MealModel model = new MealModel();
                model.MealName = textBox1.Text;
                mealManager.Insert(model);
                MessageBox.Show("Başarıyla veri eklendi..");
                RefreshFormMeal();

            }
            else
                textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MealManager mealManager = new MealManager();

            if (selectedMeal == null)
            {
                Console.WriteLine("Herhangi bir seçim yapmadınız ya da veri mevcut değil.\nTabloda seçmek istediğiniz değere çift tıklayarak seçim yapınız.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Siliniyor..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    mealManager.Delete(selectedMeal);
                    MessageBox.Show("Başarıyla veri silindi.");
                    RefreshFormMeal();
                }
            }
            selectedMeal = null;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            selectedMeal = ((MealModel)((dataGridView1.SelectedRows[0]).DataBoundItem));
            textBox1.Text = selectedMeal.MealName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MealManager mealManager = new MealManager();
            if (selectedMeal == null)
            {
                Console.WriteLine("Herhangi bir seçim yapmadınız ya da veri mevcut değil. \nTabloda seçmek istediğiniz değere çift tıklayarak seçim yapınız.");
            }
            else
            {
                bool control = textControl(textBox1.Text);
                if (control)
                {
                    selectedMeal.MealName = textBox1.Text;
                    mealManager.Modified(selectedMeal);
                    MessageBox.Show("Başarıyla veri güncellendi.");
                    RefreshFormMeal();
                }
            }

            selectedMeal = null;
        }


        private bool textControl(string text)
        {

            //string mealName = textBox1.Text.Trim();
            bool control = int.TryParse(text, out int value);

            if (text == "" || control)
            {
                MessageBox.Show("Lütfen bir metin giriniz.", "Karakter Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void RefreshFormMeal()
        {
            MealManager mealManager = new MealManager();
            textBox1.Text = string.Empty;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mealManager.GetAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) //kategorieklme
        {
            CategoryManager categoryManager = new CategoryManager();
            bool control = textControl(textBox2.Text);
            if (control)
            {
                CategoryModel model = new CategoryModel();
                model.CategoryName = textBox2.Text;
                categoryManager.Insert(model);
                MessageBox.Show("Başarıyla veri eklendi..");
                RefreshFormCategory();

            }
        }

        private void RefreshFormCategory()
        {
            CategoryManager categoryManager = new CategoryManager();
            textBox2.Text = string.Empty;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = categoryManager.GetAll();
        }

        private void button5_Click(object sender, EventArgs e) //kategory sil
        {
            CategoryManager categoryManager = new CategoryManager();

            if (selectedCategory == null || textBox2.Text.Trim() == "")
            {
                Console.WriteLine("Herhangi bir seçim yapmadınız ya da veri mevcut değil.\nTabloda seçmek istediğiniz değere çift tıklayarak seçim yapınız.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Siliniyor..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    categoryManager.Delete(selectedCategory);
                    MessageBox.Show("Başarıyla veri silindi.");
                    RefreshFormCategory();
                }
            }
            selectedCategory = null;
        }


        private void button4_Click(object sender, EventArgs e) //kategori güncelle
        {
            CategoryManager categoryManager = new CategoryManager();
            if (selectedCategory == null || textBox2.Text.Trim() == "")
            {
                Console.WriteLine("Herhangi bir seçim yapmadınız ya da veri mevcut değil. \nTabloda seçmek istediğiniz değere çift tıklayarak seçim yapınız.");
            }
            else
            {
                bool control = textControl(textBox2.Text);
                if (control)
                {
                    selectedCategory.CategoryName = textBox2.Text;
                    categoryManager.Modified(selectedCategory);
                    MessageBox.Show("Başarıyla veri güncellendi.");
                    RefreshFormCategory();
                }
            }

            selectedCategory = null;
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            selectedCategory = ((CategoryModel)((dataGridView2.SelectedRows[0]).DataBoundItem));
            textBox2.Text = selectedCategory.CategoryName;
        }

        private void button9_Click(object sender, EventArgs e) //besindegeri ekle
        {
            NutritionValueManager nutritionValue = new NutritionValueManager();
            bool control = textControl(textBox3.Text);
            if (control)
            {
                NutritionValueModel model = new NutritionValueModel();
                model.NutritionValueName = textBox3.Text;
                nutritionValue.Insert(model);
                MessageBox.Show("Başarıyla veri eklendi..");
                RefreshFormNutritionValue();

            }
        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            selectedNutriValue = ((NutritionValueModel)((dataGridView3.SelectedRows[0]).DataBoundItem));
            textBox3.Text = selectedNutriValue.NutritionValueName;
        }

        private void RefreshFormNutritionValue()
        {
            NutritionValueManager nutritionValue = new NutritionValueManager();
            textBox3.Text = string.Empty;
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = nutritionValue.GetAll();
        }

        private void button8_Click(object sender, EventArgs e) //besin degeri sil
        {
            NutritionValueManager nutritionValue = new NutritionValueManager();

            if (selectedNutriValue == null || textBox3.Text.Trim() == "")
            {
                Console.WriteLine("Herhangi bir seçim yapmadınız ya da veri mevcut değil.\nTabloda seçmek istediğiniz değere çift tıklayarak seçim yapınız.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Siliniyor..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    nutritionValue.Delete(selectedNutriValue);
                    MessageBox.Show("Başarıyla veri silindi.");
                    RefreshFormNutritionValue();
                }
            }
            selectedNutriValue = null;
        }

        private void button7_Click(object sender, EventArgs e) //besindegeri güncelle
        {
            NutritionValueManager nutritionValue = new NutritionValueManager();
            if (selectedNutriValue == null || textBox3.Text.Trim() == "")
            {
                Console.WriteLine("Herhangi bir seçim yapmadınız ya da veri mevcut değil. \nTabloda seçmek istediğiniz değere çift tıklayarak seçim yapınız.");
            }
            else
            {
                bool control = textControl(textBox3.Text);
                if (control)
                {
                    selectedNutriValue.NutritionValueName = textBox3.Text;
                    nutritionValue.Modified(selectedNutriValue);
                    MessageBox.Show("Başarıyla veri güncellendi.");
                    RefreshFormNutritionValue();
                }
            }

            selectedNutriValue = null;
        }
    }
}
