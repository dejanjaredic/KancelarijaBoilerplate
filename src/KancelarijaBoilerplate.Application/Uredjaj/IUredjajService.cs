using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Abp.Dependency;
using Abp.Domain.Repositories;
using KancelarijaBoilerplate.Uredjaj.Dto;

namespace KancelarijaBoilerplate.Uredjaj
{
    public interface IUredjajService : IApplicationService
    {
        void Create(UredjajInput input);
        void Remove(int id);
        void Update(int id, Models.Uredjaj input);
        List<UredjajInput> GetAll();
        UredjajInput GetById(int id);
    }
}
