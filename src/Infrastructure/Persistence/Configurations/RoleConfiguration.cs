using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal sealed class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .HasMaxLength(100);

            // RolePermissions relationship
            builder.HasMany(e => e.RolePermissions)
                .WithOne(e => e.Role)
                .HasForeignKey(e => e.PermissionId)
                .IsRequired();
        }
    }
}