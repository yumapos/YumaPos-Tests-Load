using System;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Server.Data.DataObjects;

namespace YumaPos.Tests.Load.Server.Interfaces
{
    public interface IJobService
    {
        Task<Job> GetNextJob();
        Task<Tuple<Terminal, Employee>> ReserveEmployeeAndTerminal(Job job);
    }

    public interface ITaskService
    {
        Task<TestTask> CreateTask(Job job, Terminal terminal, Employee employee, Client client);
    }
}