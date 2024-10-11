using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelbuilderAPI.Models;
public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public virtual ICollection<Book> Books { get; set; } = [];
    public virtual ICollection<Author> Authors { get; set; } = [];
}
