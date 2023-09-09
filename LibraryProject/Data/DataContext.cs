using System.Reflection;
using LibraryProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Data;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options) :base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<BookTransaction> BookTransactions { get; set; }
}