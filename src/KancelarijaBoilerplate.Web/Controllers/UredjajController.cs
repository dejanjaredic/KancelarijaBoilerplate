using KancelarijaBoilerplate.Uredjaj;
using KancelarijaBoilerplate.Uredjaj.Dto;
using KancelarijaBoilerplate.Web.Views;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KancelarijaBoilerplate.Web.Controllers
{
    public class UredjajController : KancelarijaBoilerplateControllerBase
    {
        private readonly IUredjajService _uredjajService;
        public UredjajController(IUredjajService uredjajService)
        {
            _uredjajService = uredjajService;
        }


        public IActionResult GetAll()
        {
            var output = _uredjajService.GetAll();
            var model = new UredjajViewMmodel(output);
            return View(model);
        }
        [HttpGet]
        public IActionResult GetById(int? id)
        {
            UredjajInput uredjaj = null;
            if (id.HasValue)
            {
                uredjaj = _uredjajService.GetById(id.Value);
            }

            return View(uredjaj);
        }

        [HttpGet]
        public IActionResult KreiranjeUredjaja()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KreiranjeUredjaja(UredjajInput input)
        {

            _uredjajService.Create(input);
            //var stringValues = Request.Form[input.Name];
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int id, UredjajEditDto input)
        {
            _uredjajService.Update(id, input);
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Delete(UredjajDeleteDto input)
        {
            _uredjajService.Remove(input);
            return RedirectToAction("GetAll");
        }

    }
}
