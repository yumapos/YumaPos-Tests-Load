
using System.Data.Entity.Infrastructure;
using YumaPos.Tests.Load.Server.Data.Interfaces;

namespace YumaPos.Tests.Load.Server.Data
{
    public class EntityContainer : IEntityContainer, IDbContextFactory<LoadTestDbContext>
    {
        private LoadTestDbContext _context;

        public LoadTestDbContext Context
        {
            get
            {
                return _context ?? (_context = Create());
            }
        }

        public LoadTestDbContext Create()
        {
            return new LoadTestDbContext("POSTestLoad");
        }
    }
}