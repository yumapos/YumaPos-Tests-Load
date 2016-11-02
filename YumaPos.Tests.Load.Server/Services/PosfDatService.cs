using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using YumaPos.Shared.API;
using YumaPos.Shared.API.Models;
using YumaPos.Shared.Infrastructure;
using YumaPos.Tests.Load.Server.Data;
using YumaPos.Tests.Load.Server.Data.DataObjects;
using YumaPos.Tests.Load.Server.Data.Interfaces;
using YumaPos.Tests.Load.Server.Interfaces;

namespace YumaPos.Tests.Load.Server.Services
{
    public class PosfDatService : IPosfDatService
    {
        private readonly IBackOfficeApi _backOfficeApi;
        private readonly IAuthorizationApi _authorizationApi;
        private readonly ITerminalApi _terminalApi;

        private LoadTestDbContext _db;

        public PosfDatService(IEntityContainer container, IBackOfficeApi backOfficeApi, IAuthorizationApi authorizationApi, ITerminalApi terminalApi)
        {
            _backOfficeApi = backOfficeApi;
            _authorizationApi = authorizationApi;
            _terminalApi = terminalApi;
            _db = container.Context;
        }

        public async Task<Terminal> CreateNewTerminal(Guid tenantId, Guid storeId)
        {
            var userToken = await _authorizationApi.Login("admin", "admin");
            _terminalApi.SetUserToken(userToken);
            var rnd = (new Random()).Next(Int32.MaxValue);
            var terminalDto = new TerminalDto()
            {
                TerminalId = Guid.NewGuid(),
                IsConfirmed = true,
                Name = "term" + rnd,
                StoreId = storeId,
                TerminalNumber = rnd
            };
            var token = (await _terminalApi.AddTerminalToStore(terminalDto)).Value;
            var terminal = new Terminal()
            {
                StoreId = storeId,
                TenantId = tenantId,
                TerminalId =terminalDto.TerminalId,
                Token = token
            };
            _db.Terminals.Add(terminal);
            return terminal;
        }

        public async Task<Employee> CreateNewEmployee(Guid tenantId, Guid storeId, string dataConnectionString)
        {
            var userToken = await _authorizationApi.Login("admin", "admin");
            _backOfficeApi.SetUserToken(userToken);
            var roles = await _backOfficeApi.GetAllRoles();
            foreach (var role in roles)
            {
                role.StoresId = new Guid[] {storeId};
            }
            var rnd = (new Random()).Next(Int32.MaxValue);
            var employeeDto = new EmployeeDto()
            {
                Login = "empl" + rnd,
                CashierPassword = rnd,
                Roles = roles,
                UserId = Guid.NewGuid()
            };
            int employeeId = await _backOfficeApi.AddEmployee(employeeDto);
            await _backOfficeApi.ChangeEmployeePassword(new EmployeePasswordDto()
            {
                EmployeeId = employeeId,
                Password = "pass" + rnd
            });
            var employee = new Employee()
            {
                EmployeeId = employeeDto.UserId,
                Login = employeeDto.Login,
                Password = "pass" + rnd,
                StoreId = storeId,
                TenantId = tenantId
            };
            _db.Employees.Add(employee);
            return employee;
        }

    }
}