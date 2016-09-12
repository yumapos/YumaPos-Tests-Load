using System.Data.Entity;
using YumaPos.Tests.Load.Client.Data.Models;

namespace YumaPos.Tests.Load.Client.Data
{
    public class TestClientDbContext : System.Data.Entity.DbContext
    {
        public TestClientDbContext(string connectionString):base(connectionString) {}

        public DbSet<TestTask> Tasks { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Config> Configuations { get; set; }
    }
}