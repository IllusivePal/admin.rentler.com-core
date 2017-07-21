using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class PaymentLineItemMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentLineItem>(entity =>
            {
                entity.HasKey(e => e.PaymentLineItemId)
                    .HasName("PK_PaymentLineItems");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentLineItems)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PaymentLineItems_Payments");
            });


        }
    }
}
