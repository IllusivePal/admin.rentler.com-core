using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rentler.Admin.DataAccess
{
    public class AchTransactionMap :IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AchTransaction>(entity =>
            {
                entity.HasKey(e => e.AchTransactionId)
                    .HasName("PK_AchTransactions");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.ProviderId).HasMaxLength(250);

                entity.Property(e => e.StatusMessage).HasMaxLength(250);

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.AchTransactions)
                    .HasForeignKey(d => d.BankAccountId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

        }
    }
}
