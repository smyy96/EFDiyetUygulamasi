using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.BLL.Model
{
    public class UserNutritionModel
    {
             
        
        public int UserId { get; set; }
        public int NutritionId { get; set; }
        public int MealId { get; set; }
        public int Quantity { get; set; }



        public UserModel User { get; set; }
        public NutritionModel Nutrition { get; set; }
        public MealModel Meal { get; set; }
    }
}
