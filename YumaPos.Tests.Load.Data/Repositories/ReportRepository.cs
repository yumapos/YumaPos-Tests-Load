using YumaPos.Tests.Load.Client.Data.Interfaces;

namespace YumaPos.Tests.Load.Client.Data.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly TestClientDbContext _dbContext;

        public ReportRepository(IEntityContainer container)
        {
            _dbContext = container.Context;
        }
    }
}