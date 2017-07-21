using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class FormProviderMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FormProvider>(entity =>
            {
                entity.HasKey(e => e.FormProviderId)
                    .HasName("PK_FormProviders");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.OfficeAddress).HasMaxLength(250);

                entity.Property(e => e.OfficeCity).HasMaxLength(250);

                entity.Property(e => e.OfficeState).HasMaxLength(50);

                entity.Property(e => e.OfficeZip).HasMaxLength(10);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PhotoUrl).HasMaxLength(250);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");
            });

        }
    }
}
