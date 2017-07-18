using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace Rentler.Admin
{
    public enum ManagementType
    {
        [Description("Private Landlord")]
        PrivateLandlord = 1,

        [Description("Property Manager")]
        PropertyManager = 2,

        [Description("Apartment Manager")]
        ApartmentManager = 3,
    }
}
