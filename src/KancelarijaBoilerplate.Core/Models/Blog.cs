using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace KancelarijaBoilerplate.Models
{
    public class Blog : Entity
    {
        //public int EntityId { get; set; }
        public string Person { get; set; }
        public string Post { get; set; }
        public string Lancode { get; set; }
    }
}
