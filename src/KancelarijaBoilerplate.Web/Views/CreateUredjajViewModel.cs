using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaBoilerplate.Uredjaj.Dto;

namespace KancelarijaBoilerplate.Web.Views
{
    public class CreateUredjajViewModel
    {
        public UredjajInput Uredjaj { get; set; }

        public CreateUredjajViewModel(UredjajInput uredjaj)
        {
            Uredjaj = Uredjaj;
        }
    }
}
