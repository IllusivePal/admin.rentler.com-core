using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class NextRecurringPaymentMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NextRecurringPayment>(entity =>
            {
                entity.HasKey(e => e.NextRecurringPaymentId)
                    .HasName("PK_NextRecurringPayments");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.NextRecurringPayments)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NextRecurringPayments_Buildings_BbuildingId");

                entity.HasOne(d => d.AchTransaction)
                    .WithMany(p => p.NextRecurringPayments)
                    .HasForeignKey(d => d.LandlordAchTransactionId);

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.NextRecurringPayments)
                    .HasForeignKey(d => d.LandlordBankAccountId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.RecurringPayment)
                    .WithMany(p => p.NextRecurringPayments)
                    .HasForeignKey(d => d.RecurringPaymentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NextRecurringPayments_RecurringPayments_RecurringPaymentId_");

                entity.HasOne(d => d.AchTransaction1)
                    .WithMany(p => p.NextRecurringPayments1)
                    .HasForeignKey(d => d.TenantAchTransactionId);

                entity.HasOne(d => d.BankAccount1)
                    .WithMany(p => p.NextRecurringPayments1)
                    .HasForeignKey(d => d.TenantBankAccountId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

        }
    }
}
