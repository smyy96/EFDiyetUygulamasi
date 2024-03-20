using EFDiyet.DAL.Context.Entities.Abstract;
using EFDiyet.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.BLL.Manager.Abstract
{
    public interface IManager<TModel, TEntity, TRepository>
        where TEntity : EntityBase, new()
        where TModel : class, new()
        where TRepository : IRepository<TEntity>, new()
    {        

        public void Insert(TModel model);

        public void Modified(TModel model);

        public void Remove(TModel model);

        public List<TModel> GetAll();

        public TModel? GetById(int Id);
    }
}
