using CodeFirstDesign.Db.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDesign.Db
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Player> Players
        {
            get;
            set;
        }
        public DbSet<PlayerInstrument> PlayerInstruments
        {
            get;
            set;
        }
        public DbSet<InstrumentType> InstrumentTypes
        {
            get;
            set;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Player>()
            .HasMany(p => p.Instruments)
            .WithOne();



            modelBuilder.Seed();
        }
    }
}

