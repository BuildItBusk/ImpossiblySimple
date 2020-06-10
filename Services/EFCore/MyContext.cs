using Domain;
using Microsoft.EntityFrameworkCore;

namespace Services.EFCore
{
    public class MyContext : DbContext
    {
        public DbSet<Agreement> Agreements { get; set; }
    }
}
