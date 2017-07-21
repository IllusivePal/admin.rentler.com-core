using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class PaymentSeriesMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentSeries>(entity =>
            {
                entity.Property(e => e.AgreeToTermsUtc).HasColumnType("datetime");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.FinalPaymentDateUtc).HasColumnType("datetime");

                entity.Property(e => e.FirstPaymentDateUtc).HasColumnType("datetime");

                entity.Property(e => e.IsFirstPaymentProrated).HasDefaultValueSql("0");

                entity.Property(e => e.LateFeeAmount).HasColumnType("decimal");

                entity.Property(e => e.MonthlyAmount).HasColumnType("decimal");

                entity.Property(e => e.PastDueAmount).HasColumnType("decimal");

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Lease)
                    .WithMany(p => p.PaymentSeries)
                    .HasForeignKey(d => d.LeaseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PaymentSeries_Leases");

                entity.HasOne(d => d.MerchantAccount)
                    .WithMany(p => p.PaymentSeries)
                    .HasForeignKey(d => d.MerchantAccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PaymentSeries_MerchantAccounts");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PaymentSeries)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PaymentSeries_Users");
            });


        }
    }
}
