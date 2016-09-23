using System;
using System.ComponentModel.DataAnnotations;

namespace YumaPos.Tests.Load.Server.Data.DataObjects
{
    public class TestTask
    {
        [Key]
        public int TestId { get; set; }
        public Guid TerminalId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid StoreId { get; set; }
        public Guid TenantId { get; set; }
        public Guid ClientId { get; set; }
        public int JobId { get; set; }

        public virtual Job Job { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual Store Store { get; set; }
        public virtual Client Client { get; set; }

    }
}