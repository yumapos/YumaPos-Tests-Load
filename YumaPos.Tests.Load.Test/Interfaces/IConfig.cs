namespace YumaPos.Tests.Load.Client.Interfaces
{
    public interface IConfig
    {
        bool ClientIsRegistered { get; set; }
        string ClientId { get; set; }
        string ClientToken { get; set; }
        int MaxInstanceCount { get; set; }
    }
}