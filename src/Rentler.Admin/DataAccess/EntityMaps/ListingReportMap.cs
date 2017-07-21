using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class ListingReportMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListingReport>(entity =>
            {
                entity.HasKey(e => e.ListingReportId)
                    .HasName("PK_ReportedListings");

                entity.Property(e => e.Content).IsRequired();

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.ListingReports)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReportedListings_Buildings1");
            });

        }
    }
}
