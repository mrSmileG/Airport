using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL.Services;
using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public abstract class BaseController<TEntityDto> : Controller where TEntityDto : class , new()
    {
        protected readonly IService<TEntityDto> _service;

        protected BaseController(IService<TEntityDto> service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual async Task<IEnumerable<TEntityDto>> GetListAsync()
        {
            return await _service.GetListAsync();
        }

        [HttpGet("{id}")]
        public virtual async Task<TEntityDto> GetAsync(int id)
        {
            return await _service.GetAsync(id);
        }

        [HttpPost]
        public virtual async Task PostAsync([FromBody]TEntityDto item)
        {
            await _service.CreateAsync(item);
        }

        [HttpPut("{id}")]
        public virtual async Task PutAsync(int id, [FromBody]TEntityDto item)
        {
            await _service.UpdateAsync(item);
        }

        [HttpDelete("{id}")]
        public virtual async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }
    }
}