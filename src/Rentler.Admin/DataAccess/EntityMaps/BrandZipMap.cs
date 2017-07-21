using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class BrandZipMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandZip>(entity =>
            {
                entity.HasKey(e => e.BrandZipId)
                    .HasName("PK_BrandZips");

                entity.HasOne(d => d.BrandService)
                    .WithMany(p => p.BrandZips)
                    .HasForeignKey(d => d.BrandServiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BrandZips_BrandServices");
            });

        }
    }
}
