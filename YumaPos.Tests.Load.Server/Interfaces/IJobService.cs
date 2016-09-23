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
        Task Cancel(List<TestTask> tasks);
    }

    public interface ITaskService
    {
        Task<TestTask> CreateTask(Job job, Terminal terminal, Employee employee, Client client);
        Task<List<TestTask>> GetTasksByClientId(Guid clientId);
    }
}