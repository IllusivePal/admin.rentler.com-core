using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class FormProvider
    {
        public long FormProviderId { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string OfficeAddress { get; set; }

        public string OfficeCity { get; set; }

        public string OfficeState { get; set; }

        public string OfficeZip { get; set; }

        public string Description { get; set; }

        public string PhotoUrl { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public DateTime UpdateDateUtc { get; set; }
    }
}
