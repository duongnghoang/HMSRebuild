using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal sealed class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.HasIndex(e => e.Email).IsUnique();
            builder.HasOne(s => s.Role)
                .WithMany(r => r.Staffs)
                .HasForeignKey(e => e.RoleId)
                .IsRequired();
        }
    }
}