using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaBoilerplate.Osoba;
using KancelarijaBoilerplate.Osoba.Dto;
using KancelarijaBoilerplate.Web.Views;
using Microsoft.AspNetCore.Mvc;

namespace KancelarijaBoilerplate.Web.Controllers
{
    public class OsobaController : KancelarijaBoilerplateControllerBase
    {
        private readonly IOsobaAppService _osobaService;

        public OsobaController(IOsobaAppService osobaService)
        {
            _osobaService = osobaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllOsoba()
        {
            var osobe = _osobaService.GetAll();
            var model = new OsobeGetAllModel(osobe);
            return View(model);
        }

        [HttpGet]
        public IActionResult GetOsobaById(int? id)
        {
            OsobaOutpot osoba = null;

            if (id.HasValue)
            {
                osoba = _osobaService.GetById(id.Value);
            }
            
            return View(osoba);
        }

        [HttpGet]
        public IActionResult DeleteOsoba()
        {
            return View();
        }

        
        public IActionResult DeleteOsoba(OssobaDeleteDto input)
        {
            _osobaService.Delete(input);
            return RedirectToAction("GetAllOsoba");
        }
        [HttpGet]
        public IActionResult AddOsoba()
        {
            return View();
        }

        public IActionResult AddOsoba(OsobaInput input)
        {
            _osobaService.Add(input);
            return RedirectToAction("GetAllOsoba");
        }

        [HttpGet]
        public IActionResult EditOsoba()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult EditOsoba(int id, OsobaInput input)
        {
            _osobaService.Edit(id, input);
            return RedirectToAction("GetAllOsoba");
        }
    }
}