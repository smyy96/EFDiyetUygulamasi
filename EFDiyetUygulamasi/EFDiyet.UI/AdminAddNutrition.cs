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
using ComboBox = System.Windows.Forms.ComboBox;


namespace EFDiyet.UI
{
    public partial class AdminAddNutrition : UserControl
    {
        public AdminAddNutrition()
        {
            InitializeComponent();

            labelClear();
            dataGridViewRefresh();

            comboBoxEnumAdded();
            comboBoxCategoryAdded();
            comboBoxNutriValAdded();
        }

        NutritionValueModel nutritionValueSelected;
        byte[] imageData = null;
        static int selectedEntityId = 0;
        object cellValue;

        private void comboBoxNutriValAdded()
        {
            NutritionValueManager manager = new NutritionValueManager();
            var data = manager.GetAll().Select(n => new { Id = n.Id, NutritionValueName = n.NutritionValueName }).ToList();
            cmbNutriVal.DataSource = data;
            cmbNutriVal.DisplayMember = "NutritionValueName";
            cmbNutriVal.ValueMember = "Id";
            cmbNutriVal.SelectedIndex = -1;
        }

        private void comboBoxCategoryAdded()
        {
            CategoryManager manager = new CategoryManager();
            var data = manager.GetAll().Select(c => new { Id = c.Id, CategoryName = c.CategoryName }).ToList();
            cmbCategory.DataSource = data;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedIndex = -1;
        }

        private void comboBoxEnumAdded()
        {

            cmbPortion.DataSource = Enum.GetValues(typeof(Portion))
            .Cast<Portion>()
            .Select(e => new { Value = e, Description = e.ToString() })
            .ToList();
            cmbPortion.DisplayMember = "Description";
            cmbPortion.ValueMember = "Value";
            cmbPortion.SelectedIndex = -1;
        }

        private void dataGridViewRefresh()
        {

            NutritionManager nutritionManager = new NutritionManager();
            var data = nutritionManager.GetNutritionDetails()
                .Select
               (n => new
               {
                   Id = n.Id,
                   Nutrion_Name = n.NutritionName,
                   Kalorisi = n.Calories,
                   Kategori_Adı = n.Category.CategoryName,
                   Besin_Degeri = n.NutritionValue.NutritionValueName,
                   Porsiyon = n.Portion,
                   PorsiyonMiktari = n.PortionSize,
                   Resim = n.Image
               }).ToList();
            dataGridView1.DataSource = data;
        }

        private void FormClear()
        {
            txt_BesinAdi.Text = string.Empty;
            txt_BesinKalori.Text = string.Empty;
            txt_BesinPorsiyon.Text = string.Empty;
            cmbPortion.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            cmbNutriVal.SelectedIndex = -1;
            pictureBox_BesinFoto.Image = null;
            imageData = null;
            selectedEntityId = 0;
            cellValue = null;
            dataGridViewRefresh();
        }

        private bool FormControl()
        {
            labelClear();
            if (string.IsNullOrWhiteSpace(txt_BesinAdi.Text))
            {
                label1.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_BesinKalori.Text))
            {
                label2.Text = "Hatalı Giriş Yaptınız.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_BesinPorsiyon.Text) || !(int.TryParse(txt_BesinPorsiyon.Text, out int b)))
            {
                label3.Text = "Hatalı Giriş Yaptınız.";
                return false;
            }
            if (cmbPortion.SelectedIndex <= -1)
            {
                label4.Text = "Bir değer seçmelisiniz";
                return false;
            }
            if (cmbCategory.SelectedIndex <= -1)
            {
                label5.Text = "Bir değer seçmelisiniz";
                return false;
            }
            if (cmbCategory.SelectedIndex <= -1)
            {
                label6.Text = "Bir değer seçmelisiniz";
                return false;
            }


            return true;
        }

