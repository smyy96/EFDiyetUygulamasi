using EFDiyet.DAL.Context.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Context.Entities.Concrete
{
    //Besin Degerleri tablosu
    public class NutritionValue : EntityBase
    {
        public string NutritionValueName { get; set; }

        public ICollection<Nutrition> Nutrition { get; set; }
    }
}
