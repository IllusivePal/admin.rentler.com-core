using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class ApiKeyMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApiKey>(entity =>
            {
                entity.HasKey(e => e.ApiKeyId)
                    .HasName("PK_ApiKeys");

                entity.Property(e => e.ApiKeyId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(40);
            });
        }
    }
}
