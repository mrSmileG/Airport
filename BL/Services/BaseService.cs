using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using DTOs;
using Models;

namespace BL.Services
{
    public abstract class BaseService<TEntityDto, TEntity> : IService<TEntityDto>
        where TEntityDto : class , new()
        where TEntity : BaseModel, new()
    {
        protected IRepository<TEntity> _repository;

        static BaseService()
        {
            AutoMapperService.Configure();
        }

        public virtual async Task<TEntityDto> CreateAsync(TEntityDto item)
        {
            var convertedItem = Mapper.Map<TEntityDto, TEntity>(item);
            var entity = await _repository.CreateAsync(convertedItem);
            var dto = Mapper.Map<TEntity, TEntityDto>(entity);

            return dto;
        }

        public virtual async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public virtual async Task<TEntityDto> GetAsync(int id)
        {
            var item = await _repository.GetAsync(id);
            var dto = Mapper.Map<TEntity, TEntityDto>(item);

            return dto;
        }

        public virtual async Task<IEnumerable<TEntityDto>> GetListAsync()
        {
            var items = await _repository.GetListAsync();
            var dtos = Mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntityDto>>(items);

            return dtos;
        }

        public virtual async Task UpdateAsync(TEntityDto item)
        {
            var convertedItem = Mapper.Map<TEntityDto, TEntity>(item);
            await _repository.UpdateAsync(convertedItem);
        }
    }
}
