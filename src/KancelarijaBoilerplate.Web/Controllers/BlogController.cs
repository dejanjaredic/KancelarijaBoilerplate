using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaBoilerplate.Blog;
using KancelarijaBoilerplate.Web.Views;
using Microsoft.AspNetCore.Mvc;

namespace KancelarijaBoilerplate.Web.Controllers
{
    public class BlogController : KancelarijaBoilerplateControllerBase
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        [HttpGet]
        public IActionResult AddBlog()
        {
            return View();
        }

        public IActionResult AddBlog(BlogDto input)
        {
            _blogService.Create(input);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var blog = _blogService.GetAll();
            var model = new BlogGetAllModel(blog);
            return View(model);
        }
        [HttpGet]
        public IActionResult Translate()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddTtranslate(int id)
        {
            var kancelarija = _blogService.GetById(id);
            return View();
        }
    }
}