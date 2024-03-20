using EFDiyet.DAL.Context;
using EFDiyet.DAL.Context.Entities.Concrete;
using EFDiyet.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Repository.Concrete
{
    public class UserNutritionRepository : Repository<UserNutrition>
    {
        public UserNutritionRepository(DietDbContext db) : base(db) { }
    }
}
