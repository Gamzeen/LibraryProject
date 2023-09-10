using LibraryProject.Data;
using LibraryProject.Entities;
using LibraryProject.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Services;

public class BookService : IBookService
{
    private readonly DataContext _dataContext;

    public BookService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<List<Book>> GetBooksAsync()
    {
        var books = await _dataContext.Books.AsNoTracking().ToListAsync();
        return books;
    }

    public async Task<Book> GetBookByIdAsync(long id)
    {
        var book = await _dataContext.Books.FirstOrDefaultAsync(x => x.Id == id);
        return book;
    }
}