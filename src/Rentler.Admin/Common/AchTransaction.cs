using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class AchTransaction
    {
        public long AchTransactionId { get; set; }

        public string ProviderId { get; set; }

        public bool IsCredit { get; set; }

        public decimal Amount { get; set; }

        public int StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public DateTime UpdateDateUtc { get; set; }
    }
}
