using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using KancelarijaBoilerplate.Configuration;
using KancelarijaBoilerplate.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace KancelarijaBoilerplate.Web.Startup
{
    [DependsOn(
        typeof(KancelarijaBoilerplateApplicationModule), 
        typeof(KancelarijaBoilerplateEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class KancelarijaBoilerplateWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public KancelarijaBoilerplateWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(KancelarijaBoilerplateConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<KancelarijaBoilerplateNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(KancelarijaBoilerplateApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KancelarijaBoilerplateWebModule).GetAssembly());
        }
    }
}