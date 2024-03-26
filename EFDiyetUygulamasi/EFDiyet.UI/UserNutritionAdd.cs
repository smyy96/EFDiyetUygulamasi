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
        }

        private void UserNutritionAdd_Load(object sender, EventArgs e)
        {

        }

        private void btn_NutritionAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
