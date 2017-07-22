using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;
namespace Rentler.Admin.DataAccess
{
    public class SavedBuildingMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SavedBuilding>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.BuildingId })
                    .HasName("PK_SavedBuildings");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.SavedBuildings)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_dbo_SavedBuildings_dbo_Buildings_BuildingId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SavedBuildings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo_SavedBuildings_dbo_Users_UserId");
            });


        }

    }
}
