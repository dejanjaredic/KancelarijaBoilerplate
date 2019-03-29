﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;

namespace KancelarijaBoilerplate.Models
{
    public class Osoba : Entity
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int KancelarijaId { get; set; }
        [ForeignKey("KancelarijaId")]
        public Kancelarija Kancelarija { get; set; }

        public List<KoriscenjeUredjaja> KoriscenjeUredjaja { get; set; } = new List<KoriscenjeUredjaja>();
    }
}
