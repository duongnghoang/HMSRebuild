using Domain.Entities.Users;
using Domain.Shared.Permissions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal sealed class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .HasMaxLength(100);

            // Self-referencing ParentPermission relationship
            builder.HasMany(e => e.ChildPermissions)
                .WithOne(e => e.ParentPermission)
                .HasForeignKey(e => e.ParentPermissionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}