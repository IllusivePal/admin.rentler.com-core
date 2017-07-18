using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class PaymentSeries
    {
        public int PaymentSeriesId { get; set; }

        public int MonthlyDueDay { get; set; }

        public decimal MonthlyAmount { get; set; }

        public DateTime FirstPaymentDateUtc { get; set; }

        public DateTime? FinalPaymentDateUtc { get; set; }

        public int MerchantAccountId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int LeaseId { get; set; }

        public PaymentSeriesStatus Status { get; set; }

        public List<Transaction> Transactions { get; set; }

        public Lease Lease { get; set; }
    }

    public enum PaymentSeriesStatus
    {
        Scheduled = 0,
        Archived = 1
    }
}
