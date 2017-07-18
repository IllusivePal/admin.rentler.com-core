using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common.Listing
{
	public class BasicProperty
	{
		public long PropertyId { get; set; }
		public int UserId { get; set; }
		public float Latitude { get; set; }
		public float Longitude { get; set; }

		public PropertyType PropertyType
		{
			get { return (PropertyType)PropertyTypeCode; }
			set { PropertyTypeCode = (int)value; }
		}
		public int PropertyTypeCode { get; set; }
		public Address Address { get; set; }
		public bool IsDeleted { get; set; }
		public bool IsListed { get; set; }
		public bool IsRemovedByAdmin { get; set; }
		public bool IsUpgraded { get; set; }
		public bool IsApplicationsEnabled { get; set; }
		public string Nickname { get; set; }
		public ManagementType? ManagementType
		{
			get
			{
				if (ManagementTypeCode.HasValue)
					return (ManagementType)ManagementTypeCode;
				else
					return null;
			}

			set
			{
				if (value.HasValue)
					ManagementTypeCode = (int)value;
				else
					ManagementTypeCode = null;
			}
		}
		[Display(Name = "Management Type")]
		public int? ManagementTypeCode { get; set; }
		public string StreetHash { get; set; }
		public string FullHash { get; set; }
		public int OrderScore { get; set; }
	}
}
