using AutoMapper;
using EFDiyet.DAL.Context.Entities.Abstract;
using EFDiyet.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.BLL.Manager.Abstract
{
    public abstract class Manager<TModel, TEntity, TRepository> : IManager<TModel, TEntity, TRepository>
    where TEntity : EntityBase, new()
    where TModel : class, new()
    where TRepository : IRepository<TEntity>, new()
    {
        protected readonly TRepository _repository;
        private readonly IMapper _mapper;

        //public Manager(TRepository repository, IMapper mapper)
        public Manager()
        {
            //_repository = repository;
            //_mapper = mapper;

            _repository = new TRepository();

            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TModel, TEntity>().ReverseMap();
            });
            _mapper = new Mapper(config);
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

        public void Remove(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Delete(entity);
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

    }

}
