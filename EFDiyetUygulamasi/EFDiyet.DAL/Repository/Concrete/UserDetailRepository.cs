using EFDiyet.DAL.Context;
using EFDiyet.DAL.Context.Entities.Concrete;
using EFDiyet.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Repository.Concrete
{
    public class UserDetailRepository : Repository<UserDetail>
    {
        public UserDetailRepository() : base(new DietDbContext()) { }

        public int AddReturnId(UserDetail entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.IsActive = true;

            _dbSet.Add(entity);
            _dbContext.SaveChanges();

            return entity.Id; // Eklenen nesneyi geri döndür
        }
    }
}
