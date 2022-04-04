using System;
using System.Collections.Generic;

namespace WebShop.Core.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string Fullname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string BillingAddress { get; set; } = null!;
        public int CountryId { get; set; }
        public string Phone { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
