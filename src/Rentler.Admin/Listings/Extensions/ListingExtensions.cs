using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rentler.Admin.Helpers;

namespace Rentler.Listings.Extensions
{
    public static class ListingExtensions
    {
        /*public static Rentler.Listings.Listing ToListing(this Rentler.Admin.Common.Listing.ListingDetail detail)
        {
            Rentler.Listings.Listing listing = new Rentler.Listings.Listing()
            {
                Origin = detail.ToOrigin(),
                PropertyType = detail.Property.PropertyType.ToPropertyType(),
                OrderScore = detail.OrderScore,
                Address = detail.Property.Address.ToAddress(),
                LatLng = detail.Property.ToLatLon(),
                MinBeds = detail.Bedrooms ?? 0,
                MaxBeds = detail.Bedrooms ?? 0,
                MinBaths = detail.Bathrooms ?? 0,
                MaxBaths = detail.Bathrooms ?? 0,
                MinSqFt = detail.SquareFeet ?? 0,
                MaxSqFt = detail.SquareFeet ?? 0,
                YearBuilt = detail.YearBuilt ?? 0,
                Acres = detail.Acres,
                Title = detail.Title,
                Description = detail.Description,
                AvailableDate = detail.DateAvailableUtc ?? DateTime.UtcNow,
                MinPrice = detail.Price,
                MaxPrice = detail.Price,
                Deposit = detail.Deposit,
                Refundable = detail.Refundable,
                ApplicationFee = detail.ApplicationFee,
                PetPolicy = detail.ToPetPolicy(),
                CommunityId = detail.CommunityId.HasValue ? "r" + detail.CommunityId.Value.ToString() : null,
                SmokingPolicy = detail.ToSmokingPolicy(),
                Contact = detail.Contact.ToContact(),
                FeaturedDates = detail.Featured.Select(f => f.ScheduledDate).ToList()
            };

            listing.IsScreeningRequired(detail.IsScreeningRequired);
            listing.IsSmokingAllowed(detail.IsSmokingAllowed);
            listing.IsSeniorRestricted(detail.IsSeniorRestricted);
            listing.CatTerms(detail.CatPolicy);
            listing.DogTerms(detail.DogPolicy);

            listing.UserId(detail.UserId);
            listing.MoveInSpecial(detail.MoveInSpecial);
            listing.IsApplicationsEnabled(detail.IsApplicationsEnabled);
            listing.RibbonId(detail.RibbonId);
            listing.IsReported(detail.IsReported);
            listing.AutoRentability(detail.AutoRentability);
            listing.CustomPhone(detail.CustomPhoneNumber);

            if (detail.FloorPlanImageId.HasValue)
                listing.FloorPlanPhoto = detail.ToFloorPlanPhoto();

            if (detail.Photos != null)
                listing.Photos = detail.Photos.Select(p => p.ToPhoto()).ToList();

            if (detail.BuildingAmenities != null)
                listing.Amenities = detail.BuildingAmenities.ToList();

            if (detail.CustomAmenities != null)
                listing.CustomAmenities = detail.CustomAmenities.ToList();

            if (detail.Utilities != null)
                listing.Utilities = detail.Utilities
                    .ToDictionary(k => k.Name, v => v.UtilityCode.Description());

            if (detail.Featured != null)
                listing.FeaturedDates = detail.Featured.Select(f => f.ScheduledDate).ToList();

            return listing;
        }

        public static Rentler.Listings.Origin ToOrigin(this Rentler.Admin.Common.Listing.ListingDetail detail)
        {
            return new Rentler.Listings.Origin()
            {
                Name = "Rentler",
                OriginId = "r",
                EntityId = detail.ListingId.ToString()
            };
        }

        public static Rentler.Listings.PropertyType ToPropertyType(this Rentler.Admin.PropertyType propertyType)
        {
            return (Rentler.Listings.PropertyType)((int)propertyType);
        }

        public static Rentler.Listings.Address ToAddress(this Rentler.Admin.Common.Listing.Address address)
        {
            return new Rentler.Listings.Address()
            {
                Address1 = address.Address1,
                Address2 = address.Address2,
                City = address.City,
                DefaultCity = address.DefaultCity,
                State = address.State,
                Zip = address.Zip
            };
        }

        public static Rentler.Listings.LatLon ToLatLon(this Rentler.Admin.Common.Listing.BasicProperty property)
        {
            return new Rentler.Listings.LatLon()
            {
                Lat = property.Latitude,
                Lon = property.Longitude
            };
        }

        public static Rentler.Listings.PetPolicy ToPetPolicy(this Rentler.Admin.Common.Listing.ListingDetail detail)
        {
            return new Rentler.Listings.PetPolicy()
            {
                Deposit = detail.PetDeposit,
                MonthlyFee = detail.PetFee,
                Description = detail.PetDetails
            };
        }

        public static Rentler.Listings.SmokingPolicy ToSmokingPolicy(this Rentler.Admin.Common.Listing.ListingDetail detail)
        {
            return new Rentler.Listings.SmokingPolicy()
            {
                Description = detail.SmokingDetails
            };
        }

        public static Rentler.Listings.Contact ToContact(this Rentler.Admin.Common.Contact detail)
        {
            Rentler.Listings.Contact contact = new Rentler.Listings.Contact()
            {
                Name = detail.Name,
                CompanyName = detail.CompanyName,
                Phone = detail.PhoneNumber,
                Email = "",
                PreferredMethod = ""
            };

            if (detail.ShowPhoneNumber)
                contact.PreferredMethod += "Phone";

            return contact;
        }

        public static Rentler.Listings.Community ToCommunity(this Rentler.Admin.Common.CommunityDetails detail)
        {
            Rentler.Listings.Community community = new Rentler.Listings.Community()
            {
                Origin = detail.ToOrigin(),
                Address = detail.Address.ToAddress(),
                LatLon = detail.Address.ToLatLon(),
                Contact = detail.Contact != null ? detail.Contact.ToContact() : null,
                Link = detail.WebsiteUrl,
                Amenities = detail.Amenities,
                Nickname = detail.Nickname,
                OperatingHours = detail.OperatingHours.ToOperatingHours(),
                HasOperatingHours = detail.HasOperatingHours.GetValueOrDefault(),
                Description = detail.Description,
                IsSeniorRestricted = detail.IsSeniorRestricted
            };

            if (detail.MainPhotoId.HasValue)
            {
                var container = new Rentler.Admin.Azure.CommunityContainer(detail.CommunityId);
                var name = Rentler.Admin.Azure.AzurePhoto.GetName<Guid>(
                    detail.MainPhotoId.Value, detail.MainPhotoExtension);

                community.MainPhoto = container.GetBlobUrl(name);
            }

            if (detail.HeaderPhotoId.HasValue)
            {
                var container = new Rentler.Admin.Azure.CommunityContainer(detail.CommunityId);
                var photoName = Rentler.Admin.Azure.AzurePhoto.GetName<Guid>(
                    detail.HeaderPhotoId.Value, detail.HeaderPhotoExtension);

                community.HeaderPhoto = container.GetBlobUrl(photoName);
            }

            community.UserId(detail.UserId);
            community.UseCustomPhone(detail.UseCustomPhoneNumbers);
            community.IsUpgraded(detail.IsUpgraded);
            community.CustomPhone(detail.CustomPhoneNumber);

            return community;
        }

        public static Rentler.Listings.Origin ToOrigin(this Rentler.Admin.Common.CommunityDetails community)
        {
            return new Rentler.Listings.Origin()
            {
                Name = "Rentler",
                OriginId = "r",
                EntityId = community.CommunityId.ToString()
            };
        }

        public static List<Rentler.Listings.BusinessDay> ToOperatingHours(this List<Rentler.Admin.Common.BusinessDay> hours)
        {
            return hours.ToBinaryArray().Deserialize<List<Rentler.Listings.BusinessDay>>();
        }

        public static Rentler.Listings.LatLon ToLatLon(this Rentler.Admin.Common.Listing.Address address)
        {
            return new Rentler.Listings.LatLon()
            {
                Lat = address.Latitude,
                Lon = address.Longitude
            };
        }

        public static Rentler.Listings.Photo ToFloorPlanPhoto(this Rentler.Admin.Common.Listing.ListingDetail detail)
        {
            if (detail.FloorPlanImageId.HasValue)
            {
                Rentler.Admin.Common.PhotoSize large = new Rentler.Admin.Common.PhotoSize(600, 395, Rentler.Admin.Common.ScaleBehavior.ScaleBoth);

                string blobName = Rentler.Admin.Azure.AzurePhoto.GetName<Guid>(
                    detail.FloorPlanImageId.Value, large, ".jpeg"
                );

                Rentler.Admin.Azure.BuildingContainer container = new Rentler.Admin.Azure.BuildingContainer(detail.ListingId);
                return new Rentler.Listings.Photo() { Url = container.GetBlobUrl(blobName) };
            }

            return null;
        }

        public static Rentler.Listings.Photo ToPhoto(this Rentler.Admin.Common.Listing.Photo photo)
        {
            return new Rentler.Listings.Photo()
            {
                Url = photo.LargePhoto,
                ThumbnailUrl = photo.MediumPhoto
            };
        }*/
    }
}
