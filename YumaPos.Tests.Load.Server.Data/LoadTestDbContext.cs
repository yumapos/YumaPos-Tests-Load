using System.Data.Entity;
using YumaPos.Tests.Load.Server.Data.DataObjects;

namespace YumaPos.Tests.Load.Server.Data
{
    public class LoadTestDbContext : DbContext
    {
        public LoadTestDbContext(string connectionString) : base(connectionString)
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<TestTask> TestTasks { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Terminal>().HasRequired(c => c.Tenant).WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<TestTask>().HasRequired(c => c.Tenant).WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<TestTask>().HasRequired(c => c.Store).WithMany().WillCascadeOnDelete(false);
        }

    }
}