using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelbuilderAPI.Models;
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime ReleaseYear { get; set; }

    public virtual ICollection<Author> Authors { get; set; } = [];
    public virtual ICollection<Genre> Genres { get; set; } = [];
    public virtual ICollection<BookReview> BookReviews { get; set; } = [];
    public virtual BookCover? BookCover { get; set; }
}
