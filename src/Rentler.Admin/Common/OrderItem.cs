using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public string ProductId { get; set; }
        public string ProductOption { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
    }
}
