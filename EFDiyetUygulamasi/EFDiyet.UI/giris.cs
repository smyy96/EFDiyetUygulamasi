using EFDiyet.BLL.Manager.Concrete;
using EFDiyet.BLL.Model;
using EFDiyet.DAL.Context.Enums;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyet.UI
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        List<UserModel> userlist;

        private void giris_Load(object sender, EventArgs e)
        {
            //UserManager userManager = new UserManager();
            //userlist = userManager.GetAll().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool control = true;
            string email;

            email = textBox1.Text;
            control = MailControl(email);
            if (control)
            {

                string password = sha256_hash(textBox2.Text);




                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Parola boş olamaz!", "Giriş Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FormClear();
                }
                else
                {
                    UserManager userManager = new UserManager();
                    List<UserModel> userList = userManager.GetAll().ToList();


                    var foundUser = userList.FirstOrDefault(u => u.Email == textBox1.Text && u.Password == password);

                    if (foundUser == null)
                    {
                        MessageBox.Show("Kullanıcı Bulunamadı Tekrar Deneyiniz!", "Giriş Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        FormClear();
                    }
                    else
                    {
                        if (foundUser.UserType == UserType.User)
                        {
                            kullanıcıForm kullanıcıForm = new kullanıcıForm(foundUser);
                            kullanıcıForm.Show();
                            this.Hide();
                        }

                        else
                        {
                            //admin sayfası acılacak
                        }
                    }
                }
            }
            else
                FormClear();

        }

        private string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        public bool MailControl(string email)
        {
            try
            {

                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Email Adresinizle Giriş Yapınız.", "Giriş Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public void FormClear()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            checkBox1.Checked = false;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayıt kayıt = new kayıt();
            this.Hide();
            kayıt.Show();

        }
    }
}
