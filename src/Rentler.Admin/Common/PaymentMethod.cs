using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class PaymentMethod
    {
        public long PaymentMethodId { get; set; }

        public string ResourceId { get; set; }

        public string Name { get; set; }

        public PaymentType PaymentMethodType { get; set; }

        public string PaymentMethodLast4 { get; set; }

        public DateTime CreateDateUtc { get; set; }
    }
}
