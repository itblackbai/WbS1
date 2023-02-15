
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WbS.Models;

namespace WbS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Contacts> contacts { get; set; } = null!;
        public DbSet<Accounts> accounts { get; set; } = null!;
        public DbSet<Incidents> incidents { get; set; } = null!;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           //Database.EnsureDeleted();
            Database.EnsureCreated();  
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            base.OnModelCreating(builder);
            builder.Entity<Accounts>(entity => {
                entity.HasKey(k => k.Id);
            });
            base.OnModelCreating(builder);
            builder.Entity<Contacts>(entity => {
                entity.HasKey(k => k.Id);
            });
            base.OnModelCreating(builder);
            builder.Entity<Incidents>(entity => {
                entity.HasKey(k => k.Id);
            });
        }

    

    }
}
