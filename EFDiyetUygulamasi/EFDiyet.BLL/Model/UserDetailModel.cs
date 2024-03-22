using EFDiyet.DAL.Context.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.BLL.Model
{
    public class UserDetailModel
    {
        public int Id { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public DateTime CreatedDate { get; set; }

        public UserModel UserModel { get; set; }
    }
}
