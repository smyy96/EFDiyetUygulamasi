﻿using EFDiyet.DAL.Context.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EFDiyet.DAL.Repository.Abstract
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase , new()
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
            entity.CreatedDate = GetById(entity.Id).CreatedDate;

            _dbSet.Update(entity);
            _dbContext.SaveChanges();

        }

        public void Delete(TEntity entity)//Soft Delete
        {
            entity.DeletedDate = DateTime.Now;
            entity.IsActive = false;    

            _dbSet.Update(entity);
            _dbContext.SaveChanges();   
        }

        public void Remove(TEntity entity) //Hard Delete
        {         
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.Where(x => x.IsActive == true && x.IsActive != null).AsNoTracking();
        }

        public TEntity? GetById(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id && x.IsActive == true);
        }

        public IQueryable<TEntity> GetAllWithIncludes()
        {


            IQueryable<TEntity> query = _dbSet; //butun nav propları al

            TEntity instance = new TEntity();
            Type type = instance.GetType(); //T'nin turunu ögreniyoruz


            PropertyInfo[] properties = type.GetProperties();


            foreach (PropertyInfo propInfo in properties.Where(pl => pl.PropertyType.GetInterfaces().Where(i => i.Name == "IEntityBase").Any()).ToList())
            {
                query = query.Include(propInfo.Name);
            }

            return query;

        }
    }
}
