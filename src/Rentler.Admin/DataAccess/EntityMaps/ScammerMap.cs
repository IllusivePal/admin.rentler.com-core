using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class ScammerMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Scammer>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_Scammers");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Scammer)
                    .HasForeignKey<Scammer>(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Scammers_Users");
            });


        }
    }
}
