using EFDiyet.BLL.Manager.Concrete;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EFDiyet.UI
{
    public partial class UserAnalysisPage : UserControl
    {
        UserModel GetUser;

        //public UserAnalysisPage()
        public UserAnalysisPage(UserModel getuser)
        {
            InitializeComponent();
            this.GetUser = getuser;
            ComboDateFill();
        }

        private void UserAnalysisPage_Load(object sender, EventArgs e)
        {

            dgvOguneGore.DataSource = null;
            dgvKategoriyeGore.DataSource = null;
            dgvGenelTuketilen.DataSource = null;
        }


        private void ComboDateFill()
        {
            UserNutritionManager userNutriManager = new UserNutritionManager();
            var users = userNutriManager.GetAll();

            var values = users.Where(a => a.UserId == GetUser.Id)
                              .GroupBy(a => a.CreatedDate.Date)
                              .Select(x => x.Key.ToString("dd/MM/yyyy"))
                              .ToList();

            values.Insert(0, "Bütün Tarihlerin Geneli");
            cmbDateTime.DataSource = values;
            cmbDateTime.SelectedIndex = -1;


        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDate = cmbDateTime.SelectedItem as string;

            if (selectedDate == "Bütün Tarihlerin Geneli")
            {
                UserNutritionManager userNutrition = new UserNutritionManager();
                dgvKategoriyeGore.DataSource = userNutrition.GetNutritionCategory().ToList();
                dgvOguneGore.DataSource = userNutrition.GetNutritionMeal().ToList();

                DataGridHeader();
            }



            else if (!string.IsNullOrEmpty(selectedDate))
            {
                UserNutritionManager userNutrition = new UserNutritionManager();
                dgvKategoriyeGore.DataSource = null;
                dgvOguneGore.DataSource = null;

                dgvKategoriyeGore.DataSource = userNutrition.GetNutritionCategoryByDate(selectedDate).ToList();
                dgvOguneGore.DataSource = userNutrition.GetNutritionMealByDate(selectedDate).ToList();
                DataGridHeader();
            }

        }

        private void DataGridHeader()
        {
            dgvKategoriyeGore.Columns["CategoryName"].HeaderText = "Kategori Adı";
            dgvKategoriyeGore.Columns["Count"].HeaderText = "Toplam Adet";
            dgvKategoriyeGore.Columns["TotalQuantity"].HeaderText = "Toplam Besin Miktarı";

            dgvOguneGore.Columns["MealName"].HeaderText = "Öğün Adı";
            dgvOguneGore.Columns["Count"].HeaderText = "Toplam Adet";
            dgvOguneGore.Columns["TotalQuantity"].HeaderText = "Toplam Besin Miktarı";

        }

        private void rbHaftalik_CheckedChanged(object sender, EventArgs e)
        {
            NutritionManager nutritionManager = new NutritionManager();
            dgvGenelTuketilen.DataSource = nutritionManager.GetNutritionMealDetails(-7, GetUser.Id);//haftalık oldugu için -7
            DataGridHeaderWeekMonth();
        }

        private void rbAylik_CheckedChanged(object sender, EventArgs e)
        {
            NutritionManager nutritionManager = new NutritionManager();
            dgvGenelTuketilen.DataSource = nutritionManager.GetNutritionMealDetails(-1, GetUser.Id); // aylık oldugu için -1
            DataGridHeaderWeekMonth();
        }

        private void DataGridHeaderWeekMonth()
        {
            dgvGenelTuketilen.Columns["TotalQuantity"].HeaderText = "Toplam Tüketim Miktarı";
            dgvGenelTuketilen.Columns["Count"].HeaderText = "Toplam Sayı";
            dgvGenelTuketilen.Columns["NutritionName"].HeaderText = "Besin Adı";
            dgvGenelTuketilen.Columns["CategoryName"].HeaderText = "Kategori Adı";
            dgvGenelTuketilen.Columns["MealName"].HeaderText = "Öğün Adı";
            dgvGenelTuketilen.Columns["NutritionValue"].HeaderText = "Besin Değeri";
        }
    }
}
