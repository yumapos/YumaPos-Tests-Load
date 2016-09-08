using System.Configuration;
using YumaPos.Tests.Load.Data.Interfaces;

namespace YumaPos.Tests.Load.Data
{
    public class EntityContainer : IEntityContainer
    {
        private TestDbContext _context;

        public TestDbContext Context
        {
            get
            {
                return _context ?? (_context = new TestDbContext(ConnectionString));
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