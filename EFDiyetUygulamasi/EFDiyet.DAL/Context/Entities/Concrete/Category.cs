using EFDiyet.DAL.Context.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Context.Entities.Concrete
{
    //Kategori tablosu
    public class Category : EntityBase
    {
        public string CategoryName {  get; set; }

        public ICollection<Nutrition> Nutrition { get; set; } //sc

    }
}
