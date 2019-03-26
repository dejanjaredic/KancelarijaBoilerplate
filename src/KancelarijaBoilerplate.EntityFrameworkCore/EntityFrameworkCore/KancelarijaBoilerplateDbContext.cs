using Abp.EntityFrameworkCore;
using KancelarijaBoilerplate.Models;
using Microsoft.EntityFrameworkCore;

namespace KancelarijaBoilerplate.EntityFrameworkCore
{
    public class KancelarijaBoilerplateDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public KancelarijaBoilerplateDbContext(DbContextOptions<KancelarijaBoilerplateDbContext> options) 
            : base(options)
        {

        }
        public DbSet<Kancelarija> Kancelarije { get; set; }
        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Uredjaj> Uredjaji { get; set; }
        public DbSet<KoriscenjeUredjaja> KorisceniUredjaji { get; set; }
    }
}
