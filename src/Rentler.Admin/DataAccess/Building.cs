//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentler.Admin.DataAccess
{
    using System;
    using System.Collections.Generic;
    using Rentler.Admin.Common;
    using System.Linq;
    
    public partial class Building
    {
        public Building()
        {
            this.Applications = new HashSet<Application>();
            this.BuildingAmenities = new HashSet<BuildingAmenity>();
            this.BuildingUtilities = new HashSet<BuildingUtility>();
            this.CustomAmenities = new HashSet<CustomAmenity>();
            this.FeaturedListings = new HashSet<FeaturedListing>();
            this.Orders = new HashSet<Order>();
            this.PaymentInvites = new HashSet<PaymentInvite>();
            this.Photos = new HashSet<Photo>();
            this.RecurringPayments = new HashSet<RecurringPayment>();
            this.SavedBuildings = new HashSet<SavedBuilding>();
            this.TenantApplications = new HashSet<TenantApplication>();
            this.NextRecurringPayments = new HashSet<NextRecurringPayment>();
            this.Notifications = new HashSet<Notification>();
            this.RefreshSchedules = new HashSet<RefreshSchedule>();
            this.RentalApplications = new HashSet<RentalApplication>();
            this.ListingReports = new HashSet<ListingReport>();
            this.Threads = new HashSet<Thread>();
        }
    
        public long BuildingId { get; set; }
        public int UserId { get; set; }
        public Nullable<System.DateTime> CreateDateUtc { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDateUtc { get; set; }
        public string UpdatedBy { get; set; }
        public string RibbonId { get; set; }
        public Nullable<System.DateTime> DateRibbonActivated { get; set; }
        public Nullable<int> ContactInfoId { get; set; }
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
        public Nullable<int> SquareFeet { get; set; }
        public Nullable<float> Acres { get; set; }
        public Nullable<int> YearBuilt { get; set; }
        public Nullable<int> Bedrooms { get; set; }
        public Nullable<float> Bathrooms { get; set; }
        public decimal Price { get; set; }
        public Nullable<System.DateTime> DateAvailableUtc { get; set; }
        public Nullable<System.DateTime> DateActivatedUtc { get; set; }
        public bool IsActive { get; set; }
        public Nullable<decimal> Deposit { get; set; }
        public Nullable<decimal> RefundableDeposit { get; set; }
        public int LeaseLengthCode { get; set; }
        public bool IsSmokingAllowed { get; set; }
        public bool IsRemovedByAdmin { get; set; }
        public bool IsReported { get; set; }
        public string ReportedText { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<decimal> PetFee { get; set; }
        public Nullable<int> TemporaryOrderId { get; set; }
        public Nullable<System.Guid> PrimaryPhotoId { get; set; }
        public string PrimaryPhotoExtension { get; set; }
        public bool IsUpgraded { get; set; }
        public Nullable<int> TransUnionPropertyId { get; set; }
        public bool IsApplicationsEnabled { get; set; }
        public string StreetHash { get; set; }
        public string FullHash { get; set; }
        public Nullable<bool> IsScreeningRequired { get; set; }
        public string Nickname { get; set; }
        public Nullable<int> ManagementTypeCode { get; set; }
        public string DefaultCity { get; set; }
        public int DogPolicyCode { get; set; }
        public int CatPolicyCode { get; set; }
        public string PetDetails { get; set; }
        public Nullable<decimal> PetDeposit { get; set; }
        public string SmokingDetails { get; set; }
        public bool IsLeaseToOwn { get; set; }
        public bool IsSeniorRestricted { get; set; }
        public Nullable<decimal> ApplicationFee { get; set; }
        public string MoveInSpecial { get; set; }
        public string CustomPhoneId { get; set; }
        public string CustomPhoneNumber { get; set; }
        public bool RecordCalls { get; set; }
        public Nullable<long> CommunityId { get; set; }
        public Nullable<System.Guid> FloorPlanImageId { get; set; }
        public Nullable<bool> AutoRentability { get; set; }
        public string FloorPlanImageExtension { get; set; }
        public string Directions { get; set; }
        public bool IsOnApprovedCredit { get; set; }
        public bool IsMonthToMonth { get; set; }
        public int MinLeaseLength { get; set; }
        public int MaxLeaseLength { get; set; }
        public Nullable<int> IsAcceptTextMessages { get; set; }
        public int OrderScore { get; set; }
        public Nullable<long> PropertyId { get; set; }
        public bool IsDIYApartment { get; set; }
        public string YouTubeUrl { get; set; }

        public BuildingPreview ToBuildingPreview()
        {
            BuildingPreview preview = new BuildingPreview
            {
                UserId = this.UserId,
                BuildingId = this.BuildingId,
                PrimaryPhotoId = this.PrimaryPhotoId,
                PrimaryPhotoExtension = this.PrimaryPhotoExtension,
                Address1 = this.Address1,
                Address2 = this.Address2,
                City = this.City,
                DefaultCity = this.DefaultCity,
                State = this.State,
                Zip = this.Zip,
                Bedrooms = this.Bedrooms,
                Bathrooms = this.Bathrooms,
                IsActive = this.IsActive,
                IsRemovedByAdmin = this.IsRemovedByAdmin,
                IsDeleted = this.IsDeleted,
                Title = this.Title,
                Latitude = this.Latitude,
                Longitude = this.Longitude,
                StreetHash = this.StreetHash,
                FullHash = this.FullHash,
                PropertyTypeCode = this.PropertyTypeCode,
                CreateDateUtc = this.CreateDateUtc,
                UpdateDateUtc = this.UpdateDateUtc,
                CommunityId = this.CommunityId,
                IsUpgraded = this.IsUpgraded,
                CustomPhoneId = this.CustomPhoneId,
                CustomPhoneNumber = this.CustomPhoneNumber,
                OrderScore = this.OrderScore,
                IsDIYApartment = this.IsDIYApartment
            };

            if (this.User != null)
                preview.User = this.User.ToUserPreview();

            if (!string.IsNullOrWhiteSpace(RibbonId) &&
                DateRibbonActivated.HasValue &&
                DateRibbonActivated.Value > DateTime.UtcNow.AddDays(-30))
                preview.HasRibbon = true;
            return preview;
        }
        public BuildingDetail ToBuildingDetail()
        {
            BuildingDetail detail = new BuildingDetail
            {
                Preview = this.ToBuildingPreview(),
                Orders = this.Orders.Where(o => o.OrderStatusCode == 2).Select(o => o.ToOrder()).ToList(),
                PropertyTypeCode = this.PropertyTypeCode,
                ListingReports = this.ListingReports.Select(l => l.ToListingReportPreview()).ToList()
            };

            detail.Preview.IsFeatured =
                this.FeaturedListings
                    .Any(d => d.ScheduledDate.ToString("dd/MM/yyyy") == DateTime.UtcNow.ToString("dd/MM/yyyy"));

            return detail;
        }
        public Common.Listing.Address ToAddress()
        {
            return new Common.Listing.Address()
            {
                Address1 = Address1,
                Address2 = Address2,
                City = City,
                DefaultCity = DefaultCity,
                Latitude = Latitude,
                Longitude = Longitude,
                State = State,
                Zip = Zip
            };
        }
        public Common.Listing.BasicProperty ToBasicProperty()
        {
            return new Common.Listing.BasicProperty()
            {
                PropertyId = this.BuildingId,
                UserId = this.UserId,
                PropertyTypeCode = this.PropertyTypeCode,
                Address = ToAddress(),
                IsDeleted = this.IsDeleted,
                IsRemovedByAdmin = this.IsRemovedByAdmin,
                Latitude = this.Latitude,
                Longitude = this.Longitude,
                StreetHash = this.StreetHash,
                FullHash = this.FullHash,
                IsListed = this.Acres.HasValue,
                IsUpgraded = this.IsUpgraded,
                IsApplicationsEnabled = this.IsApplicationsEnabled,
                Nickname = this.Nickname,
                ManagementTypeCode = this.ManagementTypeCode,
                OrderScore = this.OrderScore
            };
        }
        public Common.Listing.ListingDetail ToListingDetail()
        {
            var listing = new Common.Listing.ListingDetail()
            {
                ListingId = this.BuildingId,
                UserId = this.UserId,
                Property = ToBasicProperty(),
                CommunityId = this.CommunityId,

                Acres = this.Acres,
                SquareFeet = this.SquareFeet,
                YearBuilt = this.YearBuilt,
                Bedrooms = this.Bedrooms,
                Bathrooms = this.Bathrooms,

                Price = this.Price,
                Deposit = this.Deposit,
                Refundable = this.RefundableDeposit,
                DateAvailableUtc = this.DateAvailableUtc,
                DateCreatedUtc = this.CreateDateUtc.Value,
                IsSmokingAllowed = this.IsSmokingAllowed,
                LeaseLength = (Rentler.Admin.Common.LeaseLength)this.LeaseLengthCode,
                PetFee = this.PetFee,
                ApplicationFee = this.ApplicationFee,
                CatPolicy = (Rentler.Admin.Common.CatPolicy)this.CatPolicyCode,
                DogPolicy = (Rentler.Admin.Common.DogPolicy)this.DogPolicyCode,
                PetDeposit = this.PetDeposit,
                PetDetails = this.PetDetails,
                SmokingDetails = this.SmokingDetails,
                IsSeniorRestricted = this.IsSeniorRestricted,
                IsScreeningRequired = this.IsScreeningRequired,
                MoveInSpecial = this.MoveInSpecial,
                IsReported = this.IsReported,
                CustomPhoneNumber = this.CustomPhoneNumber,
                FloorPlanImageId = this.FloorPlanImageId,

                Title = this.Title,
                Description = this.Description,
                RibbonId = this.RibbonId,
                IsFeatured = this.FeaturedListings.Any(f => f.ScheduledDate > DateTime.Now.Date),
                PrimaryPhotoId = this.PrimaryPhotoId,
                PrimaryPhotoExtension = this.PrimaryPhotoExtension,
                IsUpgraded = this.IsUpgraded,
                IsApplicationsEnabled = this.IsApplicationsEnabled,
                AutoRentability = this.AutoRentability
            };

            listing.BuildingAmenities = this.BuildingAmenities.Select(a => a.AmenityId).ToList();
            listing.CustomAmenities = this.CustomAmenities.Select(ca => ca.Name).ToList();

            if (this.ContactInfo != null)
                listing.Contact = this.ContactInfo.ToContact();

            /* photos */
            foreach (var photo in this.Photos.OrderBy(p => p.SortOrder))
                listing.Photos.Add(photo.ToPhoto());

            //featured listings
            foreach (var f in this.FeaturedListings)
            {
                listing.Featured.Add(
                    new Common.Listing.FeaturedListingPreview
                    {
                        BuildingId = f.BuildingId,
                        ScheduledDate = f.ScheduledDate,
                        Zip = f.Zip
                    });
            }

            if (this.BuildingUtilities != null)
                listing.Utilities = this.BuildingUtilities.Select(u => u.ToUtility()).ToList();

            if (this.Community != null)
                listing.Community = this.Community.ToCommunityDetails();

            if (this.Community != null && this.Community.CommunityAmenities != null)
                listing.BuildingAmenities = listing.BuildingAmenities
                    .Union(this.Community.CommunityAmenities.Select(a => a.AmenityId))
                    .ToList();

            listing.DateActivatedUtc = this.DateActivatedUtc;
            listing.ReportedText = this.ReportedText;
            listing.IsReported = this.IsReported;

            listing.IsActive = this.IsActive;

            listing.OrderScore = this.OrderScore;

            return listing;
        }

        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<BuildingAmenity> BuildingAmenities { get; set; }
        public virtual Community Community { get; set; }
        public virtual Property Property { get; set; }
        public virtual ICollection<BuildingUtility> BuildingUtilities { get; set; }
        public virtual ContactInfo ContactInfo { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<CustomAmenity> CustomAmenities { get; set; }
        public virtual ICollection<FeaturedListing> FeaturedListings { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PaymentInvite> PaymentInvites { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<RecurringPayment> RecurringPayments { get; set; }
        public virtual ICollection<SavedBuilding> SavedBuildings { get; set; }
        public virtual ICollection<TenantApplication> TenantApplications { get; set; }
        public virtual ICollection<NextRecurringPayment> NextRecurringPayments { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<RefreshSchedule> RefreshSchedules { get; set; }
        public virtual ICollection<RentalApplication> RentalApplications { get; set; }
        public virtual ICollection<ListingReport> ListingReports { get; set; }
        public virtual ICollection<Thread> Threads { get; set; }
        public virtual User User { get; set; }
    }
}
