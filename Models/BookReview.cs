namespace ModelbuilderAPI.Models;

public class BookReview
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public string Review { get; set; } = string.Empty;

    public virtual Book? Book { get; set; } 
}
