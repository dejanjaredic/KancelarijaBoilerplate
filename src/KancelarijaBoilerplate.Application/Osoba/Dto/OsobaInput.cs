using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KancelarijaBoilerplate.Osoba
{
    public class OsobaInput
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int KancelarijaId { get; set; }
        [ForeignKey("KancelarijaId")]
        public Models.Kancelarija Kancelarija { get; set; }

        public List<Models.KoriscenjeUredjaja> KoriscenjeUredjaja { get; set; } = new List<Models.KoriscenjeUredjaja>();
    }
}
