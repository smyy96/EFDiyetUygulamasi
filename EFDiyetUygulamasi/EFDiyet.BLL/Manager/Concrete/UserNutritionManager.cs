using EFDiyet.BLL.Manager.Abstract;
using EFDiyet.BLL.MappingProfile;
using EFDiyet.BLL.Model;
using EFDiyet.DAL.Context.Entities.Concrete;
using EFDiyet.DAL.Context.Enums;
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
        public List<CategorySummary> GetNutritionCategoryByEmail(string email) //kisiye göre sorgu admin paneli kategoriye göre
        {
            var userNutritionDetails = _repository.GetNutritionNutritionDetails()
                .Where(e => e.User.Email == email)
                .GroupBy(c => c.Nutrition.Category.CategoryName)
                .Select(group => new CategorySummary
                {
                    CategoryName = group.Key,
                    Count = group.Count(),
                    TotalQuantity = group.Sum(x => x.Quantity),
                    TotalCalorie = group.Sum(x => x.Nutrition.Calories)
                })
                .OrderByDescending(item => item.Count)
                .ToList();

            return userNutritionDetails;
        }



        public List<MealSummary> GetNutritionMealByEmail(string email) //kisiye göre sorgu admin paneli ögüne göre
        {
            var userNutritionDetails = _repository.GetNutritionNutritionDetails()
                .Where(e => e.User.Email == email)
                .GroupBy(c => c.Meal.MealName)
                .Select(group => new MealSummary
                {
                    MealName = group.Key,
                    Count = group.Count(),
                    TotalQuantity = group.Sum(x => x.Quantity),
                    TotalCalorie = group.Sum(x => x.Nutrition.Calories)
                })
                .OrderByDescending(item => item.Count)
                .ToList();

            return userNutritionDetails;
        }


        public List<CategorySummary> GetNutritionCategory() //genel sorgu admin paneli
        {
            var userNutritionDetails = _repository.GetNutritionNutritionDetails()
                .GroupBy(c => c.Nutrition.Category.CategoryName)
                .Select(group => new CategorySummary
                {
                    CategoryName = group.Key,
                    Count = group.Count(),
                    TotalQuantity = group.Sum(x => x.Quantity),
                    TotalCalorie = group.Sum(x => x.Nutrition.Calories)
                })
                .OrderByDescending(item => item.Count)
                .ToList();

            return userNutritionDetails;
        }


        public List<MealSummary> GetNutritionMeal() //genel sorgu admin ögüne göre 
        {
            var userNutritionDetails = _repository.GetNutritionNutritionDetails()
                .GroupBy(c => c.Meal.MealName)
                .Select(group => new MealSummary
                {
                    MealName = group.Key,
                    Count = group.Count(),
                    TotalQuantity = group.Sum(x => x.Quantity),
                    TotalCalorie = group.Sum(x => x.Nutrition.Calories)

                })
                .OrderByDescending(item => item.Count)
                .ToList();

            return userNutritionDetails;
        }

        public List<MealSummary> GetNutritionMealByDate(string date) //Tarihe göre ögün analizi user sayfası
        {
            var userNutritionDetails = _repository.GetNutritionNutritionDetails()
                .Where(e => e.CreatedDate.ToString("dd/MM/yyyy") == date)
                .GroupBy(c => c.Meal.MealName)
                .Select(group => new MealSummary
                {
                    MealName = group.Key,
                    Count = group.Count(),
                    TotalQuantity = group.Sum(x => x.Quantity),
                    TotalCalorie = group.Sum(x => x.Nutrition.Calories)
                })
                .OrderByDescending(item => item.Count)
                .ToList();

            return userNutritionDetails;
        }



        public List<CategorySummary> GetNutritionCategoryByDate(string date) //Tarihe göre kategori analizi user sayfası
        {
            var userNutritionDetails = _repository.GetNutritionNutritionDetails()
                .Where(e => e.CreatedDate.ToString("dd/MM/yyyy") == date)
                .GroupBy(c => c.Nutrition.Category.CategoryName)
                .Select(group => new CategorySummary
                {
                    CategoryName = group.Key,
                    Count = group.Count(),
                    TotalQuantity = group.Sum(x => x.Quantity),
                    TotalCalorie = group.Sum(x => x.Nutrition.Calories)
                })
                .OrderByDescending(item => item.Count)
                .ToList();

            return userNutritionDetails;
        }


        public List<UserNutritionInfo> UserNutrition(int id, DateTime date)
        {
            return _repository.UserNutritionDetails()
                 .Where(x => x.UserId == id && x.CreatedDate.Date == Convert.ToDateTime(date).Date)
                 .Select(x => new UserNutritionInfo
                 {
                     IdUN = x.Id,
                     NutritionName = x.Nutrition.NutritionName,
                     MealName = x.Meal.MealName,
                     Portion = x.Nutrition.Portion,
                     Quantity = x.Quantity
                 }).ToList();
        }

    }

    public class CategorySummary
    {
        public string CategoryName { get; set; }
        public int Count { get; set; }
        public int TotalQuantity { get; set; }
        public float TotalCalorie { get; set; }
    }

    public class MealSummary
    {
        public string MealName { get; set; }
        public int Count { get; set; }
        public int TotalQuantity { get; set; }
        public float TotalCalorie { get; set; }
    }

    public class UserNutritionInfo
    {
        public int IdUN { get; set; }
        public string MealName { get; set; }
        public string NutritionName { get; set; }
        public Portion Portion { get; set; }
        public int Quantity { get; set; }
    }

}
