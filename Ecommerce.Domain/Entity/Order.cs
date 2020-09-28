using System;
using System.Collections.Generic;

namespace Ecommerce.Domain.Entity
{
    public partial class Order
    {
        public Order()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public string Id { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
