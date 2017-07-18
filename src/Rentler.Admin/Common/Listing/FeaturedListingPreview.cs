using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common.Listing
{
	public class FeaturedListingPreview
	{
		public long BuildingId { get; set; }
		public DateTime ScheduledDate { get; set; }
		public string Zip { get; set; }
	}
}
