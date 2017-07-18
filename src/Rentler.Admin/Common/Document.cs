using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class Document
    {
        public string Type { get; set; }

        public string Id { get; set; }

        public DocumentStatus Status { get; set; }

        public string Name { get; set; }

        public DateTime Created_At { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DocumentStatus
    {
        [EnumMember(Value = "queued")]
        Queued = 0,

        [EnumMember(Value = "processing")]
        Processing = 1,

        [EnumMember(Value = "done")]
        Done = 2,

        [EnumMember(Value = "error")]
        Error = 3
    }
}
