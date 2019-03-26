using Abp.AspNetCore.Mvc.Views;

namespace KancelarijaBoilerplate.Web.Views
{
    public abstract class KancelarijaBoilerplateRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected KancelarijaBoilerplateRazorPage()
        {
            LocalizationSourceName = KancelarijaBoilerplateConsts.LocalizationSourceName;
        }
    }
}
