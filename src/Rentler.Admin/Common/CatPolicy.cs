using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
	[Flags]
	public enum CatPolicy
	{
		[Description("N/A")]
		None = 0,

		[Description("Cats Allowed")]
		CatsAllowed = 1,

		[Description("Ask Landlord")]
		CatsContactLandlord = 2
	}
}
