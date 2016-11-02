using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Server.Data.DataObjects;

namespace YumaPos.Tests.Load.Server.Interfaces
{
    public interface IJobService
    {
        Task<Job> GetNextJob();
        Task<Tuple<Terminal, Employee>> ReserveEmployeeAndTerminal(Job job, Guid clientId);
        Task IncreaseTaskCount(int jobId);
        Task CancelByClientId(Guid clientId);
        Task CancelByTaskId(int taskId);
    }

    public interface ITaskService
    {
        Task<TestTask> CreateTask(Job job, Terminal terminal, Employee employee, Client client);
        Task<List<TestTask>> GetTasksByClientId(Guid clientId);
    }

    public interface IPosfDatService
    {
        Task<Terminal> CreateNewTerminal(Guid tenantId, Guid storeId, string dataConnectionString);
        Task<Employee> CreateNewEmployee(Guid tenantId, Guid storeId, string dataConnectionString);
    }
}