using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaBoilerplate.Uredjaj.Dto;

namespace KancelarijaBoilerplate.Web.Views
{
    public class UredjajViewMmodel
    {
        public IReadOnlyList<UredjajInput> Uredjaj { get; }

        public UredjajViewMmodel(IReadOnlyList<UredjajInput> uredjaj)
        {
            Uredjaj = uredjaj;
        }
    }
}
