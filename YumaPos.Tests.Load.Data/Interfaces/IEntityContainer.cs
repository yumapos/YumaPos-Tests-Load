namespace YumaPos.Tests.Load.Data.Interfaces
{
    public interface IEntityContainer
    {
        TestDbContext Context { get; }
    }
}