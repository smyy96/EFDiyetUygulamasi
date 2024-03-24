using EFDiyet.BLL.Manager.Concrete;
using EFDiyet.BLL.Model;
using EFDiyet.DAL.Context.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace EFDiyet.UI
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
            labelClear();
        }

        byte[] imageData;
        int? insertedUserId;

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            if (FormControl()) //butun kontrollerden sonra password kontrolunu yapma
            {
                if (PasswordControl())
                {
                    UserManager userManager = new UserManager();
                    var user = userManager.GetAll().Where(e => e.Email == txt_Mail.Text).FirstOrDefault();
                    if (user != null)
                    {
                        MessageBox.Show("Sistemde böyle bir mail adresi mevcuttur.\nLütfen yeni bir mail hesabı giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    else
                    {
                        UserDetailRegistration();
                        UserRegistration();
                        FormClear();
                        MessageBox.Show("Kaydınız Başarıyla Oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void UserDetailRegistration()
        {

            UserDetailManager userManager = new UserDetailManager();
            UserDetailModel model = new UserDetailModel();

            model.Gender = (cmbScrtyQue.SelectedItem.ToString() == "Erkek" ? Gender.Erkek : Gender.Kadın);
            model.BirthDate = dateTimePicker1.Value;
            model.Height = (float)Convert.ToDecimal(txt_Boy.Text);
            model.Weight = (float)Convert.ToDecimal(txt_Kilo.Text);

            insertedUserId = userManager.AddReturnId(model);
            //insertedUserId = userManager.GetAll().FirstOrDefault(x => x.Id == model.Id)?.Id;
            Console.WriteLine();
        }

        private void UserRegistration()
        {
            UserManager user = new UserManager();
            UserDetailManager userDetail = new UserDetailManager();
            UserModel model = new UserModel();

            model.Name = txt_Kilo.Text;
            model.Surname = txt_Soyad.Text;
            model.Email = txt_Mail.Text;
            model.Password = sha256_hash(txt_Parola.Text);
            model.SecurityQuestion = cmbScrtyQue.SelectedItem.ToString();
            model.Answer = txt_GuvenlikSorusuCevabi.Text;
            model.Picture = imageData;
            model.UserDetailId = insertedUserId.Value;

            user.Insert(model);
            insertedUserId = 0;

        }

        private bool PasswordControl()
        {
            string psswrd = txt_Parola.Text;

            if (psswrd != null && psswrd.Length >= 8)
            {
                int uppercaseCount = psswrd.Count(char.IsUpper);
                int lowercaseCount = psswrd.Count(char.IsLower);
                int specialCharacterCount = Regex.Matches(psswrd, @"[*\-+._]").Count;

                if (uppercaseCount < 2)
                {
                    MessageBox.Show("En az 2 büyük harf içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (lowercaseCount < 2)
                {
                    MessageBox.Show("En az 2 küçük harf içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (specialCharacterCount < 1)
                {
                    MessageBox.Show("En az bir özel karakter (*-+._) içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txt_Parola.Text != txt_ParolaTekrar.Text)
                {
                    MessageBox.Show("Şifreler birbiri ile uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show("En az 8 karakter içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


        private bool FormControl()
        {
            labelClear();
            if (string.IsNullOrWhiteSpace(txt_Kilo.Text))
            {
                label1.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Soyad.Text))
            {
                label2.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Mail.Text))
            {
                label3.Text = "E-posta alanı boş bırakılamaz.";
                return false;
            }

            else if (!(txt_Mail.Text).Contains("@"))
            {
                label3.Text = "Geçerli bir e-posta adresi giriniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Boy.Text) || !double.TryParse(txt_Boy.Text, out _))
            {
                label4.Text = "Geçerli bir değer giriniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Kilo.Text) || !double.TryParse(txt_Kilo.Text, out _))
            {
                label5.Text = "Geçerli bir değer giriniz.";
                return false;
            }

            if (btn_kadin.Checked == false && btn_erkek.Checked == false)
            {
                label8.Text = "Değerlerden birini seçiniz.";
                return false;
            }

            if (cmbScrtyQue.Items == null)
            {
                label6.Text = "Güvenlik sorusu seçiniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_GuvenlikSorusuCevabi.Text))
            {
                label7.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Parola.Text) || string.IsNullOrWhiteSpace(txt_ParolaTekrar.Text))
            {
                MessageBox.Show("Şifre Alanını Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            DateTime birthDate = dateTimePicker1.Value;
            int age = DateTime.Today.Year - birthDate.Year;
            if (age <= 18 || age >= 35)
            {
                MessageBox.Show("Yaş aralığı 18-35 olmalıdır.");
                return false;
            }

            return true;
        }




        private void labelClear()
        {
            foreach (Control control in Controls)
            {
                if (control is Label label)
                {
                    if (label.Name.StartsWith("label") && int.TryParse(label.Name.Substring(5), out int number) && number >= 1 && number <= 8)
                    {
                        label.Text = "";
                    }
                }
            }
        }


        private string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        private void UserRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm form = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            form.FormClear();
            form.Show();
        }

        private void pctBxImage_Click(object sender, EventArgs e)
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
                            pctBxImage.SizeMode = PictureBoxSizeMode.Zoom;
                            pctBxImage.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim yükleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FormClear()
        {
            txt_Kilo.Text = string.Empty;
            txt_Soyad.Text = string.Empty;
            txt_Mail.Text = string.Empty;
            txt_Parola.Text = string.Empty;
            txt_ParolaTekrar.Text = string.Empty;
            txt_GuvenlikSorusuCevabi.Text = string.Empty;
            txt_Boy.Text = string.Empty;
            txt_Kilo.Text = string.Empty;

            pctBxImage.Image = null;
            pctBxImage.Invalidate();

            cmbScrtyQue.SelectedItem = null;

            btn_erkek.Checked = false;
            btn_kadin.Checked = false;

            dateTimePicker1.Value = DateTime.Now;

        }
    }
}
