using Rentler.Admin.Common.Listing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class CommunityDetails
    {
        public long CommunityId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int ManagementTypeCode { get; set; }

        public Address Address { get; set; }

        public string Nickname { get; set; }

        public int? TotalUnits { get; set; }

        public bool IsUpgraded { get; set; }

        public bool IsUnderReview { get; set; }

        public int? AdvertisedListingCount { get; set; }

        public int? RefreshDays { get; set; }

        public string StreetHash { get; set; }

        public string FullHash { get; set; }

        public Guid? MainPhotoId { get; set; }

        public string MainPhotoExtension { get; set; }

        public Guid? HeaderPhotoId { get; set; }

        public string HeaderPhotoExtension { get; set; }

        public string[] Amenities { get; set; }

        public string InvoiceContactName { get; set; }

        public string InvoiceContactPhone { get; set; }

        public string RequestedPackage { get; set; }

        public int? FeaturedPlacementCount { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public string InternalName { get; set; }

        public bool? UseCustomPhoneNumbers { get; set; }

        public List<FeaturedCommunity> FeaturedCommunities { get; set; }

        public bool IsDeleted { get; set; }

        public Contact Contact { get; set; }

        public string WebsiteUrl { get; set; }

        public List<BusinessDay> OperatingHours { get; set; }

        public bool? HasOperatingHours { get; set; }

        public string Description { get; set; }

        public bool IsSeniorRestricted { get; set; }

        public string CustomPhoneNumber { get; set; }

        public string CustomPhoneId { get; set; }
    }
}
