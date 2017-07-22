using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class RentalApplicationMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RentalApplication>(entity =>
            {
                entity.HasKey(e => e.RentalApplicationId)
                    .HasName("PK_RentalApplications");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.IsApplicationRequired).HasDefaultValueSql("1");

                entity.Property(e => e.IsArchived).HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("0");

                entity.Property(e => e.IsDismissed).HasDefaultValueSql("0");

                entity.Property(e => e.RentAmount)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatusText).HasMaxLength(250);

                entity.Property(e => e.SubmitDateUtc).HasColumnType("date");

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.WasInvited).HasDefaultValueSql("0");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.RentalApplications)
                    .HasForeignKey(d => d.BuildingId);

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.RentalApplications)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_RentalApplications_Properties");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RentalApplications)
                    .HasForeignKey(d => d.UserId);
            });

        }
    }
}
