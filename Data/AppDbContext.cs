using Microsoft.EntityFrameworkCore;

namespace ItechArt.Data;

public class AppDbContext : DbContext
{
    public DbSet<ItechArt.Entities.FileEntities>? Files { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
}