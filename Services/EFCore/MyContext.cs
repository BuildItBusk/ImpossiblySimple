using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services.EFCore.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Services.EFCore
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<Asset> Assets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AuditableEntityConfiguration<Agreement>());
            builder.ApplyConfiguration(new AuditableEntityConfiguration<Asset>());
        }

    }
}
