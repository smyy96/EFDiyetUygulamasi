using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using EFDiyet.DAL.Context.Entities.Abstract;
using EFDiyet.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.BLL.Manager.Abstract
{
    public abstract class Manager<TModel, TEntity, TRepository, TMapperProfile> : IManager<TModel, TEntity, TRepository, TMapperProfile>
    where TEntity : EntityBase, new()
    where TModel : class, new()
    where TRepository : IRepository<TEntity>, new()
    where TMapperProfile : Profile, new() 
    {
        protected  TRepository _repository;
        protected  IMapper _mapper; // protected privae
        protected static MapperConfiguration _config;

        
        public Manager()
        {

            if (_config == null)
            {
                _config = new MapperConfiguration(cfg =>
                {
                    cfg.AddExpressionMapping().CreateMap<TModel, TEntity>().ReverseMap();
                    cfg.AddProfile<TMapperProfile>();
                });
            }

            IMapper mapper = new Mapper(_config);
            _mapper = mapper;
            _repository = new TRepository();


            ////_repository = repository;
            ////_mapper = mapper;

            //_repository = new TRepository();

            //_config = new MapperConfiguration(cfg =>
            //{
            //    cfg.AddExpressionMapping().CreateMap<TModel, TEntity>().ReverseMap(); //sc
            //    cfg.AddProfile<TMapperProfile>();
            //});
            //_mapper = new Mapper(_config);

        }

        public void Insert(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Add(entity);
        }

        public void Modified(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Update(entity);
        }

        public void Delete(TModel model)//Soft Delete
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Delete(entity);
        }

        public void Remove(TModel model)//Hard Delete
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Remove(entity);
        }

        public List<TModel> GetAll()
        {
            List<TEntity> entityList = _repository.GetAll().ToList();
            List<TModel> modelList = _mapper.Map<List<TModel>>(entityList);
            return modelList;
        }

        public TModel GetById(int Id)
        {
            TEntity entity = _repository.GetById(Id);
            TModel model = _mapper.Map<TModel>(entity);
            return model;
        }

        public List<TModel> GetAllWithIncludes() //sc
        {

            List<TEntity> entities = _repository.GetAllWithIncludes().ToList();

            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;

        }
    }

}
