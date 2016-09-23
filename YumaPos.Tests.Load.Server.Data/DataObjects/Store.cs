using System;
using System.ComponentModel.DataAnnotations;

namespace YumaPos.Tests.Load.Server.Data.DataObjects
{
    public class Store
    {
        [Key]
        public Guid StoreId { get; set; }
        public Guid TenantId { get; set; }
        public int? JobId { get; set; }

        public virtual Job Job { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}