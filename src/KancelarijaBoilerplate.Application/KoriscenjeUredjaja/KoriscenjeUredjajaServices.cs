using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Abp.Domain.Repositories;
using Abp.UI;
using KancelarijaBoilerplate.KoriscenjeUredjaja.Dto;
using Microsoft.EntityFrameworkCore;

namespace KancelarijaBoilerplate.KoriscenjeUredjaja
{
    public class KoriscenjeUredjajaServices : KancelarijaBoilerplateAppServiceBase, IKoriscenjeUredjajaServices
    {
        private readonly IRepository<Models.KoriscenjeUredjaja> _koriscenjeUredjajaService;
        private readonly IRepository<Models.Osoba> _osobaService;
        private readonly IRepository<Models.Uredjaj> _uredjajService;


        public KoriscenjeUredjajaServices(IRepository<Models.KoriscenjeUredjaja> koriscenjeUredjajaService, IRepository<Models.Osoba> osobaService, IRepository<Models.Uredjaj> uredjajService)
        {
            _koriscenjeUredjajaService = koriscenjeUredjajaService;
            _osobaService = osobaService;
            _uredjajService = uredjajService;
        }
        public void Create(KoriscenjeUredjajaInput input)
        {
            Models.KoriscenjeUredjaja novoKoriscenje = new Models.KoriscenjeUredjaja();
            var uredj = _uredjajService.FirstOrDefault(x => x.Id == input.UredjajId);
            var osoba = _osobaService.FirstOrDefault(y => y.Id == input.OsobaId);
            
            novoKoriscenje.VrijemeOd = DateTime.Now;
            

            var korisceniUredjaji = _koriscenjeUredjajaService.GetAll().Include(x => x.Uredjaj).Include(y => y.Osoba);
            var queryUredjaja = korisceniUredjaji.Where(x => x.UredjajId == input.UredjajId && x.VrijemeDo == null).Select(y => y.Id);
            var uredjaj = queryUredjaja.FirstOrDefault();
            

            if (queryUredjaja.Count() != 0)
            {
                var izmijeniVrijeme = _koriscenjeUredjajaService.Get(uredjaj);
                izmijeniVrijeme.VrijemeDo = DateTime.Now;
                

            }
            novoKoriscenje.Osoba = osoba;
            novoKoriscenje.Uredjaj = uredj;

            _koriscenjeUredjajaService.Insert(novoKoriscenje);

        }

        public void Delete(KoriscenjeUredjajaDelete input)
        {
            var koriscenUredjaj = _koriscenjeUredjajaService.Get(input.Id);
            if (koriscenUredjaj == null)
            {
                throw new UserFriendlyException("Uredjaj  se ne koristi");
            }
            _koriscenjeUredjajaService.Delete(ObjectMapper.Map<Models.KoriscenjeUredjaja>(koriscenUredjaj));
        }

        public List<KoriscenjeUredjajaOutput> GetAll()
        {
            var korisceniUredjaji = _koriscenjeUredjajaService.GetAll().Include(x => x.Osoba).Include(x => x.Uredjaj);
            return new List<KoriscenjeUredjajaOutput>(ObjectMapper.Map<List<KoriscenjeUredjajaOutput>>(korisceniUredjaji));
        }

        public KoriscenjeUredjajaOutput GetById(int id)
        {
            var koriscenUredjaj = _koriscenjeUredjajaService.Get(id);
            return ObjectMapper.Map<KoriscenjeUredjajaOutput>(koriscenUredjaj);
        }
    }
}
