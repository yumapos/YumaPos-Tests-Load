using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Infrastructure.Dto;
using YumaPos.Tests.Load.Server.Data.DataObjects;

namespace YumaPos.Tests.Load.Web.Interfaces
{
    public interface IJobService
    {
        Task<Job> GetNextJob();
        Task<Tuple<Terminal, Employee>> ReserveEmployeeAndTerminal(Job job, Guid clientId);
        Task IncreaseTaskCount(int jobId);
        Task CancelByClientId(Guid clientId);
        Task CancelByTaskId(int taskId);
        void Init();
    }

    public interface ITaskService
    {
        Task<TestTask> CreateTask(Job job, Terminal terminal, Employee employee, YumaPos.Tests.Load.Server.Data.DataObjects.Client client);
        Task<List<TestTask>> GetTasksByClientId(Guid clientId);
    }

    public interface IPosDataService
    {
        Task<Terminal> CreateNewTerminal(Guid tenantId, Guid storeId);
        Task<Employee> CreateNewEmployee(Guid tenantId, Guid storeId);
    }

    public interface IReportService
    {
        Task Add(ReportDto report);
    }
    public interface ITenantService
    {
        Task Import(Guid tenantId);
    }
}