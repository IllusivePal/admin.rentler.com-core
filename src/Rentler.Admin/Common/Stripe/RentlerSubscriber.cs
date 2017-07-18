using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{    
    public class RentlerSubscriber
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public bool HasSubscription { get; set; }
        
        public string Plan { get; set; }
        
        public int UpgradeTotal { get; set; }

        public bool IsTrialing { get; set; }

        public bool HasHadFreeTrial { get; set; }
    }
}
