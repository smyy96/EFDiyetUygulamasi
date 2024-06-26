using EFDiyet.BLL.Manager.Abstract;
using EFDiyet.BLL.MappingProfile;
using EFDiyet.BLL.Model;
using EFDiyet.DAL.Context.Entities.Concrete;
using EFDiyet.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.BLL.Manager.Concrete
{
    public class MealManager: Manager<MealModel, Meal, MealRepository, NutritionMapProfile>
    {
    }
}
