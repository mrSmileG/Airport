using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.EF
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseModel, new()
    {
        private readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);

            _dbContext.Set<TEntity>().Remove(entity);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetListAsync()
        {
            var entities = await _dbContext.Set<TEntity>().ToListAsync();

            foreach (var entity in entities)
            {
                foreach (var navigation in _dbContext.Entry(entity).Navigations)
                {
                    await navigation.LoadAsync();
                    await LoadIncludedEntitiesAsync(navigation.Metadata.GetTargetType().ClrType);
                }

            }
            
            return entities;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            await _dbContext.SaveChangesAsync();

            return await _dbContext.Set<TEntity>().FindAsync(entity.Id);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            var entity = await _dbContext.FindAsync<TEntity>(id);
            foreach (var navigation in _dbContext.Entry(entity).Navigations)
            {
                await navigation.LoadAsync();
                await LoadIncludedEntitiesAsync(navigation.Metadata.GetTargetType().ClrType);

            }
            return entity;
        }

        private async Task LoadIncludedEntitiesAsync(Type entityTypeValue)
        {
            var setMethod = typeof(DbContext).GetMethod("Set");

            var entityType = _dbContext.Model.FindEntityType(entityTypeValue);
            foreach (var navigation in entityType.GetNavigations())
            {
                if (setMethod != null)
                    await ((IQueryable) setMethod.MakeGenericMethod(navigation.GetTargetType().ClrType)
                            .Invoke(_dbContext, null))
                        .OfType<object>()
                        .LoadAsync();
            }
        }
    }
}
