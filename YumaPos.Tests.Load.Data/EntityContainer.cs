using System.Configuration;
using System.Data.Entity.Infrastructure;
using YumaPos.Tests.Load.Client.Data.Interfaces;

namespace YumaPos.Tests.Load.Client.Data
{
    public class EntityContainer : IEntityContainer, IDbContextFactory<TestClientDbContext>
    {
        private TestClientDbContext _context;

        public TestClientDbContext Context
        {
            get
            {
                return _context ?? (_context = Create());
            }
        }
        public TestClientDbContext Create()
        {
            return new TestClientDbContext("TestDatabase");
        }
    }

}