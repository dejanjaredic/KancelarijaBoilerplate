using System.Collections.Generic;
using Abp.Application.Services;
using KancelarijaBoilerplate.Uredjaj.Dto;

namespace KancelarijaBoilerplate.Uredjaj
{
    public interface IUredjajService : IApplicationService
    {
        void Create(UredjajInput input);
        void Remove(UredjajDeleteDto id);
        void Update(int id, UredjajEditDto input);
        List<UredjajInput> GetAll();
        UredjajInput GetById(int id);
    }
}
