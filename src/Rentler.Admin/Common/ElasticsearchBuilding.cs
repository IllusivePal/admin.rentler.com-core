using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    [ElasticsearchType(Name = "listingdetail")]
    public class ElasticsearchListing
    {
        public long BuildingId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreateDateUtc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDateUtc { get; set; }
        public string UpdatedBy { get; set; }
        public string RibbonId { get; set; }
        public DateTime? DateRibbonActivated { get; set; }
        public int? ContactInfoId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int PropertyTypeCode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? SquareFeet { get; set; }
        public float? Acres { get; set; }
        public int? YearBuilt { get; set; }
        public int? Bedrooms { get; set; }
        public double? Bathrooms { get; set; }
        public decimal Price { get; set; }
        public DateTime? DateAvailableUtc { get; set; }
        public DateTime? DateActivatedUtc { get; set; }
        public bool IsActive { get; set; }
        public decimal? Deposit { get; set; }
        public decimal? RefundableDeposit { get; set; }
        public int LeaseLengthCode { get; set; }
        public bool IsSmokingAllowed { get; set; }
        public bool IsRemovedByAdmin { get; set; }
        public bool IsReported { get; set; }
        public string ReportedText { get; set; }
        public bool IsDeleted { get; set; }
        public decimal? PetFee { get; set; }
        public int? TemporaryOrderId { get; set; }
        public Guid? PrimaryPhotoId { get; set; }
        public string PrimaryPhotoExtension { get; set; }
        public bool IsUpgraded { get; set; }
        public int? TransUnionPropertyId { get; set; }
        public bool IsApplicationsEnabled { get; set; }
        public string StreetHash { get; set; }
        public string FullHash { get; set; }
        public bool? IsScreeningRequired { get; set; }
        public string Nickname { get; set; }
        public int? ManagementTypeCode { get; set; }
        public string DefaultCity { get; set; }
        public long? CommunityId { get; set; }
        public int DogPolicyCode { get; set; }
        public int CatPolicyCode { get; set; }
        public string PetDetails { get; set; }
        public decimal? PetDeposit { get; set; }
        public string SmokingDetails { get; set; }
        public bool IsLeaseToOwn { get; set; }
        public bool IsSeniorRestricted { get; set; }
        public decimal? ApplicationFee { get; set; }
        public string MoveInSpecial { get; set; }
        public string CustomPhoneId { get; set; }
        public string CustomPhoneNumber { get; set; }
        public bool RecordCalls { get; set; }
        public Guid? FloorPlanImageId { get; set; }

        [Text]
        public Location Pin { get; set; }
    }

    public class Location
    {
        public float lat { get; set; }
        public float lon { get; set; }

    }
}
