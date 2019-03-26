using KancelarijaBoilerplate.Models;
using Microsoft.EntityFrameworkCore;

namespace KancelarijaBoilerplate.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<KancelarijaBoilerplateDbContext> dbContextOptions, 
            string connectionString
            )
        {
        
        /* This is the single point to configure DbContextOptions for KancelarijaBoilerplateDbContext */
        dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
