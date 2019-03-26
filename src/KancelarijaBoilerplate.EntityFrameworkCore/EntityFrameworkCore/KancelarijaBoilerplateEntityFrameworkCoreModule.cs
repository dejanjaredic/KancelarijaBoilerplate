using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace KancelarijaBoilerplate.EntityFrameworkCore
{
    [DependsOn(
        typeof(KancelarijaBoilerplateCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class KancelarijaBoilerplateEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KancelarijaBoilerplateEntityFrameworkCoreModule).GetAssembly());
        }
    }
}