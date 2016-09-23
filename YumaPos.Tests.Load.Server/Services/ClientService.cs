using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Server.Data;
using YumaPos.Tests.Load.Server.Data.DataObjects;
using YumaPos.Tests.Load.Server.Data.Interfaces;
using YumaPos.Tests.Load.Server.Interfaces;

namespace YumaPos.Tests.Load.Server.Services
{
    public class ClientService : IClientService
    {
        private readonly LoadTestDbContext _db;

        public ClientService(IEntityContainer container)
        {
            _db = container.Context;
        }
        public async Task<Guid> RegisterClient(Guid clientId, string userHostAddress, string name)
        {
            var client = await _db.Clients.FindAsync(clientId);
            if (client == null)
            {
                client = new Client();
                _db.Clients.Add(client);
            }
            client.ClientId = clientId;
            client.Name = name;
            client.Token = Guid.NewGuid();
            client.UserHostAddress = userHostAddress;
            client.IsActive = false;
            client.LastActivity = DateTimeOffset.Now;
            await _db.SaveChangesAsync();
            return client.Token;
        }

        public async Task ActivateClient(Guid clientId)
        {
            (await _db.Clients.FindAsync(clientId)).IsActive = true;
            await _db.SaveChangesAsync();
        }

        public Task<Client> GetByToken(Guid token)
        {
            return _db.Clients.SingleOrDefaultAsync(p => p.Token == token);
        }

        public async Task IncreaseTaskCount(Guid clientId)
        {
            (await _db.Clients.FindAsync(clientId)).TasksCount++;
            await _db.SaveChangesAsync();
        }
    }
}