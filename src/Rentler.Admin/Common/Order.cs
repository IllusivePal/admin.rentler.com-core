using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{    
    public class Order
    { 
        public long? BuildingId { get; set; }     
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public decimal OrderSubTotal { get; set; }
        public decimal OrderTotal { get; set; }
        public decimal? PromoDiscountTotal { get; set; }
        public DateTime CreateDate { get; set; }
        public User User { get; set; }
        public BuildingPreview Building { get; set; }
        public IList<OrderItem> OrderItems { get; set; }
    }
}
