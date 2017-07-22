using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class RentalApplicantMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RentalApplicant>(entity =>
            {
                entity.HasKey(e => e.RentalApplicantId)
                    .HasName("PK_RentalApplicants");

                entity.Property(e => e.AgreeToTermsDateUtc).HasColumnType("datetime");

                entity.Property(e => e.ApplicationSnapshotId).HasMaxLength(250);

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IsApplicationRequired).HasDefaultValueSql("1");

                entity.Property(e => e.IsArchived).HasDefaultValueSql("0");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.StatusCode).HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.RentalApplication)
                    .WithMany(p => p.RentalApplicants)
                    .HasForeignKey(d => d.RentalApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RentalApplicants_RentalApplications");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RentalApplicants)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_RentalApplicants_Users");
            });

        }
    }
}
