using System;
using System.Collections.Generic;
using System.Text;
using Rentler.Admin.Configuration;
using Microsoft.Extensions.Options;

namespace Rentler.Admin
{
    public class PhotoLink
    {
        private BlobImagesConfig _blobImagesConf { get; }
        public static BlobImagesConfig _BlobImageResult;
        public PhotoLink(IOptions<BlobImagesConfig> blobImagesConf)
        {
            this._blobImagesConf = blobImagesConf.Value;
           
        }
        public static string GetPhotoLink(
            long buildingId, Guid? photoId,
            int width, int height, string extension)
        {
            if (!photoId.HasValue)
                return null;

            extension = extension.Replace(".", "");

            //{            0           }/{ 1 }/{ 2  }-{3}x{4}.{5}
            //https://photos.rentler.com/48342/{guid}-800x600.jpg
            return string.Format(
                "{0}{1}/{2}-{3}x{4}.{5}",
                _BlobImageResult.BlobStorageHostname, buildingId.ToString(), photoId,
                width, height, extension);
        }

        public static string GetPhotoLink(
            long buildingId, Guid? photoId, string extension)
        {
            if (!photoId.HasValue)
                return null;

            extension = extension.Replace(".", "");

            //{            0           }/{ 1 }/{ 2  }.{3}
            //https://photos.rentler.com/48342/{guid}.jpg
            return string.Format(
                "{0}{1}/{2}.{3}",
                _BlobImageResult.BlobStorageHostname,
                buildingId.ToString(), photoId, extension);
        }
    }
}
