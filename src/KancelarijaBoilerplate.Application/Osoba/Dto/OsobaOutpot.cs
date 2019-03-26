using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KancelarijaBoilerplate.Osoba
{
    public class OsobaOutpot
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public string Ime { get; set; }
        public string Prezime { get; set; }
        
    }
}