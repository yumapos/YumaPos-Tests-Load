using System.Data.Entity;
using YumaPos.Tests.Load.Data.Models;

namespace YumaPos.Tests.Load.Data
{
    public class TestDbContext : System.Data.Entity.DbContext
    {
        public TestDbContext(string connectionString):base(connectionString) {}

        public DbSet<TestTask> Tasks { get; set; }
        public DbSet<Report> Reports { get; set; }

    }
}