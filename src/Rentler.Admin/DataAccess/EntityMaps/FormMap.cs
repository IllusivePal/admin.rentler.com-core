using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class FormMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>(entity =>
            {
                entity.HasKey(e => e.FormId)
                    .HasName("PK_Forms");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.LargeThumbnailUrl).HasMaxLength(250);

                entity.Property(e => e.PreviewProviderId).HasMaxLength(250);

                entity.Property(e => e.SmallThumbnailUrl).HasMaxLength(250);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.FormCategory)
                    .WithMany(p => p.Forms)
                    .HasForeignKey(d => d.FormCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forms_FormCategoires_FormCategoryId");

                entity.HasOne(d => d.FormProvider)
                    .WithMany(p => p.Forms)
                    .HasForeignKey(d => d.FormProviderId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

        }
    }
}
