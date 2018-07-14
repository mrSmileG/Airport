using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DAL;
using DTOs;
using Models;

namespace BL.Services
{
    public abstract class BaseService<TEntityDto, TEntity> : IService<TEntityDto>
        where TEntityDto : BaseDto, new()
        where TEntity : BaseModel, new()
    {
        protected IRepository<TEntity> _repository;

        static BaseService()
        {
            AutoMapperConfigurator.Configure();
        }

        public virtual TEntityDto Create(TEntityDto item)
        {
            var convertedItem = Mapper.Map<TEntityDto, TEntity>(item);
            var entity = _repository.Create(convertedItem);
            _repository.Save();

            var dto = Mapper.Map<TEntity, TEntityDto>(entity);
            return dto;
        }

        public virtual void Delete(Guid id)
        {
            _repository.Delete(id);
            _repository.Save();
        }

        public virtual TEntityDto Get(Guid id)
        {
            var item = _repository.Get(id);
            var dto = Mapper.Map<TEntity, TEntityDto>(item);

            return dto;
        }

        public virtual IEnumerable<TEntityDto> GetList()
        {
            var items = _repository.GetList();
            var dtos = Mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntityDto>>(items);

            return dtos;
        }

        public virtual void Update(TEntityDto item)
        {
            var convertedItem = Mapper.Map<TEntityDto, TEntity>(item);
            _repository.Update(convertedItem);
            _repository.Save();
        }
    }
}
