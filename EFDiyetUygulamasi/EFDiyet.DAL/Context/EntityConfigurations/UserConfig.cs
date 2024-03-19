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
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name).HasMaxLength(100);
            builder.Property(u =>u.Surname).HasMaxLength(100);
            builder.Property(u =>u.Email).HasMaxLength(150).IsRequired();
            builder.Property(u => u.Password).HasMaxLength(50).IsRequired();
            builder.Property(u => u.SecurityQuestion).HasMaxLength(150);
            builder.Property(u => u.Answer).HasMaxLength(100);
            builder.Property(u => u.Picture).HasMaxLength(200);

            builder.Property(u => u.UserType);

            builder.HasOne(ud => ud.UserDetail)
                   .WithOne(u => u.User);

            builder.HasMany(un => un.UserNutrition)
                   .WithOne(u => u.User)
                   .HasForeignKey(u => u.UserId);
        }
    }
}
