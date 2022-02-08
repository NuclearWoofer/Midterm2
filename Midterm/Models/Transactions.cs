using System;
using System.Collections.Generic;

namespace Midterm.Models
{
    public partial class Transactions
    {
        public int TransactionId { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CheckedOutDate { get; set; }
        public DateTime DueDate { get; set; }
        public string CheckedIn { get; set; }

        public virtual Books Book { get; set; }
        public virtual Customers Customer { get; set; }
    }
}
