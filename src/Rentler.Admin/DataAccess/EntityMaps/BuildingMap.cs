using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class BuildingMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>(entity =>
            {
                entity.HasKey(e => e.BuildingId)
                    .HasName("PK_Buildings");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Address2).HasMaxLength(250);

                entity.Property(e => e.ApplicationFee).HasColumnType("decimal");

                entity.Property(e => e.CatPolicyCode).HasDefaultValueSql("0");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CustomPhoneId).HasMaxLength(255);

                entity.Property(e => e.CustomPhoneNumber).HasMaxLength(100);

                entity.Property(e => e.DateActivatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateAvailableUtc).HasColumnType("datetime");

                entity.Property(e => e.DateRibbonActivated).HasColumnType("datetime");

                entity.Property(e => e.DefaultCity).HasMaxLength(250);

                entity.Property(e => e.Deposit).HasColumnType("decimal");

                entity.Property(e => e.Directions).HasMaxLength(250);

                entity.Property(e => e.DogPolicyCode).HasDefaultValueSql("0");

                entity.Property(e => e.FloorPlanImageExtension).HasMaxLength(10);

                entity.Property(e => e.FullHash).HasMaxLength(32);

                entity.Property(e => e.IsActive).HasDefaultValueSql("0");

                entity.Property(e => e.IsApplicationsEnabled).HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("0");

                entity.Property(e => e.IsDIYApartment)
                    .HasColumnName("IsDIYApartment")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsLeaseToOwn).HasDefaultValueSql("0");

                entity.Property(e => e.IsMonthToMonth).HasDefaultValueSql("0");

                entity.Property(e => e.IsOnApprovedCredit).HasDefaultValueSql("0");

                entity.Property(e => e.IsRemovedByAdmin).HasDefaultValueSql("0");

                entity.Property(e => e.IsReported).HasDefaultValueSql("0");

                entity.Property(e => e.IsSeniorRestricted).HasDefaultValueSql("0");

                entity.Property(e => e.IsSmokingAllowed).HasDefaultValueSql("0");

                entity.Property(e => e.IsUpgraded).HasDefaultValueSql("0");

                entity.Property(e => e.LeaseLengthCode).HasDefaultValueSql("0");

                entity.Property(e => e.MaxLeaseLength).HasDefaultValueSql("0");

                entity.Property(e => e.MinLeaseLength).HasDefaultValueSql("0");

                entity.Property(e => e.MoveInSpecial).HasMaxLength(100);

                entity.Property(e => e.Nickname).HasMaxLength(250);

                entity.Property(e => e.OrderScore).HasDefaultValueSql("10");

                entity.Property(e => e.PetDeposit).HasColumnType("decimal");

                entity.Property(e => e.PetDetails).HasMaxLength(250);

                entity.Property(e => e.PetFee).HasColumnType("decimal");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RecordCalls).HasDefaultValueSql("1");

                entity.Property(e => e.RefundableDeposit).HasColumnType("decimal");

                entity.Property(e => e.ReportedText).HasMaxLength(1000);

                entity.Property(e => e.RibbonId).HasMaxLength(50);

                entity.Property(e => e.SmokingDetails).HasMaxLength(250);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StreetHash).HasMaxLength(32);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.YouTubeUrl).HasMaxLength(100);

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.Buildings)
                    .HasForeignKey(d => d.CommunityId);

                entity.HasOne(d => d.ContactInfo)
                    .WithMany(p => p.Buildings)
                    .HasForeignKey(d => d.ContactInfoId)
                    .HasConstraintName("FK_dbo_Buildings_dbo_ContactInfoes_ContactInfoId");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Buildings)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_Buildings_Properties");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Buildings)
                    .HasForeignKey(d => d.TemporaryOrderId)
                    .HasConstraintName("FK_dbo_Buildings_dbo_Orders_TemporaryOrderId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Buildings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo_Buildings_dbo_Users_UserId");
            });

        }
    }
}
