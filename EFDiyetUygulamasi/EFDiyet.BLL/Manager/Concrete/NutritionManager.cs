using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
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
    public class NutritionManager : Manager<NutritionModel, Nutrition, NutritionRepository, NutritionMapProfile>
    {

        public NutritionManager()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping().CreateMap<CategoryModel, Category>().ReverseMap();
                cfg.AddProfile<CategoryMapProfile>();
            });

            IMapper mapper = new Mapper(config);
            _mapper = mapper;
            _repository = new NutritionRepository();
        }


        public List<Nutrition> GetNutritionDetails()
        {
            return _repository.GetNutritionDetails();
        }

        public List<NutritionCount> GetNutritionMealDetails(int haftalıkAylık)
        {
            /*
             * son bir haftada/ayda tüketilen yiyeceklerin (yiyeceklere göre grouplama ve countunu alma )toplam tüketim miktarı
             * ve en çok hangi ögünde tüketildiği- kategori ile birlikte yazma.
             */

            DateTime oneWeekMonthAgo;


            if (haftalıkAylık == -7)
                oneWeekMonthAgo = DateTime.Today.AddDays(-7);

            else
                oneWeekMonthAgo = DateTime.Today.AddMonths(-1);


            var nutritionDetails = _repository.GetNutritionMealDetails()
                                        .Where(x => x.UserNutrition.Any(un => un.CreatedDate >= oneWeekMonthAgo))
                                        .ToList();


            var groupedNutrition = nutritionDetails
                                    .GroupBy(n => new { n.NutritionName, n.Category.CategoryName })
                                    .Select(group => new NutritionCount
                                    {
                                        NutritionName = group.Key.NutritionName,
                                        CategoryName = group.Key.CategoryName,
                                        TotalQuantity = group.Sum(x => x.UserNutrition.Sum(un => un.Quantity)),
                                        MealName = group.FirstOrDefault()?.UserNutrition.FirstOrDefault()?.Meal.MealName,
                                        Count = group.Count().ToString(),
                                        NutritionValue = group.FirstOrDefault()?.NutritionValue.NutritionValueName,
                                        TotalCalorie = group.Sum(x => x.Calories)
                                    })
                                    .OrderByDescending(item => item.TotalQuantity)
                                    .ToList();

            return groupedNutrition;


        }


        public List<NutritionCount> GetNutritionMealDetails(int haftalıkAylık, int userId) //userıd ye göre haftalık-aylık analiz
        {
            /*
             * son bir haftada/ayda tüketilen yiyeceklerin (yiyeceklere göre grouplama ve countunu alma )toplam tüketim miktarı
             * ve en çok hangi ögünde tüketildiği- kategori ile birlikte yazma. userıde ye göre
             */

            DateTime oneWeekMonthAgo;


            if (haftalıkAylık == -7)
                oneWeekMonthAgo = DateTime.Today.AddDays(-7);

            else
                oneWeekMonthAgo = DateTime.Today.AddMonths(-1);


            var nutritionDetails = _repository.GetNutritionMealDetails()
                                        .Where(x => x.UserNutrition.Any(un => un.CreatedDate >= oneWeekMonthAgo && un.UserId == userId))
                                        .ToList();


            var groupedNutrition = nutritionDetails
                                    .GroupBy(n => new { n.NutritionName, n.Category.CategoryName })
                                    .Select(group => new NutritionCount
                                    {
                                        NutritionName = group.Key.NutritionName,
                                        CategoryName = group.Key.CategoryName,
                                        TotalQuantity = group.Sum(x => x.UserNutrition.Sum(un => un.Quantity)),
                                        MealName = group.FirstOrDefault()?.UserNutrition.FirstOrDefault()?.Meal.MealName,
                                        Count = group.Count().ToString(),
                                        NutritionValue = group.FirstOrDefault()?.NutritionValue.NutritionValueName,
                                        TotalCalorie = group.Sum(x => x.Calories)

                                    })
                                    .OrderByDescending(item => item.TotalQuantity)
                                    .ToList();

            return groupedNutrition;


        }



        public class NutritionCount
        {
            public string NutritionName { get; set; }
            public string CategoryName { get; set; }
            public string NutritionValue { get; set; }
            public string MealName { get; set; }
            public int TotalQuantity { get; set; }
            public float TotalCalorie { get; set; }
            public string Count { get; set; }

        }
    }
}
