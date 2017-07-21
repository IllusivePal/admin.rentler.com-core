using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class BuildingUtilityMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuildingUtility>(entity =>
            {
                entity.HasKey(e => new { e.BuildingId, e.UtilityId })
                    .HasName("PK_BuildingUtilities");

                entity.Property(e => e.UtilityId).HasMaxLength(50);

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.BuildingUtilities)
                    .HasForeignKey(d => d.BuildingId);
            });

        }
    }
}
