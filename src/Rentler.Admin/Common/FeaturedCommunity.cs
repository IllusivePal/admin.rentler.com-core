using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class FeaturedCommunity
    {
        public int FeaturedCommunityId { get; set; }

        public long CommunityId { get; set; }

        public DateTime ScheduledDate { get; set; } 
    }
}
