using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
	[Flags]
	public enum DogPolicy
	{
		[Description("N/A")]
		None = 0,

		[Description("Small Dogs Allowed")]
		DogsSmallAllowed = 1,

		[Description("Large Dogs Allowed")]
		DogsLargeAllowed = 2,

		[Description("Breed Restrictions")]
		DogsBreedRestrictions = 4,

		[Description("Ask Landlord")]
		DogsContactLandlord = 8
	}
}
