namespace ItechArt.Repositories;

public interface IUnitOfWork : IDisposable
{
    IFileRepository Files { get; }
    int Save();
}