using System;
using YumaPos.Shared.Attributes;

namespace YumaPos.Tests.Load.Infrastructure.Dto
{
    [Map]
    public class TestTaskDto
    {
        public int TaskId { get; set; }
        public bool TerminalIsRegistered { get; set; }
        public string AuthorizationAddress { get; set; }
        public string ServiceAddress { get; set; }
        public string TenantAlias { get; set; }
        public Guid TerminalId { get; set; }
        public Guid TerminalToken { get; set; }
        public string EmployeeLogin { get; set; }
        public string EmployeePassword { get; set; }
        public DateTime Start { get; set; }
        public TimeSpan Duration { get; set; }
        public TimeSpan MinInterval { get; set; }
        public TimeSpan MaxInterval { get; set; }
        public string[] Scenarios { get; set; }

    }
}