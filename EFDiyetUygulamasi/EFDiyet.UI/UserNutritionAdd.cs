using EFDiyet.BLL.Manager.Concrete;
using EFDiyet.BLL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EFDiyet.BLL.Manager.Concrete.NutritionManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFDiyet.UI
{
    public partial class UserNutritionAdd : UserControl
    {
        UserModel GetUser;
        public UserNutritionAdd(UserModel userModel)
        {
            InitializeComponent();
            this.GetUser = userModel;

            comboBoxMealsAdded();
        }

        NutritionAdd entity;
        byte[] imageData = null;


        private void comboBoxMealsAdded()
        {
            MealManager manager = new MealManager();
            var data = manager.GetAll().Select(n => new { Id = n.Id, MealName = n.MealName }).ToList();
            cmb_Meals.DataSource = data;
            cmb_Meals.DisplayMember = "MealName";
            cmb_Meals.ValueMember = "Id";
            cmb_Meals.SelectedIndex = -1;
        }



        private void UserNutritionAdd_Load(object sender, EventArgs e)
        {
            NutritionManager nutritionManager = new NutritionManager();

            dtg_Nutrition.DataSource = nutritionManager.GetNutritioAdd();

        }

        private void btn_NutritionAdd_Click(object sender, EventArgs e)
        {
            if (dtg_Nutrition.SelectedRows.Count > 0)
            {
                if (cmb_Meals.SelectedIndex >= 0)
                {
                    if (txt_BesinAdeti.Text == "" || !int.TryParse(txt_BesinAdeti.Text, out int parsedValue))
                    {
                        MessageBox.Show("Besin Adeti Seçiminde Hata Yaptınız Lütfen Tekrar Deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        UserNutritionManager userNutritionManager = new UserNutritionManager();
                        UserNutritionModel model = new UserNutritionModel();

                        model.UserId = GetUser.Id;
                        model.Quantity = int.Parse(txt_BesinAdeti.Text);


                        MealManager mealManager = new MealManager();
                        var meal = mealManager.GetAll().FirstOrDefault(m => m.Id == (int)cmb_Meals.SelectedValue);
                        model.MealId = meal.Id;


                        NutritionManager nutritionManager = new NutritionManager();
                        var nutrition = nutritionManager.GetAll().FirstOrDefault(m => m.NutritionName == entity.NutritionName);
                        model.NutritionId = nutrition.Id;


                        userNutritionManager.Insert(model);

                        MessageBox.Show("Seçilen besin başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FormClear();
                    }

                }

                else
                    MessageBox.Show("Ögün Seçmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Lütfen bir besin seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dtg_Nutrition_DoubleClick(object sender, EventArgs e)
        {
            entity = (NutritionAdd)((dtg_Nutrition.SelectedRows[0]).DataBoundItem);

            if (entity != null)
            {
                txt_Calorie.Text = entity.Calorie.ToString();
                txt_NutriCCategory.Text = entity.CategoryName;
                txt_NutriName.Text = entity.NutritionName;
                txt_NutriValue.Text = entity.NutritionValue;
                txt_Portion.Text = entity.Portion.ToString();
                txt_PortionSize.Text = entity.PortionSize.ToString();

                object cellValue = entity.Image;
                if (cellValue != null && cellValue is byte[])
                {
                    imageData = (byte[])cellValue;
                }
                if (cellValue == null)
                    pictureBox_BesinFoto.Image = null;

                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        try
                        {
                            pictureBox_BesinFoto.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox_BesinFoto.Image = Image.FromStream(ms);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Resim yüklenme hatası: " + ex.ToString());
                            pictureBox_BesinFoto.Image = null;
                        }
                    }
                }
                else
                {
                    pictureBox_BesinFoto.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Herhangi bir değer seçilmedi.", "Uyarı.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void FormClear()
        {
            txt_NutriValue.Text = string.Empty;
            txt_Calorie.Text = string.Empty;
            txt_Portion.Text = string.Empty;
            txt_PortionSize.Text = string.Empty;
            txt_NutriName.Text = string.Empty;
            txt_NutriCCategory.Text = string.Empty;
            cmb_Meals.SelectedIndex = -1;
            txt_BesinAdeti.Text = string.Empty;
            pictureBox_BesinFoto.Image = null;
        }

    }
}
