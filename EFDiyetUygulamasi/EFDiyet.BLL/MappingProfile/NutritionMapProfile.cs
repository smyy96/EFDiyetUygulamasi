using AutoMapper;
using EFDiyet.BLL.Model;
using EFDiyet.DAL.Context.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.BLL.MappingProfile
{
    public class NutritionMapProfile : Profile
    {
        public NutritionMapProfile()
        {
            CreateMap<CategoryModel, Category>()
                .ForMember(dest => dest.Nutrition, opt => opt.MapFrom(src => src.NutritionModel))
                .ReverseMap();

            CreateMap<NutritionValueModel, NutritionValue>()
                .ForMember(dest => dest.Nutrition, opt => opt.MapFrom(src => src.NutritionModel))
                .ReverseMap();
        }
    }
}
