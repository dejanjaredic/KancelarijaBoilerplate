using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.UI;
using AutoMapper;

namespace KancelarijaBoilerplate.Blog
{
    public class BlogService : IBlogService
    {
        private readonly IRepository<Models.Blog> _blogRepository;

        public BlogService(IRepository<Models.Blog> blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public void Create(BlogDto input)
        {
            Models.Blog blog = input.MapTo<Models.Blog>();
            _blogRepository.Insert(blog);
        }

        public List<BlogDto> GetAll()
        {
            var getAll = _blogRepository.GetAll();
            return getAll.MapTo<List<BlogDto>>();
        }

        public void Update(int id, BlogDto input)
        {
            var blog = _blogRepository.Get(id);
            if (blog == null)
            {
                throw new UserFriendlyException("Kancelarija ne postoji");
            }

            input.MapTo(blog);
        }
        public BlogDto GetById(int id)
        {
            var blog = _blogRepository.Get(id);
            return blog.MapTo<BlogDto>();
        }
    }
}
