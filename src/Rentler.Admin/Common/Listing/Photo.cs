using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common.Listing
{
	public class Photo
	{
		public Guid PhotoId { get; set; }
		public long BuildingId { get; set; }
		public string Extension { get; set; }
		public int SortOrder { get; set; }
		public string SmallPhoto { get; set; }
		public string MediumPhoto { get; set; }
		public string LargePhoto { get; set; }
	}
}
