using AutoMapper;
using EFDiyet.DAL.Context.Entities.Abstract;
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

        public Manager(TRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Insert(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Add(entity);
        }

        public void Modify(TModel model)
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
            List<TEntity> entityList = _repository.GetAll();
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
