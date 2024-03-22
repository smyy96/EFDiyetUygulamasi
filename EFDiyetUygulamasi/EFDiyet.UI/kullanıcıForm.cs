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
    public partial class kullanıcıForm : Form
    {
        UserModel GetUser;
        public kullanıcıForm(UserModel getuser)
        {
            InitializeComponent();
            this.GetUser = getuser;
        }

        private void kullanıcıForm_Load(object sender, EventArgs e)
        {
            label1.Text = GetUser.Name + " " + GetUser.Surname;
        }

        private void kullanıcıForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            giris form = Application.OpenForms.OfType<giris>().FirstOrDefault();
            form.FormClear();
            form.Show();
        }
    }
}
