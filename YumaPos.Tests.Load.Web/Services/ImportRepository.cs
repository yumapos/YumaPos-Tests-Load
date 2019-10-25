using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using YumaPos.Tests.Load.Server.Data.DataObjects;

namespace YumaPos.Tests.Load.Web.Services
{
    public class ImportRepository
    {
        private readonly string _serverSqlConnectionString;

        public ImportRepository(string serverSqlConnectionString)
        {
            _serverSqlConnectionString = serverSqlConnectionString;
        }

        public async Task<IList<Employee>> GetAutomatedEmployes(Guid tenantId)
        {
            string sql = @"
SELECT  DISTINCT
      e.[Login]
      ,e.[UserId] as EmployeeId
      ,e.[CashierPassword] as Pin
      ,e.[Id]
      ,e.[TenantId]
      ,e.[Password]
	  ,e2r.StoreID
  FROM [dbo].[Employees] e
  inner join  Rbac.EmployeesInRoles e2r ON e2r.UserId = e.UserId
  inner join Rbac.Roles r ON r.Id = e2r.RoleId AND r.PredefinedType = 1
  where e.[Password] is not null and e.[Login] like 'empl%'
    AND e.TenantId = @tenantId";
            IList<Employee> employees;
            using (SqlConnection connection = new SqlConnection(_serverSqlConnectionString))
            {
                employees = (await connection.QueryAsync<Employee>(sql, new {tenantId})).ToList();
            }
            return employees;
        }

        public async Task<IList<Terminal>> GetAutomatedTerminals(Guid tenantId)
        {
            string sql = @"
SELECT [StoreId]
      ,[TenantId]
      ,[Token]
      ,[TerminalId]
  FROM [Rbac].[Terminals]
  where Name LIKE  'term[0-9][0-9]%'
    AND TenantId = @tenantId";
            IList<Terminal> terminals;
            using (SqlConnection connection = new SqlConnection(_serverSqlConnectionString))
            {
                terminals = (await connection.QueryAsync<Terminal>(sql, new {tenantId})).ToList();
            }
            return terminals;
        }

    }
}