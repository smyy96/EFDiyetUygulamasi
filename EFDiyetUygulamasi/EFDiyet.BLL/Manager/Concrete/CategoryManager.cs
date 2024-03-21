using EFDiyet.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EFDiyet.BLL.Manager.Abstract;
using EFDiyet.DAL.Context.Entities.Concrete;
using EFDiyet.DAL.Repository.Concrete;
using EFDiyet.BLL.MappingProfile;
using AutoMapper.Extensions.ExpressionMapping;

namespace EFDiyet.BLL.Manager.Concrete
{
    public class CategoryManager : Manager<CategoryModel, Category, CategoryRepository,CategoryMapProfile>
    {

        public List<CategoryModel> CategoryList()
        {
            return _repository.CategoryList()
                            .Where(c => c.IsActive == true)
                            .Select(c => new CategoryModel
                            {
                                Id = c.Id,
                                CategoryName = c.CategoryName,
                                NutritionModel = c.Nutrition.Select(x => new NutritionModel
                                {
                                    NutritionName = x.NutritionName,
                                    Calories = x.Calories,
                                    Portion = x.Portion

                                }).ToList()
                            }).ToList();
        }
    }
}
