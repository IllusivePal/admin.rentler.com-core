using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class TransactionMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK_Transactions");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CommerceKey).HasMaxLength(50);

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Fee)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("1");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("0");

                entity.Property(e => e.IsPending).HasDefaultValueSql("0");

                entity.Property(e => e.PendingReason).HasMaxLength(500);

                entity.Property(e => e.StatusMessage).HasMaxLength(250);

                entity.Property(e => e.TransactionDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.PaymentSeries)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.PaymentSeriesId)
                    .HasConstraintName("FK_Transactions_PaymentSeries");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_Transactions_Tenants");

                entity.HasOne(d => d.Transfer)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.TransferId)
                    .HasConstraintName("FK__Transacti__Trans__6ABAD62E");
            });


        }
    }
}
