using System;
using System.Collections.Generic;
using Models;

namespace DAL
{
    public interface IRepository<TEntity> where TEntity : BaseModel, new()
    {
        TEntity Create(TEntity item);

        void Delete(Guid id);

        TEntity Get(Guid id);

        IEnumerable<TEntity> GetList();

        void Update(TEntity item);

        void Save();
    }
}
