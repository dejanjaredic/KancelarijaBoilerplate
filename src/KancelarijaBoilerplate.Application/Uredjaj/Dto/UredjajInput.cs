using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace KancelarijaBoilerplate.Uredjaj.Dto
{

    [AutoMapFrom(typeof(Models.Uredjaj))]
    public class UredjajInput : EntityDto
    {
        public string Name { get; set; }

    }
}
