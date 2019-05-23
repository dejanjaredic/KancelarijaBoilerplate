using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace KancelarijaBoilerplate.Models
{
    public class Node : Entity
    {
        public string Uuid { get; set; }
        public string Lancode { get; set; }
    }
}