        private void labelClear()
        {
            foreach (Control control in panel2.Controls)
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


        private void btn_BesinEkle_Click(object sender, EventArgs e)//Besin Ekle
        {
            if (FormControl())
            {
                if (selectedEntityId > 0)
                {
                    MessageBox.Show("Seçim yaptığınız değeri sadece güncelleştirebilir veya silebilirsiniz.\nYeni veri eklemek istiyorsanız sayfayı temizleyip eklemelerinizi yapınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        NutritionManager nutritionManager = new NutritionManager();
                        NutritionModel model = new NutritionModel();

                        model.NutritionName = txt_BesinAdi.Text;
                        model.Calories = float.Parse(txt_BesinKalori.Text);
                        model.PortionSize = float.Parse(txt_BesinPorsiyon.Text);
                        model.Portion = (Portion)cmbPortion.SelectedValue;
                        model.CategoryId = (int)(cmbCategory.SelectedValue);
                        model.NutritionValueId = (int)(cmbCategory.SelectedValue);
                        //if (imageData != null && ((byte[])imageData).Length != 0)
                        model.Image = (byte[])imageData;

                        nutritionManager.Insert(model);
                        MessageBox.Show("Kaydınız Başarıyla Oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormClear();
                        dataGridViewRefresh();

                        imageData = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kayıt işleminde beklenmeyen bir hata oluştu. \nHata:" + ex.ToString() + "\nEkranı temizleyip tekrar deneyiniz.", "Hata :( ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_BesinSil_Click(object sender, EventArgs e) //Besin Silme
        {
            NutritionManager nutritionManager = new NutritionManager();

            if (selectedEntityId == null || selectedEntityId <= 0)
            {
                MessageBox.Show("Herhangi bir seçim yapmadınız ya da veri mevcut değil.\nTabloda seçmek istediğiniz değere çift tıklayarak seçim yapınız.", "Uyarı..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FormClear();
            }
            else
            {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Siliniyor..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var entity = nutritionManager.GetById(selectedEntityId);
                    //entity.Image = null;
                    nutritionManager.Delete(entity);
                    MessageBox.Show("Başarıyla veri silindi.");
                    dataGridViewRefresh();
                    FormClear();
                }
                else
                    FormClear();
            }
            selectedEntityId = 0;
        }

        private void btn_BesinGuncelle_Click(object sender, EventArgs e) //Besin Güncelle
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
                    NutritionManager nutritionManager = new NutritionManager();
                    var entity = nutritionManager.GetById(selectedEntityId);
                    entity.NutritionName = txt_BesinAdi.Text;
                    entity.Calories = float.Parse(txt_BesinKalori.Text);
                    entity.PortionSize = float.Parse(txt_BesinPorsiyon.Text);
                    entity.Portion = (Portion)cmbPortion.SelectedValue;
                    entity.CategoryId = (int)(cmbCategory.SelectedValue);
                    entity.NutritionValueId = (int)(cmbNutriVal.SelectedValue);
                    entity.Image = (byte[])imageData;

                    nutritionManager.Modified(entity);
                    MessageBox.Show("Başarıyla veri güncellendi.");
                    dataGridViewRefresh();
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



        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //var selectedNutriValue = (dataGridView1.SelectedRows[0]).DataBoundItem;
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            selectedEntityId = (int)(dataGridView1.Rows[rowIndex].Cells[0].Value);

            txt_BesinAdi.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txt_BesinKalori.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txt_BesinPorsiyon.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();

            cmbPortion.SelectedValue = dataGridView1.Rows[rowIndex].Cells[5].Value;

            string categoryName = dataGridView1.Rows[rowIndex].Cells["Kategori_Adı"].Value.ToString();
            string nutriValu = dataGridView1.Rows[rowIndex].Cells["Besin_Degeri"].Value.ToString();
            SelectItemInComboBoxByCategoryName(categoryName, cmbCategory);
            SelectItemInComboBoxByNutriValue(nutriValu, cmbNutriVal);



            //byte[] imageData = null;
            //object cellValue = dataGridView1.Rows[rowIndex].Cells[7].Value;

            NutritionManager nutritionManager = new NutritionManager();

            object cellValue = nutritionManager.GetById(selectedEntityId).Image;

            if (cellValue != null && cellValue is byte[])
            {
                imageData = (byte[])cellValue;
            }
            if (cellValue == null)
                pictureBox_BesinFoto.Image = null;

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    try
                    {
                        pictureBox_BesinFoto.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox_BesinFoto.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Resim yüklenme hatası: " + ex.ToString());
                        pictureBox_BesinFoto.Image = null;
                    }
                }
            }
            else
            {
                pictureBox_BesinFoto.Image = null;
            }
        }




        private void SelectItemInComboBoxByCategoryName(string categoryName, ComboBox comboBox) //datagridden secilen kategori adını comboxa da secili duruma getirme
        {
            foreach (var item in comboBox.Items)
            {
                dynamic dataItem = item;
                if (dataItem.CategoryName == categoryName)
                {
                    comboBox.SelectedItem = item;
                    return;
                }
            }
            comboBox.Refresh();
        }

        private void SelectItemInComboBoxByNutriValue(string nutriValue, ComboBox comboBox) //besin degerini secili hale getirme
        {
            foreach (var item in comboBox.Items)
            {
                dynamic dataItem = item;
                if (dataItem.NutritionValueName == nutriValue)
                {
                    comboBox.SelectedItem = item;
                    return;
                }
            }
            comboBox.Refresh();
        }




        private void pictureBox_BesinFoto_Click(object sender, EventArgs e)
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
                            pictureBox_BesinFoto.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox_BesinFoto.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim yükleme hatası: " + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnFormClear_Click(object sender, EventArgs e)
        {
            selectedEntityId = 0;
            FormClear();
            labelClear();
            dataGridViewRefresh();
        }

    }
}
