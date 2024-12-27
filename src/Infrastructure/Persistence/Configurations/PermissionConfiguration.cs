using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal sealed class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.HasMany<RolePermission>()
                .WithOne(e => e.Permission)
                .HasForeignKey(e => e.PermissionId)
                .IsRequired();
            builder.HasMany<Permission>()
                .WithOne(e => e.ParentPermission)
                .HasForeignKey(e => e.ParentPermissionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}