using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class BrandMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("PK_Brands");

                entity.Property(e => e.IsNational).HasDefaultValueSql("0");

                entity.Property(e => e.LogoUrl).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.SiteUrl)
                    .IsRequired()
                    .HasMaxLength(250);
            });

        }
    }
}
