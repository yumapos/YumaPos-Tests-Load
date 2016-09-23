using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YumaPos.Tests.Load.Server.Data.DataObjects
{
    public class Terminal
    {
        [Key]
        public Guid TerminalId { get; set; }
        public Guid StoreId { get; set; }
        public Guid TenantId { get; set; }
        public Guid? ClientId { get; set; }

        public Guid Token { get; set; }

        public virtual Store Store { get; set; }
        public virtual Client Client { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}