using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
	public class ListingReport : ListingReportPreview
	{
		public Common.BuildingPreview Building { get; set; }
	}

	public class ListingReportPreview
	{
		public long ListingReportId { get; set; }
		public long BuildingId { get; set; }
		public string ReportTypeName { get; set; }
		public ReportType ReportType { get; set; }
		public string Content { get; set; }
		public int Points { get; set; }
		public ActionTakenType ActionTakenType { get; set; }
	}
}
