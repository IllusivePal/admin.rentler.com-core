using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class Contact
    {
        public int ContactId { get; set; }

        public ListingType ListingType { get; set; }

        public string Name { get; set; }

        public string CompanyName { get; set; }

        public string PhoneNumber { get; set; }

        public bool ShowPhoneNumber { get; set; }
    }
}
