using System;
using EFDiyet.DAL.Context.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDiyet.DAL.Repository.Abstract;
using EFDiyet.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace EFDiyet.DAL.Repository.Concrete
{
    public class CategoryRepository: Repository<Category>
    {
        
        public CategoryRepository():base(new DietDbContext()) { }

        public DietDbContext DietDbContext => _dbContext as DietDbContext;

        public IQueryable<Category> CategoryList()
        {            
            var deger = _dbSet.Include(x => x.Nutrition);
            return deger;
        }
    }
}
