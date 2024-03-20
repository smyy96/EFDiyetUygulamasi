using EFDiyet.DAL.Context.Entities.Abstract;

namespace EFDiyet.DAL.Repository.Abstract
{
    public interface IRepo<TEntity> where TEntity : EntityBase
    {
    }
}