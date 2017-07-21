using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class RecurringPaymentMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecurringPayment>(entity =>
            {
                entity.HasKey(e => e.RecurringPaymentId)
                    .HasName("PK_RecurringPayments");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.EndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.LandlordIsDismissed).HasDefaultValueSql("0");

                entity.Property(e => e.StartDateUtc).HasColumnType("datetime");

                entity.Property(e => e.TenantIsDismissed).HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.RecurringPayments)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_RecurringPayments_dbo_Buildings_BuildingId");

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.RecurringPayments)
                    .HasForeignKey(d => d.LandlordBankAccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_RecurringPayment_dbo_BankAccounts_LandlordBankAccountId");

                entity.HasOne(d => d.BankAccount1)
                    .WithMany(p => p.RecurringPayments1)
                    .HasForeignKey(d => d.TenantBankAccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_RecurringPayment_dbo_BankAccounts_TenantBankAccountId");
            });


        }
    }
}
