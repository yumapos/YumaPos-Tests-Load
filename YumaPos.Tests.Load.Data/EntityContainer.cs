using System.Configuration;
using YumaPos.Tests.Load.Client.Data.Interfaces;

namespace YumaPos.Tests.Load.Client.Data
{
    public class EntityContainer : IEntityContainer
    {
        private TestClientDbContext _context;

        public TestClientDbContext Context
        {
            get
            {
                return _context ?? (_context = new TestClientDbContext(ConnectionString));
            }
        }

        public string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["TestDatabase"].ConnectionString;
            }
        }
    }
}