namespace ItechArt.Entities;

public class FileEntities
{
    public ulong Id { get; set; }
    public string? FileName { get; set; }
    [Obsolete("This constructor only use for EF Core")]
    public FileEntities() {}
    public FileEntities(string filename)
    {
        FileName = filename;
    }
}