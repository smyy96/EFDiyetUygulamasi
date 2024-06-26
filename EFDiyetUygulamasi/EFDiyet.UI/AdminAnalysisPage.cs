﻿using EFDiyet.BLL.Manager.Concrete;
using EFDiyet.BLL.Model;
using EFDiyet.DAL.Context.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EFDiyet.UI
{
    public partial class AdminAnalysisPage : UserControl
    {
        public AdminAnalysisPage()
        {
            InitializeComponent();
            ComboUserFill();
        }

        private void AdminAnalysisPage_Load(object sender, EventArgs e)
        {
            dgvOguneGore.DataSource = null;
            dgvKategoriyeGore.DataSource = null;
            dgvGenelTuketilen.DataSource = null;
        }

        private void ComboUserFill()
        {
            UserManager userManager = new UserManager();
            var users = userManager.GetAll();

            var values = users.Where(a => a.UserType == UserType.User)
                              .Select(x => x.Name + " " + x.Surname + " - " + x.Email)
                              .ToList();

            values.Insert(0, "Bütün Kullanıcıların Geneli");
            cmbUsers.DataSource = values;
            cmbUsers.SelectedIndex = -1;
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string email = "";
            int index = 0;
            string selected = cmbUsers.SelectedItem as string;

            if (selected != null)
            {
                index = selected.IndexOf("- ");
                if (index != -1)
                {
                    email = selected.Substring(index + 2);
                }
            }


            if (selected == "Bütün Kullanıcıların Geneli")
            {
                UserNutritionManager userNutrition = new UserNutritionManager();
                dgvKategoriyeGore.DataSource = userNutrition.GetNutritionCategory().ToList();
                dgvOguneGore.DataSource = userNutrition.GetNutritionMeal().ToList();

                DataGridHeader();
            }


            else if (!string.IsNullOrEmpty(email))
            {

                UserManager userManager = new UserManager();
                var user = userManager.GetByEmail(email);

                if (user != null)
                {
                    UserNutritionManager userNutrition = new UserNutritionManager();

                    dgvKategoriyeGore.DataSource = userNutrition.GetNutritionCategoryByEmail(user.Email).ToList();
                    dgvOguneGore.DataSource = userNutrition.GetNutritionMealByEmail(user.Email).ToList();

                    DataGridHeader();
                }
                else
                {
                    dgvKategoriyeGore.DataSource = null;
                }
            }
            else
            {
                dgvKategoriyeGore.DataSource = null;
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


        private void DataGridHeaderWeekMonth()
        {
            dgvGenelTuketilen.Columns["TotalQuantity"].HeaderText = "Toplam Tüketim Miktarı";
            dgvGenelTuketilen.Columns["Count"].HeaderText = "Toplam Sayı";
            dgvGenelTuketilen.Columns["NutritionName"].HeaderText = "Besin Adı";
            dgvGenelTuketilen.Columns["CategoryName"].HeaderText = "Kategori Adı";
            dgvGenelTuketilen.Columns["MealName"].HeaderText = "Öğün Adı";
            dgvGenelTuketilen.Columns["NutritionValue"].HeaderText = "Besin Değeri";
        }



        private void rbHaftalik_CheckedChanged(object sender, EventArgs e)
        {
            /*
             * son bir haftada tüketilen yiyeceklerin (yiyeceklere göre grouplama ve countunu alma )toplam tüketim miktarı
             * ve en çok hangi ögünde tüketildiği- kategori ile birlikte yazma.
             */

            NutritionManager nutritionManager = new NutritionManager();
            dgvGenelTuketilen.DataSource = nutritionManager.GetNutritionMealDetails(-7);//haftalık oldugu için -7
            DataGridHeaderWeekMonth();

        }

        private void rbAylik_CheckedChanged(object sender, EventArgs e)
        {
            NutritionManager nutritionManager = new NutritionManager();
            dgvGenelTuketilen.DataSource = nutritionManager.GetNutritionMealDetails(-1); // aylık oldugu için -1
            DataGridHeaderWeekMonth();
        }
    }
}
