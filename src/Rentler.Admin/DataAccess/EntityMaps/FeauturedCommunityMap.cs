using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class FeauturedCommunityMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeaturedCommunity>(entity =>
            {
                entity.HasKey(e => e.FeaturedCommunityId)
                    .HasName("PK_FeaturedCommunities");

                entity.Property(e => e.ScheduledDate).HasColumnType("datetime");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.FeaturedCommunities)
                    .HasForeignKey(d => d.CommunityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FeaturedCommunities_Communities");
            });

        }
    }
}
