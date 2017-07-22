using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class VerificationMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Verification>(entity =>
            {
                entity.HasKey(e => e.VerificationId)
                    .HasName("PK_Verifications");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.ProviderId).HasMaxLength(250);

                entity.Property(e => e.SSNHash)
                    .HasColumnName("SSNHash")
                    .HasMaxLength(250);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Zip).HasMaxLength(10);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Verifications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Verifications_UserId");
            });


        }
    }
}
