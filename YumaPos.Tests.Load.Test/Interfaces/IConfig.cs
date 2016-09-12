using System;

namespace YumaPos.Tests.Load.Client.Interfaces
{
    public interface IConfig
    {
        bool ClientIsRegistered { get; set; }
        Guid ClientId { get; set; }
        Guid ClientToken { get; set; }
        int MaxInstanceCount { get; set; }
    }
}