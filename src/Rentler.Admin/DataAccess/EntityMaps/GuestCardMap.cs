using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;


namespace Rentler.Admin.DataAccess
{
    public class GuestCardMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuestCard>(entity =>
            {
                entity.HasKey(e => e.GuestCardId)
                    .HasName("PK_GuestCards");

                entity.Property(e => e.Comments).HasMaxLength(3000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.ListingId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MoveInDate).HasMaxLength(250);

                entity.Property(e => e.Phone).HasMaxLength(250);
            });

        }
    }
}
