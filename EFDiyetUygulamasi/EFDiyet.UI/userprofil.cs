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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EFDiyet.UI
{
    public partial class userprofil : Form
    {
        UserModel user; //burasına User user; demişsin fakat biz BLL Katmanındaki usermodele erişebiliyoruz. UIdan direk data katmanına erişim olmadıgı için User diyemiyoruz veri çekerken
        //static int selectedEntityId = 0; artık bu deger yok cunku kullanıcı bilgisi form acılınca direk geliyor
        byte[] imageData = null;

        public userprofil(UserModel diyetuser)
        {
            InitializeComponent();
            user = diyetuser;
            labelClear();


            comboBoxEnumAdded();//comboboxın içini enumdaki değerler ile doldurma
        }

        private void userprofil_Load(object sender, EventArgs e)
        {
            LoadScreen();

        }

        private void comboBoxEnumAdded()
        {

            comboBox1.DataSource = Enum.GetValues(typeof(Gender))
            .Cast<Gender>()
            .Select(e => new { Value = e, Description = e.ToString() })
            .ToList();
            comboBox1.DisplayMember = "Description";
            comboBox1.ValueMember = "Value";
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("Kullanıcı Yükleme Hatası.", "Uyarı..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (FormControl())
            {
                DialogResult result = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Güncelleniyor..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    //UserManager userManager = new UserManager();
                    //var entity = userManager.GetById(user.Id);
                    user.Name = textBox1.Text;
                    user.Surname = textBox2.Text;
                    user.Email = textBox3.Text;
                    user.Picture = (byte[])imageData;

                    //buraya komple bakıcaz. userdetaildan mı almak gerekir bi taraf hep hata verdi???

                    UserDetailManager userDetailManager = new UserDetailManager();
                    var detail = userDetailManager.GetById(user.UserDetailId); //user detailde bu kullanıcının detay bilgisinin cektim veritabanından 
                    detail.Gender = (Gender)comboBox1.SelectedValue;
                    detail.BirthDate = dateTimePicker1.Value;
                    detail.Weight = float.Parse(textBox6.Text);
                    detail.Height = float.Parse(textBox7.Text);

                    UserManager userManager = new UserManager(); //user tablosundaki verileri güncelleştirdik.
                    userManager.Modified(user);

                    userDetailManager.Modified(detail);//userdetail tablosunu güncelleştirdik. 


                    MessageBox.Show("Başarıyla veri güncellendi.");
                    DisableClickBehavior();
                }
                else
                {
                    LoadScreen();
                }

            }
            imageData = null;
        }

        public void LoadScreen()
        {
            UserDetailManager detailManager = new UserDetailManager();
            var detail = detailManager.GetById(user.UserDetailId);

            textBox1.Text = user.Name;
            textBox2.Text = user.Surname;
            textBox3.Text = user.Email;
            dateTimePicker1.Text = detail.BirthDate.ToShortDateString();
            comboBox1.Text = detail.Gender.ToString();
            textBox6.Text = detail.Weight.ToString();
            textBox7.Text = detail.Height.ToString();

            if (user.Picture != null && user.Picture is byte[])  //kullanıcının resmini bu satırdan sonra dolduruyor.
            {
                imageData = (byte[])user.Picture;
            }
            if (user.Picture == null)
                pictureBox1.Image = null;

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    try
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Resim yüklenme hatası: " + ex.ToString());
                        pictureBox1.Image = null;
                    }
                }
            }
            else
            {
                pictureBox1.Image = null;
            }

            DisableClickBehavior();
        }


        private void DisableClickBehavior()
        {
            // tıklanma özelliklerini kapattım
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            dateTimePicker1.Enabled = false;
            comboBox1.Enabled = false;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
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
            dateTimePicker1.Value = DateTime.Now;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            imageData = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e) // toolara tıklanıp değişiklik yapma özelliğini açtım
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            //textBox3.ReadOnly = false;
            dateTimePicker1.Enabled = true;
            comboBox1.Enabled = true;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e) //resim cervesine tıklayınca yeni resim secimi yapma
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    string extension = Path.GetExtension(filePath);
                    if (extension != ".jpg" && extension != ".jpeg" && extension != ".png" && extension != ".gif")
                    {
                        MessageBox.Show("Lütfen bir resim dosyası seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    imageData = File.ReadAllBytes(filePath);

                    try
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim yükleme hatası: " + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //bak mesela en son farkettim galiba dşündüğüme göre komple yanlıs yapmısım. Ben güncelleye tıklayınca textboxlara yazı yazılabilir hale gelsin istiyodum. sonra değişikler olacak ve kaydete basınca sisteme yeni haliyle kaydolacak gibi. 



        //onun yerine sunu yaptım Textleri aktif et diye buton koydum o textleri aktif ediyor sonra değiştirmek istediğini değiştiriyor kullanıcı güncelle butonuna tıklayınca de güncelliyor


    }
}
