using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class Form
    {
        public long FormId { get; set; }

        public long FormProviderId { get; set; }

        public long FormCategoryId { get; set; }

        public string State { get; set; }

        public string PreviewProviderId { get; set; }

        public string SmallThumbnailUrl { get; set; }

        public string LargeThumbnailUrl { get; set; }

        public bool IsOffline { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public DateTime UpdateDateUtc { get; set; }

        public FormProvider Provider { get; set; }

        public FormCategory Category { get; set; }
    }
}
