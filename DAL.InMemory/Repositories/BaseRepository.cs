using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL.InMemory.Repositories
{
    internal abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseModel, new()
    {
        protected readonly AppContext _appContext;

        protected BaseRepository(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public abstract void Update(TEntity item);

        public abstract TEntity Create(TEntity item);

        public abstract void Delete(Guid id);

        public abstract TEntity Get(Guid id);

        public abstract IEnumerable<TEntity> GetList();

        public virtual void Save()
        {
        }
    }
}
