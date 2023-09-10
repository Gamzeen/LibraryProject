using LibraryProject.Entities;

namespace LibraryProject.Services.Interface;

public interface IBookService
{
    Task<List<Book>> GetBooksAsync();
    Task<Book> GetBookByIdAsync(long id);
}