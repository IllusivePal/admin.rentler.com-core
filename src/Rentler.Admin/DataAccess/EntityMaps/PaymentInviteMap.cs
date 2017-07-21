using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class PaymentInviteMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentInvite>(entity =>
            {
                entity.HasKey(e => e.PaymentInviteId)
                    .HasName("PK_PaymentInvites");

                entity.Property(e => e.PaymentInviteId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.ConfirmationNumber).ValueGeneratedOnAdd();

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.PaymentInvites)
                    .HasForeignKey(d => d.BankAccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_PaymentInvies_dbo_BankAccounts_BankAccountId");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.PaymentInvites)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_PaymentInvies_dbo_Buildings_BuildingId");
            });


        }
    }
}
