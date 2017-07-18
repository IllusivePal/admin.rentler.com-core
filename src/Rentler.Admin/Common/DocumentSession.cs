using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class DocumentSession
    {
        public string Id { get; set; }

        public string Type { get; set; }

        public DateTime ExpiresAt { get; set; }
    }
}
