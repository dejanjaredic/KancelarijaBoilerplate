using KancelarijaBoilerplate.Configuration;
using KancelarijaBoilerplate.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace KancelarijaBoilerplate.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class KancelarijaBoilerplateDbContextFactory : IDesignTimeDbContextFactory<KancelarijaBoilerplateDbContext>
    {
        public KancelarijaBoilerplateDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<KancelarijaBoilerplateDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(KancelarijaBoilerplateConsts.ConnectionStringName)
            );

            return new KancelarijaBoilerplateDbContext(builder.Options);
        }
    }
}