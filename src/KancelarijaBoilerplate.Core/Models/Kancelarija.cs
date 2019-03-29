using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace KancelarijaBoilerplate.Models
{
    public class Kancelarija : Entity
    {

        public string Opis { get; set; }

        public List<Osoba> Osoba { get; set; } = new List<Osoba>();
    }
}