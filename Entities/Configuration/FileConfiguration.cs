using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task.Entities.Configuration;

public class FileConfiguration<T> : IEntityTypeConfiguration<T> where T : ItechArt.Entities.FileEntities
{
    public void Configure(EntityTypeBuilder<T> builder)
    {
        builder.Property(t => t.Id)
            .ValueGeneratedOnAdd();
        builder.Property(t => t.FileName).IsRequired();
    }
}