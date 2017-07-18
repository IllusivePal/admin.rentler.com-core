using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common.Ocean
{
	public class Property
	{
		[BsonIgnoreIfDefault]
		public ObjectId Id { get; set; }
		public string PropertyId { get; set; }
		public string CompanyId { get; set; }
		public string ContactId { get; set; }
		public string PropertyType { get; set; }
		public bool Available { get; set; }
		public int SquareFeet { get; set; }
		public int Bedrooms { get; set; }
		public float Bathrooms { get; set; }
		public string ParkingSpaces { get; set; }
		public string CoveredParkingSpaces { get; set; }
		public string Garage { get; set; }
		public bool GarageDoorOpener { get; set; }
		public int YearBuilt { get; set; }
		public string Directions { get; set; }
		public bool VacationHome { get; set; }
		public string LongDescription { get; set; }
		public string ShortDescription { get; set; }
		public Area Area { get; set; }
		public DetailedAddress Address { get; set; }
		public Listing Listing { get; set; }
		public DateTime ModifyDate { get; set; }
		public string ModifyUser { get; set; }
		public List<Photo> Photos { get; set; }
		public string[] Amenities { get; set; }
		public string[] Cooling { get; set; }
		public string[] Flooring { get; set; }
		public string[] Heating { get; set; }
		public string[] Kitchen { get; set; }
		public string[] Rooms { get; set; }
		public List<Utility> Utilities { get; set; }
		public Dictionary<string, List<string>> Policies { get; set; }

		public Property()
		{
			Area = new Area();
			Address = new DetailedAddress();
			Listing = new Listing();
			Photos = new List<Photo>();
			Utilities = new List<Utility>();
			Policies = new Dictionary<string, List<string>>();
		}

		public Common.BuildingPreview ToBuildingPreview()
		{
			return new BuildingPreview
			{
				UserId = 0,
				BuildingId = 0,
				Address1 = this.Address.Address1,
				Address2 = this.Address.Address2,
				City = this.Address.City,
				State = this.Address.State,
				Zip = this.Address.PostalCode,
				IsActive = false,
				IsRemovedByAdmin = false,
				IsDeleted = false,
				Title = this.Listing.Headline,
				Latitude = this.Address.Latitude == null ? 0.0f : float.Parse(this.Address.Latitude),
				Longitude = this.Address.Longitude == null ? 0.0f : float.Parse(this.Address.Longitude)
			};
		}
	}
}
