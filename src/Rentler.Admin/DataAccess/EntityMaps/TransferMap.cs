using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class TransferMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.HasKey(e => e.TransferId)
                    .HasName("PK_Transfers");

                entity.Property(e => e.AccountResourceId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDateUtc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.RentMoolaRefNumber)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ResourceId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Total).HasColumnType("decimal");

                entity.Property(e => e.TransferDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdateDateUtc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.MerchantAccount)
                    .WithMany(p => p.Transfers)
                    .HasForeignKey(d => d.MerchantAccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Transfers_MerchantAccounts");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Transfers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Transfers_Users");
            });


        }
    }
}
