using EFDiyet.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EFDiyet.BLL.Manager.Abstract;
using EFDiyet.DAL.Context.Entities.Concrete;
using EFDiyet.DAL.Repository.Concrete;

namespace EFDiyet.BLL.Manager.Concrete
{
    public class CategoryManager : Manager<CategoryModel, Category, CategoryRepository>
    {
        public List<Category> CategoryList()
        {
            return _repository.CategoryList().ToList();
        }

    }
}
