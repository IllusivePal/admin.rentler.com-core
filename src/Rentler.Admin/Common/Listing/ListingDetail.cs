using Rentler.Admin.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common.Listing
{
	public class ListingDetail
	{
		public ListingDetail()
		{
			BuildingAmenities = new List<string>();
			CustomAmenities = new List<string>();
			Photos = new List<Photo>();
			Featured = new List<FeaturedListingPreview>();
		}

		public long ListingId { get; set; }
		public long? CommunityId { get; set; }
		public int UserId { get; set; }
		public BasicProperty Property { get; set; }
		public float? Acres { get; set; }
		public int? SquareFeet { get; set; }
		public int? YearBuilt { get; set; }
		public int? Bedrooms { get; set; }
		public float? Bathrooms { get; set; }
		public IList<string> BuildingAmenities { get; set; }
		public IList<string> CustomAmenities { get; set; }
		public Contact Contact { get; set; }
		public decimal Price { get; set; }
		public decimal? Deposit { get; set; }
		public decimal? Refundable { get; set; }
		public DateTime? DateAvailableUtc { get; set; }
		public DateTime DateCreatedUtc { get; set; }
		public bool IsSmokingAllowed { get; set; }
		public bool ArePetsAllowed { get; set; }
		public decimal? PetFee { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string RibbonId { get; set; }
		public Guid? PrimaryPhotoId { get; set; }
		public string PrimaryPhotoExtension { get; set; }
		public bool HasPriority { get; set; }
		public DateTime? DatePrioritized { get; set; }
		public Order TemporaryOrder { get; set; }
		public bool IsFeatured { get; set; }
		public LeaseLength LeaseLength { get; set; }
		public decimal? PetDeposit { get; set; }
		public DogPolicy DogPolicy { get; set; }
		public CatPolicy CatPolicy { get; set; }
		public string PetDetails { get; set; }
		public string SmokingDetails { get; set; }
		public bool IsLeaseToOwn { get; set; }
		public bool IsSeniorRestricted { get; set; }
		public decimal? ApplicationFee { get; set; }
		public bool? IsScreeningRequired { get; set; }
		public string MoveInSpecial { get; set; }
		public string CustomPhoneNumber { get; set; }
		public Guid? FloorPlanImageId { get; set; }

		public DateTime? DateActivatedUtc { get; set; }

		public DateTime? ExpirationDate
		{
			get
			{
				if (this.DateActivatedUtc.HasValue)
					return this.DateActivatedUtc.Value.AddMonths(1);

				return null;
			}
		}

		public string Slug
		{
			get
			{
				string url = string.Format("{0}/{1}/{2}",
					StringHelpers.URLFriendly(Property.Address.State),
					StringHelpers.URLFriendly(Property.Address.City),
					StringHelpers.URLFriendly(Property.Address.Address1));

				return url;
			}
		}

		public string UrlId
		{
			get
			{
				return string.Format("/listing/{0}/", this.ListingId) + Slug;
			}
		}

		public IList<Photo> Photos { get; set; }

		public string ReportedText { get; set; }

		public bool IsReported { get; set; }

		public bool IsActive { get; set; }

		public bool IsUpgraded { get; set; }

		public long PageViews { get; set; }

		public long SearchViews { get; set; }

		public IList<FeaturedListingPreview> Featured { get; set; }

		public bool IsApplicationsEnabled { get; set; }

        public bool? AutoRentability { get; set; }

        public IList<Utility> Utilities { get; set; }

        public CommunityDetails Community { get; set; }

		public int OrderScore { get; set; }
	}
}
