using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace KancelarijaBoilerplate.Blog
{
    [AutoMap(typeof(Models.Blog))]
    public class BlogDto : EntityDto
    {
        
        public string Person { get; set; }
        public string Post { get; set; }
        public string Lancode { get; set; } = "en";
    }
}