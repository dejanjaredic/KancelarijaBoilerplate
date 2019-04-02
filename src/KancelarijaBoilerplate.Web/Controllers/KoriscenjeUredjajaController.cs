using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaBoilerplate.KoriscenjeUredjaja;
using KancelarijaBoilerplate.KoriscenjeUredjaja.Dto;
using KancelarijaBoilerplate.Web.Views;
using Microsoft.AspNetCore.Mvc;

namespace KancelarijaBoilerplate.Web.Controllers
{
    public class KoriscenjeUredjajaController : KancelarijaBoilerplateControllerBase
    {
        private readonly IKoriscenjeUredjajaServices _koriscenjeUredjajaService;

        public KoriscenjeUredjajaController(IKoriscenjeUredjajaServices koriscenjeUredjajaService)
        {
            _koriscenjeUredjajaService = koriscenjeUredjajaService;
        }
        public IActionResult Index()
        {
            return View();
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
            return View();
        }
        [HttpPost]
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