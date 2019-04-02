using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace KancelarijaBoilerplate.Osoba
{
    [AutoMap(typeof(Models.Osoba))]
    public class OsobaInput : EntityDto
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int KancelarijaId { get; set; }
        //public List<Models.KoriscenjeUredjaja> KoriscenjeUredjaja { get; set; } = new List<Models.KoriscenjeUredjaja>();
    }
}
