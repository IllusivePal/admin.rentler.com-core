using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class UserNoteMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserNote>(entity =>
            {
                entity.HasKey(e => e.UserNoteId)
                    .HasName("PK_UserNotes");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserNotes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserNotes_Users");
            });


        }
    }
}
