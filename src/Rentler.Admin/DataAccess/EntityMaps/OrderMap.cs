using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class OrderMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK_Orders");

                entity.Property(e => e.CardId).HasMaxLength(30);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrderSubTotal).HasColumnType("decimal");

                entity.Property(e => e.OrderTotal).HasColumnType("decimal");

                entity.Property(e => e.PromoCodeId).HasMaxLength(100);

                entity.Property(e => e.PromoDiscountTotal).HasColumnType("decimal");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.BuildingId)
                    .HasConstraintName("FK_dbo_Orders_dbo_Buildings_BuildingId");

                entity.HasOne(d => d.PromoCode)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PromoCodeId)
                    .HasConstraintName("FK_dbo_Orders_dbo_PromoCodes_PromoCodeId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo_Orders_dbo_Users_UserId");
            });


        }

    }
}
