using EFDiyet.BLL.Manager.Concrete;
using EFDiyet.BLL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFDiyet.UI
{
    public partial class AdminAdditionalData : UserControl
    {
        public AdminAdditionalData()
        {
            InitializeComponent();
            MealManager mealManager = new MealManager();
            dgvOgunEkle.DataSource = mealManager.GetAll();

            CategoryManager categoryManager = new CategoryManager();
            dgvKategoriEkle.DataSource = categoryManager.GetAll();

            NutritionValueManager nutritionValue = new NutritionValueManager();
            dgvBeDe.DataSource = nutritionValue.GetAll();
        }

        MealModel selectedMeal;
        CategoryModel selectedCategory;
        NutritionValueModel selectedNutriValue;

        private void AdminAdditionalData_Load(object sender, EventArgs e)
        {
            RoundButton1(btnOgunEkle, 30);
            RoundButton2(btnOgunSil, 30);
            RoundButton3(btnOgunGuncelle, 30);
            RoundButton4(btnKategoriEkle, 30);
            RoundButton5(btnKategoriSil, 30);
            RoundButton6(btnKategoriGuncelle, 30);
            RoundButton7(btnBeDeEkle, 30);
            RoundButton8(btnBeDeSil, 30);
            RoundButton9(btnBeDeGuncelle, 30);
            RoundDGV1(dgvOgunEkle, 20);
            RoundDGV1(dgvKategoriEkle, 20);
            RoundDGV1(dgvBeDe, 20);
        }

        private void btnOgunEkle_Click(object sender, EventArgs e) //ögün ekleme
        {
            MealManager mealManager = new MealManager();
            bool control = textControl(tbOgunEkle.Text);
            if (control)
            {
                MealModel model = new MealModel();
                model.MealName = tbOgunEkle.Text;
                mealManager.Insert(model);
                MessageBox.Show("Başarıyla veri eklendi..");
                RefreshFormMeal();

            }
            else
                tbOgunEkle.Text = string.Empty;
        }

        private void btnOgunSil_Click(object sender, EventArgs e) //ögün silme
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

        private void btnOgunGuncelle_Click(object sender, EventArgs e) //ögün güncelleme
        {
            MealManager mealManager = new MealManager();
            if (selectedMeal == null)
            {
                Console.WriteLine("Herhangi bir seçim yapmadınız ya da veri mevcut değil. \nTabloda seçmek istediğiniz değere çift tıklayarak seçim yapınız.");
            }
            else
            {
                bool control = textControl(tbOgunEkle.Text);
                if (control)
                {
                    selectedMeal.MealName = tbOgunEkle.Text;
                    mealManager.Modified(selectedMeal);
                    MessageBox.Show("Başarıyla veri güncellendi.");
                    RefreshFormMeal();
                }
            }

            selectedMeal = null;
        }

        private bool textControl(string text) //textboxı kontrol ediyor
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
            tbOgunEkle.Text = string.Empty;
            dgvOgunEkle.DataSource = null;
            dgvOgunEkle.DataSource = mealManager.GetAll();
        }

        private void dgvOgunEkle_DoubleClick(object sender, EventArgs e)
        {
            selectedMeal = ((MealModel)((dgvOgunEkle.SelectedRows[0]).DataBoundItem));
            tbOgunEkle.Text = selectedMeal.MealName;
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e) //kategori ekleme
        {
            CategoryManager categoryManager = new CategoryManager();
            bool control = textControl(tbKategoriEkle.Text);
            if (control)
            {
                CategoryModel model = new CategoryModel();
                model.CategoryName = tbKategoriEkle.Text;
                categoryManager.Insert(model);
                MessageBox.Show("Başarıyla veri eklendi..");
                RefreshFormCategory();

            }
        }

        private void btnKategoriSil_Click(object sender, EventArgs e) //kategori Sil
        {

            CategoryManager categoryManager = new CategoryManager();

            if (selectedCategory == null || tbKategoriEkle.Text.Trim() == "")
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

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)//kategori güncelle
        {
            CategoryManager categoryManager = new CategoryManager();
            if (selectedCategory == null || tbKategoriEkle.Text.Trim() == "")
            {
                Console.WriteLine("Herhangi bir seçim yapmadınız ya da veri mevcut değil. \nTabloda seçmek istediğiniz değere çift tıklayarak seçim yapınız.");
            }
            else
            {
                bool control = textControl(tbKategoriEkle.Text);
                if (control)
                {
                    selectedCategory.CategoryName = tbKategoriEkle.Text;
                    categoryManager.Modified(selectedCategory);
                    MessageBox.Show("Başarıyla veri güncellendi.");
                    RefreshFormCategory();
                }
            }

            selectedCategory = null;
        }

        private void RefreshFormCategory()
        {
            CategoryManager categoryManager = new CategoryManager();
            tbKategoriEkle.Text = string.Empty;
            dgvKategoriEkle.DataSource = null;
            dgvKategoriEkle.DataSource = categoryManager.GetAll();
        }

        private void dgvKategoriEkle_DoubleClick(object sender, EventArgs e)
        {
            selectedCategory = ((CategoryModel)((dgvKategoriEkle.SelectedRows[0]).DataBoundItem));
            tbKategoriEkle.Text = selectedCategory.CategoryName;
        }

        private void btnBeDeEkle_Click(object sender, EventArgs e) // besin ekle
        {
            NutritionValueManager nutritionValue = new NutritionValueManager();
            bool control = textControl(tbBeDe.Text);
            if (control)
            {
                NutritionValueModel model = new NutritionValueModel();
                model.NutritionValueName = tbBeDe.Text;
                nutritionValue.Insert(model);
                MessageBox.Show("Başarıyla veri eklendi..");
                RefreshFormNutritionValue();

            }
        }

        private void btnBeDeSil_Click(object sender, EventArgs e)
        {
            NutritionValueManager nutritionValue = new NutritionValueManager();

            if (selectedNutriValue == null || tbBeDe.Text.Trim() == "")
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

        private void btnBeDeGuncelle_Click(object sender, EventArgs e)
        {
            NutritionValueManager nutritionValue = new NutritionValueManager();
            if (selectedNutriValue == null || tbBeDe.Text.Trim() == "")
            {
                Console.WriteLine("Herhangi bir seçim yapmadınız ya da veri mevcut değil. \nTabloda seçmek istediğiniz değere çift tıklayarak seçim yapınız.");
            }
            else
            {
                bool control = textControl(tbBeDe.Text);
                if (control)
                {
                    selectedNutriValue.NutritionValueName = tbBeDe.Text;
                    nutritionValue.Modified(selectedNutriValue);
                    MessageBox.Show("Başarıyla veri güncellendi.");
                    RefreshFormNutritionValue();
                }
            }

            selectedNutriValue = null;
        }

        private void RefreshFormNutritionValue()
        {
            NutritionValueManager nutritionValue = new NutritionValueManager();
            tbBeDe.Text = string.Empty;
            dgvBeDe.DataSource = null;
            dgvBeDe.DataSource = nutritionValue.GetAll();
        }

        private void dgvBeDe_DoubleClick(object sender, EventArgs e)
        {
            selectedNutriValue = ((NutritionValueModel)((dgvBeDe.SelectedRows[0]).DataBoundItem));
            tbBeDe.Text = selectedNutriValue.NutritionValueName;
        }



        private void RoundButton1(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnOgunEkle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnOgunEkle.Width - radius, btnOgunEkle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnOgunEkle.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton2(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnOgunSil.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnOgunSil.Width - radius, btnOgunSil.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnOgunSil.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton3(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnOgunGuncelle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnOgunGuncelle.Width - radius, btnOgunGuncelle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnOgunGuncelle.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton4(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnKategoriEkle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnKategoriEkle.Width - radius, btnKategoriEkle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnKategoriEkle.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton5(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnKategoriSil.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnKategoriSil.Width - radius, btnKategoriSil.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnKategoriSil.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton6(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnKategoriGuncelle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnKategoriGuncelle.Width - radius, btnKategoriGuncelle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnKategoriGuncelle.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton7(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnBeDeEkle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnBeDeEkle.Width - radius, btnBeDeEkle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnBeDeEkle.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton8(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnBeDeSil.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnBeDeSil.Width - radius, btnBeDeSil.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnBeDeSil.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundButton9(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnBeDeGuncelle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnBeDeGuncelle.Width - radius, btnBeDeGuncelle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnBeDeGuncelle.Height - radius, radius, radius, 90, 90);
            button.Region = new Region(path);
        }
        private void RoundDGV1(System.Windows.Forms.DataGridView dataGridView, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(dgvOgunEkle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(dgvOgunEkle.Width - radius, dgvOgunEkle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, dgvOgunEkle.Height - radius, radius, radius, 90, 90);
            dataGridView.Region = new Region(path);
        }
        private void RoundDGV2(System.Windows.Forms.DataGridView dataGridView, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(dgvKategoriEkle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(dgvKategoriEkle.Width - radius, dgvKategoriEkle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, dgvKategoriEkle.Height - radius, radius, radius, 90, 90);
            dataGridView.Region = new Region(path);
        }
        private void RoundDGV3(System.Windows.Forms.DataGridView dataGridView, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(dgvBeDe.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(dgvBeDe.Width - radius, dgvBeDe.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, dgvBeDe.Height - radius, radius, radius, 90, 90);
            dataGridView.Region = new Region(path);
        }
    }
}
