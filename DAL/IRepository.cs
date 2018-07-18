using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public interface IRepository<TEntity> where TEntity : BaseModel, new()
    {
        Task<TEntity> CreateAsync(TEntity item);

        Task DeleteAsync(int id);

        Task<TEntity> GetAsync(int id);

        Task<IEnumerable<TEntity>> GetListAsync();

        Task UpdateAsync(TEntity item);
    }
}
