﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace KancelarijaBoilerplate.Kancelarija
{
    [AutoMap(typeof(Models.Kancelarija))]
    public class KancelarijaInput : EntityDto
    {

        public string Opis { get; set; }

       // public List<Osoba> Osoba { get; set; } = new List<Osoba>();
    }
}