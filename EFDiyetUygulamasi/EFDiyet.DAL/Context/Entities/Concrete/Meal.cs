using EFDiyet.DAL.Context.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Context.Entities.Concrete
{
    //Ögün tablosu
    public class Meal : EntityBase 
    {
        public string MealName {  get; set; } 

        public ICollection<UserNutrition> UserNutrition { get; set; } 


    }
}
