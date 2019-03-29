using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaBoilerplate.Kancelarija;

namespace KancelarijaBoilerplate.Web.Views
{
    public class KancelarijaGetAllModel
    {
        public IReadOnlyList<KancelarijaInput> Kancelarija { get; }

        public KancelarijaGetAllModel(IReadOnlyList<KancelarijaInput> kancelarija)
        {
            Kancelarija = kancelarija;
        }
    }
}
