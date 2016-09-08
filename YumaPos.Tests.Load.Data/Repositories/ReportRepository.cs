using YumaPos.Tests.Load.Data.Interfaces;

namespace YumaPos.Tests.Load.Data.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly TestDbContext _dbContext;

        public ReportRepository(IEntityContainer container)
        {
            _dbContext = container.Context;
        }
    }
}