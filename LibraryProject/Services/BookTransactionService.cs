using LibraryProject.Data;
using LibraryProject.Entities;
using LibraryProject.Utils;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Services;

public class BookTransactionService : IBookTransactionService
{
    private readonly DataContext _dataContext;

    public BookTransactionService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<BookTransaction> GetBookTransactionByBookTransactionIdAsync(long bookTransactionId)
    {
        return await _dataContext.BookTransactions.FirstOrDefaultAsync(x => x.Id == bookTransactionId);
    }

    public int GetPenalty(long bookTransactionId)
    {
        var book = GetBookTransactionByBookTransactionIdAsync(bookTransactionId).Result;
        var today = DateTime.Today;

        var jobDayValue = 0;
        int penaltyValue = 0;

        if (book.Country != CountryConstants.Dubai.ToString())
        {
            jobDayValue = Calculate(book.DeliveringDate, today);
        }

        if (jobDayValue >0)
        {
            penaltyValue = jobDayValue * 5;
        }

        return penaltyValue;
    }

    public void CreateBookTransaction(BookTransactionRequestModel model)
    {
        var deliveringDate = AddJobDate(DateTime.Today, 10);

        var transaction = new BookTransaction
        {
            AcceptanceDate = DateTime.Today,
            DeliveringDate = deliveringDate,
            BookId = model.BookId,
            Country = model.Country
        };
        _dataContext.BookTransactions.Add(transaction);
        _dataContext.SaveChangesAsync();
    }

    public static int Calculate(DateTime DeliveringDate, DateTime today)
    {
        int jobDays = 0;
        DateTime date = DeliveringDate;

        while (date <= today)
        {
            if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
            {
                jobDays++;
            }

            date = date.AddDays(1);
        }

        return jobDays;
    }

    public static DateTime AddJobDate(DateTime startDate, int dateValue)
    {
        DateTime today = startDate;
        int jobDayValue = 0;

        while (jobDayValue < dateValue)
        {
            today = today.AddDays(1);

            if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday)
            {
                jobDayValue++;
            }
        }

        return today;
    }
}