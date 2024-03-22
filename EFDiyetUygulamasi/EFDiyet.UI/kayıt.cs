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
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyet.UI
{
    public partial class kayıt : Form
    {
        public kayıt()
        {
            InitializeComponent();
        }

        byte[] imageData;
        int? insertedUserId;


        private void button2_Click(object sender, EventArgs e)
        {
            if (FormControl()) //butun kontrollerden sonra password kontrolunu yapma
            {
                if (PasswordControl())
                {
                    UserManager userManager = new UserManager();
                    var user = userManager.GetAll().Where(e => e.Email == textBox3.Text).FirstOrDefault();
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

            model.Gender = (comboBox1.SelectedItem.ToString() == "Erkek" ? Gender.Erkek : Gender.Kadın);
            model.BirthDate = dateTimePicker1.Value;
            model.Height = (float)Convert.ToDecimal(textBox7.Text);
            model.Weight = (float)Convert.ToDecimal(textBox8.Text);

            insertedUserId = userManager.AddReturnId(model);
            //insertedUserId = userManager.GetAll().FirstOrDefault(x => x.Id == model.Id)?.Id;
            Console.WriteLine();

        }

        private void UserRegistration()
        {
            UserManager user = new UserManager();
            UserDetailManager userDetail = new UserDetailManager();
            UserModel model = new UserModel();

            model.Name = textBox1.Text;
            model.Surname = textBox2.Text;
            model.Email = textBox3.Text;
            model.Password = sha256_hash(textBox4.Text);
            model.SecurityQuestion = comboBox1.SelectedItem.ToString();
            model.Answer = textBox6.Text;
            model.Picture = imageData;
            model.UserDetailId = insertedUserId.Value;

            user.Insert(model);
            insertedUserId = 0;

        }

        private bool PasswordControl()
        {
            string psswrd = textBox4.Text;

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
                if (textBox4.Text != textBox5.Text)
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
                label3.Text = "E-posta alanı boş bırakılamaz.";
                return false;
            }

            else if (!(textBox3.Text).Contains("@"))
            {
                label3.Text = "Geçerli bir e-posta adresi giriniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox7.Text) || !double.TryParse(textBox7.Text, out _))
            {
                label4.Text = "Geçerli bir değer giriniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox8.Text) || !double.TryParse(textBox8.Text, out _))
            {
                label5.Text = "Geçerli bir değer giriniz.";
                return false;
            }

            if (radioButton1.Checked == false && radiokdn.Checked == false)
            {
                label6.Text = "Değerlerden birini seçiniz.";
                return false;
            }

            if (comboBox1.Items == null)
            {
                label7.Text = "Güvenlik sorusu seçiniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                label8.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
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

        private string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        private void kayıt_FormClosed(object sender, FormClosedEventArgs e)
        {
            giris form = Application.OpenForms.OfType<giris>().FirstOrDefault();
            form.FormClear();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Resim yükleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FormClear()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;

            pictureBox1.Image = null;
            pictureBox1.Invalidate();

            comboBox1.SelectedItem = null;

            radioButton1.Checked = false;
            radiokdn.Checked = false;

            dateTimePicker1.Value = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserManager user = new UserManager();
            var data = user.GetById(6).Picture;
            if (data != null)
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromStream(ms);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }
    }
}
