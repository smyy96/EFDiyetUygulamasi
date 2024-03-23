using EFDiyet.DAL.Context.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDiyet.DAL.Context.Enums;
using System.Reflection.Emit;

namespace EFDiyet.DAL.Context.EntityConfigurations
{
    public class NutritionConfig : IEntityTypeConfiguration<Nutrition>
    {
        public void Configure(EntityTypeBuilder<Nutrition> builder)
        {
            builder.ToTable("Nutritions"); // Tablo adı

            // Nutrition anahtarını belirleme
            builder.HasKey(n => n.Id);

            builder.Property(u => u.Image)
              .HasColumnType("varbinary(max)");

            // NutritionName alanı için gereksinimler
            builder.Property(n => n.NutritionName)
                   .IsRequired()
                   .HasMaxLength(110);


            // NutritionValue ile ilişkiyi belirleme
            builder.HasOne(n => n.NutritionValue)
                   .WithMany(un => un.Nutrition)
                   .HasForeignKey(n => n.NutritionValueId);


            // UserNutrition ile ilişkiyi belirleme
            builder.HasMany(n => n.UserNutrition)
                   .WithOne(un => un.Nutrition)
                   .HasForeignKey(un => un.NutritionId);


            //Düzenlenecek enumlar türkçeleşince
            builder.HasData(
                    new Nutrition { Id = 1, NutritionName = "Elma", Calories = 52, CategoryId = 1, NutritionValueId = 1, Portion = Portion.Adet, PortionSize = 1, CreatedDate = DateTime.Now },
                    new Nutrition { Id = 2, NutritionName = "Domates", Calories = 18, CategoryId = 2, NutritionValueId = 2, Portion = Portion.Adet, PortionSize = 1 ,CreatedDate = DateTime.Now }
                    );
        }
    }
}
