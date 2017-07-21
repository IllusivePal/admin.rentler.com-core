using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class ContactInfoMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactInfo>(entity =>
            {
                entity.HasKey(e => e.ContactInfoId)
                    .HasName("PK_ContactInfoes");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.IsAcceptTextMessages).HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("0");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactInfoes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo_ContactInfoes_dbo_Users_UserId");
            });

        }
    }
}
