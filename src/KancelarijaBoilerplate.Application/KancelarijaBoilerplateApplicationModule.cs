using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace KancelarijaBoilerplate
{
    [DependsOn(
        typeof(KancelarijaBoilerplateCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class KancelarijaBoilerplateApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KancelarijaBoilerplateApplicationModule).GetAssembly());
        }
    }
}