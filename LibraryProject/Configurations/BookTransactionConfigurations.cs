using LibraryProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryProject.Configurations;

public class BookTransactionConfigurations   : IEntityTypeConfiguration<BookTransaction>
{
    public void Configure(EntityTypeBuilder<BookTransaction> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.AcceptanceDate).IsRequired();
        builder.Property(t => t.DeliveringDate).IsRequired();
        builder.Property(t => t.BookId).IsRequired();
        builder.Property(t => t.Country).IsRequired();
        builder.HasData(Data());
    }
    IEnumerable<BookTransaction> Data()
    {
        return new List<BookTransaction>
        {
            new BookTransaction
            {
                Id =1,
                AcceptanceDate = DateTime.Now.AddDays(-10),
                DeliveringDate = DateTime.Now,
                BookId = 1,
                Country = "Turkey"
            },
            new BookTransaction
            {
                Id =2,
                AcceptanceDate = DateTime.Now.AddDays(-15),
                DeliveringDate = DateTime.Now,
                BookId = 2,
                Country = "Turkey"
            },
            new BookTransaction
            {
                Id =3,
                AcceptanceDate = DateTime.Now.AddDays(-15),
                DeliveringDate = DateTime.Now.AddDays(-5),
                BookId = 2,
                Country = "Turkey"
            }
        };
    }
}