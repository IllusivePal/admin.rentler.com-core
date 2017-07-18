using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class ScheduledTransaction
    {
        public long ScheduledTransactionId { get; set; }
        
        public int PaymentSeriesId { get; set; }

        public int TenantId { get; set; }

        public long? TransactionId { get; set; }        

        public decimal Amount { get; set; }

        public DateTime TransactionDateUtc { get; set; }

        public ScheduledTransactionStatus Status { get; set; }

        public string StatusText { get; set; }

        public PaymentType PaymentType { get; set; }

        public long PaymentMethodId { get; set; }

        public long? AutopaySettingId { get; set; }        

        public DateTime CreateDateUtc { get; set; }

        public DateTime UpdateDateUtc { get; set; }        

        public string PaymentTypeDescription
        {
            get
            {
                return this.PaymentType.Description();
            }
        }
    }

    public enum ScheduledTransactionStatus
    {
        Scheduled = 0,
        Processing = 1,
        Processed = 2,
        Cancelled = 3,
        Failed = 4
    }
}
