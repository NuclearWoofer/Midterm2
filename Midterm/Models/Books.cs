using System;
using System.Collections.Generic;

namespace Midterm.Models
{
    public partial class Books
    {
        public Books()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public short YearOfRelease { get; set; }

        public virtual Authors Author { get; set; }
        public virtual Genres Genre { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
