using Domain.Entities.Users;
using Infrastructure.Persistence.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Staff> Staffs => Set<Staff>();
        public virtual DbSet<Role> Roles => Set<Role>();
        public virtual DbSet<Permission> Permissions => Set<Permission>();
        public virtual DbSet<RolePermission> RolePermissions => Set<RolePermission>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}