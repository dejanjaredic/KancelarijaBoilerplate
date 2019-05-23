using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaBoilerplate.Language;
using Microsoft.AspNetCore.Mvc;

namespace KancelarijaBoilerplate.Web.Controllers
{
    public class LanguageController : KancelarijaBoilerplateControllerBase
    {
        private readonly ILanguageService _languageService;

        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }
        [HttpGet]
        public IActionResult AddLanguage()
        {
            return View();
        }
        
        public IActionResult AddLanguage(LanguageDto input)
        {
            _languageService.Create(input);
            return RedirectToAction("AddLanguage");

        }
    }
}