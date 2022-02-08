using System;
using System.Collections.Generic;

namespace Midterm.Models
{
    public partial class Authors
    {
        public Authors()
        {
            Books = new HashSet<Books>();
        }

        public int AuthorId { get; set; }
        public string AuthorFirst { get; set; }
        public string AuthorLast { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
