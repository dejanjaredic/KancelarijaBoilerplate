using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaBoilerplate.KoriscenjeUredjaja;
using KancelarijaBoilerplate.KoriscenjeUredjaja.Dto;

namespace KancelarijaBoilerplate.Web.Views
{
    public class KoriscenjeUredjajaModel
    {
        public IReadOnlyList<KoriscenjeUredjajaOutput> KoriscenjeUredjaja { get;  }

        public KoriscenjeUredjajaModel(IReadOnlyList<KoriscenjeUredjajaOutput> koriscenjeUredjaja)
        {
            KoriscenjeUredjaja = koriscenjeUredjaja;
        }
    }
}
