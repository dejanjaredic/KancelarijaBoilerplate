using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using Abp.Domain.Entities;

namespace KancelarijaBoilerplate.Uredjaj.Dto
{
    [AutoMap(typeof(Models.Uredjaj))]
    public class UredjajDeleteDto : Entity
    {
    }
}
