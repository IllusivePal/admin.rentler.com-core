using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class PaymentCap
    {
        public int MerchantAccountId { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public decimal MonthlyTotal { get; set; }
        public string MerchantAccountDDResourceId { get; set; }

        public decimal? PaymentCapAmount { get; set; }

        public decimal CapPercentage
        {
            get
            {
                var capAmount = PaymentCapAmount ?? 15000;
                return Math.Round((MonthlyTotal / capAmount) * 100, 2);
            }
        }
    }
}
