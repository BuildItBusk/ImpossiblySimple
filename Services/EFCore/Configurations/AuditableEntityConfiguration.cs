using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Services.EFCore.Configurations
{
    public class AuditableEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : AuditableEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(e => e.CreatedBy).IsRequired(true).HasMaxLength(64).HasDefaultValueSql("SYSTEM_USER");
            builder.Property(e => e.CreatedDtm).HasDefaultValueSql("SYSDATETIME()");
        }
    }
}
