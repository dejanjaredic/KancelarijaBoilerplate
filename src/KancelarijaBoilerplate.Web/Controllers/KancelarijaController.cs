using KancelarijaBoilerplate.Kancelarija;
using KancelarijaBoilerplate.Web.Views;
using Microsoft.AspNetCore.Mvc;

namespace KancelarijaBoilerplate.Web.Controllers
{
    public class KancelarijaController : KancelarijaBoilerplateControllerBase
    {
        private readonly IKancelarijaService _kancelarijaService;

        public KancelarijaController(IKancelarijaService kancelarijaService)
        {
            _kancelarijaService = kancelarijaService;
        }
        [HttpGet]
        public IActionResult KreirajKancelariju()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KreirajKancelariju(KancelarijaInput input)
        {
            _kancelarijaService.Create(input);
            return RedirectToAction("GetAll");
            
        }

        public IActionResult GetAll()
        {
            var kancelarije = _kancelarijaService.GetAll();
            var model = new KancelarijaGetAllModel(kancelarije);
            return View(model);
        }

        [HttpGet]
        public IActionResult GetById(int? id)
        {
            KancelarijaInput kancelarija = null;
            if (id.HasValue)
            {
                kancelarija = _kancelarijaService.GetById(id.Value);
            }
            
            return View(kancelarija);
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Delete(KancelarijaDeleteDto input)
        {
            _kancelarijaService.Remove(input);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Edit(int id, KancelarijaEditDto input)
        {
            _kancelarijaService.Update(id, input);
            return RedirectToAction("GetAll");
        }
        
    }
}