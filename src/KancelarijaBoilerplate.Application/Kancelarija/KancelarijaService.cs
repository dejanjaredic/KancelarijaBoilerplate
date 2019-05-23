using System.Collections.Generic;
using Abp.Domain.Repositories;
using Abp.UI;

namespace KancelarijaBoilerplate.Kancelarija
{
    public class KancelarijaService : KancelarijaBoilerplateAppServiceBase, IKancelarijaService
    {
        private readonly IRepository<Models.Kancelarija> _kancelarijaService;

        public KancelarijaService(IRepository<Models.Kancelarija> kancelarijaService)
        {
            _kancelarijaService = kancelarijaService;
        }
        public void Create(KancelarijaInput input)
        {
            var kancelarijaa = _kancelarijaService.FirstOrDefault(x => x.Id == input.Id);
            if (kancelarijaa != null)
            {
                throw new UserFriendlyException("Kancelarija vec postoji");
            }
            Models.Kancelarija kancelarija = ObjectMapper.Map<Models.Kancelarija>(input);

            _kancelarijaService.Insert(kancelarija);
        }

        public void Remove(KancelarijaDeleteDto input)
        {
            var kancelarija = _kancelarijaService.Get(input.Id);
            if (kancelarija == null)
            {
                throw new UserFriendlyException("Kancelarija ne postoji");
            }
            _kancelarijaService.Delete(ObjectMapper.Map<Models.Kancelarija>(kancelarija));
        }

        public void Update(int id, KancelarijaEditDto input)
        {
            var kancelarija = _kancelarijaService.Get(id);
            if (kancelarija == null)
            {
                throw new UserFriendlyException("Kancelarija ne postoji");
            }

            ObjectMapper.Map(input, kancelarija);
        }

        public List<KancelarijaInput> GetAll()
        {
            var kancelarije = _kancelarijaService.GetAll();
            return new List<KancelarijaInput>(ObjectMapper.Map<List<KancelarijaInput>>(kancelarije));
        }

        public KancelarijaInput GetById(int id)
        {
            var kancelarija = _kancelarijaService.Get(id);
            return ObjectMapper.Map<KancelarijaInput>(kancelarija);
        }
    }
}
