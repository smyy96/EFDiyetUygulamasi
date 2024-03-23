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
    public class NutritionValueConfig : IEntityTypeConfiguration<NutritionValue>
    {
        public void Configure(EntityTypeBuilder<NutritionValue> builder)
        {
            builder.HasData(
                    new NutritionValue { Id = 1, NutritionValueName = "Karbonhidrat",CreatedDate = DateTime.Now },
                    new NutritionValue { Id = 2, NutritionValueName = "Protein"  , CreatedDate = DateTime.Now }
                );
        }
    }
}
