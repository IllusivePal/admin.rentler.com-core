using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class BuildingPreview
    {
        public int UserId { get; set; }
        public UserPreview User { get; set; }
        public long BuildingId { get; set; }
        public Guid? PrimaryPhotoId { get; set; }
        public string PrimaryPhotoExtension { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
		public string DefaultCity { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

		public string StreetHash { get; set; }
		public string FullHash { get; set; }
        public int? Bedrooms { get; set; }
        public float? Bathrooms { get; set; }
        public bool IsActive { get; set; }
        public bool IsRemovedByAdmin { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFeatured { get; set; }
		public bool HasRibbon { get; set; }
		public string Title { get; set; }
		public string DisplayTitle
		{
			get
			{
				return (string.IsNullOrWhiteSpace(Title)) ? "No Title" : Title;
			}
		}
		public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int PropertyTypeCode { get; set; }
        public DateTime? CreateDateUtc { get; set; }
        public DateTime? UpdateDateUtc { get; set; }
        public DateTime? DateActivatedUtc { get; set; }
        public long? CommunityId { get; set; }
        public bool IsUpgraded { get; set; }
        public string CustomPhoneId { get; set; }
        public string CustomPhoneNumber { get; set; }
        public bool AutoRentability { get; set; }
		public int OrderScore { get; set; }
        public bool IsDIYApartment { get; set; }
    }
}
