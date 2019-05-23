using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace KancelarijaBoilerplate.Language
{
    [AutoMap(typeof(Models.Language))]
    public class LanguageDto : EntityDto
    {
        public string Name { get; set; }
        public string Prefix { get; set; }
        public string Flag { get; set; }
    }
}