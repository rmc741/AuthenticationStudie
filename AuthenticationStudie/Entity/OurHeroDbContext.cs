using AuthenticationStudie.Controllers.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationStudie.Entity
{
    public class OurHeroDbContext : DbContext
    {
        public OurHeroDbContext(DbContextOptions<OurHeroDbContext> options) : base(options)
        {
        }

        DbSet<OurHero> OurHeros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OurHero>().HasKey(x => x.Id);

            modelBuilder.Entity<OurHero>().HasData(
                new OurHero
                {
                    Id = 1,
                    FirstName = "System",
                    LastName = "",
                    IsActive = true,
                },
                new OurHero
                {
                    Id = 2,
                    FirstName = "Teste",
                    LastName = "Last Name",
                    IsActive = true,
                }
            );
        }
    }
}
