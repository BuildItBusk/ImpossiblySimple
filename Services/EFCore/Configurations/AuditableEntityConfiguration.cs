using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Services.EFCore.Configurations
{
    public class AuditableEntityConfiguration : IEntityTypeConfiguration<AuditableEntity>
    {
        public void Configure(EntityTypeBuilder<AuditableEntity> builder)
        {
            builder.Property(e => e.CreatedBy).HasDefaultValueSql("USER_NAME()");
            builder.Property(e => e.CreatedDtm).HasDefaultValueSql("GET_DATE()");
        }
    }
}
