using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class RoleMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RoleName)
                    .HasName("PK_Roles");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(160);
            });


        }
    }
}
