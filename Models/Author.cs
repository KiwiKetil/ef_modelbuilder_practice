using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelbuilderAPI.Models;
public class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public virtual ICollection<Book> Books { get; set; } = [];
    public virtual ICollection<Genre> Genres { get; set; } = [];
}
