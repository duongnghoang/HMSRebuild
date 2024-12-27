using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal sealed class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasOne<Role>()
                .WithMany()
                .HasForeignKey(e => e.RoleId)
                .IsRequired();
            builder.HasOne<Permission>()
                .WithMany()
                .HasForeignKey(e => e.PermissionId)
                .IsRequired();
        }
    }
}