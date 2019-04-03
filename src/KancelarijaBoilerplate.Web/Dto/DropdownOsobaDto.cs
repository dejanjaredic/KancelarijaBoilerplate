using System.Collections.Generic;
using KancelarijaBoilerplate.Osoba;
using KancelarijaBoilerplate.Uredjaj;

namespace KancelarijaBoilerplate.Web.Controllers
{
    public class DropdownOsobaDto
    {
        public List<OsobaOutpot> Osobe { get; set;  }

        public DropdownOsobaDto(IOsobaAppService services)
        {
            Osobe = services.GetAll();
        }
    }
}