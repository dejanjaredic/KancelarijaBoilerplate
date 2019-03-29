using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace KancelarijaBoilerplate.Uredjaj.Dto
{

    [AutoMap(typeof(Models.Uredjaj))]
    public class UredjajInput : EntityDto
    {
        public string Name { get; set; }

    }
}
