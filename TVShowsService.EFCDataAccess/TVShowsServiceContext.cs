using Microsoft.EntityFrameworkCore;
using TVShowsService.Domain;
using TVShowsService.EFCDataAccess.Configurations;

namespace TVShowsService.EFCDataAccess
{
    public class TVShowsServiceContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Show> Shows { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FLVCQ2T;Initial Catalog=tvshows;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ShowConfiguration());
        }
    }
}
