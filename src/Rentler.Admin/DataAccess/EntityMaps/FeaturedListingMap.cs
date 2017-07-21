using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;


namespace Rentler.Admin.DataAccess 
{
    public class FeaturedListingMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeaturedListing>(entity =>
            {
                entity.HasKey(e => e.FeaturedListingId)
                    .HasName("PK_FeaturedListings");

                entity.Property(e => e.ScheduledDate).HasColumnType("datetime");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.FeaturedListings)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_FeaturedListings_dbo_Buildings_BuildingId");
            });

        }
    }
}
