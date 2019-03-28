using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaBoilerplate.Uredjaj.Dto;

namespace KancelarijaBoilerplate.Web.Views
{
    public class GetByIdViewModel
    {
        public UredjajInput Uredjaj { get; }

        public GetByIdViewModel(UredjajInput uredjaj)
        {
            Uredjaj = uredjaj;
        }
    }
}
