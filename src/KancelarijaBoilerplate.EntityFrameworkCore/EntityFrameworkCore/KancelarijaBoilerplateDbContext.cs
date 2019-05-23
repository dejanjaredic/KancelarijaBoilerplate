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
        public DbSet<Language> Languages { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasKey(c => new { c.Id, c.Lancode });
            modelBuilder.Entity<Blog>().Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
