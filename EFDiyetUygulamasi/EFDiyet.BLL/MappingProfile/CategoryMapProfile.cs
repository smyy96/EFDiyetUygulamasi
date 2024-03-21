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
    public class CategoryMapProfile : Profile
    {
        public CategoryMapProfile()
        {
            CreateMap<NutritionModel, Nutrition>()
             .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.CategoryModel))
             .ReverseMap();

        }
    }
}
