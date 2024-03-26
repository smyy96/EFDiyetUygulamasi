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
    }
}
