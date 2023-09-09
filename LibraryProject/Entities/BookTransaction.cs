namespace LibraryProject.Entities;

public class BookTransaction
{
    public long Id { get; set; }
    public DateTime AcceptanceDate { get; set; }
    public DateTime DeliveringDate { get; set; }
    public long BookId { get; set; }
    public string Country { get; set; }
}