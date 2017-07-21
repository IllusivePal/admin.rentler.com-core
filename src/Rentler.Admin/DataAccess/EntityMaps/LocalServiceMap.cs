using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class LocalServiceMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocalService>(entity =>
            {
                entity.HasKey(e => e.LocalServiceId)
                    .HasName("PK_LocalServices");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.LogoUrl).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(250);
            });

        }
    }
}
