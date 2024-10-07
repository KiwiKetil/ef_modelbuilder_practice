namespace ModelbuilderAPI.Models;

public class BookCover
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public string HttpAddress { get; set; } = string.Empty;

    public virtual Book? Book { get; set; }
}
