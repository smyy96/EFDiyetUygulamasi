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
    public class UserDetailManager : Manager<UserDetailModel, UserDetail, UserDetailRepository, NutritionMapProfile>
    {

        public int AddReturnId(UserDetailModel model)
        {
            UserDetail entity = _mapper.Map<UserDetail>(model);
            int returnId = _repository.AddReturnId(entity);
            return returnId;
        }
    }
}
