using System;

namespace YumaPos.Tests.Load.Server.Data.DataObjects
{
    public class TestTask
    {
        public int TestId { get; set; }
        public int TerminalId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid StoreId { get; set; }
        public Guid TenantId { get; set; }
        public Guid ClientId { get; set; }

        public virtual Tenant Tenant { get; set; }
        public virtual Store Store { get; set; }
        public virtual Client Client { get; set; }

    }
}