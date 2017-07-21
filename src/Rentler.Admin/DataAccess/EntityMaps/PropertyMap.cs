using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;


namespace Rentler.Admin.DataAccess
{
    public class PropertyMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasKey(e => e.PropertyId)
                    .HasName("PK_Properties");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Address2).HasMaxLength(250);

                entity.Property(e => e.ApplicationActivityDateUtc).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.FullHash)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.IsApplicationsEnabled).HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("0");

                entity.Property(e => e.IsScreeningRequired).HasDefaultValueSql("0");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StreetHash)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.ThumbnailUrl).HasMaxLength(2083);

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Properties_Users");
            });


        }
    }
}
