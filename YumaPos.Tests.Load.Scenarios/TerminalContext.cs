using System;
using Autofac;

namespace YumaPos.Tests.Load.Scenarios
{
    public class TerminalContext
    {
        public string AuthServer { get; set; }
        public string TerminalServer { get; set; }
        public string TenantAlias { get; set; }
        public Guid TerminalId { get; set; }
        public Guid TerminalToken { get; set; }
        public string EmployeeLogin { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeToken { get; set; }
        public bool ClientIsRegistered { get; set; }
    }
}