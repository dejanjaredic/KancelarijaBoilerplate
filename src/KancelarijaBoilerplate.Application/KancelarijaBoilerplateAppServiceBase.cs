using Abp.Application.Services;

namespace KancelarijaBoilerplate
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class KancelarijaBoilerplateAppServiceBase : ApplicationService
    {
        protected KancelarijaBoilerplateAppServiceBase()
        {
            LocalizationSourceName = KancelarijaBoilerplateConsts.LocalizationSourceName;
        }
    }
}