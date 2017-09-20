using System;
using System.Collections.Generic;
using System.Text;

namespace Rentler.Admin.Configuration
{
    public class AppSettings
    {
        public string Hostname { get; set; }
        public string DotComHostname { get; set; }
        public string ListingLocation { get; set; }
        public string BlobPrefix { get; set; }
        public string  PhotoFolder()
        {
            string prefix = BlobPrefix;
            if(!string.IsNullOrEmpty(prefix))
                prefix += "-";

            if (prefix.ToLower() == "dev-")
                prefix += System.Environment.MachineName + "-";

            prefix += "userphotos";

            return prefix.ToLower();
            
            
        }

        public string BlobConnection { get; set; }
        public string BlobStorageHostname { get; set; }
        public string AzureStorageCS { get; set; }
        public string AzureStorageAppCS { get; set; }
        public string AzureQueueNamePrefix { get; set; }
        public string GeneralBlobPrefix { get; set; }
        public string GeneralBlobConnection { get; set; }
        public string StripeApiKey { get; set; }
        public string BoxViewBaseUri { get; set; }
        public string BoxViewToken { get; set; }
        public string FacetflowUrl { get; set; }
        public string FacetflowIndexName { get; set; }
        public string SiftScienceJsKey { get; set; }
        public string SiftScienceRestKey { get; set; }
        public int SiftScienceMaxScore { get; set; }
        public string RentlerMongoConnection { get; set; }
        public string RentlerMongoDatabase { get; set; }
        public string RentlerStorageCS { get; set; }
    }
}
