using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class BrandServiceMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandService>(entity =>
            {
                entity.HasKey(e => e.BrandServiceId)
                    .HasName("PK_BrandServices");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.BrandServices)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BrandServices_Brands");
            });

        }
    }
}
