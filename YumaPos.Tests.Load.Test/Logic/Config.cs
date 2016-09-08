using YumaPos.Tests.Load.Client.Interfaces;

namespace YumaPos.Tests.Load.Client.Logic
{
    public class Config:IConfig
    {
        public bool ClientIsRegistered { get; set; }
        public string ClientId { get; set; }
        public string ClientToken { get; set; }
        public int MaxInstanceCount { get; set; }
    }
}