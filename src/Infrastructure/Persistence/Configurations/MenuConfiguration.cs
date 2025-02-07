using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal sealed class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder
                .Property(m => m.Id)
                .ValueGeneratedNever();

            builder
                .HasMany(m => m.ChildrenMenu)
                .WithOne(p => p.ParentMenu)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(m => m.Status)
                .HasDefaultValue(true);

            builder
                .Property(m => m.IsPresentInSideBar)
                .HasDefaultValue(true);

            builder
                .Property(m => m.IsAllowAnonymous)
                .HasDefaultValue(false);
        }
    }
}
