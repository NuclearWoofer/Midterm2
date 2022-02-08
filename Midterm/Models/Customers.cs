using System;
using System.Collections.Generic;

namespace Midterm.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int CustomerId { get; set; }
        public string CustomerFirst { get; set; }
        public string CustomerLast { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
