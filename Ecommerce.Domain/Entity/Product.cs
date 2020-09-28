using System;
using System.Collections.Generic;

namespace Ecommerce.Domain.Entity
{
    public partial class Product
    {
        public Product()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
