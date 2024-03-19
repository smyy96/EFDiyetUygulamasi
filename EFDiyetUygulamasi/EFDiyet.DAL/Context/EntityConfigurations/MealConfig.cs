using EFDiyet.DAL.Context.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Context.EntityConfigurations
{
    internal class MealConfig : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.ToTable("Meals");
            builder.HasKey(m => m.Id);

            // MealName alanı için gereksinimler
            builder.Property(m => m.MealName)
                   .IsRequired()
                   .HasMaxLength(80);

            // UserNutrition ile ilişkiyi belirleme
            builder.HasMany(m => m.UserNutrition)
                    .WithOne(un => un.Meal)
                    .HasForeignKey(un => un.MealId);


            builder.HasData(
                       new Meal { Id = 1, MealName = "Kahvaltı" },
                       new Meal { Id = 2, MealName = "Öğle Yemeği" },
                       new Meal { Id = 3, MealName = "Akşam Yemeği" }
                       );
        }
    }
}
