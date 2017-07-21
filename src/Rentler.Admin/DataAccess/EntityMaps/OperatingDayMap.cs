using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class OperatingDayMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OperatingDay>(entity =>
            {
                entity.Property(e => e.CloseTime).HasColumnType("time(6)");

                entity.Property(e => e.IsClosed).HasDefaultValueSql("0");

                entity.Property(e => e.OpenTime).HasColumnType("time(6)");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.OperatingDays)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("FK_OperatingDays_Communities");
            });


        }
    }
}
