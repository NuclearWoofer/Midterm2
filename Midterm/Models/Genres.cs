using System;
using System.Collections.Generic;

namespace Midterm.Models
{
    public partial class Genres
    {
        public Genres()
        {
            Books = new HashSet<Books>();
        }

        public int GenreId { get; set; }
        public string GenreType { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
