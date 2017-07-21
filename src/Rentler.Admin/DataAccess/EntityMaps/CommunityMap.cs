using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class CommunityMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Community>(entity =>
            {
                entity.HasKey(e => e.CommunityId)
                    .HasName("PK_Communities");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Address2).HasMaxLength(250);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CustomPhoneId).HasMaxLength(255);

                entity.Property(e => e.CustomPhoneNumber).HasMaxLength(255);

                entity.Property(e => e.DefaultCity).HasMaxLength(250);

                entity.Property(e => e.Directions).HasMaxLength(250);

                entity.Property(e => e.FullHash).HasMaxLength(32);

                entity.Property(e => e.HeaderPhotoExtension).HasMaxLength(10);

                entity.Property(e => e.InternalName).HasMaxLength(100);

                entity.Property(e => e.InvoiceContactName).HasMaxLength(100);

                entity.Property(e => e.InvoiceContactPhone).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("0");

                entity.Property(e => e.IsSeniorRestricted).HasDefaultValueSql("0");

                entity.Property(e => e.IsUpgraded).HasDefaultValueSql("0");

                entity.Property(e => e.LastRefreshDateUtc).HasColumnType("datetime");

                entity.Property(e => e.MainPhotoExtension).HasMaxLength(10);

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.RecordCalls).HasDefaultValueSql("1");

                entity.Property(e => e.RequestedPackage).HasMaxLength(50);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StreetHash).HasMaxLength(32);

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.WebsiteUrl).HasMaxLength(500);

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.ContactInfo)
                    .WithMany(p => p.Communities)
                    .HasForeignKey(d => d.ContactInfoId);

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Communities)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_Communities_Properties");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Communities)
                    .HasForeignKey(d => d.UserId);
            });

        }
    }
}
