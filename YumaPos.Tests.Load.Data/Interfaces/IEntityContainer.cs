namespace YumaPos.Tests.Load.Client.Data.Interfaces
{
    public interface IEntityContainer
    {
        TestClientDbContext Context { get; }
    }
}