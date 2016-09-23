using System;
using System.ComponentModel.DataAnnotations;

namespace YumaPos.Tests.Load.Server.Data.DataObjects
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }
        public Guid TenantId { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? StoreId { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }
        public string Pin { get; set; }

        public virtual Tenant Tenant { get; set; }
        public virtual Client Client { get; set; }
    }
}