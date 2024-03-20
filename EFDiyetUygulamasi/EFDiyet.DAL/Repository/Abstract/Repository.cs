using EFDiyet.DAL.Context.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EFDiyet.DAL.Repository.Abstract
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        protected readonly DbContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;


        public Repository()
        {
            
        }

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;

            _dbSet = _dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {

            entity.CreatedDate = DateTime.Now;

            _dbSet.Add(entity);
            _dbContext.SaveChanges();

        }

        public void Update(TEntity entity)
        {
            entity.UpdatedDate = DateTime.Now;

            _dbSet.Update(entity);
            _dbContext.SaveChanges();

        }

        public void Delete(TEntity entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.IsActive = false;    

            _dbSet.Update(entity);
            _dbContext.SaveChanges();   
        }

        public void Remove(TEntity entity)
        {         
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.Where(x => x.IsActive != false).AsNoTracking();
        }

        public TEntity? GetById(int id)
        {
            return _dbSet.Where(x => x.Id == id && x.IsActive == true).SingleOrDefault();
        }


    }
}
