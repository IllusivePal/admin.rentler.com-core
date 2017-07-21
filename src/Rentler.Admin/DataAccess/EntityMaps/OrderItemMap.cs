using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class OrderItemMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => e.OrderItemId)
                    .HasName("PK_OrderItems");

                entity.Property(e => e.Price).HasColumnType("decimal");

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProductOption).HasMaxLength(100);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_OrderItems_dbo_Orders_OrderId");
            });


        }
    }
}
