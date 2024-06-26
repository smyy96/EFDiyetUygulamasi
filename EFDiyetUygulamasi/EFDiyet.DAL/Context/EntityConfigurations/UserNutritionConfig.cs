using EFDiyet.DAL.Context.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Context.EntityConfigurations
{
    public class UserNutritionConfig : IEntityTypeConfiguration<UserNutrition>
    {
        public void Configure(EntityTypeBuilder<UserNutrition> builder)
        {
            builder.HasData(
                    new UserNutrition
                    {
                        Id = 1,
                        UserId = 1, 
                        NutritionId = 1, 
                        MealId = 1, 
                        Quantity = 2 ,
                        CreatedDate = DateTime.Now,
                    },
                    new UserNutrition
                    {
                        Id = 2,
                        UserId = 1, 
                        NutritionId = 2, 
                        MealId = 2, 
                        Quantity = 1 ,
                        CreatedDate = DateTime.Now
                    }
                );
        }
    }
}
