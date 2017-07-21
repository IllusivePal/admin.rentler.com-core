using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;


namespace Rentler.Admin.DataAccess
{
    public class MerchantAccountMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MerchantAccount>(entity =>
            {
                entity.Property(e => e.AccountLast4).HasMaxLength(10);

                entity.Property(e => e.RentMoolaACHResourceId)
                    .HasColumnName("ACHResourceId")
                    .HasMaxLength(50);

                entity.Property(e => e.RentMoolaCashResourceId).HasMaxLength(50);

                entity.Property(e => e.RentMoolaCCResourceId)
                    .HasColumnName("CCResourceId")
                    .HasMaxLength(50);

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentCapAmount)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("15000");

                entity.HasOne(d => d.LegalEntity)
                    .WithMany(p => p.MerchantAccounts)
                    .HasForeignKey(d => d.LegalEntityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MerchantAccounts_LegalEntities");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MerchantAccounts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MerchantAccounts_Users");
            });

        }
    }
}
