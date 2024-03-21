using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using EFDiyet.BLL.Manager.Abstract;
using EFDiyet.BLL.MappingProfile;
using EFDiyet.BLL.Model;
using EFDiyet.DAL.Context.Entities.Concrete;
using EFDiyet.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.BLL.Manager.Concrete
{
    public class NutritionManager : Manager<NutritionModel, Nutrition, NutritionRepository,NutritionMapProfile>
    {

        public NutritionManager()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping().CreateMap<CategoryModel, Category>().ReverseMap();
                cfg.AddProfile<CategoryMapProfile>();
            });

            IMapper mapper = new Mapper(config);
            _mapper = mapper;
            _repository = new NutritionRepository();
        }

    }
}
