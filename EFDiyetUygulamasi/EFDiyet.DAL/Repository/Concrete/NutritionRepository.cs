using EFDiyet.DAL.Context;
using EFDiyet.DAL.Context.Entities.Concrete;
using EFDiyet.DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Repository.Concrete
{
    public class NutritionRepository : Repository<Nutrition>
    {

        public NutritionRepository() : base(new DietDbContext())
        {

        }

        public List<Nutrition> GetNutritionDetails()
        {
            ;
            var nutritionDetails = _dbSet
                .Include(n => n.Category)
                .Include(n => n.NutritionValue)
                .ToList();
            return nutritionDetails;
        }
    }
}
