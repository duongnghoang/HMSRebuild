using Domain.Entities.RoomTypeFees;
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
            IOptions<ConnectionStrings> connectionStrings)
            : base(options)
        {
            _connectionString = connectionStrings.Value!.DefaultConnection;
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
        public virtual DbSet<Menu> Menus => Set<Menu>();
        public virtual DbSet<RoleMenu> RoleMenus => Set<RoleMenu>();
        public virtual DbSet<FeePolicy> FeePolicies => Set<FeePolicy>();
        public virtual DbSet<DayFee> DayFees => Set<DayFee>();
        public virtual DbSet<NightFee> NightFees => Set<NightFee>();
        public virtual DbSet<WeekFee> WeekFees => Set<WeekFee>();
        public virtual DbSet<MonthFee> MonthFees => Set<MonthFee>();
        public virtual DbSet<HourFee> HourFees => Set<HourFee>();
        public virtual DbSet<HourFeePrice> HourFeePrices => Set<HourFeePrice>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}