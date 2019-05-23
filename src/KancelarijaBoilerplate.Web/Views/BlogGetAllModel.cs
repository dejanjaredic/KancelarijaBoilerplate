using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaBoilerplate.Blog;

namespace KancelarijaBoilerplate.Web.Views
{
    public class BlogGetAllModel
    {
        public IReadOnlyList<BlogDto> Blog { get; }

        public BlogGetAllModel(IReadOnlyList<BlogDto> blog)
        {
            Blog = blog;
        }
    }
}
