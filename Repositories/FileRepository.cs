using ItechArt.Data;

namespace ItechArt.Repositories;

public class FileRepository : GenericRepository<ItechArt.Entities.FileEntities>, IFileRepository
{
    public FileRepository(AppDbContext context)
        : base(context) { }
}