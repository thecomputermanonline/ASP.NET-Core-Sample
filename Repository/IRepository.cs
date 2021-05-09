using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSample.Repository
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        Task<int> Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
    }
}
