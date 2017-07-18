using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class NextRecurringPayment
    {
        public long NextRecurringPaymentId { get; set; }
        public long RecurringPaymentId { get; set; }
        public long BuildingId { get; set; }
        public int LandlordBankAccountId { get; set; }
        public int TenantBankAccountId { get; set; }
        public long? LandlordAchTransactionId { get; set; }
        public long? TenantAchTransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }
        public NextRecurringPaymentStatus Status { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public DateTime UpdateDateUtc { get; set; }

        public BuildingPreview Building { get; set; }
        public User Landlord { get; set; }
        public User Tenant { get; set; }

        public BankAccount LandlordBankAccount { get; set; }

        public BankAccount TenantBankAccount { get; set; }

        public AchTransaction LandlordAchTransaction { get; set; }

        public AchTransaction TenantAchTransaction { get; set; }
    }

    public enum NextRecurringPaymentStatus
    {
        New = 0,
        TenantStarted = 1,
        LandlordStarted = 2,
        TenantFailed = 3,
        LandlordFailed = 4,
        Processed = 5
    }
}
