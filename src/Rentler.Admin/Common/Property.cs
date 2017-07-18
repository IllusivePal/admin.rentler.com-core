using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class Property
    {
        public long PropertyId { get; set; }
        public int UserId { get; set; }
        public int PropertyTypeCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string StreetHash { get; set; }
        public string FullHash { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string ThumbnailUrl { get; set; }
        public bool IsApplicationsEnabled { get; set; }
        public bool IsScreeningRequired { get; set; }
        public DateTime? ApplicationActivityDateUtc { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public bool IsDeleted { get; set; }

        public UserPreview User { get; set; }
    }
}
