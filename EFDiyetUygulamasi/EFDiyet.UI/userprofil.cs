using EFDiyet.BLL.Manager.Concrete;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EFDiyet.UI
{
    public partial class userprofil : Form
    {
        User user;
        static int selectedEntityId = 0;
        byte[] imageData = null;

        public userprofil(User diyetuser)
        {
            InitializeComponent();
            user = diyetuser;
            labelClear();

        }

        private void userprofil_Load(object sender, EventArgs e)
        {
            LoadScreen();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedEntityId == null || selectedEntityId <= 0)
            {
                MessageBox.Show("Herhangi bir seçim yapmadınız ya da veri mevcut değil.\nTabloda seçmek istediğiniz değere çift tıklayarak seçim yapınız.", "Uyarı..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (FormControl())
            {
                DialogResult result = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Güncelleniyor..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    UserManager userManager = new UserManager();
                    var entity = userManager.GetById(selectedEntityId);
                    entity.Name = textBox1.Text;
                    entity.Surname = textBox2.Text;
                    entity.Email = textBox3.Text;

                   //buraya komple bakıcaz. userdetaildan mı almak gerekir bi taraf hep hata verdi???
                    user.UserDetail.Gender = (Gender)Enum.Parse(typeof(Gender), comboBox1.SelectedItem.ToString());
                    user.UserDetail.BirthDate = dateTimePicker1.Value;
                    user.UserDetail.Weight = float.Parse(textBox6.Text);
                    user.UserDetail.Height = float.Parse(textBox7.Text);
                   
                    // entity.Gender =
                    //entity.Birthdate
                    //entity.Weight = textBox6.Text;
                    //entity.Height = textBox7.Text;
                    //entity.Picture = (byte[])pictureBox1;

                    userManager.Modified(entity);
                    MessageBox.Show("Başarıyla veri güncellendi.");
                    FormClear();
                }
                else
                {
                    FormClear();
                }

            }
            selectedEntityId = 0;
            imageData = null;
        }

        public void LoadScreen()
        {
            pictureBox1.Image = Image.FromFile(user.Picture);
            textBox1.Text = user.UserDetail.Name;
            textBox2.Text = user.UserDetail.Surname;
            textBox3.Text = user.UserDetail.Email;
            dateTimePicker1.Text = user.UserDetail.BirthDate.ToShortDateString();
            comboBox1.Text = user.UserDetail.Gender.ToString();
            textBox6.Text = user.UserDetail.Weight.ToString();
            textBox7.Text = user.UserDetail.Height.ToString();

        }

        private bool FormControl()
        {
            labelClear();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                label1.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                label2.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                label3.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }
            else if (!(textBox3.Text).Contains("@"))
            {
                label3.Text = "Geçerli bir e-posta adresi giriniz.";
                return false;
            }

            if (comboBox1.Items == null)
            {
                label4.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            DateTime birthDate = dateTimePicker1.Value;
            int age = DateTime.Today.Year - birthDate.Year;
            if (age <= 18 || age >= 35)
            {
                MessageBox.Show("Yaş aralığı 18-35 olmalıdır.");
                return false;
            }


            if (string.IsNullOrWhiteSpace(textBox6.Text) || !double.TryParse(textBox6.Text, out _))
            {
                label4.Text = "Geçerli bir değer giriniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox7.Text) || !double.TryParse(textBox7.Text, out _))
            {
                label5.Text = "Geçerli bir değer giriniz.";
                return false;
            }


            return true;
        }

        private void labelClear()
        {
            foreach (Control control in Controls) //burası dogru olmus mu
            {
                if (control is Label label)
                {
                    if (label.Name.StartsWith("label") && int.TryParse(label.Name.Substring(5), out int number) && number >= 1 && number <= 6)
                    {
                        label.Text = "";
                    }
                }
            }
        }

        private void FormClear()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            //dateTimePicker1.
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            imageData = null;
            selectedEntityId = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                
            
        }

        //bak mesela en son farkettim galiba dşündüğüme göre komple yanlıs yapmısım. Ben güncelleye tıklayınca textboxlara yazı yazılabilir hale gelsin istiyodum. sonra değişikler olacak ve kaydete basınca sisteme yeni haliyle kaydolacak gibi. 
    }
}
