using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class PhotoMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Photo>(entity =>
            {
                entity.HasKey(e => e.PhotoId)
                    .HasName("PK_Photos");

                entity.Property(e => e.PhotoId).ValueGeneratedNever();

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_Photos_dbo_Buildings_BuildingId");
            });


        }
    }
}
