using System;
using System.Collections.Generic;
using System.Text;

namespace Rentler.Admin.Configuration
{
    public class BlobImagesConfig
    {
        public string BlobStorageHostname { get; set; }
        public string BlobPrefix { get; set; }
        public string BlobConnection { get; set; }
    }
}
