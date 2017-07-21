using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class PaymentMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK_Payments");

                entity.Property(e => e.DueDateUtc).HasColumnType("datetime");

                entity.Property(e => e.IsPastDueReminderSent).HasDefaultValueSql("0");

                entity.Property(e => e.IsPaymentReminderSent).HasDefaultValueSql("0");

                entity.Property(e => e.IsProrated).HasDefaultValueSql("0");

                entity.HasOne(d => d.PaymentSeries)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentSeriesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Payments_PaymentSeries");
            });


        }
    }
}
