namespace YumaPos.Tests.Load.Server.Data.Interfaces
{
    public interface IEntityContainer
    {
        LoadTestDbContext Context { get; }
    }
}