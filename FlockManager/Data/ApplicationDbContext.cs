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
        public DbSet<FamilyTree> FamilyTree { get; set; }
        public DbSet<Health> Health { get; set; }
        public DbSet<MilkOutput> Milk { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sheep>().HasData(
                new Sheep { Id = 8079, Sex = 'F', Name = "Tim", BirthDate = new DateOnly(2018, 3, 20) },
                new Sheep { Id = 109, Sex = 'F', Name = "Caboose", BirthDate = new DateOnly(2021, 3, 11) }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
