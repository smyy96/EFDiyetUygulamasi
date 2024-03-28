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
    public partial class UserHistory : UserControl
    {
        UserModel GetUser;
        public UserHistory(UserModel user)
        {
            InitializeComponent();
            this.GetUser = user;
        }

        private void UserHistory_Load(object sender, EventArgs e)
        {
            UserNutritionManager userNutritionManager = new UserNutritionManager();
            var date = userNutritionManager.GetAll()
                                           .Where(x => x.UserId == GetUser.Id)
                                           .GroupBy(n => n.CreatedDate.Date)
                                           .Select(group => new { Tarihler = group.Key })
                                           .ToList();

            dgv_NutritionDate.Columns.Clear();
            dgv_NutritionDate.DataSource = date;

        }


        private void dgv_NutritionDate_DoubleClick(object sender, EventArgs e)
        {
            var date = dgv_NutritionDate.SelectedRows[0].Cells["Tarihler"].Value; //secilen tarihi değişkene atama


            UserNutritionManager nutritionManager = new UserNutritionManager();

            var use = nutritionManager.UserNutrition(GetUser.Id, Convert.ToDateTime(date));

            dtgv_NutritionUser.DataSource = use;

            dtgv_NutritionUser.Columns["IdUN"].Visible = false;
            dtgv_NutritionUser.Columns["NutritionName"].HeaderText = "Besin Adı";
            dtgv_NutritionUser.Columns["MealName"].HeaderText = "Öğün Adı";
            dtgv_NutritionUser.Columns["Portion"].HeaderText = "Porsiyon";
            dtgv_NutritionUser.Columns["Quantity"].HeaderText = "Miktar";

            /*var UserNutri = nutritionManager.GetAll()
                .Where(x => x.UserId == GetUser.Id && x.CreatedDate.Date == Convert.ToDateTime(date).Date)
                .ToList();*/
        }

        private void btn_NutritionDelete_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_NutritionUser_DoubleClick(object sender, EventArgs e)
        {
            var ıd = dgv_NutritionDate.SelectedRows[0].Cells["IdUN"].Value;
            
        }
    }
}
