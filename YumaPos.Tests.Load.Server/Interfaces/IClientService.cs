using System;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Server.Data.DataObjects;

namespace YumaPos.Tests.Load.Server.Interfaces
{
    public interface IClientService
    {
        Task<Guid> RegisterClient(Guid clientId, string userHostAddress, string name);
        Task ActivateClient(Guid clientId);
        Task<Data.DataObjects.Client> GetByToken(Guid token);
        Task IncreaseTaskCount(Guid clientId);
    }
}