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
    }
}
