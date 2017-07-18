using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class CreditCheck
    {
        public BuildingPreview Building { get; set; }
        public long BuildingId { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public long CreditCheckId { get; set; }
        public User User { get; set; }
        public string LastEditBy { get; set; }
        public string Notes { get; set; }
    }
}
