using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class AccountUpgradeDetail
    {
        public int AdvertisedListingCount { get; set; }

        public AccountUpgradeStatus UpgradeStatus { get; set; }

        public string RequestPackage { get; set; }

        public string InvoiceContactName { get; set; }

        public string InvoiceContactPhone { get; set; }
    }
}
