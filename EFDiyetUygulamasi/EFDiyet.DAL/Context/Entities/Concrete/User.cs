using EFDiyet.DAL.Context.Entities.Abstract;
using EFDiyet.DAL.Context.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Context.Entities.Concrete
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public string SecurityQuestion { get; set; }
        public string Answer { get; set; }
        public string? Picture { get; set; }      
        public UserDetail UserDetail { get; set; }
    }
}
