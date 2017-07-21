using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class RefreshScheduleMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RefreshSchedule>(entity =>
            {
                entity.HasKey(e => e.RefreshScheduleId)
                    .HasName("PK_RefreshSchedules");

                entity.Property(e => e.ScheduledDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.RefreshSchedules)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RefreshSchedules_Buildings");
            });


        }

    }
}
