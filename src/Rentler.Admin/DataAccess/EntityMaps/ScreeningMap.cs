using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;


namespace Rentler.Admin.DataAccess
{
    public class ScreeningMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Screening>(entity =>
            {
                entity.HasKey(e => e.ScreeningId)
                    .HasName("PK_Screenings");

                entity.Property(e => e.BackgroundProviderId).HasMaxLength(250);

                entity.Property(e => e.BackgroundProviderStatus).HasMaxLength(250);

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.CreditProviderId).HasMaxLength(250);

                entity.Property(e => e.CreditProviderShareId).HasMaxLength(250);

                entity.Property(e => e.CreditProviderStatus).HasMaxLength(250);

                entity.Property(e => e.StatusCode).HasDefaultValueSql("0");

                entity.Property(e => e.SubmitDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Screenings)
                    .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Screenings)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_Screenings_Properties");

                entity.HasOne(d => d.RentalApplicant)
                    .WithMany(p => p.Screenings)
                    .HasForeignKey(d => d.RentalApplicantId)
                    .HasConstraintName("FK_Screenings_RentalApplicants");

                entity.HasOne(d => d.RentalApplicationUser)
                    .WithMany(p => p.Screenings)
                    .HasForeignKey(d => d.RentalApplicationUserId)
                    .HasConstraintName("FK_Screenings_RentalApplications_RentalApplicationId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Screenings)
                    .HasForeignKey(d => d.UserId);
            });


        }
    }
}
