using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class ZipInfoMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ZipInfo>(entity =>
            {
                entity.HasKey(e => e.ZipInfoId)
                    .HasName("PK_ZipInfoes");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CityAliasName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(4);
            });


        }
    }
}
