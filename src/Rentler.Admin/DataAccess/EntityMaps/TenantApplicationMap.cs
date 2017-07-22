using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class TenantApplicationMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TenantApplication>(entity =>
            {
                entity.HasKey(e => e.TenantApplicationId)
                    .HasName("PK_TenantApplications");

                entity.Property(e => e.BackgroundRequestDateUtc).HasColumnType("datetime");

                entity.Property(e => e.BackgroundResult).HasMaxLength(100);

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.CreditRequestDateUtc).HasColumnType("datetime");

                entity.Property(e => e.CreditResult).HasMaxLength(100);

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.TenantApplications)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_TenantApplications_dbo_Buildings_BuildingId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TenantApplications)
                    .HasForeignKey(d => d.TenantUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_TenantApplications_dbo_Users_UserId");
            });


        }
    }
}
