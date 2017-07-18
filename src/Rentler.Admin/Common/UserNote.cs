using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class UserNote
    {
        public int UserNoteId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public DateTime UpdateDateUtc { get; set; }
        public bool IsDeleted { get; set; }
    }
}
