using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace KancelarijaBoilerplate.Models
{
    public class KoriscenjeUredjaja : Entity
    {
        public DateTime VrijemeOd { get; set; }
        public DateTime? VrijemeDo { get; set; }

        public int UredjajId { get; set; }
        [ForeignKey("UredjajId")]
        public Uredjaj Uredjaj { get; set; }

        public int OsobaId { get; set; }
        [ForeignKey("OsobaId")]
        public Osoba Osoba { get; set; }
    }
}