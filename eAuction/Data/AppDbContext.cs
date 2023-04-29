using eAuction.Models;
using Microsoft.EntityFrameworkCore;

namespace eAuction.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
         base.OnModelCreating(modelBuilder);
        }
        public DbSet<DigitalGoods> DigitalGood { get; set; }

        public DbSet<Products> Product { get; set; }

        public DbSet<Services> Service { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }



    }
}
