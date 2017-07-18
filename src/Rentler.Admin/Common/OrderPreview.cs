using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class OrderPreview
    {
        public int OrderId { get; set; }

        public decimal OrderSubTotal { get; set; }

        public decimal? PromoDiscountTotal { get; set; }

        public decimal OrderTotal { get; set; }

        public DateTime CreateDate { get; set; }

        public UserPreview User { get; set; }

        public BuildingPreview Building { get; set; }
    }
}
