using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;

namespace KancelarijaBoilerplate.Language
{
    public interface ILanguageService : IApplicationService
    {
        void Create(LanguageDto input);
    }
}
