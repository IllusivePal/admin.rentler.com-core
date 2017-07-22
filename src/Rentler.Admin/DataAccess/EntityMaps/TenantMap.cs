using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class TenantMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tenant>(entity =>
            {
                entity.HasKey(e => e.TenantId)
                    .HasName("PK_Tenants");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InviteKey).HasDefaultValueSql("newid()");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("0");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.HasOne(d => d.Lease)
                    .WithMany(p => p.Tenants)
                    .HasForeignKey(d => d.LeaseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Tenants_Leases");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tenants)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Tenants_Users");
            });


        }
    }
}
