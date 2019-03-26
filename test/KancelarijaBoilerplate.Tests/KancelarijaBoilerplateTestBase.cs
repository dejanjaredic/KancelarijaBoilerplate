using System;
using System.Threading.Tasks;
using Abp.TestBase;
using KancelarijaBoilerplate.EntityFrameworkCore;
using KancelarijaBoilerplate.Tests.TestDatas;

namespace KancelarijaBoilerplate.Tests
{
    public class KancelarijaBoilerplateTestBase : AbpIntegratedTestBase<KancelarijaBoilerplateTestModule>
    {
        public KancelarijaBoilerplateTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<KancelarijaBoilerplateDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<KancelarijaBoilerplateDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<KancelarijaBoilerplateDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<KancelarijaBoilerplateDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<KancelarijaBoilerplateDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<KancelarijaBoilerplateDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<KancelarijaBoilerplateDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<KancelarijaBoilerplateDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
