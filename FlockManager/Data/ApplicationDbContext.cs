using FlockManager.Models;
using Microsoft.EntityFrameworkCore;

namespace FlockManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Sheep> Sheep { get; set; }
        public DbSet<Health> Health { get; set; }
        public DbSet<MilkOutput> Milk { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sheep>().HasData(
                new Sheep { Id=1, FarmTag = "8079", ScrapieTag = "0111", Sex = 'F', Name = "Tim", BirthDate = new DateOnly(2018, 3, 20), DamId = "20-18", SireId = "Uknown" },
                new Sheep { Id=2, FarmTag = "104", ScrapieTag = "0111", Sex = 'F', Name = "Caboose", BirthDate = new DateOnly(2021, 3, 11), DamId = "19-48", SireId = "Uknown" }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
