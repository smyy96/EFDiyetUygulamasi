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
        
        UserModel GetUser; //kullanıcı login sayfasından giriş yaptıgı zaman giriş yapan kullanıcının bilgisini bu değişkene atıyoruz.

        public kullanıcıForm(UserModel getuser)
        {
            InitializeComponent();
            this.GetUser = getuser; //kullanıcının bilgisini değişkene atatık varlık tipin de GetUser. dşyerek propertylerine erişebilirsin
        }

        private void kullanıcıForm_Load(object sender, EventArgs e)
        {
            label1.Text = GetUser.Name + " " + GetUser.Surname; //burada örnek bir deneme yaptım giriş yapan kullanının adını ve soyadınız ekrana yazdırabildim.
        }

        private void kullanıcıForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm form = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            form.FormClear();
            form.Show();
        }
    }
}
