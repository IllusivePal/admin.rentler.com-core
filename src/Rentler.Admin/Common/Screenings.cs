using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class Screening
    {
        public long ScreeningId { get; set; }

        public long? RentalApplicationUserId { get; set; }

        public int? UserId { get; set; }

        public int? OrderId { get; set; }

        public long? BuildingId { get; set; }

        public bool IsPrepaid { get; set; }

        public string BackgroundProviderId { get; set; }

        public string BackgroundProviderStatus { get; set; }

        public string CreditProviderId { get; set; }

        public string CreditProviderShareId { get; set; }

        public string CreditProviderStatus { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public DateTime UpdateDateUtc { get; set; }

        public int StatusCode { get; set; }

        public Common.BuildingPreview BuildingPreview { get; set; }

        public Common.Property Property { get; set; }

        public User User { get; set; }

        public Common.Order Order { get; set; }

    }
}
