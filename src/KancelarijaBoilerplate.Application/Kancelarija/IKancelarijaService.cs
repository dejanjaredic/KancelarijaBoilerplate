using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;

namespace KancelarijaBoilerplate.Kancelarija
{
    public interface IKancelarijaService : IApplicationService
    {
        void Create(KancelarijaInput input);
        void Remove(KancelarijaDeleteDto input);
        void Update(int id, KancelarijaEditDto input);
        List<KancelarijaInput> GetAll();
        KancelarijaInput GetById(int id);

    }
}
