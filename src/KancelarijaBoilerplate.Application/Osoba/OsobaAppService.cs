using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Repositories;
using Abp.UI;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace KancelarijaBoilerplate.Osoba.Dto
{
    public class OsobaAppService : KancelarijaBoilerplateAppServiceBase, IOsobaAppService
    {
        private readonly IRepository<Models.Osoba> _osobaService;
        private readonly IRepository<Models.Kancelarija> _kancelarijaService;

        public OsobaAppService(IRepository<Models.Osoba> osobaService, IRepository<Models.Kancelarija> kancelarija)
        {
            _osobaService = osobaService;
            _kancelarijaService = kancelarija;
        }
        public void Add(OsobaInput input)
        {
            Models.Osoba osoba = new Models.Osoba();
            Models.Kancelarija novaKancelarija = new Models.Kancelarija();
            osoba.Ime = input.Ime;
            osoba.Prezime = input.Prezime;
            var kancelarija = _kancelarijaService.Get(input.KancelarijaId);
           
                osoba.KancelarijaId = input.KancelarijaId;
           
            _osobaService.Insert(ObjectMapper.Map<Models.Osoba>(osoba));
        }

        public List<OsobaOutpot> GetAll()
        {
            var osobe = _osobaService.GetAll().Include(c => c.Kancelarija);
            return new List<OsobaOutpot>(ObjectMapper.Map<List<OsobaOutpot>>(osobe));
            
        }

        public OsobaOutpot GetById(int id)
        {
            var osobe = _osobaService.GetAll().Include(x => x.Kancelarija);
            var osoba = osobe.FirstOrDefault(x => x.Id == id);
            return ObjectMapper.Map<OsobaOutpot>(osoba);
        }

        public void Delete(OssobaDeleteDto input)
        {
            var osoba = _osobaService.Get(input.Id);
            _osobaService.Delete(ObjectMapper.Map<Models.Osoba>(osoba));
            
        }

        public void Edit(int id, OsobaInput input)
        {
            var osoba = _osobaService.Get(id);
            if (osoba == null)
            {
                throw new UserFriendlyException("Nepostojeca osoba");
            }

            //osoba.Ime = input.Ime;
            //osoba.Prezime = input.Prezime;
            //osoba.KancelarijaId = input.KancelarijaId;

            ObjectMapper.Map(input, osoba);
        }
    }
}
