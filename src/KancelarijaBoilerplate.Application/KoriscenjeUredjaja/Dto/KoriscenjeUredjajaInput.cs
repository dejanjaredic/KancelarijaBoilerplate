using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KancelarijaBoilerplate.KoriscenjeUredjaja.Dto
{
    class KoriscenjeUredjajaInput
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
