using Domain.Entities.Users;
using Infrastructure.Persistence.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string _connectionString;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
            IOptions<AppsettingsOption> appSettings)
            : base(options)
        {
            _connectionString = appSettings.Value.ConnectionString!.DefaultConnection;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        public virtual DbSet<Staff> Staffs => Set<Staff>();

        public virtual DbSet<Role> Roles => Set<Role>();

        public virtual DbSet<Permission> Permissions => Set<Permission>();

        public virtual DbSet<RolePermission> RolePermissions => Set<RolePermission>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}