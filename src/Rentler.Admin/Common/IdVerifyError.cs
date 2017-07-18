using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class IdVerifyError
    {
        public string Id { get; set; }

        public int? UserId { get; set; }

        public string Content { get; set; }

        public string JsonContent { get; set; }

        public DateTime? CreateDateUtc { get; set; }

        public VerificationStep Step { get; set; }

        public string ErrorMessage { get; set; }

        public ExperianResponse ExperianResponse { get; set; }

        public User User { get; set; }

        public string SerializationException { get; set; }
    }
}
    