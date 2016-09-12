using System.Configuration;
using YumaPos.Tests.Load.Server.Data.Interfaces;

namespace YumaPos.Tests.Load.Server.Data
{
    public class EntityContainer : IEntityContainer
    {
        private LoadTestDbContext _context;

        public LoadTestDbContext Context
        {
            get
            {
                return _context ?? (_context = new LoadTestDbContext(ConnectionString));
            }
        }

        public string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["POSTestLoad"].ConnectionString;
            }
        }
    }
}