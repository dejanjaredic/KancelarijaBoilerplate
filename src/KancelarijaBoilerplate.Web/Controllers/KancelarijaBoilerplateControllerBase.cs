using Abp.AspNetCore.Mvc.Controllers;

namespace KancelarijaBoilerplate.Web.Controllers
{
    public abstract class KancelarijaBoilerplateControllerBase: AbpController
    {
        protected KancelarijaBoilerplateControllerBase()
        {
            LocalizationSourceName = KancelarijaBoilerplateConsts.LocalizationSourceName;
        }
    }
}