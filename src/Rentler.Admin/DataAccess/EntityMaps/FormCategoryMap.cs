using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class FormCategoryMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FormCategory>(entity =>
            {
                entity.HasKey(e => e.FormCategoryId)
                    .HasName("PK_FormCategories");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Order).HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");
            });

        }

    }
}
