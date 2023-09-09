using LibraryProject.Entities;

namespace LibraryProject.Services;

public interface IBookTransactionService
{
    Task<BookTransaction> GetBookTransactionByBookTransactionIdAsync(long bookTransactionId);

    int GetPenalty(long bookTransactionId);

    void CreateBookTransaction(BookTransactionRequestModel model);
}