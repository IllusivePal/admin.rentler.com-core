using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class RentalApplicationUserMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RentalApplicationUser>(entity =>
            {
                entity.HasKey(e => e.RentalApplicationUserId)
                    .HasName("PK_RentalApplicationUsers");

                entity.Property(e => e.ApplicationSnapshotId).HasMaxLength(250);

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("0");

                entity.Property(e => e.IsDismissed).HasDefaultValueSql("0");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.User1)
                    .WithMany(p => p.RentalApplicationUsers1)
                    .HasForeignKey(d => d.InviteUserId);

                entity.HasOne(d => d.RentalApplication)
                    .WithMany(p => p.RentalApplicationUsers)
                    .HasForeignKey(d => d.RentalApplicationId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RentalApplicationUsers)
                    .HasForeignKey(d => d.UserId);
            });

        }
    }
}
