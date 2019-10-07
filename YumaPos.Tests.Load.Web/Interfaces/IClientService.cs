using System;
using System.Threading.Tasks;

namespace YumaPos.Tests.Load.Web.Interfaces
{
    public interface IClientService
    {
        Task<Guid> RegisterClient(Guid clientId, string userHostAddress, string name);
        Task ActivateClient(Guid clientId);
        Task<YumaPos.Tests.Load.Server.Data.DataObjects.Client> GetByToken(Guid token);
        Task IncreaseTaskCount(Guid clientId);
    }
}