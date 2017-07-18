using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class RecurringPayment
    {
        public long RecurringPaymentId { get; set; }

        public long BuildingId { get; set; }

        public int LandlordBankAccountId { get; set; }

        public int TenantBankAccountId { get; set; }

        public decimal Amount { get; set; }

        public DateTime StartDateUtc { get; set; }

        public DateTime EndDateUtc { get; set; }

        public int ProcessDay { get; set; }

        public RecurringPaymentStatus Status { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public DateTime UpdateDateUtc { get; set; }

        public User Landlord { get; set; }

        public User Tenant { get; set; }

        public BuildingPreview Building { get; set; }

        public List<NextRecurringPayment> NextRecurringPayments { get; set; }
    }

    public enum RecurringPaymentStatus
    {
        New = 0,
        Processed = 1
    }
}
