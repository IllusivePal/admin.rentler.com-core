using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class PaymentInvite
    {
        public Guid PaymentInviteId { get; set; }

        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        public decimal Amount { get; set; }

        public DateTime StartDateUtc { get; set; }

        public DateTime EndDateUtc { get; set; }

        public int DayDue { get; set; }

        public bool IsAccepted { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public DateTime UpdateDateUtc { get; set; }

        public BuildingPreview Building { get; set; }
    }
}
