using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class CommunityPhotoMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommunityPhoto>(entity =>
            {
                entity.HasKey(e => e.CommunityPhotoId)
                    .HasName("PK_CommunityPhotos");

                entity.Property(e => e.CommunityPhotoId).ValueGeneratedNever();

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.CommunityPhotos)
                    .HasForeignKey(d => d.CommunityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommunityPhotos_Communities");
            });

        }

    }
}
