using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KancelarijaBoilerplate.Osoba
{
    public interface IOsobaAppService : IApplicationService
    {
        void Add(OsobaInput input);
        IEnumerable<OsobaOutpot> GetAll();
        OsobaOutpot GetById(int id);
        void Delete(int id);

        void Edit(int id, OsobaInput input);
    }
}
