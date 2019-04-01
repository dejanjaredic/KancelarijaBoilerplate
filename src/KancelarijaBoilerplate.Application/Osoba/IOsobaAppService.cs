using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using KancelarijaBoilerplate.Osoba.Dto;

namespace KancelarijaBoilerplate.Osoba
{
    public interface IOsobaAppService : IApplicationService
    {
        void Add(OsobaInput input);
        List<OsobaOutpot> GetAll();
        OsobaOutpot GetById(int id);
        void Delete(OssobaDeleteDto input);

        void Edit(int id, OsobaInput input);
    }
}
