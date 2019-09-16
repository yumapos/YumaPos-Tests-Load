using System;
using YumaPos.Shared.Terminal.Infrastructure;

namespace YumaPos.Tests.Load.Server.Services
{
    public class CheckServerConnectionService : ICheckServerConnectionService
    {
        public bool IsInOffline { get; } = false;
        public event EventHandler ConnectionEstablished;
    }
}