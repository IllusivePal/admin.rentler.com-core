using Nest;
using Rentler.Admin.Common;
using Rentler.Admin.Configuration;
using Rentler.Listings;
using Rentler.Listings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Adapters
{
    public interface IListingAdapter
    {
        /// <summary>
        /// Refreshes a listing if it is active or deletes
        /// a listing if it is inactive.
        /// </summary>
        /// <param name="listingId"></param>
        /// <returns></returns>
        Status<bool> Invalidate(long listingId);

        /// <summary>
        /// Refreshes a listing.
        /// </summary>
        /// <param name="listingId"></param>
        /// <returns></returns>
        Status<bool> InvalidateForce(long listingId);

        /// <summary>
        /// Deletes a listing.
        /// </summary>
        /// <param name="listingId"></param>
        /// <returns></returns>
        Status<bool> Delete(long listingId);

        /// <summary>
        /// Refrehes a community listing.
        /// </summary>
        /// <param name="communityId"></param>
        /// <returns></returns>
        Status<bool> InvalidateCommunity(long communityId);

        /// <summary>
        /// Deletes a community listing.
        /// </summary>
        /// <param name="communityId"></param>
        /// <returns></returns>
        Status<bool> DeleteCommunity(long communityId);

        Status<Common.ListingDetail> GetListing(long listingId);
    }

    public class ListingAdapter : IListingAdapter
    {
        //ListingService listingService;
       // CommunityService communityService;

        public ListingAdapter(
          //  ListingService listingService,
          //  CommunityService communityService/

          )
        {
          //  this.listingService = listingService;
          //  this.communityService = communityService;
        }

        public Status<bool> Invalidate(long listingId)
        {
            bool invalidate;

           /* using (var context = new RentlerEntities())
            {
                var query = (from b in context.Buildings
                             where b.BuildingId == listingId
                             select b).SingleOrDefault();

                invalidate = query == null ? false : query.IsActive;
            }*/

           // if (!invalidate)
          //  {
                this.Delete(listingId);
                return Status.OK(false);
          //  }

           // return this.InvalidateForce(listingId);
        }

        public Status<bool> InvalidateForce(long listingId)
        {
            Admin.Common.Listing.ListingDetail detail = null;

            /*using (var context = new RentlerEntities())
            {
                var query = (from b in context.Buildings
                            .Include("FeaturedListings")
                            .Include("Photos")
                            .Include("BuildingAmenities")
                            .Include("CustomAmenities")
                            .Include("BuildingUtilities")
                            .Include("Community")
                            .Include("Community.CommunityAmenities")
                             where b.BuildingId == listingId
                             select b).SingleOrDefault();

                detail = query == null ? null : query.ToListingDetail();
            }*/

            if (detail == null)
                return Status.NotFound<bool>();

            //var listing = detail.ToListing();

           // listing = this.listingService.Upsert(listing);

            return Status.OK(true);
        }

        public Status<bool> Delete(long listingId)
        {
            var id = string.Format("r{0}", listingId);

            // var result = this.listingService.Delete(id);

            // return Status.OK(result);
            return Status.OK(true);
        }

        public Status<bool> InvalidateCommunity(long communityId)
        {
            Admin.Common.CommunityDetails detail = null;

            /*using (var context = new RentlerEntities())
            {
                var query = (from c in context.Communities
                            .Include("CommunityAmenities")
                            .Include("OperatingDays")
                             where c.CommunityId == communityId
                             select c).SingleOrDefault();

                if (query == null)
                    detail = null;

                detail = query.ToCommunityDetails();
            }*/

            if (detail == null)
                return Status.NotFound<bool>();

           // var community = detail.ToCommunity();

         //   community = this.communityService.Upsert(community);

            return Status.OK(true);
        }

        public Status<bool> DeleteCommunity(long communityId)
        {
            var id = string.Format("r{0}", communityId);

            //var result = this.communityService.Delete(id);

            return Status.OK(true);
        }

        public Status<Common.ListingDetail> GetListing(long listingId)
        {
            var id = string.Format("r{0}", listingId);

            //var result = this.listingService.Get(id);

            //if (result == null)
              //  return Status.NotFound<Common.ListingDetail>();

            ListingDetail listingDetail = new ListingDetail();
          //  listingDetail.Listing = result;

            return Status.OK(listingDetail);
        }
    }
}
