using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess.EntityMaps
{
    public class ScheduledTransactionMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScheduledTransaction>(entity =>
            {
                entity.HasKey(e => e.ScheduledTransactionId)
                    .HasName("PK_ScheduledTransactionId");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("1");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("0");

                entity.Property(e => e.TransactionDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.AutopaySetting)
                    .WithMany(p => p.ScheduledTransactions)
                    .HasForeignKey(d => d.AutopaySettingId)
                    .HasConstraintName("FK_ScheduledTransactions_AutopaySettings");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.ScheduledTransactions)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_ScheduledTransactions_Payments");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.ScheduledTransactions)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ScheduledTransactions_PaymentMethods");

                entity.HasOne(d => d.PaymentSeries)
                    .WithMany(p => p.ScheduledTransactions)
                    .HasForeignKey(d => d.PaymentSeriesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ScheduledTransactions_PaymentSeries");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ScheduledTransactions)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ScheduledTransactionId_Tenants");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.ScheduledTransactions)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK_ScheduledTransactions_Transactions");
            });


        }
    }
}
