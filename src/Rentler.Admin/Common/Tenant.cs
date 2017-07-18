using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class Tenant
    {
        public int TenantId { get; set; }

        public int LeaseId { get; set; }

        public int? UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public TenantStatus Status { get; set; }

        public bool IsDeleted { get; set; }

        public Guid InviteKey { get; set; }
    }

    public enum TenantStatus
    {
        Invited = 0,
        Accepted = 1
    }
}
