using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace KancelarijaBoilerplate.Models
{
    public class Language : Entity
    {
        public string Name { get; set; }
        public string Prefix { get; set; }
        public string Flag { get; set; }
    }
}
