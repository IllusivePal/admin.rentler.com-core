using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class NotificationMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasKey(e => e.NotificationId)
                    .HasName("PK_Notifications");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Data).HasMaxLength(250);

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.BuildingId)
                    .HasConstraintName("FK_Notifications_Buildings");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.ReferenceUserId)
                    .HasConstraintName("FK_Notifications_ReferenceUser");

                entity.HasOne(d => d.User1)
                    .WithMany(p => p.Notifications1)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Notifications_Users");
            });


        }
    }
}
