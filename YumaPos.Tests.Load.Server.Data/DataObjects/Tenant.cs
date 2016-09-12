using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YumaPos.Tests.Load.Server.Data.DataObjects
{
    public class Tenant
    {
        [Key]
        public Guid TenantId { get; set; }
        public string TenantAlias { get; set; }
        public int? JobId { get; set; }
        public int ServerId { get; set; }

        public virtual Job Job { get; set; }
        public virtual Server Server { get; set; }
    }
}