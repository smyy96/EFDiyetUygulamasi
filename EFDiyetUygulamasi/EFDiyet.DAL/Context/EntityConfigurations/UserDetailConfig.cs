using EFDiyet.DAL.Context.Entities.Concrete;
using EFDiyet.DAL.Context.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Context.EntityConfigurations
{
    public class UserDetailConfig : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {
            builder.HasData(
                    new UserDetail
                    {
                        Id = 1,
                        Gender = Gender.Kadın,
                        BirthDate = new DateTime(2003, 5, 15),
                        Height = 175.5f,
                        Weight = 50.0f
                    },
                    new UserDetail
                    {
                        Id = 2,
                        Gender = Gender.Kadın,
                        BirthDate = new DateTime(2003, 5, 15),
                        Height = 175.5f,
                        Weight = 50.0f
                    });
        }
    }
}
