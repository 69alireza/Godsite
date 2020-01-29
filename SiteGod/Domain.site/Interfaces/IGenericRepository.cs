using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.App.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        //IEnumerable<T> GetAll();
        //T GetById(object id);
        //void Insert(T obj);
        //void Update(T obj);
        //void Delete(object id);
        //void Save();

        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity,bool>> where = null);
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Find(object id,Expression<Func<TEntity, bool>> where = null);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Remove(object id);
        Task<bool> IsExists(object id,Expression<Func<TEntity, bool>> where = null);
        void Save();

    }
}
