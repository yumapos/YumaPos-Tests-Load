using System;
using System.Data.Entity;
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
            var token = Guid.NewGuid();
            var client = new Client()
            {
                ClientId =  clientId,
                Name = name,
                Token = token,
                UserHostAddress = userHostAddress,
                IsActive = false,
                LastActivity = DateTimeOffset.Now
            };
            _db.Clients.Add(client);
            await _db.SaveChangesAsync();
            return token;
        }

        public async Task ActivateClient(Guid clientId)
        {
            (await _db.Clients.FindAsync(clientId)).IsActive = true;
            await _db.SaveChangesAsync();
        }

        public Task<Client> GetByToken(Guid token)
        {
            return _db.Clients.SingleAsync(p => p.Token == token);
        }
    }
}