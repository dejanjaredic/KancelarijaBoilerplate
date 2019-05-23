using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;

namespace KancelarijaBoilerplate.Blog
{
    public interface IBlogService : IApplicationService
    {
        void Create(BlogDto input);
        List<BlogDto> GetAll();
        void Update(int id, BlogDto input);
        BlogDto GetById(int id);
    }
}
