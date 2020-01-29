using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.App.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
    
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> where = null);
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Find(Expression<Func<TEntity, bool>> where = null);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Remove(Expression<Func<TEntity, bool>> where = null);
        Task<bool> IsExists(Expression<Func<TEntity, bool>> where = null);
        void Save();

    }
}
