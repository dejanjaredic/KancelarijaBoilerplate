using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace KancelarijaBoilerplate.KoriscenjeUredjaja
{
    [AutoMap(typeof(Models.Uredjaj))]
    public class KoriscenjeUredjajaDelete : EntityDto
    {
    }
}