using LibraryProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryProject.Configurations;

public class BookConfigurations : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Name).HasMaxLength(50).IsRequired();
        builder.HasData(Data());
    }

    IEnumerable<Book> Data()
    {
        return new List<Book>
        {
         new Book
         {
             Id= 1,
             Name = "Sefiller",
         },
         new Book
         {
             Id= 2,
             Name = "Az",
         }
        };
    }
}