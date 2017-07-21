using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;


namespace Rentler.Admin.DataAccess
{
    public class AutopaySettingMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutopaySetting>(entity =>
            {
                entity.HasKey(e => e.AutopaySettingId)
                    .HasName("PK_AutopaySettings");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.FirstPaymentAmount).HasColumnType("decimal");

                entity.Property(e => e.FirstPaymentDateUtc).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("0");

                entity.Property(e => e.MonthlyPaymentDay).HasDefaultValueSql("1");

                entity.Property(e => e.StartDateUtc).HasColumnType("datetime");

                entity.Property(e => e.StatusMessage).HasMaxLength(250);

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.AutopaySettings)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AutopaySettings_PaymentMethods");

                entity.HasOne(d => d.PaymentSeries)
                    .WithMany(p => p.AutopaySettings)
                    .HasForeignKey(d => d.PaymentSeriesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AutopaySettings_PaymentSeries");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.AutopaySettings)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AutopaySettings_Tenants");
            });

        }
    }
}
