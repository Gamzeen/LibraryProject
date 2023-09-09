namespace LibraryProject.Entities;

public class Book
{
    public long Id { get; set; }
    public string Name { get; set; }
    public long BookTransactionId { get; set; }
}