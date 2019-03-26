using Abp.Modules;
using Abp.Reflection.Extensions;
using KancelarijaBoilerplate.Localization;

namespace KancelarijaBoilerplate
{
    public class KancelarijaBoilerplateCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            KancelarijaBoilerplateLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KancelarijaBoilerplateCoreModule).GetAssembly());
        }
    }
}