using System.Collections.Generic;
using KancelarijaBoilerplate.Kancelarija;

namespace KancelarijaBoilerplate.Web.Dto
{
    public class DropdownKancelarijaDto
    {
        public List<KancelarijaInput> Kancelarija { get; set; }

        public DropdownKancelarijaDto(IKancelarijaService services)
        {
            Kancelarija = services.GetAll();
        }
    }
}
