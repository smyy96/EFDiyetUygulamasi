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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Tablo adı ve anahtar 
            builder.ToTable("Categories");
            builder.HasKey(c => c.Id);

            // CategoryName alanı için gereksinimler
            builder.Property(c => c.CategoryName)
                   .HasMaxLength(100);

            // Nutrition ile ilişkiyi belirleme
            builder.HasMany(c => c.Nutrition)
                   .WithOne(n => n.Category)
                   .HasForeignKey(n => n.CategoryId);


            builder.HasData(
                   new Category { Id = 1, CategoryName = "Meyve" ,CreatedDate=DateTime.Now},
                   new Category { Id = 2, CategoryName = "Sebze" , CreatedDate = DateTime.Now },
                   new Category { Id = 3, CategoryName = "Et Ürünleri" , CreatedDate = DateTime.Now },
                   new Category { Id = 4, CategoryName = "Salata" , CreatedDate = DateTime.Now },
                   new Category { Id = 5, CategoryName = "Unlu Mamuller" , CreatedDate = DateTime.Now },
                   new Category { Id = 6, CategoryName = "Tatlı", CreatedDate = DateTime.Now },
                   new Category { Id = 7, CategoryName = "İçecek", CreatedDate = DateTime.Now }

                );

        }
    }
}
