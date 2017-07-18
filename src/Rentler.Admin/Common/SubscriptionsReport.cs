using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class SubscriptionsReport
    {
        public Stat[] TotalSubscribers { get; set; }
        
        public Stat[] PaidSubscribers { get; set; }
        
        public Stat[] TrialSubscribers { get; set; }

        public Stat[] TotalProperties { get; set; }
    }
}
