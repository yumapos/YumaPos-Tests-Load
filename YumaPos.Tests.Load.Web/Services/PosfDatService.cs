using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YumaPos.Shared.API;
using YumaPos.Shared.API.Models.Ordering;
using YumaPos.Shared.BackOffice.Infrastructure;
using YumaPos.Shared.BackOffice.Infrastructure.API.Models;
using YumaPos.Shared.Terminal.Infrastructure;
using YumaPos.Tests.Load.Server.Data;
using YumaPos.Tests.Load.Server.Data.DataObjects;
using YumaPos.Tests.Load.Server.Data.Interfaces;
using YumaPos.Tests.Load.Web.Interfaces;

namespace YumaPos.Tests.Load.Web.Services
{
    public class PosDataService : IPosDataService
    {
        private readonly IBackOfficeApi _backOfficeApi;
        private readonly IAuthorizationApi _authorizationApi;
        private readonly ITerminalApi _terminalApi;
        private readonly string _login;
        private readonly string _password;

        private LoadTestDbContext _db;

        public PosDataService(IEntityContainer container, IBackOfficeApi backOfficeApi, IAuthorizationApi authorizationApi, ITerminalApi terminalApi, string login, string password)
        {
            _backOfficeApi = backOfficeApi;
            _authorizationApi = authorizationApi;
            _terminalApi = terminalApi;
            _login = login;
            _password = password;
            _db = container.Context;
        }

        public async Task<Terminal> CreateNewTerminal(Guid tenantId, Guid storeId)
        {
            var userToken = await _authorizationApi.Login(_login, _password);
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

        public async Task<Employee> CreateNewEmployee(Guid tenantId, Guid storeId)
        {
            var userToken = await _authorizationApi.Login(_login, _password);
            _backOfficeApi.SetUserToken(userToken);
            var roles = await _backOfficeApi.GetAllRoles();
            foreach (var role in roles)
            {
                role.Stores = new List<StoreDto>() {new StoreDto() {StoreId = storeId}};
            }
            var rnd = (new Random()).Next(Int32.MaxValue);
            var employeeDto = new EmployeeDto()
            {
                FirstName = "Test",
                LastName = rnd.ToString(),
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
                Pin = rnd.ToString(),
                StoreId = storeId,
                TenantId = tenantId
            };
            _db.Employees.Add(employee);
            return employee;
        }

    }
}