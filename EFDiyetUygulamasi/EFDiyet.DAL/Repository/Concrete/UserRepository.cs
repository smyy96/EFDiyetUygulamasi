﻿using EFDiyet.DAL.Context;
using EFDiyet.DAL.Context.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Repository.Concrete
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(DietDbContext db) : base(db) { }
    }
}