using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection.Metadata;
using System.Text;
using tv_shows_service.domain;
using tv_shows_service.efc_data_access.Configurations;

namespace tv_shows_service.efc_data_access
{
    public class TVShowsServiceContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FLVCQ2T;Initial Catalog=tvshows;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
