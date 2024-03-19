using EFDiyet.DAL.Context.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Context.Entities.Concrete
{
    public class UserNutrition : EntityBase
    {
        public User UserId { get; set; }
        public Nutrition NutritionId { get; set; }
        public Meal MealId { get; set; }
        public int Quantity { get; set; }



        public List<User> User  { get; set; }
        public List<Nutrition> Nutrition { get; set; }
        public List<Meal> Meal { get; set; }



    }
}
