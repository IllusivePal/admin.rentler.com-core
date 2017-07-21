using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class PromoCodeMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PromoCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_PromoCodes");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.EndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.MinimumOrderPrice).HasColumnType("decimal");

                entity.Property(e => e.MoneyLeft).HasColumnType("decimal");

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.StartDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PromoCodes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_PromoCodes_dbo_Users_UserId");
            });


        }
    }
}
