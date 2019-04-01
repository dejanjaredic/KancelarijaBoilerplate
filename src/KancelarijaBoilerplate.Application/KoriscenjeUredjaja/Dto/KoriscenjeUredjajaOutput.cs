using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.AutoMapper;

namespace KancelarijaBoilerplate.KoriscenjeUredjaja
{
    [AutoMap(typeof(Models.Uredjaj))]
    public class KoriscenjeUredjajaOutput
    {
        public DateTime VrijemeOd { get; set; }
        public DateTime? VrijemeDo { get; set; }

        public int UredjajId { get; set; }
        [ForeignKey("UredjajId")]
        public Models.Uredjaj Uredjaj { get; set; }

        public int OsobaId { get; set; }
        [ForeignKey("OsobaId")]
        public Models.Osoba Osoba { get; set; }
    }
}