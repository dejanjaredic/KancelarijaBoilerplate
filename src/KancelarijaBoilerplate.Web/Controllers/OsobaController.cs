using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaBoilerplate.Kancelarija;
using KancelarijaBoilerplate.Osoba;
using KancelarijaBoilerplate.Osoba.Dto;
using KancelarijaBoilerplate.Web.Dto;
using KancelarijaBoilerplate.Web.Views;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KancelarijaBoilerplate.Web.Controllers
{
    public class OsobaController : KancelarijaBoilerplateControllerBase
    {
        private readonly IOsobaAppService _osobaService;
        private readonly IKancelarijaService _kancelarijaService;

        public OsobaController(IOsobaAppService osobaService, IKancelarijaService kancelarijaService)
        {
            _osobaService = osobaService;
            _kancelarijaService = kancelarijaService;
        }

        public SelectList KancelarijaDropdown()
        {
            var kancelarijaDropdown = new DropdownKancelarijaDto(_kancelarijaService);

            var kancelarije = kancelarijaDropdown.Kancelarija.ToList();
            SelectList selectList = new SelectList(kancelarije, "Id", "Opis");
            return selectList;
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

        public IActionResult DeleteOsoba(OssobaDeleteDto input)
        {
            _osobaService.Delete(input);
            return RedirectToAction("GetAllOsoba");
        }
        [HttpGet]
        public IActionResult AddOsoba()
        {
            var kancelarije = KancelarijaDropdown();
            ViewData["DropDown"] = kancelarije;
            return View(new OsobaInput());
        }


        public IActionResult AddOsoba(OsobaInput input)
        {
            _osobaService.Add(input);
            return RedirectToAction("GetAllOsoba");
        }

        [HttpGet]
        public IActionResult EditOsoba(int id)
        {
            var osoba = _osobaService.GetById(id);
            OsobaInput promjenjenaOsoba = new OsobaInput();
            promjenjenaOsoba.Ime = osoba.Ime;
            promjenjenaOsoba.Prezime = osoba.Prezime;
            promjenjenaOsoba.KancelarijaId = osoba.Kancelarija.Id;
            //promjenjenaOsoba.Kancelarija.Opis = osoba.Kancelarija.Opis;
            return View(promjenjenaOsoba);
        }

        

        [HttpPost]
        public IActionResult EditOsoba(int id, OsobaInput input)
        {
            _osobaService.Edit(id, input);
            return RedirectToAction("GetAllOsoba");
        }
    }
}