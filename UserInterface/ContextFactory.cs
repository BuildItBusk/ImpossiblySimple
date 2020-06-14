using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Services.EFCore;
using System.Configuration;
using System.IO;

namespace UserInterface
{
    /// <summary>
    /// Used to provide consistant instances of DbContext. Also required to use Entity Frameworks migration feature.
    /// </summary>
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        private const string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ImpossiblySimple;Integrated Security=True;";

        public MyContext CreateDbContext() => CreateDbContext(null);

        public MyContext CreateDbContext(string[] args)
        {
            //string connStr = ConfigurationManager.ConnectionStrings["SqlDb"].ConnectionString;
            var builder = new DbContextOptionsBuilder<MyContext>();
            builder.UseSqlServer(connStr);
            return new MyContext(builder.Options);
        }
    }
}
