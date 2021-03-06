﻿using System.Collections.Generic;
using Abp.Domain.Repositories;
using Abp.UI;
using KancelarijaBoilerplate.Uredjaj.Dto;

namespace KancelarijaBoilerplate.Uredjaj
{
    public class UredjajService : KancelarijaBoilerplateAppServiceBase, IUredjajService
    {
        private readonly IRepository<Models.Uredjaj> _uredjajRepository;

        public UredjajService(IRepository<Models.Uredjaj> uredjajRepository)
        {
            _uredjajRepository = uredjajRepository;
        }


        public void Create(UredjajInput input)
        {
            var uredjaj = _uredjajRepository.FirstOrDefault(x => x.Id == input.Id);
            if (uredjaj != null)
            {
                throw new UserFriendlyException("Vec postoji");
            }
            _uredjajRepository.Insert(ObjectMapper.Map<Models.Uredjaj>(input));

        }

        public void Remove(UredjajDeleteDto input)
        {
            var uredjaj = _uredjajRepository.Get(input.Id);
            _uredjajRepository.Delete(ObjectMapper.Map<Models.Uredjaj>(uredjaj));
        }

        public void Update(int id, UredjajEditDto input)
            {
            var uredjaj = _uredjajRepository.Get(id);
            if (uredjaj == null)
            {
                throw new UserFriendlyException("Nepostojeci uredjaj");
            }

            ObjectMapper.Map(input, uredjaj);
            
        }

        public List<UredjajInput> GetAll()
        {
            var uredjaji = _uredjajRepository.GetAll();
            return new List<UredjajInput>(ObjectMapper.Map<List<UredjajInput>>(uredjaji));
        }
        
        public UredjajInput GetById(int id)
        {
            var uredjaj = _uredjajRepository.Get(id);
            return ObjectMapper.Map<UredjajInput>(uredjaj);
        }
        
    }
}
