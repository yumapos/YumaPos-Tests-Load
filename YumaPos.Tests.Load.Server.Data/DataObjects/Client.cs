using System;
using System.ComponentModel.DataAnnotations;

namespace YumaPos.Tests.Load.Server.Data.DataObjects
{
    public class Client
    {
        [Key]
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public Guid Token { get; set; }
        public string UserHostAddress { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset LastActivity { get; set; }
        public int TasksCount { get; set; }
    }
}