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


            //List<CategoryModel> a = maa.CategoryList();
            //string text1 = "";
            //foreach (var item in a)
            //{
            //    foreach (var item2 in item.Nutrition)
            //    {
            //        text1 = text1 + "Kategori Name: " + item.CategoryName + " Besin Adi: " + item2.NutritionName+" Kalorisi: "+item2.Calories+" Porsiyonu: "+item2.Portion.ToString()+"\n";
            //    }
            //}
            //MessageBox.Show(text1);

            CategoryManager categoryManager = new CategoryManager();
            var deneme1= categoryManager.GetAllWithIncludes();


            NutritionManager nutritionManager = new NutritionManager();
            var deneme = nutritionManager.GetAllWithIncludes();
            var deneme2 = nutritionManager.GetAll();

            CategoryManager k=  new CategoryManager();
            var de = k.GetAll();


            

            Console.WriteLine();
        }
    }
}
