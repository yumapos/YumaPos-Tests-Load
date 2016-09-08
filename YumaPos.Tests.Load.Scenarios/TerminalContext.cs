using Autofac;

namespace YumaPos.Tests.Load.Scenarios
{
    public class TerminalContext
    {
        public string AuthServer { get; set; }
        public string TerminalServer { get; set; }
        public string TenantAlias { get; set; }
        public string TerminalId { get; set; }
        public string TerminalToken { get; set; }
        public string EmployeeLogin { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeToken { get; set; }
        public bool ClientIsRegistered { get; set; }
    }
}