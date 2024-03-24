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
    public class UserNutritionRepository : Repository<UserNutrition>
    {
        public UserNutritionRepository() : base(new DietDbContext()) { }

        public List<UserNutrition> GetNutritionNutritionDetails()
        {
            var userNutritionDetails = _dbSet
                .Include(n => n.User)
                .Include(n => n.Nutrition)
                .ThenInclude(n => n.Category)
                .Include(n => n.Meal)
                .Where(x => x.IsActive == true)
                .ToList();
            return userNutritionDetails;
        }
    }
}
