using EFDiyet.DAL.Context.Entities.Abstract;
using EFDiyet.DAL.Context.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Context.Entities.Concrete
{
    public class UserDetail : EntityBase
    {
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public User User { get; set; }
    }
}
