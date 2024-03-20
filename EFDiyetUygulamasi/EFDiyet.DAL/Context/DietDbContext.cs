using EFDiyet.DAL.Context.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Context
{
    public class DietDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
        public DbSet<NutritionValue> NutritionValues { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UsersDetails { get; set; }
        public DbSet<UserNutrition> UserNutritions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Veritabanı baglantısı
        {

            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-5HVC58C\\SQLEXPRESS02;Initial Catalog=DietDB;Integrated Security=True;Encrypt=False");
            //optionsBuilder.UseSqlServer("Data Source=ILGıN;Initial Catalog=DietDB;Integrated Security=True;Encrypt=False");
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-DCAA7GQH\\MSSQLSERVERHIVDA;Initial Catalog=DietDB;Integrated Security=True;Encrypt=False");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
