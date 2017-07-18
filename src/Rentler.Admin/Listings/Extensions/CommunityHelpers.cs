using Rentler.Admin.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Listings.Extensions
{
    public static class CommunityHelpers
    {
        /*public static long CommunityId(this Listings.Community community)
        {
            return long.Parse(community.Origin.EntityId);
        }

        public static bool UseCustomPhone(this Listings.Community community, bool? value = null)
        {
            if (value.HasValue)
                community.Metadata["UseCustomPhone"] = value.Value.ToString();

            if (community == null || !community.Metadata.ContainsKey("UseCustomPhone"))
                return false;

            return bool.Parse(community.Metadata["UseCustomPhone"]);
        }

        public static bool IsUpgraded(this Listings.Community community, bool? value = null)
        {
            if (value.HasValue)
                community.Metadata["IsUpgraded"] = value.Value.ToString();

            if (community == null || !community.Metadata.ContainsKey("IsUpgraded"))
                return false;

            return bool.Parse(community.Metadata["IsUpgraded"]);
        }

        public static int UserId(this Listings.Community community, int? value = null)
        {
            if (value.HasValue)
                community.Metadata["UserId"] = value.Value.ToString();
            return int.Parse(community.Metadata["UserId"]);
        }

        public static string Slug(this Listings.Community community)
        {
            string url = string.Format("{0}/{1}/{2}",
                StringHelpers.URLFriendly(community.Address.State),
                StringHelpers.URLFriendly(community.Address.City),
                StringHelpers.URLFriendly(PropertyType.Apartment.ResolvePropertyType()));
            return url;
        }

        public static string UrlId(this Listings.Community community)
        {
            return string.Format("/listings/{0}/c{1}-{2}",
                community.Slug(),
                community.Origin.EntityId,
                StringHelpers.URLFriendly(community.Address.Address1));
        }

        public static string CustomPhone(this Listings.Community community, string value = null)
        {
            if (!string.IsNullOrEmpty(value))
                community.Metadata["customphone"] = value;

            if (community == null || !community.Metadata.ContainsKey("customphone"))
                return null;

            return community.Metadata["customphone"];
        }*/
    }
}
