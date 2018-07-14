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
    public abstract class BaseController<TEntityDto> : Controller where TEntityDto : BaseDto, new()
    {
        protected readonly IService<TEntityDto> _service;

        protected BaseController(IService<TEntityDto> service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual IEnumerable<TEntityDto> GetList()
        {
            return _service.GetList();
        }

        [HttpGet("{id}")]
        public virtual TEntityDto Get(Guid id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        public virtual void Post([FromBody]TEntityDto item)
        {
            _service.Create(item);
        }

        [HttpPut("{id}")]
        public virtual void Put(int id, [FromBody]TEntityDto item)
        {
            _service.Update(item);
        }

        [HttpDelete("{id}")]
        public virtual void Delete(Guid id)
        {
            _service.Delete(id);
        }
    }
}