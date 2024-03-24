using EFDiyet.BLL.Manager.Abstract;
using EFDiyet.BLL.MappingProfile;
using EFDiyet.BLL.Model;
using EFDiyet.DAL.Context.Entities.Concrete;
using EFDiyet.DAL.Repository.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.BLL.Manager.Concrete
{
    public class UserManager : Manager<UserModel, User, UserRepository, NutritionMapProfile>
    {
        public UserModel? GetByEmail(string email)
        {
            User entity = _repository.GetByEmail(email);
            UserModel model = _mapper.Map<UserModel>(entity);
            return model;
        }
    }
}
