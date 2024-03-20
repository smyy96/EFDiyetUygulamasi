using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.BLL.Model
{
    public class NutritionModel
    {
        public string NutritionName { get; set; }
       
        
        //mesela kaloriyi kullanıcı girmiyor bunlar duracak mı?
        public float Calories { get; set; }
        public string? Image { get; set; }

        //bunları da bilmiyorum duracak mı??
        public int CategoryId { get; set; }
        public CategoryModel CategoryModel { get; set; }

        public int NutritionValueId { get; set; }
        public NutritionValueModel NutritionValueMNodel { get; set; }

        //enum oldugu icin napcam
        public Portion Portion{ get; set; }
        
        
        public float PortionSize { get; set; }
    }
}
