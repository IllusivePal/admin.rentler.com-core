using System;
using System.Collections.Generic;
using System.Text;
using Rentler.Cache;
using Rentler.Admin.DataAccess;
using Rentler.Admin.Common;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Rentler.Admin.Adapters
{
    public interface IReportedAdapter
    {
        //Status<PagedList<Common.ListingReport>> SearchReported(string search, int page, int pageSize);
        Status<Common.BuildingPreview> UnflagBuilding(long id);
        Status<Common.BuildingPreview> DeactivateBuilding(long id);
        //Status<Common.BuildingPreview> DeleteBuilding(long id);
        //Status<Common.BuildingPreview> UpdateReportedText(long id, string text);

        //Status<BuildingPreview> ActivateBuilding(long id);
    }

    public class ReportedAdapter: IReportedAdapter
    {
        IAtomicCache _cache;
        IListingAdapter listingAdapter;
        private readonly RentlerEntities _dbContext;
        public ReportedAdapter(IAtomicCache chache,
                               IListingAdapter _listingAdapter,
                              RentlerEntities rentler)
        {
            this._cache = chache;
            this._dbContext = rentler;
        }
        public Status<Common.BuildingPreview> UnflagBuilding(long id)
        {
            Common.BuildingPreview result;
           
                var report = (from r in _dbContext.ListingReports
                                .Include("Building")
                                .Include("Building.User")
                                .Include("Building.BuildingUtilities")
                              where r.ListingReportId == id
                              select r).SingleOrDefault();

                if (report == null)
                    return Status.NotFound<Common.BuildingPreview>();

                report.ActionTakenType = (int)ActionTakenType.ReportRemoved;
                _dbContext.SaveChanges();

                //any more reports?
                int reportsCount = (from l in _dbContext.ListingReports
                                    where l.BuildingId == report.BuildingId &&
                                          l.ActionTakenType == (int)ActionTakenType.None
                                    select l.BuildingId).Count();

                if (reportsCount < 1)
                {
                    //no more reports, update the building
                    var building = (from b in _dbContext.Buildings
                                    .Include("FeaturedListings")
                                    .Include("BuildingUtilities")
                                    .Include("Photos")
                                    .Include("BuildingAmenities")
                                    .Include("CustomAmenities")
                                    .Include("Community")
                                    .Include("Community.CommunityAmenities")
                                    .Include("Community.OperatingDays")
                                    where b.BuildingId == report.BuildingId
                                    select b).SingleOrDefault();
                    building.IsReported = false;
                    building.ReportedText = null;
                    _dbContext.SaveChanges();

                    report.Building = building;
                }

                result = report.Building.ToBuildingPreview();
            

            // Invalidate the listing
            this.listingAdapter.Invalidate(result.BuildingId);

            return Status.OK(result);
        }
        public Status<Common.BuildingPreview> DeactivateBuilding(long id)
        {
            Common.BuildingPreview result;
            try
            {
                var building = (from b in _dbContext.Buildings
                                where b.BuildingId == id
                                select b).SingleOrDefault();

                if (building == null)
                    return Status.NotFound<Common.BuildingPreview>();

                building.IsActive = false;
                _dbContext.SaveChanges();
                result = building.ToBuildingPreview();

                return null;

            }
            catch
            {
                return null;
            }
        }
    }
}
