using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;

namespace KancelarijaBoilerplate.Uredjaj.Dto
{
    [AutoMap(typeof(Models.Uredjaj))]
    public class UredjajEditDto : EntityDto
    {
        public string Name { get; set; }
    }
}
