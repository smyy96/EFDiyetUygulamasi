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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFDiyet.UI
{
    public partial class UserProfile : UserControl
    {
        UserModel GetUser;
        byte[] imageData = null;

        public UserProfile(UserModel getuser)
        {
            InitializeComponent();
            this.GetUser = getuser;

            comboBoxEnumAdded();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            LoadScreen();
            labelClear();
        }

        private void comboBoxEnumAdded()
        {

            cmb_Gender.DataSource = Enum.GetValues(typeof(Gender))
            .Cast<Gender>()
            .Select(e => new { Value = e, Description = e.ToString() })
            .ToList();
            cmb_Gender.DisplayMember = "Description";
            cmb_Gender.ValueMember = "Value";
            cmb_Gender.SelectedIndex = -1;
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (GetUser == null)
            {
                MessageBox.Show("Kullanıcı Yükleme Hatası.", "Uyarı..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (FormControl())
            {
                DialogResult result = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Güncelleniyor..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    //UserManager userManager = new UserManager();
                    //var entity = userManager.GetById(GetUser.Id);
                    GetUser.Name = txt_Name.Text;
                    GetUser.Surname = txt_Surname.Text;
                    GetUser.Email = txt_Mail.Text;
                    GetUser.Picture = (byte[])imageData;

                    //buraya komple bakıcaz. userdetaildan mı almak gerekir bi taraf hep hata verdi???

                    UserDetailManager userDetailManager = new UserDetailManager();
                    var detail = userDetailManager.GetById(GetUser.UserDetailId); //GetUser detailde bu kullanıcının detay bilgisinin cektim veritabanından 
                    detail.Gender = (Gender)cmb_Gender.SelectedValue;
                    detail.BirthDate = dtTime_BirthDay.Value;
                    detail.Weight = float.Parse(txt_Weight.Text);
                    detail.Height = float.Parse(txt_Height.Text);

                    UserManager userManager = new UserManager(); //GetUser tablosundaki verileri güncelleştirdik.
                    userManager.Modified(GetUser);

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
            var detail = detailManager.GetById(GetUser.UserDetailId);

            txt_Name.Text = GetUser.Name;
            txt_Surname.Text = GetUser.Surname;
            txt_Mail.Text = GetUser.Email;
            dtTime_BirthDay.Text = detail.BirthDate.ToShortDateString();
            cmb_Gender.Text = detail.Gender.ToString();
            txt_Weight.Text = detail.Weight.ToString();
            txt_Height.Text = detail.Height.ToString();

            if (GetUser.Picture != null && GetUser.Picture is byte[])  //kullanıcının resmini bu satırdan sonra dolduruyor.
            {
                imageData = (byte[])GetUser.Picture;
            }
            if (GetUser.Picture == null)
                pctBx_ImageAdd.Image = null;

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    try
                    {
                        pctBx_ImageAdd.SizeMode = PictureBoxSizeMode.Zoom;
                        pctBx_ImageAdd.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Resim yüklenme hatası: " + ex.ToString());
                        pctBx_ImageAdd.Image = null;
                    }
                }
            }
            else
            {
                pctBx_ImageAdd.Image = null;
            }

            DisableClickBehavior();
        }


        private void DisableClickBehavior()
        {
            // tıklanma özelliklerini kapattım
            txt_Name.ReadOnly = true;
            txt_Surname.ReadOnly = true;
            txt_Mail.ReadOnly = true;
            dtTime_BirthDay.Enabled = false;
            cmb_Gender.Enabled = false;
            txt_Weight.ReadOnly = true;
            txt_Height.ReadOnly = true;
        }

        private bool FormControl()
        {
            labelClear();

            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                label8.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Surname.Text))
            {
                label9.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Mail.Text))
            {
                label10.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }
            else if (!(txt_Mail.Text).Contains("@"))
            {
                label10.Text = "Geçerli bir e-posta adresi giriniz.";
                return false;
            }

            if (cmb_Gender.Items == null)
            {
                label11.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            DateTime birthDate = dtTime_BirthDay.Value;
            int age = DateTime.Today.Year - birthDate.Year;
            if (age <= 18 || age >= 35)
            {
                label12.Text = "Yaş aralığı 18-35 olmalıdır.";
                return false;
            }


            if (string.IsNullOrWhiteSpace(txt_Weight.Text) || !double.TryParse(txt_Weight.Text, out _))
            {
                label13.Text = "Geçerli bir değer giriniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Height.Text) || !double.TryParse(txt_Height.Text, out _))
            {
                label14.Text = "Geçerli bir değer giriniz.";
                return false;
            }


            return true;
        }

        private void labelClear()
        {
            foreach (Control control in panel3.Controls)
            {
                if (control is Label label)
                {
                    if (label.Name.StartsWith("label") && int.TryParse(label.Name.Substring(5), out int number) && number >= 11 && number <= 14)
                    {
                        label.Text = "";
                    }
                }
            }

            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
        }

        private void FormClear()
        {
            txt_Name.Text = string.Empty;
            txt_Surname.Text = string.Empty;
            txt_Mail.Text = string.Empty;
            cmb_Gender.SelectedIndex = -1;
            dtTime_BirthDay.Value = DateTime.Now;
            txt_Weight.Text = string.Empty;
            txt_Height.Text = string.Empty;
            imageData = null;

        }

        private void btn_Active_Click(object sender, EventArgs e)
        {
            txt_Name.ReadOnly = false;
            txt_Surname.ReadOnly = false;
            dtTime_BirthDay.Enabled = true;
            cmb_Gender.Enabled = true;
            txt_Weight.ReadOnly = false;
            txt_Height.ReadOnly = false;
        }

        private void pctBx_ImageAdd_Click(object sender, EventArgs e)
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
                            pctBx_ImageAdd.SizeMode = PictureBoxSizeMode.Zoom;
                            pctBx_ImageAdd.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim yükleme hatası: " + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
