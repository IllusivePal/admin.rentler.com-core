using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;


namespace Rentler.Admin.DataAccess
{
    public class LocalServiceZipMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocalServiceZip>(entity =>
            {
                entity.HasKey(e => e.LocalServiceZipId)
                    .HasName("PK_LocalServiceZips");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.LocalService)
                    .WithMany(p => p.LocalServiceZips)
                    .HasForeignKey(d => d.LocalServiceId)
                    .HasConstraintName("FK_LocalServiceZips_LocalServices");
            });

        }
    }
}
