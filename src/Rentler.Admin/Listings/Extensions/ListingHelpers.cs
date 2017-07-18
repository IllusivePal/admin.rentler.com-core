using Rentler.Admin.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Listings.Extensions
{
    public static class ListingHelpers
    {
        /*private static T Metadata<T>(Listings.Listing listing, string key, T value)
        {
            // Update the listing metadata if there is a value
            if (value != null)
                listing.MetaData[key] = value.ToString();

            // Return default value of type if key not in metadata
            if (!listing.MetaData.ContainsKey(key))
                return default(T);

            // Return the metadata value
            var converter = TypeDescriptor.GetConverter(typeof(T));
            return (T)converter.ConvertFromString(listing.MetaData[key]);
        }

        public static int? UserId(this Listings.Listing listing, int? value = null)
        {
            return Metadata(listing, "userid", value);
        }

        public static string MoveInSpecial(this Listings.Listing listing, string value = null)
        {
            return Metadata(listing, "moveinspecial", value);
        }

        public static bool IsApplicationsEnabled(this Listings.Listing listing, bool? value = null)
        {
            return Metadata(listing, "applicationsenabled", value).GetValueOrDefault();
        }

        public static string RibbonId(this Listings.Listing listing, string value = null)
        {
            return Metadata(listing, "ribbonid", value);
        }

        public static bool IsReported(this Listings.Listing listing, bool? value = null)
        {
            return Metadata(listing, "reported", value).GetValueOrDefault();
        }

        public static bool AutoRentability(this Listings.Listing listing, bool? value = null)
        {
            return Metadata(listing, "autorentability", value).GetValueOrDefault();
        }

        public static string CustomPhone(this Listings.Listing listing, string value = null)
        {
            return Metadata(listing, "customphone", value);
        }

        private static bool Terms(Listings.Listing listing, string key, bool? value)
        {
            // Add the term if there is a value and true
            if (value.HasValue && value.Value)
                listing.Terms.Add(key);
            // Remove the term if there is a value and false
            else if (value.HasValue && !value.Value)
                listing.Terms.Remove(key);

            // Return whether the term exists
            return listing.Terms.Contains(key);
        }

        public static bool IsScreeningRequired(this Listings.Listing listing, bool? value = null)
        {
            return Terms(listing, "screeningrequired", value);
        }

        public static bool IsSmokingAllowed(this Listings.Listing listing, bool? value = null)
        {
            return Terms(listing, "smokingallowed", value);
        }

        public static bool IsSeniorRestricted(this Listings.Listing listing, bool? value = null)
        {
            return Terms(listing, "seniorrestricted", value);
        }

        public static List<string> CatTerms(this Listings.Listing listing, Admin.Common.CatPolicy? value = null)
        {
            List<string> terms = new List<string>();

            foreach (Admin.Common.CatPolicy item in Enum.GetValues(typeof(Admin.Common.CatPolicy)))
            {
                if (item == Admin.Common.CatPolicy.None) continue;

                string term = item.ToString().ToLower();

                if (value.HasValue && value.Value.HasFlag(item))
                {
                    listing.Terms.Add(term);
                }
                else if (value.HasValue)
                {
                    listing.Terms.Remove(term);
                }

                if (listing.Terms.Contains(term))
                {
                    terms.Add(item.Description());
                }
            }

            if (terms.Count == 0)
                terms.Add("No Cats Allowed");

            return terms;
        }

        public static List<string> DogTerms(this Listings.Listing listing, Admin.Common.DogPolicy? value = null)
        {
            List<string> terms = new List<string>();

            foreach (Admin.Common.DogPolicy item in Enum.GetValues(typeof(Admin.Common.DogPolicy)))
            {
                if (item == Admin.Common.DogPolicy.None) continue;

                string term = item.ToString().ToLower();

                if (value.HasValue && value.Value.HasFlag(item))
                {
                    listing.Terms.Add(term);
                }
                else if (value.HasValue)
                {
                    listing.Terms.Remove(term);
                }

                if (listing.Terms.Contains(term))
                {
                    terms.Add(item.Description());
                }
            }

            if (terms.Count == 0)
                terms.Add("No Dogs Allowed");

            return terms;
        }

        public static long ListingId(this Listing listing)
        {
            return long.Parse(listing.Origin.EntityId);
        }

        public static bool CatsAllowed(this Listings.Listing listing)
        {
            return listing.Terms.Contains(Admin.Common.CatPolicy.CatsAllowed.ToString().ToLower());
        }

        public static bool DogsAllowed(this Listings.Listing listing)
        {
            return listing.Terms.Contains(Admin.Common.DogPolicy.DogsBreedRestrictions.ToString().ToLower()) ||
                   listing.Terms.Contains(Admin.Common.DogPolicy.DogsLargeAllowed.ToString().ToLower()) ||
                   listing.Terms.Contains(Admin.Common.DogPolicy.DogsSmallAllowed.ToString().ToLower());
        }

        public static DateTime ExpirationDate(this Listings.Listing listing)
        {
            return listing.CreateDate.AddMonths(1);
        }

        public static TimeSpan TimeOnline(this Listings.Listing listing)
        {
            return DateTime.UtcNow - listing.CreateDate;
        }

        public static TimeSpan TimeLeft(this Listings.Listing listing)
        {
            return listing.ExpirationDate() - DateTime.UtcNow;
        }

        public static bool HasCustomPhone(this Listings.Listing listing, Listings.Community community)
        {
            return community != null &&
                   community.UseCustomPhone() &&
                   !string.IsNullOrWhiteSpace(listing.CustomPhone());
        }

        public static bool HasMoveInSpecial(this Listings.Listing listing, Listings.Community community)
        {
            return community != null &&
                   community.IsUpgraded() &&
                   !string.IsNullOrWhiteSpace(listing.MoveInSpecial());
        }

        public static string Slug(this Listings.Listing listing)
        {
            string url = string.Format("{0}/{1}/{2}",
                StringHelpers.URLFriendly(listing.Address.State),
                StringHelpers.URLFriendly(listing.Address.City),
                StringHelpers.URLFriendly(listing.PropertyType.ResolvePropertyType()));
            return url;
        }

        public static string UrlId(this Listings.Listing listing)
        {
            string communityId = listing.CommunityId == null ? "" : listing.CommunityId.Replace("r", "");
            if (!string.IsNullOrWhiteSpace(communityId))
                return string.Format("/listings/{0}/c{1}-{2}/l{3}-{4}",
                    listing.Slug(),
                    communityId,
                    StringHelpers.URLFriendly(listing.Address.Address1),
                    listing.ListingId(),
                    StringHelpers.URLFriendly(listing.Address.Address1));
            else
                return string.Format("/listings/{0}/l{1}-{2}",
                    listing.Slug(),
                    listing.ListingId(),
                    StringHelpers.URLFriendly(listing.Address.Address1));
        }

        public static string PrimaryPhoto(this Listings.Listing listing)
        {
            if (listing.Photos.Any())
                return listing.Photos.First().ThumbnailUrl;
            return "/images/noimage-200x150.png";
        }

        public static string PromotionalType(this Listings.Listing listing)
        {
            string type = string.Empty;
            if (listing.IsFeatured()) type += "featured ";
            if (!(string.IsNullOrWhiteSpace(listing.RibbonId()))) type += "ribbon";

            if (type == string.Empty)
                type = "free";

            type = type.Trim();

            return type;
        }

        public static bool IsFeatured(this Listings.Listing listing)
        {
            var today = DateHelper.ToStoredDate(DateTime.UtcNow);
            return listing.FeaturedDates.Contains(today);
        }*/
    }
}
