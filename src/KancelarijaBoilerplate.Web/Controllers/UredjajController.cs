using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var output =  _uredjajService.GetAll();
            var model = new UredjajViewMmodel(output);
            return View(model);
        }

        // GET api/<controller>/5
        public IActionResult GetById(int id)
        {
            var uredjaj = _uredjajService.GetById(id);
            var model = new GetByIdViewModel(uredjaj);
            return View(model);
        }

        // POST api/<controller>
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

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Models.Uredjaj value)
        {
            _uredjajService.Update(id, value);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _uredjajService.Remove(id);
        }
    }
}
