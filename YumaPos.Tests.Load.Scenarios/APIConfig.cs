using YumaPos.Shared.Core.Reciept.Contracts;

namespace YumaPos.Tests.Load.Scenarios
{
    public class ApiConfig : IAPIConfig
    {
        public string TerminalServiceAddress { get; set; }
        public string TerminalId { get; set; }
        public string Tenant { get; set; }
        public string Token { get; set; }
        public string BackOfficeAddress { get; set; }
        public string AuthorizationAddress { get; set; }
        public string OrderServiceAddress { get; set; }
    }
}