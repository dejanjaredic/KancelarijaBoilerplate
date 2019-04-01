using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaBoilerplate.Osoba;

namespace KancelarijaBoilerplate.Web.Views
{
    public class OsobeGetAllModel
    {
        public IReadOnlyList<OsobaOutpot> Osoba { get;  }

        public OsobeGetAllModel(IReadOnlyList<OsobaOutpot> osoba)
        {
            Osoba = osoba;
        }
    }
}
