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

namespace EFDiyet.UI
{
    public partial class UserNutritionAdd : UserControl
    {
        UserModel GetUser;
        public UserNutritionAdd(UserModel userModel)
        {
            InitializeComponent();
            this.GetUser = userModel;
            InitializeComponent();

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
        }



        private void UserNutritionAdd_Load(object sender, EventArgs e)
        {
            NutritionManager nutritionManager = new NutritionManager();
            var data = nutritionManager.GetNutritionDetails()
                .Select(n => new List<DAL.Context.Entities.Concrete.Nutrition> { });       
                    
            dtg_Nutrition.DataSource = nutritionManager.GetNutritionDetails().ToList(); 
        }

        private void btn_NutritionAdd_Click(object sender, EventArgs e)
        {
            if (dtg_Nutrition.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dtg_Nutrition.SelectedCells[0].RowIndex;
                int selectedEntityId = (int)dtg_Nutrition.Rows[selectedRowIndex].Cells["Id"].Value;

                NutritionManager nutritionManager = new NutritionManager();
                var selectedNutrition = nutritionManager.GetById(selectedEntityId);


                UserNutritionManager userNutritionManager = new UserNutritionManager();
                UserNutritionModel model = new UserNutritionModel();
                model.UserId = GetUser.Id;
                //model.NutritionId = dtg_Nutrition_DoubleClick.Entity.NutritionId;



                model.NutritionId = selectedNutrition.Id;
                userNutritionManager.Insert(model);

                MessageBox.Show("Seçilen besin başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir besin seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }

        private void dtg_Nutrition_DoubleClick(object sender, EventArgs e)
        {
            NutritionManager nutritionManager = new NutritionManager();
            var data = nutritionManager.GetNutritionDetails()
                .Select(n => new
                {
                    txt_NutriName = n.NutritionName,
                    txt_Calorie = n.Calories,
                    txt_NutriCCategory = n.Category.CategoryName,
                    txt_NutriValue = n.NutritionValue.NutritionValueName,
                    txt_Portion = n.Portion,
                    txt_PortionSize = n.PortionSize
                }).ToList();
        
    }
    }
}
