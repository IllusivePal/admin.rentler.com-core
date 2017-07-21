using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class CustomAmenityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomAmenity>(entity =>
            {
                entity.HasKey(e => new { e.BuildingId, e.Name })
                    .HasName("PK_CustomAmenities");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.CustomAmenities)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_CustomAmenities_dbo_Buildings_BuildingId");
            });

        }
    }
}
