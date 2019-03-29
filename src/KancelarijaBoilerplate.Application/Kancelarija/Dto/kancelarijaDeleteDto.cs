using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;

namespace KancelarijaBoilerplate.Kancelarija
{
    [AutoMap(typeof(Models.Kancelarija))]
    public class KancelarijaDeleteDto : EntityDto
    {
    }
}