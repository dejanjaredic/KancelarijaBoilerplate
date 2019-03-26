using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using KancelarijaBoilerplate.Web.Startup;
namespace KancelarijaBoilerplate.Web.Tests
{
    [DependsOn(
        typeof(KancelarijaBoilerplateWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class KancelarijaBoilerplateWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KancelarijaBoilerplateWebTestModule).GetAssembly());
        }
    }
}