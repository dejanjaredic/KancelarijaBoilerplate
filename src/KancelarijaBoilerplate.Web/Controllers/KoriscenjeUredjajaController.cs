using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaBoilerplate.KoriscenjeUredjaja;
using KancelarijaBoilerplate.KoriscenjeUredjaja.Dto;
using KancelarijaBoilerplate.Osoba;
using KancelarijaBoilerplate.Uredjaj;
using KancelarijaBoilerplate.Web.Dto;
using KancelarijaBoilerplate.Web.Views;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KancelarijaBoilerplate.Web.Controllers
{
    public class KoriscenjeUredjajaController : KancelarijaBoilerplateControllerBase
    {
        private readonly IKoriscenjeUredjajaServices _koriscenjeUredjajaService;
        private readonly IUredjajService _uredjajService;
        private readonly IOsobaAppService _osobaService;

        public KoriscenjeUredjajaController(IKoriscenjeUredjajaServices koriscenjeUredjajaService, IUredjajService uredjajService, IOsobaAppService osobaService)
        {
            _koriscenjeUredjajaService = koriscenjeUredjajaService;
            _uredjajService = uredjajService;
            _osobaService = osobaService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public SelectList UredjajDropdown()
        {
            var uredjajDropdown = new DropdownUredjajDto(_uredjajService);

            var uredjaji = uredjajDropdown.Uredjaj.ToList();
            SelectList selectList = new SelectList(uredjaji, "Id", "Name");
            return selectList;
        }

        public SelectList OsobaDropdown()
        {
            var osobaDropdown = new DropdownOsobaDto(_osobaService);

            var osobe = osobaDropdown.Osobe.ToList();
            SelectList selectList = new SelectList(osobe, "Id", "Ime");
            return selectList;
        }

        [HttpGet]
        public IActionResult GetAllHistory()
        {
            var history = _koriscenjeUredjajaService.GetAll();
            var model = new KoriscenjeUredjajaModel(history);
            return View(model);
        }

        [HttpGet]
        public IActionResult CreateHistory()
        {
            var osobe = OsobaDropdown();
            ViewData["OsobaDropdown"] = osobe;
            return View(new KoriscenjeUredjajaInput());
        }
        
        public IActionResult CreateHistory(KoriscenjeUredjajaInput input)
        {
            _koriscenjeUredjajaService.Create(input);
            return RedirectToAction("GetAllHistory");
        }

        [HttpGet]
        public IActionResult GetHistoryById(int? id)
        {
            KoriscenjeUredjajaOutput koriscenje = null;
            if (id.HasValue)
            {
                koriscenje = _koriscenjeUredjajaService.GetById(id.Value);
            }
            
            return View(koriscenje);
        }

        
        public IActionResult DeleteHistory(KoriscenjeUredjajaDelete input)
        {
            _koriscenjeUredjajaService.Delete(input);
            return RedirectToAction("GetAllHistory");
        }
    }
}