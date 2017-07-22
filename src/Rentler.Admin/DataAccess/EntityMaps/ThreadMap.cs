using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;


namespace Rentler.Admin.DataAccess
{
    public class ThreadMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Thread>(entity =>
            {
                entity.HasKey(e => e.ThreadId)
                    .HasName("PK_Threads");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.SmsPhoneNumber).HasMaxLength(25);

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.Threads)
                    .HasForeignKey(d => d.BuildingId);

                entity.HasOne(d => d.User1)
                    .WithMany(p => p.Threads1)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Threads_Users");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Threads)
                    .HasForeignKey(d => d.UserId2)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_Threads_dbo_Users_UserId2");
            });


        }
    }
}
