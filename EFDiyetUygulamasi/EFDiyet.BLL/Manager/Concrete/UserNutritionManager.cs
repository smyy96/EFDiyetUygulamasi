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
    public class UserNutritionManager : Manager<UserNutritionModel, UserNutrition, UserNutritionRepository, NutritionMapProfile>
    {
        public List<CategorySummary> GetNutritionCategoryByEmail(string email)
        {
            var userNutritionDetails = _repository.GetNutritionNutritionDetails() //kisiye göre sorgu
                .Where(e => e.User.Email == email)
                .GroupBy(c => c.Nutrition.Category.CategoryName)
                .Select(group => new CategorySummary
                {
                    CategoryName = group.Key,
                    Count = group.Count(),
                    TotalQuantity = group.Sum(x => x.Quantity)
                })
                .OrderByDescending(item => item.Count)
                .ToList();

            return userNutritionDetails;
        }


        public List<CategorySummary> GetNutritionCategory() //genel sorgu
        {
            var userNutritionDetails = _repository.GetNutritionNutritionDetails()
                .GroupBy(c => c.Nutrition.Category.CategoryName)
                .Select(group => new CategorySummary
                {
                    CategoryName = group.Key,
                    Count = group.Count(),
                    TotalQuantity = group.Sum(x => x.Quantity)
                })
                .OrderByDescending(item => item.Count)
                .ToList();

            return userNutritionDetails;
        }



        public List<MealSummary> GetNutritionMealByEmail(string email)
        {
            var userNutritionDetails = _repository.GetNutritionNutritionDetails() //kisiye göre sorgu
                .Where(e => e.User.Email == email)
                .GroupBy(c => c.Meal.MealName)
                .Select(group => new MealSummary
                {
                    MealName = group.Key,
                    Count = group.Count(),
                    TotalQuantity = group.Sum(x => x.Quantity)
                })
                .OrderByDescending(item => item.Count)
                .ToList();

            return userNutritionDetails;
        }


        public List<MealSummary> GetNutritionMealByDate(string date) //Tarihe göre kategori analizi
        {
            var userNutritionDetails = _repository.GetNutritionNutritionDetails()
                .Where(e => e.CreatedDate.ToString("dd/MM/yyyy") == date)
                .GroupBy(c => c.Nutrition.Category.CategoryName)
                .Select(group => new MealSummary
                {
                    MealName = group.Key,
                    Count = group.Count(),
                    TotalQuantity = group.Sum(x => x.Quantity)
                })
                .OrderByDescending(item => item.Count)
                .ToList();

            return userNutritionDetails;
        }



        public List<CategorySummary> GetNutritionCategoryByDate(string date) //Tarihe göre kategori analizi
        {
            var userNutritionDetails = _repository.GetNutritionNutritionDetails()
                .Where(e => e.CreatedDate.ToString("dd/MM/yyyy") == date)
                .GroupBy(c => c.Nutrition.Category.CategoryName)
                .Select(group => new CategorySummary
                {
                    CategoryName = group.Key,
                    Count = group.Count(),
                    TotalQuantity = group.Sum(x => x.Quantity)
                })
                .OrderByDescending(item => item.Count)
                .ToList();

            return userNutritionDetails;
        }



        public List<MealSummary> GetNutritionMeal() //genel sorgu
        {
            var userNutritionDetails = _repository.GetNutritionNutritionDetails()
                .GroupBy(c => c.Meal.MealName)
                .Select(group => new MealSummary
                {
                    MealName = group.Key,
                    Count = group.Count(),
                    TotalQuantity = group.Sum(x => x.Quantity)
                })
                .OrderByDescending(item => item.Count)
                .ToList();

            return userNutritionDetails;
        }



    }

    public class CategorySummary
    {
        public string CategoryName { get; set; }
        public int Count { get; set; }
        public int TotalQuantity { get; set; }
    }

    public class MealSummary
    {
        public string MealName { get; set; }
        public int Count { get; set; }
        public int TotalQuantity { get; set; }
    }

}
