using EFDiyet.DAL.Context.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.BLL.Model
{
    public class NutritionModel
    {
        public int NutritionId { get; set; }

        public string NutritionName { get; set; }
       
        public float Calories { get; set; }
        public byte[]? Image { get; set; }

        
        public int CategoryId { get; set; }
        public CategoryModel CategoryModel { get; set; }

        public int NutritionValueId { get; set; }
        public NutritionValueModel NutritionValueMNodel { get; set; }

        
        public Portion Portion{ get; set; }        
        
        public float PortionSize { get; set; }
    }
}
