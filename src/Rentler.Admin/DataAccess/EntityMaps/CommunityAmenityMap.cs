using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class CommunityAmenityMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommunityAmenity>(entity =>
            {
                entity.HasKey(e => new { e.CommunityId, e.AmenityId })
                    .HasName("PK_CommunityAmenities");

                entity.Property(e => e.AmenityId).HasMaxLength(128);

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.CommunityAmenities)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("FK_CommunityAmenities_Communities");
            });

        }
    }
}
