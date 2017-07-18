using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Listings.Extensions
{
    public static class PropertyTypeExtensions
    {
        /*public static string ResolvePropertyType(this Rentler.Listings.PropertyType type)
        {
            var types = new Dictionary<string, Rentler.Listings.PropertyType>();
            types["single-family-homes"] = Rentler.Listings.PropertyType.SingleFamilyHome;
            types["apartments"] = Rentler.Listings.PropertyType.Apartment;
            types["condos-townhomes"] = Rentler.Listings.PropertyType.CondoTownhome;
            types["multi-family-homes"] = Rentler.Listings.PropertyType.MultiFamilyHome;
            types["manufactured-homes"] = Rentler.Listings.PropertyType.ManufacturedHome;
            types["horse-livestock"] = Rentler.Listings.PropertyType.HorseLivestock;
            types["single-rooms"] = Rentler.Listings.PropertyType.SingleRoom;
            types["subleases"] = Rentler.Listings.PropertyType.SubLease;

            if (types.ContainsValue(type))
                return types.First(t => t.Value == type).Key;

            return "any";
        }*/
    }
}
