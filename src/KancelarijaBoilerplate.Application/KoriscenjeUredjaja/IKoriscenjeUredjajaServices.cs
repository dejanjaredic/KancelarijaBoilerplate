using System;
using System.Collections.Generic;
using System.Text;
using KancelarijaBoilerplate.KoriscenjeUredjaja.Dto;

namespace KancelarijaBoilerplate.KoriscenjeUredjaja
{
    public interface IKoriscenjeUredjajaServices
    {
        void Create(KoriscenjeUredjajaInput input);
        void Delete(KoriscenjeUredjajaDelete input);
        List<KoriscenjeUredjajaOutput> GetAll();
        KoriscenjeUredjajaOutput GetById(int id);
    }

  
}
