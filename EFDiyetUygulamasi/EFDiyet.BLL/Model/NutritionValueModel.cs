using EFDiyet.DAL.Context.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.BLL.Model
{
    public class NutritionValueModel
    {


        public int Id { get; set; }
        public string NutritionValueName { get; set; }

        public List<NutritionModel> NutritionModel { get; set; }
    }
}
