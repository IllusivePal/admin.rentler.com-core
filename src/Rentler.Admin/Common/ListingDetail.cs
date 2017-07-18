using Rentler.Admin.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class ListingDetail
    {
        /*public Listings.Listing Listing { get; set; }

        public string ExpirationDate
        {
            get
            {
                if (this.Listing == null)
                    return string.Empty;

                return this.Listing.CreateDate.AddMonths(1).ToShortDateString();
            }
        }

        public string TimeOnline
        {
            get
            {
                if (this.Listing == null)
                    return string.Empty;

                return (DateTime.UtcNow - this.Listing.CreateDate).Friendly();
            }
        }

        public string TimeLeft
        {
            get
            {
                if (this.Listing == null)
                    return string.Empty;

                return (this.Listing.CreateDate.AddMonths(1) - DateTime.UtcNow).Friendly();
            }
        }*/
    }
}
