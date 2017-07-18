using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class PromoCode
    {
        public string Code { get; set; }

        public int UserId { get; set; }

        public string Description { get; set; }

        public float Discount { get; set; }

        public string ProductName { get; set; }

        public decimal? MinimumOrderPrice { get; set; }

        public int? UsesAvailable { get; set; }

        public DateTime StartDateUtc { get; set; }

        public DateTime EndDateUtc { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public bool IsDeleted { get; set; }

        public string Username { get; set; }

        public decimal? MoneyLeft { get; set; }
    }
}
