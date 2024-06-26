using EFDiyet.BLL.Model;
using EFDiyet.UI;
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
    public partial class UserForm : Form
    {
        UserModel GetUser;

        public UserForm(UserModel getuser)
        {
            InitializeComponent();
            this.GetUser = getuser;
        }

        private void ShowPanelControl(UserControl userControl)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void pbUserProfile_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile(GetUser);
            ShowPanelControl(userProfile);
        }

        private void lblKullanici_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile(GetUser);
            ShowPanelControl(userProfile);
        }

        private void pbAnalizU_Click(object sender, EventArgs e)
        {
            UserAnalysisPage userAnalysisPage = new UserAnalysisPage(GetUser);
            ShowPanelControl(userAnalysisPage);
        }

        private void lblAnalizU_Click(object sender, EventArgs e)
        {
            UserAnalysisPage userAnalysisPage = new UserAnalysisPage(GetUser);
            ShowPanelControl(userAnalysisPage);
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm form = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            form.FormClear();
            form.Show();
        }

        private void pbAnasayfa_Click(object sender, EventArgs e)
        {
            UserNutritionAdd userNutrition = new UserNutritionAdd(GetUser);
            ShowPanelControl(userNutrition);
        }

        private void lblAnasayfa_Click(object sender, EventArgs e)
        {
            UserNutritionAdd userNutrition = new UserNutritionAdd(GetUser);
            ShowPanelControl(userNutrition);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            UserNutritionAdd userNutrition = new UserNutritionAdd(GetUser);
            ShowPanelControl(userNutrition);
        }

        private void pbGecmis_Click(object sender, EventArgs e)
        {
            UserHistory userHistory = new UserHistory(GetUser);
            ShowPanelControl(userHistory);
        }

        private void lblGecmis_Click(object sender, EventArgs e)
        {
            UserHistory userHistory = new UserHistory(GetUser);
            ShowPanelControl(userHistory);
        }

        private void lblDietAppU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tDiyet Uygulaması\n\tSümeyye, Hivda, Ilgın\n\tSaygıyla Sunar ♥");
        }
    }
}
