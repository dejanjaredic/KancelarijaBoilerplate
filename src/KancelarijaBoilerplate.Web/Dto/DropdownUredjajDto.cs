using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaBoilerplate.Uredjaj;
using KancelarijaBoilerplate.Uredjaj.Dto;

namespace KancelarijaBoilerplate.Web.Dto
{
    public class DropdownUredjajDto
    {
        public List<UredjajInput> Uredjaj { get; set; }

        public DropdownUredjajDto(IUredjajService service)
        {
            Uredjaj = service.GetAll();
        }
    }
}
