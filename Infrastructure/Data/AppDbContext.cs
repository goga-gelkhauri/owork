using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Mobile> Mobiles { get; set; }
        public DbSet<Communal> Communals { get; set; }
        public DbSet<Finance> Finances { get; set; }
        public DbSet<Charity> Charities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyAllConfigurationsFromCurrentAssembly();
        }
    }
}