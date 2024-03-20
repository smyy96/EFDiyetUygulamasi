using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.BLL.Model
{
    public class UserNutritionModel
    {
       //bir de burası da öyle kullanıcıdan gelecek bir sey olmadıgı icin olmayacak mı??
       
        
        public int UserId { get; set; }
        public int NutritionId { get; set; }
        public int MealId { get; set; }
        public int Quantity { get; set; }



        public User User { get; set; }
        public Nutrition Nutrition { get; set; }
        public Meal Meal { get; set; }
    }
}
