using Domain;
using Microsoft.EntityFrameworkCore;
using Services.EFCore.Configurations;

namespace Services.EFCore
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<Asset> Assets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
