using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DTOs;

namespace BL.Services
{
    public interface IService<TEntityDto> where TEntityDto : class , new()
    {
        Task<TEntityDto> CreateAsync(TEntityDto item);

        Task DeleteAsync(int id);

        Task<TEntityDto> GetAsync(int id);

        Task<IEnumerable<TEntityDto>> GetListAsync();

        Task UpdateAsync(TEntityDto item);
    }
}
