using EFDiyet.DAL.Context.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Context.Entities.Concrete
{
    //Kullanıcı Besin tablosu
    public class UserNutrition : EntityBase
    {
        public int UserId { get; set; }
        public int NutritionId { get; set; }
        public int MealId { get; set; }
        public int Quantity { get; set; }



        public User User  { get; set; }
        public Nutrition Nutrition { get; set; }
        public Meal Meal { get; set; } 



    }
}
