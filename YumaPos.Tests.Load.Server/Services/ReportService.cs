using System.Linq;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Infrastucture.Dto;
using YumaPos.Tests.Load.Server.Data;
using YumaPos.Tests.Load.Server.Data.DataObjects;
using YumaPos.Tests.Load.Server.Data.Interfaces;
using YumaPos.Tests.Load.Server.Interfaces;

namespace YumaPos.Tests.Load.Server.Services
{
    public class ReportService : IReportService
    {
        private LoadTestDbContext _db;

        public ReportService(IEntityContainer container)
        {
            _db = container.Context;
        }
        public async Task Add(ReportDto report)
        {
            var test = await _db.TestTasks.FindAsync(report.TaskId);
            _db.Reports.AddRange(
                report.ReportItems.Select(p => new Report()
                {
                    JobId = test.JobId,
                    TaskId = report.TaskId,
                    MethodName = p.MethodName,
                    Created = p.Created,
                    Duration = p.Duration,
                    ExceptionMessage = p.ExceptionMessage
                }));
            await _db.SaveChangesAsync();
        }
    }
}