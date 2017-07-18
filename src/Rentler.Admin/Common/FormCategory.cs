using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class FormCategory
    {
        public long FormCategoryId { get; set; }

        public string Name { get; set; }

        public FormCategoryType Type { get; set; }

        public int Order { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public DateTime UpdateDateUtc { get; set; }
    }

    public enum FormCategoryType
    {
        LeaseInitiation = 1,
        DuringTenancy = 2,
        LeaseEnd = 3
    }
}
