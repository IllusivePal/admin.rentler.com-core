using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rentler.Admin.Common.Listing
{
	public class Address
	{
		public string Address1 { get; set; }

		public string Address2 { get; set; }

		public string City { get; set; }

		public string DefaultCity { get; set; }

		public string State { get; set; }

		public string Zip { get; set; }

		public float Latitude { get; set; }

		public float Longitude { get; set; }

		public string FullAddress
		{
			get
			{
				string address = string.Empty;

				//address line
				if (!string.IsNullOrWhiteSpace(this.Address1))
				{
					address += this.Address1.Trim();
					if (!string.IsNullOrWhiteSpace(this.Address2))
						address += " " + this.Address2.Trim();
				}

				//city
				if (!string.IsNullOrWhiteSpace(this.City))
					if (address.Length > 0)
						address += ", " + this.City.Trim();
					else
						address += this.City.Trim();

				//state
				if (!string.IsNullOrWhiteSpace(this.State))
					if (address.Length > 0)
						address += ", " + this.State.Trim();
					else
						address += this.State.Trim();

				if (!string.IsNullOrWhiteSpace(this.Zip))
					if (address.Length > 0)
						address += " " + this.Zip.Trim();
					else
						address += this.Zip.Trim();

				return address;
			}
		}

		/// <summary>
		/// Generally, the safest way to get a consistent, unique string
		/// address is to put the address1, address2, city, and state together.
		/// Zip codes can change at the USPS' whims, and the Delivery Point
		/// Barcode (DPBC) can change as well. See 
		/// <seealso cref="http://smartystreets.com/kb/faq/do-addresses-have-a-unique-identifier"/>
		/// </summary>
		public string SafeUniqueFullAddress
		{
			get
			{
				string address = string.Empty;

				if (string.IsNullOrWhiteSpace(this.Address1) ||
				   string.IsNullOrWhiteSpace(this.City) ||
				   string.IsNullOrWhiteSpace(this.State))
					throw new ArgumentNullException("Must have full address.");

				//address line
				address += this.Address1.Trim();
				if (!string.IsNullOrWhiteSpace(this.Address2))
					address += " " + this.Address2.Trim();

				//city
				if (!string.IsNullOrWhiteSpace(this.DefaultCity))
				{
					if (address.Length > 0)
						address += ", " + this.DefaultCity.Trim();
					else
						address += this.DefaultCity.Trim();
				}
				else
				{
					if (address.Length > 0)
						address += ", " + this.City.Trim();
					else
						address += this.City.Trim();
				}

				//state
				if (address.Length > 0)
					address += ", " + this.State.Trim();
				else
					address += this.State.Trim();

				return address;
			}
		}

		public string SafeUniqueStreetAddress
		{
			get
			{
				string address = string.Empty;

				if (string.IsNullOrWhiteSpace(this.Address1) ||
				   string.IsNullOrWhiteSpace(this.City) ||
				   string.IsNullOrWhiteSpace(this.State))
					throw new ArgumentNullException("Must have full address.");

				//address line
				address += this.Address1.Trim();

				//city
				if (!string.IsNullOrWhiteSpace(this.DefaultCity))
				{
					if (address.Length > 0)
						address += ", " + this.DefaultCity.Trim();
					else
						address += this.DefaultCity.Trim();
				}
				else
				{
					if (address.Length > 0)
						address += ", " + this.City.Trim();
					else
						address += this.City.Trim();
				}

				//state
				if (address.Length > 0)
					address += ", " + this.State.Trim();
				else
					address += this.State.Trim();

				return address;
			}
		}

		public string FullHash
		{
			get
			{
				return Hashing.Md5(SafeUniqueFullAddress);
			}
		}

		public string StreetHash
		{
			get
			{
				return Hashing.Md5(SafeUniqueStreetAddress);
			}
		}

		public void Clean()
		{
			//trim spaces
			this.Address1 = SafeTrim(this.Address1);
			this.Address2 = SafeTrim(this.Address2);
			this.City = SafeTrim(this.City);
			this.State = SafeTrim(this.State);
			this.Zip = SafeTrim(this.Zip);

			//common stuff
			this.Address1 = SafeReplace(this.Address1, "\\.");
			this.City = SafeReplace(this.City, "\\.");
			this.City = SafeReplace(this.City, "slc", "Salt Lake City");
		}

		string SafeReplace(string item, string match, string replace = "")
		{
			if (!string.IsNullOrWhiteSpace(item))
				item = Regex.Replace(item, match, replace, RegexOptions.IgnoreCase);

			return item;
		}

		string SafeTrim(string item)
		{
			if (!string.IsNullOrWhiteSpace(item))
				item = item.Trim();

			return item;
		}

		public bool SkipAvs { get; set; }
	}
}
