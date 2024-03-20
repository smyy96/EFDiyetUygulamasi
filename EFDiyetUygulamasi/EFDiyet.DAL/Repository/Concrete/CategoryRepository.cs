using System;
using EFDiyet.DAL.Context.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDiyet.DAL.Repository.Abstract;
using EFDiyet.DAL.Context;

namespace EFDiyet.DAL.Repository.Concrete
{
    public class CategoryRepository: Repository<Category>
    {
        public CategoryRepository()
        {                
        }
        public CategoryRepository(DietDbContext db):base(db) { }
    }
}
