using System;
using System.Collections.Generic;

namespace WebShop.Core.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderEmail { get; set; } = null!;
        public string OrderAddress { get; set; } = null!;
        public string ShippingAddress { get; set; } = null!;
        public decimal Ammount { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
