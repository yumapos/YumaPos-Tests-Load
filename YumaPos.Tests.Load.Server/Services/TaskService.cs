using System;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Server.Data.DataObjects;
using YumaPos.Tests.Load.Server.Interfaces;

namespace YumaPos.Tests.Load.Server.Services
{
    public class TaskService: ITaskService
    {
        public Task<TestTask> CreateTask(Job job, Terminal terminal, Employee employee, Client client)
        {
            throw new NotImplementedException();
        }
    }
}