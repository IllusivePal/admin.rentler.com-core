using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class UserMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_Users");

                entity.Property(e => e.AdvertisedListingCount).HasDefaultValueSql("2");

                entity.Property(e => e.ApplicationId).HasMaxLength(250);

                entity.Property(e => e.AvatarUri).HasMaxLength(250);

                entity.Property(e => e.CanAccessForms).HasDefaultValueSql("0");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Introduction).HasMaxLength(250);

                entity.Property(e => e.InvoiceContactName).HasMaxLength(50);

                entity.Property(e => e.InvoiceContactPhone).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LastRefreshDateUtc).HasColumnType("datetime");

                entity.Property(e => e.LockedOutDateUtc).HasColumnType("datetime");

                entity.Property(e => e.LockoutUpdateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.PasswordHash).HasMaxLength(250);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RequestedPackage).HasMaxLength(50);

                entity.Property(e => e.StripeCustomerId).HasMaxLength(500);

                entity.Property(e => e.StripeOrderCustomerId).HasMaxLength(500);

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpgradeStatus).HasDefaultValueSql("0");

                entity.Property(e => e.UserResourceId).HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });


        }
    }
}
