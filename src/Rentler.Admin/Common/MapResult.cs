using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
	public class MapResult<T>
	{
		public List<T> Results { get; set; }
		public LocationBounds Bounds { get; set; }
	}
}
