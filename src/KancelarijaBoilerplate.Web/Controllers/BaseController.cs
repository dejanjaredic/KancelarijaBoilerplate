using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;

namespace KancelarijaBoilerplate.Web.Controllers
{
    public class BaseController<TEntity, TDto, TType> : KancelarijaBoilerplateControllerBase where TEntity : class, IEntity<TType> where TDto : class
    {
        private readonly IRepository<TEntity, TType> _baseService;

        public BaseController(IRepository<TEntity, TType> baseService)
        {
            _baseService = baseService;
        }
        [HttpPost]
        public virtual IActionResult Create(TDto input)
        {
           _baseService.Insert(ObjectMapper.Map<TEntity>(input));
            return RedirectToAction("GetAll");
        }
        [HttpDelete]
        public virtual IActionResult Remove(TType id)
        {
            var data = _baseService.Get(id);
            _baseService.Delete(data);
            return Ok(data);
        }
        [HttpPut]
        public virtual IActionResult Update(TType id, TDto input)
        {
            var data = _baseService.Get(id);
            _baseService.Update(ObjectMapper.Map<TEntity>(data));
            return Ok(data);
        }
        [HttpGet]
        public virtual IQueryable GetAll()
        {
            return _baseService.GetAll().ProjectTo<TDto>();
        }
        [HttpGet("{id}")]
        public virtual IActionResult GetById(TType id)
        {
            var data = _baseService.Get(id);
            return Ok(ObjectMapper.Map<TDto>(data));
        }
    }

}