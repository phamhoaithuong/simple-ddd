using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
