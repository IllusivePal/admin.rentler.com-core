using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class RentalApplicant
    {
        public long RentalApplicantId { get; set; }

        public long RentalApplicationId { get; set; }

        public int? UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Guid? InviteKey { get; set; }

        public string ApplicationSnapshotId { get; set; }

        public int StatusCode { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public DateTime UpdateDateUtc { get; set; }

        public DateTime? AgreeToTermsDateUtc { get; set; }

        public bool IsArchived { get; set; }

        public bool IsApplicationRequired { get; set; }
    }
}
