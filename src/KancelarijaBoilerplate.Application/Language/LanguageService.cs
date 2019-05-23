using Abp.AutoMapper;
using Abp.Domain.Repositories;
using AutoMapper;

namespace KancelarijaBoilerplate.Language
{
    public class LanguageService : ILanguageService
    {
        private readonly IRepository<Models.Language> _languageRepository;
        //private readonly IObjectMapper _objectMapper;
        public LanguageService(IRepository<Models.Language> languageRepository)
        {
            _languageRepository = languageRepository;
            //_objectMapper = objectMapper;
        }
        public void Create(LanguageDto input)
        {
            Models.Language language = input.MapTo<Models.Language>();

            _languageRepository.Insert(language);
        }
    }
}
