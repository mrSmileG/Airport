using System;
using System.Collections.Generic;
using System.Text;
using DTOs;

namespace BL.Services
{
    public interface IService<TEntityDto> where TEntityDto : BaseDto, new()
    {
        TEntityDto Create(TEntityDto item);

        void Delete(Guid id);

        TEntityDto Get(Guid id);

        IEnumerable<TEntityDto> GetList();

        void Update(TEntityDto item);
    }
}
