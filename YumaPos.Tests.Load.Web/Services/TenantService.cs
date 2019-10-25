using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Infrastructure.Dto;
using YumaPos.Tests.Load.Server.Data;
using YumaPos.Tests.Load.Server.Data.DataObjects;
using YumaPos.Tests.Load.Server.Data.Interfaces;
using YumaPos.Tests.Load.Web.Interfaces;

namespace YumaPos.Tests.Load.Web.Services
{
    public class TenantService : ITenantService
    {
        private readonly IEntityContainer _container;
        private LoadTestDbContext _db;

        public TenantService(IEntityContainer container)
        {
            _container = container;
            _db = _container.Context;
        }
        public async Task Import(Guid tenantId)
        {
            var tenant = await _db.Tenants.SingleAsync(p => p.TenantId == tenantId);
            var server = await _db.Servers.SingleAsync(p => p.ServerId == tenant.ServerId);
            var stores = await _db.Stores.Where(p => p.TenantId == tenant.TenantId).ToListAsync();
            if (string.IsNullOrWhiteSpace(server.SqlConnectionString))
            {
                throw new ValidationException("Server SqlConnectionString must be set for import");
            }
            var rep = new ImportRepository(server.SqlConnectionString);

            _db.Employees.RemoveRange(_db.Employees.Where(p => p.TenantId == tenantId).ToList());
            await _db.SaveChangesAsync();
            var employees = await rep.GetAutomatedEmployes(tenantId);
            var result = new List<Employee>();
            foreach (var employee in employees)
            {
                if (stores.Any(s => s.StoreId == employee.StoreId) && employee.Password == sha256("pass" + employee.Pin))
                {
                    employee.Password = "pass" + employee.Pin;
                    result.Add(employee);
                }
            }
            _db.Employees.AddRange(result);
            await _db.SaveChangesAsync();

            _db.Terminals.RemoveRange(_db.Terminals.Where(p => p.TenantId == tenantId).ToList());
            await _db.SaveChangesAsync();
            var terminals = ( await rep.GetAutomatedTerminals(tenantId)).Where(t => stores.Any( s => s.StoreId == t.StoreId)).ToList();
            _db.Terminals.AddRange(terminals);
            await _db.SaveChangesAsync();

        }


        static string sha256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}