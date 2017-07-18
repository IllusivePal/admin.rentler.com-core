using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class BuildingDetail
    {
        public BuildingPreview Preview { get; set; }
        
        public int PropertyTypeCode { get; set; }

        public IList<Order> Orders { get; set; }

        public IList<DateTime> FeaturedDates { get; set; }

		public IList<ListingReportPreview> ListingReports { get; set; }

        public Contact Contact { get; set; }
    }
}
