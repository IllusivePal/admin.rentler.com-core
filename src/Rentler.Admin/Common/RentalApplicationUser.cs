using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class RentalApplicationUser
    {
        public long RentalApplicationUserId { get; set; }

        public long RentalApplicationId { get; set; }

        public string ApplicationSnapshotId { get; set; }

        public int UserId { get; set; }

        public int? InviteUserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public RentalApplication RentalApplication { get; set; }
    }
}
