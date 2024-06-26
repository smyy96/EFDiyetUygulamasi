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

        }
    }
}
