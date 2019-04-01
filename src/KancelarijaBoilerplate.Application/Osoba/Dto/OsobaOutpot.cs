using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.AutoMapper;
using KancelarijaBoilerplate.Kancelarija;

namespace KancelarijaBoilerplate.Osoba
{
    [AutoMap(typeof(Models.Osoba))]
    public class OsobaOutpot
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        [ForeignKey("KancelarijaId")]
        public KancelarijaInput Kancelarija { get; set; }
    }
}