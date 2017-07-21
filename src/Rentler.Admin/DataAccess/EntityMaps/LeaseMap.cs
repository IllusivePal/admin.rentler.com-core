using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class LeaseMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lease>(entity =>
            {
                entity.HasKey(e => e.LeaseId)
                    .HasName("PK_Leases");

                entity.Property(e => e.EndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("0");

                entity.Property(e => e.StartDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Unit).HasMaxLength(20);

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Leases)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Leases_Properties");
            });

        }
    }
}
