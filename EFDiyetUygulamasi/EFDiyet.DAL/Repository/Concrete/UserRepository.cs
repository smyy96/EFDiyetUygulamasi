using EFDiyet.DAL.Context;
using EFDiyet.DAL.Context.Entities.Concrete;
using EFDiyet.DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Repository.Concrete
{
    public class UserRepository : Repository<User>
    {
        public UserRepository() : base(new DietDbContext()) { }


        public User? GetByEmail(string email)
        {
            var entity = _dbSet.AsNoTracking().FirstOrDefault(x => x.Email == email && x.IsActive == true);
            return entity;
        }
    }
}
