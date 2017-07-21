using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class LegalEntityMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LegalEntity>(entity =>
            {
                entity.Property(e => e.ResourceId).HasMaxLength(50);

                entity.Property(e => e.ResourceUrl).HasMaxLength(2083);

                entity.Property(e => e.StatusCode).HasDefaultValueSql("0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LegalEntities)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LegalEntities_Users");
            });

        }
    }
}
