using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class BuildingAmenityMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuildingAmenity>(entity =>
            {
                entity.HasKey(e => new { e.BuildingId, e.AmenityId })
                    .HasName("PK_BuildingAmenities");

                entity.Property(e => e.AmenityId).HasMaxLength(128);

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.BuildingAmenities)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_BuildingAmenities_dbo_Buildings_BuildingId");
            });

        }
    }
}
