using EFDiyet.BLL.Manager.Concrete;
using EFDiyet.BLL.Model;

namespace EFDiyet.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryManager maa = new CategoryManager();
            var deger = maa.GetAll();
            string text = "";
            foreach (var item in deger)
            {
                text = text + " " + item.CategoryName;
            }
            MessageBox.Show(text);

            // MealManager mealManager = new MealManager();
            //var de = mealManager.GetAll();
            //MessageBox.Show(de.FirstOrDefault().MealName);


            /*
            MealManager mealManager = new MealManager();
            MealModel mealModel = new MealModel();
            mealModel.MealName = "Gece Yemeði";
            mealManager.Insert(mealModel);
            */


            List<catego> = maa.CategoryList;
            string text1 = "";
            foreach (var item in a)
            {
                text1 = text1 + " " + item.CategoryName;
            }
            MessageBox.Show(text);

        }
    }
}
