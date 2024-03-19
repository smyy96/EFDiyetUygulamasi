using EFDiyet.DAL.Context.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Context.Entities.Concrete
{
    public class Meal : EntityBase 
    {
        public string OgunAdi {  get; set; }

        public List<Nutrition> Besin { get; set; }


    }
}
