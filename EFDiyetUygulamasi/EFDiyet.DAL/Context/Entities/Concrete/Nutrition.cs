using EFDiyet.DAL.Context.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Context.Entities.Concrete
{
    public class Nutrition :EntityBase
    {
        public string NutritionName { get; set; }
        public float Calories { get; set; } 
        public string Image {  get; set; }  

        public Category CategoryId { get; set; }
        public NutritionValue NutritionValueId { get; set; }
        public Portion Portion { get; set; }
        public float PortionSize { get; set; }
    }
}
