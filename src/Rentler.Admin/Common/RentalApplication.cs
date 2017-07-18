using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class RentalApplication
    {
        public long RentalApplicationId { get; set; }

        public int? UserId { get; set; }

        public long? BuildingId { get; set; }

        public RentalApplicationStatus Status { get; set; }

        public string StatusText { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public DateTime UpdateDateUtc { get; set; }

        public DateTime? SubmitDateUtc { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsDismissed { get; set; }

        public User User { get; set; }

        public Property Property { get; set; }

        public Common.BuildingPreview BuildingPreview { get; set; }

        public bool IsArchived { get; set; }

        public bool WasInvited { get; set; }

        public bool IsApplicationRequired { get; set; }

        public IEnumerable<RentalApplicant> RentalApplicants { get; set; }
    }

    public enum RentalApplicationStatus
    {
        Draft = 0,
        Submitted = 1,
        Accepted = 2,
        Rejected = 3,
        Invited = 4,
        PartiallySubmitted = 5
    }
}


