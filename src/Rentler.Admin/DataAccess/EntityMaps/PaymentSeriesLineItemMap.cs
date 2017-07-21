using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class PaymentSeriesLineItemMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentSeriesLineItem>(entity =>
            {
                entity.HasKey(e => e.PaymentSeriesLineItemId)
                    .HasName("PK_PaymentSeriesLineItems");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.PaymentSeries)
                    .WithMany(p => p.PaymentSeriesLineItems)
                    .HasForeignKey(d => d.PaymentSeriesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PaymentSeriesLineItems_PaymentSeries");
            });


        }
    }
}
