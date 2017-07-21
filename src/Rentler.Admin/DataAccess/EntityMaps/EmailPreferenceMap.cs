using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class EmailPreferenceMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmailPreference>(entity =>
            {
                entity.HasKey(e => e.EmailPreferenceId)
                    .HasName("PK_EmailPreferences");

                entity.Property(e => e.AnalyticReportDateUtc).HasColumnType("datetime");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PhoneLeadReportDateUtc).HasColumnType("datetime");

                entity.Property(e => e.PhoneLeadReportFrequency).HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EmailPreferences)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmailPreferences_Users");
            });

        }

    }
}
